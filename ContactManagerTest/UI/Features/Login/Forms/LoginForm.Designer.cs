namespace ContactManager.WinForms.UI.Features.Login.Forms
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblError = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblhint = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtUser
            // 
            txtUser.Location = new Point(34, 272);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(385, 31);
            txtUser.TabIndex = 0;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(34, 364);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(385, 31);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Location = new Point(34, 407);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(385, 34);
            btnLogin.TabIndex = 2;
            btnLogin.Text = "Anmelden";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblError
            // 
            lblError.AutoSize = true;
            lblError.ForeColor = Color.Red;
            lblError.Location = new Point(37, 194);
            lblError.Name = "lblError";
            lblError.Size = new Size(0, 25);
            lblError.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(67, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(308, 171);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 240);
            label1.Name = "label1";
            label1.Size = new Size(124, 25);
            label1.TabIndex = 6;
            label1.Text = "Benutzername";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 330);
            label2.Name = "label2";
            label2.Size = new Size(82, 25);
            label2.TabIndex = 7;
            label2.Text = "Passwort";
            // 
            // lblhint
            // 
            lblhint.AutoSize = true;
            lblhint.Font = new Font("Segoe UI Semilight", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhint.Location = new Point(107, 483);
            lblhint.Name = "lblhint";
            lblhint.Size = new Size(218, 25);
            lblhint.TabIndex = 8;
            lblhint.Text = "Zugang: admin / admin123";
            // 
            // LoginForm
            // 
            AcceptButton = btnLogin;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(458, 530);
            Controls.Add(lblhint);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(lblError);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "GeniusCRM - Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtUser;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblError;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label lblhint;
    }
}