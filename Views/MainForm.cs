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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("Are you sure want to logout?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            sites1.Visible = false;
            employeeDashboard1.Visible = false;
            office1.Visible = false;
            vehicleForm1.Visible = false;
        }

        private void vehiclesBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            sites1.Visible = false;
            employeeDashboard1.Visible = false;
            office1.Visible = false;
            vehicleForm1.Visible = true;
        }

        private void sitesBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            sites1.Visible = true;
            employeeDashboard1.Visible = false;
            office1.Visible = false;
            vehicleForm1.Visible = false;
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            sites1.Visible = false;
            employeeDashboard1.Visible = true;
            office1.Visible = false;
            vehicleForm1.Visible = false;
        }

        private void officeBtn_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            sites1.Visible = false;
            employeeDashboard1.Visible = false;
            office1.Visible = true;
            vehicleForm1.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
