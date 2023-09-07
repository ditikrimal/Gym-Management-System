using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFitnessDeskApp.UsersControl
{
    public partial class cstmTrainPlanTab : UserControl
    {
        public cstmTrainPlanTab() {
            InitializeComponent();

            planInput.DataSource= tuc.getTrainingPlanTable();
            planInput.DisplayMember = "planName";
            planInput.ValueMember = "planID";
            planInput.SelectedIndex = -1;
            CstmrPlanTable.AutoGenerateColumns = false;
            CstmrPlanTable.DataSource = cuc.customerTable();
            cstrPlanTable.AutoGenerateColumns = false;
          

        }

        Classes.customerTrainingPlanClass uc = new Classes.customerTrainingPlanClass();
        Classes.customersClass cuc = new Classes.customersClass();
        Classes.trainingPlanClass tuc = new Classes.trainingPlanClass();


        private void refreshData()
        {
            SqlConnection conn = new SqlConnection("Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from customerTable", conn);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "customerTable");
           
            CstmrPlanTable.DataSource = ds.Tables[0];
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void cstmTrainPlanTab_Load(object sender, EventArgs e)
        {

            CstmrPlanTable.CurrentCell = null;

            cstrPlanTable.CurrentCell = null;

        }

        private void CstmrPlanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void cstmTrainPlanTab_Click(object sender, EventArgs e)
        {
            if (searchInput.Text == "")
            {
                searchLabel.Visible = true;
                searchBtn.Visible = true;

            }
            else
            {

                searchLabel.Visible = false;
                searchBtn.Visible = false;
            }

            CstmrPlanTable.CurrentCell = null;
            successInput.Focus();
           
            nameInput.Visible = false;
            WeightInput.Visible = false;
            tWeightInput.Visible = false;
            cstrPlanTable.CurrentCell=null;
            planInput.SelectedIndex = -1;
            hrsWeekInput.Clear();
            remarksInput.Clear();
            cstrPlanTable.DataSource= null;
        }

        private void cWeightLabel_Click(object sender, EventArgs e)
        {

        }

        private void selectCstLabel_Click(object sender, EventArgs e)
        {

        }

        private void CstmrPlanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            string customerID = CstmrPlanTable.SelectedRows[0].Cells["cstrID"].Value.ToString();
            string customerName = CstmrPlanTable.SelectedRows[0].Cells["cstmrName"].Value.ToString();
            string cWeight = CstmrPlanTable.SelectedRows[0].Cells["cWeight"].Value.ToString();
            string tWeight = CstmrPlanTable.SelectedRows[0].Cells["tWeight"].Value.ToString();
            
            nameInput.Visible = true;
            WeightInput.Visible = true;
            tWeightInput.Visible = true;

            nameInput.Text =  customerName;
            WeightInput.Text =  cWeight;
            tWeightInput.Text = tWeight;
            customerIDLabel.Text = customerID;

            cstrPlanTable.DataSource = uc.getTrainingPlanByCustomersID(int.Parse(customerIDLabel.Text));
            cstrPlanTable.CurrentCell = null;


        }

        private void tWeightInput_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Visible = false;
            searchLabel.Visible = false;
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchInput.Focus();
            searchLabel.Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchInput.Focus();
            searchBtn.Hide();
        }

        private void searchInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                CstmrPlanTable.DataSource = cuc.customerSearch(searchInput.Text);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void clearSearchBtn_Click(object sender, EventArgs e)
        {
            refreshData();
            CstmrPlanTable.ClearSelection();
            CstmrPlanTable.CurrentCell = null;
            searchInput.Clear();
            searchBtn.Visible = true;
            searchLabel.Visible = true;
            successInput.Focus();
            nameInput.Visible = false;
            WeightInput.Visible = false;
            tWeightInput.Visible = false;
            cstrPlanTable.AutoGenerateColumns = false;
            cstrPlanTable.DataSource = null;
            cstrPlanTable.CurrentCell = null;
        }

        private void searchInput_Click(object sender, EventArgs e)
        {
            searchBtn.Visible = false;
            searchLabel.Visible = false;
        }
        int id = 0;
        private async void addPlanBtn_Click(object sender, EventArgs e)
        {
            
            try
            {
                bool rs = uc.manageCustomerTrainingPlan(id,
                    int.Parse(customerIDLabel.Text), 
                    int.Parse(planInput.SelectedValue.ToString()),
                    remarksInput.Text,int.Parse(hrsWeekInput.Text),1);
            if (rs)
                {
                    cstrPlanTable.DataSource = uc.getTrainingPlanByCustomersID(int.Parse(customerIDLabel.Text));
                    successLabel.Text = "Plan Assigned Successfully.";

                    planInput.SelectedIndex=-1;
                    hrsWeekInput.Clear();
                    remarksInput.Clear();


                    successLabel.Visible = true;
                    await Task.Delay(5000);
                    successLabel.Visible = false;
                }
                else{

                    errorLabel.Text = "Something went wrong.";
                    errorLabel.Visible = true;
                    await Task.Delay(5000);
                    errorLabel.Visible = false;
                }
            
            }
            catch (Exception ){
                errorLabel.Text = "Something went wrong.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            if (customerIDLabel.Text != "")
            {
                try
                {
                    bool rs = uc.deleteCstmrPlan(int.Parse(cstrPlanTable.SelectedRows[0].Cells["cstrPlanID"].Value.ToString()));

                    if (rs)
                    {

                        cstrPlanTable.DataSource = uc.allTrainingPlans();
                        cstrPlanTable.CurrentCell = null;
                        planInput.SelectedIndex=-1;
                        hrsWeekInput.Clear();
                        remarksInput.Clear();

                    }

                }
                catch(Exception)
                {
                    errorLabel.Text = "Something went wrong.";
                    errorLabel.Visible = true;
                    await Task.Delay(5000);
                    errorLabel.Visible = false;
                }
            }
            else
            {
                try
                {
                    bool rs = uc.deleteCstmrPlan(int.Parse(cstrPlanTable.SelectedRows[0].Cells["cstrPlanID"].Value.ToString()));

                    if (rs)
                    {

                        cstrPlanTable.DataSource = uc.getTrainingPlanByCustomersID(int.Parse(customerIDLabel.Text));
                        cstrPlanTable.CurrentCell = null;

                    }else {
                        errorLabel.Text = "Something went wrong.";
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
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {


            try
            {
                bool rs = uc.manageCustomerTrainingPlan(int.Parse(cstrPlanTable.SelectedRows[0].Cells["ID"].Value.ToString()),
                    int.Parse(customerIDLabel.Text),
                    int.Parse(planInput.SelectedValue.ToString()),
                    remarksInput.Text, int.Parse(hrsWeekInput.Text)/100, 2);
                if (rs)
                {
                    cstrPlanTable.DataSource = uc.getTrainingPlanByCustomersID(int.Parse(customerIDLabel.Text));
                    successLabel.Text = "Customer Plan Updated Successfully.";

                    planInput.SelectedIndex = -1;
                    hrsWeekInput.Clear();
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
                errorLabel.Text = "Something went wrong.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }

        private void cstrPlanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            planInput.SelectedIndex = -1;
            hrsWeekInput.Clear();
            remarksInput.Clear();
        }

        private void cstrPlanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            planInput.Text = cstrPlanTable.SelectedRows[0].Cells["planName"].Value.ToString();
            hrsWeekInput.Text = Regex.Replace(cstrPlanTable.SelectedRows[0].Cells["rate_unit"].Value.ToString().Split()[0], @"[^0-9a-zA-Z\ ]+", "");
            remarksInput.Text = cstrPlanTable.SelectedRows[0].Cells["remarks"].Value.ToString();
        }

        private void successInput_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
