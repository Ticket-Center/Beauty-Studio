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
        public BookTreatmentsPage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);
            
            dPickerDate.MinDate = DateTime.Now.Date;
            dPickerDate.MaxDate = DateTime.Now.Date.AddDays(30);

            _serviceTypeService = new ServiceTypeService();

            if (UserSession.Instance.isLoggedIn())
            {
                lbUsername.Text = $"Hi, {UserSession.Instance.Username}";
            }
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
            pBImage.Image = Properties.Resources.HairImage;
            LoadServiceTypes("hair");
        }

        private void btnNails_Click(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.NailsImage;
            LoadServiceTypes("nails");
        }

        private void btnFace_Click(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.FaceImage;
            LoadServiceTypes("face");
        }

        private void LoadServiceTypes(string category)
        {
            try
            {
                DataTable serviceTypes = _serviceTypeService.GetServiceTypesByCategory(category);
                cbService.DataSource = serviceTypes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading service types: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
