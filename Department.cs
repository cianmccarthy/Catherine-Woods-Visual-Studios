using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.ManagedDataAccess.Client;

namespace StockSYS
{
    class Department
    {
        int deptId;
        String requestor;
        String deptName;
        String location;


        public Department()
        {
            deptId = 0;
            requestor = "";
            deptName = "";
            location = "";
        }

        //getters
        public String getLocation()
        {
            return location;
        }

        public String getRequestor()
        {
            return requestor;
        }

        public static DataSet getDepts()
        {
            DataSet ds = new DataSet();

            //define SQL Query
            String strSQL = "SELECT * FROM Departments ORDER BY Dept_Name";


            //declare oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //get oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            da.Fill(ds, "DP");

            //close database connection
            conn.Close();


            return ds;
        }

        public void getDepartment(int DeptId)
        {

            //define SQL Query
            String strSQL = "SELECT * FROM Departments WHERE Dept_Id = " + DeptId;

            //declare oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //get oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //declare an oracle DataAdapter
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            //instantiate object variables
            deptId = dr.GetInt32(0);
            requestor = dr.GetString(1);
            deptName = dr.GetString(2);
            location = dr.GetString(3);

            //close database connection
            conn.Close();

        }
    }
}
