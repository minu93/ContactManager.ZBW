namespace ContactManagerTest
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            tlpNav = new TableLayoutPanel();
            pictureBox1 = new PictureBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnDashboard = new Button();
            btnCustomer = new Button();
            btnEmployee = new Button();
            btnSettings = new Button();
            flpTabs = new FlowLayoutPanel();
            colorDialog1 = new ColorDialog();
            tabSettings = new TabPage();
            tabMain = new TabControl();
            tabDashboard = new TabPage();
            tabCustomer = new TabPage();
            tabEmployee = new TabPage();
            tlpNav.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            tabMain.SuspendLayout();
            SuspendLayout();
            // 
            // tlpNav
            // 
            tlpNav.BackColor = SystemColors.Window;
            tlpNav.ColumnCount = 3;
            tlpNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNav.ColumnStyles.Add(new ColumnStyle());
            tlpNav.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpNav.Controls.Add(pictureBox1, 0, 0);
            tlpNav.Controls.Add(flowLayoutPanel1, 1, 0);
            tlpNav.Dock = DockStyle.Top;
            tlpNav.Location = new Point(0, 0);
            tlpNav.Margin = new Padding(0);
            tlpNav.Name = "tlpNav";
            tlpNav.Padding = new Padding(8, 8, 8, 0);
            tlpNav.RowCount = 1;
            tlpNav.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tlpNav.Size = new Size(1385, 70);
            tlpNav.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(227, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(btnDashboard);
            flowLayoutPanel1.Controls.Add(btnCustomer);
            flowLayoutPanel1.Controls.Add(btnEmployee);
            flowLayoutPanel1.Controls.Add(btnSettings);
            flowLayoutPanel1.Location = new Point(421, 8);
            flowLayoutPanel1.Margin = new Padding(0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(542, 40);
            flowLayoutPanel1.TabIndex = 1;
            flowLayoutPanel1.WrapContents = false;
            // 
            // btnDashboard
            // 
            btnDashboard.AutoSize = true;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Location = new Point(6, 0);
            btnDashboard.Margin = new Padding(6, 0, 6, 0);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(120, 40);
            btnDashboard.TabIndex = 1;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += Nav_Click;
            // 
            // btnCustomer
            // 
            btnCustomer.AutoSize = true;
            btnCustomer.FlatStyle = FlatStyle.Flat;
            btnCustomer.Location = new Point(138, 0);
            btnCustomer.Margin = new Padding(6, 0, 6, 0);
            btnCustomer.Name = "btnCustomer";
            btnCustomer.Size = new Size(112, 40);
            btnCustomer.TabIndex = 2;
            btnCustomer.Text = "Kunden";
            btnCustomer.UseVisualStyleBackColor = false;
            btnCustomer.Click += Nav_Click;
            // 
            // btnEmployee
            // 
            btnEmployee.AutoSize = true;
            btnEmployee.FlatStyle = FlatStyle.Flat;
            btnEmployee.Location = new Point(262, 0);
            btnEmployee.Margin = new Padding(6, 0, 6, 0);
            btnEmployee.Name = "btnEmployee";
            btnEmployee.Size = new Size(122, 40);
            btnEmployee.TabIndex = 3;
            btnEmployee.Text = "Mitarbeiter";
            btnEmployee.UseVisualStyleBackColor = false;
            btnEmployee.Click += Nav_Click;
            // 
            // btnSettings
            // 
            btnSettings.AutoSize = true;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(396, 0);
            btnSettings.Margin = new Padding(6, 0, 6, 0);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(140, 40);
            btnSettings.TabIndex = 4;
            btnSettings.Text = "Einstellungen";
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += Nav_Click;
            // 
            // flpTabs
            // 
            flpTabs.AutoSize = true;
            flpTabs.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flpTabs.BackColor = Color.White;
            flpTabs.ForeColor = SystemColors.ControlText;
            flpTabs.Location = new Point(772, 8);
            flpTabs.Margin = new Padding(0);
            flpTabs.Name = "flpTabs";
            flpTabs.Size = new Size(0, 0);
            flpTabs.TabIndex = 0;
            flpTabs.WrapContents = false;
            // 
            // tabSettings
            // 
            tabSettings.Location = new Point(4, 5);
            tabSettings.Name = "tabSettings";
            tabSettings.Padding = new Padding(3);
            tabSettings.Size = new Size(1377, 588);
            tabSettings.TabIndex = 3;
            tabSettings.Text = "Einstellungen";
            tabSettings.UseVisualStyleBackColor = true;
            // 
            // tabMain
            // 
            tabMain.Controls.Add(tabDashboard);
            tabMain.Controls.Add(tabCustomer);
            tabMain.Controls.Add(tabEmployee);
            tabMain.Controls.Add(tabSettings);
            tabMain.Dock = DockStyle.Fill;
            tabMain.ItemSize = new Size(0, 1);
            tabMain.Location = new Point(0, 70);
            tabMain.Name = "tabMain";
            tabMain.Padding = new Point(0, 0);
            tabMain.SelectedIndex = 0;
            tabMain.Size = new Size(1385, 698);
            tabMain.SizeMode = TabSizeMode.Fixed;
            tabMain.TabIndex = 1;
            tabMain.TabStop = false;
            // 
            // tabDashboard
            // 
            tabDashboard.Location = new Point(4, 5);
            tabDashboard.Name = "tabDashboard";
            tabDashboard.Padding = new Padding(3);
            tabDashboard.Size = new Size(1377, 689);
            tabDashboard.TabIndex = 0;
            tabDashboard.Text = "Dashboard";
            tabDashboard.UseVisualStyleBackColor = true;
            // 
            // tabCustomer
            // 
            tabCustomer.Location = new Point(4, 5);
            tabCustomer.Name = "tabCustomer";
            tabCustomer.Padding = new Padding(3);
            tabCustomer.Size = new Size(1377, 588);
            tabCustomer.TabIndex = 1;
            tabCustomer.Text = "Kunden";
            tabCustomer.UseVisualStyleBackColor = true;
            // 
            // tabEmployee
            // 
            tabEmployee.Location = new Point(4, 5);
            tabEmployee.Name = "tabEmployee";
            tabEmployee.Padding = new Padding(3);
            tabEmployee.Size = new Size(1377, 588);
            tabEmployee.TabIndex = 2;
            tabEmployee.Text = "Mitarbeiter";
            tabEmployee.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1385, 768);
            Controls.Add(tabMain);
            Controls.Add(tlpNav);
            Font = new Font("Segoe UI", 10F);
            MinimumSize = new Size(1407, 824);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ContactManager";
            Load += FormMain_Load;
            tlpNav.ResumeLayout(false);
            tlpNav.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            tabMain.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpNav;
        private FlowLayoutPanel flpTabs;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnDashboard;
        private Button btnCustomer;
        private Button btnEmployee;
        private Button btnSettings;
        private ColorDialog colorDialog1;
        private TabPage tabSettings;
        private TabControl tabMain;
        private TabPage tabCustomer;
        private TabPage tabDashboard;
        private TabPage tabEmployee;
        private PictureBox pictureBox1;
    }
}