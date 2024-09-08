using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace ConstructionApp.Views.EmployeeSection
{
    public partial class Overview : UserControl
    {
        public Overview()
        {
            InitializeComponent();

            DateTime todayOnly = DateTime.Today;
            label2.Text = "Total Payroll of " + todayOnly.ToString("MMMM");

            //chart title
            //chart1.Titles.Add("Overview of Total Payroll");
            //chart1.Titles[0].Font = new Font("Segoe UI Emoji", 12, FontStyle.Bold);

            //chart size
            chart1.Width = 600;
            chart1.Height = 400;

            //chart data

            double total = 50000.00;
            double paid = 20000.00;
            double arreas = 30000.00;

            chart1.Series["s1"].Points.AddXY("Rs. " + total, total);
            chart1.Series["s1"].Points.AddXY("Rs. " + paid, paid);
            chart1.Series["s1"].Points.AddXY("Rs. " + arreas, arreas);

            //placeholders for search
            SetPlaceholderText(sitesearchTbox, "Site Name");
            SetPlaceholderText(subsearchTbox, "Sub-Contractor Name");

        }

        // Get the selected date
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

        private void dateenterBtn_Click(object sender, EventArgs e)
        {

        }

        //Reset the date of the datetimepicker
        private void dateresetBtn_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
