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
    public partial class frmGenerateDepartmentAnalysis : Form
    {
        frmMainMenu parent;

        public frmGenerateDepartmentAnalysis()
        {
            InitializeComponent();
        }

        public frmGenerateDepartmentAnalysis(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            //close this form
            this.Close();

            //make main menu visible
            Parent.Visible = true;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblMessage_Click(object sender, EventArgs e)
        {

        }

        private void frmGenerateDepartmentAnalysis_Load(object sender, EventArgs e)
        {
            cboDepartments.Items.Add("Medical Records");
            cboDepartments.Items.Add("Laboratory");
            cboDepartments.Items.Add("Clinics");
      
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            picMedRec19.Visible = false;
            picLab.Visible = false;
            picClinics.Visible = false;

            if (cboDepartments.SelectedIndex is 0)
            {
                picMedRec19.Visible = true;
                picLab.Visible = false;
                picClinics.Visible = false;
            }

            if (cboDepartments.SelectedIndex is 1)
            {
                picMedRec19.Visible = false;
                picLab.Visible = true;
                picClinics.Visible = false;
            }

            if (cboDepartments.SelectedIndex is 2)
            {
                picMedRec19.Visible = false;
                picLab.Visible = false;
                picClinics.Visible = true;
            }



        }
    }
}
