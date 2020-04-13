using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace StockSYS
{
    public partial class frmConnect : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);

        public frmConnect()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //open the database connection
            conn.Open();
            lblMessage.ForeColor = System.Drawing.Color.Red;
            lblMessage.Text = "Database Connection Open - Get Your Data";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            //close the database connection
            conn.Close();
            lblMessage.ForeColor = System.Drawing.Color.Blue;
            lblMessage.Text = "Database Connection closed";
        }
    }
}
