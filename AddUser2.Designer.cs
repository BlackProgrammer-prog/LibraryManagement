namespace WindowsFormsApp4
{
    partial class AddUser2
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
            this.components = new System.ComponentModel.Container();
            this.Name = new System.Windows.Forms.TextBox();
            this.Famile = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.NumPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.National = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Subscription = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB1DataSet = new WindowsFormsApp4.DB1DataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new WindowsFormsApp4.DB1DataSetTableAdapters.UsersTableAdapter();
            this.Time = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Naghsh = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(587, 61);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(201, 34);
            this.Name.TabIndex = 1;
            this.Name.Leave += new System.EventHandler(this.Name_Leave);
            // 
            // Famile
            // 
            this.Famile.Location = new System.Drawing.Point(244, 61);
            this.Famile.Multiline = true;
            this.Famile.Name = "Famile";
            this.Famile.Size = new System.Drawing.Size(201, 34);
            this.Famile.TabIndex = 2;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(587, 98);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(201, 34);
            this.Fname.TabIndex = 3;
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(244, 101);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(201, 34);
            this.UserName.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(794, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = ":نام";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = ":نام خانوادگی";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(794, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = ":اسم پدر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(451, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = ":نام کاربری";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(794, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = ":آدرس";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(244, 225);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(544, 34);
            this.Address.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(798, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = ":رمز عبور";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(587, 141);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(201, 34);
            this.Password.TabIndex = 12;
            // 
            // NumPhone
            // 
            this.NumPhone.Location = new System.Drawing.Point(244, 141);
            this.NumPhone.Multiline = true;
            this.NumPhone.Name = "NumPhone";
            this.NumPhone.Size = new System.Drawing.Size(201, 34);
            this.NumPhone.TabIndex = 14;
            this.NumPhone.TextChanged += new System.EventHandler(this.NumPhone_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(455, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = ":شماره موبایل";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(794, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = ":سن";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(587, 181);
            this.Age.Multiline = true;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(201, 34);
            this.Age.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(451, 184);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 20);
            this.label10.TabIndex = 18;
            this.label10.Text = ":کد ملی";
            // 
            // National
            // 
            this.National.Location = new System.Drawing.Point(244, 181);
            this.National.Multiline = true;
            this.National.Name = "National";
            this.National.Size = new System.Drawing.Size(201, 34);
            this.National.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(794, 268);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 20;
            this.label11.Text = ":توضیحات";
            // 
            // Subscription
            // 
            this.Subscription.Location = new System.Drawing.Point(244, 265);
            this.Subscription.Multiline = true;
            this.Subscription.Name = "Subscription";
            this.Subscription.Size = new System.Drawing.Size(544, 34);
            this.Subscription.TabIndex = 19;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(455, 364);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(155, 48);
            this.Submit.TabIndex = 25;
            this.Submit.Text = "ثبت کاربر";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dB1DataSet;
            this.bindingSource1.Position = 0;
            // 
            // dB1DataSet
            // 
            this.dB1DataSet.DataSetName = "DB1DataSet";
            this.dB1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.bindingSource1;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // Time
            // 
            this.Time.Location = new System.Drawing.Point(244, 305);
            this.Time.Multiline = true;
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(201, 34);
            this.Time.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(451, 313);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 20);
            this.label13.TabIndex = 29;
            this.label13.Text = ":مدت زمان اشتراک";
            // 
            // Naghsh
            // 
            this.Naghsh.FormattingEnabled = true;
            this.Naghsh.Location = new System.Drawing.Point(587, 305);
            this.Naghsh.Name = "Naghsh";
            this.Naghsh.Size = new System.Drawing.Size(201, 28);
            this.Naghsh.TabIndex = 28;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(794, 305);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = ":نقش";
            // 
            // AddUser2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1036, 605);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Naghsh);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Subscription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.National);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NumPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Famile);
            this.Controls.Add(this.Name);
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "افزودن کاربر";
            this.Load += new System.EventHandler(this.AddUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.TextBox Famile;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.TextBox NumPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox National;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Subscription;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DB1DataSet dB1DataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DB1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.TextBox Time;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox Naghsh;
        private System.Windows.Forms.Label label12;
    }
}