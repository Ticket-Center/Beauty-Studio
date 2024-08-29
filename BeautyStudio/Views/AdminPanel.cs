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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading appointments", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSession.Instance.ClearUser();
            LogIn logInForm = new LogIn();
            this.Hide();
            logInForm.ShowDialog();
        }

        /*private void btnCancel_Click(object sender, EventArgs e)
        {
            UpdateAppointmentStatus("Canceled");
        }*/

        /*private void UpdateAppointmentStatus(string status)
        {
            if (dataGridViewAppointments.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridViewAppointments.SelectedRows[0];
                int appointmentId = Convert.ToInt32(selectedRow.Cells["id"].Value); // Adjust "id" to your actual column name

                try
                {
                    _appointmentManagementService.UpdateAppointmentStatus(appointmentId, status);
                    MessageBox.Show($"Appointment {status} successfully.");
                    LoadAppointments(); // Refresh the data grid view to show updated status
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
        }*/
    }
}
