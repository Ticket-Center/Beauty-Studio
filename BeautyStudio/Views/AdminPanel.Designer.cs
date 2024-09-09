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
            pBLogo = new PictureBox();
            panelAdmin = new Panel();
            lbAdmin = new Label();
            panelGap1 = new Panel();
            panelAppointments = new Panel();
            btnAppointments = new Button();
            panelGap2 = new Panel();
            panelLogOut = new Panel();
            btnMessages = new Button();
            panelGap3 = new Panel();
            panel1 = new Panel();
            btnLogOut = new Button();
            dataGridViewAppointments = new DataGridView();
            btnCancel = new Button();
            btnComplete = new Button();
            txtBUsername = new TextBox();
            dPickerDate = new DateTimePicker();
            btnFilter = new Button();
            cBUsername = new CheckBox();
            cBDate = new CheckBox();
            fLPanelMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            panelAdmin.SuspendLayout();
            panelAppointments.SuspendLayout();
            panelLogOut.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).BeginInit();
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
            fLPanelMenu.Controls.Add(panelGap3);
            fLPanelMenu.Controls.Add(panel1);
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
            panelLogo.TabIndex = 1;
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
            btnAppointments.FlatAppearance.BorderColor = Color.White;
            btnAppointments.FlatStyle = FlatStyle.Flat;
            btnAppointments.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnAppointments.ForeColor = SystemColors.ControlLightLight;
            btnAppointments.Location = new Point(0, 0);
            btnAppointments.Name = "btnAppointments";
            btnAppointments.Size = new Size(247, 50);
            btnAppointments.TabIndex = 7;
            btnAppointments.Text = "Appointments";
            btnAppointments.UseVisualStyleBackColor = true;
            btnAppointments.Click += btnAppointments_Click;
            // 
            // panelGap2
            // 
            panelGap2.Location = new Point(3, 274);
            panelGap2.Name = "panelGap2";
            panelGap2.Size = new Size(247, 5);
            panelGap2.TabIndex = 1;
            // 
            // panelLogOut
            // 
            panelLogOut.Controls.Add(btnMessages);
            panelLogOut.Location = new Point(3, 285);
            panelLogOut.Name = "panelLogOut";
            panelLogOut.Size = new Size(247, 50);
            panelLogOut.TabIndex = 1;
            // 
            // btnMessages
            // 
            btnMessages.FlatAppearance.BorderColor = Color.FromArgb(183, 130, 187);
            btnMessages.FlatStyle = FlatStyle.Flat;
            btnMessages.Font = new Font("Impact", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            btnMessages.ForeColor = SystemColors.ControlLightLight;
            btnMessages.Location = new Point(0, 0);
            btnMessages.Name = "btnMessages";
            btnMessages.Size = new Size(247, 50);
            btnMessages.TabIndex = 2;
            btnMessages.Text = "Messages";
            btnMessages.UseVisualStyleBackColor = true;
            btnMessages.Click += btnMessages_Click;
            // 
            // panelGap3
            // 
            panelGap3.Location = new Point(3, 341);
            panelGap3.Name = "panelGap3";
            panelGap3.Size = new Size(247, 178);
            panelGap3.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnLogOut);
            panel1.Location = new Point(3, 525);
            panel1.Name = "panel1";
            panel1.Size = new Size(247, 50);
            panel1.TabIndex = 4;
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
            // dataGridViewAppointments
            // 
            dataGridViewAppointments.BackgroundColor = Color.Plum;
            dataGridViewAppointments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAppointments.Location = new Point(298, 180);
            dataGridViewAppointments.Name = "dataGridViewAppointments";
            dataGridViewAppointments.RowHeadersWidth = 51;
            dataGridViewAppointments.RowTemplate.Height = 29;
            dataGridViewAppointments.Size = new Size(673, 385);
            dataGridViewAppointments.TabIndex = 1;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(298, 103);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 54);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnComplete
            // 
            btnComplete.BackColor = Color.Plum;
            btnComplete.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnComplete.ForeColor = SystemColors.ControlLightLight;
            btnComplete.Location = new Point(443, 103);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(123, 54);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Complete";
            btnComplete.UseVisualStyleBackColor = false;
            btnComplete.Click += btnComplete_Click;
            // 
            // txtBUsername
            // 
            txtBUsername.Location = new Point(298, 45);
            txtBUsername.Name = "txtBUsername";
            txtBUsername.Size = new Size(268, 27);
            txtBUsername.TabIndex = 4;
            txtBUsername.Text = "Username";
            txtBUsername.MouseClick += txtBUsername_MouseClick;
            // 
            // dPickerDate
            // 
            dPickerDate.Location = new Point(589, 45);
            dPickerDate.Name = "dPickerDate";
            dPickerDate.Size = new Size(218, 27);
            dPickerDate.TabIndex = 5;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Plum;
            btnFilter.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.ForeColor = SystemColors.ControlLightLight;
            btnFilter.Location = new Point(848, 30);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(123, 54);
            btnFilter.TabIndex = 6;
            btnFilter.Text = "Filter";
            btnFilter.UseVisualStyleBackColor = false;
            btnFilter.Click += btnFilter_Click;
            // 
            // cBUsername
            // 
            cBUsername.AutoSize = true;
            cBUsername.Location = new Point(423, 22);
            cBUsername.Name = "cBUsername";
            cBUsername.Size = new Size(18, 17);
            cBUsername.TabIndex = 7;
            cBUsername.UseVisualStyleBackColor = true;
            // 
            // cBDate
            // 
            cBDate.AutoSize = true;
            cBDate.Location = new Point(689, 22);
            cBDate.Name = "cBDate";
            cBDate.Size = new Size(18, 17);
            cBDate.TabIndex = 8;
            cBDate.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 603);
            Controls.Add(cBDate);
            Controls.Add(cBUsername);
            Controls.Add(btnFilter);
            Controls.Add(dPickerDate);
            Controls.Add(txtBUsername);
            Controls.Add(btnComplete);
            Controls.Add(btnCancel);
            Controls.Add(dataGridViewAppointments);
            Controls.Add(fLPanelMenu);
            Name = "AdminPanel";
            Text = "Beauty Studio";
            fLPanelMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            panelAdmin.ResumeLayout(false);
            panelAppointments.ResumeLayout(false);
            panelLogOut.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewAppointments).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel fLPanelMenu;
        private Panel panelLogo;
        private PictureBox pBLogo;
        private Panel panelAdmin;
        private Label lbAdmin;
        private Panel panelGap1;
        private Panel panelAppointments;
        private Button btnM;
        private Panel panelGap2;
        private Panel panelLogOut;
        private Button btnLogOut;
        private DataGridView dataGridViewAppointments;
        private Button btnCancel;
        private Button btnComplete;
        private TextBox txtBUsername;
        private DateTimePicker dPickerDate;
        private Button btnFilter;
        private Button btnAppointments;
        private Panel panelGap3;
        private Panel panel1;
        private Button btnMessages;
        private CheckBox cBUsername;
        private CheckBox cBDate;
    }
}