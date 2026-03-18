namespace MiniStore_BackOffice.Views
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
            this.tblProducts = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsProduct = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbView = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.pnlGrid = new System.Windows.Forms.Panel();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Colname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typFilters = new System.Windows.Forms.TableLayoutPanel();
            this.lblStockStatus = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.cbStockStatus = new System.Windows.Forms.ComboBox();
            this.tblProducts.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tsProduct.SuspendLayout();
            this.pnlGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.typFilters.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProducts
            // 
            this.tblProducts.ColumnCount = 1;
            this.tblProducts.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Controls.Add(this.panel1, 0, 0);
            this.tblProducts.Controls.Add(this.pnlGrid, 0, 2);
            this.tblProducts.Controls.Add(this.typFilters, 0, 1);
            this.tblProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblProducts.Location = new System.Drawing.Point(0, 0);
            this.tblProducts.Name = "tblProducts";
            this.tblProducts.RowCount = 3;
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 56F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 84F));
            this.tblProducts.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblProducts.Size = new System.Drawing.Size(875, 565);
            this.tblProducts.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.Controls.Add(this.tsProduct);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(866, 50);
            this.panel1.TabIndex = 0;
            // 
            // tsProduct
            // 
            this.tsProduct.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsbEdit,
            this.tsbView,
            this.tsbDelete,
            this.toolStripSeparator1,
            this.tsbRefresh});
            this.tsProduct.Location = new System.Drawing.Point(0, 0);
            this.tsProduct.Name = "tsProduct";
            this.tsProduct.Size = new System.Drawing.Size(866, 25);
            this.tsProduct.TabIndex = 0;
            this.tsProduct.Text = "tsProducts";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = global::MiniStore_BackOffice.Properties.Resources.ico_Add;
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(49, 22);
            this.tsbAdd.Text = "Add";
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = global::MiniStore_BackOffice.Properties.Resources.ico_Edit;
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbEdit.Text = "Edit";
            // 
            // tsbView
            // 
            this.tsbView.Image = global::MiniStore_BackOffice.Properties.Resources.ico_View;
            this.tsbView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbView.Name = "tsbView";
            this.tsbView.Size = new System.Drawing.Size(52, 22);
            this.tsbView.Text = "View";
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = global::MiniStore_BackOffice.Properties.Resources.ico_Delete;
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = global::MiniStore_BackOffice.Properties.Resources.ico_Refresh;
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(66, 22);
            this.tsbRefresh.Text = "Refresh";
            // 
            // pnlGrid
            // 
            this.pnlGrid.BackColor = System.Drawing.Color.White;
            this.pnlGrid.Controls.Add(this.dgvProducts);
            this.pnlGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlGrid.Location = new System.Drawing.Point(3, 143);
            this.pnlGrid.Name = "pnlGrid";
            this.pnlGrid.Padding = new System.Windows.Forms.Padding(12);
            this.pnlGrid.Size = new System.Drawing.Size(869, 419);
            this.pnlGrid.TabIndex = 2;
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToResizeRows = false;
            this.dgvProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducts.BackgroundColor = System.Drawing.Color.White;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.Colname,
            this.ColCategory,
            this.ColPrice,
            this.ColStock,
            this.ColStatus});
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(12, 12);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowHeadersWidth = 51;
            this.dgvProducts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProducts.Size = new System.Drawing.Size(845, 395);
            this.dgvProducts.TabIndex = 0;
            // 
            // ColID
            // 
            this.ColID.FillWeight = 97.46193F;
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // Colname
            // 
            this.Colname.FillWeight = 100.5076F;
            this.Colname.HeaderText = "Name";
            this.Colname.Name = "Colname";
            this.Colname.ReadOnly = true;
            // 
            // ColCategory
            // 
            this.ColCategory.FillWeight = 100.5076F;
            this.ColCategory.HeaderText = "Category";
            this.ColCategory.Name = "ColCategory";
            this.ColCategory.ReadOnly = true;
            // 
            // ColPrice
            // 
            this.ColPrice.FillWeight = 100.5076F;
            this.ColPrice.HeaderText = "Price";
            this.ColPrice.Name = "ColPrice";
            this.ColPrice.ReadOnly = true;
            // 
            // ColStock
            // 
            this.ColStock.FillWeight = 100.5076F;
            this.ColStock.HeaderText = "Stock";
            this.ColStock.Name = "ColStock";
            this.ColStock.ReadOnly = true;
            // 
            // ColStatus
            // 
            this.ColStatus.FillWeight = 100.5076F;
            this.ColStatus.HeaderText = "Status";
            this.ColStatus.Name = "ColStatus";
            this.ColStatus.ReadOnly = true;
            // 
            // typFilters
            // 
            this.typFilters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.typFilters.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.typFilters.ColumnCount = 3;
            this.typFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.typFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.typFilters.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.typFilters.Controls.Add(this.lblStockStatus, 2, 0);
            this.typFilters.Controls.Add(this.lblSearch, 0, 0);
            this.typFilters.Controls.Add(this.lblCategory, 1, 0);
            this.typFilters.Controls.Add(this.tbSearch, 0, 1);
            this.typFilters.Controls.Add(this.cbCategory, 1, 1);
            this.typFilters.Controls.Add(this.cbStockStatus, 2, 1);
            this.typFilters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.typFilters.Location = new System.Drawing.Point(3, 59);
            this.typFilters.Name = "typFilters";
            this.typFilters.RowCount = 2;
            this.typFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typFilters.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.typFilters.Size = new System.Drawing.Size(869, 78);
            this.typFilters.TabIndex = 3;
            // 
            // lblStockStatus
            // 
            this.lblStockStatus.AutoSize = true;
            this.lblStockStatus.BackColor = System.Drawing.Color.White;
            this.lblStockStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblStockStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStockStatus.Location = new System.Drawing.Point(610, 0);
            this.lblStockStatus.Name = "lblStockStatus";
            this.lblStockStatus.Size = new System.Drawing.Size(256, 39);
            this.lblStockStatus.TabIndex = 2;
            this.lblStockStatus.Text = "StockStatus";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.BackColor = System.Drawing.Color.White;
            this.lblSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearch.Location = new System.Drawing.Point(3, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(341, 39);
            this.lblSearch.TabIndex = 0;
            this.lblSearch.Text = "Search";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.BackColor = System.Drawing.Color.White;
            this.lblCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(350, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(254, 39);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(3, 42);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(318, 20);
            this.tbSearch.TabIndex = 3;
            this.tbSearch.Text = "_________";
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(350, 42);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(226, 21);
            this.cbCategory.TabIndex = 4;
            // 
            // cbStockStatus
            // 
            this.cbStockStatus.FormattingEnabled = true;
            this.cbStockStatus.Location = new System.Drawing.Point(610, 42);
            this.cbStockStatus.Name = "cbStockStatus";
            this.cbStockStatus.Size = new System.Drawing.Size(236, 21);
            this.cbStockStatus.TabIndex = 5;
            // 
            // ProductsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblProducts);
            this.Name = "ProductsView";
            this.Size = new System.Drawing.Size(875, 565);
            this.tblProducts.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tsProduct.ResumeLayout(false);
            this.tsProduct.PerformLayout();
            this.pnlGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.typFilters.ResumeLayout(false);
            this.typFilters.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Colname;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColStatus;
    }
}
