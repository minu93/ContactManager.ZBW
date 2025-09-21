namespace ContactManager.WinForms.UI.App.Pages
{
    partial class DashboardPage
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
            tlpMain = new TableLayoutPanel();
            tlpRoot = new TableLayoutPanel();
            cardHints = new Panel();
            lbHints = new ListBox();
            label2 = new Label();
            lblHintsTitle = new Label();
            flpTop = new FlowLayoutPanel();
            cardCustomers = new Panel();
            lblCustomersSub = new Label();
            lblCustomersCount = new Label();
            label1 = new Label();
            cardEmployees = new Panel();
            lblEmployeesSub = new Label();
            lblEmployeesCount = new Label();
            label4 = new Label();
            cardNotes = new Panel();
            lblNotesSub = new Label();
            lblNotesCount = new Label();
            label7 = new Label();
            cardActivity = new Panel();
            lblActivitySub = new Label();
            lblActivityCount = new Label();
            label10 = new Label();
            cardBirthdays = new Panel();
            lbBirthdays = new ListBox();
            lblBirthdaysSub = new Label();
            lblBirthdaysTitle = new Label();
            tlpMain.SuspendLayout();
            tlpRoot.SuspendLayout();
            cardHints.SuspendLayout();
            flpTop.SuspendLayout();
            cardCustomers.SuspendLayout();
            cardEmployees.SuspendLayout();
            cardNotes.SuspendLayout();
            cardActivity.SuspendLayout();
            cardBirthdays.SuspendLayout();
            SuspendLayout();
            // 
            // tlpMain
            // 
            tlpMain.AutoScroll = true;
            tlpMain.ColumnCount = 3;
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.ColumnStyles.Add(new ColumnStyle());
            tlpMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMain.Controls.Add(tlpRoot, 1, 0);
            tlpMain.Dock = DockStyle.Fill;
            tlpMain.Location = new Point(0, 0);
            tlpMain.Name = "tlpMain";
            tlpMain.Padding = new Padding(12, 0, 0, 0);
            tlpMain.RowCount = 1;
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tlpMain.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tlpMain.Size = new Size(1330, 741);
            tlpMain.TabIndex = 0;
            // 
            // tlpRoot
            // 
            tlpRoot.ColumnCount = 2;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpRoot.Controls.Add(cardHints, 1, 1);
            tlpRoot.Controls.Add(flpTop, 0, 0);
            tlpRoot.Controls.Add(cardBirthdays, 0, 1);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(21, 3);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 3;
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpRoot.Size = new Size(1300, 735);
            tlpRoot.TabIndex = 0;
            // 
            // cardHints
            // 
            cardHints.BackColor = Color.White;
            cardHints.Controls.Add(lbHints);
            cardHints.Controls.Add(label2);
            cardHints.Controls.Add(lblHintsTitle);
            cardHints.Dock = DockStyle.Fill;
            cardHints.Location = new Point(665, 166);
            cardHints.Margin = new Padding(15, 10, 3, 3);
            cardHints.Name = "cardHints";
            cardHints.Padding = new Padding(12);
            tlpRoot.SetRowSpan(cardHints, 2);
            cardHints.Size = new Size(632, 566);
            cardHints.TabIndex = 2;
            // 
            // lbHints
            // 
            lbHints.BorderStyle = BorderStyle.FixedSingle;
            lbHints.Dock = DockStyle.Fill;
            lbHints.FormattingEnabled = true;
            lbHints.IntegralHeight = false;
            lbHints.ItemHeight = 25;
            lbHints.Location = new Point(12, 94);
            lbHints.Name = "lbHints";
            lbHints.Size = new Size(608, 460);
            lbHints.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Location = new Point(12, 54);
            label2.Margin = new Padding(3);
            label2.Name = "label2";
            label2.Padding = new Padding(0, 0, 0, 15);
            label2.Size = new Size(199, 40);
            label2.TabIndex = 1;
            label2.Text = "Wichtige Informationen";
            // 
            // lblHintsTitle
            // 
            lblHintsTitle.AutoSize = true;
            lblHintsTitle.Dock = DockStyle.Top;
            lblHintsTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHintsTitle.Location = new Point(12, 12);
            lblHintsTitle.Name = "lblHintsTitle";
            lblHintsTitle.Padding = new Padding(0, 0, 0, 10);
            lblHintsTitle.Size = new Size(152, 42);
            lblHintsTitle.TabIndex = 0;
            lblHintsTitle.Text = "Information";
            // 
            // flpTop
            // 
            tlpRoot.SetColumnSpan(flpTop, 2);
            flpTop.Controls.Add(cardCustomers);
            flpTop.Controls.Add(cardEmployees);
            flpTop.Controls.Add(cardNotes);
            flpTop.Controls.Add(cardActivity);
            flpTop.Dock = DockStyle.Top;
            flpTop.Location = new Point(3, 3);
            flpTop.Name = "flpTop";
            flpTop.Size = new Size(1294, 150);
            flpTop.TabIndex = 0;
            flpTop.WrapContents = false;
            // 
            // cardCustomers
            // 
            cardCustomers.BackColor = Color.White;
            cardCustomers.Controls.Add(lblCustomersSub);
            cardCustomers.Controls.Add(lblCustomersCount);
            cardCustomers.Controls.Add(label1);
            cardCustomers.Location = new Point(0, 0);
            cardCustomers.Margin = new Padding(0, 0, 30, 0);
            cardCustomers.Name = "cardCustomers";
            cardCustomers.Padding = new Padding(12);
            cardCustomers.Size = new Size(300, 150);
            cardCustomers.TabIndex = 0;
            // 
            // lblCustomersSub
            // 
            lblCustomersSub.AutoSize = true;
            lblCustomersSub.Location = new Point(15, 111);
            lblCustomersSub.Name = "lblCustomersSub";
            lblCustomersSub.Size = new Size(76, 25);
            lblCustomersSub.TabIndex = 2;
            lblCustomersSub.Text = "x inaktiv";
            // 
            // lblCustomersCount
            // 
            lblCustomersCount.AutoSize = true;
            lblCustomersCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblCustomersCount.Location = new Point(15, 51);
            lblCustomersCount.Name = "lblCustomersCount";
            lblCustomersCount.Size = new Size(62, 48);
            lblCustomersCount.TabIndex = 1;
            lblCustomersCount.Text = "50";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label1.Location = new Point(15, 12);
            label1.Name = "label1";
            label1.Size = new Size(84, 28);
            label1.TabIndex = 0;
            label1.Text = "Kunden";
            // 
            // cardEmployees
            // 
            cardEmployees.BackColor = Color.White;
            cardEmployees.Controls.Add(lblEmployeesSub);
            cardEmployees.Controls.Add(lblEmployeesCount);
            cardEmployees.Controls.Add(label4);
            cardEmployees.Location = new Point(330, 0);
            cardEmployees.Margin = new Padding(0, 0, 30, 0);
            cardEmployees.Name = "cardEmployees";
            cardEmployees.Padding = new Padding(12);
            cardEmployees.Size = new Size(302, 150);
            cardEmployees.TabIndex = 1;
            // 
            // lblEmployeesSub
            // 
            lblEmployeesSub.AutoSize = true;
            lblEmployeesSub.Location = new Point(15, 111);
            lblEmployeesSub.Name = "lblEmployeesSub";
            lblEmployeesSub.Size = new Size(76, 25);
            lblEmployeesSub.TabIndex = 5;
            lblEmployeesSub.Text = "x inaktiv";
            // 
            // lblEmployeesCount
            // 
            lblEmployeesCount.AutoSize = true;
            lblEmployeesCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblEmployeesCount.Location = new Point(15, 51);
            lblEmployeesCount.Name = "lblEmployeesCount";
            lblEmployeesCount.Size = new Size(62, 48);
            lblEmployeesCount.TabIndex = 4;
            lblEmployeesCount.Text = "50";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(15, 12);
            label4.Name = "label4";
            label4.Size = new Size(120, 28);
            label4.TabIndex = 3;
            label4.Text = "Mitarbeiter";
            // 
            // cardNotes
            // 
            cardNotes.BackColor = Color.White;
            cardNotes.Controls.Add(lblNotesSub);
            cardNotes.Controls.Add(lblNotesCount);
            cardNotes.Controls.Add(label7);
            cardNotes.Location = new Point(662, 0);
            cardNotes.Margin = new Padding(0, 0, 30, 0);
            cardNotes.Name = "cardNotes";
            cardNotes.Padding = new Padding(12);
            cardNotes.Size = new Size(300, 150);
            cardNotes.TabIndex = 2;
            // 
            // lblNotesSub
            // 
            lblNotesSub.AutoSize = true;
            lblNotesSub.Location = new Point(15, 111);
            lblNotesSub.Name = "lblNotesSub";
            lblNotesSub.Size = new Size(76, 25);
            lblNotesSub.TabIndex = 8;
            lblNotesSub.Text = "x inaktiv";
            // 
            // lblNotesCount
            // 
            lblNotesCount.AutoSize = true;
            lblNotesCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblNotesCount.Location = new Point(15, 51);
            lblNotesCount.Name = "lblNotesCount";
            lblNotesCount.Size = new Size(62, 48);
            lblNotesCount.TabIndex = 7;
            lblNotesCount.Text = "50";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label7.Location = new Point(15, 12);
            label7.Name = "label7";
            label7.Size = new Size(87, 28);
            label7.TabIndex = 6;
            label7.Text = "Notizen";
            // 
            // cardActivity
            // 
            cardActivity.BackColor = Color.White;
            cardActivity.Controls.Add(lblActivitySub);
            cardActivity.Controls.Add(lblActivityCount);
            cardActivity.Controls.Add(label10);
            cardActivity.Location = new Point(992, 0);
            cardActivity.Margin = new Padding(0, 0, 12, 0);
            cardActivity.Name = "cardActivity";
            cardActivity.Padding = new Padding(12);
            cardActivity.Size = new Size(300, 150);
            cardActivity.TabIndex = 3;
            // 
            // lblActivitySub
            // 
            lblActivitySub.AutoSize = true;
            lblActivitySub.Location = new Point(15, 111);
            lblActivitySub.Name = "lblActivitySub";
            lblActivitySub.Size = new Size(76, 25);
            lblActivitySub.TabIndex = 11;
            lblActivitySub.Text = "x inaktiv";
            // 
            // lblActivityCount
            // 
            lblActivityCount.AutoSize = true;
            lblActivityCount.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblActivityCount.Location = new Point(15, 51);
            lblActivityCount.Name = "lblActivityCount";
            lblActivityCount.Size = new Size(62, 48);
            lblActivityCount.TabIndex = 10;
            lblActivityCount.Text = "50";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label10.Location = new Point(15, 12);
            label10.Name = "label10";
            label10.Size = new Size(95, 28);
            label10.TabIndex = 9;
            label10.Text = "Aktivität";
            // 
            // cardBirthdays
            // 
            cardBirthdays.BackColor = Color.White;
            cardBirthdays.Controls.Add(lbBirthdays);
            cardBirthdays.Controls.Add(lblBirthdaysSub);
            cardBirthdays.Controls.Add(lblBirthdaysTitle);
            cardBirthdays.Dock = DockStyle.Fill;
            cardBirthdays.Location = new Point(3, 166);
            cardBirthdays.Margin = new Padding(3, 10, 15, 3);
            cardBirthdays.Name = "cardBirthdays";
            cardBirthdays.Padding = new Padding(12);
            tlpRoot.SetRowSpan(cardBirthdays, 2);
            cardBirthdays.Size = new Size(632, 566);
            cardBirthdays.TabIndex = 1;
            // 
            // lbBirthdays
            // 
            lbBirthdays.BorderStyle = BorderStyle.FixedSingle;
            lbBirthdays.Dock = DockStyle.Fill;
            lbBirthdays.FormattingEnabled = true;
            lbBirthdays.IntegralHeight = false;
            lbBirthdays.ItemHeight = 25;
            lbBirthdays.Location = new Point(12, 94);
            lbBirthdays.Name = "lbBirthdays";
            lbBirthdays.Size = new Size(608, 460);
            lbBirthdays.TabIndex = 2;
            // 
            // lblBirthdaysSub
            // 
            lblBirthdaysSub.AutoSize = true;
            lblBirthdaysSub.Dock = DockStyle.Top;
            lblBirthdaysSub.Location = new Point(12, 54);
            lblBirthdaysSub.Margin = new Padding(3);
            lblBirthdaysSub.Name = "lblBirthdaysSub";
            lblBirthdaysSub.Padding = new Padding(0, 0, 0, 15);
            lblBirthdaysSub.Size = new Size(363, 40);
            lblBirthdaysSub.TabIndex = 1;
            lblBirthdaysSub.Text = "Kontakte mit Geburtstag im aktuellen Monat";
            // 
            // lblBirthdaysTitle
            // 
            lblBirthdaysTitle.AutoSize = true;
            lblBirthdaysTitle.Dock = DockStyle.Top;
            lblBirthdaysTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBirthdaysTitle.Location = new Point(12, 12);
            lblBirthdaysTitle.Name = "lblBirthdaysTitle";
            lblBirthdaysTitle.Padding = new Padding(0, 0, 0, 10);
            lblBirthdaysTitle.Size = new Size(359, 42);
            lblBirthdaysTitle.TabIndex = 0;
            lblBirthdaysTitle.Text = "🎂 Geburtstage diesen Monat";
            // 
            // DashboardPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tlpMain);
            Name = "DashboardPage";
            Size = new Size(1330, 741);
            tlpMain.ResumeLayout(false);
            tlpRoot.ResumeLayout(false);
            cardHints.ResumeLayout(false);
            cardHints.PerformLayout();
            flpTop.ResumeLayout(false);
            cardCustomers.ResumeLayout(false);
            cardCustomers.PerformLayout();
            cardEmployees.ResumeLayout(false);
            cardEmployees.PerformLayout();
            cardNotes.ResumeLayout(false);
            cardNotes.PerformLayout();
            cardActivity.ResumeLayout(false);
            cardActivity.PerformLayout();
            cardBirthdays.ResumeLayout(false);
            cardBirthdays.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpMain;
        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flpTop;
        private Panel cardCustomers;
        private Panel cardEmployees;
        private Panel cardNotes;
        private Panel cardActivity;
        private Label lblCustomersSub;
        private Label lblCustomersCount;
        private Label label1;
        private Label lblEmployeesSub;
        private Label lblEmployeesCount;
        private Label label4;
        private Label lblNotesSub;
        private Label lblNotesCount;
        private Label label7;
        private Label lblActivitySub;
        private Label lblActivityCount;
        private Label label10;
        private Panel cardBirthdays;
        private ListBox lbBirthdays;
        private Label lblBirthdaysSub;
        private Label lblBirthdaysTitle;
        private Panel cardHints;
        private ListBox lbHints;
        private Label label2;
        private Label lblHintsTitle;
    }
}
