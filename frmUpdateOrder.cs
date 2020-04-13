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
    public partial class frmUpdateOrder : Form
    {
        frmMainMenu parent;
        public frmUpdateOrder()
        {
            InitializeComponent();
        }

        public frmUpdateOrder(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();

            //make main menu visible
            Parent.Visible = true;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //validate the data
            if (txtOrderId.Text.Equals(""))
            {
                //"OrderId entered is invalid";

                MessageBox.Show("Order Id entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.Focus();
                return;
            }

            // retrieve order details from DB (Not for prototype)

                //OrderId not found
                if (txtOrderId.Text.Equals("999"))
                {
                    MessageBox.Show("This order does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtOrderId.Focus();
                    return;
                }

            if (txtOrderId.Text.Equals("888"))
            {
                MessageBox.Show("This order has been removed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.Focus();
                return;
            }

            if (txtOrderId.Text.Length < 3 || txtOrderId.Text.Length > 3)
            {
                MessageBox.Show("Order Id must be 3 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.Focus();
                return;
            }

            //load on UI
            //hard coded order
            txtDeptId.Text = "0011"; //entering this text onto deptId field
            txtStockId.Text = "001";
            txtQty.Text = "5";
            //cboStatus

            //display
            grpUpdateOrder.Visible = true; //making the group box visible

        }



        private void frmUpdateOrder_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Add("Placed");
            cboStatus.Items.Add("Cancelled");
         
         
        }

        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (txtDeptId.Text.Equals(""))
            {
                //"Description entered is invalid";

                MessageBox.Show("Department Id entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeptId.Focus();
                return;
            }

            if (txtStockId.Text.Equals(""))
            {
                //"Cost entered is invalid";

                MessageBox.Show("Stock Id entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockId.Focus();
                return;
            }

            if (txtQty.Text.Equals(""))
            {
                //"Quantity entered is invalid";

                MessageBox.Show("Quantity entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeptId.Focus();
                return;
            }

           

            if (txtDeptId.Text.Length < 4 || txtDeptId.Text.Length > 4)
            {
                MessageBox.Show("Department Id must be 4 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDeptId.Focus();
                return;
            }

            if (txtStockId.Text.Length < 3 || txtStockId.Text.Length > 3)
            {
                MessageBox.Show("Stock Id must be 3 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockId.Focus();
                return;
            }

            //if (txtQty.Text. HAS A LETTER)
            //{

            //MessageBox.Show("Invalid Entry for Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//PROBLEM!!
            //txtQty.Focus();
            //  return;

            //}

            //user confirmtaion
            MessageBox.Show("Are you sure you want update this piece order?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //update database

            //display confirmation message
            MessageBox.Show("Order Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box

            //reset ui

            grpUpdateOrder.Visible = false;
            txtOrderId.Clear(); //clears order id field
            txtOrderId.Focus(); //cursor goes to order id
            txtDeptId.Clear();
            txtStockId.Clear();
            txtQty.Clear();
            cboStatus.ResetText();


        }
    }
}
