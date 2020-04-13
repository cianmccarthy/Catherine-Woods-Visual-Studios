using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StockSYS
{
    public partial class frmCustomerMainMenu : Form
    {
        public frmCustomerMainMenu()
        {
            InitializeComponent();
        }

        private void mnuPlaceOrder_Click(object sender, EventArgs e)
        {
            frmPlaceOrder nextForm = new frmPlaceOrder(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
