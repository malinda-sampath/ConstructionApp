using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConstructionApp.Views.EmployeeSection
{
    public partial class Payroll : UserControl
    {
        public Payroll()
        {
            InitializeComponent();
            // placeholders for search
            SetPlaceholderText(textBox9, "Site Name");
            SetPlaceholderText(textBox8, "Sub-Contractor Name");

            // set the initial date to the label
            DateTime todayOnly = DateTime.Today;
            salarydetailsLabel.Text = "Salary Details of " + todayOnly.ToString("yyyy-MM-dd");
            summaryLabel.Text = "Summary of " + todayOnly.ToString("yyyy-MM-dd");
        }

        //To get selected date
        private string GetSelectedDate()
        {
            DateTime selectedDate = dateTimePicker1.Value;
            string formattedDate = selectedDate.ToString("yyyy-MM-dd");
            return formattedDate;
        }

        // Method to add placeholder functionality
        private void SetPlaceholderText(TextBox textBox, string placeholder)
        {
            textBox.Text = placeholder;
            textBox.ForeColor = Color.Gray;

            textBox.Enter += (sender, e) =>
            {
                if (textBox.Text == placeholder)
                {
                    textBox.Text = "";
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.Leave += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    textBox.Text = placeholder;
                    textBox.ForeColor = Color.Gray;
                }
            };
        }

        private void Payroll_Load(object sender, EventArgs e)
        {

        }

        //Get the selected date to the lable
        private void button7_Click(object sender, EventArgs e)
        {
            salarydetailsLabel.Text = "Salary Details of " + GetSelectedDate();
            summaryLabel.Text = "Summary of " + GetSelectedDate();
        }

        //Reset the date value
        private void dateresetBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            salarydetailsLabel.Text = "Salary Details of " + GetSelectedDate();
            summaryLabel.Text = "Summary of " + GetSelectedDate();
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}
