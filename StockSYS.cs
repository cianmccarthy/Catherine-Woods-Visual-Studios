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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void mnuRegisterStock_Click(object sender, EventArgs e)
        {
            //hide main menu
            this.Hide();

            //display frmRegisterStock
            frmRegisterStock nextForm = new frmRegisterStock(this);
            nextForm.Show();

        }

        private void mnuChgStock_Click(object sender, EventArgs e)
        {
            //hide main menu
            this.Hide();

            //display frmChangeStock
            frmChangeStock nextForm = new frmChangeStock(this);
            nextForm.Show();
        }

        private void mnuRemoveStock_Click(object sender, EventArgs e)
        {
            //hide main menu
            this.Hide();

            //display frmChangeStock
            frmRemoveStock nextForm = new frmRemoveStock(this);
            nextForm.Show();
        }

        private void mnuAddDept_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmAddDepartment frmNextForm = new frmAddDepartment(this);
            frmNextForm.Show();
        }

        private void mnuUpdateDept_Click(object sender, EventArgs e)
        {
            this.Hide();

            frmUpdateDepartment nextForm = new frmUpdateDepartment(this);
            nextForm.Show();
        }

        private void mnuCloseDept_Click_1(object sender, EventArgs e)
        {
            this.Hide();

            frmCloseDepartment frmNextForm = new frmCloseDepartment(this);
            frmNextForm.Show();
        }

        private void mnuAddDept_Click_1(object sender, EventArgs e)
        {

        }
    }
}
