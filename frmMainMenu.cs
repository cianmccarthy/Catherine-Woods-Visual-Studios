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

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegStock_Click(object sender, EventArgs e)
        {
            frmRegisterStock nextForm = new frmRegisterStock(this);
            this.Hide();

            nextForm.Show();
        }

        private void frmChgStock_Click(object sender, EventArgs e)
        {
            frmChangeStock nextForm = new frmChangeStock(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuRemStock_Click(object sender, EventArgs e)
        {
            frmRemoveStock nextForm = new frmRemoveStock(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuAddDept_Click(object sender, EventArgs e)
        {
            frmAddDepartment nextForm = new frmAddDepartment(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuUpdateDept_Click(object sender, EventArgs e)
        {
            frmUpdateDepartment nextForm = new frmUpdateDepartment(this);
            this.Hide();

            nextForm.Show();
        }
        private void mnuCloseDept_Click_1(object sender, EventArgs e)
        {
            frmCloseDepartment nextForm = new frmCloseDepartment(this);
            this.Hide();

            nextForm.Show();
        }


        private void mnuUpdateOrder_Click(object sender, EventArgs e)
        {
            frmUpdateOrder nextForm = new frmUpdateOrder(this);
            this.Hide();

            nextForm.Show();

       }

         private void mnuCancelOrder_Click(object sender, EventArgs e)
        {
            frmCancelOrder nextForm = new frmCancelOrder(this);
            this.Hide();

                nextForm.Show();
        }

        private void mnuGenDep_Click(object sender, EventArgs e)
        {
            frmGenerateDepartmentAnalysis nextForm = new frmGenerateDepartmentAnalysis(this);
            this.Hide();

            nextForm.Show();
        }

        private void mnuYrlyExp_Click(object sender, EventArgs e)
        {
            frmYearlyExpenditureReport nextForm = new frmYearlyExpenditureReport(this);
            this.Hide();

            nextForm.Show();
        }
    }
}
