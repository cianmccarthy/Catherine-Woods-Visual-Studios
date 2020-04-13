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
    public partial class frmUpdateDepartment : Form
    {

        frmMainMenu parent;

        public frmUpdateDepartment()
        {
            InitializeComponent();
        }

        public frmUpdateDepartment(frmMainMenu Parent)
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
        
      private void Search_Click(object sender, EventArgs e)
             {
            //retrieve Dept details from DB (Not for prototype)

            //Dept Id not found
            if (txtId.Text.Equals("9999"))
            {
                MessageBox.Show("This Department does not exist", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            if (txtId.Text.Equals("8888"))
            {
                MessageBox.Show("This Department has been closed", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            if (txtId.Text.Length < 4 || txtId.Text.Length > 4)
            {
                MessageBox.Show("Department Id must be 4 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }

            if (txtId.Text.Equals(""))
            {
                //"Id entered is invalid";

                MessageBox.Show("Department Id entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtId.Focus();
                return;
            }      

            //display
            grpDetails.Visible = true; //making the group box visible
        }

        private void btnUpdateDept_Click_1(object sender, EventArgs e)
        {
            //validation
    
            if (txtRequestor.Text.Equals(""))
            {
                //"Requestor entered is invalid";

                MessageBox.Show("Requestor entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRequestor.Focus();
                return;
            }

            if (txtName.Text.Equals(""))
            {
                //"Name entered is invalid";

                MessageBox.Show("Department Name entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            //if (txtRequestor.Text. HAS A NUMBER)
            //{

            //MessageBox.Show("Invalid Entry for Requestor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);//PROBLEM!!
            //txtQty.Focus();
            //  return;

            //}


            //if (txtName.Text.HAS A NUMBER)
            //{
            //MessageBox.Show("Invalid Entry for Department", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //PROBLEM!!
            //txtCost.Focus();
            //  return;
            //}

            //User Confirmation
            MessageBox.Show("Are you sure you want to update this department?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //display system confirmation message

            MessageBox.Show("Department Updated", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box


            //reset UI
            txtId.Clear(); //clears Dept id field
            txtId.Focus(); //cursor goes to Dept id
            txtRequestor.Clear();
            txtName.Clear();
            cboLocation.ResetText();
        }

   

        private void frmUpdateDepartment_Load(object sender, EventArgs e)
        {
            cboLocation.Items.Add("North");
            cboLocation.Items.Add("South");
            cboLocation.Items.Add("West");
            cboLocation.Items.Add("East");

        }
    }
}
