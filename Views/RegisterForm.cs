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
using MySql.Data.MySqlClient;
using ConstructionApp.Interfaces;
using static ConstructionApp.Services.RegistrationService;

namespace ConstructionApp.Views
{
    public partial class RegisterForm : Form
    {

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



            try
            {
                if (string.IsNullOrWhiteSpace(register_password.Text)
                    || string.IsNullOrWhiteSpace(register_username.Text)
                    || string.IsNullOrWhiteSpace(register_name.Text))
                {
                    MessageBox.Show("Please fill all input fields", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {

                    name = register_name.Text.Trim();
                    username = register_username.Text.Trim();
                    password = register_password.Text;

                    if (RegisterUser(name, username, password))
                    {
                      
                        LoginForm frm = new LoginForm();
                        frm.Show();
                        this.Hide();
                    }
                    else
                    {
                            return;
                    }

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
