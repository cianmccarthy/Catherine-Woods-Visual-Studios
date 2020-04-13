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
    public partial class frmChangeStock : Form
    {
        frmMainMenu parent;

        public frmChangeStock()
        {
            InitializeComponent();
        }

        public frmChangeStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

       //EXIT THE APPLICATION                           
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //GOING BACK TO THE MAIN MENU
        private void mnuBack_Click(object sender, EventArgs e)
        {
                //close this form
                this.Close();

                //make main menu visible
                parent.Visible = true;
            
        }

        //WHEN YOU CLICK THE CHANGE STOCK BUTTON
        private void btnChg_Click(object sender, EventArgs e) //when change stock button is clicked
        {
            //--------VALIDATION---------

            //CHECK IF DESCRIPTION IS EMPTY
            if (txtDesc.Text.Equals(""))
            {
                MessageBox.Show("Description entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            //CHECK IF QUANTITY IS EMPTY
            if (txtQty.Text.Equals(""))
            {
                MessageBox.Show("Quantity entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            //CHECK IF QUANTITY IS GREATER THAN ZERO
            if(Convert.ToInt32(txtQty.Text) <= 0)
            {
              MessageBox.Show("Quantity entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
               txtQty.Focus();
               return;
            }

            //CHECK IF COST IS EMPTY
            if (txtCost.Text.Equals(""))
            {
                MessageBox.Show("Cost entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
               return;
            }

            //CHECK IF COST IS GREATER THAN ZERO
             if((Convert.ToDouble(txtCost.Text))<=0)
            {
                MessageBox.Show("Cost entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            //--------VALIDATION END----------

            //-------UPDATING THE DATA---------

            //instantiate the STOCK variables
            Stock myStock = new Stock();
            myStock.setId(Convert.ToInt32(txtStockId.Text));
            myStock.setDescription(txtDesc.Text);
            myStock.setQuantity(Convert.ToInt32(txtQty.Text));
            myStock.setCost(Convert.ToDouble(txtCost.Text));

          
            //CALL THE updateStock() METHOD

            myStock.updateStock();

            //grpWidgets.Visible = false;

            //user confirmtaion
            MessageBox.Show("Are you sure you want change this piece of stock?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            
            
            //display confirmation message
            MessageBox.Show("Stock Changed", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box

            //RESETTING THE UI

            //refill grid
            grdStock.DataSource = Stock.getStock().Tables["ST"];

            grpStock.Visible = false; //making the group box invisible again
            txtStockId.Clear(); //clears stock it field
            txtStockId.Focus(); //cursor goes to stock id
            
        }

        private void frmChangeStock_Load(object sender, EventArgs e)
        {
            grdStock.DataSource = Stock.getStock().Tables["ST"];

            //Utility.formatGrid(grdWidgets);
        }

        private void grdStock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //retrieve STOCK for Col 0 of row selected
            Stock myStock = new Stock();
            myStock.getAnItem(Convert.ToInt32(grdStock.Rows[grdStock.CurrentCell.RowIndex].Cells[0].Value));

            //load widget details onto form
            txtStockId.Text = myStock.getId().ToString();
            txtDesc.Text = myStock.getDescription();
            txtQty.Text = myStock.getQuantity().ToString();
            txtCost.Text = myStock.getCost().ToString();

            grpStock.Visible = true;
        }
        //CODE FOR ONLY TAKING IN NUMBERS INTO QUANTITY FIELD
        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        //CODE FOR TAKING IN NUMBERS AND DOTS (FOR FLOATS) ONLY
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtCost.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(ch) && ch != 8 && ch!= 46)
            {
                e.Handled = true;
            }
        }
    }
}
