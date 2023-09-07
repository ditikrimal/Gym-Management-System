using BestFitnessDeskApp.UsersControl;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Net;
using System.Text.RegularExpressions;


namespace BestFitnessDeskApp
{
    public partial class mainMenu : Form
    {

        public Color Red { get; private set; }
        bool mouseDown;
        private Point offset;

       
        public mainMenu()
        {
            InitializeComponent();
            clockBox.Text = DateTime.Now.ToString();
            this.SetStyle(ControlStyles.ResizeRedraw, true);


            dashboardHomeTab uc = new dashboardHomeTab();
            addUserControl(uc);



        }
        






        private const int cGrip = 16;
        private const int cCaption = 32;


        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84) {

                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption) {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip) {
                    m.Result=(IntPtr)17;
                    return;
                    
            }
            }
            base.WndProc(ref m);
        }


        private void addUserControl(UserControl userControl) { 
            
            userControl.Dock = DockStyle.Fill;
            tabsPanel.Controls.Clear();
            userControl.BringToFront();
            tabsPanel.Controls.Add(userControl);
        }
        private void removeUserControl(UserControl userControl)
        {

            userControl.Dock = DockStyle.Fill;
            tabsPanel.Controls.Clear();
            
        }



        private void pageDragTreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }
        private void logoPanel_Paint(object sender, PaintEventArgs e)
        {

        }
       



        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logoPicture_Click(object sender, EventArgs e)
        {

        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {
            BackColor = Color.Black;
        }

        private void customerCareBtn_Click(object sender, EventArgs e)
        {

        }

        private void kryptonDropButton1_Click(object sender, EventArgs e)
        {

        }

        private void kryptonLabel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void exitBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void feedbackBtn_Click(object sender, EventArgs e)
        {

        }
   
        private void customercareBtn_Click_1(object sender, EventArgs e)
        {
           

        }

        private void contactLabel_Click(object sender, EventArgs e)
        {

        }

       
        

        private void crossBtn_Click_1(object sender, EventArgs e)
        {
            Close();
           /* DialogResult dr = Message.Show("Do you really want to quit ?","Confirm Exit");*/


        }

        private void exitBtn_Click_2(object sender, EventArgs e)
        {

            if (customersBtn.Focus())
            {
               
                trainingPlanBtn.BackColor = Color.Transparent;
                custTrainBtn.BackColor = Color.Transparent;
                newRegBtn.BackColor = Color.Transparent;
                customersBtn.BackColor= Color.Transparent;  
                userBtn.BackColor = Color.Transparent;

                customersBtn.BackColor = Color.FromArgb(69, 70, 71);
            }
            customersTab uc = new  customersTab();
            addUserControl(uc);

        }

        private void trainersBtn_Click(object sender, EventArgs e)
        {

        }

        private void custTrainBtn_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

       

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
      
       

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            offset.X = e.X;
            offset.Y = e.Y;
            mouseDown = true;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
          if (mouseDown == true) { 
            Point currentScreenPos= PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - offset.X, currentScreenPos.Y - offset.Y);
            }
        }

        private void draggableTitle_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
     
        private void iconButton1_Click_2(object sender, EventArgs e)
              
        {


            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
             
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
     
        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

      

     
        private void clockBox_Tick(object sender, EventArgs e)
        {
          
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockBox.Text = DateTime.Now.ToString();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        
        private void titleName_Click(object sender, EventArgs e)
        {

        }

        private void clockBox_Click(object sender, EventArgs e)
        {

        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {

        }
     
        private void userBtn_Click(object sender, EventArgs e)
        {
            if (userBtn.Focus())
            {
                trainingPlanBtn.BackColor = Color.Transparent;
                custTrainBtn.BackColor = Color.Transparent;
                newRegBtn.BackColor = Color.Transparent;
                customersBtn.BackColor = Color.Transparent;

                userBtn.BackColor = Color.FromArgb(69, 70, 71);
            }
            UsersTab uc =new UsersTab();
            addUserControl(uc); 

        }


        private void newRegBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (newRegBtn.Focus())
            {
               
                userBtn.BackColor = Color.Transparent;
              
                trainingPlanBtn.BackColor = Color.Transparent;
                custTrainBtn.BackColor = Color.Transparent;
                customersBtn.BackColor = Color.Transparent;

                newRegBtn.BackColor = Color.FromArgb(69, 70, 71);
            }
        }

        private void trainingPlanBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (trainingPlanBtn.Focus())
            {

                userBtn.BackColor = Color.Transparent;
                newRegBtn.BackColor = Color.Transparent;
                custTrainBtn.BackColor = Color.Transparent;
                customersBtn.BackColor = Color.Transparent;

                trainingPlanBtn.BackColor = Color.FromArgb(69, 70, 71);
            }
            trainPlanTab uc = new trainPlanTab();
            addUserControl(uc);
        }

        private void custTrainBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (custTrainBtn.Focus())
            {

                userBtn.BackColor = Color.Transparent;
                newRegBtn.BackColor = Color.Transparent;
                trainingPlanBtn.BackColor = Color.Transparent;
                customersBtn.BackColor = Color.Transparent;

                custTrainBtn.BackColor = Color.FromArgb(69, 70, 71);
            }
        }

     

        private void newRegBtn_Click(object sender, EventArgs e)
        {
            newRegTab uc = new newRegTab();
            addUserControl(uc);
        }

        private void trainingPlanBtn_Click(object sender, EventArgs e)
        {
            trainPlanTab uc = new trainPlanTab();
            addUserControl(uc);
        }

        private void custTrainBtn_Click_1(object sender, EventArgs e)
        {
            cstmTrainPlanTab uc = new cstmTrainPlanTab();
            addUserControl(uc);
        }
        private void trainersBtn_Click_1(object sender, EventArgs e)
        {
            trainersTab uc = new trainersTab();
            addUserControl(uc);
        }

        private void tabsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void tabsPanel_Load(object sender, PaintEventArgs e)
        {

        }
        private void iconButton1_Click_3(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Do you want to Log Out ?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                Close();
                this.Hide();

                loginForm lgFrm = new loginForm();
                lgFrm.Show();
            }
        }

        private void iconButton1_Click_4(object sender, EventArgs e)
        {
            this.Hide();
            newRegTab frm = new newRegTab();
            frm.Show();
          
        }

      
        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void userBtn_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            userBtn.BackColor = Color.Transparent;
            custTrainBtn.BackColor = Color.Transparent;
            newRegBtn.BackColor = Color.Transparent;
            trainingPlanBtn.BackColor = Color.Transparent;
            customersBtn.BackColor = Color.Transparent;
            dashboardHomeTab uc = new dashboardHomeTab();
            addUserControl(uc);
        }

        private void CstmrPlanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cstrPlanTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void copyLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }

