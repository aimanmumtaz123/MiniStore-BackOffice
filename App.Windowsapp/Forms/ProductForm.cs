using App.Core.Models;
using App.Core.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace App.Windowsapp.Forms
{
    public partial class ProductForm : Form
    {
        public ProductForm(ProductFormModeEnum mode, Product? p)
        {
            InitializeComponent();
            nuPrice.Maximum=decimal.MaxValue;
            nuStock.Maximum = Int32.MaxValue;

            cBCategory.Items.Clear();
            cBCategory.DataSource = Enum.GetValues(typeof(ProductCategoryEnum));
            cBCategory.SelectedIndex = 0;

            cBStatus.Items.Clear();
            cBStatus.DataSource = Enum.GetValues(typeof(ProductStatusEnum));
            cBStatus.SelectedIndex = 0;

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
    }
}
