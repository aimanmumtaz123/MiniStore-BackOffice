namespace App.Windowsapp.Views
{
    partial class ProductsView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tblProducts = new TableLayoutPanel();
            panel1 = new Panel();
            tsProduct = new ToolStrip();
            tsbAdd = new ToolStripButton();
            tsbEdit = new ToolStripButton();
            tsbView = new ToolStripButton();
            tsbDelete = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbRefresh = new ToolStripButton();
            pnlGrid = new Panel();
            dgvProducts = new DataGridView();
            ColID = new DataGridViewTextBoxColumn();
            Colname = new DataGridViewTextBoxColumn();
            ColCategory = new DataGridViewTextBoxColumn();
            ColPrice = new DataGridViewTextBoxColumn();
            ColStock = new DataGridViewTextBoxColumn();
            ColStatus = new DataGridViewTextBoxColumn();
            typFilters = new TableLayoutPanel();
            lblStockStatus = new Label();
            lblSearch = new Label();
            lblCategory = new Label();
            tbSearch = new TextBox();
            cbCategory = new ComboBox();
            cbStockStatus = new ComboBox();
            tblProducts.SuspendLayout();
            panel1.SuspendLayout();
            tsProduct.SuspendLayout();
            pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            typFilters.SuspendLayout();
            SuspendLayout();
            // 
            // tblProducts
            // 
            tblProducts.ColumnCount = 1;
            tblProducts.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblProducts.Controls.Add(panel1, 0, 0);
            tblProducts.Controls.Add(pnlGrid, 0, 2);
            tblProducts.Controls.Add(typFilters, 0, 1);
            tblProducts.Dock = DockStyle.Fill;
            tblProducts.Location = new Point(0, 0);
            tblProducts.Margin = new Padding(4, 3, 4, 3);
            tblProducts.Name = "tblProducts";
            tblProducts.RowCount = 3;
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Absolute, 97F));
            tblProducts.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tblProducts.Size = new Size(600, 445);
            tblProducts.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Info;
            panel1.Controls.Add(tsProduct);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(4, 3);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(592, 58);
            panel1.TabIndex = 0;
            // 
            // tsProduct
            // 
            tsProduct.Items.AddRange(new ToolStripItem[] { tsbAdd, tsbEdit, tsbView, tsbDelete, toolStripSeparator1, tsbRefresh });
            tsProduct.Location = new Point(0, 0);
            tsProduct.Name = "tsProduct";
            tsProduct.Size = new Size(592, 25);
            tsProduct.TabIndex = 0;
            tsProduct.Text = "tsProducts";
            // 
            // tsbAdd
            // 
            tsbAdd.Image = Properties.Resources.ico_Add;
            tsbAdd.ImageTransparentColor = Color.Magenta;
            tsbAdd.Name = "tsbAdd";
            tsbAdd.Size = new Size(49, 22);
            tsbAdd.Text = "Add";
            tsbAdd.Click += tsbAdd_Click;
            // 
            // tsbEdit
            // 
            tsbEdit.Image = Properties.Resources.ico_Edit;
            tsbEdit.ImageTransparentColor = Color.Magenta;
            tsbEdit.Name = "tsbEdit";
            tsbEdit.Size = new Size(47, 22);
            tsbEdit.Text = "Edit";
            tsbEdit.Click += tsbEdit_Click;
            // 
            // tsbView
            // 
            tsbView.Image = Properties.Resources.ico_View;
            tsbView.ImageTransparentColor = Color.Magenta;
            tsbView.Name = "tsbView";
            tsbView.Size = new Size(52, 22);
            tsbView.Text = "View";
            tsbView.Click += tsbView_Click;
            // 
            // tsbDelete
            // 
            tsbDelete.Image = Properties.Resources.ico_Delete;
            tsbDelete.ImageTransparentColor = Color.Magenta;
            tsbDelete.Name = "tsbDelete";
            tsbDelete.Size = new Size(60, 22);
            tsbDelete.Text = "Delete";
            tsbDelete.Click += tsbDelete_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 25);
            // 
            // tsbRefresh
            // 
            tsbRefresh.Image = Properties.Resources.ico_Refresh;
            tsbRefresh.ImageTransparentColor = Color.Magenta;
            tsbRefresh.Name = "tsbRefresh";
            tsbRefresh.Size = new Size(66, 22);
            tsbRefresh.Text = "Refresh";
            tsbRefresh.Click += tsbRefresh_Click;
            // 
            // pnlGrid
            // 
            pnlGrid.BackColor = Color.White;
            pnlGrid.Controls.Add(dgvProducts);
            pnlGrid.Dock = DockStyle.Fill;
            pnlGrid.Location = new Point(4, 165);
            pnlGrid.Margin = new Padding(4, 3, 4, 3);
            pnlGrid.Name = "pnlGrid";
            pnlGrid.Padding = new Padding(14);
            pnlGrid.Size = new Size(592, 277);
            pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            dgvProducts.AllowUserToAddRows = false;
            dgvProducts.AllowUserToDeleteRows = false;
            dgvProducts.AllowUserToResizeRows = false;
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.BackgroundColor = Color.White;
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { ColID, Colname, ColCategory, ColPrice, ColStock, ColStatus });
            dgvProducts.Dock = DockStyle.Fill;
            dgvProducts.Location = new Point(14, 14);
            dgvProducts.Margin = new Padding(4, 3, 4, 3);
            dgvProducts.MultiSelect = false;
            dgvProducts.Name = "dgvProducts";
            dgvProducts.ReadOnly = true;
            dgvProducts.RowHeadersVisible = false;
            dgvProducts.RowHeadersWidth = 51;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProducts.Size = new Size(564, 249);
            dgvProducts.TabIndex = 0;
            // 
            // ColID
            // 
            ColID.DataPropertyName = "Id";
            ColID.FillWeight = 97.46193F;
            ColID.HeaderText = "ID";
            ColID.Name = "ColID";
            ColID.ReadOnly = true;
            // 
            // Colname
            // 
            Colname.DataPropertyName = "Name";
            Colname.FillWeight = 100.5076F;
            Colname.HeaderText = "Name";
            Colname.Name = "Colname";
            Colname.ReadOnly = true;
            // 
            // ColCategory
            // 
            ColCategory.DataPropertyName = "Category";
            ColCategory.FillWeight = 100.5076F;
            ColCategory.HeaderText = "Category";
            ColCategory.Name = "ColCategory";
            ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            ColPrice.DataPropertyName = "Price";
            ColPrice.FillWeight = 100.5076F;
            ColPrice.HeaderText = "Price";
            ColPrice.Name = "ColPrice";
            ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            ColStock.DataPropertyName = "Stock";
            ColStock.FillWeight = 100.5076F;
            ColStock.HeaderText = "Stock";
            ColStock.Name = "ColStock";
            ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            ColStatus.DataPropertyName = "Status";
            ColStatus.FillWeight = 100.5076F;
            ColStatus.HeaderText = "Status";
            ColStatus.Name = "ColStatus";
            ColStatus.ReadOnly = true;
            // 
            // typFilters
            // 
            typFilters.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            typFilters.BackColor = SystemColors.ControlLightLight;
            typFilters.ColumnCount = 3;
            typFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            typFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            typFilters.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            typFilters.Controls.Add(lblStockStatus, 2, 0);
            typFilters.Controls.Add(lblSearch, 0, 0);
            typFilters.Controls.Add(lblCategory, 1, 0);
            typFilters.Controls.Add(tbSearch, 0, 1);
            typFilters.Controls.Add(cbCategory, 1, 1);
            typFilters.Controls.Add(cbStockStatus, 2, 1);
            typFilters.Dock = DockStyle.Fill;
            typFilters.Location = new Point(4, 68);
            typFilters.Margin = new Padding(4, 3, 4, 3);
            typFilters.Name = "typFilters";
            typFilters.RowCount = 2;
            typFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            typFilters.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            typFilters.Size = new Size(592, 91);
            typFilters.TabIndex = 3;
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.BackColor = Color.White;
            lblStockStatus.Dock = DockStyle.Fill;
            lblStockStatus.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStockStatus.Location = new Point(417, 0);
            lblStockStatus.Margin = new Padding(4, 0, 4, 0);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(171, 45);
            lblStockStatus.TabIndex = 2;
            lblStockStatus.Text = "StockStatus";
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.BackColor = Color.White;
            lblSearch.Dock = DockStyle.Fill;
            lblSearch.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSearch.Location = new Point(4, 0);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(228, 45);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.BackColor = Color.White;
            lblCategory.Dock = DockStyle.Fill;
            lblCategory.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCategory.Location = new Point(240, 0);
            lblCategory.Margin = new Padding(4, 0, 4, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(169, 45);
            lblCategory.TabIndex = 1;
            lblCategory.Text = "Category";
            // 
            // tbSearch
            // 
            tbSearch.Dock = DockStyle.Fill;
            tbSearch.Location = new Point(4, 48);
            tbSearch.Margin = new Padding(4, 3, 4, 3);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(228, 23);
            tbSearch.TabIndex = 3;
            tbSearch.TextChanged += tbSearch_TextChanged;
            // 
            // cbCategory
            // 
            cbCategory.Dock = DockStyle.Fill;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(240, 48);
            cbCategory.Margin = new Padding(4, 3, 4, 3);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(169, 23);
            cbCategory.TabIndex = 4;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // cbStockStatus
            // 
            cbStockStatus.Dock = DockStyle.Fill;
            cbStockStatus.FormattingEnabled = true;
            cbStockStatus.Location = new Point(417, 48);
            cbStockStatus.Margin = new Padding(4, 3, 4, 3);
            cbStockStatus.Name = "cbStockStatus";
            cbStockStatus.Size = new Size(171, 23);
            cbStockStatus.TabIndex = 5;
            cbStockStatus.SelectedIndexChanged += cbStockStatus_SelectedIndexChanged;
            // 
            // ProductsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblProducts);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ProductsView";
            Size = new Size(600, 445);
            Load += ProductsView_Load_1;
            tblProducts.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tsProduct.ResumeLayout(false);
            tsProduct.PerformLayout();
            pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            typFilters.ResumeLayout(false);
            typFilters.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblProducts;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStrip tsProduct;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbView;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.TableLayoutPanel typFilters;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.ComboBox cbStockStatus;
        private System.Windows.Forms.Panel pnlGrid;
        private System.Windows.Forms.DataGridView dgvProducts;
        private DataGridViewTextBoxColumn ColID;
        private DataGridViewTextBoxColumn Colname;
        private DataGridViewTextBoxColumn ColCategory;
        private DataGridViewTextBoxColumn ColPrice;
        private DataGridViewTextBoxColumn ColStock;
        private DataGridViewTextBoxColumn ColStatus;
    }
}
