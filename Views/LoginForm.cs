using ConstructionApp.Models;
using ConstructionApp.Repositories;
using ConstructionApp.Services;
using static ConstructionApp.Services.AuthenticationService;
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
using Org.BouncyCastle.Asn1.Cms;

namespace ConstructionApp.Views
{
    public partial class LoginForm : Form
    {
        User user = new User();

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
           

            try
            {
                if (string.IsNullOrWhiteSpace(login_password.Text) || string.IsNullOrWhiteSpace(login_username.Text))
                {
                    MessageBox.Show("Please fill both Username and Password", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                username = login_username.Text.Trim();
                password = login_password.Text;

                if (AuthenticateUserLogging(username, password))
                {
                    //MessageBox.Show("Welcome "+user.Name,"login Success",MessageBoxButtons.OK,MessageBoxIcon.None);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    login_username.Clear();
                    login_password.Clear();
                }




            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
