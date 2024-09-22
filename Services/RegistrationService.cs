using ConstructionApp.Interfaces;
using MySql.Data.MySqlClient;

namespace ConstructionApp.Services
{
    internal class RegistrationService
    {
        public static bool RegisterUser(string name, string username, string password)
        {
            DateTime dateRegistered = DateTime.Today;
            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password, 13);

            // Use the DbManagerProxy for database operations
            IDbManager dbManager = new DbManagerProxy();
            
                try
                {
                    dbManager.OpenConnection();

                    // Check if the username already exists
                    string checkquery = "SELECT COUNT(*) FROM `users` WHERE `username` = @username";
                    using (MySqlCommand checkAvailabilityCmd = new MySqlCommand(checkquery, dbManager.GetConnection()))
                    {
                        checkAvailabilityCmd.Parameters.AddWithValue("@username", username);
                        int usernameCount = Convert.ToInt32(checkAvailabilityCmd.ExecuteScalar());

                        if (usernameCount > 0)
                        {
                            MessageBox.Show("Username already exists. Please choose a different one.", "Username Taken", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return false;
                        }

                        // If username is available, proceed to register the user
                        string insertquery = "INSERT INTO `users` (`name`, `username`, `password`, `date_registered`) " +
                                             "VALUES (@name, @username, @password, @dateRegistered)";
                        using (MySqlCommand cmd = new MySqlCommand(insertquery, dbManager.GetConnection()))
                        {
                            // Bind parameters
                            cmd.Parameters.AddWithValue("@name", name);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", hashedPassword);
                            cmd.Parameters.AddWithValue("@dateRegistered", dateRegistered);

                            // Execute the command
                            int rowsAffected = cmd.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("User registered successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("User registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                finally
                {
                    dbManager.CloseConnection();
                }
            
        }
    }
}