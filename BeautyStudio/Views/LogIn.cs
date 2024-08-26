using BeautyStudio.DatabaseConfiguration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BeautyStudio.SessionManagement;
using BeautyStudio.Views;
using BeautyStudio.Services;

namespace BeautyStudio
{
    public partial class LogIn : Form
    {
        private LogInService _logInService;
        public LogIn()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            _logInService = new LogInService();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register registerForm = new Register();
            this.Hide();
            registerForm.ShowDialog();
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int userId;
            string role;
            bool isAuthenticated = _logInService.AuthenticateUser(username, password, out userId, out role);

            if (isAuthenticated)
            {
                UserSession.Instance.SetUser(username, userId, role);

                if (role == "admin")
                {
                    AdminPanel adminPanelForm = new AdminPanel();
                    this.Hide();
                    adminPanelForm.ShowDialog();
                }
                else
                {
                    HomePage homePageForm = new HomePage();
                    this.Hide();
                    homePageForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}