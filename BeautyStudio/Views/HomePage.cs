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
        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            _appointmentService = new AppointmentService();

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
            catch(Exception ex)
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
    }
}
