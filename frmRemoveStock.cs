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
    public partial class frmRemoveStock : Form
    {
        frmMainMenu parent;
        public frmRemoveStock()
        {
            InitializeComponent();
        }

        public frmRemoveStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

      private void mnuBack_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();

            //make main menu visible
            parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtStockId.Text.Length < 3 || txtStockId.Text.Length > 3)
            {
                MessageBox.Show("Stock Id must be 3 digits", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStockId.Focus();
                return;
            }
            //retrieve stock details from DB (Not for prototype)
            //load on UI
            txtDesc.Text = "BIC Blue ballpoint"; //entering this text onto desc field
            txtQty.Text = "027";
            txtCost.Text = "3.50";

            //display
            grpStock.Visible = true; //making the group box visible
        }

        private void btnRemStock_Click(object sender, EventArgs e)
        {

            //if(cboStatus.Text.Equals REMOVED!)
            //{
            //Remove That Record
           // }


            //update database

            //user confirmtaion
            MessageBox.Show("Are you sure you want to remove this piece of stock?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            //display confirmation message
            MessageBox.Show("Stock Removed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box

            //reset ui

            grpStock.Visible = false; //hides group box
            txtStockId.Clear(); //clears stock it field
            txtStockId.Focus(); //cursor goes to stock id
        }

        private void frmRemoveStock_Load(object sender, EventArgs e)
        {
            cboStatus.Items.Add("Available");
            cboStatus.Items.Add("Removed");
        }
    }
}
