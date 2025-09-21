using ContactManager.Application.Abstractions;
using ContactManager.Domain.Entities;

namespace ContactManager.WinForms.UI.Features.Login.Forms
{
    public partial class LoginForm : Form
    {
        private readonly IAuthService _auth = null!;
        public User? SignedInUser { get; private set; }

        public LoginForm() { InitializeComponent(); } // Designer

        public LoginForm(IAuthService auth) : this()
        {
            _auth = auth ?? throw new ArgumentNullException(nameof(auth));
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            btnLogin.Enabled = false;
            try
            {
                var user = await _auth.LoginAsync(txtUser.Text, txtPassword.Text);
                if (user == null)
                {
                    lblError.Text = "Ungültiger Benutzername oder Passwort.";
                    txtPassword.SelectAll(); txtPassword.Focus();
                    return;
                }
                SignedInUser = user;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login fehlgeschlagen: " + ex.Message,
                    "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { btnLogin.Enabled = true; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }


    }
}
