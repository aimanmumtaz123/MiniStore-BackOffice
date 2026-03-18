namespace MiniStore_BackOffice.Views
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
            this.tblDashBoard = new System.Windows.Forms.TableLayoutPanel();
            this.flpKPI = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlSales = new System.Windows.Forms.Panel();
            this.lblSalesV = new System.Windows.Forms.Label();
            this.lblSalesT = new System.Windows.Forms.Label();
            this.pnlOrders = new System.Windows.Forms.Panel();
            this.lblOrdersV = new System.Windows.Forms.Label();
            this.lblOrdersT = new System.Windows.Forms.Label();
            this.pnlRevenue = new System.Windows.Forms.Panel();
            this.lblRevenueV = new System.Windows.Forms.Label();
            this.lblRevenueT = new System.Windows.Forms.Label();
            this.pnlLowStock = new System.Windows.Forms.Panel();
            this.pnlRecentOrder = new System.Windows.Forms.Panel();
            this.lvLowStock = new System.Windows.Forms.ListView();
            this.lvRecentOrder = new System.Windows.Forms.ListView();
            this.lblLowStock = new System.Windows.Forms.Label();
            this.colProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCustomer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblRecentOrders = new System.Windows.Forms.Label();
            this.tblDashBoard.SuspendLayout();
            this.flpKPI.SuspendLayout();
            this.pnlSales.SuspendLayout();
            this.pnlOrders.SuspendLayout();
            this.pnlRevenue.SuspendLayout();
            this.pnlLowStock.SuspendLayout();
            this.pnlRecentOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblDashBoard
            // 
            this.tblDashBoard.ColumnCount = 1;
            this.tblDashBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblDashBoard.Controls.Add(this.flpKPI, 0, 0);
            this.tblDashBoard.Controls.Add(this.pnlLowStock, 0, 1);
            this.tblDashBoard.Controls.Add(this.pnlRecentOrder, 0, 2);
            this.tblDashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblDashBoard.Location = new System.Drawing.Point(0, 0);
            this.tblDashBoard.Name = "tblDashBoard";
            this.tblDashBoard.RowCount = 3;
            this.tblDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tblDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tblDashBoard.Size = new System.Drawing.Size(800, 600);
            this.tblDashBoard.TabIndex = 0;
            this.tblDashBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.tblDashBoard_Paint);
            // 
            // flpKPI
            // 
            this.flpKPI.Controls.Add(this.pnlSales);
            this.flpKPI.Controls.Add(this.pnlOrders);
            this.flpKPI.Controls.Add(this.pnlRevenue);
            this.flpKPI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpKPI.Location = new System.Drawing.Point(3, 3);
            this.flpKPI.Name = "flpKPI";
            this.flpKPI.Size = new System.Drawing.Size(794, 114);
            this.flpKPI.TabIndex = 0;
            // 
            // pnlSales
            // 
            this.pnlSales.BackColor = System.Drawing.Color.White;
            this.pnlSales.Controls.Add(this.lblSalesV);
            this.pnlSales.Controls.Add(this.lblSalesT);
            this.pnlSales.Location = new System.Drawing.Point(3, 3);
            this.pnlSales.Name = "pnlSales";
            this.pnlSales.Size = new System.Drawing.Size(242, 100);
            this.pnlSales.TabIndex = 0;
            // 
            // lblSalesV
            // 
            this.lblSalesV.AutoSize = true;
            this.lblSalesV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesV.Location = new System.Drawing.Point(134, 44);
            this.lblSalesV.Name = "lblSalesV";
            this.lblSalesV.Size = new System.Drawing.Size(28, 16);
            this.lblSalesV.TabIndex = 1;
            this.lblSalesV.Text = "163";
            this.lblSalesV.Click += new System.EventHandler(this.lblSalesV_Click);
            // 
            // lblSalesT
            // 
            this.lblSalesT.AutoSize = true;
            this.lblSalesT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalesT.Location = new System.Drawing.Point(19, 44);
            this.lblSalesT.Name = "lblSalesT";
            this.lblSalesT.Size = new System.Drawing.Size(42, 16);
            this.lblSalesT.TabIndex = 0;
            this.lblSalesT.Text = "Sales";
            // 
            // pnlOrders
            // 
            this.pnlOrders.BackColor = System.Drawing.Color.White;
            this.pnlOrders.Controls.Add(this.lblOrdersV);
            this.pnlOrders.Controls.Add(this.lblOrdersT);
            this.pnlOrders.Location = new System.Drawing.Point(251, 3);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Size = new System.Drawing.Size(247, 100);
            this.pnlOrders.TabIndex = 1;
            // 
            // lblOrdersV
            // 
            this.lblOrdersV.AutoSize = true;
            this.lblOrdersV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersV.Location = new System.Drawing.Point(159, 44);
            this.lblOrdersV.Name = "lblOrdersV";
            this.lblOrdersV.Size = new System.Drawing.Size(21, 16);
            this.lblOrdersV.TabIndex = 2;
            this.lblOrdersV.Text = "33";
            this.lblOrdersV.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblOrdersT
            // 
            this.lblOrdersT.AutoSize = true;
            this.lblOrdersT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrdersT.Location = new System.Drawing.Point(34, 44);
            this.lblOrdersT.Name = "lblOrdersT";
            this.lblOrdersT.Size = new System.Drawing.Size(48, 16);
            this.lblOrdersT.TabIndex = 1;
            this.lblOrdersT.Text = "Orders";
            // 
            // pnlRevenue
            // 
            this.pnlRevenue.BackColor = System.Drawing.Color.White;
            this.pnlRevenue.Controls.Add(this.lblRevenueV);
            this.pnlRevenue.Controls.Add(this.lblRevenueT);
            this.pnlRevenue.Location = new System.Drawing.Point(504, 3);
            this.pnlRevenue.Name = "pnlRevenue";
            this.pnlRevenue.Size = new System.Drawing.Size(253, 100);
            this.pnlRevenue.TabIndex = 2;
            // 
            // lblRevenueV
            // 
            this.lblRevenueV.AutoSize = true;
            this.lblRevenueV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueV.Location = new System.Drawing.Point(142, 44);
            this.lblRevenueV.Name = "lblRevenueV";
            this.lblRevenueV.Size = new System.Drawing.Size(75, 16);
            this.lblRevenueV.TabIndex = 2;
            this.lblRevenueV.Text = "37,356 PKR";
            this.lblRevenueV.Click += new System.EventHandler(this.lblRevenueV_Click);
            // 
            // lblRevenueT
            // 
            this.lblRevenueT.AutoSize = true;
            this.lblRevenueT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRevenueT.Location = new System.Drawing.Point(24, 44);
            this.lblRevenueT.Name = "lblRevenueT";
            this.lblRevenueT.Size = new System.Drawing.Size(62, 16);
            this.lblRevenueT.TabIndex = 1;
            this.lblRevenueT.Text = "Revenue";
            this.lblRevenueT.Click += new System.EventHandler(this.lblRevenueT_Click);
            // 
            // pnlLowStock
            // 
            this.pnlLowStock.BackColor = System.Drawing.Color.White;
            this.pnlLowStock.Controls.Add(this.lblLowStock);
            this.pnlLowStock.Controls.Add(this.lvLowStock);
            this.pnlLowStock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlLowStock.Location = new System.Drawing.Point(3, 123);
            this.pnlLowStock.Name = "pnlLowStock";
            this.pnlLowStock.Size = new System.Drawing.Size(794, 234);
            this.pnlLowStock.TabIndex = 1;
            // 
            // pnlRecentOrder
            // 
            this.pnlRecentOrder.BackColor = System.Drawing.Color.White;
            this.pnlRecentOrder.Controls.Add(this.lblRecentOrders);
            this.pnlRecentOrder.Controls.Add(this.lvRecentOrder);
            this.pnlRecentOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlRecentOrder.Location = new System.Drawing.Point(3, 363);
            this.pnlRecentOrder.Name = "pnlRecentOrder";
            this.pnlRecentOrder.Size = new System.Drawing.Size(794, 234);
            this.pnlRecentOrder.TabIndex = 2;
            // 
            // lvLowStock
            // 
            this.lvLowStock.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProduct,
            this.colStock});
            this.lvLowStock.FullRowSelect = true;
            this.lvLowStock.GridLines = true;
            this.lvLowStock.HideSelection = false;
            this.lvLowStock.Location = new System.Drawing.Point(3, 91);
            this.lvLowStock.Name = "lvLowStock";
            this.lvLowStock.Size = new System.Drawing.Size(747, 97);
            this.lvLowStock.TabIndex = 0;
            this.lvLowStock.UseCompatibleStateImageBehavior = false;
            this.lvLowStock.View = System.Windows.Forms.View.Details;
            this.lvLowStock.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // lvRecentOrder
            // 
            this.lvRecentOrder.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colOrderid,
            this.colCustomer,
            this.colTotal,
            this.colStatus});
            this.lvRecentOrder.HideSelection = false;
            this.lvRecentOrder.Location = new System.Drawing.Point(3, 49);
            this.lvRecentOrder.Name = "lvRecentOrder";
            this.lvRecentOrder.Size = new System.Drawing.Size(747, 97);
            this.lvRecentOrder.TabIndex = 1;
            this.lvRecentOrder.UseCompatibleStateImageBehavior = false;
            this.lvRecentOrder.View = System.Windows.Forms.View.Details;
            // 
            // lblLowStock
            // 
            this.lblLowStock.AutoSize = true;
            this.lblLowStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLowStock.Location = new System.Drawing.Point(3, 68);
            this.lblLowStock.Name = "lblLowStock";
            this.lblLowStock.Size = new System.Drawing.Size(83, 20);
            this.lblLowStock.TabIndex = 1;
            this.lblLowStock.Text = "Low Stock";
            this.lblLowStock.Click += new System.EventHandler(this.lblLowStock_Click);
            // 
            // colProduct
            // 
            this.colProduct.Text = "Product";
            // 
            // colStock
            // 
            this.colStock.Text = "Stock";
            // 
            // colOrderid
            // 
            this.colOrderid.Text = "Order Id";
            // 
            // colCustomer
            // 
            this.colCustomer.Text = "Cutomer";
            // 
            // colTotal
            // 
            this.colTotal.Text = "Total";
            // 
            // colStatus
            // 
            this.colStatus.Text = "Status";
            // 
            // lblRecentOrders
            // 
            this.lblRecentOrders.AutoSize = true;
            this.lblRecentOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecentOrders.Location = new System.Drawing.Point(-1, 26);
            this.lblRecentOrders.Name = "lblRecentOrders";
            this.lblRecentOrders.Size = new System.Drawing.Size(113, 20);
            this.lblRecentOrders.TabIndex = 2;
            this.lblRecentOrders.Text = "Recent Orders";
            this.lblRecentOrders.Click += new System.EventHandler(this.lblRecentOrders_Click);
            // 
            // DashBoardView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tblDashBoard);
            this.Name = "DashBoardView";
            this.Size = new System.Drawing.Size(800, 600);
            this.tblDashBoard.ResumeLayout(false);
            this.flpKPI.ResumeLayout(false);
            this.pnlSales.ResumeLayout(false);
            this.pnlSales.PerformLayout();
            this.pnlOrders.ResumeLayout(false);
            this.pnlOrders.PerformLayout();
            this.pnlRevenue.ResumeLayout(false);
            this.pnlRevenue.PerformLayout();
            this.pnlLowStock.ResumeLayout(false);
            this.pnlLowStock.PerformLayout();
            this.pnlRecentOrder.ResumeLayout(false);
            this.pnlRecentOrder.PerformLayout();
            this.ResumeLayout(false);

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
