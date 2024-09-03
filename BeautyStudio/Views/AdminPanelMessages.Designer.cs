namespace BeautyStudio.Views
{
    partial class AdminPanelMessages
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPanelMessages));
            fLPanelMenu = new FlowLayoutPanel();
            panelGap3 = new Panel();
            pBLogo = new PictureBox();
            panelMessages = new Panel();
            lbAdmin = new Label();
            panelGap1 = new Panel();
            panelAppointments = new Panel();
            btnAppointments = new Button();
            panelGap2 = new Panel();
            panelAdmin = new Panel();
            btnMessages = new Button();
            panelLogo = new Panel();
            panelLogOut = new Panel();
            btnLogOut = new Button();
            fLPanelMenu.SuspendLayout();
            panelGap3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            panelMessages.SuspendLayout();
            panelAppointments.SuspendLayout();
            panelAdmin.SuspendLayout();
            panelLogOut.SuspendLayout();
            SuspendLayout();
            // 
            // fLPanelMenu
            // 
            fLPanelMenu.BackColor = Color.FromArgb(183, 130, 187);
            fLPanelMenu.Controls.Add(panelGap3);
            fLPanelMenu.Controls.Add(panelMessages);
            fLPanelMenu.Controls.Add(panelGap1);
            fLPanelMenu.Controls.Add(panelAppointments);
            fLPanelMenu.Controls.Add(panelGap2);
            fLPanelMenu.Controls.Add(panelAdmin);
            fLPanelMenu.Controls.Add(panelLogo);
            fLPanelMenu.Controls.Add(panelLogOut);
            fLPanelMenu.Dock = DockStyle.Left;
            fLPanelMenu.Location = new Point(0, 0);
            fLPanelMenu.Name = "fLPanelMenu";
            fLPanelMenu.Size = new Size(250, 603);
            fLPanelMenu.TabIndex = 0;
            // 
            // panelGap3
            // 
            panelGap3.Controls.Add(pBLogo);
            panelGap3.Location = new Point(3, 3);
            panelGap3.Name = "panelGap3";
            panelGap3.Size = new Size(247, 125);
            panelGap3.TabIndex = 6;
            // 
            // pBLogo
            // 
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(3, 0);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(247, 125);
            pBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBLogo.TabIndex = 0;
            pBLogo.TabStop = false;
            // 
            // panelMessages
            // 
            panelMessages.Controls.Add(lbAdmin);
            panelMessages.Location = new Point(3, 134);
            panelMessages.Name = "panelMessages";
            panelMessages.Size = new Size(247, 50);
            panelMessages.TabIndex = 5;
            // 
            // lbAdmin
            // 
            lbAdmin.FlatStyle = FlatStyle.Flat;
            lbAdmin.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            lbAdmin.ForeColor = SystemColors.ControlLightLight;
            lbAdmin.Location = new Point(0, 0);
            lbAdmin.Name = "lbAdmin";
            lbAdmin.Size = new Size(247, 50);
            lbAdmin.TabIndex = 1;
            lbAdmin.Text = "admin";
            lbAdmin.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panelGap1
            // 
            panelGap1.Location = new Point(3, 190);
            panelGap1.Name = "panelGap1";
            panelGap1.Size = new Size(247, 22);
            panelGap1.TabIndex = 4;
            // 
            // panelAppointments
            // 
            panelAppointments.Controls.Add(btnAppointments);
            panelAppointments.Location = new Point(3, 218);
            panelAppointments.Name = "panelAppointments";
            panelAppointments.Size = new Size(247, 50);
            panelAppointments.TabIndex = 3;
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
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // panelGap2
            // 
            panelGap2.Location = new Point(3, 274);
            panelGap2.Name = "panelGap2";
            panelGap2.Size = new Size(247, 5);
            panelGap2.TabIndex = 2;
            // 
            // panelAdmin
            // 
            panelAdmin.Controls.Add(btnMessages);
            panelAdmin.Location = new Point(3, 285);
            panelAdmin.Name = "panelAdmin";
            panelAdmin.Size = new Size(247, 52);
            panelAdmin.TabIndex = 1;
            // 
            // btnMessages
            // 
            btnMessages.FlatAppearance.BorderColor = Color.White;
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMessages.ForeColor = SystemColors.ControlLightLight;
            btnMessages.Location = new Point(0, 0);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(247, 50);
            btnMessages.TabIndex = 1;
            btnMessages.Text = "Messages";
            btnMessages.UseVisualStyleBackColor = true;
            // 
            // panelLogo
            // 
            panelLogo.Location = new Point(3, 343);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(247, 178);
            panelLogo.TabIndex = 0;
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(btnLogOut);
            panelLogOut.Location = new Point(3, 527);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(247, 50);
            panelLogOut.TabIndex = 7;
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
            btnLogOut.TabIndex = 1;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // AdminPanelMessages
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 603);
            Controls.Add(fLPanelMenu);
            Name = "AdminPanelMessages";
            Text = "Beauty Studio";
            fLPanelMenu.ResumeLayout(false);
            panelGap3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            panelMessages.ResumeLayout(false);
            panelAppointments.ResumeLayout(false);
            panelAdmin.ResumeLayout(false);
            panelLogOut.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel fLPanelMenu;
        private Panel panelLogo;
        private PictureBox pBLogo;
        private Label lbAdmin;
        private Panel panelAdmin;
        private Panel panelGap2;
        private Panel panelAppointments;
        private Panel panelMessages;
        private Panel panelGap1;
        private Panel panelGap3;
        private Panel panelLogOut;
        private Button btnMessages;
        private Button btnAppointments;
        private Label lbAdm;
        private Button btnLogOut;
    }
}