namespace proj
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.FullPanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BaatLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.ForgotPassword = new System.Windows.Forms.LinkLabel();
            this.LogInButton = new System.Windows.Forms.Button();
            this.RememberCheck = new System.Windows.Forms.CheckBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.LogInPanel = new System.Windows.Forms.Panel();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.SignUpLInk = new System.Windows.Forms.LinkLabel();
            this.SignUpLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.FullPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.LogInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // FullPanel
            // 
            this.FullPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FullPanel.Controls.Add(this.pictureBox1);
            this.FullPanel.Controls.Add(this.BaatLabel);
            this.FullPanel.Controls.Add(this.TitleLabel);
            this.FullPanel.Location = new System.Drawing.Point(76, 42);
            this.FullPanel.Name = "FullPanel";
            this.FullPanel.Size = new System.Drawing.Size(800, 450);
            this.FullPanel.TabIndex = 0;
            this.FullPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.LogInPanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // BaatLabel
            // 
            this.BaatLabel.AutoSize = true;
            this.BaatLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaatLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaatLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.BaatLabel.Location = new System.Drawing.Point(101, 355);
            this.BaatLabel.Name = "BaatLabel";
            this.BaatLabel.Size = new System.Drawing.Size(304, 23);
            this.BaatLabel.TabIndex = 2;
            this.BaatLabel.Text = "Let\'s pick up right where we left off.";
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("MS Gothic", 19.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLabel.Location = new System.Drawing.Point(-6, 224);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(434, 154);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Welcome Back Gym-Warrior! \r\nLog-in to your account.";
            this.TitleLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ForgotPassword
            // 
            this.ForgotPassword.AutoSize = true;
            this.ForgotPassword.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForgotPassword.LinkColor = System.Drawing.Color.Black;
            this.ForgotPassword.Location = new System.Drawing.Point(192, 257);
            this.ForgotPassword.Name = "ForgotPassword";
            this.ForgotPassword.Size = new System.Drawing.Size(116, 16);
            this.ForgotPassword.TabIndex = 8;
            this.ForgotPassword.TabStop = true;
            this.ForgotPassword.Text = "Forgot Password?";
            // 
            // LogInButton
            // 
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(48, 294);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(262, 42);
            this.LogInButton.TabIndex = 7;
            this.LogInButton.Text = "Log In";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // RememberCheck
            // 
            this.RememberCheck.AutoSize = true;
            this.RememberCheck.BackColor = System.Drawing.Color.Transparent;
            this.RememberCheck.Location = new System.Drawing.Point(48, 257);
            this.RememberCheck.Name = "RememberCheck";
            this.RememberCheck.Size = new System.Drawing.Size(132, 20);
            this.RememberCheck.TabIndex = 6;
            this.RememberCheck.Text = "Show Password?";
            this.RememberCheck.UseVisualStyleBackColor = false;
            this.RememberCheck.CheckedChanged += new System.EventHandler(this.RememberCheck_CheckedChanged);
            // 
            // PasswordBox
            // 
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.Location = new System.Drawing.Point(48, 200);
            this.PasswordBox.Multiline = true;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(260, 35);
            this.PasswordBox.TabIndex = 5;
            this.PasswordBox.TextChanged += new System.EventHandler(this.PasswordBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.Location = new System.Drawing.Point(48, 143);
            this.EmailBox.Multiline = true;
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(260, 35);
            this.EmailBox.TabIndex = 4;
            this.EmailBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(10, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(335, 130);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            // 
            // LogInPanel
            // 
            this.LogInPanel.Controls.Add(this.EmailLabel);
            this.LogInPanel.Controls.Add(this.PasswordLabel);
            this.LogInPanel.Controls.Add(this.SignUpLInk);
            this.LogInPanel.Controls.Add(this.SignUpLabel);
            this.LogInPanel.Controls.Add(this.Logo);
            this.LogInPanel.Controls.Add(this.ForgotPassword);
            this.LogInPanel.Controls.Add(this.LogInButton);
            this.LogInPanel.Controls.Add(this.RememberCheck);
            this.LogInPanel.Controls.Add(this.PasswordBox);
            this.LogInPanel.Controls.Add(this.EmailBox);
            this.LogInPanel.Location = new System.Drawing.Point(528, 42);
            this.LogInPanel.Name = "LogInPanel";
            this.LogInPanel.Size = new System.Drawing.Size(350, 450);
            this.LogInPanel.TabIndex = 12;
            this.LogInPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // EmailLabel
            // 
            this.EmailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.EmailLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EmailLabel.Location = new System.Drawing.Point(60, 153);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(67, 16);
            this.EmailLabel.TabIndex = 15;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PasswordLabel.Location = new System.Drawing.Point(60, 210);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(100, 16);
            this.PasswordLabel.TabIndex = 14;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Click += new System.EventHandler(this.PasswordLabel_Click);
            // 
            // SignUpLInk
            // 
            this.SignUpLInk.AutoSize = true;
            this.SignUpLInk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpLInk.Location = new System.Drawing.Point(217, 373);
            this.SignUpLInk.Name = "SignUpLInk";
            this.SignUpLInk.Size = new System.Drawing.Size(91, 16);
            this.SignUpLInk.TabIndex = 13;
            this.SignUpLInk.TabStop = true;
            this.SignUpLInk.Text = "Register Now!";
            this.SignUpLInk.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.SignUpLInk_LinkClicked);
            // 
            // SignUpLabel
            // 
            this.SignUpLabel.AutoSize = true;
            this.SignUpLabel.Location = new System.Drawing.Point(45, 373);
            this.SignUpLabel.Name = "SignUpLabel";
            this.SignUpLabel.Size = new System.Drawing.Size(146, 16);
            this.SignUpLabel.TabIndex = 12;
            this.SignUpLabel.Text = "Don\'t have an account?";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(913, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(44, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 56;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LogInPanel);
            this.Controls.Add(this.FullPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.FullPanel.ResumeLayout(false);
            this.FullPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.LogInPanel.ResumeLayout(false);
            this.LogInPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel FullPanel;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.LinkLabel ForgotPassword;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.CheckBox RememberCheck;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel LogInPanel;
        private System.Windows.Forms.LinkLabel SignUpLInk;
        private System.Windows.Forms.Label SignUpLabel;
        private System.Windows.Forms.Label BaatLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}