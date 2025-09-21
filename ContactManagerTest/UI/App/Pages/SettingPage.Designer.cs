namespace ContactManager.WinForms
{
    partial class SettingPage
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
            lblSettings = new Label();
            lblHint = new Label();
            pnlDrop = new Panel();
            btnDownloadSample = new Button();
            lblStatus = new Label();
            btnChooseFile = new Button();
            tblMain = new TableLayoutPanel();
            tlpRoot = new TableLayoutPanel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            pnlDrop.SuspendLayout();
            tblMain.SuspendLayout();
            tlpRoot.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSettings
            // 
            lblSettings.AutoSize = true;
            lblSettings.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            lblSettings.Location = new Point(3, 0);
            lblSettings.Name = "lblSettings";
            lblSettings.Size = new Size(371, 48);
            lblSettings.TabIndex = 0;
            lblSettings.Text = "Kontakte importieren";
            // 
            // lblHint
            // 
            lblHint.AutoSize = true;
            lblHint.Location = new Point(3, 54);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(750, 25);
            lblHint.TabIndex = 2;
            lblHint.Text = "Importieren Sie Kontakte aus CSV- oder vCard-Dateien. Unterstützte Formate: .csv, .vcf, .vcard";
            // 
            // pnlDrop
            // 
            pnlDrop.AllowDrop = true;
            pnlDrop.Controls.Add(btnDownloadSample);
            pnlDrop.Controls.Add(lblStatus);
            pnlDrop.Controls.Add(btnChooseFile);
            pnlDrop.Dock = DockStyle.Top;
            pnlDrop.Location = new Point(3, 94);
            pnlDrop.Name = "pnlDrop";
            pnlDrop.Size = new Size(1343, 301);
            pnlDrop.TabIndex = 3;
            pnlDrop.DragDrop += pnlDrop_DragDrop;
            pnlDrop.DragEnter += pnlDrop_DragEnter;
            pnlDrop.Paint += pnlDrop_Paint;
            // 
            // btnDownloadSample
            // 
            btnDownloadSample.Location = new Point(317, 225);
            btnDownloadSample.Name = "btnDownloadSample";
            btnDownloadSample.Size = new Size(283, 51);
            btnDownloadSample.TabIndex = 1;
            btnDownloadSample.Text = "Beispiel herunterladen";
            btnDownloadSample.UseVisualStyleBackColor = true;
            btnDownloadSample.Click += btnDownloadSample_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStatus.ForeColor = Color.ForestGreen;
            lblStatus.Location = new Point(619, 9);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(65, 25);
            lblStatus.TabIndex = 1;
            lblStatus.Text = "Status";
            // 
            // btnChooseFile
            // 
            btnChooseFile.Location = new Point(694, 225);
            btnChooseFile.Name = "btnChooseFile";
            btnChooseFile.Size = new Size(273, 51);
            btnChooseFile.TabIndex = 0;
            btnChooseFile.Text = "Datei auswählen";
            btnChooseFile.UseVisualStyleBackColor = true;
            btnChooseFile.Click += btnChooseFile_Click;
            // 
            // tblMain
            // 
            tblMain.AutoScroll = true;
            tblMain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tblMain.ColumnCount = 3;
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.ColumnStyles.Add(new ColumnStyle());
            tblMain.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tblMain.Controls.Add(tlpRoot, 1, 0);
            tblMain.Dock = DockStyle.Fill;
            tblMain.Location = new Point(0, 0);
            tblMain.Name = "tblMain";
            tblMain.RowCount = 1;
            tblMain.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblMain.Size = new Size(1393, 751);
            tblMain.TabIndex = 4;
            // 
            // tlpRoot
            // 
            tlpRoot.AutoSize = true;
            tlpRoot.ColumnCount = 1;
            tlpRoot.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpRoot.Controls.Add(flowLayoutPanel1, 0, 0);
            tlpRoot.Controls.Add(pnlDrop, 0, 2);
            tlpRoot.Controls.Add(lblHint, 0, 1);
            tlpRoot.Dock = DockStyle.Fill;
            tlpRoot.Location = new Point(22, 3);
            tlpRoot.Name = "tlpRoot";
            tlpRoot.RowCount = 3;
            tlpRoot.RowStyles.Add(new RowStyle());
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 5.43478251F));
            tlpRoot.RowStyles.Add(new RowStyle(SizeType.Percent, 94.5652161F));
            tlpRoot.Size = new Size(1349, 745);
            tlpRoot.TabIndex = 5;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(lblSettings);
            flowLayoutPanel1.Dock = DockStyle.Top;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(1343, 48);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.WrapContents = false;
            // 
            // SettingPage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblMain);
            Name = "SettingPage";
            Size = new Size(1393, 751);
            Load += SettingPage_Load;
            pnlDrop.ResumeLayout(false);
            pnlDrop.PerformLayout();
            tblMain.ResumeLayout(false);
            tblMain.PerformLayout();
            tlpRoot.ResumeLayout(false);
            tlpRoot.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSettings;
        private Label lblHint;
        private Panel pnlDrop;
        private Label lblStatus;
        private Button btnChooseFile;
        private Button btnDownloadSample;
        private TableLayoutPanel tblMain;
        private TableLayoutPanel tlpRoot;
        private FlowLayoutPanel flowLayoutPanel1;
    }
}
