namespace BestFitnessDeskApp.UsersControl
{
    partial class customersTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.successLabel = new FontAwesome.Sharp.IconButton();
            this.errorLabel = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.searchInput = new Guna.UI2.WinForms.Guna2TextBox();
            this.searchBtn = new FontAwesome.Sharp.IconButton();
            this.searchLabel = new System.Windows.Forms.Label();
            this.customerTable = new System.Windows.Forms.DataGridView();
            this.successInput = new System.Windows.Forms.TextBox();
            this.clearSearchBtn = new FontAwesome.Sharp.IconButton();
            this.deleteAllButton = new FontAwesome.Sharp.IconButton();
            this.slctAllBtn = new FontAwesome.Sharp.IconButton();
            this.customerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactPhn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.targetWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteBtn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.selectBox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).BeginInit();
            this.SuspendLayout();
            // 
            // successLabel
            // 
            this.successLabel.FlatAppearance.BorderSize = 0;
            this.successLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.successLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.successLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.successLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.successLabel.ForeColor = System.Drawing.Color.Green;
            this.successLabel.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.successLabel.IconColor = System.Drawing.Color.Green;
            this.successLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.successLabel.IconSize = 28;
            this.successLabel.Location = new System.Drawing.Point(798, 179);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(499, 45);
            this.successLabel.TabIndex = 75;
            this.successLabel.Text = "iconButton2";
            this.successLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.successLabel.UseVisualStyleBackColor = true;
            this.successLabel.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.FlatAppearance.BorderSize = 0;
            this.errorLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.errorLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.errorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.errorLabel.IconColor = System.Drawing.Color.Red;
            this.errorLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorLabel.IconSize = 28;
            this.errorLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.errorLabel.Location = new System.Drawing.Point(874, 179);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(410, 45);
            this.errorLabel.TabIndex = 76;
            this.errorLabel.Text = "iconButton2";
            this.errorLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.errorLabel.UseVisualStyleBackColor = true;
            this.errorLabel.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Yu Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2069, 118);
            this.panel1.TabIndex = 77;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(808, 3);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(525, 100);
            this.iconButton1.TabIndex = 29;
            this.iconButton1.Text = "Customer Management";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // searchInput
            // 
            this.searchInput.AutoRoundedCorners = true;
            this.searchInput.BorderRadius = 30;
            this.searchInput.BorderThickness = 0;
            this.searchInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchInput.DefaultText = "";
            this.searchInput.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchInput.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchInput.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchInput.FillColor = System.Drawing.Color.Gainsboro;
            this.searchInput.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchInput.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.searchInput.ForeColor = System.Drawing.Color.Black;
            this.searchInput.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchInput.Location = new System.Drawing.Point(15, 229);
            this.searchInput.Margin = new System.Windows.Forms.Padding(5, 7, 5, 7);
            this.searchInput.Name = "searchInput";
            this.searchInput.PasswordChar = '\0';
            this.searchInput.PlaceholderText = "";
            this.searchInput.SelectedText = "";
            this.searchInput.Size = new System.Drawing.Size(561, 63);
            this.searchInput.TabIndex = 79;
            this.searchInput.TextOffset = new System.Drawing.Point(10, 0);
            this.searchInput.TextChanged += new System.EventHandler(this.guna2TextBox1_TextChanged);
            this.searchInput.Click += new System.EventHandler(this.searchInput_Click);
            this.searchInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchInput_KeyPress);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.searchBtn.FlatAppearance.BorderSize = 0;
            this.searchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchBtn.ForeColor = System.Drawing.Color.Transparent;
            this.searchBtn.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.searchBtn.IconColor = System.Drawing.Color.Black;
            this.searchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.searchBtn.IconSize = 25;
            this.searchBtn.Location = new System.Drawing.Point(33, 245);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(32, 36);
            this.searchBtn.TabIndex = 80;
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.Color.Gainsboro;
            this.searchLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.searchLabel.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.searchLabel.Location = new System.Drawing.Point(68, 252);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(86, 18);
            this.searchLabel.TabIndex = 81;
            this.searchLabel.Text = "SEARCH....";
            this.searchLabel.Click += new System.EventHandler(this.searchLabel_Click);
            // 
            // customerTable
            // 
            this.customerTable.AllowUserToAddRows = false;
            this.customerTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.customerTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.customerTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customerTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.customerTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.customerTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.customerTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.customerTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.customerTable.ColumnHeadersHeight = 65;
            this.customerTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.customerTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerID,
            this.customerName,
            this.DOB,
            this.Address,
            this.contactPhn,
            this.contactEmail,
            this.currentWeight,
            this.targetWeight,
            this.editBtn,
            this.deleteBtn,
            this.selectBox});
            this.customerTable.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 3.8F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.customerTable.DefaultCellStyle = dataGridViewCellStyle7;
            this.customerTable.EnableHeadersVisualStyles = false;
            this.customerTable.Location = new System.Drawing.Point(15, 313);
            this.customerTable.MultiSelect = false;
            this.customerTable.Name = "customerTable";
            this.customerTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.customerTable.RowHeadersVisible = false;
            this.customerTable.RowHeadersWidth = 51;
            this.customerTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.customerTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.customerTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.customerTable.RowTemplate.Height = 50;
            this.customerTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.customerTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.customerTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerTable.ShowEditingIcon = false;
            this.customerTable.Size = new System.Drawing.Size(2043, 923);
            this.customerTable.TabIndex = 72;
            this.customerTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customerTable_CellContentClick);
            // 
            // successInput
            // 
            this.successInput.Location = new System.Drawing.Point(476, 256);
            this.successInput.Name = "successInput";
            this.successInput.Size = new System.Drawing.Size(100, 22);
            this.successInput.TabIndex = 82;
            // 
            // clearSearchBtn
            // 
            this.clearSearchBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.clearSearchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearSearchBtn.FlatAppearance.BorderSize = 0;
            this.clearSearchBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.clearSearchBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.clearSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearSearchBtn.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.clearSearchBtn.IconColor = System.Drawing.Color.Crimson;
            this.clearSearchBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clearSearchBtn.IconSize = 30;
            this.clearSearchBtn.Location = new System.Drawing.Point(523, 242);
            this.clearSearchBtn.Name = "clearSearchBtn";
            this.clearSearchBtn.Size = new System.Drawing.Size(40, 41);
            this.clearSearchBtn.TabIndex = 83;
            this.clearSearchBtn.UseVisualStyleBackColor = false;
            this.clearSearchBtn.Click += new System.EventHandler(this.iconButton2_Click_1);
            // 
            // deleteAllButton
            // 
            this.deleteAllButton.BackColor = System.Drawing.Color.Gainsboro;
            this.deleteAllButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAllButton.FlatAppearance.BorderSize = 0;
            this.deleteAllButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAllButton.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.deleteAllButton.ForeColor = System.Drawing.Color.Crimson;
            this.deleteAllButton.IconChar = FontAwesome.Sharp.IconChar.CircleMinus;
            this.deleteAllButton.IconColor = System.Drawing.Color.Crimson;
            this.deleteAllButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.deleteAllButton.IconSize = 25;
            this.deleteAllButton.Location = new System.Drawing.Point(1817, 229);
            this.deleteAllButton.Name = "deleteAllButton";
            this.deleteAllButton.Size = new System.Drawing.Size(241, 63);
            this.deleteAllButton.TabIndex = 84;
            this.deleteAllButton.Text = "Delete Selected";
            this.deleteAllButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.deleteAllButton.UseVisualStyleBackColor = false;
            this.deleteAllButton.Click += new System.EventHandler(this.deleteAllButton_Click);
            // 
            // slctAllBtn
            // 
            this.slctAllBtn.BackColor = System.Drawing.Color.Gainsboro;
            this.slctAllBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.slctAllBtn.FlatAppearance.BorderSize = 0;
            this.slctAllBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slctAllBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Bold);
            this.slctAllBtn.ForeColor = System.Drawing.Color.Green;
            this.slctAllBtn.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
            this.slctAllBtn.IconColor = System.Drawing.Color.Green;
            this.slctAllBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.slctAllBtn.IconSize = 25;
            this.slctAllBtn.Location = new System.Drawing.Point(1546, 229);
            this.slctAllBtn.Name = "slctAllBtn";
            this.slctAllBtn.Size = new System.Drawing.Size(241, 63);
            this.slctAllBtn.TabIndex = 85;
            this.slctAllBtn.Text = "Select All";
            this.slctAllBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.slctAllBtn.UseVisualStyleBackColor = false;
            this.slctAllBtn.Click += new System.EventHandler(this.slctAllBtn_Click);
            // 
            // customerID
            // 
            this.customerID.DataPropertyName = "customerID";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.customerID.DefaultCellStyle = dataGridViewCellStyle3;
            this.customerID.FillWeight = 23.28231F;
            this.customerID.HeaderText = "ID";
            this.customerID.MinimumWidth = 6;
            this.customerID.Name = "customerID";
            this.customerID.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customerName";
            dataGridViewCellStyle4.Format = "N0";
            this.customerName.DefaultCellStyle = dataGridViewCellStyle4;
            this.customerName.FillWeight = 64.02637F;
            this.customerName.HeaderText = "Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // DOB
            // 
            this.DOB.DataPropertyName = "DOB";
            this.DOB.FillWeight = 46.56462F;
            this.DOB.HeaderText = "DOB";
            this.DOB.MinimumWidth = 6;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            // 
            // Address
            // 
            this.Address.DataPropertyName = "Address";
            this.Address.FillWeight = 58.20579F;
            this.Address.HeaderText = "Address";
            this.Address.MinimumWidth = 6;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            // 
            // contactPhn
            // 
            this.contactPhn.DataPropertyName = "contactPhn";
            this.contactPhn.FillWeight = 58.20579F;
            this.contactPhn.HeaderText = "Phone Number";
            this.contactPhn.MinimumWidth = 6;
            this.contactPhn.Name = "contactPhn";
            this.contactPhn.ReadOnly = true;
            // 
            // contactEmail
            // 
            this.contactEmail.DataPropertyName = "contactEmail";
            this.contactEmail.FillWeight = 58.20579F;
            this.contactEmail.HeaderText = "Email";
            this.contactEmail.MinimumWidth = 6;
            this.contactEmail.Name = "contactEmail";
            this.contactEmail.ReadOnly = true;
            // 
            // currentWeight
            // 
            this.currentWeight.DataPropertyName = "currentWeight";
            this.currentWeight.FillWeight = 52.38521F;
            this.currentWeight.HeaderText = "Current Weight";
            this.currentWeight.MinimumWidth = 6;
            this.currentWeight.Name = "currentWeight";
            this.currentWeight.ReadOnly = true;
            // 
            // targetWeight
            // 
            this.targetWeight.DataPropertyName = "targetWeight";
            this.targetWeight.FillWeight = 52.38521F;
            this.targetWeight.HeaderText = "Target Weight";
            this.targetWeight.MinimumWidth = 6;
            this.targetWeight.Name = "targetWeight";
            this.targetWeight.ReadOnly = true;
            // 
            // editBtn
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(171)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.editBtn.DefaultCellStyle = dataGridViewCellStyle5;
            this.editBtn.FillWeight = 46.56462F;
            this.editBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editBtn.HeaderText = "Edit";
            this.editBtn.MinimumWidth = 6;
            this.editBtn.Name = "editBtn";
            this.editBtn.Text = "Edit";
            this.editBtn.UseColumnTextForButtonValue = true;
            // 
            // deleteBtn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Crimson;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.deleteBtn.DefaultCellStyle = dataGridViewCellStyle6;
            this.deleteBtn.FillWeight = 46.56462F;
            this.deleteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteBtn.HeaderText = "Delete";
            this.deleteBtn.MinimumWidth = 6;
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseColumnTextForButtonValue = true;
            // 
            // selectBox
            // 
            this.selectBox.FillWeight = 28.60962F;
            this.selectBox.HeaderText = "Select";
            this.selectBox.MinimumWidth = 6;
            this.selectBox.Name = "selectBox";
            this.selectBox.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // customersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.slctAllBtn);
            this.Controls.Add(this.deleteAllButton);
            this.Controls.Add(this.clearSearchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.searchInput);
            this.Controls.Add(this.customerTable);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.successInput);
            this.Controls.Add(this.successLabel);
            this.Name = "customersTab";
            this.Size = new System.Drawing.Size(2069, 1215);
            this.Load += new System.EventHandler(this.customersTab_Load);
            this.Click += new System.EventHandler(this.customersTab_Click);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customerTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton successLabel;
        private FontAwesome.Sharp.IconButton errorLabel;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private Guna.UI2.WinForms.Guna2TextBox searchInput;
        private FontAwesome.Sharp.IconButton searchBtn;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.DataGridView customerTable;
        private System.Windows.Forms.TextBox successInput;
        private FontAwesome.Sharp.IconButton clearSearchBtn;
        private FontAwesome.Sharp.IconButton deleteAllButton;
        private FontAwesome.Sharp.IconButton slctAllBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactPhn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn targetWeight;
        private System.Windows.Forms.DataGridViewButtonColumn editBtn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteBtn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectBox;
    }
}
