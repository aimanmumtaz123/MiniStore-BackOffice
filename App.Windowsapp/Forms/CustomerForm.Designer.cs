namespace App.Windowsapp.Forms
{
    partial class CustomerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerForm));
            tlpCustomerService = new TableLayoutPanel();
            lblName = new Label();
            lblPhone = new Label();
            lblId = new Label();
            lblAddress = new Label();
            lblEmail = new Label();
            txtName = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            txtAddress = new TextBox();
            txtId = new TextBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnSave = new Button();
            btnCancel = new Button();
            tlpCustomerService.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerService
            // 
            tlpCustomerService.ColumnCount = 2;
            tlpCustomerService.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tlpCustomerService.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 85F));
            tlpCustomerService.Controls.Add(lblName, 0, 0);
            tlpCustomerService.Controls.Add(lblPhone, 0, 1);
            tlpCustomerService.Controls.Add(lblId, 0, 4);
            tlpCustomerService.Controls.Add(lblAddress, 0, 3);
            tlpCustomerService.Controls.Add(lblEmail, 0, 2);
            tlpCustomerService.Controls.Add(txtName, 1, 0);
            tlpCustomerService.Controls.Add(txtPhone, 1, 1);
            tlpCustomerService.Controls.Add(txtEmail, 1, 2);
            tlpCustomerService.Controls.Add(txtAddress, 1, 3);
            tlpCustomerService.Controls.Add(txtId, 1, 4);
            tlpCustomerService.Dock = DockStyle.Top;
            tlpCustomerService.Location = new Point(0, 0);
            tlpCustomerService.Name = "tlpCustomerService";
            tlpCustomerService.RowCount = 5;
            tlpCustomerService.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerService.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerService.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerService.RowStyles.Add(new RowStyle());
            tlpCustomerService.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tlpCustomerService.Size = new Size(668, 211);
            tlpCustomerService.TabIndex = 0;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 11.25F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(94, 35);
            lblName.TabIndex = 0;
            lblName.Text = "Name";
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.Dock = DockStyle.Fill;
            lblPhone.Font = new Font("Segoe UI", 11.25F);
            lblPhone.Location = new Point(3, 35);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(94, 35);
            lblPhone.TabIndex = 1;
            lblPhone.Text = "Phone";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Dock = DockStyle.Fill;
            lblId.Font = new Font("Segoe UI", 11.25F);
            lblId.Location = new Point(3, 169);
            lblId.Name = "lblId";
            lblId.Size = new Size(94, 42);
            lblId.TabIndex = 4;
            lblId.Text = "Id";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Dock = DockStyle.Fill;
            lblAddress.Font = new Font("Segoe UI", 11.25F);
            lblAddress.Location = new Point(3, 105);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(94, 64);
            lblAddress.TabIndex = 3;
            lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Dock = DockStyle.Fill;
            lblEmail.Font = new Font("Segoe UI", 11.25F);
            lblEmail.Location = new Point(3, 70);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(94, 35);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(103, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(562, 23);
            txtName.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Dock = DockStyle.Fill;
            txtPhone.Location = new Point(103, 38);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(562, 23);
            txtPhone.TabIndex = 6;
            // 
            // txtEmail
            // 
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Location = new Point(103, 73);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(562, 23);
            txtEmail.TabIndex = 7;
            // 
            // txtAddress
            // 
            txtAddress.Dock = DockStyle.Fill;
            txtAddress.Location = new Point(103, 108);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Vertical;
            txtAddress.Size = new Size(562, 58);
            txtAddress.TabIndex = 8;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(103, 172);
            txtId.Name = "txtId";
            txtId.Size = new Size(562, 23);
            txtId.TabIndex = 9;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btnSave);
            flowLayoutPanel1.Controls.Add(btnCancel);
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 339);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(668, 52);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(563, 9);
            btnSave.Margin = new Padding(9);
            btnSave.Name = "btnSave";
            btnSave.Padding = new Padding(3);
            btnSave.Size = new Size(96, 37);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(449, 9);
            btnCancel.Margin = new Padding(9);
            btnCancel.Name = "btnCancel";
            btnCancel.Padding = new Padding(3);
            btnCancel.Size = new Size(96, 37);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // CustomerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(668, 391);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(tlpCustomerService);
            Name = "CustomerForm";
            Text = "CustomerForm";
            tlpCustomerService.ResumeLayout(false);
            tlpCustomerService.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerService;
        private Label lblId;
        private Label lblAddress;
        private Label lblEmail;
        private Label lblName;
        private Label lblPhone;
        private TextBox txtName;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private TextBox txtAddress;
        private TextBox txtId;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnSave;
        private Button btnCancel;
    }
}