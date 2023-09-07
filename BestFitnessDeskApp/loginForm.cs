using BestFitnessDeskApp.UsersControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

using System.Drawing.Drawing2D;
using System.Windows.Forms;


namespace BestFitnessDeskApp
{
    public partial class loginForm : Form
    {
         
        public loginForm()
        {
            
            InitializeComponent();
            opacityPanel.BackColor = Color.FromArgb(155, Color.Black);


        }
        bool mouseDown;
        private Point offset;
    

     
        private void loginForm_Load(object sender, EventArgs e)
        {

        }
        private void addUserControl(UserControl userControl)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void closeBtnX_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
        
           
        }

        private void iconButton1_MouseHover(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            mainMenu frm = new mainMenu();
            frm.Show();
        }

        private void title1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            userNameInput.Focus();
            userNameLabel.Hide();   
            if (passwordInput.Text == "")
            {
                passwordLabel.Show();
            }

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {
            passwordInput.Focus();
            passwordLabel.Hide();
            if (userNameInput.Text == "")
            {
                userNameLabel.Show();

            }
        }
        
        private void dragPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void dragPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown == true)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void dragPanel_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown=false;
        }
        Classes.usersClass uc = new Classes.usersClass();

            private async void loginBtn_Click(object sender, EventArgs e)
                {
            try
            {
                bool rs = uc.loginUser(userNameInput.Text, passwordInput.Text);
                if (rs)
                {

                    this.Hide();
                    mainMenu frm = new mainMenu();
                    frm.Show();
                    


                }
                else {
                    errorLabel.Text = "Incorrect Username or Password";
                    errorLabel.Visible = true;
                    await Task.Delay(5000);
                    errorLabel.Visible = false;
                    passwordInput.Clear();
                
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

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void userNameInput_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void userNameInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (passwordInput.Text == "" ) { 
                passwordLabel.Show();
            }
            userNameLabel.Hide();
            
        }
     

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {
            passwordLabel.Hide();
        }

        private void passwordInput_MouseClick(object sender, MouseEventArgs e)
        {
            if (userNameInput.Text =="" )
            {
                userNameLabel.Show();
                
            }
            passwordLabel.Hide();
        }

        private void loginForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (userNameInput.Text == "")
            {
                userNameLabel.Show();
               
            }
            if (passwordInput.Text == "")
            {
                passwordLabel.Show();
                
            }

        }

        private void loginBtn_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void usrImg_Click(object sender, EventArgs e)
        {

        }

        private void loginBtn_MouseLeave(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.White;
        }

        private void loginBtn_MouseEnter(object sender, EventArgs e)
        {
            loginBtn.ForeColor = Color.Black;
        }

        private void passwordInput_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void passwordInput_Enter(object sender, EventArgs e)
        {
          
        }

        private void passwordInput_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginBtn_Click(this, new EventArgs());
            }
        }

        private void guna2CustomGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void opacityPanel_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
