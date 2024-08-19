namespace BeautyStudio
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            pBLogo = new PictureBox();
            txtUsername = new TextBox();
            lbPassword = new Label();
            lbUsername = new Label();
            txtPassword = new TextBox();
            btnLogIn = new Button();
            btnRegister = new Button();
            ((System.ComponentModel.ISupportInitialize)pBLogo).BeginInit();
            SuspendLayout();
            // 
            // pBLogo
            // 
            pBLogo.BackgroundImageLayout = ImageLayout.None;
            pBLogo.Image = (Image)resources.GetObject("pBLogo.Image");
            pBLogo.Location = new Point(318, 31);
            pBLogo.Name = "pBLogo";
            pBLogo.Size = new Size(334, 228);
            pBLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pBLogo.TabIndex = 1;
            pBLogo.TabStop = false;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(436, 320);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Multiline = true;
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(300, 35);
            txtUsername.TabIndex = 2;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbPassword.ForeColor = SystemColors.ControlLightLight;
            lbPassword.Location = new Point(203, 381);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(198, 35);
            lbPassword.TabIndex = 3;
            lbPassword.Text = "Enter Password:";
            // 
            // lbUsername
            // 
            lbUsername.AutoSize = true;
            lbUsername.Font = new Font("Impact", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            lbUsername.ForeColor = SystemColors.ControlLightLight;
            lbUsername.Location = new Point(203, 320);
            lbUsername.Name = "lbUsername";
            lbUsername.Size = new Size(203, 35);
            lbUsername.TabIndex = 4;
            lbUsername.Text = "Enter Username:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(436, 381);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Multiline = true;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(300, 35);
            txtPassword.TabIndex = 5;
            // 
            // btnLogIn
            // 
            btnLogIn.BackColor = Color.Plum;
            btnLogIn.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.ForeColor = SystemColors.ControlLightLight;
            btnLogIn.Location = new Point(349, 457);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(123, 54);
            btnLogIn.TabIndex = 6;
            btnLogIn.Text = "Log In";
            btnLogIn.UseVisualStyleBackColor = false;
            btnLogIn.Click += btnLogIn_Click;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Plum;
            btnRegister.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnRegister.ForeColor = SystemColors.ControlLightLight;
            btnRegister.Location = new Point(507, 457);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(123, 54);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "New User?";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(183, 130, 187);
            ClientSize = new Size(1010, 603);
            Controls.Add(btnRegister);
            Controls.Add(btnLogIn);
            Controls.Add(txtPassword);
            Controls.Add(lbUsername);
            Controls.Add(lbPassword);
            Controls.Add(txtUsername);
            Controls.Add(pBLogo);
            Name = "LogIn";
            Text = "Beauty Studio";
            ((System.ComponentModel.ISupportInitialize)pBLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pBLogo;
        private TextBox txtUsername;
        private Label lbPassword;
        private Label lbUsername;
        private TextBox txtPassword;
        private Button btnLogIn;
        private Button btnRegister;
    }
}