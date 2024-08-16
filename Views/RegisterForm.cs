using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
