using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace WindowsFormsApp4
{
    public partial class addFeather : Form
    {
        string connectionString;
        public addFeather()
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

        private void addFeather_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(connectionString))
            {
                MessageBox.Show("اتصال به پایگاه داده برقرار نشد.");
                return;
            }
            using(OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();
                string query = "select onvan from naghsh";
                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    //string s = cmd.ExecuteScalar().ToString();
                    //MessageBox.Show("iii" + cmd.ExecuteScalar().ToString(), "iii");
                    //Naghsh.Items.Add(cmd.ExecuteNonQuery());
                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string role = reader["onvan"].ToString();
                            listView1.Items.Add(role);
                        }
                    }

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OleDbConnection conn = new OleDbConnection(connectionString))
            {
                conn.Open();


                string checkQuery = "SELECT COUNT(*) FROM naghsh WHERE onvan = @onvan";
                using (OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn))
                {
                    checkCmd.Parameters.AddWithValue("@onvan", naghsh.Text);

                    int count = (int)checkCmd.ExecuteScalar();
                    if (count > 0)
                    {
                        MessageBox.Show("نقش تکراری است.", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string query = @"
                              INSERT INTO naghsh ([onvan],[sharh]) 
                              VALUES (@onvan,@sharh)"
                ;

                using (OleDbCommand cmd = new OleDbCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@onvan", naghsh.Text);
                    cmd.Parameters.AddWithValue("@sharh", Sharh.Text);
                    cmd.ExecuteNonQuery();
                }
            }

        }
    }
}
