namespace ContactManager.WinForms
{
    partial class EmployeePage
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            tabMain = new TabControl();
            tabCustomer = new TabPage();
            tlpMain = new TableLayoutPanel();
            tlpRoot = new TableLayoutPanel();
            flpTop = new FlowLayoutPanel();
            lblCustomerTitle = new Label();
            lvEmployees = new ListView();
            colEmployeeNumber = new ColumnHeader();
            colName = new ColumnHeader();
            colRole = new ColumnHeader();
            colDepartment = new ColumnHeader();
            colBirthDate = new ColumnHeader();
            cmsEmployee = new ContextMenuStrip(components);
            miHistory = new ToolStripMenuItem();
            txtSearch = new TextBox();
            btnNewEmployee = new Button();
            tabEmployee = new TabPage();
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            button1 = new Button();
            txtEmployeeSearch = new TextBox();
            tabSettings = new TabPage();
            colActive = new ColumnHeader();
            tabMain.SuspendLayout();
            tabCustomer.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpRoot.SuspendLayout();
            flpTop.SuspendLayout();
            cmsEmployee.SuspendLayout();
            tabEmployee.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Name";
            columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Status";
            columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "E-Mail";
            columnHeader3.Width = 240;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Telefon";
            columnHeader4.Width = 140;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Geburtsdatum";
            columnHeader5.Width = 200;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabCustomer);
            tabMain.Controls.Add(tabEmployee);
            tabMain.Controls.Add(tabSettings);
            tabMain.Dock = DockStyle.Fill;
            tabMain.ItemSize = new Size(0, 1);
            tabMain.Location = new Point(0, 0);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Point(0, 0);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1399, 774);
            tabMain.SizeMode = TabSizeMode.Fixed;
            tabMain.TabIndex = 3;
            tabMain.TabStop = false;
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(tlpMain);
            tabCustomer.Location = new Point(4, 5);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(1391, 765);
            tabCustomer.TabIndex = 1;
            tabCustomer.Text = "Kunden";
            tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tlpMain
            // 
            tlpMain.AutoSize = true;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle());
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(tlpRoot, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(3, 3);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12);
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.Size = new Size(1385, 759);
            tlpMain.TabIndex = 6;
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80.30769F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.6923084F));
            tlpRoot.Controls.Add(flpTop, 0, 0);
            tlpRoot.Controls.Add(lvEmployees, 0, 2);
            tlpRoot.Controls.Add(txtSearch, 0, 1);
            tlpRoot.Controls.Add(btnNewEmployee, 1, 0);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(42, 15);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 3;
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.Size = new Size(1300, 729);
            tlpRoot.TabIndex = 0;
            // 
            // flpTop
            // 
            flpTop.Controls.Add(lblCustomerTitle);
            flpTop.Dock = DockStyle.Bottom;
            flpTop.Location = new Point(3, 3);
            flpTop.Name = "flpTop";
            flpTop.Size = new Size(1038, 62);
            flpTop.TabIndex = 4;
            flpTop.WrapContents = false;
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerTitle.Location = new Point(3, 0);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(386, 48);
            lblCustomerTitle.TabIndex = 2;
            lblCustomerTitle.Text = "Mitarbeiterverwaltung";
            // 
            // lvEmployees
            // 
            lvEmployees.Columns.AddRange(new ColumnHeader[] { colEmployeeNumber, colName, colBirthDate, colRole, colDepartment, colActive });
            tlpRoot.SetColumnSpan(lvEmployees, 2);
            lvEmployees.ContextMenuStrip = cmsEmployee;
            lvEmployees.Dock = DockStyle.Fill;
            lvEmployees.FullRowSelect = true;
            lvEmployees.Location = new Point(3, 108);
            lvEmployees.MultiSelect = false;
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(1294, 618);
            lvEmployees.TabIndex = 3;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.Details;
            lvEmployees.DoubleClick += lvEmployees_DoubleClick;
            lvEmployees.KeyDown += lvEmployees_KeyDown;
            // 
            // colEmployeeNumber
            // 
            colEmployeeNumber.Text = "MitarbeiterNr";
            colEmployeeNumber.Width = 140;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 220;
            // 
            // colRole
            // 
            colRole.DisplayIndex = 2;
            colRole.Text = "Funktion";
            colRole.Width = 240;
            // 
            // colDepartment
            // 
            colDepartment.DisplayIndex = 3;
            colDepartment.Text = "Abteilung";
            colDepartment.Width = 140;
            // 
            // colBirthDate
            // 
            colBirthDate.DisplayIndex = 4;
            colBirthDate.Text = "Geburtsdatum";
            colBirthDate.Width = 200;
            // 
            // cmsEmployee
            // 
            cmsEmployee.ImageScalingSize = new Size(24, 24);
            cmsEmployee.Items.AddRange(new ToolStripItem[] { miHistory });
            cmsEmployee.Name = "cmsEmployee";
            cmsEmployee.Size = new Size(216, 36);
            cmsEmployee.Opening += cmsEmployee_Opening;
            // 
            // miHistory
            // 
            miHistory.Name = "miHistory";
            miHistory.Size = new Size(215, 32);
            miHistory.Text = "Historie ansehen";
            miHistory.Click += miHistory_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tlpRoot.SetColumnSpan(txtSearch, 2);
            txtSearch.Location = new Point(3, 71);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Suchen nach Name, E-Mail, Telefon...";
            txtSearch.Size = new Size(1294, 31);
            txtSearch.TabIndex = 0;
            // 
            // btnNewEmployee
            // 
            btnNewEmployee.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewEmployee.AutoSize = true;
            btnNewEmployee.FlatStyle = FlatStyle.Flat;
            btnNewEmployee.Location = new Point(1047, 3);
            btnNewEmployee.Name = "btnNewEmployee";
            btnNewEmployee.Padding = new Padding(10, 6, 10, 6);
            btnNewEmployee.Size = new Size(250, 62);
            btnNewEmployee.TabIndex = 4;
            btnNewEmployee.Text = "+ Neuer Mitarbeiter";
            btnNewEmployee.UseVisualStyleBackColor = true;
            btnNewEmployee.Click += btnNewEmployee_Click;
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(panel1);
            tabEmployee.Location = new Point(4, 5);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(1391, 765);
            tabEmployee.TabIndex = 2;
            tabEmployee.Text = "Mitarbeiter";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtEmployeeSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8, 8, 8, 0);
            panel1.Size = new Size(1385, 138);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(329, 48);
            label1.TabIndex = 4;
            label1.Text = "Kundenverwaltung";
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.AutoSize = true;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Location = new Point(607, 32);
            button2.Name = "button2";
            button2.Padding = new Padding(10, 6, 10, 6);
            button2.Size = new Size(219, 52);
            button2.TabIndex = 3;
            button2.Text = "+ Neuer Mitarbeiter";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(3410, 27);
            button1.Name = "button1";
            button1.Padding = new Padding(10, 6, 10, 6);
            button1.Size = new Size(219, 52);
            button1.TabIndex = 1;
            button1.Text = "+ Neuer Mitarbeiter";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtEmployeeSearch
            // 
            txtEmployeeSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtEmployeeSearch.Location = new Point(35, 90);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.PlaceholderText = "Suchen nach Name, E-Mail, Telefon...";
            txtEmployeeSearch.Size = new Size(1312, 31);
            txtEmployeeSearch.TabIndex = 0;
            // 
            // tabSettings
            // 
            tabSettings.Location = new Point(4, 5);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(3);
            tabSettings.Size = new Size(1391, 765);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Einstellungen";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // colActive
            // 
            colActive.Text = "Status";
            colActive.Width = 100;
            // 
            // EmployeePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabMain);
            Name = "EmployeePage";
            Size = new Size(1399, 774);
            tabMain.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            tabCustomer.PerformLayout();
            tlpMain.ResumeLayout(false);
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            flpTop.ResumeLayout(false);
            flpTop.PerformLayout();
            cmsEmployee.ResumeLayout(false);
            tabEmployee.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        //8private ListView lvEmployeess;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private TabControl tabMain;
        private TabPage tabCustomer;
        private TabPage tabEmployee;
        private Panel panel1;
        private Label label1;
        private Button button2;
        private Button button1;
        private TextBox txtEmployeeSearch;
        private TabPage tabSettings;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flpTop;
        private Label lblCustomerTitle;
        private ListView lvEmployees;
        private ColumnHeader colName;
        private ColumnHeader colRole;
        private ColumnHeader colDepartment;
        private ColumnHeader colBirthDate;
        private TextBox txtSearch;
        private Button btnNewEmployee;
        private ContextMenuStrip cmsEmployee;
        private ToolStripMenuItem miHistory;
        private ColumnHeader colEmployeeNumber;
        private ColumnHeader colActive;
    }
}
