using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.WinForms.UI.Shared.Forms;
using System.ComponentModel;
using System.Text.RegularExpressions;

namespace ContactManager.WinForms
{
    public partial class EmployeePage : UserControl
    {
        private readonly IEmployeeService? _employeeService = null!;
        private readonly IEmployeeRepository? _employeeRepo = null!;
        private readonly IContactHistoryRepository _contactHistoryRepo = null!;

        private List<Employee> _cache = new();

        public EmployeePage()
        {
            InitializeComponent();

            txtSearch.TextChanged += (_, __) => ApplyFilter();
            txtSearch.KeyDown += (s, ev) => { if (ev.KeyCode == Keys.Escape) { txtSearch.Clear(); ev.SuppressKeyPress = true; } };
        }

        public EmployeePage(IEmployeeService employeeService, IEmployeeRepository repo, IContactHistoryRepository contactHistoryRepo) : this()
        {
            _employeeService = employeeService;
            _employeeRepo = repo;
            _contactHistoryRepo = contactHistoryRepo;

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _ = ReloadAsync();
        }

        private async void btnNewEmployee_Click(object sender, EventArgs e)
        {
            using var dlg = new EmployeeDetailForm(_employeeService);
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                await ReloadAsync();

        }

        private async Task ReloadAsync()
        {
            if (_employeeRepo == null) return;
            _cache = (await _employeeRepo.GetAllAsync()).ToList();
            ApplyFilter();

        }

        private void ApplyFilter()
        {
            string q = (txtSearch.Text ?? "").Trim();

            lvEmployees.BeginUpdate();
            lvEmployees.Items.Clear();

            foreach (var employee in _cache)
            {
                string hay = $"{employee.FirstName} {employee.LastName} {employee.Email} " +
                             $"{employee.PhoneNumberMobile} {employee.PhoneNumberBusiness} {employee.PhoneNumberPrivate}";

                bool matchesFreeText = q.Length == 0 ||
                                       hay.IndexOf(q, StringComparison.OrdinalIgnoreCase) >= 0;

                bool matchesPhone = PhoneMatches(employee.PhoneNumberMobile, q)
                                  || PhoneMatches(employee.PhoneNumberBusiness, q)
                                  || PhoneMatches(employee.PhoneNumberPrivate, q);

                if (matchesFreeText || matchesPhone)
                {
                    var it = new ListViewItem(employee.EmployeeNumber.ToString());
                    it.SubItems.Add($"{employee.FirstName} {employee.LastName}".Trim());
                    it.SubItems.Add(employee.DateOfBirth?.ToString("d") ?? "");
                    it.SubItems.Add(employee.Role ?? "");
                    it.SubItems.Add(employee.Department ?? "");
                    it.SubItems.Add(employee.Status ? "Aktiv" : "Inaktiv");
                    it.Tag = employee;
                    lvEmployees.Items.Add(it);
                }
            }

            lvEmployees.EndUpdate();
        }

        private async void lvEmployees_DoubleClick(object sender, EventArgs e)
        {

            if (lvEmployees.SelectedItems.Count == 0) return;
            var selected = (Employee)lvEmployees.SelectedItems[0].Tag!;

            using var dlg = new EmployeeDetailForm(_employeeService, selected);
            if (dlg.ShowDialog(FindForm()) == DialogResult.OK)
                await ReloadAsync();

        }


        private async void lvEmployees_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || lvEmployees.SelectedItems.Count == 0) return;

            var employee = (Employee)lvEmployees.SelectedItems[0].Tag!;
            if (MessageBox.Show($"„Möchten Sie {employee.FirstName} {employee.LastName}“ wirklich löschen?",
                    "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await _employeeService.DeleteAsync(employee); // service handles persistence
                await ReloadAsync();
            }
        }

        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (LicenseManager.UsageMode == LicenseUsageMode.Designtime) return;

            if (Visible && IsHandleCreated && _employeeRepo != null)
                await ReloadAsync();
        }

        private void cmsEmployee_Opening(object sender, CancelEventArgs e)
        {
            bool hasSel = lvEmployees.SelectedItems.Count > 0;
            miHistory.Enabled = hasSel && _contactHistoryRepo != null;
            if (!hasSel) e.Cancel = true;

        }

        private void miHistory_Click(object sender, EventArgs e)
        {
            if (_contactHistoryRepo == null) { MessageBox.Show("History-Repository fehlt."); return; }
            if (lvEmployees.SelectedItems.Count == 0) return;

            
            var person = (Person)lvEmployees.SelectedItems[0].Tag!;

            using var dlg = new ContactHistoryForm(person.Id, $"{person.FirstName} {person.LastName}".Trim(), _contactHistoryRepo);
            dlg.ShowDialog(FindForm());
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

    }
}
