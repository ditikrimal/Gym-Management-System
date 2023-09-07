using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BestFitnessDeskApp.UsersControl;

namespace BestFitnessDeskApp
{
    public partial class CustomerEditForm : Form
    {
       
        public CustomerEditForm(string customerID,string name,string email,string phone,string address,string cWeight,string tWeight,DateTime DOB)
        {
            
            InitializeComponent();
            customerIDInput.Text = customerID;
            nameInput.Text = name;
            emailInput.Text = email;
            phoneInput.Text = phone;
            addressInput.Text = address;
            cWeightInput.Text = cWeight;
            tWeightInput.Text = tWeight;
            dobInput.Value= DOB;
            

        }
     
        
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void tPlanTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        private void CustomerEditForm_Load(object sender, EventArgs e)
        {

        }

        private void successLabel_Click(object sender, EventArgs e)
        {

        }

        private void nameInput_TextChanged(object sender, EventArgs e)
        {

        }
        private void addressInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void nameInput_Click(object sender, EventArgs e)
        {
            nameInput.ForeColor = Color.Black;
            emailInput.ForeColor = Color.DimGray;
            phoneInput.ForeColor = Color.DimGray;
            addressInput.ForeColor = Color.DimGray;
            cWeightInput.ForeColor = Color.DimGray;
            tWeightInput.ForeColor = Color.DimGray;
        }

        private void emailInput_Click(object sender, EventArgs e)
        {
            emailInput.ForeColor = Color.Black;
            nameInput.ForeColor = Color.DimGray;
            phoneInput.ForeColor = Color.DimGray;
            addressInput.ForeColor = Color.DimGray;
            cWeightInput.ForeColor = Color.DimGray;
            tWeightInput.ForeColor = Color.DimGray;
        }

        private void phoneInput_Click(object sender, EventArgs e)
        {
            phoneInput.ForeColor = Color.Black;
            emailInput.ForeColor = Color.DimGray;
            nameInput.ForeColor = Color.DimGray;
            addressInput.ForeColor = Color.DimGray;
            cWeightInput.ForeColor = Color.DimGray;
            tWeightInput.ForeColor = Color.DimGray;
        }

       

        private void addressInput_Click(object sender, EventArgs e)
        {
            addressInput.ForeColor = Color.Black;
            emailInput.ForeColor = Color.DimGray;
            phoneInput.ForeColor = Color.DimGray;
            nameInput.ForeColor = Color.DimGray;
            cWeightInput.ForeColor = Color.DimGray;
            tWeightInput.ForeColor = Color.DimGray;
        }

        private void cWeightInput_Click(object sender, EventArgs e)
        {
            cWeightInput.ForeColor = Color.Black;
            emailInput.ForeColor = Color.DimGray;
            phoneInput.ForeColor = Color.DimGray;
            addressInput.ForeColor = Color.DimGray;
            nameInput.ForeColor = Color.DimGray;
            tWeightInput.ForeColor = Color.DimGray;
        }

        private void tWeightInput_Click(object sender, EventArgs e)
        {
            tWeightInput.ForeColor = Color.Black;
            emailInput.ForeColor = Color.DimGray;
            phoneInput.ForeColor = Color.DimGray;
            addressInput.ForeColor = Color.DimGray;
            cWeightInput.ForeColor = Color.DimGray;
            nameInput.ForeColor = Color.DimGray;
        }
        Classes.customersClass uc = new Classes.customersClass();
        private async void updateBtn_Click(object sender, EventArgs e)
        {
       
            if (nameInput.Text == "" || emailInput.Text == "" || phoneInput.Text == "" || addressInput.Text == "" || cWeightInput.Text == "" || tWeightInput.Text == "")
            {
                errorLabel.Text = "Forgot Something ?";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }


            try
            {
                bool r = uc.manageCustomers(int.Parse(customerIDInput.Text), nameInput.Text, DateTime.Parse(dobInput.Text), addressInput.Text, phoneInput.Text, emailInput.Text, int.Parse(cWeightInput.Text), int.Parse(tWeightInput.Text), 2);
                if (r)
                {
                    customersTab cstTab = new customersTab();

                  this.Close();


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
                errorLabel.Text = "Something went wrong Ex.";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
            }
        }
    }
}
