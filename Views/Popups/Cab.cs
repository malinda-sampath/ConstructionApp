using ConstructionApp.Models;
using ConstructionApp.Services;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConstructionApp.Views.Popups
{
    public partial class Cab : Form
    {
        Vehical cab = new();
        public Cab()
        {
            InitializeComponent();

         
            cab.FuelType = "Diesel";
            cab.NumberPlate = "ABC-1234";
        }



        private void cabUpdateBtn_Click(object sender, EventArgs e)
        {
          

            try
            {
                DbManager dbManager = DbManager.Instance;
                dbManager.OpenConnection();

                SqlDateTime insRenewDate = cabNewInsurance.Value;
                SqlDateTime licRenewDate = cabNewLicense.Value;

                cabInsurance.Text = DateOnly.Parse(insRenewDate.ToString()).ToString();
                cabLicense.Text = DateOnly.Parse(licRenewDate.ToString()).ToString();

                string sql = "";
                using (SqlCommand cmd = new SqlCommand(sql, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@insRenewDate", insRenewDate);
                    cmd.Parameters.AddWithValue("@licRenewDate", licRenewDate);
                }



            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
