using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class Add_book : Form
    {
        string connectionString;
        string pathFile;
        public Add_book()
        {
            InitializeComponent();
            InitConnection();


        }

        private void InitConnection()
        {
            string databasePath = Path.Combine(Application.StartupPath, "DB1.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(nameBook.Text) ||
                string.IsNullOrWhiteSpace(Author.Text) ||
                string.IsNullOrWhiteSpace(Publisher.Text) ||
                string.IsNullOrWhiteSpace(Description.Text) ||
                string.IsNullOrWhiteSpace(Year_of_publication.Text) ||
                string.IsNullOrWhiteSpace(Category.Text) ||
                string.IsNullOrWhiteSpace(ShelfLocation.Text) ||
                string.IsNullOrWhiteSpace(NumBook.Text) ||
                pictureBox1.Image == null)
            {
                MessageBox.Show("لطفاً تمام فیلدها را پر کنید و عکس را انتخاب کنید.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                DateTime date = DateTime.Parse(Year_of_publication.Text);
                string Name = nameBook.Text.Trim();
                string author = Author.Text.Trim();
                string publisher = Publisher.Text.Trim();
                string description = Description.Text.Trim();
                string category = Category.Text.Trim();
                string shelfLocation = ShelfLocation.Text.Trim();
                int num = Convert.ToInt32(NumBook.Text);

                byte[] imageBytes = File.ReadAllBytes(pathFile);


                //using (MemoryStream ms = new MemoryStream())
                //{
                //    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
                //    imageBytes = ms.ToArray();
                //}

                using (OleDbConnection conn = new OleDbConnection(connectionString))
                {
                    conn.Open();

                    string insertUser = @"INSERT INTO ketab 
([Name], [Author], [Publisher], [Year_of_publication], [Inventory_number], [Category], [Image], [ShelfLocation], [Description]) 
VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    OleDbCommand cmdUser = new OleDbCommand(insertUser, conn);
                    cmdUser.Parameters.AddWithValue("?", Name);
                    cmdUser.Parameters.AddWithValue("?", author);
                    cmdUser.Parameters.AddWithValue("?", publisher);
                    cmdUser.Parameters.AddWithValue("?", date.ToShortTimeString());
                    cmdUser.Parameters.AddWithValue("?", num);
                    cmdUser.Parameters.AddWithValue("?", category);
                cmdUser.Parameters.AddWithValue("?", imageBytes);
                //cmdUser.Parameters.Add("?", OleDbType.Binary).Value = imageBytes;
                cmdUser.Parameters.AddWithValue("?", shelfLocation);
                    cmdUser.Parameters.AddWithValue("?", description);

                    cmdUser.ExecuteNonQuery();
                }

                MessageBox.Show("کتاب با موفقیت اضافه شد.", "موفق", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در افزودن کتاب: " + ex.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "(*.jpg;*.jpeg;*.png; *.bmp)| *.jpg; *.jpeg; *.png; *.bmp";
            if (op.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = System.Drawing.Image.FromFile(op.FileName);
                pathFile = op.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

            
            }
        }
}
