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
    public partial class frmRegisterStock : Form
    {
        frmMainMenu parent;

        public frmRegisterStock()
        {
            InitializeComponent();
        }


        public frmRegisterStock(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
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
            parent.Visible = true;
        }

        private void frmRegisterStock_Load(object sender, EventArgs e)
        {
            //SYSTEM DETERMINES NEXT STOCK ID
            txtStockId.Text = Stock.getStockId().ToString("000");

            grdStock.DataSource = Stock.getStock().Tables["WS"];
            //Utility.formatGrid(grdWidgets);
            
            //define sql query

            //declare oracle command

            //execute query(data adapter)

        }

        private void btnRegisterStock_Click(object sender, EventArgs e)
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
            if (Convert.ToInt32(txtQty.Text) <= 0)
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
            if ((Convert.ToDouble(txtCost.Text)) <= 0)
            {
                MessageBox.Show("Cost entered is invalid", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDesc.Focus();
                return;
            }

            //--------VALIDATION END----------



            //save data in database (not doing for prototype)
            //instantiate the STOCK variables
            Stock myStock = new Stock(Convert.ToInt32(txtStockId.Text), txtDesc.Text,Convert.ToInt32(txtQty.Text), Convert.ToDouble(txtCost.Text),"A");

            //CALL THE RegisterStock() METHOD

            myStock.regStock();

            //User Confirmation
          //  MessageBox.Show("Are you sure you want to register this piece of stock?", "Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)== DialogResult.Yes){

           // }

      


            //display system confirmation message
                
            MessageBox.Show("Stock Registered", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information); //displaying a message box
            

            //reset UI
            txtStockId.Clear(); //clears stock it field
            txtStockId.Focus(); //cursor goes to stock id
            txtDesc.Clear();
            txtQty.Clear();
            txtCost.Clear();
            
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

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

    }
}
