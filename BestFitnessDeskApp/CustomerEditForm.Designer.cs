namespace BestFitnessDeskApp
{
    partial class CustomerEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerEditForm));
            this.closeBtn = new FontAwesome.Sharp.IconButton();
            this.updateBtn = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tWeightInput = new System.Windows.Forms.TextBox();
            this.cWeightInput = new System.Windows.Forms.TextBox();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.phoneInput = new System.Windows.Forms.TextBox();
            this.emailInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.dobInput = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.customerIDInput = new System.Windows.Forms.TextBox();
            this.errorLabel = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // closeBtn
            // 
            this.closeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.closeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBtn.FlatAppearance.BorderSize = 0;
            this.closeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.closeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.closeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closeBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.closeBtn.IconColor = System.Drawing.Color.Black;
            this.closeBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.closeBtn.IconSize = 1;
            this.closeBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.closeBtn.Location = new System.Drawing.Point(561, 806);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(253, 60);
            this.closeBtn.TabIndex = 96;
            this.closeBtn.Text = "CLOSE";
            this.closeBtn.UseVisualStyleBackColor = false;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(65)))), ((int)(((byte)(77)))));
            this.updateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.updateBtn.FlatAppearance.BorderSize = 0;
            this.updateBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(181)))), ((int)(((byte)(71)))));
            this.updateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.updateBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.updateBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.updateBtn.IconColor = System.Drawing.Color.Black;
            this.updateBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.updateBtn.IconSize = 1;
            this.updateBtn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.updateBtn.Location = new System.Drawing.Point(240, 806);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(253, 60);
            this.updateBtn.TabIndex = 90;
            this.updateBtn.Text = "UPDATE";
            this.updateBtn.UseVisualStyleBackColor = false;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label7.Location = new System.Drawing.Point(371, 648);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 17);
            this.label7.TabIndex = 87;
            this.label7.Text = "DOB";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label6.Location = new System.Drawing.Point(555, 527);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 20);
            this.label6.TabIndex = 86;
            this.label6.Text = "TARGET WEIGHT";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label5.Location = new System.Drawing.Point(555, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label4.Location = new System.Drawing.Point(45, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 84;
            this.label4.Text = "PHONE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label3.Location = new System.Drawing.Point(45, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 20);
            this.label3.TabIndex = 83;
            this.label3.Text = "CURRENT WEIGHT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.label2.Location = new System.Drawing.Point(555, 353);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 20);
            this.label2.TabIndex = 82;
            this.label2.Text = "ADDRESS";
            // 
            // tWeightInput
            // 
            this.tWeightInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.tWeightInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tWeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.tWeightInput.ForeColor = System.Drawing.Color.DimGray;
            this.tWeightInput.Location = new System.Drawing.Point(561, 561);
            this.tWeightInput.Multiline = true;
            this.tWeightInput.Name = "tWeightInput";
            this.tWeightInput.Size = new System.Drawing.Size(444, 37);
            this.tWeightInput.TabIndex = 81;
            this.tWeightInput.Click += new System.EventHandler(this.tWeightInput_Click);
            // 
            // cWeightInput
            // 
            this.cWeightInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.cWeightInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cWeightInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.cWeightInput.ForeColor = System.Drawing.Color.DimGray;
            this.cWeightInput.Location = new System.Drawing.Point(49, 561);
            this.cWeightInput.Multiline = true;
            this.cWeightInput.Name = "cWeightInput";
            this.cWeightInput.Size = new System.Drawing.Size(444, 37);
            this.cWeightInput.TabIndex = 80;
            this.cWeightInput.Click += new System.EventHandler(this.cWeightInput_Click);
            // 
            // addressInput
            // 
            this.addressInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.addressInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.addressInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.addressInput.ForeColor = System.Drawing.Color.DimGray;
            this.addressInput.Location = new System.Drawing.Point(561, 388);
            this.addressInput.Multiline = true;
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(444, 40);
            this.addressInput.TabIndex = 79;
            this.addressInput.Click += new System.EventHandler(this.addressInput_Click);
            this.addressInput.TextChanged += new System.EventHandler(this.addressInput_TextChanged);
            // 
            // phoneInput
            // 
            this.phoneInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.phoneInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.phoneInput.ForeColor = System.Drawing.Color.DimGray;
            this.phoneInput.Location = new System.Drawing.Point(49, 388);
            this.phoneInput.Multiline = true;
            this.phoneInput.Name = "phoneInput";
            this.phoneInput.Size = new System.Drawing.Size(444, 40);
            this.phoneInput.TabIndex = 78;
            this.phoneInput.Click += new System.EventHandler(this.phoneInput_Click);
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.emailInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.emailInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.emailInput.ForeColor = System.Drawing.Color.DimGray;
            this.emailInput.Location = new System.Drawing.Point(561, 228);
            this.emailInput.Multiline = true;
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(444, 37);
            this.emailInput.TabIndex = 77;
            this.emailInput.Click += new System.EventHandler(this.emailInput_Click);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.nameLabel.Location = new System.Drawing.Point(45, 193);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(61, 20);
            this.nameLabel.TabIndex = 76;
            this.nameLabel.Text = "NAME";
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(247)))), ((int)(((byte)(252)))));
            this.nameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.nameInput.ForeColor = System.Drawing.Color.DimGray;
            this.nameInput.Location = new System.Drawing.Point(49, 228);
            this.nameInput.Multiline = true;
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(444, 37);
            this.nameInput.TabIndex = 75;
            this.nameInput.Click += new System.EventHandler(this.nameInput_Click);
            this.nameInput.TextChanged += new System.EventHandler(this.nameInput_TextChanged);
            // 
            // dobInput
            // 
            this.dobInput.BackColor = System.Drawing.Color.Transparent;
            this.dobInput.BorderRadius = 15;
            this.dobInput.Checked = true;
            this.dobInput.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.dobInput.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.dobInput.ForeColor = System.Drawing.Color.Black;
            this.dobInput.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dobInput.Location = new System.Drawing.Point(359, 668);
            this.dobInput.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dobInput.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dobInput.Name = "dobInput";
            this.dobInput.Size = new System.Drawing.Size(332, 68);
            this.dobInput.TabIndex = 88;
            this.dobInput.Value = new System.DateTime(2023, 4, 19, 10, 50, 1, 692);
            // 
            // customerIDInput
            // 
            this.customerIDInput.Location = new System.Drawing.Point(49, 49);
            this.customerIDInput.Name = "customerIDInput";
            this.customerIDInput.Size = new System.Drawing.Size(100, 22);
            this.customerIDInput.TabIndex = 99;
            this.customerIDInput.Visible = false;
            // 
            // errorLabel
            // 
            this.errorLabel.FlatAppearance.BorderSize = 0;
            this.errorLabel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.errorLabel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.errorLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.errorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.IconChar = FontAwesome.Sharp.IconChar.Warning;
            this.errorLabel.IconColor = System.Drawing.Color.Red;
            this.errorLabel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.errorLabel.IconSize = 28;
            this.errorLabel.Location = new System.Drawing.Point(359, 49);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(442, 45);
            this.errorLabel.TabIndex = 97;
            this.errorLabel.Text = "iconButton2";
            this.errorLabel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.errorLabel.UseVisualStyleBackColor = true;
            this.errorLabel.Visible = false;
            // 
            // CustomerEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1042, 940);
            this.Controls.Add(this.customerIDInput);
            this.Controls.Add(this.closeBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.dobInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tWeightInput);
            this.Controls.Add(this.cWeightInput);
            this.Controls.Add(this.addressInput);
            this.Controls.Add(this.phoneInput);
            this.Controls.Add(this.emailInput);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.errorLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CustomerEditForm";
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.CustomerEditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconButton closeBtn;
        private FontAwesome.Sharp.IconButton updateBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tWeightInput;
        private System.Windows.Forms.TextBox cWeightInput;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.TextBox phoneInput;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameInput;
        private Guna.UI2.WinForms.Guna2DateTimePicker dobInput;
        private System.Windows.Forms.TextBox customerIDInput;
        private FontAwesome.Sharp.IconButton errorLabel;
    }
}