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
    public partial class Jeep : Form
    {
        Vehical jeep = new();
        public Jeep()
        {
            InitializeComponent();
            jeep.FuelType = "Diesel";
            jeep.NumberPlate = "ABC-1234";

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
                    cmd.Parameters.AddWithValue("@regNo", jeep.RegNo);

                    // Execute the query and read the data
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Check if any row is returned
                        if (reader.Read())
                        {

                            jeep.NumberPlate = reader.GetString(reader.GetOrdinal("number_plate"));
                            jeep.FuelType = reader.GetString(reader.GetOrdinal("fuel_type"));
                            jeep.LicRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("license_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("license_renew_date")));
                            jeep.InsuranceRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("insurance_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("insurance_renew_date")));
                            jeep.Model = reader.GetString(reader.GetOrdinal("model"));



                        }
                        else
                        {
                            MessageBox.Show("error loading database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    jeepInsurance.Text = jeep.InsuranceRenewDate.Date.ToString();
                    jeepLicense.Text = jeep.LicRenewDate.Date.ToString();
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

        private void jeepUpdateBtn_Click(object sender, EventArgs e)
        {
            DbManager dbManager = DbManager.Instance;
            try
            {
                dbManager.OpenConnection();

                DateTime insRenewDate = jeepNewInsurance.Value.Date;
                DateTime licRenewDate = jeepNewLicense.Value.Date;

                // Corrected SQL query
                string sql = "UPDATE [dbo].[vehical] SET license_renew_date = @licRenewDate, insurance_renew_date = @insRenewDate WHERE regNo = @regNo";
                using (SqlCommand cmd = new SqlCommand(sql, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@insRenewDate", insRenewDate);
                    cmd.Parameters.AddWithValue("@licRenewDate", licRenewDate);
                    cmd.Parameters.AddWithValue("@regNo", jeep.RegNo);

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

                // Corrected text field assignment
                jeepInsurance.Text = insRenewDate.ToString("d");
                jeepLicense.Text = licRenewDate.ToString("d");

                // Update the vehicle object
                jeep.InsuranceRenewDate = insRenewDate;
                jeep.LicRenewDate = licRenewDate;
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
