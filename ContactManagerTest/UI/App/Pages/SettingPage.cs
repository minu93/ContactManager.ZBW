using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using Microsoft.VisualBasic.FileIO;
using System.Globalization;
using System.Text;


namespace ContactManager.WinForms
{
    public partial class SettingPage : UserControl
    {
        /*
         [] TODO: Refactor this mess create service for import / example data !
        */
        private readonly ICustomerRepository _customerRepo = null!;
        private readonly IEmployeeRepository _employeeRepo = null!;

        public SettingPage()
        {
            InitializeComponent();

        }

        public SettingPage(ICustomerRepository customerRepo, IEmployeeRepository employeeRepo) : this()
        {
            _customerRepo = customerRepo ?? throw new ArgumentNullException(nameof(customerRepo));
            _employeeRepo = employeeRepo ?? throw new ArgumentNullException(nameof(employeeRepo));
        }


        private void SettingPage_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "";
        }

        private void pnlDrop_Paint(object sender, PaintEventArgs e)
        {

            // dashed border
            var r = pnlDrop.ClientRectangle; r.Inflate(-4, -4);
            using var pen = new System.Drawing.Pen(SystemColors.ScrollBar) { DashStyle = System.Drawing.Drawing2D.DashStyle.Dash };
            e.Graphics.DrawRectangle(pen, r);
            // center text/icon hint (optional)
            var txt = "Datei zum Importieren auswählen\nCSV oder vCard (.vcf) Dateien\noder Datei hier ablegen";
            var fmt = new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            e.Graphics.DrawString(txt, Font, SystemBrushes.GrayText, r, fmt);

        }


        private void pnlDrop_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) == true)
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop)!;
                if (files.Any(IsSupported))
                    e.Effect = DragDropEffects.Copy;
            }
        }

        private async void pnlDrop_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data?.GetDataPresent(DataFormats.FileDrop) != true) return;
            var files = ((string[])e.Data.GetData(DataFormats.FileDrop)!).Where(IsSupported).ToArray();
            if (files.Length == 0) return;
            await ImportAsync(files[0]);   // single file for now
        }

        private async void btnChooseFile_Click(object sender, EventArgs e)
        {
            using var ofd = new OpenFileDialog
            {
                Title = "Datei zum Importieren auswählen",
                Filter = "CSV (*.csv)|*.csv|vCard (*.vcf;*.vcard)|*.vcf;*.vcard|Alle Dateien (*.*)|*.*",
                Multiselect = false
            };
            if (ofd.ShowDialog(FindForm()) == DialogResult.OK)
                await ImportAsync(ofd.FileName);

        }

        private void btnDownloadSample_Click(object sender, EventArgs e)
        {
            using var sfd = new SaveFileDialog
            {
                Title = "Beispiel-CSV speichern",
                FileName = "contacts_sample.csv",
                Filter = "CSV (*.csv)|*.csv"
            };
            if (sfd.ShowDialog(FindForm()) == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, BuildSampleCsv());
                lblStatus.Text = $"Beispiel gespeichert: {sfd.FileName}";
            }

        }


        private bool IsSupported(string path)
        {
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return ext == ".csv" || ext == ".vcf" || ext == ".vcard";
        }
        private async Task ImportAsync(string path)
        {
            try
            {
                var ext = Path.GetExtension(path).ToLowerInvariant();

                List<Customer> customers = new();

                List<Employee> employees = new();

                if (ext == ".csv")
                {
                    (customers, employees) = ParseCsvAll(path);
                }

                else if (ext == ".vcf" || ext == ".vcard")
                {
                    // vCard kann keinen Typ unterscheiden -> als Customer importieren
                    customers = ParseVCard(path);
                }
                else
                {
                    lblStatus.Text = "Nicht unterstütztes Format.";
                    return;
                }

                int count = 0;

                foreach (var customer in customers)
                {
                    // instead of looping we can also implement a bluk but there is no time for that shit !!! 
                    await _customerRepo.AddAsync(customer);
                    count++;
                }

                foreach (var employee in employees)
                {
                    await _employeeRepo.AddAsync(employee);
                    count++;
                }

                lblStatus.Text = $"Import abgeschlossen: {count} Kontakt(e).";


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Import fehlgeschlagen:\n{ex.Message}", "Import", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private static (List<Customer> customers, List<Employee> employees) ParseCsvAll(string path)
        {
            var customers = new List<Customer>();
            var employees = new List<Employee>();

            using var parser = new TextFieldParser(path, Encoding.UTF8)
            {
                TextFieldType = FieldType.Delimited,
                HasFieldsEnclosedInQuotes = true
            };
            parser.SetDelimiters(",");

            if (parser.EndOfData) return (customers, employees);

            // Header -> Dictionary (case-insensitive)
            var header = parser.ReadFields() ?? Array.Empty<string>();
            var cols = header.Select((h, i) => new { h = (h ?? "").Trim(), i })
                             .ToDictionary(x => x.h.ToLowerInvariant(), x => x.i);

            string?[] row;
            while (!parser.EndOfData && (row = parser.ReadFields()!) != null)
            {
                string Get(string name) =>
                    cols.TryGetValue(name.ToLowerInvariant(), out var idx) && idx < row.Length
                        ? (row[idx] ?? "").Trim() : "";

                // ---- gemeinsame Felder (Person) ----
                string type = Get("type");               // Customer | Employee | Trainee
                string firstName = Get("firstname");
                string lastName = Get("lastname");

                if (string.IsNullOrWhiteSpace(firstName) && string.IsNullOrWhiteSpace(lastName))
                    continue; // leere Zeile überspringen

                var p = new Person // nur temporär, um Felder zu sammeln
                {
                    Salutation = NullIfEmpty(Get("salutation")),
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = TryDate(Get("dateofbirth")),
                    Gender = ParseGender(Get("gender")), // M/W, m/w, männlich/weiblich
                    Title = NullIfEmpty(Get("title")),
                    SocialSecurityNumber = NullIfEmpty(Get("socialsecuritynumber")),
                    PhoneNumberPrivate = NullIfEmpty(Get("phoneprivate")),
                    PhoneNumberMobile = NullIfEmpty(Get("phonemobile")),
                    PhoneNumberBusiness = NullIfEmpty(Get("phonebusiness")),
                    Email = NullIfEmpty(Get("email")),
                    Status = ParseBool(Get("status"), true),
                    Nationality = NullIfEmpty(Get("nationality")),
                    Street = NullIfEmpty(Get("street")),
                    StreetNumber = NullIfEmpty(Get("streetnumber")),
                    ZipCode = TryInt(Get("zipcode")),
                    Place = NullIfEmpty(Get("place"))
                };

                // ---- Spezifische Felder pro Typ ----
                switch ((type ?? "Customer").Trim().ToLowerInvariant())
                {
                    case "employee":
                        {
                            var e = new Employee();

                            // Person (common)
                            e.SetSalutation(NullIfEmpty(Get("salutation")));
                            e.SetName(firstName, lastName);
                            e.SetBirthdate(TryDate(Get("dateofbirth")));
                            e.SetGender(ParseGender(Get("gender")));
                            e.SetTitle(NullIfEmpty(Get("title")));
                            e.SetSocialSecurityNumber(NullIfEmpty(Get("socialsecuritynumber")));
                            e.SetPhones(NullIfEmpty(Get("phoneprivate")), NullIfEmpty(Get("phonemobile")), NullIfEmpty(Get("phonebusiness")));
                            e.SetEmail(NullIfEmpty(Get("email")));
                            if (ParseBool(Get("status"), true)) e.Activate(); else e.Deactivate();
                            e.SetAddress(NullIfEmpty(Get("street")), NullIfEmpty(Get("streetnumber")), TryInt(Get("zipcode")), NullIfEmpty(Get("place")), NullIfEmpty(Get("nationality")));

                            e.SetDepartment(NullIfEmpty(Get("department")));
                            var start = TryDate(Get("startdate"));
                            if (start.HasValue) e.SetStartDate(start.Value);             
                            e.SetEndDate(TryDate(Get("enddate")));
                            var pensum = TryInt(Get("employment"));
                            if (pensum.HasValue) e.SetEmployment(pensum.Value);
                            e.SetRole(NullIfEmpty(Get("role")));
                            var cadre = TryInt(Get("cadrelevel"));
                            if (cadre.HasValue) e.SetCadreLevel(cadre.Value);

                            employees.Add(e);
                            break;
                        }
                    case "trainee":
                        {
                            var t = new Trainee();

                            // Person (common)
                            t.SetSalutation(NullIfEmpty(Get("salutation")));
                            t.SetName(firstName, lastName);
                            t.SetBirthdate(TryDate(Get("dateofbirth")));
                            t.SetGender(ParseGender(Get("gender")));
                            t.SetTitle(NullIfEmpty(Get("title")));
                            t.SetSocialSecurityNumber(NullIfEmpty(Get("socialsecuritynumber")));
                            t.SetPhones(NullIfEmpty(Get("phoneprivate")), NullIfEmpty(Get("phonemobile")), NullIfEmpty(Get("phonebusiness")));
                            t.SetEmail(NullIfEmpty(Get("email")));
                            if (ParseBool(Get("status"), true)) t.Activate(); else t.Deactivate();
                            t.SetAddress(NullIfEmpty(Get("street")), NullIfEmpty(Get("streetnumber")), TryInt(Get("zipcode")), NullIfEmpty(Get("place")), NullIfEmpty(Get("nationality")));

                            t.SetDepartment(NullIfEmpty(Get("department")));
                            var start = TryDate(Get("startdate"));
                            if (start.HasValue) t.SetStartDate(start.Value);
                            t.SetEndDate(TryDate(Get("enddate")));
                            var pensum = TryInt(Get("employment"));
                            if (pensum.HasValue) t.SetEmployment(pensum.Value);
                            t.SetRole(NullIfEmpty(Get("role")));
                            var cadre = TryInt(Get("cadrelevel"));
                            if (cadre.HasValue) t.SetCadreLevel(cadre.Value);

                            var totalYears = TryInt(Get("traineeyears"));
                            var currentYear = TryInt(Get("actualtraineeyear"));
                            t.SetTraineePlan(totalYears, currentYear);

                            employees.Add(t);
                            break;
                        }
                    default:
                        {
                            var c = new Customer
                            {
                                Id = Guid.NewGuid(),
                                Salutation = p.Salutation,
                                FirstName = p.FirstName,
                                LastName = p.LastName,
                                DateOfBirth = p.DateOfBirth,
                                Gender = p.Gender,
                                Title = p.Title,
                                SocialSecurityNumber = p.SocialSecurityNumber,
                                PhoneNumberPrivate = p.PhoneNumberPrivate,
                                PhoneNumberMobile = p.PhoneNumberMobile,
                                PhoneNumberBusiness = p.PhoneNumberBusiness,
                                Email = p.Email,
                                Status = p.Status,
                                Nationality = p.Nationality,
                                Street = p.Street,
                                StreetNumber = p.StreetNumber,
                                ZipCode = p.ZipCode,
                                Place = p.Place,

                            };
                            c.SetCompany(NullIfEmpty(Get("companyname")), 
                                NullIfEmpty(Get("companycontact")), 
                                ParseChar(NullIfEmpty(Get("customertype"))));

                            customers.Add(c);
                            break;
                        }
                }
            }

            return (customers, employees);

            // helpers
            static string? NullIfEmpty(string s) => string.IsNullOrWhiteSpace(s) ? null : s.Trim();
            static bool ParseBool(string s, bool dflt)
                => string.IsNullOrWhiteSpace(s) ? dflt :
                   s.Equals("true", StringComparison.OrdinalIgnoreCase) ||
                   s.Equals("1") || s.Equals("ja", StringComparison.OrdinalIgnoreCase);
            static char? ParseChar(string? s) => !string.IsNullOrWhiteSpace(s) ? s![0] : (char?)null;
            static DateTime? TryDate(string s)
                => DateTime.TryParse(s, CultureInfo.InvariantCulture, DateTimeStyles.AssumeLocal, out var d) ? d.Date : (DateTime?)null;
            static int? TryInt(string s)
                => int.TryParse(s, NumberStyles.Integer, CultureInfo.InvariantCulture, out var i) ? i : (int?)null;
            static bool ParseGender(string s)
                => s.StartsWith("m", StringComparison.OrdinalIgnoreCase) || s.Equals("1");
        }




        private static List<Customer> ParseVCard(string path)
        {
            var list = new List<Customer>();
            var lines = File.ReadAllLines(path);
            Customer? current = null;

            foreach (var raw in lines)
            {
                var line = raw.Trim();
                if (line.Equals("BEGIN:VCARD", StringComparison.OrdinalIgnoreCase))
                {
                    current = new Customer { Status = true };
                }
                else if (line.Equals("END:VCARD", StringComparison.OrdinalIgnoreCase))
                {
                    if (current != null && (!string.IsNullOrWhiteSpace(current.FirstName) || !string.IsNullOrWhiteSpace(current.LastName)))
                        list.Add(current);
                    current = null;
                }
                else if (current != null)
                {
                    var idx = line.IndexOf(':');
                    if (idx <= 0) continue;
                    var key = line.Substring(0, idx).ToUpperInvariant();
                    var val = line.Substring(idx + 1);

                    if (key.StartsWith("FN"))
                    {
                        // full name → split naive
                        var parts = val.Split(' ');
                        current.FirstName = parts.FirstOrDefault() ?? "";
                        current.LastName = string.Join(" ", parts.Skip(1));
                    }
                    else if (key == "N")
                    {

                        var parts = val.Split(';');
                        current.LastName = parts.ElementAtOrDefault(0) ?? current.LastName;
                        current.FirstName = parts.ElementAtOrDefault(1) ?? current.FirstName;
                    }
                    else if (key.StartsWith("EMAIL"))
                    {
                        current.Email = val;
                    }
                    else if (key.StartsWith("TEL"))
                    {
                        // pick first TEL as mobile/business
                        if (string.IsNullOrWhiteSpace(current.PhoneNumberMobile))
                            current.PhoneNumberMobile = val;
                        else if (string.IsNullOrWhiteSpace(current.PhoneNumberBusiness))
                            current.PhoneNumberBusiness = val;
                    }
                    else if (key == "BDAY" && DateTime.TryParse(val, out var d))
                    {
                        current.DateOfBirth = d.Date;
                    }
                }
            }
            return list;
        }

        private static string BuildSampleCsv()
        {

            var sb = new StringBuilder();
            sb.AppendLine("Type,Salutation,FirstName,LastName,DateOfBirth,Gender,Title,SocialSecurityNumber,PhonePrivate,PhoneMobile,PhoneBusiness,Email,Status,Nationality,Street,StreetNumber,ZipCode,Place,CompanyName,CustomerType,CompanyContact,EmployeeNumber,Department,StartDate,EndDate,Employment,Role,CadreLevel,TraineeYears,ActualTraineeYear");

            var rnd = new Random(42);

            string[] maleFirst = { "Max", "Lukas", "Noah", "Leon", "David", "Jonas", "Matteo", "Jan", "Fabian", "Nico", "Tom", "Elia", "Sandro", "Tim", "Simon" };
            string[] femaleFirst = { "Anna", "Mia", "Lena", "Lea", "Sofia", "Laura", "Nina", "Sara", "Lina", "Emma", "Julia", "Noemi", "Elena", "Chiara", "Zoe" };
            string[] lastNames = { "Meier", "Müller", "Schneider", "Weber", "Fischer", "Keller", "Huber", "Zimmermann", "Walter", "Brunner", "Baumann", "Graf", "Frei", "Kunz", "Steiner", "Wagner", "Schmid", "Bachmann", "Ammann", "Schütz" };
            (string Zip, string City, string Street)[] places =
            {
                ("8001","Zürich","Seestrasse"),
                ("3011","Bern","Bundesgasse"),
                ("4001","Basel","Rheingasse"),
                ("4051","Basel","Baselstrasse"),
                ("6003","Luzern","Pilatusstrasse"),
                ("9000","St. Gallen","Marktgasse"),
                ("1201","Genf","Rue du Rhône"),
                ("1003","Lausanne","Rue de Bourg"),
                ("4058","Basel","Messeplatz"),
                ("6300","Zug","Baarerstrasse"),
                ("5400","Baden","Bahnhofstrasse"),
                ("7000","Chur","Poststrasse"),
                ("2502","Biel","Bahnhofplatz"),
                ("1700","Fribourg","Rue de Lausanne"),
                ("6900","Lugano","Via Nassa"),
            };
            string[] companies = { "Acme AG", "Contoso GmbH", "Globex AG", "Initech GmbH", "Umbrella AG", "Stark Industries AG", "Wayne Holding", "Helvetia Consulting", "Alpenblick GmbH", "Matterhorn AG" };
            string[] departments = { "IT", "HR", "Finance", "Operations", "Sales", "Marketing" };
            string[] roles = { "Software Engineer", "System Engineer", "HR Specialist", "Accountant", "Operations Manager", "Sales Manager", "Marketing Manager", "Support Engineer" };
            char[] custTypes = { 'A', 'B', 'C' };

            string RandFrom(string[] arr) => arr[rnd.Next(arr.Length)];
            (string Zip, string City, string Street) RandPlace() => places[rnd.Next(places.Length)];
            string RandDigits(int n)
            {
                var s = new char[n];
                for (int i = 0; i < n; i++) s[i] = (char)('0' + rnd.Next(10));
                return new string(s);
            }
            string Ssn() => $"756.{RandDigits(4)}.{RandDigits(4)}.{RandDigits(2)}";
            string Phone() => $"+41 {new[] { "76", "77", "78", "79", "44", "43" }[rnd.Next(6)]} {rnd.Next(100, 1000)} {rnd.Next(10, 100)} {rnd.Next(10, 100)}";
            DateTime RandDob() => new DateTime(rnd.Next(1958, 2006), rnd.Next(1, 13), rnd.Next(1, 28));
            DateTime RandStartDate() => new DateTime(rnd.Next(2012, 2025), rnd.Next(1, 13), rnd.Next(1, 28));
            string Email(string first, string last, string domain) => $"{first}.{last}@{domain}".ToLowerInvariant().Replace("ä", "ae").Replace("ö", "oe").Replace("ü", "ue");
            string Clean(string s) => s.Replace(",", " "); 

            for (int i = 0; i < 15; i++)
            {
                bool male = rnd.NextDouble() < 0.5;
                string sal = male ? "Herr" : "Frau";
                string first = male ? RandFrom(maleFirst) : RandFrom(femaleFirst);
                string last = RandFrom(lastNames);
                var (zip, city, street) = RandPlace();
                string streetNr = rnd.Next(1, 120).ToString();
                string company = RandFrom(companies);
                char ctype = custTypes[rnd.Next(custTypes.Length)];
                string contact = male ? RandFrom(femaleFirst) : RandFrom(maleFirst) + " " + RandFrom(lastNames);
                var dob = RandDob();

                sb.AppendLine(string.Join(",",
                    "Customer",
                    sal,
                    Clean(first),
                    Clean(last),
                    dob.ToString("yyyy-MM-dd"),
                    male ? "M" : "W",
                    "",                        // Title
                    Ssn(),
                    "",                        // PhonePrivate
                    Phone(),                   // PhoneMobile
                    "",                        // PhoneBusiness
                    Email(first, last, "example.com"),
                    (rnd.NextDouble() < 0.9) ? "TRUE" : "FALSE", // Status
                    "CH",
                    Clean(street),
                    streetNr,
                    zip,
                    Clean(city),
                    Clean(company),
                    ctype.ToString(),
                    Clean(contact),
                    "",    // EmployeeNumber
                    "",    // Department
                    "",    // StartDate
                    "",    // EndDate
                    "",    // Employment
                    "",    // Role
                    "",    // CadreLevel
                    "",    // TraineeYears
                    ""     // ActualTraineeYear
                ));
            }

            // ---- 10 Employees ----
            for (int i = 0; i < 10; i++)
            {
                bool male = rnd.NextDouble() < 0.6;
                string sal = male ? "Herr" : "Frau";
                string first = male ? RandFrom(maleFirst) : RandFrom(femaleFirst);
                string last = RandFrom(lastNames);
                var (zip, city, street) = RandPlace();
                string streetNr = rnd.Next(1, 120).ToString();
                var start = RandStartDate();
                string dept = RandFrom(departments);
                string role = RandFrom(roles);
                int employment = new[] { 60, 80, 100 }[rnd.Next(3)];
                int cadre = rnd.Next(1, 6); 
                var dob = RandDob();
                if (i >= 7)
                {
                    sb.AppendLine(string.Join(",",
                        "Trainee",
                        sal,
                        Clean(first),
                        Clean(last),
                        dob.ToString("yyyy-MM-dd"),
                        male ? "M" : "W",
                        "",                        // Title
                        Ssn(),
                        "",                        // PhonePrivate
                        Phone(),                   // PhoneMobile
                        "",                        // PhoneBusiness
                        Email(first, last, "company.ch"),
                        (rnd.NextDouble() < 0.95) ? "TRUE" : "FALSE", // Status
                        "CH",
                        Clean(street),
                        streetNr,
                        zip,
                        Clean(city),
                        "",    // CompanyName (n/a)
                        "",    // CustomerType
                        "",    // CompanyContact
                        "",    // EmployeeNumber -> leer lassen (Repo vergibt)
                        dept,
                        start.ToString("yyyy-MM-dd"),
                        "",    // EndDate
                        employment.ToString(CultureInfo.InvariantCulture),
                        "Lernende/r Informatiker/in",
                        cadre.ToString(CultureInfo.InvariantCulture),
                        "4",    // TraineeYears
                        "2"     // ActualTraineeYear
                    ));
                }
                else
                {
                    sb.AppendLine(string.Join(",",
                        "Employee",
                        sal,
                        Clean(first),
                        Clean(last),
                        dob.ToString("yyyy-MM-dd"),
                        male ? "M" : "W",
                        "",                        // Title
                        Ssn(),
                        "",                        // PhonePrivate
                        Phone(),                   // PhoneMobile
                        "",                        // PhoneBusiness
                        Email(first, last, "company.ch"),
                        (rnd.NextDouble() < 0.95) ? "TRUE" : "FALSE", // Status
                        "CH",
                        Clean(street),
                        streetNr,
                        zip,
                        Clean(city),
                        "",    // CompanyName (n/a)
                        "",    // CustomerType
                        "",    // CompanyContact
                        "",    // EmployeeNumber -> leer lassen (Repo vergibt)
                        dept,
                        start.ToString("yyyy-MM-dd"),
                        "",    // EndDate
                        employment.ToString(CultureInfo.InvariantCulture),
                        role,
                        cadre.ToString(CultureInfo.InvariantCulture),
                        "",    // TraineeYears
                        ""     // ActualTraineeYear
                    ));
                }
            }

            return sb.ToString();
        }
    }
}
