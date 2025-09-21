using ContactManager.Application.Abstractions;
using ContactManager.WinForms;
using ContactManager.WinForms.UI.App.Pages;


namespace ContactManagerTest
{
    public partial class FormMain : Form
    {
        private readonly ICustomerService? _customerService = null!;
        private readonly ICustomerRepository? _customerRepo = null!;

        private readonly ICustomerNoteService? _customerNoteService = null!;
        private readonly ICustomerNoteRepository? _customerNoteRepo = null!;

        private readonly IEmployeeService? _employeeService = null!;
        private readonly IEmployeeRepository? _employeeRepo = null!;
        private readonly IContactHistoryRepository? _historyRepo = null!;


        private Button[] _navButtons = Array.Empty<Button>();
        private Button _activeButton = null!;

        private DashboardPage? _dashboardPage;
        private CustomersPage? _customerPage;
        private EmployeePage? _employeePage;
        private SettingPage? _settingPage;


        public FormMain()
        {

            InitializeComponent();
        }
        public FormMain(ICustomerService customerService, ICustomerRepository repo, ICustomerNoteService customerNoteService, ICustomerNoteRepository noteRepo, IEmployeeService employeeService, IEmployeeRepository employeeRepo, IContactHistoryRepository? historyRepo) : this()
        {
            _customerService = customerService;
            _customerRepo = repo;
            _customerNoteService = customerNoteService;
            _customerNoteRepo = noteRepo;

            _employeeService = employeeService;
            _employeeRepo = employeeRepo;
            
            _historyRepo = historyRepo;

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            // Map buttons to pages
            btnDashboard.Tag = tabDashboard;
            btnCustomer.Tag = tabCustomer;
            btnEmployee.Tag = tabEmployee;
            btnSettings.Tag = tabSettings;

            // Register your nav buttons in a fixed list (container-agnostic)
            _navButtons = new[] { btnDashboard, btnCustomer, btnEmployee, btnSettings };

            // Ensure consistent baseline style
            foreach (var b in _navButtons)
            {
                b.FlatStyle = FlatStyle.Flat;
                b.UseVisualStyleBackColor = false; 
                SetInactive(b);
            }

            //mount the Pages
            _dashboardPage = new DashboardPage(_customerRepo!, _employeeRepo!, _customerNoteRepo!);
            _dashboardPage.Dock = DockStyle.Fill;
            tabDashboard.Controls.Add(_dashboardPage);


            _customerPage = new CustomersPage(_customerService,  _customerRepo!,_customerNoteService,  _customerNoteRepo!, _historyRepo!);
            _customerPage.Dock = DockStyle.Fill;
            tabCustomer.Controls.Add(_customerPage);

            _employeePage = new EmployeePage(_employeeService!, _employeeRepo!, _historyRepo!);
            _employeePage.Dock = DockStyle.Fill;
            tabEmployee.Controls.Add(_employeePage);


            _settingPage = new SettingPage(_customerRepo!, _employeeRepo!);
            _settingPage.Dock = DockStyle.Fill;
            tabSettings.Controls.Add(_settingPage);


            // Start on Dashboard
            SelectTab(btnDashboard);


        }

        private void Nav_Click(object sender, EventArgs e)
        {
            if (sender is Button btn)
                SelectTab(btn);
        }

        private void SelectTab(Button btn)
        {
            if (btn.Tag is TabPage page)
            {
                tabMain.SelectedTab = page;

                // Un-highlight previous
                if (_activeButton != null && _activeButton != btn)
                    SetInactive(_activeButton);

                // Highlight current
                SetActive(btn);
                _activeButton = btn;
            }
        }

        private static void SetInactive(Button b)
        {
            b.BackColor = SystemColors.Control;
            b.ForeColor = SystemColors.ControlText;
            b.FlatAppearance.BorderSize = 1;
        }

        private static void SetActive(Button b)
        {
            b.BackColor = SystemColors.Highlight;
            b.ForeColor = SystemColors.HighlightText;
            b.FlatAppearance.BorderSize = 0;
        }


    }
}
