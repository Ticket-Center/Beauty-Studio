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
    public partial class BookTreatmentsPage : Form
    {
        private ServiceTypeService _serviceTypeService;
        private AppointmentService _appointmentService;
        private string selectedCategory;  // Add this to store the selected category

        public BookTreatmentsPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            dPickerDate.MinDate = DateTime.Now.Date;
            dPickerDate.MaxDate = DateTime.Now.Date.AddDays(30);

            _serviceTypeService = new ServiceTypeService();
            _appointmentService = new AppointmentService();

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
        }

        private void btnNails_Click(object sender, EventArgs e)
        {
            selectedCategory = "nails"; 
            pBImage.Image = Properties.Resources.NailsImage;
            cbHour.Items.Clear();
            LoadServiceTypes(selectedCategory);
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            selectedCategory = "face";
            pBImage.Image = Properties.Resources.FaceImage;
            cbHour.Items.Clear();
            LoadServiceTypes(selectedCategory);
        }

        private void LoadServiceTypes(string category)
        {
            try
            {
                DataTable serviceTypes = _serviceTypeService.GetServiceTypesByCategory(category);
                cbService.DataSource = serviceTypes;
                cbService.DisplayMember = "Service";
                cbService.ValueMember = "Service";
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

                var freeHours = workingHours.Where(h => !occupiedHours.Contains(h.Hour)).Select(h => h.Hour).ToList();

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
    }

}
