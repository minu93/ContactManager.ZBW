namespace ContactManager.WinForms
{
    partial class EmployeeDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            errorProvider1 = new ErrorProvider(components);
            label18 = new Label();
            label1 = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            txtDepartment = new TextBox();
            label21 = new Label();
            dtpStartDate = new DateTimePicker();
            label22 = new Label();
            dtpEndDate = new DateTimePicker();
            label23 = new Label();
            label24 = new Label();
            txtRole = new TextBox();
            lblKader = new Label();
            nudCadre = new NumericUpDown();
            label28 = new Label();
            nudEmployment = new NumericUpDown();
            tableLayoutPanel3 = new TableLayoutPanel();
            chckIsTrainee = new CheckBox();
            label12 = new Label();
            nudTraineeYears = new NumericUpDown();
            lblTraineeYears = new Label();
            nudActualYear = new NumericUpDown();
            lblActualYear = new Label();
            label2 = new Label();
            txtSalutation = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblEmployeeNumber = new Label();
            lblEmployeeNumberTitle = new Label();
            lblTitle = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            label8 = new Label();
            label7 = new Label();
            txtNationality = new TextBox();
            txtSocialSecurityNumber = new MaskedTextBox();
            dtpBirthDate = new DateTimePicker();
            cmbGender = new ComboBox();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtTitle = new TextBox();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            txtPhoneNumberBusiness = new MaskedTextBox();
            txtPhoneNumberMobile = new MaskedTextBox();
            txtPhoneNumberPrivate = new MaskedTextBox();
            txtPlace = new TextBox();
            txtZipCode = new TextBox();
            txtStreet = new TextBox();
            txtEmail = new TextBox();
            label32 = new Label();
            label30 = new Label();
            label25 = new Label();
            label19 = new Label();
            label16 = new Label();
            label13 = new Label();
            label15 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            chkActive = new CheckBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudCadre).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudEmployment).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudTraineeYears).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudActualYear).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label18.Location = new Point(217, 49);
            label18.Name = "label18";
            label18.Size = new Size(109, 28);
            label18.TabIndex = 4;
            label18.Text = "Nachname";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(29, 34);
            label1.Name = "label1";
            label1.Size = new Size(335, 45);
            label1.TabIndex = 40;
            label1.Text = "Persönliche Angaben";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.72483F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.27517F));
            tableLayoutPanel2.Controls.Add(txtDepartment, 1, 8);
            tableLayoutPanel2.Controls.Add(label21, 0, 8);
            tableLayoutPanel2.Controls.Add(dtpStartDate, 1, 9);
            tableLayoutPanel2.Controls.Add(label22, 0, 9);
            tableLayoutPanel2.Controls.Add(dtpEndDate, 1, 10);
            tableLayoutPanel2.Controls.Add(label23, 0, 10);
            tableLayoutPanel2.Controls.Add(label24, 0, 11);
            tableLayoutPanel2.Controls.Add(txtRole, 1, 12);
            tableLayoutPanel2.Controls.Add(lblKader, 0, 13);
            tableLayoutPanel2.Controls.Add(nudCadre, 1, 13);
            tableLayoutPanel2.Controls.Add(label28, 0, 12);
            tableLayoutPanel2.Controls.Add(nudEmployment, 1, 11);
            tableLayoutPanel2.Location = new Point(29, 491);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new Padding(12);
            tableLayoutPanel2.RowCount = 18;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.Size = new Size(626, 247);
            tableLayoutPanel2.TabIndex = 2;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(218, 15);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.Size = new Size(369, 31);
            txtDepartment.TabIndex = 0;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label21.Location = new Point(15, 12);
            label21.Name = "label21";
            label21.Size = new Size(116, 28);
            label21.TabIndex = 41;
            label21.Text = "Abteilung *";
            // 
            // dtpStartDate
            // 
            dtpStartDate.CustomFormat = "dd.MM.yyyy";
            dtpStartDate.Format = DateTimePickerFormat.Custom;
            dtpStartDate.Location = new Point(218, 52);
            dtpStartDate.Name = "dtpStartDate";
            dtpStartDate.Size = new Size(369, 31);
            dtpStartDate.TabIndex = 1;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label22.Location = new Point(15, 49);
            label22.Name = "label22";
            label22.Size = new Size(155, 28);
            label22.TabIndex = 43;
            label22.Text = "Eintrittsdatum *";
            // 
            // dtpEndDate
            // 
            dtpEndDate.Checked = false;
            dtpEndDate.CustomFormat = "dd.MM.yyyy";
            dtpEndDate.Format = DateTimePickerFormat.Custom;
            dtpEndDate.Location = new Point(218, 89);
            dtpEndDate.Name = "dtpEndDate";
            dtpEndDate.ShowCheckBox = true;
            dtpEndDate.Size = new Size(369, 31);
            dtpEndDate.TabIndex = 2;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label23.Location = new Point(15, 86);
            label23.Name = "label23";
            label23.Size = new Size(147, 28);
            label23.TabIndex = 45;
            label23.Text = "Austrittsdatum";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label24.Location = new Point(15, 123);
            label24.Name = "label24";
            label24.Size = new Size(165, 28);
            label24.TabIndex = 47;
            label24.Text = "Arbeitspensum *";
            // 
            // txtRole
            // 
            txtRole.Location = new Point(218, 163);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(369, 31);
            txtRole.TabIndex = 4;
            // 
            // lblKader
            // 
            lblKader.AutoSize = true;
            lblKader.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblKader.Location = new Point(15, 197);
            lblKader.Name = "lblKader";
            lblKader.Size = new Size(125, 28);
            lblKader.TabIndex = 51;
            lblKader.Text = "Kaderstufe *";
            // 
            // nudCadre
            // 
            nudCadre.Location = new Point(218, 200);
            nudCadre.Name = "nudCadre";
            nudCadre.Size = new Size(369, 31);
            nudCadre.TabIndex = 5;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label28.Location = new Point(15, 160);
            label28.Name = "label28";
            label28.Size = new Size(71, 28);
            label28.TabIndex = 49;
            label28.Text = "Rolle *";
            // 
            // nudEmployment
            // 
            nudEmployment.Location = new Point(218, 126);
            nudEmployment.Name = "nudEmployment";
            nudEmployment.Size = new Size(369, 31);
            nudEmployment.TabIndex = 3;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.72483F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.27517F));
            tableLayoutPanel3.Controls.Add(chckIsTrainee, 1, 13);
            tableLayoutPanel3.Controls.Add(label12, 0, 13);
            tableLayoutPanel3.Controls.Add(nudTraineeYears, 1, 14);
            tableLayoutPanel3.Controls.Add(lblTraineeYears, 0, 14);
            tableLayoutPanel3.Controls.Add(nudActualYear, 1, 15);
            tableLayoutPanel3.Controls.Add(lblActualYear, 0, 15);
            tableLayoutPanel3.Location = new Point(675, 491);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.Padding = new Padding(12);
            tableLayoutPanel3.RowCount = 18;
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.RowStyles.Add(new RowStyle());
            tableLayoutPanel3.Size = new Size(627, 153);
            tableLayoutPanel3.TabIndex = 3;
            // 
            // chckIsTrainee
            // 
            chckIsTrainee.AutoSize = true;
            chckIsTrainee.Location = new Point(218, 15);
            chckIsTrainee.Name = "chckIsTrainee";
            chckIsTrainee.Size = new Size(53, 29);
            chckIsTrainee.TabIndex = 0;
            chckIsTrainee.Text = "Ja";
            chckIsTrainee.UseVisualStyleBackColor = true;
            chckIsTrainee.CheckedChanged += chckIsTrainee_CheckedChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label12.Location = new Point(15, 12);
            label12.Name = "label12";
            label12.Size = new Size(149, 28);
            label12.TabIndex = 51;
            label12.Text = "In Ausbildung?";
            label12.TextAlign = ContentAlignment.BottomRight;
            // 
            // nudTraineeYears
            // 
            nudTraineeYears.Location = new Point(218, 50);
            nudTraineeYears.Name = "nudTraineeYears";
            nudTraineeYears.Size = new Size(369, 31);
            nudTraineeYears.TabIndex = 1;
            nudTraineeYears.Visible = false;
            // 
            // lblTraineeYears
            // 
            lblTraineeYears.AutoSize = true;
            lblTraineeYears.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTraineeYears.Location = new Point(15, 47);
            lblTraineeYears.Name = "lblTraineeYears";
            lblTraineeYears.Size = new Size(97, 28);
            lblTraineeYears.TabIndex = 53;
            lblTraineeYears.Text = "Lehrjahre";
            lblTraineeYears.Visible = false;
            // 
            // nudActualYear
            // 
            nudActualYear.Location = new Point(218, 87);
            nudActualYear.Name = "nudActualYear";
            nudActualYear.Size = new Size(369, 31);
            nudActualYear.TabIndex = 2;
            nudActualYear.Visible = false;
            // 
            // lblActualYear
            // 
            lblActualYear.AutoSize = true;
            lblActualYear.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblActualYear.Location = new Point(15, 84);
            lblActualYear.Name = "lblActualYear";
            lblActualYear.Size = new Size(176, 28);
            lblActualYear.TabIndex = 55;
            lblActualYear.Text = "Aktuelles Lehrjahr";
            lblActualYear.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(15, 77);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 58;
            label2.Text = "Anrede";
            // 
            // txtSalutation
            // 
            txtSalutation.Location = new Point(217, 80);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(357, 31);
            txtSalutation.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.72483F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.27517F));
            tableLayoutPanel1.Controls.Add(lblEmployeeNumber, 1, 0);
            tableLayoutPanel1.Controls.Add(lblEmployeeNumberTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(label5, 0, 6);
            tableLayoutPanel1.Controls.Add(label8, 0, 8);
            tableLayoutPanel1.Controls.Add(label7, 0, 7);
            tableLayoutPanel1.Controls.Add(txtNationality, 1, 8);
            tableLayoutPanel1.Controls.Add(txtSocialSecurityNumber, 1, 7);
            tableLayoutPanel1.Controls.Add(dtpBirthDate, 1, 6);
            tableLayoutPanel1.Controls.Add(cmbGender, 1, 5);
            tableLayoutPanel1.Controls.Add(txtLastName, 1, 4);
            tableLayoutPanel1.Controls.Add(txtFirstName, 1, 3);
            tableLayoutPanel1.Controls.Add(txtSalutation, 1, 2);
            tableLayoutPanel1.Controls.Add(txtTitle, 1, 1);
            tableLayoutPanel1.Location = new Point(29, 81);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(12);
            tableLayoutPanel1.RowCount = 18;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(623, 359);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblEmployeeNumber
            // 
            lblEmployeeNumber.AutoSize = true;
            lblEmployeeNumber.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeNumber.Location = new Point(217, 12);
            lblEmployeeNumber.Name = "lblEmployeeNumber";
            lblEmployeeNumber.Size = new Size(190, 28);
            lblEmployeeNumber.TabIndex = 75;
            lblEmployeeNumber.Text = "Mitarbeiternummer";
            // 
            // lblEmployeeNumberTitle
            // 
            lblEmployeeNumberTitle.AutoSize = true;
            lblEmployeeNumberTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmployeeNumberTitle.Location = new Point(15, 12);
            lblEmployeeNumberTitle.Name = "lblEmployeeNumberTitle";
            lblEmployeeNumberTitle.Size = new Size(190, 28);
            lblEmployeeNumberTitle.TabIndex = 74;
            lblEmployeeNumberTitle.Text = "Mitarbeiternummer";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(15, 40);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 28);
            lblTitle.TabIndex = 67;
            lblTitle.Text = "Titel";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(15, 114);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 60;
            label3.Text = "Vorname *";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(15, 151);
            label4.Name = "label4";
            label4.Size = new Size(124, 28);
            label4.TabIndex = 62;
            label4.Text = "Nachname *";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(15, 188);
            label6.Name = "label6";
            label6.Size = new Size(111, 28);
            label6.TabIndex = 64;
            label6.Text = "Geschlecht";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 227);
            label5.Name = "label5";
            label5.Size = new Size(159, 28);
            label5.TabIndex = 63;
            label5.Text = "Geburtsdatum *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(15, 301);
            label8.Name = "label8";
            label8.Size = new Size(117, 28);
            label8.TabIndex = 70;
            label8.Text = "Nationalität";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(15, 264);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 68;
            label7.Text = "AHV Nummer";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(217, 304);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(357, 31);
            txtNationality.TabIndex = 7;
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.HidePromptOnLeave = true;
            txtSocialSecurityNumber.Location = new Point(217, 267);
            txtSocialSecurityNumber.Mask = "000.0000.0000.00";
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PromptChar = ' ';
            txtSocialSecurityNumber.RejectInputOnFirstFailure = true;
            txtSocialSecurityNumber.Size = new Size(357, 31);
            txtSocialSecurityNumber.TabIndex = 6;
            txtSocialSecurityNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd.MM.yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(217, 230);
            dtpBirthDate.MaxDate = new DateTime(2999, 9, 20, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(357, 31);
            dtpBirthDate.TabIndex = 5;
            dtpBirthDate.Value = new DateTime(1990, 1, 1, 21, 20, 0, 0);
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Männlich", "Weiblich" });
            cmbGender.Location = new Point(217, 191);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(357, 33);
            cmbGender.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(217, 154);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(357, 31);
            txtLastName.TabIndex = 3;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(217, 117);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(357, 31);
            txtFirstName.TabIndex = 2;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(217, 43);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(357, 31);
            txtTitle.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(29, 443);
            label9.Name = "label9";
            label9.Size = new Size(197, 45);
            label9.TabIndex = 60;
            label9.Text = "Rollenprofil";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(674, 443);
            label10.Name = "label10";
            label10.Size = new Size(192, 45);
            label10.TabIndex = 61;
            label10.Text = "Ausbildung";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(675, 34);
            label11.Name = "label11";
            label11.Size = new Size(487, 45);
            label11.TabIndex = 62;
            label11.Text = "Kontakt / Adressinformationen";
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.72483F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.27517F));
            tableLayoutPanel4.Controls.Add(txtPhoneNumberBusiness, 1, 2);
            tableLayoutPanel4.Controls.Add(txtPhoneNumberMobile, 1, 1);
            tableLayoutPanel4.Controls.Add(txtPhoneNumberPrivate, 1, 0);
            tableLayoutPanel4.Controls.Add(txtPlace, 1, 6);
            tableLayoutPanel4.Controls.Add(txtZipCode, 1, 5);
            tableLayoutPanel4.Controls.Add(txtStreet, 1, 4);
            tableLayoutPanel4.Controls.Add(txtEmail, 1, 3);
            tableLayoutPanel4.Controls.Add(label32, 0, 6);
            tableLayoutPanel4.Controls.Add(label30, 0, 5);
            tableLayoutPanel4.Controls.Add(label25, 0, 4);
            tableLayoutPanel4.Controls.Add(label19, 0, 3);
            tableLayoutPanel4.Controls.Add(label16, 0, 2);
            tableLayoutPanel4.Controls.Add(label13, 0, 1);
            tableLayoutPanel4.Controls.Add(label15, 0, 0);
            tableLayoutPanel4.Location = new Point(675, 81);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.Padding = new Padding(12);
            tableLayoutPanel4.RowCount = 18;
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.RowStyles.Add(new RowStyle());
            tableLayoutPanel4.Size = new Size(627, 319);
            tableLayoutPanel4.TabIndex = 4;
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.HidePromptOnLeave = true;
            txtPhoneNumberBusiness.Location = new Point(218, 89);
            txtPhoneNumberBusiness.Mask = "+00 00 000 00 00";
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PromptChar = ' ';
            txtPhoneNumberBusiness.Size = new Size(357, 31);
            txtPhoneNumberBusiness.TabIndex = 2;
            txtPhoneNumberBusiness.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhoneNumberBusiness.MouseUp += txtPhoneNumber_MouseUp;
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.HidePromptOnLeave = true;
            txtPhoneNumberMobile.Location = new Point(218, 52);
            txtPhoneNumberMobile.Mask = "+00 00 000 00 00";
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PromptChar = ' ';
            txtPhoneNumberMobile.Size = new Size(357, 31);
            txtPhoneNumberMobile.TabIndex = 1;
            txtPhoneNumberMobile.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhoneNumberMobile.MouseUp += txtPhoneNumber_MouseUp;
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.HidePromptOnLeave = true;
            txtPhoneNumberPrivate.Location = new Point(218, 15);
            txtPhoneNumberPrivate.Mask = "+00 00 000 00 00";
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PromptChar = ' ';
            txtPhoneNumberPrivate.Size = new Size(357, 31);
            txtPhoneNumberPrivate.TabIndex = 0;
            txtPhoneNumberPrivate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhoneNumberPrivate.MouseUp += txtPhoneNumber_MouseUp;
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(218, 237);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(357, 31);
            txtPlace.TabIndex = 6;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(218, 200);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(357, 31);
            txtZipCode.TabIndex = 5;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(218, 163);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(357, 31);
            txtStreet.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(357, 31);
            txtEmail.TabIndex = 3;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label32.Location = new Point(15, 234);
            label32.Name = "label32";
            label32.Size = new Size(42, 28);
            label32.TabIndex = 78;
            label32.Text = "Ort";
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label30.Location = new Point(15, 197);
            label30.Name = "label30";
            label30.Size = new Size(115, 28);
            label30.TabIndex = 76;
            label30.Text = "Postleitzahl";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label25.Location = new Point(15, 160);
            label25.Name = "label25";
            label25.Size = new Size(75, 28);
            label25.TabIndex = 74;
            label25.Text = "Strasse";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label19.Location = new Point(15, 123);
            label19.Name = "label19";
            label19.Size = new Size(83, 28);
            label19.TabIndex = 72;
            label19.Text = "E-Mail *";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label16.Location = new Point(15, 86);
            label16.Name = "label16";
            label16.Size = new Size(195, 28);
            label16.TabIndex = 70;
            label16.Text = "Telefon Geschäftlich";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(15, 49);
            label13.Name = "label13";
            label13.Size = new Size(148, 28);
            label13.TabIndex = 68;
            label13.Text = "Telefon Mobile";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label15.Location = new Point(15, 12);
            label15.Name = "label15";
            label15.Size = new Size(136, 28);
            label15.TabIndex = 67;
            label15.Text = "Telefon Privat";
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(1190, 752);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 5;
            btnSave.Text = "Speichern";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Location = new Point(1069, 752);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Checked = true;
            chkActive.CheckState = CheckState.Checked;
            chkActive.Location = new Point(525, 50);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(78, 29);
            chkActive.TabIndex = 63;
            chkActive.Text = "Aktiv";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.DialogResult = DialogResult.Cancel;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(29, 752);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 64;
            btnDelete.Text = "Löschen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // EmployeeDetailForm
            // 
            AcceptButton = btnCancel;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1330, 803);
            Controls.Add(btnDelete);
            Controls.Add(chkActive);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(tableLayoutPanel4);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(tableLayoutPanel3);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(label1);
            Controls.Add(tableLayoutPanel1);
            MaximumSize = new Size(1352, 859);
            MinimumSize = new Size(1352, 859);
            Name = "EmployeeDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "EmployeeDetailForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudCadre).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudEmployment).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudTraineeYears).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudActualYear).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ErrorProvider errorProvider1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label28;
        private Label label1;
        private Label label18;
        private TextBox txtDepartment;
        private Label lblTitle;
        private DateTimePicker dtpStartDate;
        private DateTimePicker dtpEndDate;
        private Label label9;
        private TextBox txtRole;
        private Label lblKader;
        private NumericUpDown nudCadre;
        private NumericUpDown nudTraineeYears;
        private Label lblTraineeYears;
        private NumericUpDown nudActualYear;
        private Label lblActualYear;
        private CheckBox chckIsTrainee;
        private Label lblRole;
        private NumericUpDown nudEmployment;
        private Label lblEmployement;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label12;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox txtSalutation;
        private Label label2;
        private TextBox txtFirstName;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private Label label5;
        private TextBox txtLastName;
        private Label label4;
        private Label label6;
        private ComboBox cmbGender;
        private TextBox txtTitle;
        private Label label7;
        private TextBox txtNationality;
        private Label label8;
        private Label label11;
        private Label label10;
        private TableLayoutPanel tableLayoutPanel4;
        private Label label15;
        private Label label32;
        private Label label30;
        private Label label25;
        private Label label19;
        private Label label16;
        private Label label13;
        private TextBox txtPlace;
        private TextBox txtZipCode;
        private TextBox txtStreet;
        private TextBox txtEmail;
        private Button btnCancel;
        private Button btnSave;
        private MaskedTextBox txtSocialSecurityNumber;
        private CheckBox chkActive;
        private MaskedTextBox txtPhoneNumberPrivate;
        private MaskedTextBox txtPhoneNumberBusiness;
        private MaskedTextBox txtPhoneNumberMobile;
        private Label lblEmployeeNumber;
        private Label lblEmployeeNumberTitle;
        private Button btnDelete;
        //    private Label lblActualYear;
    }
}