using BeautyStudio.Services;
using BeautyStudio.SessionManagement;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BeautyStudio.Views
{
    public partial class AdminPanel : Form
    {
        private AppointmentService _appointmentService;
        private AppointmentManagementService _appointmentManagementService;
        public AdminPanel()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            _appointmentService = new AppointmentService();
            _appointmentManagementService = new AppointmentManagementService();
            LoadAppointments();
        }

        private void LoadAppointments()
        {
            try
            {
                DataTable appointments = _appointmentService.GetAppointments();
                dataGridViewAppointments.DataSource = appointments;

                if (dataGridViewAppointments.Columns["id"] != null)
                {
                    dataGridViewAppointments.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSession.Instance.ClearUser();
            LogIn logInForm = new LogIn();
            this.Hide();
            logInForm.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus("Canceled");
        }

        private void btnComplete_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus("Completed");
        }

        private void UpdateAppointmentStatus(string status)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointments.SelectedRows[0];
                int appointmentId = Convert.ToInt32(selectedRow.Cells["id"].Value);
                DateTime appointmentDate = Convert.ToDateTime(selectedRow.Cells["Date"].Value);
                TimeSpan appointmentHour = TimeSpan.Parse(selectedRow.Cells["Hour"].Value.ToString());

                DateTime appointmentDateTime = appointmentDate.Date + appointmentHour;

                string currentStatus = selectedRow.Cells["Status"].Value.ToString();
                if (currentStatus != "active")
                {
                    MessageBox.Show("Only appointments with 'active' status can be updated.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (currentStatus == status)
                {
                    MessageBox.Show("Already with " + status + " status", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (status == "Completed" && DateTime.Now < appointmentDateTime)
                {
                    MessageBox.Show("You cannot complete an appointment before its scheduled time.", "Invalid Operation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    _appointmentManagementService.UpdateAppointmentStatus(appointmentId, status);
                    MessageBox.Show($"Appointment {status} successfully.");
                    LoadAppointments();
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to update.");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string username = txtBUsername.Text;
            DateTime selectedDate = dPickerDate.Value.Date;

            bool isUsernameChecked = cBUsername.Checked;
            bool isDateChecked = cBDate.Checked;

            try
            {
                DataTable appointments = null;

                if (isUsernameChecked && isDateChecked)
                {
                    // Both Username and Date are checked - call the SQL query to filter by both
                    if (!string.IsNullOrEmpty(username))
                    {
                        appointments = _appointmentService.GetAppointmentsByDateAndUsername(selectedDate, username);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (isUsernameChecked)
                {
                    // Only Username is checked - call the SQL query to filter by username
                    if (!string.IsNullOrEmpty(username))
                    {
                        appointments = _appointmentService.GetAppointmentsByUsername(username);
                    }
                    else
                    {
                        MessageBox.Show("Please enter a username.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
                else if (isDateChecked)
                {
                    // Only Date is checked - call the SQL query to filter by date
                    appointments = _appointmentService.GetAppointmentsByDate(selectedDate);
                }
                else
                {
                    // No checkbox is checked - show a message or load all appointments
                    MessageBox.Show("Please check at least one filter option.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Assign the filtered appointments to the DataGridView
                if (appointments != null)
                {
                    dataGridViewAppointments.DataSource = appointments;

                    // Optionally, handle the case where no appointments are found
                    if (appointments.Rows.Count == 0)
                    {
                        MessageBox.Show("No appointments found for the given filters.", "No Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtBUsername_MouseClick(object sender, MouseEventArgs e)
        {
            txtBUsername.Text = string.Empty;
        }

        private void btnMessages_Click(object sender, EventArgs e)
        {
            AdminPanelMessages adminPanelMessagesForm = new AdminPanelMessages();
            this.Hide();
            adminPanelMessagesForm.ShowDialog();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanelForm = new AdminPanel();
            this.Hide();
            adminPanelForm.ShowDialog();
        }
    }
}
