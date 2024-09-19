using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructionApp.Interfaces
{
    internal interface IDbManager
    {
        void OpenConnection();
        void CloseConnection();
        MySqlConnection GetConnection();
    }
}
