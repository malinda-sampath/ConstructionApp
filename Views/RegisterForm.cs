using ConstructionApp.Models;
using ConstructionApp.Services;
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
    public partial class RegisterForm : Form
    {
        User user = new User();//use if needed for dashbord
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void register_loginBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void register_closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void register_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            register_password.PasswordChar = register_showPassword.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name;
            string password;
            string username;
            DateTime dateRegistered;
            DbManager dbManager = DbManager.Instance;

            try
            {
                if (string.IsNullOrWhiteSpace(register_password.Text)
                    || string.IsNullOrWhiteSpace(register_username.Text)
                    || string.IsNullOrWhiteSpace(register_name.Text))
                {
                    MessageBox.Show("Please fill all input fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                //checking username exists.
                dbManager.OpenConnection();
                string checkquery = "SELECT COUNT(*) FROM [dbo].[users] WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(checkquery, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", register_username.Text.Trim());
                    int usernameCount = (int)cmd.ExecuteScalar();
                    if (usernameCount > 0)
                    {
                        MessageBox.Show("Username already exists. Please choose a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                //use these if needed for user model above
                name = register_name.Text.Trim();
                username = register_username.Text.Trim();
                password = register_password.Text;
                dateRegistered = DateTime.Today;


                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, 13);

                dbManager.OpenConnection();

                string insertquery = "INSERT INTO [dbo].[users] ([name], [username], [password], [date_registered]) " +
                               "VALUES (@name, @username, @password, @dateRegistered)";

                // Create the SqlCommand object
                using (SqlCommand cmd = new SqlCommand(insertquery, dbManager.GetConnection()))
                {
                    // Bind the parameters with actual values
                    cmd.Parameters.AddWithValue("@name", name);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", hashedPassword);
                    cmd.Parameters.AddWithValue("@dateRegistered", dateRegistered);

                    // Execute the command
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoginForm frm = new LoginForm();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
