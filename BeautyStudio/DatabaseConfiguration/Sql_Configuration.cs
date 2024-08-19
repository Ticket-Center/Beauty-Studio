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
        string ConnectionString = @"Data Source=desktop-fnbr72g;Initial Catalog=beauty-studio;Integrated Security=True";
        SqlConnection con;
        private static Sql_Configuration instance;
        public static Sql_Configuration getInstance()
        {
            if (instance == null)
                instance = new Sql_Configuration();
            return instance;
        }

        private Sql_Configuration()
        {
            con = new SqlConnection(ConnectionString);
            con.Open();
        }

        public SqlConnection getConnection()
        {
            return con;
        }
    }
}
