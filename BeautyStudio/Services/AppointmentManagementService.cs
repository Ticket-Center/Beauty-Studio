using BeautyStudio.DatabaseConfiguration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeautyStudio.Services
{
    public class AppointmentManagementService
    {
        private int GetStatusId(string statusName)
        {
            int statusId = -1;

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query= "SELECT id FROM [beauty-studio].[dbo].[Status] WHERE status = @StatusName";

                using (SqlCommand cmd=new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StatusName", statusName);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        statusId = Convert.ToInt32(result);
                    }
                }
            }catch(Exception ex)
            {
                throw new ApplicationException("An error occured while retrieving the status id", ex);
            }

            return statusId;
        }

        public void UpdateAppointmentStatus(int appointmentId, string statusName)
        {
            int statusId = GetStatusId(statusName);

            if (statusId == -1)
            {
                throw new ApplicationException("The status name provided does not exist.");
            }

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = "UPDATE [beauty-studio].[dbo].[Appointments] SET [status] = @StatusId WHERE [id] = @AppointmentID";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@StatusId", statusId);
                    cmd.Parameters.AddWithValue("@AppointmentID", appointmentId);

                    cmd.ExecuteNonQuery();
                }
            }catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while updating the appointment status.", ex);
            }
        }

        public void AddAppointment(DateTime appointmentDate, string appointmentHour, string statusName, int employeeId, int serviceTypeId, int userId)
        {
            int statusId = GetStatusId(statusName);
            if (statusId == -1)
            {
                throw new ApplicationException("Invalid status name.");
            }

            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                // Prepare the query to insert a new appointment
                string query = "INSERT INTO [beauty-studio].[dbo].[Appointments] (appointmentDate, appointmentHour, status, employee, serviceType) " +
                               "VALUES (@AppointmentDate, @AppointmentHour, @Status, @Employee, @ServiceType); " +
                               "SELECT SCOPE_IDENTITY();"; // Get the ID of the inserted appointment

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@AppointmentDate", appointmentDate);
                    cmd.Parameters.AddWithValue("@AppointmentHour", TimeSpan.Parse(appointmentHour)); 
                    cmd.Parameters.AddWithValue("@Status", statusId); 
                    cmd.Parameters.AddWithValue("@Employee", employeeId);
                    cmd.Parameters.AddWithValue("@ServiceType", serviceTypeId);

                    // Execute the query and get the new appointment ID
                    int newAppointmentId = Convert.ToInt32(cmd.ExecuteScalar());

                    // Insert into UserAppointments table
                    string userAppointmentsQuery = "INSERT INTO [beauty-studio].[dbo].[UserAppointments] (appointment_id, user_id) " +
                                                   "VALUES (@AppointmentID, @UserID)";
                    using (SqlCommand userCmd = new SqlCommand(userAppointmentsQuery, con))
                    {
                        userCmd.Parameters.AddWithValue("@AppointmentID", newAppointmentId);
                        userCmd.Parameters.AddWithValue("@UserID", userId);

                        userCmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("An error occurred while adding the appointment.", ex);
            }
        }
    }
}
