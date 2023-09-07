namespace BestFitnessDeskApp
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.title1 = new System.Windows.Forms.Label();
            this.title2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.dragPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.loginBtn = new FontAwesome.Sharp.IconButton();
            this.pswImg = new FontAwesome.Sharp.IconButton();
            this.usrImg = new FontAwesome.Sharp.IconButton();
            this.closeBtnX = new FontAwesome.Sharp.IconButton();
            this.errorLabel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.GradientPanel = new System.Windows.Forms.Panel();
            this.opacityPanel = new System.Windows.Forms.Panel();
            this.dragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.GradientPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // title1
            // 
            resources.ApplyResources(this.title1, "title1");
            this.title1.Name = "title1";
            this.title1.Click += new System.EventHandler(this.title1_Click);
            // 
            // title2
            // 
            resources.ApplyResources(this.title2, "title2");
            this.title2.BackColor = System.Drawing.Color.Transparent;
            this.title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(154)))));
            this.title2.Name = "title2";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(154)))));
            this.panel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(91)))), ((int)(((byte)(134)))), ((int)(((byte)(154)))));
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Name = "label1";
            // 
            // userNameInput
            // 
            this.userNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.userNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.userNameInput, "userNameInput");
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.userNameInput_MouseClick);
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.passwordInput, "passwordInput");
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passwordInput_MouseClick);
            this.passwordInput.TextChanged += new System.EventHandler(this.passwordInput_TextChanged);
            this.passwordInput.Enter += new System.EventHandler(this.passwordInput_Enter);
            this.passwordInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordInput_KeyDown);
            this.passwordInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.passwordInput_KeyPress);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel3, "panel3");
            this.panel3.Name = "panel3";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.panel4, "panel4");
            this.panel4.Name = "panel4";
            this.panel4.Paint += new System.Windows.Forms.PaintEventHandler(this.panel4_Paint);
            // 
            // userNameLabel
            // 
            resources.ApplyResources(this.userNameLabel, "userNameLabel");
            this.userNameLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userNameLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // passwordLabel
            // 
            resources.ApplyResources(this.passwordLabel, "passwordLabel");
            this.passwordLabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // dragPanel
            // 
            this.dragPanel.Controls.Add(this.pictureBox1);
            this.dragPanel.Controls.Add(this.titleLabel);
            resources.ApplyResources(this.dragPanel, "dragPanel");
            this.dragPanel.Name = "dragPanel";
            this.dragPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.dragPanel_Paint);
            this.dragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseDown);
            this.dragPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseMove);
            this.dragPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dragPanel_MouseUp);
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // titleLabel
            // 
            resources.ApplyResources(this.titleLabel, "titleLabel");
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Click += new System.EventHandler(this.titleLabel_Click);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.loginBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginBtn.FlatAppearance.BorderSize = 0;
            this.loginBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            resources.ApplyResources(this.loginBtn, "loginBtn");
            this.loginBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.loginBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.loginBtn.IconColor = System.Drawing.Color.Black;
            this.loginBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.loginBtn.IconSize = 1;
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            this.loginBtn.MouseEnter += new System.EventHandler(this.loginBtn_MouseEnter);
            this.loginBtn.MouseLeave += new System.EventHandler(this.loginBtn_MouseLeave);
            this.loginBtn.MouseHover += new System.EventHandler(this.loginBtn_MouseHover);
            // 
            // pswImg
            // 
            this.pswImg.BackColor = System.Drawing.Color.Transparent;
            this.pswImg.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.pswImg, "pswImg");
            this.pswImg.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.pswImg.IconColor = System.Drawing.Color.Black;
            this.pswImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.pswImg.IconSize = 22;
            this.pswImg.Name = "pswImg";
            this.pswImg.UseVisualStyleBackColor = false;
            // 
            // usrImg
            // 
            this.usrImg.BackColor = System.Drawing.Color.Transparent;
            this.usrImg.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.usrImg, "usrImg");
            this.usrImg.IconChar = FontAwesome.Sharp.IconChar.User;
            this.usrImg.IconColor = System.Drawing.Color.Black;
            this.usrImg.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.usrImg.IconSize = 22;
            this.usrImg.Name = "usrImg";
            this.usrImg.UseVisualStyleBackColor = false;
            this.usrImg.Click += new System.EventHandler(this.usrImg_Click);
            // 
            // closeBtnX
            // 
            this.closeBtnX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtnX.FlatAppearance.BorderSize = 0;
            this.closeBtnX.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            resources.ApplyResources(this.closeBtnX, "closeBtnX");
            this.closeBtnX.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.closeBtnX.IconColor = System.Drawing.Color.Black;
            this.closeBtnX.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtnX.IconSize = 30;
            this.closeBtnX.Name = "closeBtnX";
            this.closeBtnX.UseVisualStyleBackColor = true;
            this.closeBtnX.Click += new System.EventHandler(this.closeBtnX_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.FlatAppearance.BorderSize = 0;
            this.errorLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.errorLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            resources.ApplyResources(this.errorLabel, "errorLabel");
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.errorLabel.IconColor = System.Drawing.Color.Red;
            this.errorLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorLabel.IconSize = 28;
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSlateGray;
            this.panel1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GradientPanel
            // 
            resources.ApplyResources(this.GradientPanel, "GradientPanel");
            this.GradientPanel.Controls.Add(this.opacityPanel);
            this.GradientPanel.Name = "GradientPanel";
            // 
            // opacityPanel
            // 
            resources.ApplyResources(this.opacityPanel, "opacityPanel");
            this.opacityPanel.Name = "opacityPanel";
            this.opacityPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.opacityPanel_Paint);
            // 
            // loginForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.GradientPanel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.dragPanel);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.pswImg);
            this.Controls.Add(this.usrImg);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.title2);
            this.Controls.Add(this.title1);
            this.Controls.Add(this.closeBtnX);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "loginForm";
            this.Load += new System.EventHandler(this.loginForm_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.loginForm_MouseClick);
            this.dragPanel.ResumeLayout(false);
            this.dragPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.GradientPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton closeBtnX;
        private System.Windows.Forms.Label title1;
        private System.Windows.Forms.Label title2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private FontAwesome.Sharp.IconButton usrImg;
        private FontAwesome.Sharp.IconButton pswImg;
        private FontAwesome.Sharp.IconButton loginBtn;
        private System.Windows.Forms.Panel dragPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton errorLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel GradientPanel;
        private System.Windows.Forms.Panel opacityPanel;
    }
}