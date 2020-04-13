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
    public partial class frmYearlyExpenditureReport : Form
    {
        frmMainMenu parent;
        public frmYearlyExpenditureReport()
        {
            InitializeComponent();
        }

        public frmYearlyExpenditureReport(frmMainMenu Parent)
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

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void frmYearlyExpenditureReport_Load(object sender, EventArgs e)
        {
            cboYear.Items.Add("2019");
            cboYear.Items.Add("2018");
            cboYear.Items.Add("2017");
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            pic2019.Visible = false;
            pic2018.Visible = false;
            pic2017.Visible = false;


            if (cboYear.SelectedIndex is 0)
            {
                pic2019.Visible = true;
                pic2018.Visible = false;
                pic2017.Visible = false;
            }

            if (cboYear.SelectedIndex is 1)
            {
                pic2019.Visible = false;
                pic2018.Visible = true;
                pic2017.Visible = false;
            }

            if (cboYear.SelectedIndex is 2)
            {
                pic2019.Visible = false;
                pic2018.Visible = false;
                pic2017.Visible = true;
            }

        }
    }
}
