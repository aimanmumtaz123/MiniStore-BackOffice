
namespace App.Windowsapp.Forms
{
    partial class ProductForm
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
            tlpProductForm = new TableLayoutPanel();
            lblCategory = new Label();
            lblPrice = new Label();
            lblStock = new Label();
            lblStatus = new Label();
            txtName = new TextBox();
            cBCategory = new ComboBox();
            nuPrice = new NumericUpDown();
            nuStock = new NumericUpDown();
            cBStatus = new ComboBox();
            txtId = new TextBox();
            lblID = new Label();
            lblName = new Label();
            flpProductForm = new FlowLayoutPanel();
            btnCancel = new Button();
            btnSave = new Button();
            tlpProductForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).BeginInit();
            flpProductForm.SuspendLayout();
            SuspendLayout();
            // 
            // tlpProductForm
            // 
            tlpProductForm.ColumnCount = 2;
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tlpProductForm.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 80F));
            tlpProductForm.Controls.Add(lblCategory, 0, 1);
            tlpProductForm.Controls.Add(lblPrice, 0, 2);
            tlpProductForm.Controls.Add(lblStock, 0, 3);
            tlpProductForm.Controls.Add(lblStatus, 0, 4);
            tlpProductForm.Controls.Add(txtName, 1, 0);
            tlpProductForm.Controls.Add(cBCategory, 1, 1);
            tlpProductForm.Controls.Add(nuPrice, 1, 2);
            tlpProductForm.Controls.Add(nuStock, 1, 3);
            tlpProductForm.Controls.Add(cBStatus, 1, 4);
            tlpProductForm.Controls.Add(txtId, 1, 5);
            tlpProductForm.Controls.Add(lblID, 0, 5);
            tlpProductForm.Controls.Add(lblName, 0, 0);
            tlpProductForm.Dock = DockStyle.Top;
            tlpProductForm.Location = new Point(0, 0);
            tlpProductForm.Name = "tlpProductForm";
            tlpProductForm.RowCount = 6;
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProductForm.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tlpProductForm.Size = new Size(800, 303);
            tlpProductForm.TabIndex = 0;
            tlpProductForm.Paint += tlpProductForm_Paint;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.Gainsboro;
            lblCategory.BorderStyle = BorderStyle.FixedSingle;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Segoe UI", 12F);
            lblCategory.Location = new Point(3, 50);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(154, 50);
            lblCategory.TabIndex = 7;
            lblCategory.Text = "Category";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.BackColor = Color.Gainsboro;
            lblPrice.BorderStyle = BorderStyle.FixedSingle;
            lblPrice.Dock = DockStyle.Fill;
            lblPrice.Font = new Font("Segoe UI", 12F);
            lblPrice.Location = new Point(3, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(154, 50);
            lblPrice.TabIndex = 8;
            lblPrice.Text = "Price";
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.BackColor = Color.Gainsboro;
            lblStock.BorderStyle = BorderStyle.FixedSingle;
            lblStock.Dock = DockStyle.Fill;
            lblStock.Font = new Font("Segoe UI", 12F);
            lblStock.Location = new Point(3, 150);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(154, 50);
            lblStock.TabIndex = 9;
            lblStock.Text = "Stock";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Gainsboro;
            lblStatus.BorderStyle = BorderStyle.FixedSingle;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 12F);
            lblStatus.Location = new Point(3, 200);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(154, 50);
            lblStatus.TabIndex = 10;
            lblStatus.Text = "Status";
            lblStatus.Click += lblStatus_Click;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(163, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(634, 23);
            txtName.TabIndex = 0;
            // 
            // cBCategory
            // 
            cBCategory.Dock = DockStyle.Fill;
            cBCategory.FormattingEnabled = true;
            cBCategory.Location = new Point(163, 53);
            cBCategory.Name = "cBCategory";
            cBCategory.Size = new Size(634, 23);
            cBCategory.TabIndex = 1;
            // 
            // nuPrice
            // 
            nuPrice.Dock = DockStyle.Fill;
            nuPrice.Location = new Point(163, 103);
            nuPrice.Name = "nuPrice";
            nuPrice.Size = new Size(634, 23);
            nuPrice.TabIndex = 2;
            // 
            // nuStock
            // 
            nuStock.Dock = DockStyle.Fill;
            nuStock.Location = new Point(163, 153);
            nuStock.Name = "nuStock";
            nuStock.Size = new Size(634, 23);
            nuStock.TabIndex = 3;
            // 
            // cBStatus
            // 
            cBStatus.Dock = DockStyle.Fill;
            cBStatus.FormattingEnabled = true;
            cBStatus.Location = new Point(163, 203);
            cBStatus.Name = "cBStatus";
            cBStatus.Size = new Size(634, 23);
            cBStatus.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Dock = DockStyle.Fill;
            txtId.Location = new Point(163, 253);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(634, 23);
            txtId.TabIndex = 5;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.BackColor = Color.Gainsboro;
            lblID.BorderStyle = BorderStyle.FixedSingle;
            lblID.Dock = DockStyle.Fill;
            lblID.Font = new Font("Segoe UI", 12F);
            lblID.Location = new Point(3, 250);
            lblID.Name = "lblID";
            lblID.Size = new Size(154, 53);
            lblID.TabIndex = 11;
            lblID.Text = "ID";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Gainsboro;
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Dock = DockStyle.Fill;
            lblName.Font = new Font("Segoe UI", 12F);
            lblName.Location = new Point(3, 0);
            lblName.Name = "lblName";
            lblName.Size = new Size(154, 50);
            lblName.TabIndex = 6;
            lblName.Text = "Name";
            // 
            // flpProductForm
            // 
            flpProductForm.Controls.Add(btnCancel);
            flpProductForm.Controls.Add(btnSave);
            flpProductForm.Dock = DockStyle.Bottom;
            flpProductForm.FlowDirection = FlowDirection.RightToLeft;
            flpProductForm.Location = new Point(0, 350);
            flpProductForm.Name = "flpProductForm";
            flpProductForm.Size = new Size(800, 100);
            flpProductForm.TabIndex = 1;
            flpProductForm.Paint += flpProductForm_Paint;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(722, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 35);
            btnCancel.TabIndex = 0;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlign = ContentAlignment.MiddleLeft;
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.White;
            btnSave.Image = Properties.Resources.save1;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(641, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 35);
            btnSave.TabIndex = 1;
            btnSave.Text = "Save";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(flpProductForm);
            Controls.Add(tlpProductForm);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "ProductForm";
            tlpProductForm.ResumeLayout(false);
            tlpProductForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nuPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nuStock).EndInit();
            flpProductForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpProductForm;
        private Label lblName;
        private Label lblCategory;
        private Label lblPrice;
        private Label lblStock;
        private Label lblStatus;
        private Label lblID;
        private FlowLayoutPanel flpProductForm;
        private TextBox tBName;
        private ComboBox cBCategory;
        private NumericUpDown numericUpDown1;
        private NumericUpDown nUDStock;
        private ComboBox cBStatus;
        private TextBox tBID;
        private Button btnCancel;
        private Button btnSave;
        private EventHandler lblID_Click;
        private Label cmbCategory;
        private Label cmbStock;
        private Label nuStatus;
        private NumericUpDown nuPrice;
        private NumericUpDown nuStock;
        private TextBox txtName;
        public TextBox txtId;
    }
}