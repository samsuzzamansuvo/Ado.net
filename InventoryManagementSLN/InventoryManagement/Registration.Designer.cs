namespace InventoryManagement
{
    partial class Registration
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
            this.pictureBoxRegistrtion = new System.Windows.Forms.PictureBox();
            this.pannelRegistration = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.Label();
            this.txtUsernames = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.lblRegisterHere = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrtion)).BeginInit();
            this.pannelRegistration.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxRegistrtion
            // 
            this.pictureBoxRegistrtion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRegistrtion.Image = global::InventoryManagement.Properties.Resources.login;
            this.pictureBoxRegistrtion.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRegistrtion.Name = "pictureBoxRegistrtion";
            this.pictureBoxRegistrtion.Size = new System.Drawing.Size(866, 531);
            this.pictureBoxRegistrtion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRegistrtion.TabIndex = 0;
            this.pictureBoxRegistrtion.TabStop = false;
            // 
            // pannelRegistration
            // 
            this.pannelRegistration.BackColor = System.Drawing.Color.LightGreen;
            this.pannelRegistration.Controls.Add(this.btnBack);
            this.pannelRegistration.Controls.Add(this.btnRegister);
            this.pannelRegistration.Controls.Add(this.panel2);
            this.pannelRegistration.Controls.Add(this.lblConfirmPassword);
            this.pannelRegistration.Controls.Add(this.txtConfirmPassword);
            this.pannelRegistration.Controls.Add(this.label6);
            this.pannelRegistration.Controls.Add(this.txtPassword);
            this.pannelRegistration.Controls.Add(this.txtUsername);
            this.pannelRegistration.Controls.Add(this.txtUsernames);
            this.pannelRegistration.Controls.Add(this.lblPhone);
            this.pannelRegistration.Controls.Add(this.txtPhone);
            this.pannelRegistration.Controls.Add(this.lblAddress);
            this.pannelRegistration.Controls.Add(this.txtAddress);
            this.pannelRegistration.Controls.Add(this.label2);
            this.pannelRegistration.Controls.Add(this.txtLastname);
            this.pannelRegistration.Controls.Add(this.lblFirstName);
            this.pannelRegistration.Controls.Add(this.txtFirstname);
            this.pannelRegistration.Controls.Add(this.lblRegisterHere);
            this.pannelRegistration.Location = new System.Drawing.Point(376, 0);
            this.pannelRegistration.Name = "pannelRegistration";
            this.pannelRegistration.Size = new System.Drawing.Size(405, 519);
            this.pannelRegistration.TabIndex = 1;
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(191, 453);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(89, 30);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(24, 258);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 47);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remember this:";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPassword.Location = new System.Drawing.Point(112, 405);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(125, 19);
            this.lblConfirmPassword.TabIndex = 2;
            this.lblConfirmPassword.Text = "ConfirmPassword:";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(117, 427);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(163, 20);
            this.txtConfirmPassword.TabIndex = 1;
            this.txtConfirmPassword.Text = "Confirm Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(115, 358);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(117, 380);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(163, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.Text = "Password";
            // 
            // txtUsername
            // 
            this.txtUsername.AutoSize = true;
            this.txtUsername.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(115, 312);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(81, 19);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.Text = "UserName:";
            // 
            // txtUsernames
            // 
            this.txtUsernames.Location = new System.Drawing.Point(117, 334);
            this.txtUsernames.Name = "txtUsernames";
            this.txtUsernames.Size = new System.Drawing.Size(163, 20);
            this.txtUsernames.TabIndex = 1;
            this.txtUsernames.Text = "User Name";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhone.Location = new System.Drawing.Point(116, 199);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(71, 19);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "PhoneNo:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(117, 221);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(163, 20);
            this.txtPhone.TabIndex = 1;
            this.txtPhone.Text = "PhoneNo";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(117, 152);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(65, 19);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Address:";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(117, 175);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(163, 20);
            this.txtAddress.TabIndex = 1;
            this.txtAddress.Text = "Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(117, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "LastName:";
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(117, 129);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(163, 20);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstName.Location = new System.Drawing.Point(113, 61);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(79, 19);
            this.lblFirstName.TabIndex = 2;
            this.lblFirstName.Text = "FirstName:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(117, 83);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(163, 20);
            this.txtFirstname.TabIndex = 1;
            this.txtFirstname.Text = "First Name";
            // 
            // lblRegisterHere
            // 
            this.lblRegisterHere.AutoSize = true;
            this.lblRegisterHere.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegisterHere.Location = new System.Drawing.Point(98, 9);
            this.lblRegisterHere.Name = "lblRegisterHere";
            this.lblRegisterHere.Size = new System.Drawing.Size(213, 39);
            this.lblRegisterHere.TabIndex = 0;
            this.lblRegisterHere.Text = "Register Here";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(116, 453);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(69, 30);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 531);
            this.Controls.Add(this.pannelRegistration);
            this.Controls.Add(this.pictureBoxRegistrtion);
            this.Name = "Registration";
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Registration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRegistrtion)).EndInit();
            this.pannelRegistration.ResumeLayout(false);
            this.pannelRegistration.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxRegistrtion;
        private System.Windows.Forms.Panel pannelRegistration;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label txtUsername;
        private System.Windows.Forms.TextBox txtUsernames;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.Label lblRegisterHere;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}