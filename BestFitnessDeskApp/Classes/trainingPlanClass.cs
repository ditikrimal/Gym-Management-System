using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BestFitnessDeskApp.Classes
{
    public class trainingPlanClass
    {
        SqlConnection conn = new SqlConnection(dbConnection.connectionString);
        public bool manageTrainingPlan(int planID,String planName,String unit,Double rate, String remarks,int Mode) {

            bool result = false;
            try
            {
                String txtSql = "";
                if (Mode == 1)
                {
                    txtSql = @"insert into trainingPlanTable(planName,unit,rate,remarks) values(@planName,@unit,@rate,@remarks)";

                }
                if (Mode == 2)
                {

                    txtSql = @"update trainingPlanTable set planName=@planName,unit=@unit,rate=@rate,remarks=@remarks where planID=@planID";
                }
                if (Mode == 3)
                {

                    txtSql = @"Delete from trainingPlanTable where planID=@planID";
                }
                SqlCommand cmd = new SqlCommand(txtSql, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@planID", planID);
                cmd.Parameters.AddWithValue("@planName", planName);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@rate", rate);
                cmd.Parameters.AddWithValue("@remarks", remarks);
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
        public DataTable getTrainingPlanTable()
        {
         
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("Select * from trainingPlanTable", conn);
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
    }
}
