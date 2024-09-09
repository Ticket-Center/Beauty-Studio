using BeautyStudio.DatabaseConfiguration;
using BeautyStudio.Enums;
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
        public RegistrationResult RegisterUser(string username,string firstName,string lastName, string email,string password)
        {
            if (IsUsernameTaken(username))
            {
                return RegistrationResult.UsernameTaken;
            }

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

                    return rowsAffected > 0 ? RegistrationResult.Success : RegistrationResult.Failure;
                }  
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occured during registration.", ex);
            }
        }

        private bool IsUsernameTaken(string username)
        {
            try
            {

                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0; //return true if exists

                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while checking the username.", ex);
            }
        }
    }
}
