using App.Core.Contracts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Utilities;
using App.Core.Services;
using App.Windowsapp.Forms;
using App.Core.Models;

namespace App.Windowsapp.Views
{
    public partial class ProductsView : UserControl
    {
        IProductServices _service;
        BindingSource _dgvBindingSource = new BindingSource();

        public ProductsView(IProductServices _ser)

        {
            InitializeComponent();
            _service = _ser;
            dgvProducts.DataSource = _dgvBindingSource;

        }


        private void ProductsView_Load_1(object sender, EventArgs e)
        {
            cbCategory.Items.Clear();
            cbCategory.Items.Add("--All--");
            cbCategory.Items.AddRange(Enum.GetNames(typeof(ProductCategoryEnum)));
            cbCategory.SelectedIndex = 0;

            cbStockStatus.Items.Clear();
            cbStockStatus.Items.Add("--All--");
            cbStockStatus.Items.AddRange(Enum.GetNames(typeof(ProductStatusEnum)));
            cbStockStatus.SelectedIndex = 0;
            if (_service == null)
            {
                return;
            }
            _service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)

        {

            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null);
            prodForm.ShowDialog();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct);
                prodForm.ShowDialog();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct);
                prodForm.ShowDialog();
            }
        }

       
    }
}
