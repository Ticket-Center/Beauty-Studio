using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.DatabaseConfiguration
{
    class Sql_Configuration
    {
        private static Sql_Configuration instance;
        private string connectionString;

        // Private constructor to enforce singleton pattern
        private Sql_Configuration()
        {
            connectionString = @"Data Source=desktop-fnbr72g;Initial Catalog=beauty-studio;Integrated Security=True";
        }

        // Singleton instance accessor
        public static Sql_Configuration getInstance()
        {
            if (instance == null)
            {
                instance = new Sql_Configuration();
            }
            return instance;
        }

        // Get a new connection each time
        public SqlConnection getConnection()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }
    }
}
