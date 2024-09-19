using ConstructionApp.Models;
using ConstructionApp.Services;
using ConstructionApp.Views.Popups;
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
using MySql.Data.MySqlClient;
using ConstructionApp.Interfaces;

namespace ConstructionApp.Views
{
    public partial class VehicleForm : UserControl
    {
        public VehicleForm()
        {
            InitializeComponent();
        }



        //this method will return a vehicle model from database for given 'RegNo'
        private Vehicle getVehicleFromDatabase(int RegNo)
        {
            Vehicle vehicle = null; 
            IDbManager dbManager = new DbManagerProxy();
            try
            {
                // Open the connection to the database
                dbManager.OpenConnection();

                string selectQuery = "SELECT * FROM vehicle WHERE regNo = @regNo";


                using (MySqlCommand cmd = new MySqlCommand(selectQuery, dbManager.GetConnection()))
                {
                    // Add the parameter for the vehicle registration number
                    cmd.Parameters.AddWithValue("@regNo", RegNo);

                    // Execute the query and read the data
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        // Check if any row is returned
                        if (reader.Read())
                        {
                            vehicle = new Vehicle();
                            vehicle.FuelType = reader.GetString(reader.GetOrdinal("fuel_type"));
                            vehicle.NumberPlate = reader.GetString(reader.GetOrdinal("number_plate"));
                            vehicle.LicRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("license_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("license_renew_date")));
                            vehicle.InsuranceRenewDate = (DateTime)(reader.IsDBNull(reader.GetOrdinal("insurance_renew_date")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("insurance_renew_date")));
                            vehicle.Model = reader.GetString(reader.GetOrdinal("model"));

                        }
                        else
                        {
                            MessageBox.Show("error loading database", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

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
                    return vehicle;
        }

        private void btn_lorry_Click(object sender, EventArgs e)
        {

           RenewalPopup renewalPopup = new(vehicle: getVehicleFromDatabase(7979));
            renewalPopup.Show();
           // Lorry lorry = new Lorry();
           // lorry.Show();
        }

        private void btn_cab_Click(object sender, EventArgs e)
        {
            RenewalPopup renewalPopup = new(vehicle: getVehicleFromDatabase(1931));
            renewalPopup.Show();
            //Cab cb = new Cab();
            //cb.Show();
        }

        private void btn_jeep_Click(object sender, EventArgs e)
        {
            RenewalPopup renewalPopup = new(vehicle: getVehicleFromDatabase(9995));
            renewalPopup.Show();
            //Jeep jeep = new Jeep();
            //jeep.Show();
        }

        private void btn_bike_Click(object sender, EventArgs e)
        {
            RenewalPopup renewalPopup = new(vehicle: getVehicleFromDatabase(6751));
            renewalPopup.Show();
            //Bike bike = new Bike();
            //bike.Show();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {

        }
    }
}
