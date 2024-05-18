namespace BeautyStudio
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
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