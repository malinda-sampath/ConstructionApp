using ConstructionApp.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionApp.Services
{
    internal class DbManagerProxy : IDbManager
    {
        private readonly DbManager _dbManager;

        public DbManagerProxy()
        {
            _dbManager = DbManager.Instance; // Get the singleton instance of DbManager
        }

        public void OpenConnection()
        {
            // Additional functionality, such as logging or checking access control, you can later allows access control fi needed.
            Console.WriteLine("Opening database connection ");
            _dbManager.OpenConnection();
        }

        public void CloseConnection()
        {
            // Additional functionality
            Console.WriteLine("Closing database connection...");
            _dbManager.CloseConnection();
        }

        public MySqlConnection GetConnection()
        {
            // Additional functionality if needed
            return _dbManager.GetConnection();
        }
    }
}
// in here no need to implement lazy initialization since it is already achived by singleton implimentation of DbManager.cs