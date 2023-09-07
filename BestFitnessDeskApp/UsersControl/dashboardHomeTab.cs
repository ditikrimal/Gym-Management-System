using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestFitnessDeskApp.UsersControl
{
    public partial class dashboardHomeTab : UserControl
    {
        public dashboardHomeTab()
        {
            InitializeComponent();

            CstmrPlanTable.AutoGenerateColumns = false;
            CstmrPlanTable.DataSource = cuc.customerTable();
            CstmrPlanTable.CurrentCell = null; 
            cstrPlanTable.AutoGenerateColumns = false;
            cstrPlanTable.DataSource = uc.allTrainingPlans();
            cstrPlanTable.DataSource = null;


        }
        Classes.customerTrainingPlanClass uc = new Classes.customerTrainingPlanClass();
        Classes.customersClass cuc = new Classes.customersClass();
        Classes.trainingPlanClass tuc = new Classes.trainingPlanClass();
        private void dashboardHomeTab_Load(object sender, EventArgs e)
        {

            CstmrPlanTable.CurrentCell = null;
            cstrPlanTable.CurrentCell = null;
        
            
            
        }

        private void CstmrPlanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerID = CstmrPlanTable.SelectedRows[0].Cells["cstrID"].Value.ToString();
            string customerName = CstmrPlanTable.SelectedRows[0].Cells["cstmrName"].Value.ToString();
            string cWeight = CstmrPlanTable.SelectedRows[0].Cells["cWeight"].Value.ToString();
            string tWeight = CstmrPlanTable.SelectedRows[0].Cells["tWeight"].Value.ToString();

         
            customerIDLabel.Text = customerID;

            cstrPlanTable.DataSource = uc.getTrainingPlanByCustomersID(int.Parse(customerIDLabel.Text));
            cstrPlanTable.CurrentCell = null;
        }

        private void dashboardHomeTab_Click(object sender, EventArgs e)
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
        
            cstrPlanTable.CurrentCell = null;
          
            cstrPlanTable.DataSource = null;
        }



        private void CstmrPlanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string customerID = CstmrPlanTable.SelectedRows[0].Cells["cstrID"].Value.ToString();
            string customerName = CstmrPlanTable.SelectedRows[0].Cells["cstmrName"].Value.ToString();
            string cWeight = CstmrPlanTable.SelectedRows[0].Cells["cWeight"].Value.ToString();
            string tWeight = CstmrPlanTable.SelectedRows[0].Cells["tWeight"].Value.ToString();


            customerIDLabel.Text = customerID;

            cstrPlanTable.DataSource = uc.getTrainingPlanByCustomersID(int.Parse(customerIDLabel.Text));
            cstrPlanTable.CurrentCell = null;
        }

        private void refreshData()
        {
            SqlConnection conn = new SqlConnection("Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from customerTable", conn);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "customerTable");

            CstmrPlanTable.DataSource = ds.Tables[0];
        }


        private void searchInput_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Visible = false;
            searchLabel.Visible = false;
            cstrPlanTable.DataSource= null;
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
          
            cstrPlanTable.AutoGenerateColumns = false;
            cstrPlanTable.DataSource = uc.allTrainingPlans();
            cstrPlanTable.DataSource = null;
        }

        private void searchInput_Click(object sender, EventArgs e)
        {
            searchBtn.Visible = false;
            searchLabel.Visible = false;
        }
    }
}

