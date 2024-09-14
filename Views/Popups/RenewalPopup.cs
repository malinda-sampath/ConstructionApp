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


namespace ConstructionApp.Views.Popups
{
    public partial class RenewalPopup : Form
    {
        private Vehicle vehicle;
        public RenewalPopup(Vehicle vehicle)
        {
            InitializeComponent();
            this.vehicle = vehicle;
            
        }



        private void vehicleUpdateBtn_Click(object sender, EventArgs e)
        {

            DbManager dbManager = DbManager.Instance;
            try
            {
                dbManager.OpenConnection();

                DateTime insRenewDate = vehicleNewInsurance.Value.Date;
                DateTime licRenewDate = vehicleNewLicense.Value.Date;

                // Corrected SQL query
                string sql = "UPDATE [dbo].[vehicle] SET license_renew_date = @licRenewDate, insurance_renew_date = @insRenewDate WHERE regNo = @regNo";
                using (SqlCommand cmd = new SqlCommand(sql, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@insRenewDate", insRenewDate);
                    cmd.Parameters.AddWithValue("@licRenewDate", licRenewDate);
                    cmd.Parameters.AddWithValue("@regNo", vehicle.RegNo);

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
                vehicleInsurance.Text = insRenewDate.ToString("d");
                vehicleLicense.Text = licRenewDate.ToString("d");

                // Update the vehicle object
                vehicle.InsuranceRenewDate = insRenewDate;
                vehicle.LicRenewDate = licRenewDate;
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

        private void RenewalPopup_Load(object sender, EventArgs e)
        {
            updateComponets();
        }
        private void updateComponets()
        {
            DbManager dbManager = DbManager.Instance;
            try
            {
                // Open the connection to the database
                dbManager.OpenConnection();

                string selectQuery = "SELECT * FROM [dbo].[vehicle] WHERE regNo = @regNo";

                using (SqlCommand cmd = new SqlCommand(selectQuery, dbManager.GetConnection()))
                {
                    // Add the parameter for the vehicle registration number
                    cmd.Parameters.AddWithValue("@regNo", vehicle.RegNo);

                    // Execute the query and read the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any row is returned
                        if (reader.Read())
                        {

                            vehicle.NumberPlate = reader.GetString(reader.GetOrdinal("number_plate"));
                            vehicle.FuelType = reader.GetString(reader.GetOrdinal("fuel_type"));
                            vehicle.LicRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("license_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("license_renew_date")));
                            vehicle.InsuranceRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("insurance_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("insurance_renew_date")));
                            vehicle.Model = reader.GetString(reader.GetOrdinal("model"));



                        }
                        else
                        {
                            MessageBox.Show("error loading database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    vehicleInsurance.Text = vehicle.InsuranceRenewDate.Date.ToString();
                    vehicleLicense.Text = vehicle.LicRenewDate.Date.ToString();
                    lblRegNo.Text = vehicle.NumberPlate;
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
    }
}
