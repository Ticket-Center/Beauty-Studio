namespace BeautyStudio.Views
{
    partial class AdminPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanel));
            fLPanelMenu = new FlowLayoutPanel();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            panelAdmin = new Panel();
            lbAdmin = new Label();
            panelGap1 = new Panel();
            panelAppointments = new Panel();
            btnAppointments = new Button();
            panelGap2 = new Panel();
            panelLogOut = new Panel();
            btnLogOut = new Button();
            fLPanelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelAdmin.SuspendLayout();
            panelAppointments.SuspendLayout();
            panelLogOut.SuspendLayout();
            SuspendLayout();
            // 
            // fLPanelMenu
            // 
            fLPanelMenu.BackColor = Color.FromArgb(183, 130, 187);
            fLPanelMenu.Controls.Add(panelLogo);
            fLPanelMenu.Controls.Add(panelAdmin);
            fLPanelMenu.Controls.Add(panelGap1);
            fLPanelMenu.Controls.Add(panelAppointments);
            fLPanelMenu.Controls.Add(panelGap2);
            fLPanelMenu.Controls.Add(panelLogOut);
            fLPanelMenu.Dock = DockStyle.Left;
            fLPanelMenu.Location = new Point(0, 0);
            fLPanelMenu.Name = "fLPanelMenu";
            fLPanelMenu.Size = new Size(250, 603);
            fLPanelMenu.TabIndex = 0;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Location = new Point(3, 3);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 125);
            panelLogo.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(247, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(lbAdmin);
            panelAdmin.Location = new Point(3, 134);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(247, 50);
            panelAdmin.TabIndex = 1;
            // 
            // lbAdmin
            // 
            lbAdmin.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAdmin.ForeColor = SystemColors.ControlLightLight;
            lbAdmin.Location = new Point(0, 0);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(247, 50);
            lbAdmin.TabIndex = 0;
            lbAdmin.Text = "admin";
            lbAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGap1
            // 
            panelGap1.Location = new Point(3, 190);
            panelGap1.Name = "panelGap1";
            panelGap1.Size = new Size(247, 22);
            panelGap1.TabIndex = 2;
            // 
            // panelAppointments
            // 
            panelAppointments.Controls.Add(btnAppointments);
            panelAppointments.Location = new Point(3, 218);
            panelAppointments.Name = "panelAppointments";
            panelAppointments.Size = new Size(247, 50);
            panelAppointments.TabIndex = 0;
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
            btnAppointments.TabIndex = 0;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            // 
            // panelGap2
            // 
            panelGap2.Location = new Point(3, 274);
            panelGap2.Name = "panelGap2";
            panelGap2.Size = new Size(247, 245);
            panelGap2.TabIndex = 1;
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(btnLogOut);
            panelLogOut.Location = new Point(3, 525);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(247, 50);
            panelLogOut.TabIndex = 1;
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
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 603);
            Controls.Add(fLPanelMenu);
            Name = "AdminPanel";
            Text = "Beauty Studio";
            fLPanelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelAdmin.ResumeLayout(false);
            panelAppointments.ResumeLayout(false);
            panelLogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fLPanelMenu;
        private Panel panelLogo;
        private PictureBox pictureBox1;
        private Panel panelAdmin;
        private Label lbAdmin;
        private Panel panelGap1;
        private Panel panelAppointments;
        private Button btnAppointments;
        private Panel panelGap2;
        private Panel panelLogOut;
        private Button btnLogOut;
    }
}