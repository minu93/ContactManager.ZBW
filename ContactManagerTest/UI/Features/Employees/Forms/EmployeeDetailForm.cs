using System.Globalization;
using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.Domain.Errors;

namespace ContactManager.WinForms
{
    public partial class EmployeeDetailForm : Form
    {
        private readonly IEmployeeService _employeeService;

        public Employee Model { get; private set; }
        public bool ModelReplaced { get; private set; }
        private readonly bool _isNew;
        private readonly Employee? _original;

        public EmployeeDetailForm(IEmployeeService employeeService, Employee? existing = null)
        {
            InitializeComponent();
            _employeeService = employeeService ?? throw new ArgumentNullException(nameof(employeeService));
            _isNew = existing is null;
            Model = existing ?? new Employee();
            _original = existing;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Text = _isNew ? "Neuer Mitarbeiter" : "Mitarbeiter bearbeiten";

            // Personal Data
            lblEmployeeNumber.Visible = !_isNew;
            lblEmployeeNumberTitle.Visible = !_isNew;   

            if (!_isNew)
                lblEmployeeNumber.Text = Model.EmployeeNumber.ToString();

            chkActive.Checked = Model.Status;
            txtTitle.Text = Model.Title ?? string.Empty;
            txtSalutation.Text = Model.Salutation ?? string.Empty;
            txtFirstName.Text = Model.FirstName ?? string.Empty;
            txtLastName.Text = Model.LastName ?? string.Empty;
            cmbGender.SelectedIndex = Model.Gender ? 1 : 0;

            dtpBirthDate.Value = (Model.DateOfBirth ?? DateTime.Today).Date;

            txtSocialSecurityNumber.Text = Model.SocialSecurityNumber ?? string.Empty;
            txtNationality.Text = Model.Nationality ?? string.Empty;

            // Roleprofile
            txtDepartment.Text = Model.Department ?? string.Empty;

            dtpStartDate.Value = (Model.StartDate ?? DateTime.Today).Date;

            dtpEndDate.ShowCheckBox = true;
            dtpEndDate.Checked = Model.EndDate.HasValue;
            if (Model.EndDate.HasValue) dtpEndDate.Value = Model.EndDate.Value.Date;

            nudEmployment.Value = Model.Employment ?? 0;
            txtRole.Text = Model.Role ?? string.Empty;
            nudCadre.Value = Model.CadreLevel ?? 0;

            // Contact / Adress
            txtPhoneNumberPrivate.Text = Model.PhoneNumberPrivate ?? string.Empty;
            txtPhoneNumberMobile.Text = Model.PhoneNumberMobile ?? string.Empty;
            txtPhoneNumberBusiness.Text = Model.PhoneNumberBusiness ?? string.Empty;
            txtEmail.Text = Model.Email ?? string.Empty;
            txtStreet.Text = Model.Street ?? string.Empty;
            txtPlace.Text = Model.Place ?? string.Empty;
            txtZipCode.Text = Model.ZipCode.HasValue ? Model.ZipCode.Value.ToString() : string.Empty;

            // Trainee
            if (Model is Trainee t)
            {
                chckIsTrainee.Checked = true;
                nudTraineeYears.Value = t.TraineeYears ?? 0;
                nudActualYear.Value = t.ActualTraineeYear ?? 0;
            }
            else
            {
                chckIsTrainee.Checked = false;
                nudTraineeYears.Value = 0;
                nudActualYear.Value = 0;
            }

            chckIsTrainee.CheckedChanged -= chckIsTrainee_CheckedChanged;
            chckIsTrainee.CheckedChanged += chckIsTrainee_CheckedChanged;
            chckIsTrainee_CheckedChanged(chckIsTrainee, EventArgs.Empty);
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            try
            {
                if (chkActive.Checked) Model.Activate(); else Model.Deactivate();

                Model.SetTitle(TextOrNull(txtTitle));
                Model.SetSalutation(TextOrNull(txtSalutation));
                Model.SetName(txtFirstName.Text ?? "", txtLastName.Text ?? "");
                Model.SetGender(cmbGender.SelectedIndex == 1);


                Model.SetBirthdate(dtpBirthDate.Value.Date);

                Model.SetSocialSecurityNumber(TextOrNull(txtSocialSecurityNumber));
                Model.SetAddress(TextOrNull(txtStreet), null, IntOrNull(txtZipCode.Text), TextOrNull(txtPlace), TextOrNull(txtNationality));
                Model.SetEmail(TextOrNull(txtEmail));
                Model.SetPhones(TextOrNull(txtPhoneNumberPrivate), TextOrNull(txtPhoneNumberMobile), TextOrNull(txtPhoneNumberBusiness));

                // Employee-specific
                Model.SetDepartment(TextOrNull(txtDepartment));
                Model.SetStartDate(dtpStartDate.Value.Date);
                Model.SetEndDate(dtpEndDate.Checked ? dtpEndDate.Value.Date : (DateTime?)null);
                Model.SetEmployment((int)nudEmployment.Value);
                Model.SetRole(TextOrNull(txtRole));
                Model.SetCadreLevel((int)nudCadre.Value);

                // Trainee toggle/type switch
                bool wantTrainee = chckIsTrainee.Checked;
                if (wantTrainee && Model is not Trainee)
                {
                    var t = new Trainee();
                    CopyCommonTo(t);
                    CopyEmployeeTo(t);
                    t.SetTraineePlan((int)nudTraineeYears.Value <= 0 ? null : (int)nudTraineeYears.Value,
                                     (int)nudActualYear.Value <= 0 ? null : (int)nudActualYear.Value);
                    // replace & persist as delete+add
                    await ReplaceEmployeeAsync(t);
                }
                else if (!wantTrainee && Model is Trainee)
                {
                    var emp = new Employee();
                    CopyCommonTo(emp);
                    CopyEmployeeTo(emp);
                    await ReplaceEmployeeAsync(emp);
                }
                else
                {

                    if (Model is Trainee existingTrainee)
                    {
                        existingTrainee.SetTraineePlan(
                            nudTraineeYears.Value > 0 ? (int)nudTraineeYears.Value : (int?)null,
                            nudActualYear.Value > 0 ? (int)nudActualYear.Value : (int?)null
                        );
                    }
                    // Type unchanged
                    if (_isNew) await _employeeService.CreateAsync(Model);
                    else await _employeeService.UpdateAsync(Model);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DomainValidationException ex)
            {
                MapToFieldError(ex);
            }
        }

        private async Task ReplaceEmployeeAsync(Employee replacement)
        {
            if (_original != null)
                await _employeeService.DeleteAsync(_original);
            Model = replacement;
            ModelReplaced = true;
            await _employeeService.CreateAsync(Model);
        }


        private static string? TextOrNull(TextBoxBase tb)
        {
            var s = tb.Text?.Trim();
            return string.IsNullOrWhiteSpace(s) ? null : s;
        }

        private static int? IntOrNull(string? text)
        {
            if (string.IsNullOrWhiteSpace(text)) return null;
            return int.TryParse(text.Trim(), NumberStyles.Integer, CultureInfo.InvariantCulture, out var n)
                ? n
                : (int?)null;
        }

        private void CopyCommonTo(Employee e)
        {
            if (chkActive.Checked) e.Activate(); else e.Deactivate();

            e.SetTitle(TextOrNull(txtTitle));
            e.SetSalutation(TextOrNull(txtSalutation));
            e.SetName(txtFirstName.Text ?? "", txtLastName.Text ?? "");
            e.SetGender(cmbGender.SelectedIndex == 1);
            e.SetBirthdate(dtpBirthDate.Value);

            e.SetSocialSecurityNumber(TextOrNull(txtSocialSecurityNumber));
            e.SetAddress(TextOrNull(txtStreet), null, IntOrNull(txtZipCode.Text), TextOrNull(txtPlace), TextOrNull(txtNationality));
            e.SetEmail(TextOrNull(txtEmail));
            e.SetPhones(TextOrNull(txtPhoneNumberPrivate), TextOrNull(txtPhoneNumberMobile), TextOrNull(txtPhoneNumberBusiness));
        }

        private void CopyEmployeeTo(Employee e)
        {
            e.SetDepartment(TextOrNull(txtDepartment));
            e.SetStartDate(dtpStartDate.Value.Date);
            e.SetEndDate(dtpEndDate.Checked ? dtpEndDate.Value.Date : (DateTime?)null);
            e.SetEmployment((int)nudEmployment.Value);
            e.SetRole(TextOrNull(txtRole));
            e.SetCadreLevel((int)nudCadre.Value);
        }

        private void MapToFieldError(DomainValidationException ex)
        {

            Control? target = ex.Field switch
            {
                nameof(Employee.Salutation) => txtSalutation,
                nameof(Employee.LastName) => txtLastName,
                nameof(Employee.FirstName) => txtFirstName,
                nameof(Employee.DateOfBirth) => dtpBirthDate,
                nameof(Employee.Gender) => cmbGender,
                nameof(Employee.Title) => txtTitle,
                nameof(Employee.SocialSecurityNumber) => txtSocialSecurityNumber,
                nameof(Employee.PhoneNumberPrivate) => txtPhoneNumberPrivate,
                nameof(Employee.PhoneNumberMobile) => txtPhoneNumberMobile,
                nameof(Employee.PhoneNumberBusiness) => txtPhoneNumberBusiness,

                nameof(Employee.Email) => txtEmail,
                nameof(Employee.ZipCode) => txtZipCode,
                nameof(Employee.StartDate) => dtpStartDate,
                nameof(Employee.Department) => txtDepartment,
                nameof(Employee.Role) => txtRole,

                nameof(Employee.EndDate) => dtpEndDate,
                nameof(Employee.Employment) => nudEmployment,
                nameof(Employee.CadreLevel) => nudCadre,

                _ => null
            };

            if (target != null)
            {
                errorProvider1.SetError(target, ex.Message);
                target.Focus();
            }
            else
            {
                MessageBox.Show(ex.Message, "Eingabefehler", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void chckIsTrainee_CheckedChanged(object sender, EventArgs e)
        {
            bool show = chckIsTrainee.Checked;
            lblTraineeYears.Visible = show;
            nudTraineeYears.Visible = show;
            nudTraineeYears.Enabled = show;
            nudTraineeYears.TabStop = show;

            lblActualYear.Visible = show;
            nudActualYear.Visible = show;
            nudActualYear.Enabled = show;
            nudActualYear.TabStop = show;

            if (!show)
            {
                nudTraineeYears.Value = 0;
                nudActualYear.Value = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"„Möchten Sie {Model.FirstName} {Model.LastName}“ wirklich löschen?",
                    "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _employeeService.DeleteAsync(Model);
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void txtPhoneNumber_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is not MaskedTextBox m) return;

            int pos = m.MaskedTextProvider.FindEditPositionFrom(0,true);
            if (pos < 0) pos = 0;


            m.BeginInvoke(new Action(() =>
            {
                m.SelectionStart = pos;   
                m.SelectionLength = 0;
            }));
        }
    }
}
