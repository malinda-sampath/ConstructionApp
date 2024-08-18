using ConstructionApp.Models;
using ConstructionApp.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ConstructionApp.Views
{
    public partial class LoginForm : Form
    {
        User user=new User();

        public LoginForm()
        {
            InitializeComponent();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password;
            string username;
            DbManager dbManager = DbManager.Instance;

            try
            {
                if (string.IsNullOrWhiteSpace(login_password.Text) || string.IsNullOrWhiteSpace(login_username.Text))
                {
                    MessageBox.Show("Please fill both Username and Password", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                username = login_username.Text.Trim();
                password = login_password.Text;

                dbManager.OpenConnection();

                string query = "SELECT name, username, password FROM users WHERE username = @username";

                using (SqlCommand cmd = new SqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (SqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        if (sqlDataReader.Read()) // Move to the first record
                        {
                            user.Name = sqlDataReader["name"].ToString();
                            user.Username = sqlDataReader["username"].ToString();
                            user.HashedPassword = sqlDataReader["password"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, user.HashedPassword))
                            {
                                MessageBox.Show("Welcome "+user.Name,"login Success",MessageBoxButtons.OK,MessageBoxIcon.None);
                                Dashboard frm = new Dashboard();
                                frm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                login_username.Clear();
                                login_password.Clear();
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            login_username.Clear();
                            login_password.Clear();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }


        private void login_registerBtn_Click(object sender, EventArgs e)
        {
            RegisterForm frm = new RegisterForm();
            frm.Show();
            this.Hide();
        }

        private void login_showPassword_Click(object sender, EventArgs e)
        {
        }

        private void login_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            login_password.PasswordChar = login_showPassword.Checked ? '\0' : '*';
        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
