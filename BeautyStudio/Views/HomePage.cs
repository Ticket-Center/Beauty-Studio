using BeautyStudio.Services;
using BeautyStudio.SessionManagement;
using BeautyStudio.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeautyStudio
{
    public partial class HomePage : Form
    {
        private AppointmentService _appointmentService;
        private MessageManagementService _messageManagementService;
        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            _appointmentService = new AppointmentService();
            _messageManagementService = new MessageManagementService();

            if (UserSession.Instance.isLoggedIn())
            {
                lbUsername.Text = $"Hi, {UserSession.Instance.Username}";
                LoadUserAppointments(UserSession.Instance.UserId);
            }
        }
        private void LoadUserAppointments(int userId)
        {
            try
            {
                DataTable userAppointments = _appointmentService.GetUserAppointments(userId);

                // Filter the appointments to show only those with 'active' status
                DataView activeAppointmentsView = new DataView(userAppointments)
                {
                    RowFilter = "Status = 'active'"
                };

                dataGridViewUserAppointments.DataSource = activeAppointmentsView;


                if (dataGridViewUserAppointments.Columns["id"] != null)
                {
                    dataGridViewUserAppointments.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading your appointments: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookTreatmentsPage bookTreatmentsForm = new BookTreatmentsPage();
            this.Hide();
            bookTreatmentsForm.ShowDialog();
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
            if (dataGridViewUserAppointments.SelectedRows.Count > 0)
            {
                try
                {
                    int selectedRowIndex = dataGridViewUserAppointments.SelectedRows[0].Index;
                    //int appointmentId = Convert.ToInt32(dataGridViewUserAppointments.Rows[selectedRowIndex].Cells["id"].Value);

                    DateTime appointmentDate = Convert.ToDateTime(dataGridViewUserAppointments.Rows[selectedRowIndex].Cells["Date"].Value);
                    string appointmentHour = dataGridViewUserAppointments.Rows[selectedRowIndex].Cells["Hour"].Value.ToString();
                    string serviceType = dataGridViewUserAppointments.Rows[selectedRowIndex].Cells["Service Type"].Value.ToString();
                    string employeeName = dataGridViewUserAppointments.Rows[selectedRowIndex].Cells["Employee"].Value.ToString();

                    string username = UserSession.Instance.Username;

                    string formattedDate = appointmentDate.ToShortDateString();

                    string appointmentDetails = $"User " + username +
                        $" request cancellation of appointment.\n" +
                        $"Date: " + formattedDate +
                        $"\nHour: " + appointmentHour +
                        $"\nService Type: " + serviceType +
                        $"\nBy Employee: " + employeeName;

                    bool result = _messageManagementService.RequestAppointmentCancellation(appointmentDetails);
                    if (result)
                    {
                        MessageBox.Show("Your cancellation request has been submitted.", "Request Submitted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit the cancellation request. Please try again later.", "Request Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error submitting cancellation request: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select an appointment to cancel.", "No Appointment Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
