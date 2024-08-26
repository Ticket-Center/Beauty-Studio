using BeautyStudio.DatabaseConfiguration;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BeautyStudio.SessionManagement;
using BeautyStudio.Views;

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
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool isAuthenticated = AuthenticateUser(username, password);

            if (isAuthenticated)
            {
                if (UserSession.Instance.Role == "admin")
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

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                Sql_Configuration sqlConfig = Sql_Configuration.getInstance();
                SqlConnection con = sqlConfig.getConnection();

                string query = "SELECT id, role FROM Users WHERE Username=@Username AND Password=@Password";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@Password", password);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int userId = Convert.ToInt32(reader["id"]);
                            string role = reader["role"].ToString();

                            UserSession.Instance.SetUser(username, userId, role);

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}