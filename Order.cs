using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;


namespace StockSYS
{
    class Order
    {
        private int oid;
        private int did;
        private int sid;
        private int quantity;
        private String status;


        //DON'T FORGET THE ORDER DATE + ORDER VALUE!!
        public Order()
        {
            oid = 0;
            did = 0;
            sid = 0;
            quantity = 0;
            status = "";
        }

        public Order(int Oid, int Did, int Sid, int Quantity, String Status)
        {
            oid = Oid;
            did = Did;
            sid = Sid;
            quantity = Quantity;
            status = Status;
        }

        //-------------GETTERS-----------------

        public int getOid()
        {
            return oid;
        }

        public int getDid()
        {
            return did;
        }

        public int getSid()
        {
            return sid;
        }

        public int getQuantity()
        {
            return quantity;
        }

        //GET ORDER DATE!
        //GET ORDER VALUE!

        public String getStatus()
        {
            return status;
        }

        //----------------SETTERS-----------------

        public void setOid(int OID)
        {
            oid = OID;
        }

        public void setDid(int DID)
        {
            did = DID;
        }

        public void setSid(int SID)
        {
            sid = SID;
        }

        public void setQuantity(int Quantity)
        {
            quantity = Quantity;
        }

        //SET ORDER DATE!
        //SET ORDER VALUE!

        public void setStatus(String Status)
        {
            status = Status;
        }

        //-------------------GETTING NEXT ORDER ID------------------
        public static int getOrderId()
        {
            int Oid = 0;

            //Define Oracle Connection

            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define SQL query
            String strSQL = "SELECT MAX(Order_Id) FROM Orders";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //executing query
            OracleDataReader dr = cmd.ExecuteReader();

            dr.Read();
            if (dr.IsDBNull(0))
            {
                Oid = 1;
            }
            else
                Oid = dr.GetInt32(0) + 1;

            conn.Close();

            return Oid;


        }

        //--------------PLACING AN ORDER AND STORING INTO THE DATABASE-------------------

       // public void placeOrder()
      //  {
            //define SQL Query

        //    String strSQL = "INSERT INTO Orders VALUES (" + this.oid + "," + this.did + "," + this.sid + "," +
         //       this.quantity + //THE ORDER DATE AND ORDER VALUE! ",'" + this.status + "')";

            //declare oracle connection
        //    OracleConnection conn = new OracleConnection(DBConnect.oradb);
        //    conn.Open();

            //get oracle command to execute
        //    OracleCommand cmd = new OracleCommand(strSQL, conn);

        //    cmd.ExecuteNonQuery();

       //     conn.Close();

      //  }





    }
}
