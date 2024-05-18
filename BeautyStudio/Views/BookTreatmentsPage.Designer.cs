namespace BeautyStudio.Views
{
    partial class BookTreatmentsPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookTreatmentsPage));
            fLPanelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            pBLogo = new PictureBox();
            panelUsername = new Panel();
            lbLogo = new Label();
            panelGap1 = new Panel();
            panelAppointments = new Panel();
            btnAppointments = new Button();
            panelGap2 = new Panel();
            panelBook = new Panel();
            btnBook = new Button();
            panelGap3 = new Panel();
            panelLogOut = new Panel();
            btnLogOut = new Button();
            fLPanelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            panelUsername.SuspendLayout();
            panelAppointments.SuspendLayout();
            panelBook.SuspendLayout();
            panelLogOut.SuspendLayout();
            SuspendLayout();
            // 
            // fLPanelMenu
            // 
            fLPanelMenu.BackColor = Color.FromArgb(183, 130, 187);
            fLPanelMenu.Controls.Add(panelLogo);
            fLPanelMenu.Controls.Add(panelUsername);
            fLPanelMenu.Controls.Add(panelGap1);
            fLPanelMenu.Controls.Add(panelAppointments);
            fLPanelMenu.Controls.Add(panelGap2);
            fLPanelMenu.Controls.Add(panelBook);
            fLPanelMenu.Controls.Add(panelGap3);
            fLPanelMenu.Controls.Add(panelLogOut);
            fLPanelMenu.Dock = DockStyle.Left;
            fLPanelMenu.Location = new Point(0, 0);
            fLPanelMenu.Name = "fLPanelMenu";
            fLPanelMenu.Size = new Size(250, 603);
            fLPanelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pBLogo);
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 125);
            panelLogo.TabIndex = 0;
            // 
            // pBLogo
            // 
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(0, 0);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(247, 125);
            pBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBLogo.TabIndex = 0;
            pBLogo.TabStop = false;
            // 
            // panelUsername
            // 
            panelUsername.Controls.Add(lbLogo);
            panelUsername.Location = new Point(3, 134);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(247, 50);
            panelUsername.TabIndex = 1;
            // 
            // lbLogo
            // 
            lbLogo.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbLogo.ForeColor = SystemColors.ControlLightLight;
            lbLogo.Location = new Point(0, 0);
            lbLogo.Name = "lbLogo";
            lbLogo.Size = new Size(247, 50);
            lbLogo.TabIndex = 0;
            lbLogo.Text = "Hi, Username";
            lbLogo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGap1
            // 
            panelGap1.Location = new Point(3, 190);
            panelGap1.Name = "panelGap1";
            panelGap1.Size = new Size(247, 22);
            panelGap1.TabIndex = 1;
            // 
            // panelAppointments
            // 
            panelAppointments.Controls.Add(btnAppointments);
            panelAppointments.Location = new Point(3, 218);
            panelAppointments.Name = "panelAppointments";
            panelAppointments.Size = new Size(247, 50);
            panelAppointments.TabIndex = 2;
            // 
            // btnAppointments
            // 
            btnAppointments.FlatAppearance.BorderColor = Color.FromArgb(183, 130, 187);
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppointments.ForeColor = SystemColors.ControlLightLight;
            btnAppointments.Location = new Point(0, 0);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(247, 50);
            btnAppointments.TabIndex = 1;
            btnAppointments.Text = "My Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // panelGap2
            // 
            panelGap2.Location = new Point(3, 274);
            panelGap2.Name = "panelGap2";
            panelGap2.Size = new Size(247, 5);
            panelGap2.TabIndex = 0;
            // 
            // panelBook
            // 
            panelBook.Controls.Add(btnBook);
            panelBook.Location = new Point(3, 285);
            panelBook.Name = "panelBook";
            panelBook.Size = new Size(247, 50);
            panelBook.TabIndex = 0;
            // 
            // btnBook
            // 
            btnBook.FlatAppearance.BorderColor = Color.White;
            btnBook.FlatStyle = FlatStyle.Flat;
            btnBook.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnBook.ForeColor = SystemColors.ControlLightLight;
            btnBook.Location = new Point(0, 0);
            btnBook.Name = "btnBook";
            btnBook.Size = new Size(247, 50);
            btnBook.TabIndex = 0;
            btnBook.Text = "Book A Treatment";
            btnBook.UseVisualStyleBackColor = true;
            // 
            // panelGap3
            // 
            panelGap3.Location = new Point(3, 341);
            panelGap3.Name = "panelGap3";
            panelGap3.Size = new Size(247, 178);
            panelGap3.TabIndex = 0;
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(btnLogOut);
            panelLogOut.Location = new Point(3, 525);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(247, 50);
            panelLogOut.TabIndex = 0;
            // 
            // btnLogOut
            // 
            btnLogOut.FlatAppearance.BorderColor = Color.FromArgb(183, 130, 187);
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.ForeColor = SystemColors.ControlLightLight;
            btnLogOut.Location = new Point(0, 0);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(247, 50);
            btnLogOut.TabIndex = 0;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // BookTreatmentsPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 603);
            Controls.Add(fLPanelMenu);
            Name = "BookTreatmentsPage";
            Text = "Beauty Studio";
            fLPanelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            panelUsername.ResumeLayout(false);
            panelAppointments.ResumeLayout(false);
            panelBook.ResumeLayout(false);
            panelLogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fLPanelMenu;
        private Panel panelLogo;
        private PictureBox pBLogo;
        private Panel panelUsername;
        private Label lbLogo;
        private Panel panelGap1;
        private Panel panelAppointments;
        private Panel panelGap2;
        private Panel panelBook;
        private Panel panelGap3;
        private Button btnAppointments;
        private Button btnBook;
        private Panel panelLogOut;
        private Button btnLogOut;
    }
}