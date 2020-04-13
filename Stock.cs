using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace StockSYS
{
    class Stock
    {
        private int id;
        private String description;
        private int quantity;
        private double cost;
        private String status;

        //-------CONSTRUCTOR----------
        public Stock()
        {
            id = 0;
            description = "";
            quantity = 0;
            cost = 0.00;
            status = "";


        }

        public Stock(int Id, String Description, int Quantity, double Cost, String Status)
        {
            id = Id;
            description = Description;
            quantity = Quantity;
            cost = Cost;
            status = Status;

        }
        //-----------------GETTERS---------------------

        public int getId()
        {
           return id;
        }

        public String getDescription()
        {
          return description;
        }

        public int getQuantity()
        {
           return quantity;
        }

         public double getCost()
        {
           return cost;
         }

         public String getStatus()
        {
          return status;
        }

        //----------SETTERS------------------

        public void setId(int ID)
        {
         id = ID;
        }

        public void setDescription(String Description)
        {
          description = Description;
        }

        public void setQuantity(int Quantity)
        {
          quantity = Quantity;
        }

        public void setCost(double Cost){
         cost = Cost;
        }

        public void setStatus(String Status)
        {
          status = Status;
        }


        public static int getStockId()
        {
            int Sid = 0;

            //Define Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT MAX(Stock_Id) FROM Stock";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //executing query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
            {
                Sid = 1;
            }
            else
                Sid = dr.GetInt32(0) + 1;

            conn.Close();

            return Sid;

            
        }

        //-------------INSERT into Stock METHOD---------------
        public void regStock()
        {
            //define SQL Query
 
            String strSQL = "INSERT INTO Stock VALUES (" + this.id + ",'" + this.description + "'," + this.quantity + "," + 
                this.cost + ",'" + this.status + "')";

            //declare oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //get oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }

        //-------------DISPLAY + UPDATE Stock METHODS ----------------

        public static DataSet getStock()
        {
            //define SQL Query
            String strSQL = "SELECT Stock_Id, Description FROM Stock WHERE Status = 'A' ORDER BY Description";
          

            //declare oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //get oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //declare DataSet to return records to 
            DataSet ds = new DataSet();

            da.Fill(ds, "ST");

            //close database connection
            conn.Close();

            return ds;
        }


        public static DataSet getAllStock()
        {
            //define SQL Query
            String strSQL = "SELECT * FROM Stock WHERE Status = 'A' ORDER BY Description";


            //declare oracle connection
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //get oracle command to execute
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //declare an oracle DataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);

            //declare DataSet to return records to 
            DataSet ds = new DataSet();

            da.Fill(ds, "ST");

            //close database connection
            conn.Close();

            return ds;
        }

        public void getAnItem(int ID)
        {
            //Define Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT * FROM Stock WHERE Stock_Id = " + ID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //executing query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();

            //instantiate object variables

            this.id = dr.GetInt32(0);
            this.description = dr.GetString(1);
            this.quantity = dr.GetInt32(2);
            this.cost = dr.GetDouble(3);
            this.status = dr.GetString(4);

            conn.Close();

        }

        public void updateStock()
        {
                //Define Oracle Connection

                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                conn.Open();

                //define SQL query
                String strSQL = "UPDATE Stock SET Description = '" + this.description + " ', Quantity_In_Stock =" + this.quantity + ", Cost_Per_Supply = " + this.cost + " WHERE Stock_Id = " + this.id;

                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //executing query
                cmd.ExecuteNonQuery();

                conn.Close();
           
        }


    }
}
