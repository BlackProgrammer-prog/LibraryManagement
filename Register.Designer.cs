namespace WindowsFormsApp4
{
    partial class Register
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
            this.Submit = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.Subscription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNationalId = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPname = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(303, 314);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(155, 48);
            this.Submit.TabIndex = 50;
            this.Submit.Text = "ثبت کاربر";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(641, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 45;
            this.label11.Text = ":توضیحات";
            // 
            // Subscription
            // 
            this.Subscription.Location = new System.Drawing.Point(91, 251);
            this.Subscription.Multiline = true;
            this.Subscription.Name = "Subscription";
            this.Subscription.Size = new System.Drawing.Size(544, 34);
            this.Subscription.TabIndex = 44;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 43;
            this.label10.Text = ":کد ملی";
            // 
            // txtNationalId
            // 
            this.txtNationalId.Location = new System.Drawing.Point(91, 170);
            this.txtNationalId.Multiline = true;
            this.txtNationalId.Name = "txtNationalId";
            this.txtNationalId.Size = new System.Drawing.Size(201, 34);
            this.txtNationalId.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(641, 173);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 41;
            this.label9.Text = ":سن";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(434, 170);
            this.txtAge.Multiline = true;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(201, 34);
            this.txtAge.TabIndex = 40;
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(91, 130);
            this.txtMobile.Multiline = true;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(201, 34);
            this.txtMobile.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = ":شماره موبایل";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(434, 130);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 34);
            this.txtPassword.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(645, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = ":رمز عبور";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(641, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = ":آدرس";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(91, 211);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(544, 34);
            this.txtAddress.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(298, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 33;
            this.label5.Text = ":نام کاربری";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(641, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 32;
            this.label4.Text = ":اسم پدر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = ":نام خانوادگی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(641, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = ":نام";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(91, 90);
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 34);
            this.txtUsername.TabIndex = 29;
            // 
            // txtPname
            // 
            this.txtPname.Location = new System.Drawing.Point(434, 87);
            this.txtPname.Multiline = true;
            this.txtPname.Name = "txtPname";
            this.txtPname.Size = new System.Drawing.Size(201, 34);
            this.txtPname.TabIndex = 28;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(91, 50);
            this.txtFamily.Multiline = true;
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(201, 34);
            this.txtFamily.TabIndex = 27;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(434, 50);
            this.txtFname.Multiline = true;
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(201, 34);
            this.txtFname.TabIndex = 26;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Subscription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtNationalId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.txtPname);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.txtFname);
            this.Name = "Register";
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Subscription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNationalId;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.TextBox txtPname;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.TextBox txtFname;
    }
}