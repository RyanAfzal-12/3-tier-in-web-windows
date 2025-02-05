using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppProps;

namespace DAL
{
    public class custDAL
    {
        dbcon dbcon = new dbcon();
        public bool CustInsertDAL(cust cust)
        {
            string queryInsert = "INSERT INTO Customer VALUES('" + cust.Customer_Name1 + "','" + cust.Cell_No1 + "','" + cust.Address1 + "')";
            return dbcon.ExecuteCommand(queryInsert);
        }

        public bool CustDeleteDAL(string Customer_Id)
        {

            string querydelete = " DELETE FROM Customer WHERE Customer_Id = '" + Customer_Id + "'";
            return dbcon.ExecuteCommand(querydelete);
        }
        public bool CustUpdateDAL(string Customer_Id, string Customer_Name1, string Cell_No1, string Address1)
        {

            string queryupdate = " UPDATE  Customer SET Name = '" + Customer_Name1 + "', Cell_No ='" + Cell_No1 + "',Address = '" + Address1 + "' WHERE Customer_Id = '" + Customer_Id + "'";
            return dbcon.ExecuteCommand(queryupdate);
        }

        public DataTable CustSearchDAL(string Customer_Id)
        {
            string queryselect = "SELECT * FROM Customer WHERE Customer_Id = '" + Customer_Id + "'";
            return dbcon.FetchData(queryselect);
        }
        public DataTable CustViewAllDAL(string Customer_Id, string Customer_Name1, string Cell_No1, string Address1)
        {
            string queryviewall = "SELECT * FROM Customer";
            return dbcon.FetchData(queryviewall);
        }
    }
}