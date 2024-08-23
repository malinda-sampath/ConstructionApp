using System;
using System.Data.SqlClient;
using System.Configuration;





namespace ConstructionApp.Services
{
    internal class DbManager
    {
        private static DbManager _instance = null;
        private static readonly object _lock = new object();
        private SqlConnection _connection;
        private static string connectionString = ConfigurationManager.ConnectionStrings["ConstructionAppConnectionString"].ConnectionString;

        // Private constructor to prevent instantiation from outside
        private DbManager()
        {
            _connection = new SqlConnection(connectionString);
        }

        // Public static method to get the single instance of the class
        public static DbManager Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new DbManager();
                    }
                    return _instance;
                }
            }
        }

        // Optional property to allow changing the connection string
        public static string ConnectionString
        {
            get => connectionString;
            set
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        connectionString = value;
                    }
                    else
                    {
                        throw new InvalidOperationException("Cannot change the connection string after the instance has been created.");
                    }
                }
            }
        }

        // Method to open the database connection
        public void OpenConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        // Method to close the database connection
        public void CloseConnection()
        {
            if (_connection.State == System.Data.ConnectionState.Open)
            {
                _connection.Close();
            }
        }

        // Method to get the SQL connection
        public SqlConnection GetConnection()
        {
            return _connection;
        }
    }
}
