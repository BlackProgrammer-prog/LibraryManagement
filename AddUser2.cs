using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Data;
using System.Globalization;
using System.Security.Cryptography;

namespace WindowsFormsApp4
{
    public partial class AddUser2 : Form
    {
        string connectionString;

        public AddUser2()
        {
            InitializeComponent();
            InitDatabaseConnection();
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
        static string AddDaysToPersianDate(int daysToAdd)
        {
            DateTime today = DateTime.Now;
            DateTime newDate = today.AddDays(daysToAdd);

            PersianCalendar pc = new PersianCalendar();
            int year = pc.GetYear(newDate);
            int month = pc.GetMonth(newDate);
            int day = pc.GetDayOfMonth(newDate);

            return $"{year:0000}/{month:00}/{day:00}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(AddDaysToPersianDate(Convert.ToInt32(Time.Text)));
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();


                string checkQuery = "SELECT COUNT(*) FROM Users WHERE national_id = @national_id OR MobilePhone = @MobilePhone";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@national_id", National.Text);
                    checkCmd.Parameters.AddWithValue("@MobilePhone", NumPhone.Text);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("کاربری با این کد ملی یا شماره موبایل قبلاً ثبت شده است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"
                              INSERT INTO Users ([fname], [Family], [p_name], [UserName], [Password], 
                              [MobilePhone], [Age], [Addres], [SubscriptionStatus], [national_id])
                              VALUES (@fname, @Family, @p_name, @UserName, @Password, 
                              @MobilePhone, @Age, @Addres, @SubscriptionStatus, @national_id)";

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@fname", Name.Text);
                    cmd.Parameters.AddWithValue("@Family", Famile.Text);
                    cmd.Parameters.AddWithValue("@p_name", Fname.Text);
                    cmd.Parameters.AddWithValue("@UserName", UserName.Text);
                    cmd.Parameters.AddWithValue("@Password", Password.Text);
                    cmd.Parameters.AddWithValue("@MobilePhone", NumPhone.Text);
                    cmd.Parameters.AddWithValue("@Age", Convert.ToInt32(Age.Text));
                    cmd.Parameters.AddWithValue("@Addres", Address.Text);
                    cmd.Parameters.AddWithValue("@SubscriptionStatus", Subscription.Text);
                    cmd.Parameters.AddWithValue("@national_id", National.Text);
                    cmd.ExecuteNonQuery();


                    OleDbCommand idcmd = new OleDbCommand("select @@IDENTITY", conn);

                    int iduser = Convert.ToInt32(idcmd.ExecuteScalar());
                    string test12 = idcmd.ExecuteScalar().ToString();

                    string query2 = @"
                              INSERT INTO rel_naghsh ([ID_Users], [ID_naghsh], [start_date], [end_date])
                              VALUES (@ID_Users, @ID_naghsh, @start_date, @end_date)";
                    try
                    {
                        using (OleDbCommand cmd2 = new OleDbCommand(query2, conn))
                        {
                            cmd2.Parameters.AddWithValue("@ID_Users", test12);
                            cmd2.Parameters.AddWithValue("@ID_naghsh", Naghsh.SelectedValue.ToString());
                            cmd2.Parameters.AddWithValue("@start_date", DateTime.Now.ToShortDateString());
                            cmd2.Parameters.AddWithValue("@end_date", DateTime.Now.ToShortDateString());// Convert.ToDateTime(AddDaysToPersianDate(Convert.ToInt32(Time.Text))));
                            cmd2.ExecuteNonQuery();
                            MessageBox.Show("ok","ok");
                        }
                    }
                    catch (Exception ex)
                    {
                        string qurey3 = "delete Users where ID_Users = @ID_Users";

                        MessageBox.Show("khata" + ex.Message.ToString(), "khata");

                        using(OleDbCommand cmd3 = new OleDbCommand(qurey3, conn))
                        {
                            cmd3.Parameters.AddWithValue("@ID_Users", test12);
                            cmd3.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void AddUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB1DataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.dB1DataSet.Users);
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show("اتصال به پایگاه داده برقرار نشد.");
                return;
            }
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "select onvan,id_naghsh from naghsh";

                OleDbDataAdapter adapter = new OleDbDataAdapter(query,conn);

                DataTable dt = new DataTable();
                adapter.Fill(dt);

                Naghsh.DataSource = dt;
                Naghsh.DisplayMember = "onvan";
                Naghsh.ValueMember = "id_naghsh";
                
                //MessageBox.Show("s"+Naghsh.SelectedValue.ToString(), "");

                //using (OleDbCommand cmd = new OleDbCommand(query, conn))
                //{
                //    //string s = cmd.ExecuteScalar().ToString();
                //    //MessageBox.Show("iii" + cmd.ExecuteScalar().ToString(), "iii");
                //    //Naghsh.Items.Add(cmd.ExecuteNonQuery());
                //    using (OleDbDataReader reader = cmd.ExecuteReader())
                //    {
                //        while (reader.Read()) 
                //        {
                //            string role = reader["onvan"].ToString();
                //            string id_naghsh = reader["id_naghsh"].ToString();
                //            Naghsh.Items.Add(role);
                //            Naghsh.Items.Add(id_naghsh);
                //        }
                //    }
                    
                //}
            }
        }

        private void NumPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Name_Leave(object sender, EventArgs e)
        {
            //if(!string.IsNullOrEmpty(Name.Text))
            //usersBindingSource.Filter = "ID_Users = " + Name.Text  ;
            //dataGridView1.Refresh();
        }

        private void Naghsh_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
