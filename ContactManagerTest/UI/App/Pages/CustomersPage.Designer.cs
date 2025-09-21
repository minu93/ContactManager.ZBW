namespace ContactManager.WinForms
{
    partial class CustomersPage
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
            tabMain = new TabControl();
            tabCustomer = new TabPage();
            tlpMain = new TableLayoutPanel();
            tlpRoot = new TableLayoutPanel();
            flpTop = new FlowLayoutPanel();
            lblCustomerTitle = new Label();
            lvCustomers = new ListView();
            colName = new ColumnHeader();
            colStatus = new ColumnHeader();
            colEmail = new ColumnHeader();
            colPhone = new ColumnHeader();
            colBirthDate = new ColumnHeader();
            cmsCustomers = new ContextMenuStrip(components);
            miHistory = new ToolStripMenuItem();
            txtSearch = new TextBox();
            btnNewCustomer = new Button();
            tabEmployee = new TabPage();
            lvEmployees = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            panel1 = new Panel();
            lblEmployeeTitle = new Label();
            button1 = new Button();
            txtEmployeeSearch = new TextBox();
            tabSettings = new TabPage();
            tabMain.SuspendLayout();
            tabCustomer.SuspendLayout();
            tlpMain.SuspendLayout();
            tlpRoot.SuspendLayout();
            flpTop.SuspendLayout();
            cmsCustomers.SuspendLayout();
            tabEmployee.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
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
            tabMain.Size = new Size(1330, 741);
            tabMain.SizeMode = TabSizeMode.Fixed;
            tabMain.TabIndex = 2;
            tabMain.TabStop = false;
            // 
            // tabCustomer
            // 
            tabCustomer.Controls.Add(tlpMain);
            tabCustomer.Location = new Point(4, 5);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(1322, 732);
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
            tlpMain.Size = new Size(1316, 726);
            tlpMain.TabIndex = 5;
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85.07692F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 14.9230766F));
            tlpRoot.Controls.Add(flpTop, 0, 0);
            tlpRoot.Controls.Add(lvCustomers, 0, 2);
            tlpRoot.Controls.Add(txtSearch, 0, 1);
            tlpRoot.Controls.Add(btnNewCustomer, 1, 0);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(8, 15);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 3;
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.Size = new Size(1300, 696);
            tlpRoot.TabIndex = 0;
            // 
            // flpTop
            // 
            flpTop.Controls.Add(lblCustomerTitle);
            flpTop.Dock = DockStyle.Bottom;
            flpTop.Location = new Point(3, 3);
            flpTop.Name = "flpTop";
            flpTop.Size = new Size(1099, 62);
            flpTop.TabIndex = 4;
            flpTop.WrapContents = false;
            // 
            // lblCustomerTitle
            // 
            lblCustomerTitle.AutoSize = true;
            lblCustomerTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerTitle.Location = new Point(3, 0);
            lblCustomerTitle.Name = "lblCustomerTitle";
            lblCustomerTitle.Size = new Size(329, 48);
            lblCustomerTitle.TabIndex = 2;
            lblCustomerTitle.Text = "Kundenverwaltung";
            // 
            // lvCustomers
            // 
            lvCustomers.Columns.AddRange(new ColumnHeader[] { colName, colStatus, colEmail, colPhone, colBirthDate });
            tlpRoot.SetColumnSpan(lvCustomers, 2);
            lvCustomers.ContextMenuStrip = cmsCustomers;
            lvCustomers.Dock = DockStyle.Fill;
            lvCustomers.FullRowSelect = true;
            lvCustomers.Location = new Point(3, 108);
            lvCustomers.MultiSelect = false;
            lvCustomers.Name = "lvCustomers";
            lvCustomers.Size = new Size(1294, 585);
            lvCustomers.TabIndex = 3;
            lvCustomers.UseCompatibleStateImageBehavior = false;
            lvCustomers.View = View.Details;
            //lvCustomers.SelectedIndexChanged += lvCustomers_SelectedIndexChanged;
            lvCustomers.DoubleClick += lvCustomers_DoubleClick;
            lvCustomers.KeyDown += lvCustomers_KeyDown;
            // 
            // colName
            // 
            colName.Text = "Name";
            colName.Width = 220;
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            colStatus.Width = 80;
            // 
            // colEmail
            // 
            colEmail.Text = "E-Mail";
            colEmail.Width = 240;
            // 
            // colPhone
            // 
            colPhone.Text = "Telefon";
            colPhone.Width = 140;
            // 
            // colBirthDate
            // 
            colBirthDate.Text = "Geburtsdatum";
            colBirthDate.Width = 200;
            // 
            // cmsCustomers
            // 
            cmsCustomers.ImageScalingSize = new Size(24, 24);
            cmsCustomers.Items.AddRange(new ToolStripItem[] { miHistory });
            cmsCustomers.Name = "cmsCustomers";
            cmsCustomers.Size = new Size(216, 36);
            cmsCustomers.Opening += cmsCustomers_Opening;
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
            // btnNewCustomer
            // 
            btnNewCustomer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnNewCustomer.AutoSize = true;
            btnNewCustomer.FlatStyle = FlatStyle.Flat;
            btnNewCustomer.Location = new Point(1108, 3);
            btnNewCustomer.Name = "btnNewCustomer";
            btnNewCustomer.Padding = new Padding(10, 6, 10, 6);
            btnNewCustomer.Size = new Size(189, 62);
            btnNewCustomer.TabIndex = 4;
            btnNewCustomer.Text = "+ Neuer Kunde";
            btnNewCustomer.UseVisualStyleBackColor = true;
            btnNewCustomer.Click += btnNewCustomer_Click;
            // 
            // tabEmployee
            // 
            tabEmployee.Controls.Add(lvEmployees);
            tabEmployee.Controls.Add(panel1);
            tabEmployee.Location = new Point(4, 5);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(1322, 732);
            tabEmployee.TabIndex = 2;
            tabEmployee.Text = "Mitarbeiter";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // lvEmployees
            // 
            lvEmployees.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lvEmployees.Dock = DockStyle.Fill;
            lvEmployees.FullRowSelect = true;
            lvEmployees.Location = new Point(3, 141);
            lvEmployees.MultiSelect = false;
            lvEmployees.Name = "lvEmployees";
            lvEmployees.Size = new Size(1316, 588);
            lvEmployees.TabIndex = 4;
            lvEmployees.UseCompatibleStateImageBehavior = false;
            lvEmployees.View = View.Details;
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
            // panel1
            // 
            panel1.Controls.Add(lblEmployeeTitle);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtEmployeeSearch);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(8, 8, 8, 0);
            panel1.Size = new Size(1316, 138);
            panel1.TabIndex = 3;
            // 
            // lblEmployeeTitle
            // 
            lblEmployeeTitle.AutoSize = true;
            lblEmployeeTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeTitle.Location = new Point(27, 31);
            lblEmployeeTitle.Name = "lblEmployeeTitle";
            lblEmployeeTitle.Size = new Size(386, 48);
            lblEmployeeTitle.TabIndex = 2;
            lblEmployeeTitle.Text = "Mitarbeiterverwaltung";
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.AutoSize = true;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(2236, 19);
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
            txtEmployeeSearch.Location = new Point(27, 98);
            txtEmployeeSearch.Name = "txtEmployeeSearch";
            txtEmployeeSearch.PlaceholderText = "Suchen nach Name, E-Mail, Telefon...";
            txtEmployeeSearch.Size = new Size(2428, 31);
            txtEmployeeSearch.TabIndex = 0;
            // 
            // tabSettings
            // 
            tabSettings.Location = new Point(4, 5);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(3);
            tabSettings.Size = new Size(1322, 732);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Einstellungen";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // CustomersPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tabMain);
            Name = "CustomersPage";
            Size = new Size(1330, 741);
            tabMain.ResumeLayout(false);
            tabCustomer.ResumeLayout(false);
            tabCustomer.PerformLayout();
            tlpMain.ResumeLayout(false);
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            flpTop.ResumeLayout(false);
            flpTop.PerformLayout();
            cmsCustomers.ResumeLayout(false);
            tabEmployee.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabMain;
        private TabPage tabCustomer;
        private ListView lvCustomers;
        private ColumnHeader colName;
        private ColumnHeader colStatus;
        private ColumnHeader colEmail;
        private ColumnHeader colPhone;
        private ColumnHeader colBirthDate;
        private Label lblCustomerTitle;
        private TextBox txtSearch;
        private TabPage tabEmployee;
        private ListView lvEmployees;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private ColumnHeader columnHeader5;
        private Panel panel1;
        private Label lblEmployeeTitle;
        private Button button1;
        private TextBox txtEmployeeSearch;
        private TabPage tabSettings;
        private Button btnNewCustomer;
        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flpTop;
        private ContextMenuStrip cmsCustomers;
        private ToolStripMenuItem miHistory;
    }
}
