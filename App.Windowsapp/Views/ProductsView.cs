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
            var categories = new List<object> { "--All--" };
            categories.AddRange(Enum.GetValues(typeof(ProductCategoryEnum)).Cast<object>());
            cbCategory.DataSource = categories;
            cbCategory.SelectedIndex = 0;

            cbStockStatus.Items.Clear();
            var stockStatus = new List<object> { "--All--" };
            stockStatus.AddRange(Enum.GetValues(typeof(ProductStatusEnum)).Cast<object>());
            cbStockStatus.DataSource = stockStatus;
            cbStockStatus.SelectedIndex = 0;

            if (_service == null)
            {
                return;
            }

            //_service.GetAll();
            _dgvBindingSource.DataSource = _service.GetAll();
        }

        private void tsbAdd_Click(object sender, EventArgs e)

        {

            ProductForm prodForm = new ProductForm(ProductFormModeEnum.Add, null, _service);
            prodForm.ShowDialog();
            RefreshGrid();


        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.Edit, selectedProduct, _service);
                prodForm.ShowDialog();
                RefreshGrid();
            }
        }

        private void tsbView_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;
            if (selectedProduct != null)
            {
                ProductForm prodForm = new ProductForm(ProductFormModeEnum.View, selectedProduct, _service);
                prodForm.ShowDialog();
            }
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            RefreshGrid();
        }



        
        private void RefreshGrid()
        {
            //_dgvBindingSource.DataSource = _service.GetAll();

            string searchText = tbSearch.Text;

            ProductCategoryEnum? selectedCategory = null;
            if (cbCategory.SelectedItem != null)
            {
                if (cbCategory.SelectedItem.ToString().Equals("--All--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedCategory = (ProductCategoryEnum?)cbCategory.SelectedItem;
                }
            }

            ProductStatusEnum? selectedStatus = null;
            if (cbStockStatus.SelectedItem != null)
            {
                if (cbStockStatus.SelectedItem.ToString().Equals("--All--"))
                {
                    selectedCategory = null;
                }
                else
                {
                    selectedStatus = (ProductStatusEnum?)cbStockStatus.SelectedItem;
                }
            }


            _dgvBindingSource.DataSource = _service.Search(searchText, selectedCategory, selectedStatus);
        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }

        private void cbStockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshGrid();
        }
        //Delete btn :
        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Product? selectedProduct = _dgvBindingSource.Current as Product;

            if (selectedProduct == null)
            {
                MessageBox.Show("Please select a product.");
                return;
            }

            var confirm = MessageBox.Show(
                "Are you sure you want to delete?",
                "Confirm",
                MessageBoxButtons.YesNo
            );

            if (confirm == DialogResult.Yes)
            {
                bool isDeleted = _service.Delete(selectedProduct.Id); // check Id/P_Id

                if (isDeleted)
                {
                    MessageBox.Show("Deleted Successfully");

                    _dgvBindingSource.DataSource = null;
                    _dgvBindingSource.DataSource = _service.GetAll();
                }
                else
                {
                    MessageBox.Show("Delete failed!");
                }
            }
        }
    }
}
