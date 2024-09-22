using ConstructionApp.Interfaces;
using ConstructionApp.Models;
using ConstructionApp.Views;
using MySql.Data.MySqlClient;
using Mysqlx.Session;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ConstructionApp.Services
{
    internal class AuthenticationService
    {
        public static bool AuthenticateUserLogging(String username, string password)
        {
            IDbManager dbManager = new DbManagerProxy();

            try
            {
                dbManager.OpenConnection();
                User user = new User();

                string query = "SELECT name, username, password FROM users WHERE username = @username";
                using (MySqlCommand cmd = new MySqlCommand(query, dbManager.GetConnection()))
                {
                    cmd.Parameters.AddWithValue("@username", username);

                    using (MySqlDataReader sqlDataReader = cmd.ExecuteReader())
                    {
                        if (sqlDataReader.Read()) // Move to the first record
                        {
                            user.Name = sqlDataReader["name"].ToString();
                            user.Username = sqlDataReader["username"].ToString();
                            user.HashedPassword = sqlDataReader["password"].ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, user.HashedPassword))
                            {
                                //MessageBox.Show("Welcome "+user.Name,"login Success",MessageBoxButtons.OK,MessageBoxIcon.None);
                                return true;
                            }
                            else
                            {
                                MessageBox.Show("Invalid credentials", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return false;
                            }
                        }
                        else
                        {
                            MessageBox.Show("User not found", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("An error occurred: " + ex.Message, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dbManager.CloseConnection();
            }

            return false;

        }




    }
}

