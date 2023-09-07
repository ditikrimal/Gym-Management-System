using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Forms;

namespace BestFitnessDeskApp.UsersControl
{
    public partial class trainPlanTab : UserControl
    {
        public trainPlanTab()
        {
            InitializeComponent();
            tPlanTable.AutoGenerateColumns = false;
            tPlanTable.DataSource = uc.getTrainingPlanTable();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            tPlanInput.Clear();
            unitInput.Dispose();
            rateInput.Clear();
            remarksInput.Clear();
            tPlanTable.ClearSelection();
            tPlanTable.CurrentCell = null;

        }
        Classes.trainingPlanClass uc = new Classes.trainingPlanClass();
        private void refreshData()
        {
            SqlConnection conn = new SqlConnection("Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from trainingPlanTable", conn);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "tPlanTable");
            tPlanTable.DataSource = ds.Tables[0];
        }
        private async void createBtn_Click(object sender, EventArgs e)
        {

            if (tPlanInput.Text == "" || unitInput.Text == "" || rateInput.Text == "" || remarksInput.Text=="")
            {
                errorLabel.Text = "Forgot Something ?";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }

          

            try
            {
                bool r = uc.manageTrainingPlan(0, tPlanInput.Text, unitInput.Text, Double.Parse(rateInput.Text), remarksInput.Text, 1);
                if (r)
                {
                    successLabel.Text = "Plan Created Successfully.";
                    refreshData();
                    tPlanTable.CurrentCell = null;
                    tPlanInput.Clear();
                    unitInput.SelectedIndex=-1;
                    rateInput.Clear();
                    remarksInput.Clear();
                    successLabel.Visible = true;
                    await Task.Delay(5000);
                    successLabel.Visible = false;


                }
                else
                {
                    errorLabel.Text = "Something went wrong.";
                    errorLabel.Visible = true;
                    await Task.Delay(5000);
                    errorLabel.Visible = false;
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "Plan Name already exists.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = System.Windows.Forms.MessageBox.Show("Are you sure you want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    bool r = uc.manageTrainingPlan(planId, tPlanInput.Text, unitInput.Text, Double.Parse(rateInput.Text), remarksInput.Text, 3);
                    if (r)
                    {
                        successLabel.Text = "Plan Deleted Successfully.";
                        refreshData();
                        tPlanTable.CurrentCell = null;
                        tPlanInput.Clear();
                        unitInput.SelectedIndex = -1;
                        rateInput.Clear();
                        remarksInput.Clear();
                        successLabel.Visible = true;
                        await Task.Delay(5000);
                        successLabel.Visible = false;

                    }
                    else
                    {
                        errorLabel.Text = "Something went wrong.";
                        errorLabel.Visible = true;
                        await Task.Delay(5000);
                        errorLabel.Visible = false;
                    }
                }
                catch (Exception ex)
                {
                    errorLabel.Text = "No data is selected.";
                    errorLabel.Visible = true;
                    await Task.Delay(5000);
                    errorLabel.Visible = false; ;
                }
            }
        }
        private int planId;
        private void tPlanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {


            if (tPlanTable.Rows.Count == 0)
            {
                return;
            }
            planId = int.Parse(tPlanTable.SelectedRows[0].Cells["planID"].Value.ToString());

            tPlanInput.Text = tPlanTable.SelectedRows[0].Cells["planName"].Value.ToString();
            unitInput.Text = tPlanTable.SelectedRows[0].Cells["unit"].Value.ToString();
            rateInput.Text = tPlanTable.SelectedRows[0].Cells["rate"].Value.ToString();
            remarksInput.Text = tPlanTable.SelectedRows[0].Cells["Remarks"].Value.ToString();

        }

        private void trainPlanTab_Load(object sender, EventArgs e)
        {
            tPlanTable.ClearSelection();
            tPlanTable.CurrentCell = null;
        }

        private void trainPlanTab_Click(object sender, EventArgs e)
        {
            tPlanTable.CurrentCell = null;
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {

            if (tPlanInput.Text == "" || unitInput.Text == "" || rateInput.Text == "" || remarksInput.Text == "")
            {
                errorLabel.Text = "Forgot Something ?";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }



            try
            {
                bool r = uc.manageTrainingPlan(planId, tPlanInput.Text, unitInput.Text, Double.Parse(rateInput.Text), remarksInput.Text, 2);
                if (r)
                {
                    successLabel.Text = "Plan Updated Successfully.";
                    refreshData();
                    tPlanTable.CurrentCell = null;
                    tPlanInput.Clear();
                    unitInput.SelectedIndex = -1;
                    rateInput.Clear();
                    remarksInput.Clear();
                    successLabel.Visible = true;
                    await Task.Delay(5000);
                    successLabel.Visible = false;


                }
                else
                {
                    errorLabel.Text = "Something went wrong12.";
                    errorLabel.Visible = true;
                    await Task.Delay(5000);
                    errorLabel.Visible = false;
                }
            }
            catch (Exception)
            {
                errorLabel.Text = "Something went wrong.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }

        private void tPlanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
