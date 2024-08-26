using BeautyStudio.DatabaseConfiguration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Services
{
    public class LogInService
    {
        public bool AuthenticateUser(string username, string password, out int userId, out string role)
        {
            userId = -1;   // Default value indicating no user ID is set
            role = null;   // Default value indicating no role is set

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = "SELECT id, role FROM Users WHERE Username=@Username AND Password=@Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userId = Convert.ToInt32(reader["id"]);
                            role = reader["role"].ToString();
                            return true;
                        }
                        else
                        {
                            return false; // Authentication failed
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred during authentication.", ex);
            }
        }

    }
}
