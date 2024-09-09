using BeautyStudio.Enums;
using BeautyStudio.Services;
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
    public partial class Register : Form
    {
        private readonly RegistrationService _registrationService;
        public Register()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            _registrationService = new RegistrationService();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            this.Hide();
            logInForm.ShowDialog();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string firstName = txtFirstName.Text.Trim();
            string lastName = txtLastName.Text.Trim();
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();
            string repeatPassword = txtRepeatPassword.Text.Trim();

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(repeatPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!password.Equals(repeatPassword))
            {
                MessageBox.Show("Passwords don't match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                var result = _registrationService.RegisterUser(username, firstName, lastName, email, password);

                switch (result)
                {
                    case RegistrationResult.Success:
                        MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LogIn logInForm = new LogIn();
                        this.Hide();
                        logInForm.ShowDialog();
                        break;

                    case RegistrationResult.UsernameTaken:
                        MessageBox.Show("Username already exists. Please choose a different one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;

                    case RegistrationResult.Failure:
                        MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
