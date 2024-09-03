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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BeautyStudio.Views
{
    public partial class BookTreatmentsPage : Form
    {
        private ServiceTypeService _serviceTypeService;
        private AppointmentService _appointmentService;
        private AppointmentManagementService _appointmentManagementService;
        private EmployeeService _employeeService;

        private string selectedCategory;

        public BookTreatmentsPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            dPickerDate.MinDate = DateTime.Now.Date;
            dPickerDate.MaxDate = DateTime.Now.Date.AddDays(30);

            _serviceTypeService = new ServiceTypeService();
            _appointmentService = new AppointmentService();
            _appointmentManagementService = new AppointmentManagementService();
            _employeeService = new EmployeeService();

            if (UserSession.Instance.isLoggedIn())
            {
                lbUsername.Text = $"Hi, {UserSession.Instance.Username}";
            }

            dPickerDate.ValueChanged += dPickerDate_ValueChanged;
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            HomePage homePageForm = new HomePage();
            this.Hide();
            homePageForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            UserSession.Instance.ClearUser();
            LogIn logInForm = new LogIn();
            this.Hide();
            logInForm.ShowDialog();
        }

        private void btnHair_Click(object sender, EventArgs e)
        {
            selectedCategory = "hair";
            pBImage.Image = Properties.Resources.HairImage;
            cbHour.Items.Clear();
            LoadServiceTypes(selectedCategory);
            LoadEmployees(selectedCategory);
        }

        private void btnNails_Click(object sender, EventArgs e)
        {
            selectedCategory = "nails";
            pBImage.Image = Properties.Resources.NailsImage;
            cbHour.Items.Clear();
            LoadServiceTypes(selectedCategory);
            LoadEmployees(selectedCategory);
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            selectedCategory = "face";
            pBImage.Image = Properties.Resources.FaceImage;
            cbHour.Items.Clear();
            LoadServiceTypes(selectedCategory);
            LoadEmployees(selectedCategory);
        }

        private void LoadServiceTypes(string category)
        {
            try
            {
                DataTable serviceTypes = _serviceTypeService.GetServiceTypesByCategory(category);
                cbService.DataSource = serviceTypes;
                cbService.DisplayMember = "Service";  // Display name of the service
                cbService.ValueMember = "Id";         // ID of the service
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dPickerDate_ValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedCategory))
            {
                PopulateAvailableHours(dPickerDate.Value, selectedCategory);
            }
            else
            {
                MessageBox.Show("Please select a category first.", "Category Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopulateAvailableHours(DateTime selectedDate, string category)
        {
            try
            {
                DataTable appointments = _appointmentService.GetAppointmentsForDateAndCategory(selectedDate, category);

                var workingHours = Enumerable.Range(10, 8).Select(h => new { Hour = h }).ToList();


                var occupiedHours = new List<int>();
                foreach (DataRow row in appointments.Rows)
                {
                    int startHour = ((TimeSpan)row["appointmentHour"]).Hours;
                    int duration = Convert.ToInt32(row["duration"]);

                    int endHour = startHour + (duration / 60);
                    if (duration % 60 > 0) endHour++;

                    for (int hour = startHour; hour < endHour; hour++)
                    {
                        if (!occupiedHours.Contains(hour))
                        {
                            occupiedHours.Add(hour);
                        }
                    }
                }

                // Get current time
                DateTime now = DateTime.Now;
                TimeSpan twoHoursFromNow = TimeSpan.FromHours(2);
                bool isToday = selectedDate.Date == now.Date;

                //var freeHours = workingHours.Where(h => !occupiedHours.Contains(h.Hour)).Select(h => h.Hour).ToList();

                // Filter working hours based on whether it's today
                var freeHours = workingHours
                    .Where(h =>
                        (!isToday || (new TimeSpan(h.Hour, 0, 0) >= now.TimeOfDay.Add(twoHoursFromNow))) // If today, only include hours 2 hours from now or later
                        && !occupiedHours.Contains(h.Hour)) // Exclude occupied hours
                    .Select(h => h.Hour)
                    .ToList();


                cbHour.Items.Clear();

                if (freeHours.Count > 0)
                {
                    foreach (var hour in freeHours)
                    {
                        cbHour.Items.Add($"{hour}:00:00");
                    }
                    cbHour.SelectedIndex = -1;
                    cbHour.Text = "Select an hour";
                }
                else
                {
                    cbHour.Items.Add("No available hours");
                    cbHour.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading available hours: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedCategory))
            {
                MessageBox.Show("Please select a category first.", "Category Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbService.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a service.", "Service Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbHour.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an hour.", "Hour Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbEmployee.SelectedIndex == -1)
            {
                MessageBox.Show("Please select an employee.", "Employee Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime appointmentDate = dPickerDate.Value.Date;
            string appointmentHour = cbHour.SelectedItem.ToString();
            int serviceTypeId = Convert.ToInt32(cbService.SelectedValue);
            int employeeId = Convert.ToInt32(cbEmployee.SelectedValue);

            TimeSpan appointmentH = TimeSpan.Parse(appointmentHour);

            try
            {
                //Duration of the selected service
                int serviceDuration = _serviceTypeService.GetServiceDurationById(serviceTypeId);
                TimeSpan serviceDurationTimeSpan=TimeSpan.FromMinutes(serviceDuration);

                //The end time of the appointment
                TimeSpan appointmentEndHour=appointmentH.Add(serviceDurationTimeSpan);

                DataTable appointments = _appointmentService.GetAppointmentsForDateAndCategory(appointmentDate, selectedCategory);

                foreach(DataRow row in appointments.Rows)
                {
                    TimeSpan existingStartHour = (TimeSpan)row["appointmentHour"];
                    int existingDuration = Convert.ToInt32(row["duration"]);
                    TimeSpan existingEndHour = existingStartHour.Add(TimeSpan.FromMinutes(existingDuration));


                    // Check if the selected time overlaps with any existing appointment
                    if (appointmentH < existingEndHour && appointmentEndHour > existingStartHour)
                    {
                        MessageBox.Show("The selected time slot overlaps with an existing appointment. Please choose another time.", "Time Slot Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }


                int userId = UserSession.Instance.UserId;
                _appointmentManagementService.AddAppointment(appointmentDate, appointmentHour, "active", employeeId, serviceTypeId, userId);
                MessageBox.Show("Appointment booked successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                BookTreatmentsPage bookTreatmentsForm = new BookTreatmentsPage();
                this.Hide();
                bookTreatmentsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error booking appointment: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadEmployees(string category)
        {
            try
            {
                DataTable employees = _employeeService.GetEmployeesByServiceCategory(category);
                cbEmployee.DataSource = employees;
                cbEmployee.DisplayMember = "full_name";
                cbEmployee.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employees: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetEmployeeTypeByCategory(string category)
        {
            switch (category.ToLower())
            {
                case "hair":
                    return "Hairstylist";
                case "nails":
                    return "Manicurist";
                case "face":
                    return "Esthetician";
                default:
                    return null;
            }
        }
    }

}
