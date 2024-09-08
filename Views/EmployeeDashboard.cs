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
    public partial class EmployeeDashboard : UserControl
    {
        public EmployeeDashboard()
        {
            InitializeComponent();

            //Onclick color
            overviewBtn.BackColor = Color.LightBlue;
            employeeBtn.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;

            //Onclick size
            overviewBtn.Size = new Size(189, 44);
            employeeBtn.Size = new Size(185, 40);
            button2.Size = new Size(185, 40);

            //Onclick location
            overviewBtn.Location = new Point(602, 18);
            employeeBtn.Location = new Point(820, 20);
            button2.Location = new Point(1036, 20);
        }

        private void overviewBtn_Click(object sender, EventArgs e)
        {
            overview1.Visible = true;
            employee1.Visible = false;
            payroll1.Visible = false;

            //Onclick color
            overviewBtn.BackColor = Color.LightBlue;
            employeeBtn.BackColor = Color.Transparent;
            button2.BackColor = Color.Transparent;

            //Onclick size
            overviewBtn.Size = new Size(189, 44);
            employeeBtn.Size = new Size(185, 40);
            button2.Size = new Size(185, 40);

            //Onclick location
            overviewBtn.Location = new Point(602, 18);
            employeeBtn.Location = new Point(820, 20);
            button2.Location = new Point(1036, 20);
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            overview1.Visible = false;
            employee1.Visible = true;
            payroll1.Visible = false;

            //Onclick color
            overviewBtn.BackColor = Color.Transparent;
            employeeBtn.BackColor = Color.LightBlue;
            button2.BackColor = Color.Transparent;

            //Onclick size
            overviewBtn.Size = new Size(185, 40);
            employeeBtn.Size = new Size(189, 44);
            button2.Size = new Size(185, 40);

            //Onclick location
            overviewBtn.Location = new Point(604, 20);
            employeeBtn.Location = new Point(818, 18);
            button2.Location = new Point(1036, 20);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            overview1.Visible = false;
            employee1.Visible = false;
            payroll1.Visible = true;

            //Onclick color
            overviewBtn.BackColor = Color.Transparent;
            employeeBtn.BackColor = Color.Transparent;
            button2.BackColor = Color.LightBlue;

            //Onclick size
            overviewBtn.Size = new Size(185, 40);
            employeeBtn.Size = new Size(185, 40);
            button2.Size = new Size(189, 44);

            //Onclick location
            overviewBtn.Location = new Point(604, 20);
            employeeBtn.Location = new Point(820, 20);
            button2.Location = new Point(1034, 18);
        }
    }
}
