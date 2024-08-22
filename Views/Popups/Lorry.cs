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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ConstructionApp.Views.Popups
{
    public partial class Lorry : Form
    {
        Vehical lorry = new();
        public Lorry()
        {
            InitializeComponent();
            lorry.FuelType = "Diesel";
            lorry.NumberPlate = "ABC-1234";

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
                    cmd.Parameters.AddWithValue("@regNo", lorry.RegNo);

                    // Execute the query and read the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any row is returned
                        if (reader.Read())
                        {

                            lorry.NumberPlate = reader.GetString(reader.GetOrdinal("number_plate"));
                            lorry.FuelType = reader.GetString(reader.GetOrdinal("fuel_type"));
                            lorry.LicRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("license_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("license_renew_date")));
                            lorry.InsuranceRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("insurance_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("insurance_renew_date")));
                            lorry.Model = reader.GetString(reader.GetOrdinal("model"));



                        }
                        else
                        {
                            MessageBox.Show("error loading database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    lorryInsurance.Text =lorry.InsuranceRenewDate.Date.ToString();
                    lorryLicense.Text = lorry.LicRenewDate.Date.ToString();
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

        private void lorryUpdateBtn_Click(object sender, EventArgs e)
        {
            DbManager dbManager = DbManager.Instance;
            try
            {
                dbManager.OpenConnection();

                DateTime insRenewDate = lorryNewInsurance.Value.Date;
                DateTime licRenewDate = lorryNewLicense.Value.Date;

                // Corrected SQL query
                string sql = "UPDATE [dbo].[vehical] SET license_renew_date = @licRenewDate, insurance_renew_date = @insRenewDate WHERE regNo = @regNo";
                using (SqlCommand cmd = new SqlCommand(sql, dbManager.GetConnection()))
                {
                    // Add parameters with proper value types
                    cmd.Parameters.AddWithValue("@insRenewDate", insRenewDate);
                    cmd.Parameters.AddWithValue("@licRenewDate", licRenewDate);
                    cmd.Parameters.AddWithValue("@regNo", lorry.RegNo);

                    // Execute the query
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Updated", "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    else
                    {
                        MessageBox.Show("Cannot update", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                // Update UI components and lorry object
                lorryInsurance.Text = insRenewDate.ToString("d"); // Format the date as needed
                lorryLicense.Text = licRenewDate.ToString("d"); // Format the date as needed
                lorry.InsuranceRenewDate = insRenewDate;
                lorry.LicRenewDate = licRenewDate;
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
