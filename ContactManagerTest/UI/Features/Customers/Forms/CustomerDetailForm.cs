using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.Domain.Errors;

namespace ContactManager.WinForms
{
    public partial class CustomerDetailForm : Form
    {
        private readonly ICustomerService _customerService;

        private readonly ICustomerNoteService _noteService;
        private readonly ICustomerNoteRepository? _noteRepo;
        private readonly bool _isNew;

        private readonly List<CustomerNote> _customerNoteCache = new();

        public Customer Model { get; }

        public CustomerDetailForm(ICustomerService customerService,
                                  ICustomerNoteService noteService,
                                  ICustomerNoteRepository noteRepo,
                                  Customer? existing = null)
        {
            InitializeComponent();
            _customerService = customerService;
            _noteService = noteService;
            _noteRepo = noteRepo;

            _isNew = existing is null;
            Model = existing ?? new Customer();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _ = ReloadNotesAsync();

            Text = _isNew ? "Neuer Kunde" : "Kunde bearbeiten";

            btnDelete.Visible = !_isNew;


            chkActive.Checked = Model.Status;
            txtTitle.Text = Model.Title ?? string.Empty;
            txtSalutation.Text = Model.Salutation ?? string.Empty;

            txtFirstName.Text = Model.FirstName ?? string.Empty;
            txtLastName.Text = Model.LastName ?? string.Empty;
            cmbGender.SelectedIndex = Model.Gender ? 1 : 0;

            dtpBirthDate.Value = (Model.DateOfBirth ?? DateTime.Today).Date;

            txtSocialSecurityNumber.Text = Model.SocialSecurityNumber ?? string.Empty;
            txtNationality.Text = Model.Nationality ?? string.Empty;

            txtCompanyName.Text = Model.CompanyName ?? string.Empty;
            cmbCustomerType.SelectedItem = Model.CustomerType.HasValue ? Model.CustomerType.ToString() : null;
            txtCompanyContact.Text = Model.CompanyContact ?? string.Empty;

            txtPhoneNumberPrivate.Text = Model.PhoneNumberPrivate ?? string.Empty;
            txtPhoneNumberMobile.Text = Model.PhoneNumberMobile ?? string.Empty;
            txtPhoneNumberBusiness.Text = Model.PhoneNumberBusiness ?? string.Empty;
            txtEmail.Text = Model.Email ?? string.Empty;

            txtStreet.Text = Model.Street ?? string.Empty;
            txtZipCode.Text = Model.ZipCode.HasValue ? Model.ZipCode.Value.ToString() : string.Empty;
            txtPlace.Text = Model.Place ?? string.Empty;

            if (string.IsNullOrWhiteSpace(txtFirstName.Text) && string.IsNullOrWhiteSpace(txtCompanyName.Text))
                txtFirstName.Focus();
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                if (chkActive.Checked) Model.Activate(); else Model.Deactivate();

                Model.SetTitle(NullIfBlank(txtTitle.Text));
                Model.SetSalutation(NullIfBlank(txtSalutation.Text));

                Model.SetGender(cmbGender.SelectedIndex == 1);

                Model.SetName(txtFirstName.Text ?? "", txtLastName.Text ?? "");
                Model.SetBirthdate(dtpBirthDate.Value.Date);
                Model.SetEmail(NullIfBlank(txtEmail.Text));
                Model.SetPhones(NullIfBlank(txtPhoneNumberPrivate.Text),
                                NullIfBlank(txtPhoneNumberMobile.Text),
                                NullIfBlank(txtPhoneNumberBusiness.Text));

                Model.SetCompany(NullIfBlank(txtCompanyName.Text),
                                 NullIfBlank(txtCompanyContact.Text),
                                 (cmbCustomerType.SelectedItem is string s && s.Length > 0) ? s[0] : (char?)null);


                Model.SetAddress(NullIfBlank(txtStreet.Text),
                                 NullIfBlank(null),
                                 TryInt(txtZipCode.Text),
                                 NullIfBlank(txtPlace.Text),
                                 NullIfBlank(txtNationality.Text));

                Model.SetSocialSecurityNumber(NullIfBlank(txtSocialSecurityNumber.Text));

                if (_isNew) await _customerService.CreateAsync(Model);
                else await _customerService.UpdateAsync(Model);


                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DomainValidationException ex)
            {
                MapToFieldError(ex);
            }
        }

        private void MapToFieldError(DomainValidationException ex)
        {
            Control? target = ex.Field switch
            {
                "Email" => txtEmail,
                "ZipCode" => txtZipCode,
                "DateOfBirth" => dtpBirthDate,
                "PhoneNumberPrivate" => txtPhoneNumberPrivate,
                "PhoneNumberMobile" => txtPhoneNumberMobile,
                "PhoneNumberBusiness" => txtPhoneNumberBusiness,
                "CompanyName" => txtCompanyName,
                "Name" => txtFirstName, // or both first/last
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


        private async void btnNewCustomerNote_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                MessageBox.Show("Bitte zuerst den Kunden speichern, danach können Notizen erfasst werden.",
                                "Hinweis", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            using var dlg = new CustomerNoteForm(_noteService, Model);
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await ReloadNotesAsync();
            }
        }
        private async Task ReloadNotesAsync()
        {
            if (_noteRepo == null) return;

            if (_isNew)
            {
                _customerNoteCache.Clear();
                RefreshCustomerNotesList();
                return;
            }

            var list = await _noteRepo.GetForCustomerAsync(Model.Id);
            _customerNoteCache.Clear();
            _customerNoteCache.AddRange(list);
            RefreshCustomerNotesList();
        }

        private void RefreshCustomerNotesList()
        {
            lvCustomerNotes.BeginUpdate();
            try
            {
                lvCustomerNotes.Items.Clear();

                foreach (var note in _customerNoteCache.OrderByDescending(n => n.CreatedAt))
                {
                    var it = new ListViewItem(note.Note ?? "");
                    it.SubItems.Add(note.CreatedAt == default ? "" : note.CreatedAt.ToString("d"));
                    it.Tag = note;
                    lvCustomerNotes.Items.Add(it);
                }
            }
            finally
            {
                lvCustomerNotes.EndUpdate();
            }
        }

        private async void lvCustomerNotes_DoubleClick(object sender, EventArgs e)
        {
            if (lvCustomerNotes.SelectedItems.Count == 0) return;

            var note = (CustomerNote)lvCustomerNotes.SelectedItems[0].Tag!;
            using var dlg = new CustomerNoteForm(_noteService, Model, note);

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                await ReloadNotesAsync();
            }
        }

        private async void lvCustomerNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete || lvCustomerNotes.SelectedItems.Count == 0) return;

            var note = (CustomerNote)lvCustomerNotes.SelectedItems[0].Tag!;
            if (MessageBox.Show("Möchtest du die Notiz wirklich löschen?",
                "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                await _noteService.DeleteAsync(note);
                await ReloadNotesAsync();
            }
        }


        private static string? NullIfBlank(string? s)
            => string.IsNullOrWhiteSpace(s) ? null : s.Trim();

        private static int? TryInt(string? s)
            => int.TryParse((s ?? "").Trim(), out var n) ? n : (int?)null;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show($"„{Model.FirstName} {Model.LastName}“ löschen?",
                "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _customerService.DeleteAsync(Model);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void txtPhoneNumber_MouseUp(object sender, MouseEventArgs e)
        {
            if (sender is not MaskedTextBox m) return;

            // first editable position (after '+')
            int pos = m.MaskedTextProvider.FindEditPositionFrom(0, true);
            if (pos < 0) pos = 0;


            m.BeginInvoke(new Action(() =>
            {
                m.SelectionStart = pos;
                m.SelectionLength = 0;
            }));
        }
    }
}
