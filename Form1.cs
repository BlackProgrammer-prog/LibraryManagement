using System;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        string connectionString;

        public Form1()
        {
            InitializeComponent();
            InitDatabaseConnection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show("اتصال به پایگاه داده برقرار نشد.");
                return;
            }

            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = @"
                        SELECT naghsh.onvan 
                        FROM (Users 
                        INNER JOIN rel_naghsh ON Users.ID_Users = rel_naghsh.ID_Users)
                        INNER JOIN naghsh ON rel_naghsh.ID_naghsh = naghsh.ID_naghsh
                        WHERE Users.Username = @user AND Users.Password = @pass";
                    //string query = @"
                    //    SELECT count(*) 
                    //    FROM Users where Username = @user AND Password = @pass";

                    using (OleDbCommand cmd = new OleDbCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@user", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@pass", textBox2.Text.Trim());

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string role = result.ToString().ToLower();

                            if (role == "modir" || role == "admin")
                            {
                                //MessageBox.Show("خوش آمدید مدیر محترم.");
                                ManagerForm mf = new ManagerForm();
                                mf.Show();
                                this.Hide();
                            }
                            else if (role == "daneshjoo" || role == "student")
                            {
                                //MessageBox.Show("ورود موفقیت‌آمیز به عنوان دانشجو.");
                                StudentForm sf = new StudentForm();
                                sf.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("نقش شناسایی نشد: " + role);
                            }
                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("خطا در ورود: " + ex.Message);
                }
            }
        }

        private void InitDatabaseConnection()
        {
            string databasePath = Path.Combine(Application.StartupPath, "DB1.accdb");

            string ace = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";
            string jet = $"Provider=Microsoft.JET.OLEDB.4.0;Data Source={databasePath};";

            if (TestConnection(ace))
            {
                connectionString = ace;
            }
            else if (TestConnection(jet))
            {
                connectionString = jet;
            }
            else
            {
                MessageBox.Show("عدم توانایی در اتصال به دیتابیس. لطفاً Microsoft Access Database Engine را نصب کنید.");
            }
        }

        private bool TestConnection(string connStr)
        {
            try
            {
                using (OleDbConnection conn = new OleDbConnection(connStr))
                {
                    conn.Open();
                    conn.Close();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
            this.Hide();
        }
    }
}