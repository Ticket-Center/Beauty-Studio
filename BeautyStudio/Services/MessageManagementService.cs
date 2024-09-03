﻿using BeautyStudio.DatabaseConfiguration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Services
{
    public class MessageManagementService
    {
        public bool RequestAppointmentCancellation(string appointmentDetails)
        {
            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = @"
                        INSERT INTO [beauty-studio].[dbo].[Messages] (message,status)
                        VALUES(@Message,@Status)";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Message", appointmentDetails);
                    cmd.Parameters.AddWithValue("@Status", 0);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while requesting appointment cancellation.", ex);
            }
        }

        public DataTable GetMessages()
        {
            DataTable messagesTable = new DataTable();

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                using (SqlConnection con = sqlConfig.getConnection())
                {
                    string query = @"
                    SELECT 
                        m.id,
                        m.message AS [Message for Cancelation], 
                        s.status AS [Status]
                    FROM
                        [beauty-studio].[dbo].[Messages] m
                    INNER JOIN
                        [beauty-studio].[dbo].[Status] s ON m.status=s.id
                    WHERE
                        s.status = 'active'";


                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                    {
                        adapter.Fill(messagesTable);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving messages.", ex);
            }

            return messagesTable;
        }

    }
}
