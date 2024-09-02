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
                    u.username AS [Username],
                    a.id,
                    a.appointmentDate AS [Date],
                    a.appointmentHour As [Hour],
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
                    [beauty-studio].[dbo].[ServiceTypes] srv ON a.serviceType = srv.id
                INNER JOIN
                    [beauty-studio].[dbo].[UserAppointments] ua ON a.id = ua.appointment_id
                INNER JOIN
                    [beauty-studio].[dbo].[Users] u ON ua.user_id = u.id";



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

        public DataTable GetUserAppointments(int userId)
        {

            DataTable dt=new DataTable();
            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = @"
                            SELECT 
                                a.id,
                                a.appointmentDate AS [Date],
                                a.appointmentHour AS [Hour],
                                s.status AS [Status],
                                e.first_name + ' ' + e.last_name AS [Employee],
                                srv.service AS [Service Type]
                            FROM 
                                [beauty-studio].[dbo].[Appointments] a
                            INNER JOIN 
                                [beauty-studio].[dbo].[Status] s ON a.status = s.id
                            INNER JOIN 
                                [beauty-studio].[dbo].[Employees] e ON a.employee = e.id
                            INNER JOIN 
                                [beauty-studio].[dbo].[ServiceTypes] srv ON a.serviceType = srv.id
                            INNER JOIN
                                [beauty-studio].[dbo].[UserAppointments] ua ON a.id = ua.appointment_id
                            WHERE
                                ua.user_id = @UserId";

                using(SqlDataAdapter adapter= new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@UserId", userId);
                    adapter.Fill(dt);
                }
            }
            catch(Exception ex) 
            {
                throw new ApplicationException("An error occurred while retrieving user appointments.", ex);
            }
            return dt;
        }

        public DataTable GetAppointmentsForDateAndCategory(DateTime date, string category)
        {
            DataTable dt = new DataTable();
            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = @"
                SELECT
                    a.appointmentHour,
                    st.duration
                FROM
                    [beauty-studio].[dbo].[Appointments] a
                INNER JOIN
                    [beauty-studio].[dbo].[ServiceTypes] st ON a.serviceType = st.id
                INNER JOIN
                    [beauty-studio].[dbo].[ServiceCategories] sc ON st.category = sc.id
                WHERE
                    CAST(a.appointmentDate AS DATE) = @Date
                    AND sc.category = @Category
                ";

                using (SqlDataAdapter adapter = new SqlDataAdapter(query, con))
                {
                    adapter.SelectCommand.Parameters.AddWithValue("@Date", date.Date);
                    adapter.SelectCommand.Parameters.AddWithValue("@Category", category);
                    adapter.Fill(dt);
                }
                Console.WriteLine("Number of appointments fetched: " + dt.Rows.Count);
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while retrieving appointments.", ex);
            }
            return dt;
        }

    }
}
