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
    public partial class AdminPanelMessages : Form
    {
        private MessageManagementService _messageManagementService;
        public AdminPanelMessages()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);

            _messageManagementService = new MessageManagementService();
            LoadMessages();
        }

        private void LoadMessages()
        {
            try
            {
                DataTable messages = _messageManagementService.GetMessages();
                dataGridViewMessages.DataSource = messages;

                if (dataGridViewMessages.Columns["id"] != null)
                {
                    dataGridViewMessages.Columns["id"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading messages: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAppointments_Click(object sender, EventArgs e)
        {
            AdminPanel adminPanelForm = new AdminPanel();
            this.Hide();
            adminPanelForm.ShowDialog();
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
