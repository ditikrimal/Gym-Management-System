using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace BestFitnessDeskApp.UsersControl
{
    public partial class UsersTab : UserControl

    {

    
        public UsersTab()
        {
            
            
            InitializeComponent();
            
            usersTable.AutoGenerateColumns = false;
            usersTable.DataSource = uc.userList();
           
        }
      

        private void UsersTab_Load(object sender, EventArgs e)
        {
            usersTable.ClearSelection();
            usersTable.CurrentCell = null;
       
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }
        private void refreshData() {
            SqlConnection conn = new SqlConnection("Data Source=ELPROFESOR\\SQLEXPRESS;Initial Catalog=BestFitness;Integrated Security=True");
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter("select * from userTable",conn);
            DataSet ds = new System.Data.DataSet();
            da.Fill(ds,"userTable");
            usersTable.DataSource = ds.Tables[0];
        }
       
        private void clearBtn_Click(object sender, EventArgs e)
        {
            userNameInput.Clear();
            passwordInput.Clear();
            cPasswordInput.Clear();
            
        }
        Classes.usersClass uc = new Classes.usersClass();
        private async void createBtn_Click(object sender, EventArgs e)
        {
            

            if (userNameInput.Text == "" || passwordInput.Text == "" || cPasswordInput.Text == "")
            {
                errorLabel.Text = "Forgot Something ?";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }
           
            if (passwordInput.Text != cPasswordInput.Text)
            {
                errorLabel.Text = "Passwords didn't Match";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }
           
            try
            {
                bool r = uc.manageUsers(0, userNameInput.Text, passwordInput.Text, 1);
                if (r)
                {
                    successLabel.Text = "User Created Successfully.";
                    refreshData();
                    usersTable.CurrentCell = null;
                    userNameInput.Clear();
                    passwordInput.Clear();
                    cPasswordInput.Clear();
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
                errorLabel.Text ="Username already exists.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }

        private async void deleteBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Are you sure you want to delete ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {


                try
                {
                    bool r = uc.manageUsers(userId, userNameInput.Text, passwordInput.Text, 3);
                    if (r)
                    {
                        successLabel.Text = "User Deleted Successfully.";
                        refreshData();
                        usersTable.CurrentCell = null;
                        userNameInput.Clear();
                        passwordInput.Clear();
                        cPasswordInput.Clear();

                        usersTable.Refresh();
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

        private void usersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void usersTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             /*   userID = int.Parse(UsersTab.SelectedRows[0].Cells["userID"].Value.ToString());*/
            
        }

      

     

        private void usersTable_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void UsersTab_Click(object sender, EventArgs e)
        {
            usersTable.CurrentCell = null;
        }
        private int userId;
        
        private void usersTable_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (usersTable.Rows.Count == 0)
            {
                return;
            }
            userId = int.Parse(usersTable.SelectedRows[0].Cells["userID"].Value.ToString());
            userNameInput.Text = usersTable.SelectedRows[0].Cells["userName"].Value.ToString();
            passwordInput.Text = usersTable.SelectedRows[0].Cells["password"].Value.ToString();
            cPasswordInput.Text = usersTable.SelectedRows[0].Cells["password"].Value.ToString();
           
        }

        private async void editBtn_Click(object sender, EventArgs e)
        {
            if (userNameInput.Text == "" || passwordInput.Text == "" || cPasswordInput.Text == "")
            {
                errorLabel.Text = "Forgot Something ?";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }
            if (passwordInput.Text.Length < 8)
            {
                errorLabel.Text = "Minimum password legth is 8";
                errorLabel.Left = 670;
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }
            if (passwordInput.Text != cPasswordInput.Text)
            {
                errorLabel.Text = "Passwords didn't Match";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }

            try
            {
                bool r = uc.manageUsers(userId, userNameInput.Text, passwordInput.Text, 2);
                if (r)
                {
                    successLabel.Text = "User Updated Successfully.";
                    refreshData();
                    usersTable.CurrentCell = null;
                    userNameInput.Clear();
                    passwordInput.Clear();
                    cPasswordInput.Clear();


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

                MessageBox.Show(ex.Message);
            }
        }

        private void userNameInput_TextChanged(object sender, EventArgs e)
        {

        }
      
        

        private void userNameInput_AcceptsTabChanged(object sender, EventArgs e)
        {

        }
    }
}
