using BeautyStudio.DatabaseConfiguration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace BeautyStudio
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            HomePage homePageForm = new HomePage();
            this.Hide();
            homePageForm.ShowDialog();
        }
    }
}