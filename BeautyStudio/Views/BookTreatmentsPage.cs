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
        public BookTreatmentsPage()
        {
            InitializeComponent();
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            HomePage homePageForm = new HomePage();
            this.Hide();
            homePageForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            this.Hide();
            logInForm.ShowDialog();
        }

        private void BookTreatmentsPage_Load(object sender, EventArgs e)
        {

        }

        private void btnHair_Click(object sender, EventArgs e)
        {
            pBImage.Image = Properties.Resources.HairImage;
        }
    }
}
