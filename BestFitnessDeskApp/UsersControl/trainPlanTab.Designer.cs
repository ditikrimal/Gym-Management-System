namespace BestFitnessDeskApp.UsersControl
{
    partial class trainPlanTab
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rateInput = new System.Windows.Forms.TextBox();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tPlanTable = new System.Windows.Forms.DataGridView();
            this.planID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.planName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remarks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unitLabel = new System.Windows.Forms.Label();
            this.clearBtn = new FontAwesome.Sharp.IconButton();
            this.deleteBtn = new FontAwesome.Sharp.IconButton();
            this.createBtn = new FontAwesome.Sharp.IconButton();
            this.nameLabel = new System.Windows.Forms.Label();
            this.tPlanInput = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.successLabel = new FontAwesome.Sharp.IconButton();
            this.errorLabel = new FontAwesome.Sharp.IconButton();
            this.editBtn = new FontAwesome.Sharp.IconButton();
            this.remarksInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.unitInput = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.tPlanTable)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rateInput
            // 
            this.rateInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.rateInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rateInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.rateInput.Location = new System.Drawing.Point(58, 650);
            this.rateInput.Multiline = true;
            this.rateInput.Name = "rateInput";
            this.rateInput.Size = new System.Drawing.Size(481, 41);
            this.rateInput.TabIndex = 73;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Dumbbell;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(840, 4);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(528, 100);
            this.iconButton1.TabIndex = 30;
            this.iconButton1.Text = "Training Plan";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(53, 594);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 31);
            this.label1.TabIndex = 74;
            this.label1.Text = "Rate :";
            // 
            // tPlanTable
            // 
            this.tPlanTable.AllowUserToAddRows = false;
            this.tPlanTable.AllowUserToDeleteRows = false;
            this.tPlanTable.AllowUserToResizeColumns = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.tPlanTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tPlanTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tPlanTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.tPlanTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPlanTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tPlanTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Verdana", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(171)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tPlanTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.tPlanTable.ColumnHeadersHeight = 65;
            this.tPlanTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.tPlanTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.planID,
            this.planName,
            this.unit,
            this.rate,
            this.Remarks});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tPlanTable.DefaultCellStyle = dataGridViewCellStyle5;
            this.tPlanTable.EnableHeadersVisualStyles = false;
            this.tPlanTable.Location = new System.Drawing.Point(603, 342);
            this.tPlanTable.MultiSelect = false;
            this.tPlanTable.Name = "tPlanTable";
            this.tPlanTable.ReadOnly = true;
            this.tPlanTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tPlanTable.RowHeadersVisible = false;
            this.tPlanTable.RowHeadersWidth = 51;
            this.tPlanTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.tPlanTable.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 13F);
            this.tPlanTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.tPlanTable.RowTemplate.Height = 50;
            this.tPlanTable.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.tPlanTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tPlanTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tPlanTable.ShowEditingIcon = false;
            this.tPlanTable.Size = new System.Drawing.Size(1442, 494);
            this.tPlanTable.TabIndex = 71;
            this.tPlanTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tPlanTable_CellClick);
            this.tPlanTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tPlanTable_CellContentClick);
            // 
            // planID
            // 
            this.planID.DataPropertyName = "planID";
            dataGridViewCellStyle3.Format = "N0";
            dataGridViewCellStyle3.NullValue = null;
            this.planID.DefaultCellStyle = dataGridViewCellStyle3;
            this.planID.FillWeight = 20F;
            this.planID.HeaderText = "ID";
            this.planID.MinimumWidth = 6;
            this.planID.Name = "planID";
            this.planID.ReadOnly = true;
            // 
            // planName
            // 
            this.planName.DataPropertyName = "planName";
            dataGridViewCellStyle4.Format = "N0";
            this.planName.DefaultCellStyle = dataGridViewCellStyle4;
            this.planName.FillWeight = 55F;
            this.planName.HeaderText = "Training Plan Name";
            this.planName.MinimumWidth = 6;
            this.planName.Name = "planName";
            this.planName.ReadOnly = true;
            this.planName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.FillWeight = 30F;
            this.unit.HeaderText = "Unit";
            this.unit.MinimumWidth = 6;
            this.unit.Name = "unit";
            this.unit.ReadOnly = true;
            // 
            // rate
            // 
            this.rate.DataPropertyName = "rate";
            this.rate.FillWeight = 33F;
            this.rate.HeaderText = "Rate";
            this.rate.MinimumWidth = 6;
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            // 
            // Remarks
            // 
            this.Remarks.DataPropertyName = "remarks";
            this.Remarks.FillWeight = 80F;
            this.Remarks.HeaderText = "Remarks";
            this.Remarks.MinimumWidth = 6;
            this.Remarks.Name = "Remarks";
            this.Remarks.ReadOnly = true;
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.BackColor = System.Drawing.Color.Transparent;
            this.unitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.unitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.unitLabel.Location = new System.Drawing.Point(51, 498);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(78, 31);
            this.unitLabel.TabIndex = 68;
            this.unitLabel.Text = "Unit :";
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
            this.clearBtn.Location = new System.Drawing.Point(1678, 160);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.clearBtn.Size = new System.Drawing.Size(204, 64);
            this.clearBtn.TabIndex = 63;
            this.clearBtn.Text = "Clear";
            this.clearBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.clearBtn.UseVisualStyleBackColor = false;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
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
            this.deleteBtn.Location = new System.Drawing.Point(1386, 160);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.deleteBtn.Size = new System.Drawing.Size(204, 64);
            this.deleteBtn.TabIndex = 61;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteBtn.UseVisualStyleBackColor = false;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
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
            this.createBtn.Location = new System.Drawing.Point(801, 160);
            this.createBtn.Name = "createBtn";
            this.createBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.createBtn.Size = new System.Drawing.Size(204, 64);
            this.createBtn.TabIndex = 60;
            this.createBtn.Text = "Create";
            this.createBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.createBtn.UseVisualStyleBackColor = false;
            this.createBtn.Click += new System.EventHandler(this.createBtn_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.nameLabel.Location = new System.Drawing.Point(52, 338);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(267, 31);
            this.nameLabel.TabIndex = 65;
            this.nameLabel.Text = "Training Plan Name :";
            // 
            // tPlanInput
            // 
            this.tPlanInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.tPlanInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tPlanInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.tPlanInput.Location = new System.Drawing.Point(57, 396);
            this.tPlanInput.Multiline = true;
            this.tPlanInput.Name = "tPlanInput";
            this.tPlanInput.Size = new System.Drawing.Size(482, 41);
            this.tPlanInput.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(18)))), ((int)(((byte)(38)))));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2048, 119);
            this.panel1.TabIndex = 59;
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
            this.successLabel.Location = new System.Drawing.Point(1185, 255);
            this.successLabel.Name = "successLabel";
            this.successLabel.Size = new System.Drawing.Size(391, 45);
            this.successLabel.TabIndex = 72;
            this.successLabel.Text = "iconButton2";
            this.successLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.successLabel.UseVisualStyleBackColor = true;
            this.successLabel.Visible = false;
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
            this.errorLabel.Location = new System.Drawing.Point(1188, 255);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(397, 45);
            this.errorLabel.TabIndex = 70;
            this.errorLabel.Text = "iconButton2";
            this.errorLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.errorLabel.UseVisualStyleBackColor = true;
            this.errorLabel.Visible = false;
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
            this.editBtn.Location = new System.Drawing.Point(1094, 160);
            this.editBtn.Name = "editBtn";
            this.editBtn.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.editBtn.Size = new System.Drawing.Size(204, 64);
            this.editBtn.TabIndex = 62;
            this.editBtn.Text = "Edit";
            this.editBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.editBtn.UseVisualStyleBackColor = false;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // remarksInput
            // 
            this.remarksInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.remarksInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.remarksInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.remarksInput.Location = new System.Drawing.Point(56, 813);
            this.remarksInput.Multiline = true;
            this.remarksInput.Name = "remarksInput";
            this.remarksInput.Size = new System.Drawing.Size(481, 333);
            this.remarksInput.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(51, 757);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 31);
            this.label2.TabIndex = 78;
            this.label2.Text = "Remarks :";
            // 
            // unitInput
            // 
            this.unitInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.unitInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.8F);
            this.unitInput.FormattingEnabled = true;
            this.unitInput.Items.AddRange(new object[] {
            "Hourly",
            "Weekly"});
            this.unitInput.Location = new System.Drawing.Point(157, 498);
            this.unitInput.Name = "unitInput";
            this.unitInput.Size = new System.Drawing.Size(382, 37);
            this.unitInput.TabIndex = 76;
            // 
            // trainPlanTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.Controls.Add(this.remarksInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.unitInput);
            this.Controls.Add(this.rateInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tPlanTable);
            this.Controls.Add(this.unitLabel);
            this.Controls.Add(this.clearBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.tPlanInput);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.successLabel);
            this.Name = "trainPlanTab";
            this.Size = new System.Drawing.Size(2048, 1456);
            this.Load += new System.EventHandler(this.trainPlanTab_Load);
            this.Click += new System.EventHandler(this.trainPlanTab_Click);
            ((System.ComponentModel.ISupportInitialize)(this.tPlanTable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox rateInput;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tPlanTable;
        private System.Windows.Forms.Label unitLabel;
        private FontAwesome.Sharp.IconButton clearBtn;
        private FontAwesome.Sharp.IconButton deleteBtn;
        private FontAwesome.Sharp.IconButton createBtn;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox tPlanInput;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton successLabel;
        private FontAwesome.Sharp.IconButton errorLabel;
        private FontAwesome.Sharp.IconButton editBtn;
        private System.Windows.Forms.TextBox remarksInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn planID;
        private System.Windows.Forms.DataGridViewTextBoxColumn planName;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remarks;
        private System.Windows.Forms.ComboBox unitInput;
    }
}
