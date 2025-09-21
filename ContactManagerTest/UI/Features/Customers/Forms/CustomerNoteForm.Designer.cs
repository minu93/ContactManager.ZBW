namespace ContactManager.WinForms
{
    partial class CustomerNoteForm
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
            pnlActions = new Panel();
            btnDelete = new Button();
            btnCancel = new Button();
            btnSave = new Button();
            txtNote = new TextBox();
            lblNote = new Label();
            tlpCustomerDetail = new TableLayoutPanel();
            errorProvider1 = new ErrorProvider(components);
            pnlActions.SuspendLayout();
            tlpCustomerDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // pnlActions
            // 
            pnlActions.Controls.Add(btnDelete);
            pnlActions.Controls.Add(btnCancel);
            pnlActions.Controls.Add(btnSave);
            pnlActions.Dock = DockStyle.Bottom;
            pnlActions.Location = new Point(15, 284);
            pnlActions.Name = "pnlActions";
            pnlActions.Size = new Size(590, 41);
            pnlActions.TabIndex = 24;
            // 
            // btnDelete
            // 
            btnDelete.DialogResult = DialogResult.Cancel;
            btnDelete.Location = new Point(3, 2);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 34);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Löschen";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(357, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(112, 34);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Abbrechen";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(475, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(112, 34);
            btnSave.TabIndex = 0;
            btnSave.Text = "Speichern";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(15, 43);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(584, 218);
            txtNote.TabIndex = 4;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNote.Location = new Point(15, 12);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(60, 28);
            lblNote.TabIndex = 1;
            lblNote.Text = "Notiz";
            // 
            // tlpCustomerDetail
            // 
            tlpCustomerDetail.ColumnCount = 1;
            tlpCustomerDetail.ColumnStyles.Add(new ColumnStyle());
            tlpCustomerDetail.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerDetail.Controls.Add(lblNote, 0, 0);
            tlpCustomerDetail.Controls.Add(txtNote, 1, 0);
            tlpCustomerDetail.Controls.Add(pnlActions, 1, 11);
            tlpCustomerDetail.Dock = DockStyle.Left;
            tlpCustomerDetail.Location = new Point(0, 0);
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
            tlpCustomerDetail.Size = new Size(620, 340);
            tlpCustomerDetail.TabIndex = 1;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // CustomerNoteForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(611, 340);
            Controls.Add(tlpCustomerDetail);
            Name = "CustomerNoteForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CustomerNoteForm";
            pnlActions.ResumeLayout(false);
            tlpCustomerDetail.ResumeLayout(false);
            tlpCustomerDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlActions;
        private Button btnCancel;
        private Button btnSave;
        private TextBox txtNote;
        private Label lblNote;
        private TableLayoutPanel tlpCustomerDetail;
        private ErrorProvider errorProvider1;
        private Button btnDelete;
    }
}