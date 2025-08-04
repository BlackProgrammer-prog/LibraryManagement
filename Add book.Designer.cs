namespace WindowsFormsApp4
{
    partial class Add_book
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
            this.usersTableAdapter = new WindowsFormsApp4.DB1DataSetTableAdapters.UsersTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB1DataSet = new WindowsFormsApp4.DB1DataSet();
            this.Submit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Subscription = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.NumPhone = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.Famile = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.Naghsh = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.iDUsersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.familyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobilePhoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subscriptionStatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDUsersDataGridViewTextBoxColumn,
            this.fnameDataGridViewTextBoxColumn,
            this.familyDataGridViewTextBoxColumn,
            this.pnameDataGridViewTextBoxColumn,
            this.userNameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.mobilePhoneDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn,
            this.addresDataGridViewTextBoxColumn,
            this.subscriptionStatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 330);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(944, 163);
            this.dataGridView1.TabIndex = 52;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.bindingSource1;
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
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(401, 237);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(110, 48);
            this.Submit.TabIndex = 51;
            this.Submit.Text = "ثبت کاربر";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(798, 133);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 20);
            this.label12.TabIndex = 47;
            this.label12.Text = ":کدام قفسه";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(802, 176);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = ":توضیحات";
            // 
            // Subscription
            // 
            this.Subscription.Location = new System.Drawing.Point(189, 173);
            this.Subscription.Multiline = true;
            this.Subscription.Name = "Subscription";
            this.Subscription.Size = new System.Drawing.Size(604, 34);
            this.Subscription.TabIndex = 45;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 96);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 20);
            this.label10.TabIndex = 44;
            this.label10.Text = ":دسته بندی";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(798, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = ":تعداد کتاب";
            // 
            // Age
            // 
            this.Age.Location = new System.Drawing.Point(549, 93);
            this.Age.Multiline = true;
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(243, 34);
            this.Age.TabIndex = 41;
            // 
            // NumPhone
            // 
            this.NumPhone.Location = new System.Drawing.Point(189, 53);
            this.NumPhone.Multiline = true;
            this.NumPhone.Name = "NumPhone";
            this.NumPhone.Size = new System.Drawing.Size(243, 34);
            this.NumPhone.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(442, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 20);
            this.label8.TabIndex = 39;
            this.label8.Text = ":زمان انتشار";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(549, 53);
            this.Password.Multiline = true;
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(243, 34);
            this.Password.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(802, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 20);
            this.label7.TabIndex = 37;
            this.label7.Text = ":ناشر";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(438, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = ":اسم نویسنده";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(798, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = ":اسم کتاب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(320, -25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = ":نام خانوادگی";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(663, -25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = ":نام";
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(189, 13);
            this.UserName.Multiline = true;
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(243, 34);
            this.UserName.TabIndex = 30;
            // 
            // Fname
            // 
            this.Fname.Location = new System.Drawing.Point(549, 10);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(243, 34);
            this.Fname.TabIndex = 29;
            // 
            // Famile
            // 
            this.Famile.Location = new System.Drawing.Point(113, -28);
            this.Famile.Multiline = true;
            this.Famile.Name = "Famile";
            this.Famile.Size = new System.Drawing.Size(114, 14);
            this.Famile.TabIndex = 28;
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(456, -28);
            this.Name.Multiline = true;
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(114, 14);
            this.Name.TabIndex = 27;
            // 
            // Naghsh
            // 
            this.Naghsh.FormattingEnabled = true;
            this.Naghsh.Location = new System.Drawing.Point(189, 99);
            this.Naghsh.Name = "Naghsh";
            this.Naghsh.Size = new System.Drawing.Size(243, 28);
            this.Naghsh.TabIndex = 53;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(549, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(243, 28);
            this.comboBox1.TabIndex = 54;
            // 
            // iDUsersDataGridViewTextBoxColumn
            // 
            this.iDUsersDataGridViewTextBoxColumn.DataPropertyName = "ID_Users";
            this.iDUsersDataGridViewTextBoxColumn.HeaderText = "ID_ketab";
            this.iDUsersDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.iDUsersDataGridViewTextBoxColumn.Name = "iDUsersDataGridViewTextBoxColumn";
            this.iDUsersDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDUsersDataGridViewTextBoxColumn.Width = 150;
            // 
            // fnameDataGridViewTextBoxColumn
            // 
            this.fnameDataGridViewTextBoxColumn.DataPropertyName = "fname";
            this.fnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.fnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.fnameDataGridViewTextBoxColumn.Name = "fnameDataGridViewTextBoxColumn";
            this.fnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.fnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // familyDataGridViewTextBoxColumn
            // 
            this.familyDataGridViewTextBoxColumn.DataPropertyName = "Family";
            this.familyDataGridViewTextBoxColumn.HeaderText = "Author";
            this.familyDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.familyDataGridViewTextBoxColumn.Name = "familyDataGridViewTextBoxColumn";
            this.familyDataGridViewTextBoxColumn.ReadOnly = true;
            this.familyDataGridViewTextBoxColumn.Width = 150;
            // 
            // pnameDataGridViewTextBoxColumn
            // 
            this.pnameDataGridViewTextBoxColumn.DataPropertyName = "p_name";
            this.pnameDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.pnameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pnameDataGridViewTextBoxColumn.Name = "pnameDataGridViewTextBoxColumn";
            this.pnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.pnameDataGridViewTextBoxColumn.Width = 150;
            // 
            // userNameDataGridViewTextBoxColumn
            // 
            this.userNameDataGridViewTextBoxColumn.DataPropertyName = "UserName";
            this.userNameDataGridViewTextBoxColumn.HeaderText = "Year_of_publication";
            this.userNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.userNameDataGridViewTextBoxColumn.Name = "userNameDataGridViewTextBoxColumn";
            this.userNameDataGridViewTextBoxColumn.ReadOnly = true;
            this.userNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Inventory_number";
            this.passwordDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Width = 150;
            // 
            // mobilePhoneDataGridViewTextBoxColumn
            // 
            this.mobilePhoneDataGridViewTextBoxColumn.DataPropertyName = "MobilePhone";
            this.mobilePhoneDataGridViewTextBoxColumn.HeaderText = "Category";
            this.mobilePhoneDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mobilePhoneDataGridViewTextBoxColumn.Name = "mobilePhoneDataGridViewTextBoxColumn";
            this.mobilePhoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.mobilePhoneDataGridViewTextBoxColumn.Width = 150;
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Image";
            this.ageDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            this.ageDataGridViewTextBoxColumn.ReadOnly = true;
            this.ageDataGridViewTextBoxColumn.Width = 150;
            // 
            // addresDataGridViewTextBoxColumn
            // 
            this.addresDataGridViewTextBoxColumn.DataPropertyName = "Addres";
            this.addresDataGridViewTextBoxColumn.HeaderText = "ShelfLocation";
            this.addresDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.addresDataGridViewTextBoxColumn.Name = "addresDataGridViewTextBoxColumn";
            this.addresDataGridViewTextBoxColumn.ReadOnly = true;
            this.addresDataGridViewTextBoxColumn.Width = 150;
            // 
            // subscriptionStatusDataGridViewTextBoxColumn
            // 
            this.subscriptionStatusDataGridViewTextBoxColumn.DataPropertyName = "SubscriptionStatus";
            this.subscriptionStatusDataGridViewTextBoxColumn.HeaderText = "Description";
            this.subscriptionStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subscriptionStatusDataGridViewTextBoxColumn.Name = "subscriptionStatusDataGridViewTextBoxColumn";
            this.subscriptionStatusDataGridViewTextBoxColumn.ReadOnly = true;
            this.subscriptionStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = ":عکس کتاب";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(133, 29);
            this.button1.TabIndex = 57;
            this.button1.Text = "Input Image";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 504);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Naghsh);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Subscription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.NumPhone);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Fname);
            this.Controls.Add(this.Famile);
            this.Controls.Add(this.Name);
            this.Name = "Add_book";
            this.Text = "Add_book";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DB1DataSet dB1DataSet;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Subscription;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox NumPhone;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.TextBox Fname;
        private System.Windows.Forms.TextBox Famile;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.ComboBox Naghsh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDUsersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn familyDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobilePhoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addresDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subscriptionStatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}