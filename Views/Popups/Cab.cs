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

            updateComponets();
        }

        private void updateComponets()
        {
            DbManager dbManager = DbManager.Instance;
            try
            {
                // Open the connection to the database
                dbManager.OpenConnection();

                string selectQuery = "SELECT * FROM [dbo].[vehical] WHERE regNo = @regNo";

                using (SqlCommand cmd = new SqlCommand(selectQuery, dbManager.GetConnection()))
                {
                    // Add the parameter for the vehicle registration number
                    cmd.Parameters.AddWithValue("@regNo", cab.RegNo);

                    // Execute the query and read the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any row is returned
                        if (reader.Read())
                        {

                            cab.NumberPlate = reader.GetString(reader.GetOrdinal("number_plate"));
                            cab.FuelType = reader.GetString(reader.GetOrdinal("fuel_type"));
                            cab.LicRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("license_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("license_renew_date")));
                            cab.InsuranceRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("insurance_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("insurance_renew_date")));
                            cab.Model = reader.GetString(reader.GetOrdinal("model"));



                        }
                        else
                        {
                            MessageBox.Show("error loading database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    cabInsurance.Text = cab.InsuranceRenewDate.Date.ToString();
                    cabLicense.Text = cab.LicRenewDate.Date.ToString();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "fetching Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

        private void cabUpdateBtn_Click(object sender, EventArgs e)
        {
            DbManager dbManager = DbManager.Instance;
            try
            {
                dbManager.OpenConnection();

                DateTime insRenewDate = cabNewInsurance.Value.Date;
                DateTime licRenewDate = cabNewLicense.Value.Date;

                // Corrected SQL query
                string sql = "UPDATE [dbo].[vehical] SET license_renew_date = @licRenewDate, insurance_renew_date = @insRenewDate WHERE regNo = @regNo";
                using (SqlCommand cmd = new SqlCommand(sql, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@insRenewDate", insRenewDate);
                    cmd.Parameters.AddWithValue("@licRenewDate", licRenewDate);
                    cmd.Parameters.AddWithValue("@regNo", cab.RegNo);

                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Updated", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Cannot update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Correct text field assignment
                cabInsurance.Text = insRenewDate.ToString("d");
                cabLicense.Text = licRenewDate.ToString("d");

                // Update the vehicle object
                cab.InsuranceRenewDate = insRenewDate;
                cab.LicRenewDate = licRenewDate;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }
        }

    }
}
