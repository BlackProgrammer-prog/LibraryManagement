using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Register : Form
    {
        string connectionString;

        public Register(int a)
        {
            InitializeComponent();
            InitConnection();
        }
        private void InitConnection()
        {
            string databasePath = Path.Combine(Application.StartupPath, "DB1.accdb");
            connectionString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={databasePath};";
        }
        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string fname = txtFname.Text.Trim();
            string family = txtFamily.Text.Trim();
            string pname = txtPname.Text.Trim();
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string mobile = txtMobile.Text.Trim();
            string address = txtAddress.Text.Trim();
            string nationalId = txtNationalId.Text.Trim();
            string age = txtAge.Text;
            string d = Subscription.Text.Trim();




            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                //try
                //{
                    conn.Open();

                    string insertUser = @"INSERT INTO Users 
                    (fname, Family, p_name, Username, [Password], Mobilephone, Age, [Addres], SubscriptionStatus, national_id) 
                    VALUES (?, ?, ?, ?, ?, ?, ?, ?, ?, ?)";

                    OleDbCommand cmdUser = new OleDbCommand(insertUser, conn);
                    cmdUser.Parameters.AddWithValue("?", fname);
                    cmdUser.Parameters.AddWithValue("?", family);
                    cmdUser.Parameters.AddWithValue("?", pname);
                    cmdUser.Parameters.AddWithValue("?", username);
                    cmdUser.Parameters.AddWithValue("?", password);
                    cmdUser.Parameters.AddWithValue("?", mobile);
                    cmdUser.Parameters.AddWithValue("?", Convert.ToInt32(age));
                    cmdUser.Parameters.AddWithValue("?", address);
                    cmdUser.Parameters.AddWithValue("?", d);
                    cmdUser.Parameters.AddWithValue("?", nationalId);

                    cmdUser.ExecuteNonQuery();

                    OleDbCommand getIdCmd = new OleDbCommand("SELECT @@IDENTITY", conn);
                    int userId = Convert.ToInt32(getIdCmd.ExecuteScalar());

                    int studentRoleId = 2; 
                    string insertRel = @"INSERT INTO rel_naghsh (ID_Users, ID_naghsh, start_date ,end_date) VALUES (?, ?, ?,?)";
                    DateTime now = DateTime.Now;
                    DateTime oneYearLater = now.AddYears(1);

                    OleDbCommand cmdRel = new OleDbCommand(insertRel, conn);
                    cmdRel.Parameters.AddWithValue("?", userId.ToString());
                    cmdRel.Parameters.AddWithValue("?", studentRoleId.ToString());
                    cmdRel.Parameters.AddWithValue("?", DateTime.Now.ToShortTimeString());
                    cmdRel.Parameters.AddWithValue("?", oneYearLater.ToShortDateString());

                    cmdRel.ExecuteNonQuery();

                    MessageBox.Show("ثبت‌نام با موفقیت انجام شد.");
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("خطا در ثبت‌نام: " + ex.Message);
                //}
            }
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1 form = new Form1();
            //form.Show();
            
        }
    }
}
