namespace BeautyStudio
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            pBLogo = new PictureBox();
            btnRegister = new Button();
            txtLastName = new TextBox();
            lbUsername = new Label();
            lbPassword = new Label();
            txtFirstName = new TextBox();
            lbFirstName = new Label();
            lbLastName = new Label();
            lbEmail = new Label();
            txtUsername = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            SuspendLayout();
            // 
            // pBLogo
            // 
            pBLogo.BackgroundImageLayout = ImageLayout.None;
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(318, 32);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(334, 228);
            pBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBLogo.TabIndex = 2;
            pBLogo.TabStop = false;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Plum;
            btnRegister.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(828, 440);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 54);
            btnRegister.TabIndex = 12;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(313, 368);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(215, 35);
            txtLastName.TabIndex = 11;
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(72, 426);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(203, 35);
            lbUsername.TabIndex = 10;
            lbUsername.Text = "Enter Username:";
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.ForeColor = SystemColors.ControlLightLight;
            lbPassword.Location = new Point(712, 309);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(198, 35);
            lbPassword.TabIndex = 9;
            lbPassword.Text = "Enter Password:";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(313, 309);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(215, 35);
            txtFirstName.TabIndex = 8;
            // 
            // lbFirstName
            // 
            lbFirstName.AutoSize = true;
            lbFirstName.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbFirstName.ForeColor = SystemColors.ControlLightLight;
            lbFirstName.Location = new Point(72, 309);
            lbFirstName.Name = "lbFirstName";
            lbFirstName.Size = new Size(206, 35);
            lbFirstName.TabIndex = 13;
            lbFirstName.Text = "Enter First Name:";
            // 
            // lbLastName
            // 
            lbLastName.AutoSize = true;
            lbLastName.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbLastName.ForeColor = SystemColors.ControlLightLight;
            lbLastName.Location = new Point(72, 368);
            lbLastName.Name = "lbLastName";
            lbLastName.Size = new Size(203, 35);
            lbLastName.TabIndex = 14;
            lbLastName.Text = "Enter Last Name:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.ForeColor = SystemColors.ControlLightLight;
            lbEmail.Location = new Point(72, 486);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(148, 35);
            lbEmail.TabIndex = 15;
            lbEmail.Text = "Enter Email:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(313, 426);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(215, 35);
            txtUsername.TabIndex = 16;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(313, 486);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(215, 35);
            txtEmail.TabIndex = 17;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(712, 368);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(215, 35);
            txtPassword.TabIndex = 18;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Plum;
            btnCancel.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.ControlLightLight;
            btnCancel.Location = new Point(662, 440);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(123, 54);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 130, 187);
            ClientSize = new Size(1010, 603);
            Controls.Add(btnCancel);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtUsername);
            Controls.Add(lbEmail);
            Controls.Add(lbLastName);
            Controls.Add(lbFirstName);
            Controls.Add(btnRegister);
            Controls.Add(txtLastName);
            Controls.Add(lbUsername);
            Controls.Add(lbPassword);
            Controls.Add(txtFirstName);
            Controls.Add(pBLogo);
            Name = "Register";
            Text = "Beauty Studio";
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBLogo;
        private Button btnRegister;
        private TextBox txtLastName;
        private Label lbUsername;
        private Label lbPassword;
        private TextBox txtFirstName;
        private Label lbFirstName;
        private Label lbLastName;
        private Label lbEmail;
        private TextBox txtUsername;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Button btnCancel;
    }
}