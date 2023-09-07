using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;

namespace BestFitnessDeskApp.UsersControl
{
    public partial class newRegTab : UserControl
    {
        public newRegTab()
        {
            InitializeComponent();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newRegTab_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
      

        private void homeBtn_Click(object sender, EventArgs e)
        {

            
            

        }
        Classes.customersClass uc = new Classes.customersClass();

        private async void submitBtn_Click(object sender, EventArgs e)
        {


            if (nameInput.Text == "" || emailInput.Text == "" || phoneInput.Text == ""|| addressInput.Text==""|| cWeightInput.Text==""|| tWeightInput.Text=="")
            {
                errorLabel.Text = "Forgot Something ?";
                errorLabel.Visible = true;
                await Task.Delay(5000);
                errorLabel.Visible = false;
                return;

            }


            try
            {
                bool r  = uc.manageCustomers(0, nameInput.Text,DateTime.Parse(dobInput.Text), addressInput.Text, phoneInput.Text, emailInput.Text, int.Parse( cWeightInput.Text),int.Parse(tWeightInput.Text), 1);
                if (r)
                {
                    successLabel.Text = "Customer Added Successfully.";

                    nameInput.Clear();
                    emailInput.Clear();
                    phoneInput.Clear();
                    addressInput.Clear();
                    cWeightInput.Clear();
                    tWeightInput.Clear();

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

        private void clearBtn_Click(object sender, EventArgs e)
        {

            nameInput.Clear();
            emailInput.Clear();
            phoneInput.Clear();
            addressInput.Clear();
            cWeightInput.Clear();
            tWeightInput.Clear();
        }
    }
}
