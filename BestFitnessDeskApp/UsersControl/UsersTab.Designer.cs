namespace BestFitnessDeskApp.UsersControl
{
    partial class UsersTab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.createBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.clearBtn = new FontAwesome.Sharp.IconButton();
            this.panel7 = new System.Windows.Forms.Panel();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userNameInput = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cPasswordLabel = new System.Windows.Forms.Label();
            this.cPasswordInput = new System.Windows.Forms.TextBox();
            this.errorLabel = new FontAwesome.Sharp.IconButton();
            this.usersTable = new System.Windows.Forms.DataGridView();
            this.userID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.successLabel = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2069, 119);
            this.panel1.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(840, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(528, 100);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.Text = "Users Management";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            this.createBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.createBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createBtn.FlatAppearance.BorderSize = 0;
            this.createBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(71)))));
            this.createBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createBtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createBtn.ForeColor = System.Drawing.Color.White;
            this.createBtn.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.createBtn.IconColor = System.Drawing.Color.White;
            this.createBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.createBtn.IconSize = 32;
            this.createBtn.Location = new System.Drawing.Point(581, 413);
            this.createBtn.Name = "createBtn";
            this.createBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.createBtn.Size = new System.Drawing.Size(192, 64);
            this.createBtn.TabIndex = 1;
            this.createBtn.Text = "Create";
            this.createBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.deleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteBtn.FlatAppearance.BorderSize = 0;
            this.deleteBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Crimson;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.ForeColor = System.Drawing.Color.White;
            this.deleteBtn.IconChar = FontAwesome.Sharp.IconChar.UserXmark;
            this.deleteBtn.IconColor = System.Drawing.Color.White;
            this.deleteBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteBtn.IconSize = 32;
            this.deleteBtn.Location = new System.Drawing.Point(1166, 413);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(192, 64);
            this.deleteBtn.TabIndex = 2;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.editBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.editBtn.FlatAppearance.BorderSize = 0;
            this.editBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(106)))), ((int)(((byte)(145)))));
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editBtn.ForeColor = System.Drawing.Color.White;
            this.editBtn.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.editBtn.IconColor = System.Drawing.Color.White;
            this.editBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.editBtn.IconSize = 32;
            this.editBtn.Location = new System.Drawing.Point(874, 413);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(192, 64);
            this.editBtn.TabIndex = 3;
            this.editBtn.Text = "Edit";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.ForeColor = System.Drawing.Color.White;
            this.clearBtn.IconChar = FontAwesome.Sharp.IconChar.Backspace;
            this.clearBtn.IconColor = System.Drawing.Color.White;
            this.clearBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearBtn.IconSize = 32;
            this.clearBtn.Location = new System.Drawing.Point(1458, 413);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.clearBtn.Size = new System.Drawing.Size(192, 64);
            this.clearBtn.TabIndex = 4;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Black;
            this.panel7.Location = new System.Drawing.Point(491, 282);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(350, 3);
            this.panel7.TabIndex = 27;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.userNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.userNameLabel.Location = new System.Drawing.Point(490, 210);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(107, 24);
            this.userNameLabel.TabIndex = 26;
            this.userNameLabel.Text = "Username :";
            // 
            // userNameInput
            // 
            this.userNameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.userNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.userNameInput.Location = new System.Drawing.Point(495, 248);
            this.userNameInput.Multiline = true;
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.Size = new System.Drawing.Size(352, 56);
            this.userNameInput.TabIndex = 25;
            this.userNameInput.AcceptsTabChanged += new System.EventHandler(this.userNameInput_AcceptsTabChanged);
            this.userNameInput.TextChanged += new System.EventHandler(this.userNameInput_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(934, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 3);
            this.panel2.TabIndex = 30;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.passwordLabel.Location = new System.Drawing.Point(933, 210);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 24);
            this.passwordLabel.TabIndex = 29;
            this.passwordLabel.Text = "Password :";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.passwordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.passwordInput.Location = new System.Drawing.Point(938, 248);
            this.passwordInput.Multiline = true;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(352, 56);
            this.passwordInput.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(1377, 282);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 3);
            this.panel3.TabIndex = 33;
            // 
            // cPasswordLabel
            // 
            this.cPasswordLabel.AutoSize = true;
            this.cPasswordLabel.BackColor = System.Drawing.Color.Transparent;
            this.cPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.cPasswordLabel.Location = new System.Drawing.Point(1376, 210);
            this.cPasswordLabel.Name = "cPasswordLabel";
            this.cPasswordLabel.Size = new System.Drawing.Size(172, 24);
            this.cPasswordLabel.TabIndex = 32;
            this.cPasswordLabel.Text = "Confirm Password :";
            // 
            // cPasswordInput
            // 
            this.cPasswordInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.cPasswordInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cPasswordInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.cPasswordInput.Location = new System.Drawing.Point(1381, 248);
            this.cPasswordInput.Multiline = true;
            this.cPasswordInput.Name = "cPasswordInput";
            this.cPasswordInput.PasswordChar = '*';
            this.cPasswordInput.Size = new System.Drawing.Size(352, 56);
            this.cPasswordInput.TabIndex = 31;
            // 
            // errorLabel
            // 
            this.errorLabel.FlatAppearance.BorderSize = 0;
            this.errorLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.errorLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.errorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.errorLabel.IconColor = System.Drawing.Color.Red;
            this.errorLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorLabel.IconSize = 28;
            this.errorLabel.Location = new System.Drawing.Point(923, 324);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(397, 45);
            this.errorLabel.TabIndex = 35;
            this.errorLabel.Text = "iconButton2";
            this.errorLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.errorLabel.UseVisualStyleBackColor = true;
            this.errorLabel.Visible = false;
            // 
            // usersTable
            // 
            this.usersTable.AllowUserToAddRows = false;
            this.usersTable.AllowUserToDeleteRows = false;
            this.usersTable.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.usersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.usersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.usersTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.usersTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.usersTable.ColumnHeadersHeight = 65;
            this.usersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userID,
            this.userName,
            this.password});
            this.usersTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.usersTable.EnableHeadersVisualStyles = false;
            this.usersTable.Location = new System.Drawing.Point(290, 527);
            this.usersTable.MultiSelect = false;
            this.usersTable.Name = "usersTable";
            this.usersTable.ReadOnly = true;
            this.usersTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.usersTable.RowHeadersVisible = false;
            this.usersTable.RowHeadersWidth = 51;
            this.usersTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.usersTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.usersTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.usersTable.RowTemplate.Height = 50;
            this.usersTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.usersTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.usersTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersTable.ShowEditingIcon = false;
            this.usersTable.Size = new System.Drawing.Size(1634, 642);
            this.usersTable.TabIndex = 37;
            this.usersTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellClick_1);
            this.usersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usersTable_CellContentClick_1);
            // 
            // userID
            // 
            this.userID.DataPropertyName = "userID";
            dataGridViewCellStyle3.Format = "N0";
            this.userID.DefaultCellStyle = dataGridViewCellStyle3;
            this.userID.HeaderText = "User ID";
            this.userID.MinimumWidth = 6;
            this.userID.Name = "userID";
            this.userID.ReadOnly = true;
            this.userID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // userName
            // 
            this.userName.DataPropertyName = "userName";
            this.userName.HeaderText = "User Name";
            this.userName.MinimumWidth = 6;
            this.userName.Name = "userName";
            this.userName.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "Password";
            this.password.MinimumWidth = 6;
            this.password.Name = "password";
            this.password.ReadOnly = true;
            // 
            // successLabel
            // 
            this.successLabel.FlatAppearance.BorderSize = 0;
            this.successLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.successLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.successLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.successLabel.ForeColor = System.Drawing.Color.Green;
            this.successLabel.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.successLabel.IconColor = System.Drawing.Color.Green;
            this.successLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.successLabel.IconSize = 28;
            this.successLabel.Location = new System.Drawing.Point(908, 324);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(391, 45);
            this.successLabel.TabIndex = 38;
            this.successLabel.Text = "iconButton2";
            this.successLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.successLabel.UseVisualStyleBackColor = true;
            this.successLabel.Visible = false;
            // 
            // UsersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.usersTable);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.cPasswordLabel);
            this.Controls.Add(this.cPasswordInput);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.successLabel);
            this.Name = "UsersTab";
            this.Size = new System.Drawing.Size(2069, 1215);
            this.Load += new System.EventHandler(this.UsersTab_Load);
            this.Click += new System.EventHandler(this.UsersTab_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton createBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton editBtn;
        private FontAwesome.Sharp.IconButton clearBtn;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.TextBox userNameInput;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label cPasswordLabel;
        private System.Windows.Forms.TextBox cPasswordInput;
        private FontAwesome.Sharp.IconButton errorLabel;
        private System.Windows.Forms.DataGridView usersTable;
        private FontAwesome.Sharp.IconButton successLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn userID;
        private System.Windows.Forms.DataGridViewTextBoxColumn userName;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;
    }
}
