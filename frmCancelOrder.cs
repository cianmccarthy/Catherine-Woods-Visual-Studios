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
    
    public partial class frmCancelOrder : Form
    {
        frmMainMenu parent;
        public frmCancelOrder()
        {
            InitializeComponent();
        }
        public frmCancelOrder(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();

            //make main menu visible
            Parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmCancelOrder_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Add("Placed");
            cboStatus.Items.Add("Cancelled");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate the data
            if (txtId.Text.Equals(""))
            {
                //"OrderId entered is invalid";

                MessageBox.Show("Order Id entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            // retrieve order details from DB (Not for prototype)

            //OrderId not found
            if (txtId.Text.Equals("999"))
            {
                MessageBox.Show("This order does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            if (txtId.Text.Equals("888"))
            {
                MessageBox.Show("This order has been removed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            if (txtId.Text.Length < 3 || txtId.Text.Length > 3)
            {
                MessageBox.Show("Order Id must be 3 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            //load on UI
            //hard coded stock
            txtDeptId.Text = "0011"; //entering this text onto deptId field
            txtStockId.Text = "001";
            txtQty.Text = "5";
            //cboStatus

            //display
            grpCancelOrder.Visible = true; //making the group box visible
        }

        private void btnCancelOrder_Click(object sender, EventArgs e)
        {
            //user confirmtaion
            MessageBox.Show("Are you sure you want cancel this order?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //update database

            //display confirmation message
            MessageBox.Show("Order Cancelled", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box

            //reset ui

            grpCancelOrder.Visible = false;
            txtId.Clear(); //clears order id field
            txtId.Focus(); //cursor goes to order id
            txtDeptId.Clear();
            txtStockId.Clear();
            txtQty.Clear();
            cboStatus.ResetText();
        }
    }
}
