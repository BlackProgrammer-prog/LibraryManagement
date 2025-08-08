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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dB1DataSet = new WindowsFormsApp4.DB1DataSet();
            this.Submit = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Description = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.NumBook = new System.Windows.Forms.TextBox();
            this.Year_of_publication = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Publisher = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Author = new System.Windows.Forms.TextBox();
            this.nameBook = new System.Windows.Forms.TextBox();
            this.Famile = new System.Windows.Forms.TextBox();
            this.Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Image = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.ShelfLocation = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
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
            this.Submit.Text = "ثبت کتاب";
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
            // Description
            // 
            this.Description.Location = new System.Drawing.Point(189, 173);
            this.Description.Multiline = true;
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(604, 34);
            this.Description.TabIndex = 45;
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
            // NumBook
            // 
            this.NumBook.Location = new System.Drawing.Point(549, 93);
            this.NumBook.Multiline = true;
            this.NumBook.Name = "NumBook";
            this.NumBook.Size = new System.Drawing.Size(243, 34);
            this.NumBook.TabIndex = 41;
            // 
            // Year_of_publication
            // 
            this.Year_of_publication.Location = new System.Drawing.Point(189, 53);
            this.Year_of_publication.Multiline = true;
            this.Year_of_publication.Name = "Year_of_publication";
            this.Year_of_publication.Size = new System.Drawing.Size(243, 34);
            this.Year_of_publication.TabIndex = 40;
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
            // Publisher
            // 
            this.Publisher.Location = new System.Drawing.Point(549, 53);
            this.Publisher.Multiline = true;
            this.Publisher.Name = "Publisher";
            this.Publisher.Size = new System.Drawing.Size(243, 34);
            this.Publisher.TabIndex = 38;
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
            // Author
            // 
            this.Author.Location = new System.Drawing.Point(189, 13);
            this.Author.Multiline = true;
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(243, 34);
            this.Author.TabIndex = 30;
            // 
            // nameBook
            // 
            this.nameBook.Location = new System.Drawing.Point(549, 10);
            this.nameBook.Multiline = true;
            this.nameBook.Name = "nameBook";
            this.nameBook.Size = new System.Drawing.Size(243, 34);
            this.nameBook.TabIndex = 29;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(438, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = ":عکس کتاب";
            // 
            // Image
            // 
            this.Image.Location = new System.Drawing.Point(255, 136);
            this.Image.Name = "Image";
            this.Image.Size = new System.Drawing.Size(133, 29);
            this.Image.TabIndex = 57;
            this.Image.Text = "Input Image";
            this.Image.UseVisualStyleBackColor = true;
            this.Image.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(158, 197);
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // Category
            // 
            this.Category.Location = new System.Drawing.Point(189, 93);
            this.Category.Multiline = true;
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(243, 34);
            this.Category.TabIndex = 59;
            // 
            // ShelfLocation
            // 
            this.ShelfLocation.Location = new System.Drawing.Point(549, 133);
            this.ShelfLocation.Multiline = true;
            this.ShelfLocation.Name = "ShelfLocation";
            this.ShelfLocation.Size = new System.Drawing.Size(243, 34);
            this.ShelfLocation.TabIndex = 60;
            // 
            // Add_book
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 504);
            this.Controls.Add(this.ShelfLocation);
            this.Controls.Add(this.Category);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Image);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.NumBook);
            this.Controls.Add(this.Year_of_publication);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Publisher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.nameBook);
            this.Controls.Add(this.Famile);
            this.Controls.Add(this.Name);
            this.Name = "Add_book";
            this.Text = "Add_book";
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DB1DataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private DB1DataSet dB1DataSet;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Description;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox NumBook;
        private System.Windows.Forms.TextBox Year_of_publication;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Publisher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Author;
        private System.Windows.Forms.TextBox nameBook;
        private System.Windows.Forms.TextBox Famile;
        private System.Windows.Forms.TextBox Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox ShelfLocation;
    }
}