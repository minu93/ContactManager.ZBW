using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using System.Data;


namespace ContactManager.WinForms.UI.App.Pages
{
    public partial class DashboardPage : UserControl
    {
        private readonly ICustomerRepository _customerRepo = null!;
        private readonly IEmployeeRepository _employeeRepo = null!;
        private readonly ICustomerNoteRepository _noteRepo = null!;

        public DashboardPage()
        {
            InitializeComponent();
            this.Load += DashboardPage_Load;

        }
        public DashboardPage(ICustomerRepository customerRepo,
                     IEmployeeRepository employeeRepo,
                     ICustomerNoteRepository noteRepo) : this()
        {
            _customerRepo = customerRepo;
            _employeeRepo = employeeRepo;
            _noteRepo = noteRepo;
        }

        private async void DashboardPage_Load(object? sender, EventArgs e)
        {
            if (!IsHandleCreated) return;
            await RefreshAsync();
        }
        protected override async void OnVisibleChanged(EventArgs e)
        {
            base.OnVisibleChanged(e);
            if (Visible && IsHandleCreated)
                await RefreshAsync();
        }

        private async Task RefreshAsync()
        {
            // Load in parallel
            var tCust = _customerRepo.GetAllAsync();
            var tEmp = _employeeRepo.GetAllAsync();
            var tNotes = _noteRepo.GetAllAsync();

            var customers = (await tCust).ToList();
            var employees = (await tEmp).ToList();
            var notes = (await tNotes).ToList();

            var now = DateTime.Now;

            // --- top cards ---
            int custTotal = customers.Count;
            int custInactive = customers.Count(c => !c.Status);

            int empTotal = employees.Count;
            int trainees = employees.OfType<Trainee>().Count();

            int notesMonth = notes.Count(n => n.CreatedAt.Year == now.Year && n.CreatedAt.Month == now.Month);
            int notes7d = notes.Count(n => n.CreatedAt >= now.AddDays(-7));

            lblCustomersCount.Text = custTotal.ToString();
            lblCustomersSub.Text = $"{custInactive} inaktiv";

            lblEmployeesCount.Text = empTotal.ToString();
            lblEmployeesSub.Text = $"inkl. {trainees} Trainees";

            lblNotesCount.Text = notesMonth.ToString();
            lblNotesSub.Text = "diesen Monat";

            lblActivityCount.Text = notes7d.ToString();
            lblActivitySub.Text = "Notizen (7 Tage)";

            // --- birthdays ---
            var bdays = customers
                .Where(p => p.DateOfBirth.HasValue && p.DateOfBirth.Value.Month == now.Month)
                .OrderBy(p => p.DateOfBirth!.Value.Day)
                .Select(p => $"{p.DateOfBirth!.Value:dd}. {p.FirstName} {p.LastName}")
                .ToList();

            lbBirthdays.Items.Clear();
            if (bdays.Count == 0)
            {
                lbBirthdays.Items.Add("Keine Geburtstage diesen Monat");
            }
            else
            {
                foreach (var s in bdays) lbBirthdays.Items.Add(s);
            }

            // --- hints ---
            lbHints.Items.Clear();
            if (custInactive > 0) lbHints.Items.Add($"⚠ {custInactive} inaktive Kontakte – regelmässig prüfen");
            if (bdays.Count == 0) lbHints.Items.Add("ℹ Keine Geburtstage diesen Monat");
            if (notes7d >= 4) lbHints.Items.Add("📈 Gute Aktivität in der Kontaktverwaltung (letzte 7 Tage)");
            lbHints.Items.Add("✅ Daten werden automatisch gespeichert");
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
