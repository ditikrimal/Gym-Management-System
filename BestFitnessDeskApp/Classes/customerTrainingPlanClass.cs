using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BestFitnessDeskApp.Classes
{
    public class customerTrainingPlanClass
    {
        SqlConnection conn = new SqlConnection(dbConnection.connectionString);
        public bool manageCustomerTrainingPlan(
        int ID,
       int customerID,
       int planID,
       string remarks,
       int Units,
       int Mode
       )
        {
            bool result = false;
            try
            {
                String txtSql = "";
                if (Mode == 1)
                {
                    txtSql = @"insert into customerTrainingPlanTable(customerID,planID,remarks,Units) values(@customerID,@planID,@remarks,@Units)";

                }
                if (Mode == 2)
                {

                    txtSql = @"update customerTrainingPlanTable set customerID=@customerID,planID=@planID,remarks=@remarks,Units=@Units where ID=@ID";
                }
                if (Mode == 3)
                {

                    txtSql = @"Delete from customerTrainingPlanTable where ID=@ID";
                }
                SqlCommand cmd = new SqlCommand(txtSql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@customerID", customerID);
                cmd.Parameters.AddWithValue("@planID", planID);
                cmd.Parameters.AddWithValue("@remarks", remarks);
                cmd.Parameters.AddWithValue("@Units", Units);


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
        public bool deleteCstmrPlan(int ID) {
            bool result = false;
            try
            {
                String txtSql = "";
            

                    txtSql = @"Delete from customerTrainingPlanTable where ID=@ID";
                
                SqlCommand cmd = new SqlCommand(txtSql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@ID", ID);

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
        public DataTable cstmrPlanTable()
        {
            try
            {

                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select  from customerTrainingPlanTable",conn);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally { conn.Close(); }
        }
        public DataTable allTrainingPlans() {
            try {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"SELECT ID, customerName, planName,CONCAT(ct.Units, ' ', t.unit) AS rate_unit, t.rate,  ct.remarks,   totalAmount=ct.Units*rate    
                        FROM dbo.customerTrainingPlanTable ct, dbo.trainingPlanTable t, dbo.customerTable c  
                        WHERE ct.planID = t.planID and ct.customerID=c.customerID"

                    /*@"SELECT ID,
                    customerName,planName,rate,t.unit,ct.remarks,totalAmount=ct.Units*rate 
                    FROM dbo.customerTrainingPlanTable ct,dbo.trainingPlanTable t,dbo.customerTable c
                    WHERE ct.planID=t.planID and ct.customerID=c.customerID"*/, conn);
                cmd.CommandType = CommandType.Text;
                conn.Open();
          

                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally { conn.Close(); }
        
        }
        public DataTable getTrainingPlanByCustomersID(int customerID) {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(@"SELECT ID, customerName, planName,CONCAT(ct.Units, ' ', t.unit) AS rate_unit, t.rate,  ct.remarks,    totalAmount=ct.Units*rate    
                            FROM dbo.customerTrainingPlanTable ct, dbo.trainingPlanTable t, dbo.customerTable c  
                             WHERE ct.planID = t.planID and ct.customerID=c.customerID and c.customerID =    @customerID"


                    /*@"SELECT ID,
                    customerName,planName,ct.Units,t.rate,t.unit,ct.remarks,totalAmount=ct.Units*rate 
                    FROM dbo.customerTrainingPlanTable ct,dbo.trainingPlanTable t,dbo.customerTable c
                    WHERE ct.planID=t.planID and ct.customerID=c.customerID and c.customerID=@customerID"*/, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@customerID", customerID);
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                dt.Load(dr);
                conn.Close();
                return dt;
            }
            catch (Exception ex){ 
            throw ex;
            }
            finally { conn.Close(); }
        }


    }
}



