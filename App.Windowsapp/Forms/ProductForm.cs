using App.Core.Models;
using App.Core.Utilities;
using App.Windowsapp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.Core.Contracts;


namespace App.Windowsapp.Forms
{
    public partial class ProductForm : Form
    {
        ProductFormModeEnum _mode;
        Product _product;
        IProductServices _service;
        public ProductForm(ProductFormModeEnum mode, Product? p , IProductServices service)
        {
            InitializeComponent();

            nuPrice.Maximum = Decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cBCategory.Items.Clear();
            cBCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cBCategory.SelectedIndex = 0;

            cBStatus.Items.Clear();
            cBStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cBStatus.SelectedIndex = 0;

            _mode = mode;
            _product = p;
            _service = service;



            if (mode == ProductFormModeEnum.Edit)
            {
                btnSave.Text = "Update";
            }
            else if (mode == ProductFormModeEnum.View)
            {
                btnSave.Visible = false;

            }

            if (mode == ProductFormModeEnum.Edit || mode == ProductFormModeEnum.View)
            {
                txtId.Text = p.Id;
                txtName.Text = p.Name;
                cBCategory.SelectedItem = p.Category;
                cBStatus.SelectedItem = p.Status;
                nuPrice.Value = p.Price;
                nuStock.Value = p.Stock;
            }


        }

        private void tlpProductForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flpProductForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e )
        { 
            if(_mode == ProductFormModeEnum.Add)
            {
                Product newProduct = new Product();
                newProduct.Name = txtName.Text;
                newProduct.Category = (ProductCategoryEnum)cBCategory.SelectedItem;
                newProduct.Status = (ProductStatusEnum)cBStatus.SelectedItem;
                newProduct.Price = nuPrice.Value;
                newProduct.Stock = (int) nuStock.Value;

                //_product = _service.Add(newProduct);
                //txtId.Text = _product.Id;

                //Product temp = _service.Add(newProduct);
                //txtId.Text = temp?.Id ?? "";
            }
            else if(_mode == ProductFormModeEnum.Edit)
            {
                _product.Name = txtName.Text;
                _product.Category = (ProductCategoryEnum)cBCategory.SelectedItem;
                _product.Status = (ProductStatusEnum)cBStatus.SelectedItem;
                _product.Price = nuPrice.Value;
                _product.Stock = (int)nuStock.Value;

                bool isUpdate = _service.Update(_product);
            }
        }
    }
}
