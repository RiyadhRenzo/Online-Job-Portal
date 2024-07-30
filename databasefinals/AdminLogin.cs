using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace databasefinals
{
    public partial class AdminLogin : Form
    {
        string mysqlCon = "server=127.0.0.1; port=3307; user=root; database=itep finals;";
        MySqlConnection mySqlConnection;

        public AdminLogin()
        {
            InitializeComponent();
            mySqlConnection = new MySqlConnection(mysqlCon);
            mySqlConnection.Open();
        }

        private void AdminLogin_Load(object sender, EventArgs e)
        {
            // Form initialization code
        }

        private void Login_Click(object sender, EventArgs e)
        {
            string password = txtPassword.Text;

            string query = "SELECT name FROM admin WHERE password = @Password";

            using (MySqlCommand command = new MySqlCommand(query, mySqlConnection))
            {
                command.Parameters.AddWithValue("@Password", password);
                object result = command.ExecuteScalar();

                if (result != null)
                {
                    // IF Password is correct, display the admin's name
                    string adminName = result.ToString();
                    MessageBox.Show($"Welcome, Admin {adminName}!");
                    AdminPage adminPage = new AdminPage();
                    adminPage.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("Invalid password");
                }
            }
        }

        private void AdminLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            mySqlConnection.Close();
        }
        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        }

    }
}

