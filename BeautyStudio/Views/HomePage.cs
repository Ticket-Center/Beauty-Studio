﻿using BeautyStudio.Views;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(400, 150);
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            BookTreatmentsPage bookTreatmentsForm = new BookTreatmentsPage();
            this.Hide();
            bookTreatmentsForm.ShowDialog();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            LogIn logInForm = new LogIn();
            this.Hide();
            logInForm.ShowDialog();
        }
    }
}
