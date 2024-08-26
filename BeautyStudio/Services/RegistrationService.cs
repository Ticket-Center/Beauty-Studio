using BeautyStudio.DatabaseConfiguration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Services
{
    public class RegistrationService
    {
        public bool RegisterUser(string username,string firstName,string lastName, string email,string password)
        {
            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = "INSERT INTO Users (Username,First_Name,Last_Name,Email,Password,Is_Active,Role) " + "VALUES (@Username,@First_Name,@Last_Name,@Email,@Password,@Is_Active,@Role)";

                using (SqlCommand cmd= new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@First_Name", firstName);
                    cmd.Parameters.AddWithValue("@Last_Name", lastName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Password", password);
                    cmd.Parameters.AddWithValue("@Is_Active", "true");
                    cmd.Parameters.AddWithValue("@Role", "customer");

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }catch (Exception ex)
            {
                throw new ApplicationException("An error occured during registration.", ex);
            }
        }
    }
}
