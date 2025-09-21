using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;
using ContactManager.Domain.Errors;

namespace ContactManager.WinForms
{
    public partial class CustomerNoteForm : Form
    {
        private readonly ICustomerNoteService _noteService;

        public CustomerNote Model { get; }
        private readonly bool _isNew;
        private readonly Customer _customer;

        public CustomerNoteForm(ICustomerNoteService noteService,
                                Customer customer,
                                CustomerNote? existing = null)
        {
            InitializeComponent();

            _noteService = noteService ?? throw new ArgumentNullException(nameof(noteService));
            _customer = customer ?? throw new ArgumentNullException(nameof(customer));

            _isNew = existing is null;
            Model = existing ?? new CustomerNote();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            Text = _isNew ? "Neue Notiz" : "Notiz bearbeiten";
            txtNote.Text = Model.Note ?? string.Empty;
            txtNote.ReadOnly = false;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            try
            {
                Model.SetNote(txtNote.Text);

                if (_isNew)
                {
                    Model.AssignToCustomer(_customer.Id);
                    Model.StampCreated();
                    await _noteService.CreateAsync(Model);
                }
                else
                {
                    await _noteService.UpdateAsync(Model);
                }

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (DomainValidationException ex)
            {
                // map to textbox so the user sees it right away
                errorProvider1.SetError(txtNote, ex.Message);
                txtNote.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Möchtest du die Notiz wirklich löschen?",
                "Löschen", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _noteService.DeleteAsync(Model);
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
