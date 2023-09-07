using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BestFitnessDeskApp.Classes
{
    public class customersClass
    {
        SqlConnection conn = new SqlConnection(dbConnection.connectionString);
        public bool manageCustomers(int customerID, String customerName, DateTime DOB, String Address, String contactPhn, String contactEmail, int currentWeight, int targetWeight, int Mode)
        {
            bool result = false;
            try
            {
                String txtSql = "";
                if (Mode == 1)
                {
                    txtSql = @"insert into customerTable(customerName,DOB,Address,contactPhn,contactEmail,currentWeight,targetWeight) values(@customerName,@DOB,@Address,@contactPhn,@contactEmail,@currentWeight,@targetWeight)";

                }
                if (Mode == 2)
                {

                    txtSql = @"update customerTable set customerName=@customerName,DOB=@DOB,Address=@Address,contactPhn=@contactPhn,contactEmail=@contactEmail,currentWeight=@currentWeight,targetWeight=@targetWeight where customerID=@customerID";
                }
                if (Mode == 3)
                {

                    txtSql = @"Delete from customerTable where customerID=@customerID";
                }
                SqlCommand cmd = new SqlCommand(txtSql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@customerName", customerName);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@contactPhn", contactPhn);
                cmd.Parameters.AddWithValue("@contactEmail", contactEmail);
                cmd.Parameters.AddWithValue("@currentWeight", currentWeight);
                cmd.Parameters.AddWithValue("@targetWeight", targetWeight);

                conn.Open();
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                {
                    result = true;
                }
                else { result = false; }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
            return result;
        }
        public bool deleteAll(int customerID) {

            bool result = false;
            try
            {
                String txtSql = "";
               

                    txtSql = @"Delete from customerTable where customerID=@customerID";

                SqlCommand cmd = new SqlCommand(txtSql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@customerID", customerID);




                conn.Open();
                int r = cmd.ExecuteNonQuery();
                conn.Close();
                if (r > 0)
                {
                    result = true;
                }
                else { result = false; }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
            return result;
        }
        public DataTable customerTable()
        {
            DataTable dt = new DataTable();
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from customerTable", conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
            return dt;
        }
        public DataTable customerSearch(string customerName)
        {
            DataTable dt = new DataTable();
            try {

                SqlCommand cmd = new SqlCommand("Select * from customerTable where customerName like '%'+ @customerName+ '%';", conn);
                cmd.Parameters.AddWithValue("@customerName", customerName);

                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();

            } catch (Exception ex) {

                throw ex;
            }
            finally { conn.Close(); }
            return dt;
        }

    }
}



