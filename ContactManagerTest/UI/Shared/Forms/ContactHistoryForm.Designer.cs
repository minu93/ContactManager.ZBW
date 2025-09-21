namespace ContactManager.WinForms.UI.Shared.Forms
{
    partial class ContactHistoryForm
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
            lvHistory = new ListView();
            SuspendLayout();
            // 
            // lvHistory
            // 
            lvHistory.Dock = DockStyle.Fill;
            lvHistory.Location = new Point(0, 0);
            lvHistory.MultiSelect = false;
            lvHistory.Name = "lvHistory";
            lvHistory.Size = new Size(800, 450);
            lvHistory.TabIndex = 0;
            lvHistory.UseCompatibleStateImageBehavior = false;
            // 
            // ContactHistoryForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lvHistory);
            Name = "ContactHistoryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ContactHistoryForm";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvHistory;
    }
}