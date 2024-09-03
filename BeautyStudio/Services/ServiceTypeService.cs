using BeautyStudio.DatabaseConfiguration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Services
{
    internal class ServiceTypeService
    {
        public DataTable GetServiceTypesByCategory(string category)
        {
            DataTable dt = new DataTable();

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = @"
                        SELECT 
                            st.service AS [Service],
                            st.id AS [Id],          
                            st.duration AS [Duration]
                        FROM 
                            [beauty-studio].[dbo].[ServiceTypes] st
                        INNER JOIN 
                            [beauty-studio].[dbo].[ServiceCategories] sc ON st.category = sc.id
                        WHERE 
                            sc.category = @Category";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Category", category);
                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving service types.", ex);
            }

            return dt;
        }

        public int GetServiceDurationById(int serviceTypeId)
        {
            int duration = 0;

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = @"
            SELECT 
                st.duration AS [Duration]
            FROM 
                [beauty-studio].[dbo].[ServiceTypes] st
            WHERE 
                st.id = @ServiceTypeId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ServiceTypeId", serviceTypeId);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        if (dt.Rows.Count > 0)
                        {
                            duration = Convert.ToInt32(dt.Rows[0]["Duration"]);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving the service duration.", ex);
            }

            return duration;
        }


    }
}
