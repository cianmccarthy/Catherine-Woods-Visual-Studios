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
    public partial class frmCloseDepartment : Form
    {
        frmMainMenu parent;
        public frmCloseDepartment()
        {
            InitializeComponent();
        }

        public frmCloseDepartment(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();

            parent.Show();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
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

        private void btnCloseDept_Click(object sender, EventArgs e)
        {
            //User Confirmation
            MessageBox.Show("Are you sure you want to close this department?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //display system confirmation message

            MessageBox.Show("Department Closed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box


            txtId.Clear();
            txtId.Focus();
            txtName.Clear();
            txtRequestor.Clear();
            cboLocation.ResetText();

        }
    }
}
