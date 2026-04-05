using App.Core.Contracts;
using App.Core.Models;
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
    public partial class CustomerPicker : Form
    {
        private readonly ICustomerService _customerService;
        private BindingSource _bindingSource;
        public CustomerForm SelectedCustomer { get; private set; }
        public CustomerPicker(ICustomerService service)
        {
            InitializeComponent();
            _bindingSource = new BindingSource();
            lbCustomers.DataSource = _bindingSource;
            _customerService = service;
            LoadCustomer(string.Empty);
        }

        private void LoadCustomer(string query)
        {
            var customers = string.IsNullOrWhiteSpace(query) ?
                _customerService.GetAll() : _customerService.Search(query);
            _bindingSource.DataSource = customers;
            lbCustomers.DisplayMember = "Name";
            lbCustomers.ValueMember = "Id";
        }
        private void tbSearchQuery_TextChanged(object sender, EventArgs e)
        {
            LoadCustomer(tbSearchQuery.Text);
        }

        private void SelectCustomer()
        {

            if (lbCustomers.SelectedItem != null && lbCustomers.SelectedItem is Customer)
            {
                SelectedCustomer = (CustomerForm)lbCustomers.SelectedItem;
                this.DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Please select a customer", " Customer Select",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void lbCustomers_DoubleClick(object sender, EventArgs e)
        {
            SelectCustomer();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult= DialogResult.Cancel;
            Close();
        }
    }
}
