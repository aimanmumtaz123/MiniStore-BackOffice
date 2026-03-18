using MiniStore_BackOffice.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore_BackOffice.Forms
{
    public partial class MainForm : Form
    {
        private readonly Dictionary<Type, UserControl> _views = new Dictionary<Type, UserControl>();

        public MainForm()
        {
            InitializeComponent();
            {
                
            }

        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
           // this.pnlContent.Controls.Clear();
           // this.pnlContent.Controls.Add(new ProductsView());

        }

        private void btnDashBoard_Click(object sender, EventArgs e)
        {
            // this.pnlContent.Controls.Clear();
            // this.pnlContent.Controls.Add(new DashBoardView());
        }
        //view
        private void ShowView<T>(Func<T> factory) where T : UserControl
        {
            var key = typeof(T);
            if (_views.TryGetValue(key,out var view )) 
            {
                 view = factory();
                view.Dock = DockStyle.Fill;
                _views[key] = view;

            }
            if (!pnlContent.Controls.Contains(view)) {
                 pnlContent.Controls.Clear();
                pnlContent.Controls.Add(view);


            }
            view.BringToFront();

        }
    }
}
