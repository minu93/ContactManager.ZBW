using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.WinForms.UI.Shared.Forms;
using System.ComponentModel;
using System.Globalization;
using System.Text.RegularExpressions;


namespace ContactManager.WinForms
{
    public partial class CustomersPage : UserControl
    {
        private readonly ICustomerService _customerService;               
        private readonly ICustomerRepository _customerRepo;

        private readonly ICustomerNoteService? _customerNoteService;
        private readonly ICustomerNoteRepository? _customerNoteRepo;
        private readonly IContactHistoryRepository? _contactHistoryRepo;

        private List<Customer> _cache = new();

        public CustomersPage() { InitializeComponent(); }

        public CustomersPage(ICustomerService cutomerService,
                             ICustomerRepository customerRepo,
                             ICustomerNoteService? customerNoteService,
                             ICustomerNoteRepository? customerNoteRepo,
                             IContactHistoryRepository? contactHistoryRepo) : this()
        {
            _customerService = cutomerService;
            _customerRepo = customerRepo;
            _customerNoteService = customerNoteService;
            _customerNoteRepo = customerNoteRepo;
            _contactHistoryRepo = contactHistoryRepo;

            txtSearch.TextChanged += (_, __) => ApplyFilter();
            txtSearch.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Escape) { txtSearch.Clear(); ev.SuppressKeyPress = true; } };
        }

        private void CustomersPage_Load(object sender, EventArgs e)
        {
            lvCustomers.DoubleClick += lvCustomers_DoubleClick;
            lvCustomers.KeyDown += lvCustomers_KeyDown;
            btnNewCustomer.Click += btnNewCustomer_Click;
            _ = ReloadAsync();
        }

        public async Task ReloadAsync()
        {
            _cache = (await _customerRepo.GetAllAsync()).ToList(); // read only
            ApplyFilter();
        }

        private void ApplyFilter()
        {
            string q = (txtSearch.Text ?? "").Trim();
            var culture = CultureInfo.CurrentCulture;

            bool qIsDate = DateTime.TryParse(q, culture, DateTimeStyles.None, out var qDate);

            lvCustomers.BeginUpdate();
            lvCustomers.Items.Clear();

            foreach (var c in _cache)
            {
                string hay = $"{c.FirstName} {c.LastName} {c.Email} " +
                             $"{c.PhoneNumberMobile} {c.PhoneNumberBusiness} {c.PhoneNumberPrivate}";

                // DOB tokens
                string[] dobTokens = Array.Empty<string>();
                if (c.DateOfBirth.HasValue)
                {
                    var d = c.DateOfBirth.Value.Date;
                    dobTokens = new[]
                    {
                d.ToString("d", culture),
                d.ToString("dd.MM.yyyy"),
                d.ToString("d.M.yyyy"),
                d.ToString("yyyy-MM-dd"),
                d.ToString("MM.yyyy"),
                d.ToString("yyyy")
            };
                }

                bool matchesFreeText =
                    q.Length == 0 ||
                    hay.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0 ||
                    dobTokens.Any(t => t.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0);

                bool matchesExactDate = qIsDate &&
                                        c.DateOfBirth.HasValue &&
                                        c.DateOfBirth.Value.Date == qDate.Date;

                bool matchesPhone =
                    PhoneMatches(c.PhoneNumberMobile, q) ||
                    PhoneMatches(c.PhoneNumberBusiness, q) ||
                    PhoneMatches(c.PhoneNumberPrivate, q);

                if (matchesFreeText || matchesExactDate || matchesPhone)
                {
                    var it = new ListViewItem($"{c.FirstName} {c.LastName}".Trim());
                    it.SubItems.Add(c.Status ? "Aktiv" : "Inaktiv");
                    it.SubItems.Add(c.Email ?? "");
                    it.SubItems.Add(c.PhoneNumberMobile ?? c.PhoneNumberBusiness ?? c.PhoneNumberPrivate ?? "");
                    it.SubItems.Add(c.DateOfBirth?.ToString("d", culture) ?? "");
                    it.Tag = c;
                    lvCustomers.Items.Add(it);
                }
            }

            lvCustomers.EndUpdate();
        }

        private static string DigitsOnly(string? s)
        {
            if (string.IsNullOrEmpty(s)) return "";
            return Regex.Replace(s, @"\D", "");
        }

        private static string CanonCH(string digits)
        {
            if (string.IsNullOrEmpty(digits)) return "";
            if (digits.StartsWith("00")) digits = digits[2..];
            if (digits.StartsWith("0")) digits = "41" + digits[1..];
            return digits;
        }

        private static bool PhoneMatches(string? phone, string q)
        {
            if (string.IsNullOrWhiteSpace(phone) || string.IsNullOrWhiteSpace(q)) return false;

            var pDigits = DigitsOnly(phone);
            var qDigits = DigitsOnly(q);


            if (qDigits.Length == 0) return false;


            if (pDigits.Contains(qDigits)) return true;

            var pCanon = CanonCH(pDigits);
            var qCanon = CanonCH(qDigits);
            return pCanon.Contains(qCanon);
        }


        private async void btnNewCustomer_Click(object? sender, EventArgs e)
        {
            using var dlg = new CustomerDetailForm(_customerService, _customerNoteService, _customerNoteRepo!); 
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                await ReloadAsync(); 
        }

        private async void lvCustomers_DoubleClick(object? sender, EventArgs e)
        {
            if (lvCustomers.SelectedItems.Count == 0) return;
            var c = (Customer)lvCustomers.SelectedItems[0].Tag!;

            using var dlg = new CustomerDetailForm(_customerService,_customerNoteService, _customerNoteRepo!, c); 
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                await ReloadAsync(); 
        }

        private async void lvCustomers_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || lvCustomers.SelectedItems.Count == 0) return;
            var c = (Customer)lvCustomers.SelectedItems[0].Tag!;
            if (MessageBox.Show($"„{c.FirstName} {c.LastName}“ löschen?",
                "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await _customerService.DeleteAsync(c);
                await ReloadAsync();
            }
        }

        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;
            if (Visible && IsHandleCreated) await ReloadAsync();
        }

        private void cmsCustomers_Opening(object sender, CancelEventArgs e)
        {
            bool hasSel = lvCustomers.SelectedItems.Count > 0;
            miHistory.Enabled = hasSel && _contactHistoryRepo != null;
            if (!hasSel) e.Cancel = true;
        }

        private void miHistory_Click(object sender, EventArgs e)
        {
            if (_contactHistoryRepo == null) { MessageBox.Show("History-Repository fehlt."); return; }
            if (lvCustomers.SelectedItems.Count == 0) return;

            var c = (Customer)lvCustomers.SelectedItems[0].Tag!;
            using var dlg = new ContactHistoryForm(c.Id, $"{c.FirstName} {c.LastName}".Trim(), _contactHistoryRepo);
            dlg.ShowDialog(FindForm());
        }
    }
}
