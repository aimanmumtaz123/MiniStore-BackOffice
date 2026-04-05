namespace App.Windowsapp.Forms
{
    partial class CustomerPicker
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
            tlpCustomerPicker = new TableLayoutPanel();
            flpSearchBar = new FlowLayoutPanel();
            lblSearchQuery = new Label();
            tbSearchQuery = new TextBox();
            flpButtons = new FlowLayoutPanel();
            btnSelect = new Button();
            btnCancel = new Button();
            lbCustomers = new ListBox();
            tlpCustomerPicker.SuspendLayout();
            flpSearchBar.SuspendLayout();
            flpButtons.SuspendLayout();
            SuspendLayout();
            // 
            // tlpCustomerPicker
            // 
            tlpCustomerPicker.BackColor = Color.White;
            tlpCustomerPicker.ColumnCount = 1;
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tlpCustomerPicker.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tlpCustomerPicker.Controls.Add(flpSearchBar, 0, 0);
            tlpCustomerPicker.Controls.Add(flpButtons, 0, 2);
            tlpCustomerPicker.Controls.Add(lbCustomers, 0, 1);
            tlpCustomerPicker.Dock = DockStyle.Fill;
            tlpCustomerPicker.Location = new Point(0, 0);
            tlpCustomerPicker.Name = "tlpCustomerPicker";
            tlpCustomerPicker.RowCount = 3;
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tlpCustomerPicker.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tlpCustomerPicker.Size = new Size(622, 396);
            tlpCustomerPicker.TabIndex = 0;
            // 
            // flpSearchBar
            // 
            flpSearchBar.Controls.Add(lblSearchQuery);
            flpSearchBar.Controls.Add(tbSearchQuery);
            flpSearchBar.Dock = DockStyle.Fill;
            flpSearchBar.Location = new Point(3, 3);
            flpSearchBar.Name = "flpSearchBar";
            flpSearchBar.Size = new Size(616, 33);
            flpSearchBar.TabIndex = 0;
            // 
            // lblSearchQuery
            // 
            lblSearchQuery.AutoSize = true;
            lblSearchQuery.BackColor = Color.White;
            lblSearchQuery.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearchQuery.ForeColor = SystemColors.InactiveCaptionText;
            lblSearchQuery.Location = new Point(3, 0);
            lblSearchQuery.Name = "lblSearchQuery";
            lblSearchQuery.Size = new Size(92, 20);
            lblSearchQuery.TabIndex = 0;
            lblSearchQuery.Text = "SearchQuery";
            // 
            // tbSearchQuery
            // 
            tbSearchQuery.Location = new Point(101, 3);
            tbSearchQuery.Name = "tbSearchQuery";
            tbSearchQuery.Size = new Size(446, 23);
            tbSearchQuery.TabIndex = 1;
            tbSearchQuery.TextChanged += tbSearchQuery_TextChanged;
            // 
            // flpButtons
            // 
            flpButtons.Controls.Add(btnSelect);
            flpButtons.Controls.Add(btnCancel);
            flpButtons.Dock = DockStyle.Fill;
            flpButtons.FlowDirection = FlowDirection.RightToLeft;
            flpButtons.Location = new Point(3, 358);
            flpButtons.Name = "flpButtons";
            flpButtons.Size = new Size(616, 35);
            flpButtons.TabIndex = 1;
            // 
            // btnSelect
            // 
            btnSelect.BackColor = SystemColors.Window;
            btnSelect.FlatAppearance.BorderSize = 0;
            btnSelect.FlatStyle = FlatStyle.Flat;
            btnSelect.Font = new Font("Segoe UI", 9.75F);
            btnSelect.Image = Properties.Resources.select;
            btnSelect.Location = new Point(538, 3);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(75, 32);
            btnSelect.TabIndex = 0;
            btnSelect.Text = "Select";
            btnSelect.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSelect.UseVisualStyleBackColor = false;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = SystemColors.Window;
            btnCancel.FlatAppearance.BorderSize = 0;
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.75F);
            btnCancel.Image = Properties.Resources.cancel;
            btnCancel.Location = new Point(457, 3);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 32);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // lbCustomers
            // 
            lbCustomers.Dock = DockStyle.Fill;
            lbCustomers.FormattingEnabled = true;
            lbCustomers.ItemHeight = 15;
            lbCustomers.Location = new Point(3, 42);
            lbCustomers.Name = "lbCustomers";
            lbCustomers.Size = new Size(616, 310);
            lbCustomers.TabIndex = 2;
            lbCustomers.DoubleClick += lbCustomers_DoubleClick;
            // 
            // CustomerPicker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(622, 396);
            Controls.Add(tlpCustomerPicker);
            Name = "CustomerPicker";
            Text = "CustomerPicker";
            tlpCustomerPicker.ResumeLayout(false);
            flpSearchBar.ResumeLayout(false);
            flpSearchBar.PerformLayout();
            flpButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tlpCustomerPicker;
        private FlowLayoutPanel flpSearchBar;
        private FlowLayoutPanel flpButtons;
        private Label lblSearchQuery;
        private TextBox tbSearchQuery;
        private Button btnSelect;
        private Button btnCancel;
        private ListBox lbCustomers;
    }
}