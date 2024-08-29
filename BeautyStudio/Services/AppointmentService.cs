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
    public class AppointmentService
    {
        public DataTable GetAppointments()
        {
            DataTable dt=new DataTable();

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();


                string query = @"
                            SELECT 
                                a.appointmentDate,
                                a.appointmentHour,
                                s.status AS [Status],
                                e.first_name + ' ' + e.last_name AS [Employee],
                                srv.service AS [ServiceType]
                            FROM 
                                [beauty-studio].[dbo].[Appointments] a
                            INNER JOIN 
                                [beauty-studio].[dbo].[Status] s ON a.status = s.id
                            INNER JOIN 
                                [beauty-studio].[dbo].[Employees] e ON a.employee = e.id
                            INNER JOIN 
                                [beauty-studio].[dbo].[ServiceTypes] srv ON a.serviceType = srv.id";


                using (SqlDataAdapter adapter=new SqlDataAdapter(query, con))
                {
                    adapter.Fill(dt);
                }
            }catch (Exception ex)
            {
                throw new ApplicationException("An error occured while retrieving appointments.", ex);
            }
            return dt;
        }
    }
}
