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
    public partial class frmPlaceOrder : Form
    {
        frmCustomerMainMenu parent;
        public frmPlaceOrder()
        {
            InitializeComponent();
        }

        public frmPlaceOrder(frmCustomerMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click_1(object sender, EventArgs e)
        {
            //close this form
            this.Close();

            //make main menu visible
            parent.Visible = true;
        }

        private void mnuExit_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnPlaceOrder_Click_1(object sender, EventArgs e)
        {
            //save data in database (not doing for prototype)
            //instantiate the STOCK variables
          //  Order myOrder = new Order(Convert.ToInt32(txtOrderId.Text), Convert.ToInt32(txtDeptId.Text), Convert.ToInt32(txtStockId.Text), Convert.ToInt32(txtQty.Text),//THE ORDER DATE AND ORDER VALUE! "P");

            //CALL THE RegisterStock() METHOD

          //  myOrder.placeOrder();

            //display system confirmation message

            MessageBox.Show("Order Placed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box


            //validate the data
            if (txtOrderId.Text.Equals(""))
            {
                //"OrderId entered is invalid";

                MessageBox.Show("Order Id entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.Focus();
                return;
            }

            if (txtOrderId.Text.Length < 3 || txtOrderId.Text.Length > 3)
            {
                MessageBox.Show("Order Id must be 3 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOrderId.Focus();
                return;
            }


            if (txtRequestor.Text.Equals(""))
            {
                //"Cost entered is invalid";

                MessageBox.Show("Cost entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRequestor.Focus();
                return;
            }

            if (txtRequestor.Text.Length < 3 || txtRequestor.Text.Length > 3)
            {
                MessageBox.Show("Stock Id must be 3 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRequestor.Focus();
                return;
            }


            //if (txtQty.Text. HAS A LETTER)
            //{

            //MessageBox.Show("Invalid Entry for Quantity", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//PROBLEM!!
            //txtQty.Focus();
            //  return;

            //}

            //User Confirmation
            MessageBox.Show("Are you sure you want to place this order?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //save data


            

            //reset UI
            txtOrderId.Clear(); //clears stock it field
            txtOrderId.Focus(); //cursor goes to stock id
            //txtDeptId.Clear();
            txtRequestor.Clear();
            txtLocation.Clear();

            //DON'T KNOW HOW TO RESET CALENDAR. DON'T KNOW HOW TO NAME CALENDAR
       
        }

        private void frmPlaceOrder_Load_1(object sender, EventArgs e)
        {

            grpStock.Visible = false;
            // Get Order Id
            //SYSTEM DETERMINES NEXT STOCK ID
            txtOrderId.Text = Order.getOrderId().ToString("000");

            //Load departments

            DataSet ds = Department.getDepts();

            for (int i = 0; i<= ds.Tables["DP"].Rows.Count-1; i++)
            {
                cboDepts.Items.Add(ds.Tables[0].Rows[i][0].ToString().PadLeft(4,'0') + " " + ds.Tables[0].Rows[i][2].ToString());
            }

            // MessageBox.Show(DateTime.Today.ToLongDateString());

            MessageBox.Show(String.Format("{0:dd-MMM-yy}", DateTime.Today));

            grdStock.DataSource = Stock.getAllStock().Tables["ST"];
           // grdDepartments.DataSource = Stock.getAllDepartments().Tables["DP"];
            //Utility.formatGrid(grdWidgets);
        }

        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve STOCK for Col 0 of row selected
            Stock myStock = new Stock();
            myStock.getAnItem(Convert.ToInt32(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value));

            //load widget details onto form
            txtRequestor.Text = myStock.getId().ToString();

            grpDept.Visible = true;
        }

        private void cboDepts_SelectedIndexChanged(object sender, EventArgs e)
        {
            // get Department Details
            Department dept = new Department();
            dept.getDepartment(Convert.ToInt32(cboDepts.Text.Substring(0,4)));
            txtLocation.Text = dept.getLocation();
            txtRequestor.Text = dept.getRequestor();

            grpStock.Visible = true;

            String deptId = cboDepts.Text.Substring(0, 4);
            String str = "SELECT Requestor FROM Departments WHERE Dept_Id = " + deptId;

            txtRequestor.Equals(str);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {


            //add to order details
            lstItems.Items.Add("Stock Id  " + "  Description  " + "  Quantity  " + "  Unit Cost  ");
            lstItems.Items.Add(String.Format("{000}", grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value) + " " + "XXX" + txtQty.Text + "               XXX        ");

            txtTotal.Text = Convert.ToDouble(txtTotal.Text) + (Convert.ToInt32((txtQty.Text)) * Convert.ToDouble(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[3].Value)).ToString("000.00");
        }
    }
}
