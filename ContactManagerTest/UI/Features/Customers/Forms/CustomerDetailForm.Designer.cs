namespace ContactManager.WinForms
{
    partial class CustomerDetailForm
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
            tlpCustomerDetail = new TableLayoutPanel();
            dtpBirthDate = new DateTimePicker();
            txtTitle = new TextBox();
            lblTitle = new Label();
            label2 = new Label();
            txtSalutation = new TextBox();
            lblFirstName = new Label();
            txtFirstName = new TextBox();
            lblLastName = new Label();
            txtLastName = new TextBox();
            lblGender = new Label();
            cmbGender = new ComboBox();
            lblBirthDate = new Label();
            label8 = new Label();
            label7 = new Label();
            txtNationality = new TextBox();
            txtSocialSecurityNumber = new MaskedTextBox();
            txtCompanyContact = new TextBox();
            LblCompanyContact = new Label();
            txtCompanyName = new TextBox();
            lblCompanyName = new Label();
            chkActive = new CheckBox();
            cmbCustomerType = new ComboBox();
            btnCancel = new Button();
            btnSave = new Button();
            errorProvider1 = new ErrorProvider(components);
            btnNewCustomerNote = new Button();
            lblCustomerNotesTitle = new Label();
            lvCustomerNotes = new ListView();
            colNote = new ColumnHeader();
            colCreatedAt = new ColumnHeader();
            label1 = new Label();
            tlpCustomerContact = new TableLayoutPanel();
            txtPhoneNumberBusiness = new MaskedTextBox();
            txtPlace = new TextBox();
            txtPhoneNumberMobile = new MaskedTextBox();
            txtZipCode = new TextBox();
            txtPhoneNumberPrivate = new MaskedTextBox();
            txtStreet = new TextBox();
            txtEmail = new TextBox();
            label32 = new Label();
            label30 = new Label();
            label25 = new Label();
            label19 = new Label();
            label16 = new Label();
            label13 = new Label();
            label15 = new Label();
            label11 = new Label();
            tlpCustomerInfo = new TableLayoutPanel();
            label3 = new Label();
            label17 = new Label();
            btnDelete = new Button();
            tlpCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            tlpCustomerContact.SuspendLayout();
            tlpCustomerInfo.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerDetail
            // 
            tlpCustomerDetail.ColumnCount = 2;
            tlpCustomerDetail.ColumnStyles.Add(new ColumnStyle());
            tlpCustomerDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerDetail.Controls.Add(dtpBirthDate, 1, 5);
            tlpCustomerDetail.Controls.Add(txtTitle, 1, 0);
            tlpCustomerDetail.Controls.Add(lblTitle, 0, 0);
            tlpCustomerDetail.Controls.Add(label2, 0, 1);
            tlpCustomerDetail.Controls.Add(txtSalutation, 1, 1);
            tlpCustomerDetail.Controls.Add(lblFirstName, 0, 2);
            tlpCustomerDetail.Controls.Add(txtFirstName, 1, 2);
            tlpCustomerDetail.Controls.Add(lblLastName, 0, 3);
            tlpCustomerDetail.Controls.Add(txtLastName, 1, 3);
            tlpCustomerDetail.Controls.Add(lblGender, 0, 4);
            tlpCustomerDetail.Controls.Add(cmbGender, 1, 4);
            tlpCustomerDetail.Controls.Add(lblBirthDate, 0, 5);
            tlpCustomerDetail.Controls.Add(label8, 0, 7);
            tlpCustomerDetail.Controls.Add(label7, 0, 6);
            tlpCustomerDetail.Controls.Add(txtNationality, 1, 7);
            tlpCustomerDetail.Controls.Add(txtSocialSecurityNumber, 1, 6);
            tlpCustomerDetail.Location = new Point(34, 70);
            tlpCustomerDetail.Name = "tlpCustomerDetail";
            tlpCustomerDetail.Padding = new Padding(12);
            tlpCustomerDetail.RowCount = 12;
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.RowStyles.Add(new RowStyle());
            tlpCustomerDetail.Size = new Size(567, 342);
            tlpCustomerDetail.TabIndex = 0;
            // 
            // dtpBirthDate
            // 
            dtpBirthDate.CustomFormat = "dd.MM.yyyy";
            dtpBirthDate.Format = DateTimePickerFormat.Custom;
            dtpBirthDate.Location = new Point(180, 202);
            dtpBirthDate.MaxDate = new DateTime(2999, 9, 20, 0, 0, 0, 0);
            dtpBirthDate.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            dtpBirthDate.Name = "dtpBirthDate";
            dtpBirthDate.Size = new Size(347, 31);
            dtpBirthDate.TabIndex = 5;
            dtpBirthDate.Value = new DateTime(1990, 1, 1, 21, 20, 0, 0);
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(180, 15);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(347, 31);
            txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblTitle.Location = new Point(15, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(51, 28);
            lblTitle.TabIndex = 16;
            lblTitle.Text = "Titel";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label2.Location = new Point(15, 49);
            label2.Name = "label2";
            label2.Size = new Size(78, 28);
            label2.TabIndex = 18;
            label2.Text = "Anrede";
            // 
            // txtSalutation
            // 
            txtSalutation.Location = new Point(180, 52);
            txtSalutation.Name = "txtSalutation";
            txtSalutation.Size = new Size(347, 31);
            txtSalutation.TabIndex = 1;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblFirstName.Location = new Point(15, 86);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(109, 28);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "Vorname *";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(180, 89);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(347, 31);
            txtFirstName.TabIndex = 2;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblLastName.Location = new Point(15, 123);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(124, 28);
            lblLastName.TabIndex = 3;
            lblLastName.Text = "Nachname *";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(180, 126);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(347, 31);
            txtLastName.TabIndex = 3;
            // 
            // lblGender
            // 
            lblGender.AutoSize = true;
            lblGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblGender.Location = new Point(15, 160);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(111, 28);
            lblGender.TabIndex = 8;
            lblGender.Text = "Geschlecht";
            // 
            // cmbGender
            // 
            cmbGender.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbGender.FormattingEnabled = true;
            cmbGender.Items.AddRange(new object[] { "Männlich", "Weiblich" });
            cmbGender.Location = new Point(180, 163);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(347, 33);
            cmbGender.TabIndex = 4;
            // 
            // lblBirthDate
            // 
            lblBirthDate.AutoSize = true;
            lblBirthDate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblBirthDate.Location = new Point(15, 199);
            lblBirthDate.Name = "lblBirthDate";
            lblBirthDate.Size = new Size(159, 28);
            lblBirthDate.TabIndex = 6;
            lblBirthDate.Text = "Geburtsdatum *";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label8.Location = new Point(15, 273);
            label8.Name = "label8";
            label8.Size = new Size(117, 28);
            label8.TabIndex = 76;
            label8.Text = "Nationalität";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label7.Location = new Point(15, 236);
            label7.Name = "label7";
            label7.Size = new Size(140, 28);
            label7.TabIndex = 75;
            label7.Text = "AHV Nummer";
            // 
            // txtNationality
            // 
            txtNationality.Location = new Point(180, 276);
            txtNationality.Name = "txtNationality";
            txtNationality.Size = new Size(347, 31);
            txtNationality.TabIndex = 7;
            // 
            // txtSocialSecurityNumber
            // 
            txtSocialSecurityNumber.HidePromptOnLeave = true;
            txtSocialSecurityNumber.Location = new Point(180, 239);
            txtSocialSecurityNumber.Mask = "000.0000.0000.00";
            txtSocialSecurityNumber.Name = "txtSocialSecurityNumber";
            txtSocialSecurityNumber.PromptChar = ' ';
            txtSocialSecurityNumber.RejectInputOnFirstFailure = true;
            txtSocialSecurityNumber.Size = new Size(347, 31);
            txtSocialSecurityNumber.TabIndex = 6;
            txtSocialSecurityNumber.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCompanyContact
            // 
            txtCompanyContact.Location = new Point(196, 15);
            txtCompanyContact.Name = "txtCompanyContact";
            txtCompanyContact.Size = new Size(331, 31);
            txtCompanyContact.TabIndex = 0;
            // 
            // LblCompanyContact
            // 
            LblCompanyContact.AutoSize = true;
            LblCompanyContact.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            LblCompanyContact.Location = new Point(15, 12);
            LblCompanyContact.Name = "LblCompanyContact";
            LblCompanyContact.Size = new Size(175, 28);
            LblCompanyContact.TabIndex = 22;
            LblCompanyContact.Text = "Ansprechperson *";
            // 
            // txtCompanyName
            // 
            txtCompanyName.Location = new Point(196, 52);
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.Size = new Size(331, 31);
            txtCompanyName.TabIndex = 1;
            // 
            // lblCompanyName
            // 
            lblCompanyName.AutoSize = true;
            lblCompanyName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            lblCompanyName.Location = new Point(15, 49);
            lblCompanyName.Name = "lblCompanyName";
            lblCompanyName.Size = new Size(77, 28);
            lblCompanyName.TabIndex = 18;
            lblCompanyName.Text = "Firma *";
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Checked = true;
            chkActive.CheckState = CheckState.Checked;
            chkActive.Location = new Point(483, 35);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(78, 29);
            chkActive.TabIndex = 8;
            chkActive.Text = "Aktiv";
            chkActive.UseVisualStyleBackColor = true;
            // 
            // cmbCustomerType
            // 
            cmbCustomerType.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbCustomerType.FormattingEnabled = true;
            cmbCustomerType.Items.AddRange(new object[] { "A", "B", "C", "D", "E" });
            cmbCustomerType.Location = new Point(196, 89);
            cmbCustomerType.Name = "cmbCustomerType";
            cmbCustomerType.Size = new Size(331, 33);
            cmbCustomerType.TabIndex = 2;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(1013, 854);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 7;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(1150, 854);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 6;
            btnSave.Text = "Speichern";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // btnNewCustomerNote
            // 
            btnNewCustomerNote.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNewCustomerNote.AutoSize = true;
            btnNewCustomerNote.FlatStyle = FlatStyle.Flat;
            btnNewCustomerNote.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewCustomerNote.Location = new Point(1078, 445);
            btnNewCustomerNote.Name = "btnNewCustomerNote";
            btnNewCustomerNote.Padding = new Padding(10, 6, 10, 6);
            btnNewCustomerNote.Size = new Size(177, 52);
            btnNewCustomerNote.TabIndex = 5;
            btnNewCustomerNote.Text = "+ Neue Notiz";
            btnNewCustomerNote.UseVisualStyleBackColor = true;
            btnNewCustomerNote.Click += btnNewCustomerNote_Click;
            // 
            // lblCustomerNotesTitle
            // 
            lblCustomerNotesTitle.AutoSize = true;
            lblCustomerNotesTitle.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCustomerNotesTitle.Location = new Point(628, 449);
            lblCustomerNotesTitle.Name = "lblCustomerNotesTitle";
            lblCustomerNotesTitle.Size = new Size(149, 48);
            lblCustomerNotesTitle.TabIndex = 2;
            lblCustomerNotesTitle.Text = "Notizen";
            // 
            // lvCustomerNotes
            // 
            lvCustomerNotes.Columns.AddRange(new ColumnHeader[] { colNote, colCreatedAt });
            lvCustomerNotes.FullRowSelect = true;
            lvCustomerNotes.Location = new Point(628, 500);
            lvCustomerNotes.MultiSelect = false;
            lvCustomerNotes.Name = "lvCustomerNotes";
            lvCustomerNotes.Size = new Size(634, 293);
            lvCustomerNotes.TabIndex = 4;
            lvCustomerNotes.UseCompatibleStateImageBehavior = false;
            lvCustomerNotes.View = View.Details;
            lvCustomerNotes.DoubleClick += lvCustomerNotes_DoubleClick;
            lvCustomerNotes.KeyDown += lvCustomerNote_KeyDown;
            // 
            // colNote
            // 
            colNote.Text = "Notiz";
            colNote.Width = 200;
            // 
            // colCreatedAt
            // 
            colCreatedAt.Text = "Erstellt am";
            colCreatedAt.Width = 200;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 22);
            label1.Name = "label1";
            label1.Size = new Size(335, 45);
            label1.TabIndex = 41;
            label1.Text = "Persönliche Angaben";
            // 
            // tlpCustomerContact
            // 
            tlpCustomerContact.ColumnCount = 2;
            tlpCustomerContact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.72483F));
            tlpCustomerContact.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.27517F));
            tlpCustomerContact.Controls.Add(txtPhoneNumberBusiness, 1, 2);
            tlpCustomerContact.Controls.Add(txtPlace, 1, 6);
            tlpCustomerContact.Controls.Add(txtPhoneNumberMobile, 1, 1);
            tlpCustomerContact.Controls.Add(txtZipCode, 1, 5);
            tlpCustomerContact.Controls.Add(txtPhoneNumberPrivate, 1, 0);
            tlpCustomerContact.Controls.Add(txtStreet, 1, 4);
            tlpCustomerContact.Controls.Add(txtEmail, 1, 3);
            tlpCustomerContact.Controls.Add(label32, 0, 6);
            tlpCustomerContact.Controls.Add(label30, 0, 5);
            tlpCustomerContact.Controls.Add(label25, 0, 4);
            tlpCustomerContact.Controls.Add(label19, 0, 3);
            tlpCustomerContact.Controls.Add(label16, 0, 2);
            tlpCustomerContact.Controls.Add(label13, 0, 1);
            tlpCustomerContact.Controls.Add(label15, 0, 0);
            tlpCustomerContact.Location = new Point(628, 70);
            tlpCustomerContact.Name = "tlpCustomerContact";
            tlpCustomerContact.Padding = new Padding(12);
            tlpCustomerContact.RowCount = 18;
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.RowStyles.Add(new RowStyle());
            tlpCustomerContact.Size = new Size(627, 319);
            tlpCustomerContact.TabIndex = 2;
            // 
            // txtPhoneNumberBusiness
            // 
            txtPhoneNumberBusiness.HidePromptOnLeave = true;
            txtPhoneNumberBusiness.Location = new Point(218, 89);
            txtPhoneNumberBusiness.Mask = "+00 00 000 00 00";
            txtPhoneNumberBusiness.Name = "txtPhoneNumberBusiness";
            txtPhoneNumberBusiness.PromptChar = ' ';
            txtPhoneNumberBusiness.Size = new Size(365, 31);
            txtPhoneNumberBusiness.TabIndex = 2;
            txtPhoneNumberBusiness.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhoneNumberBusiness.MouseUp += txtPhoneNumber_MouseUp;
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(218, 237);
            txtPlace.Name = "txtPlace";
            txtPlace.Size = new Size(365, 31);
            txtPlace.TabIndex = 6;
            // 
            // txtPhoneNumberMobile
            // 
            txtPhoneNumberMobile.HidePromptOnLeave = true;
            txtPhoneNumberMobile.Location = new Point(218, 52);
            txtPhoneNumberMobile.Mask = "+00 00 000 00 00";
            txtPhoneNumberMobile.Name = "txtPhoneNumberMobile";
            txtPhoneNumberMobile.PromptChar = ' ';
            txtPhoneNumberMobile.Size = new Size(365, 31);
            txtPhoneNumberMobile.TabIndex = 1;
            txtPhoneNumberMobile.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhoneNumberMobile.MouseUp += txtPhoneNumber_MouseUp;
            // 
            // txtZipCode
            // 
            txtZipCode.Location = new Point(218, 200);
            txtZipCode.Name = "txtZipCode";
            txtZipCode.Size = new Size(365, 31);
            txtZipCode.TabIndex = 5;
            // 
            // txtPhoneNumberPrivate
            // 
            txtPhoneNumberPrivate.HidePromptOnLeave = true;
            txtPhoneNumberPrivate.Location = new Point(218, 15);
            txtPhoneNumberPrivate.Mask = "+00 00 000 00 00";
            txtPhoneNumberPrivate.Name = "txtPhoneNumberPrivate";
            txtPhoneNumberPrivate.PromptChar = ' ';
            txtPhoneNumberPrivate.Size = new Size(365, 31);
            txtPhoneNumberPrivate.TabIndex = 0;
            txtPhoneNumberPrivate.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            txtPhoneNumberPrivate.MouseUp += txtPhoneNumber_MouseUp;
            // 
            // txtStreet
            // 
            txtStreet.Location = new Point(218, 163);
            txtStreet.Name = "txtStreet";
            txtStreet.Size = new Size(365, 31);
            txtStreet.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(218, 126);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(365, 31);
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
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(628, 23);
            label11.Name = "label11";
            label11.Size = new Size(487, 45);
            label11.TabIndex = 64;
            label11.Text = "Kontakt / Adressinformationen";
            // 
            // tlpCustomerInfo
            // 
            tlpCustomerInfo.ColumnCount = 2;
            tlpCustomerInfo.ColumnStyles.Add(new ColumnStyle());
            tlpCustomerInfo.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerInfo.Controls.Add(label3, 0, 11);
            tlpCustomerInfo.Controls.Add(cmbCustomerType, 1, 11);
            tlpCustomerInfo.Controls.Add(lblCompanyName, 0, 7);
            tlpCustomerInfo.Controls.Add(LblCompanyContact, 0, 0);
            tlpCustomerInfo.Controls.Add(txtCompanyContact, 1, 0);
            tlpCustomerInfo.Controls.Add(txtCompanyName, 1, 7);
            tlpCustomerInfo.Location = new Point(34, 503);
            tlpCustomerInfo.Name = "tlpCustomerInfo";
            tlpCustomerInfo.Padding = new Padding(12);
            tlpCustomerInfo.RowCount = 3;
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.RowStyles.Add(new RowStyle());
            tlpCustomerInfo.Size = new Size(567, 146);
            tlpCustomerInfo.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            label3.Location = new Point(15, 86);
            label3.Name = "label3";
            label3.Size = new Size(127, 28);
            label3.TabIndex = 24;
            label3.Text = "Kundentyp *";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label17.Location = new Point(34, 455);
            label17.Name = "label17";
            label17.Size = new Size(195, 45);
            label17.TabIndex = 66;
            label17.Text = "Kundeninfo";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(34, 854);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 67;
            btnDelete.Text = "Löschen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // CustomerDetailForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(1295, 902);
            Controls.Add(btnDelete);
            Controls.Add(label17);
            Controls.Add(tlpCustomerInfo);
            Controls.Add(tlpCustomerContact);
            Controls.Add(label11);
            Controls.Add(btnCancel);
            Controls.Add(label1);
            Controls.Add(btnSave);
            Controls.Add(btnNewCustomerNote);
            Controls.Add(lvCustomerNotes);
            Controls.Add(lblCustomerNotesTitle);
            Controls.Add(tlpCustomerDetail);
            Controls.Add(chkActive);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximumSize = new Size(1317, 958);
            MinimizeBox = false;
            MinimumSize = new Size(1317, 958);
            Name = "CustomerDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CustomerDetailForm";
            tlpCustomerDetail.ResumeLayout(false);
            tlpCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            tlpCustomerContact.ResumeLayout(false);
            tlpCustomerContact.PerformLayout();
            tlpCustomerInfo.ResumeLayout(false);
            tlpCustomerInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpCustomerDetail;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblBirthDate;
        private TextBox txtLastName;
        private TextBox txtFirstName;
        private Label lblGender;
        private ComboBox cmbGender;
        private TextBox txtCompanyContact;
        private Label LblCompanyContact;
        private TextBox txtCompanyName;
        private Label lblCompanyName;
        private CheckBox chkActive;
        private ComboBox cmbCustomerType;
        private Button btnCancel;
        private Button btnSave;
        private ErrorProvider errorProvider1;
        private Label lblCustomerNotesTitle;
        private Button btnNewCustomerNote;
        private ListView lvCustomerNotes;
        private ColumnHeader colNote;
        private ColumnHeader colCreatedAt;
        private Label label1;
        private TextBox txtTitle;
        private Label lblTitle;
        private Label label2;
        private TextBox txtSalutation;
        private Label label8;
        private Label label7;
        private TextBox txtNationality;
        private MaskedTextBox txtSocialSecurityNumber;
        private TableLayoutPanel tlpCustomerContact;
        private TextBox txtPlace;
        private TextBox txtZipCode;
        private TextBox txtStreet;
        private TextBox txtEmail;
        private Label label32;
        private Label label30;
        private Label label25;
        private Label label19;
        private Label label16;
        private Label label13;
        private Label label15;
        private Label label11;
        private Label label17;
        private TableLayoutPanel tlpCustomerInfo;
        private Label label3;
        private DateTimePicker dtpBirthDate;
        private MaskedTextBox txtPhoneNumberBusiness;
        private MaskedTextBox txtPhoneNumberMobile;
        private MaskedTextBox txtPhoneNumberPrivate;
        private Button btnDelete;
    }
}