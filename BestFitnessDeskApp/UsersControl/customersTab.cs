using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Web.Configuration;
using System.Windows.Forms;
using static Guna.UI2.Native.WinApi;
using static Guna.UI2.WinForms.Suite.Descriptions;

namespace BestFitnessDeskApp.UsersControl
{
    public partial class customersTab : UserControl
    {
        public customersTab()
        {
            InitializeComponent();





            customerTable.AutoGenerateColumns = false;
            customerTable.DataSource = uc.customerTable();
        }
        Classes.customersClass uc = new Classes.customersClass();
        private void customersTab_Load(object sender, EventArgs e)
        {

            customerTable.CurrentCell = null;



        }

        private void customersTab_Click(object sender, EventArgs e)
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

            customerTable.CurrentCell = null;
            successInput.Focus();
            foreach (DataGridViewRow row in customerTable.Rows)
            {
                row.Cells["selectBox"].Value = false;



            }

        }

        private void refreshData()
        {
            SqlConnection conn = new SqlConnection("Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from customerTable", conn);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds, "customerTable");
            customerTable.DataSource = ds.Tables[0];
        }


        private async void customerTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerTable.Rows.Count == 0)
            {
                return;
            }
            if (customerTable.Columns[e.ColumnIndex].Name == "deleteBtn")
            {
                if (MessageBox.Show("Are you sure you want to delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    try
                    {
                        bool r = uc.manageCustomers(
                            int.Parse(customerTable.SelectedRows[0].Cells["customerID"].Value.ToString()),
                            customerTable.SelectedRows[0].Cells["customerName"].Value.ToString(),

                            DateTime.Parse(customerTable.SelectedRows[0].Cells["DOB"].Value.ToString()),
                            customerTable.SelectedRows[0].Cells["Address"].Value.ToString(),

                            customerTable.SelectedRows[0].Cells["contactPhn"].Value.ToString(),
                            customerTable.SelectedRows[0].Cells["contactEmail"].Value.ToString(),
                            int.Parse(customerTable.SelectedRows[0].Cells["currentWeight"].Value.ToString()),
                            int.Parse(customerTable.SelectedRows[0].Cells["targetWeight"].Value.ToString()),
                            3


                            );
                        if (r)
                        {
                            refreshData();
                            successLabel.Text = "Deleted Successfully.";
                            customerTable.ClearSelection();
                            customerTable.CurrentCell = null;
                            successLabel.Visible = true;
                            await Task.Delay(5000);
                            successLabel.Visible = false;




                        }
                        else {
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
            if (customerTable.Columns[e.ColumnIndex].Name == "editBtn")
            {

                string customerID = customerTable.SelectedRows[0].Cells["customerID"].Value.ToString();
                string customerName = customerTable.SelectedRows[0].Cells["customerName"].Value.ToString();
                DateTime DOB = DateTime.Parse(customerTable.SelectedRows[0].Cells["DOB"].Value.ToString());
                string Address = customerTable.SelectedRows[0].Cells["Address"].Value.ToString();
                string contactPhn = customerTable.SelectedRows[0].Cells["contactPhn"].Value.ToString();
                string contactEmail = customerTable.SelectedRows[0].Cells["contactEmail"].Value.ToString();
                string currentWeight = customerTable.SelectedRows[0].Cells["currentWeight"].Value.ToString();
                string targetWeight = customerTable.SelectedRows[0].Cells["targetWeight"].Value.ToString();


                /*     CustomerEditForm editUC = new CustomerEditForm(customerID,customerName, contactEmail,contactPhn,Address,currentWeight,targetWeight,DOB);
                     editUC.Show();*/
                using (var newFrm = new CustomerEditForm(customerID, customerName, contactEmail, contactPhn, Address, currentWeight, targetWeight, DOB))
                {
                    newFrm.ShowDialog();  // execution of Form1 stops until Form2 is closed
                }
                refreshData();
                successLabel.Text = "Updated Successfully.";

                customerTable.ClearSelection();
                customerTable.CurrentCell = null;

                successLabel.Visible = true;
                await Task.Delay(5000);
                successLabel.Visible = false;

            }
        }



        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            searchBtn.Visible = false;
            searchLabel.Visible = false;
        }

        private void searchLabel_Click(object sender, EventArgs e)
        {
            searchInput.Focus();
            searchLabel.Hide();

        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            searchInput.Focus();
            searchBtn.Hide();
        }

        private void searchInput_Click(object sender, EventArgs e)
        {
            searchBtn.Visible = false;
            searchLabel.Visible = false;
        }

        private void successInput_Click(object sender, EventArgs e)
        {

        }
        SqlConnection conn = new SqlConnection("Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True");

        private async void searchInput_KeyPress(object sender, KeyPressEventArgs e)
        {

            try
            {
                customerTable.DataSource = uc.customerSearch(searchInput.Text);
            }
            catch (Exception )
            {

                errorLabel.Text = "Something went wrong.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {
            refreshData();
            customerTable.ClearSelection();
            customerTable.CurrentCell = null;
            searchInput.Clear();
            searchBtn.Visible = true;
            searchLabel.Visible = true;
            successInput.Focus();


        }

        private async void deleteAllButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete ? ", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in customerTable.Rows)
                {
                    if (Convert.ToBoolean(row.Cells["selectBox"].Value) == true)
                    {
                        int cstId = int.Parse(row.Cells["customerID"].Value.ToString());
                        uc.deleteAll(cstId);
                    }
                }

                refreshData();
                successLabel.Text = "Selected Infos Deleted Successfully.";

                customerTable.ClearSelection();
                customerTable.CurrentCell = null;
                errorLabel.Visible = false;
                successLabel.Visible = true;
                await Task.Delay(6000);
                successLabel.Visible = false;
            }
        }

        

        private void slctAllBtn_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in customerTable.Rows)
            {
                row.Cells["selectBox"].Value= true;
               


            }
        }
    }
    }

    



