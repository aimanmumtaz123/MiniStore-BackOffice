namespace App.Windowsapp.Views
{
    partial class DashBoardView
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
            tblDashBoard = new TableLayoutPanel();
            flpKPI = new FlowLayoutPanel();
            pnlSales = new Panel();
            lblSalesV = new Label();
            lblSalesT = new Label();
            pnlOrders = new Panel();
            lblOrdersV = new Label();
            lblOrdersT = new Label();
            pnlRevenue = new Panel();
            lblRevenueV = new Label();
            lblRevenueT = new Label();
            pnlLowStock = new Panel();
            lblLowStock = new Label();
            lvLowStock = new ListView();
            colProduct = new ColumnHeader();
            colStock = new ColumnHeader();
            pnlRecentOrder = new Panel();
            lblRecentOrders = new Label();
            lvRecentOrder = new ListView();
            colOrderid = new ColumnHeader();
            colCustomer = new ColumnHeader();
            colTotal = new ColumnHeader();
            colStatus = new ColumnHeader();
            tblDashBoard.SuspendLayout();
            flpKPI.SuspendLayout();
            pnlSales.SuspendLayout();
            pnlOrders.SuspendLayout();
            pnlRevenue.SuspendLayout();
            pnlLowStock.SuspendLayout();
            pnlRecentOrder.SuspendLayout();
            SuspendLayout();
            // 
            // tblDashBoard
            // 
            tblDashBoard.ColumnCount = 1;
            tblDashBoard.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tblDashBoard.Controls.Add(flpKPI, 0, 0);
            tblDashBoard.Controls.Add(pnlLowStock, 0, 1);
            tblDashBoard.Controls.Add(pnlRecentOrder, 0, 2);
            tblDashBoard.Dock = DockStyle.Fill;
            tblDashBoard.Location = new Point(0, 0);
            tblDashBoard.Margin = new Padding(4, 3, 4, 3);
            tblDashBoard.Name = "tblDashBoard";
            tblDashBoard.RowCount = 3;
            tblDashBoard.RowStyles.Add(new RowStyle(SizeType.Absolute, 138F));
            tblDashBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashBoard.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tblDashBoard.Size = new Size(933, 692);
            tblDashBoard.TabIndex = 0;
            tblDashBoard.Paint += tblDashBoard_Paint;
            // 
            // flpKPI
            // 
            flpKPI.Controls.Add(pnlSales);
            flpKPI.Controls.Add(pnlOrders);
            flpKPI.Controls.Add(pnlRevenue);
            flpKPI.Dock = DockStyle.Fill;
            flpKPI.Location = new Point(4, 3);
            flpKPI.Margin = new Padding(4, 3, 4, 3);
            flpKPI.Name = "flpKPI";
            flpKPI.Size = new Size(925, 132);
            flpKPI.TabIndex = 0;
            // 
            // pnlSales
            // 
            pnlSales.BackColor = Color.White;
            pnlSales.Controls.Add(lblSalesV);
            pnlSales.Controls.Add(lblSalesT);
            pnlSales.Location = new Point(4, 3);
            pnlSales.Margin = new Padding(4, 3, 4, 3);
            pnlSales.Name = "pnlSales";
            pnlSales.Size = new Size(282, 115);
            pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            lblSalesV.AutoSize = true;
            lblSalesV.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesV.Location = new Point(156, 51);
            lblSalesV.Margin = new Padding(4, 0, 4, 0);
            lblSalesV.Name = "lblSalesV";
            lblSalesV.Size = new Size(0, 16);
            lblSalesV.TabIndex = 1;
            lblSalesV.Click += lblSalesV_Click;
            // 
            // lblSalesT
            // 
            lblSalesT.AutoSize = true;
            lblSalesT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSalesT.Location = new Point(22, 51);
            lblSalesT.Margin = new Padding(4, 0, 4, 0);
            lblSalesT.Name = "lblSalesT";
            lblSalesT.Size = new Size(42, 16);
            lblSalesT.TabIndex = 0;
            lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            pnlOrders.BackColor = Color.White;
            pnlOrders.Controls.Add(lblOrdersV);
            pnlOrders.Controls.Add(lblOrdersT);
            pnlOrders.Location = new Point(294, 3);
            pnlOrders.Margin = new Padding(4, 3, 4, 3);
            pnlOrders.Name = "pnlOrders";
            pnlOrders.Size = new Size(288, 115);
            pnlOrders.TabIndex = 1;
            // 
            // lblOrdersV
            // 
            lblOrdersV.AutoSize = true;
            lblOrdersV.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdersV.Location = new Point(186, 51);
            lblOrdersV.Margin = new Padding(4, 0, 4, 0);
            lblOrdersV.Name = "lblOrdersV";
            lblOrdersV.Size = new Size(0, 16);
            lblOrdersV.TabIndex = 2;
            lblOrdersV.Click += label4_Click;
            // 
            // lblOrdersT
            // 
            lblOrdersT.AutoSize = true;
            lblOrdersT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblOrdersT.Location = new Point(40, 51);
            lblOrdersT.Margin = new Padding(4, 0, 4, 0);
            lblOrdersT.Name = "lblOrdersT";
            lblOrdersT.Size = new Size(48, 16);
            lblOrdersT.TabIndex = 1;
            lblOrdersT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            pnlRevenue.BackColor = Color.White;
            pnlRevenue.Controls.Add(lblRevenueV);
            pnlRevenue.Controls.Add(lblRevenueT);
            pnlRevenue.Location = new Point(590, 3);
            pnlRevenue.Margin = new Padding(4, 3, 4, 3);
            pnlRevenue.Name = "pnlRevenue";
            pnlRevenue.Size = new Size(295, 115);
            pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            lblRevenueV.AutoSize = true;
            lblRevenueV.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRevenueV.Location = new Point(166, 51);
            lblRevenueV.Margin = new Padding(4, 0, 4, 0);
            lblRevenueV.Name = "lblRevenueV";
            lblRevenueV.Size = new Size(37, 16);
            lblRevenueV.TabIndex = 2;
            lblRevenueV.Text = " PKR";
            lblRevenueV.Click += lblRevenueV_Click;
            // 
            // lblRevenueT
            // 
            lblRevenueT.AutoSize = true;
            lblRevenueT.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRevenueT.Location = new Point(28, 51);
            lblRevenueT.Margin = new Padding(4, 0, 4, 0);
            lblRevenueT.Name = "lblRevenueT";
            lblRevenueT.Size = new Size(62, 16);
            lblRevenueT.TabIndex = 1;
            lblRevenueT.Text = "Revenue";
            lblRevenueT.Click += lblRevenueT_Click;
            // 
            // pnlLowStock
            // 
            pnlLowStock.BackColor = Color.White;
            pnlLowStock.Controls.Add(lblLowStock);
            pnlLowStock.Controls.Add(lvLowStock);
            pnlLowStock.Dock = DockStyle.Fill;
            pnlLowStock.Location = new Point(4, 141);
            pnlLowStock.Margin = new Padding(4, 3, 4, 3);
            pnlLowStock.Name = "pnlLowStock";
            pnlLowStock.Size = new Size(925, 271);
            pnlLowStock.TabIndex = 1;
            // 
            // lblLowStock
            // 
            lblLowStock.AutoSize = true;
            lblLowStock.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLowStock.Location = new Point(4, 78);
            lblLowStock.Margin = new Padding(4, 0, 4, 0);
            lblLowStock.Name = "lblLowStock";
            lblLowStock.Size = new Size(83, 20);
            lblLowStock.TabIndex = 1;
            lblLowStock.Text = "Low Stock";
            lblLowStock.Click += lblLowStock_Click;
            // 
            // lvLowStock
            // 
            lvLowStock.Columns.AddRange(new ColumnHeader[] { colProduct, colStock });
            lvLowStock.FullRowSelect = true;
            lvLowStock.GridLines = true;
            lvLowStock.Location = new Point(4, 105);
            lvLowStock.Margin = new Padding(4, 3, 4, 3);
            lvLowStock.Name = "lvLowStock";
            lvLowStock.Size = new Size(871, 111);
            lvLowStock.TabIndex = 0;
            lvLowStock.UseCompatibleStateImageBehavior = false;
            lvLowStock.View = View.Details;
            lvLowStock.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colProduct
            // 
            colProduct.Text = "Product";
            // 
            // colStock
            // 
            colStock.Text = "Stock";
            // 
            // pnlRecentOrder
            // 
            pnlRecentOrder.BackColor = Color.White;
            pnlRecentOrder.Controls.Add(lblRecentOrders);
            pnlRecentOrder.Controls.Add(lvRecentOrder);
            pnlRecentOrder.Dock = DockStyle.Fill;
            pnlRecentOrder.Location = new Point(4, 418);
            pnlRecentOrder.Margin = new Padding(4, 3, 4, 3);
            pnlRecentOrder.Name = "pnlRecentOrder";
            pnlRecentOrder.Size = new Size(925, 271);
            pnlRecentOrder.TabIndex = 2;
            // 
            // lblRecentOrders
            // 
            lblRecentOrders.AutoSize = true;
            lblRecentOrders.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRecentOrders.Location = new Point(-1, 30);
            lblRecentOrders.Margin = new Padding(4, 0, 4, 0);
            lblRecentOrders.Name = "lblRecentOrders";
            lblRecentOrders.Size = new Size(113, 20);
            lblRecentOrders.TabIndex = 2;
            lblRecentOrders.Text = "Recent Orders";
            lblRecentOrders.Click += lblRecentOrders_Click;
            // 
            // lvRecentOrder
            // 
            lvRecentOrder.Columns.AddRange(new ColumnHeader[] { colOrderid, colCustomer, colTotal, colStatus });
            lvRecentOrder.Location = new Point(4, 57);
            lvRecentOrder.Margin = new Padding(4, 3, 4, 3);
            lvRecentOrder.Name = "lvRecentOrder";
            lvRecentOrder.Size = new Size(871, 111);
            lvRecentOrder.TabIndex = 1;
            lvRecentOrder.UseCompatibleStateImageBehavior = false;
            lvRecentOrder.View = View.Details;
            // 
            // colOrderid
            // 
            colOrderid.Text = "Order Id";
            // 
            // colCustomer
            // 
            colCustomer.Text = "Cutomer";
            // 
            // colTotal
            // 
            colTotal.Text = "Total";
            // 
            // colStatus
            // 
            colStatus.Text = "Status";
            // 
            // DashBoardView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tblDashBoard);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DashBoardView";
            Size = new Size(933, 692);
            tblDashBoard.ResumeLayout(false);
            flpKPI.ResumeLayout(false);
            pnlSales.ResumeLayout(false);
            pnlSales.PerformLayout();
            pnlOrders.ResumeLayout(false);
            pnlOrders.PerformLayout();
            pnlRevenue.ResumeLayout(false);
            pnlRevenue.PerformLayout();
            pnlLowStock.ResumeLayout(false);
            pnlLowStock.PerformLayout();
            pnlRecentOrder.ResumeLayout(false);
            pnlRecentOrder.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblDashBoard;
        private System.Windows.Forms.FlowLayoutPanel flpKPI;
        private System.Windows.Forms.Panel pnlSales;
        private System.Windows.Forms.Panel pnlOrders;
        private System.Windows.Forms.Label lblSalesV;
        private System.Windows.Forms.Label lblSalesT;
        private System.Windows.Forms.Label lblOrdersV;
        private System.Windows.Forms.Label lblOrdersT;
        private System.Windows.Forms.Panel pnlRevenue;
        private System.Windows.Forms.Label lblRevenueV;
        private System.Windows.Forms.Label lblRevenueT;
        private System.Windows.Forms.Panel pnlLowStock;
        private System.Windows.Forms.Panel pnlRecentOrder;
        private System.Windows.Forms.ListView lvLowStock;
        private System.Windows.Forms.ListView lvRecentOrder;
        private System.Windows.Forms.Label lblLowStock;
        private System.Windows.Forms.ColumnHeader colProduct;
        private System.Windows.Forms.ColumnHeader colStock;
        private System.Windows.Forms.Label lblRecentOrders;
        private System.Windows.Forms.ColumnHeader colOrderid;
        private System.Windows.Forms.ColumnHeader colCustomer;
        private System.Windows.Forms.ColumnHeader colTotal;
        private System.Windows.Forms.ColumnHeader colStatus;
    }
}
