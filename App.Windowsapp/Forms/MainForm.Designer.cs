namespace App.Windowsapp.Forms;
    partial class MainForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        pnlHeader = new Panel();
        flpRight = new FlowLayoutPanel();
        pbUser = new PictureBox();
        lblUser = new Label();
        flpLeft = new FlowLayoutPanel();
        pbLogo = new PictureBox();
        pnlSideBar = new Panel();
        pnlContent = new Panel();
        btnOrders = new Button();
        flpNav = new FlowLayoutPanel();
        btnDashBoard = new Button();
        btnProducts = new Button();
        btnCustomer = new Button();
        btnReports = new Button();
        btnSync = new Button();
        btnLogs = new Button();
        btnSettings = new Button();
        statusStrip = new StatusStrip();
        tsLabelStatus = new ToolStripStatusLabel();
        toolStripStatusLabel1 = new ToolStripStatusLabel();
        btnOrder = new Button();
        pnlHeader.SuspendLayout();
        flpRight.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
        flpLeft.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
        pnlSideBar.SuspendLayout();
        pnlContent.SuspendLayout();
        flpNav.SuspendLayout();
        statusStrip.SuspendLayout();
        SuspendLayout();
        // 
        // pnlHeader
        // 
        pnlHeader.Controls.Add(flpRight);
        pnlHeader.Controls.Add(flpLeft);
        pnlHeader.Dock = DockStyle.Top;
        pnlHeader.Location = new Point(0, 0);
        pnlHeader.Margin = new Padding(0);
        pnlHeader.Name = "pnlHeader";
        pnlHeader.Size = new Size(812, 46);
        pnlHeader.TabIndex = 0;
        // 
        // flpRight
        // 
        flpRight.Controls.Add(pbUser);
        flpRight.Controls.Add(lblUser);
        flpRight.Dock = DockStyle.Right;
        flpRight.Location = new Point(702, 0);
        flpRight.Margin = new Padding(3, 4, 3, 4);
        flpRight.Name = "flpRight";
        flpRight.Size = new Size(110, 46);
        flpRight.TabIndex = 1;
        // 
        // pbUser
        // 
        pbUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
        pbUser.Image = Properties.Resources.ico_user;
        pbUser.Location = new Point(3, 3);
        pbUser.Name = "pbUser";
        pbUser.Size = new Size(32, 32);
        pbUser.TabIndex = 1;
        pbUser.TabStop = false;
        // 
        // lblUser
        // 
        lblUser.AutoSize = true;
        lblUser.Dock = DockStyle.Right;
        lblUser.Location = new Point(41, 0);
        lblUser.Name = "lblUser";
        lblUser.Size = new Size(43, 38);
        lblUser.TabIndex = 2;
        lblUser.Text = "Admin";
        lblUser.TextAlign = ContentAlignment.MiddleLeft;
        lblUser.Click += lblUser_Click;
        // 
        // flpLeft
        // 
        flpLeft.Controls.Add(pbLogo);
        flpLeft.Dock = DockStyle.Left;
        flpLeft.Location = new Point(0, 0);
        flpLeft.Margin = new Padding(4, 3, 4, 3);
        flpLeft.Name = "flpLeft";
        flpLeft.Size = new Size(155, 46);
        flpLeft.TabIndex = 0;
        // 
        // pbLogo
        // 
        pbLogo.Image = Properties.Resources.ico_miniStore;
        pbLogo.Location = new Point(3, 3);
        pbLogo.Name = "pbLogo";
        pbLogo.Size = new Size(32, 32);
        pbLogo.TabIndex = 0;
        pbLogo.TabStop = false;
        // 
        // pnlSideBar
        // 
        pnlSideBar.Controls.Add(pnlContent);
        pnlSideBar.Controls.Add(flpNav);
        pnlSideBar.Dock = DockStyle.Fill;
        pnlSideBar.Location = new Point(0, 46);
        pnlSideBar.Margin = new Padding(4, 3, 4, 3);
        pnlSideBar.Name = "pnlSideBar";
        pnlSideBar.Size = new Size(812, 485);
        pnlSideBar.TabIndex = 1;
        // 
        // pnlContent
        // 
        pnlContent.Controls.Add(btnOrders);
        pnlContent.Dock = DockStyle.Fill;
        pnlContent.Location = new Point(233, 0);
        pnlContent.Name = "pnlContent";
        pnlContent.Size = new Size(579, 485);
        pnlContent.TabIndex = 1;
        // 
        // btnOrders
        // 
        btnOrders.FlatAppearance.BorderSize = 0;
        btnOrders.FlatStyle = FlatStyle.Flat;
        btnOrders.Image = Properties.Resources.ico_orders;
        btnOrders.ImageAlign = ContentAlignment.MiddleLeft;
        btnOrders.Location = new Point(-230, 151);
        btnOrders.Name = "btnOrders";
        btnOrders.Padding = new Padding(10, 0, 0, 0);
        btnOrders.Size = new Size(230, 40);
        btnOrders.TabIndex = 2;
        btnOrders.Text = "Orders";
        btnOrders.TextAlign = ContentAlignment.MiddleLeft;
        btnOrders.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnOrders.UseVisualStyleBackColor = true;
        // 
        // flpNav
        // 
        flpNav.Controls.Add(btnDashBoard);
        flpNav.Controls.Add(btnProducts);
        flpNav.Controls.Add(btnCustomer);
        flpNav.Controls.Add(btnOrder);
        flpNav.Controls.Add(btnReports);
        flpNav.Controls.Add(btnSync);
        flpNav.Controls.Add(btnLogs);
        flpNav.Controls.Add(btnSettings);
        flpNav.Dock = DockStyle.Left;
        flpNav.FlowDirection = FlowDirection.TopDown;
        flpNav.Location = new Point(0, 0);
        flpNav.Margin = new Padding(4, 3, 4, 3);
        flpNav.Name = "flpNav";
        flpNav.Size = new Size(233, 485);
        flpNav.TabIndex = 0;
        // 
        // btnDashBoard
        // 
        btnDashBoard.FlatAppearance.BorderSize = 0;
        btnDashBoard.FlatStyle = FlatStyle.Flat;
        btnDashBoard.Image = Properties.Resources.ico_dashboard;
        btnDashBoard.ImageAlign = ContentAlignment.MiddleLeft;
        btnDashBoard.Location = new Point(3, 3);
        btnDashBoard.Name = "btnDashBoard";
        btnDashBoard.Padding = new Padding(10, 0, 0, 0);
        btnDashBoard.Size = new Size(230, 40);
        btnDashBoard.TabIndex = 1;
        btnDashBoard.Text = "DashBoard";
        btnDashBoard.TextAlign = ContentAlignment.MiddleLeft;
        btnDashBoard.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnDashBoard.UseVisualStyleBackColor = true;
        btnDashBoard.Click += btnDashBoard_Click;
        // 
        // btnProducts
        // 
        btnProducts.FlatAppearance.BorderSize = 0;
        btnProducts.FlatStyle = FlatStyle.Flat;
        btnProducts.Image = Properties.Resources.ico_products;
        btnProducts.ImageAlign = ContentAlignment.MiddleLeft;
        btnProducts.Location = new Point(3, 49);
        btnProducts.Name = "btnProducts";
        btnProducts.Padding = new Padding(10, 0, 0, 0);
        btnProducts.Size = new Size(230, 40);
        btnProducts.TabIndex = 1;
        btnProducts.Text = "Products";
        btnProducts.TextAlign = ContentAlignment.MiddleLeft;
        btnProducts.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnProducts.UseVisualStyleBackColor = true;
        btnProducts.Click += btnProducts_Click;
        // 
        // btnCustomer
        // 
        btnCustomer.FlatAppearance.BorderSize = 0;
        btnCustomer.FlatStyle = FlatStyle.Flat;
        btnCustomer.Image = (Image)resources.GetObject("btnCustomer.Image");
        btnCustomer.ImageAlign = ContentAlignment.MiddleLeft;
        btnCustomer.Location = new Point(3, 95);
        btnCustomer.Name = "btnCustomer";
        btnCustomer.Padding = new Padding(10, 0, 0, 0);
        btnCustomer.Size = new Size(230, 50);
        btnCustomer.TabIndex = 7;
        btnCustomer.Text = "Customers";
        btnCustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnCustomer.UseVisualStyleBackColor = true;
        btnCustomer.Click += btnCustomer_Click;
        // 
        // btnReports
        // 
        btnReports.FlatAppearance.BorderSize = 0;
        btnReports.FlatStyle = FlatStyle.Flat;
        btnReports.Image = Properties.Resources.ico_report;
        btnReports.ImageAlign = ContentAlignment.MiddleLeft;
        btnReports.Location = new Point(3, 207);
        btnReports.Name = "btnReports";
        btnReports.Padding = new Padding(10, 0, 0, 0);
        btnReports.Size = new Size(230, 40);
        btnReports.TabIndex = 3;
        btnReports.Text = "Reports";
        btnReports.TextAlign = ContentAlignment.MiddleLeft;
        btnReports.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnReports.UseVisualStyleBackColor = true;
        // 
        // btnSync
        // 
        btnSync.FlatAppearance.BorderSize = 0;
        btnSync.FlatStyle = FlatStyle.Flat;
        btnSync.Image = Properties.Resources.ico_sync;
        btnSync.ImageAlign = ContentAlignment.MiddleLeft;
        btnSync.Location = new Point(3, 253);
        btnSync.Name = "btnSync";
        btnSync.Padding = new Padding(10, 0, 0, 0);
        btnSync.Size = new Size(230, 40);
        btnSync.TabIndex = 4;
        btnSync.Text = "Sync";
        btnSync.TextAlign = ContentAlignment.MiddleLeft;
        btnSync.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSync.UseVisualStyleBackColor = true;
        // 
        // btnLogs
        // 
        btnLogs.FlatAppearance.BorderSize = 0;
        btnLogs.FlatStyle = FlatStyle.Flat;
        btnLogs.Image = Properties.Resources.ico_logs;
        btnLogs.ImageAlign = ContentAlignment.MiddleLeft;
        btnLogs.Location = new Point(3, 299);
        btnLogs.Name = "btnLogs";
        btnLogs.Padding = new Padding(10, 0, 0, 0);
        btnLogs.Size = new Size(230, 40);
        btnLogs.TabIndex = 5;
        btnLogs.Text = "Logs";
        btnLogs.TextAlign = ContentAlignment.MiddleLeft;
        btnLogs.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnLogs.UseVisualStyleBackColor = true;
        // 
        // btnSettings
        // 
        btnSettings.FlatAppearance.BorderSize = 0;
        btnSettings.FlatStyle = FlatStyle.Flat;
        btnSettings.Image = Properties.Resources.ico_settings;
        btnSettings.ImageAlign = ContentAlignment.MiddleLeft;
        btnSettings.Location = new Point(3, 345);
        btnSettings.Name = "btnSettings";
        btnSettings.Padding = new Padding(10, 0, 0, 0);
        btnSettings.Size = new Size(230, 40);
        btnSettings.TabIndex = 6;
        btnSettings.Text = "Settings";
        btnSettings.TextAlign = ContentAlignment.MiddleLeft;
        btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnSettings.UseVisualStyleBackColor = true;
        // 
        // statusStrip
        // 
        statusStrip.Items.AddRange(new ToolStripItem[] { tsLabelStatus });
        statusStrip.Location = new Point(0, 531);
        statusStrip.Name = "statusStrip";
        statusStrip.Padding = new Padding(1, 0, 16, 0);
        statusStrip.Size = new Size(812, 22);
        statusStrip.TabIndex = 3;
        statusStrip.Text = "Ready";
        // 
        // tsLabelStatus
        // 
        tsLabelStatus.Name = "tsLabelStatus";
        tsLabelStatus.Size = new Size(39, 17);
        tsLabelStatus.Text = "Ready";
        // 
        // toolStripStatusLabel1
        // 
        toolStripStatusLabel1.Name = "toolStripStatusLabel1";
        toolStripStatusLabel1.Size = new Size(23, 23);
        toolStripStatusLabel1.Text = "toolStripStatusLabel1";
        // 
        // btnOrder
        // 
        btnOrder.FlatAppearance.BorderSize = 0;
        btnOrder.FlatStyle = FlatStyle.Flat;
        btnOrder.Image = Properties.Resources.ico_orders;
        btnOrder.ImageAlign = ContentAlignment.MiddleLeft;
        btnOrder.Location = new Point(3, 151);
        btnOrder.Name = "btnOrder";
        btnOrder.Padding = new Padding(10, 0, 0, 0);
        btnOrder.Size = new Size(230, 50);
        btnOrder.TabIndex = 8;
        btnOrder.Text = "Orders";
        btnOrder.TextImageRelation = TextImageRelation.ImageBeforeText;
        btnOrder.UseVisualStyleBackColor = true;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(812, 553);
        Controls.Add(pnlSideBar);
        Controls.Add(pnlHeader);
        Controls.Add(statusStrip);
        Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
        Margin = new Padding(4, 3, 4, 3);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainForm";
        WindowState = FormWindowState.Maximized;
        pnlHeader.ResumeLayout(false);
        flpRight.ResumeLayout(false);
        flpRight.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
        flpLeft.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
        pnlSideBar.ResumeLayout(false);
        pnlContent.ResumeLayout(false);
        flpNav.ResumeLayout(false);
        statusStrip.ResumeLayout(false);
        statusStrip.PerformLayout();
        ResumeLayout(false);
        PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.FlowLayoutPanel flpRight;
        private System.Windows.Forms.FlowLayoutPanel flpLeft;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.FlowLayoutPanel flpNav;
        private System.Windows.Forms.Button btnDashBoard;
        private System.Windows.Forms.Button btnProducts;
        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnSync;
        private System.Windows.Forms.Button btnLogs;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripStatusLabel tsLabelStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private Panel pnlContent;
    private Button btnCustomer;
    private Button btnOrder;
}
