using BeautyStudio.DatabaseConfiguration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Services
{
    public class EmployeeService
    {
        public DataTable GetEmployeesByServiceCategory(string category)
        {
            DataTable employeeTable = new DataTable();
            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                using (SqlConnection con = sqlConfig.getConnection())
                {
                    string query = @"
                        SELECT e.id, CONCAT(e.first_name, ' ', e.last_name) AS full_name
                        FROM [beauty-studio].[dbo].[Employees] e
                        JOIN [beauty-studio].[dbo].[EmployeeTypes] et ON e.type = et.id
                        JOIN [beauty-studio].[dbo].[ServiceCategories] sc ON et.id = sc.id
                        WHERE sc.category = @Category";

                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@Category", category);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(employeeTable);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving employees.", ex);
            }
            return employeeTable;
        }
    }
}
