namespace proj
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.PassLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.DateBox = new System.Windows.Forms.ComboBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.FNameText = new System.Windows.Forms.TextBox();
            this.LNameText = new System.Windows.Forms.TextBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BaatLabel = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogLink = new System.Windows.Forms.LinkLabel();
            this.LogLabel = new System.Windows.Forms.Label();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.Transparent;
            this.SignUpPanel.Controls.Add(this.PassLabel);
            this.SignUpPanel.Controls.Add(this.EmailLabel);
            this.SignUpPanel.Controls.Add(this.LNameLabel);
            this.SignUpPanel.Controls.Add(this.FNameLabel);
            this.SignUpPanel.Controls.Add(this.DoBLabel);
            this.SignUpPanel.Controls.Add(this.YearBox);
            this.SignUpPanel.Controls.Add(this.MonthBox);
            this.SignUpPanel.Controls.Add(this.DateBox);
            this.SignUpPanel.Controls.Add(this.PasswordText);
            this.SignUpPanel.Controls.Add(this.EmailText);
            this.SignUpPanel.Controls.Add(this.Logo);
            this.SignUpPanel.Controls.Add(this.FNameText);
            this.SignUpPanel.Controls.Add(this.LNameText);
            this.SignUpPanel.Controls.Add(this.SignUpButton);
            this.SignUpPanel.Location = new System.Drawing.Point(76, 42);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(800, 450);
            this.SignUpPanel.TabIndex = 0;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpPanel_Paint);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(55, 227);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(75, 18);
            this.PassLabel.TabIndex = 19;
            this.PassLabel.Text = "Password";
            this.PassLabel.Click += new System.EventHandler(this.PassLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(55, 175);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 18);
            this.EmailLabel.TabIndex = 20;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(246, 125);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(80, 18);
            this.LNameLabel.TabIndex = 21;
            this.LNameLabel.Text = "Last Name";
            this.LNameLabel.Click += new System.EventHandler(this.LNameLabel_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(55, 125);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(81, 18);
            this.FNameLabel.TabIndex = 18;
            this.FNameLabel.Text = "First Name";
            this.FNameLabel.Click += new System.EventHandler(this.FNameLabel_Click);
            // 
            // DoBLabel
            // 
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.Location = new System.Drawing.Point(41, 273);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(86, 16);
            this.DoBLabel.TabIndex = 19;
            this.DoBLabel.Text = "Date of Birth?";
            // 
            // YearBox
            // 
            this.YearBox.DropDownHeight = 70;
            this.YearBox.DropDownWidth = 80;
            this.YearBox.FormattingEnabled = true;
            this.YearBox.IntegralHeight = false;
            this.YearBox.Items.AddRange(new object[] {
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980"});
            this.YearBox.Location = new System.Drawing.Point(292, 292);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(121, 24);
            this.YearBox.TabIndex = 18;
            this.YearBox.Text = "Year";
            // 
            // MonthBox
            // 
            this.MonthBox.DropDownHeight = 70;
            this.MonthBox.DropDownWidth = 80;
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.IntegralHeight = false;
            this.MonthBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apr",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.MonthBox.Location = new System.Drawing.Point(165, 292);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(121, 24);
            this.MonthBox.TabIndex = 17;
            this.MonthBox.Text = "Month";
            // 
            // DateBox
            // 
            this.DateBox.AllowDrop = true;
            this.DateBox.DropDownHeight = 70;
            this.DateBox.DropDownWidth = 80;
            this.DateBox.FormattingEnabled = true;
            this.DateBox.IntegralHeight = false;
            this.DateBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.DateBox.Location = new System.Drawing.Point(44, 292);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(115, 24);
            this.DateBox.TabIndex = 16;
            this.DateBox.Text = "Date";
            // 
            // PasswordText
            // 
            this.PasswordText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordText.Location = new System.Drawing.Point(44, 220);
            this.PasswordText.Multiline = true;
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(369, 35);
            this.PasswordText.TabIndex = 13;
            this.PasswordText.TextChanged += new System.EventHandler(this.PasswordText_TextChanged);
            // 
            // EmailText
            // 
            this.EmailText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailText.Location = new System.Drawing.Point(44, 168);
            this.EmailText.Multiline = true;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(369, 35);
            this.EmailText.TabIndex = 12;
            this.EmailText.TextChanged += new System.EventHandler(this.EmailText_TextChanged);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(59, -19);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(335, 130);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 11;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FNameText
            // 
            this.FNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FNameText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameText.Location = new System.Drawing.Point(44, 117);
            this.FNameText.Multiline = true;
            this.FNameText.Name = "FNameText";
            this.FNameText.Size = new System.Drawing.Size(175, 35);
            this.FNameText.TabIndex = 4;
            this.FNameText.TextChanged += new System.EventHandler(this.FNameText_TextChanged);
            // 
            // LNameText
            // 
            this.LNameText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LNameText.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameText.Location = new System.Drawing.Point(234, 117);
            this.LNameText.Multiline = true;
            this.LNameText.Name = "LNameText";
            this.LNameText.Size = new System.Drawing.Size(179, 35);
            this.LNameText.TabIndex = 5;
            this.LNameText.TextChanged += new System.EventHandler(this.LNameText_TextChanged);
            // 
            // SignUpButton
            // 
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(96, 372);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(262, 42);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Next";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.Teal;
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.BaatLabel);
            this.SidePanel.Controls.Add(this.TitleLabel);
            this.SidePanel.Controls.Add(this.LogLink);
            this.SidePanel.Controls.Add(this.LogLabel);
            this.SidePanel.Location = new System.Drawing.Point(526, 42);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(350, 450);
            this.SidePanel.TabIndex = 13;
            this.SidePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SidePanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 143);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // BaatLabel
            // 
            this.BaatLabel.BackColor = System.Drawing.Color.Transparent;
            this.BaatLabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaatLabel.ForeColor = System.Drawing.SystemColors.Info;
            this.BaatLabel.Location = new System.Drawing.Point(26, 294);
            this.BaatLabel.Name = "BaatLabel";
            this.BaatLabel.Size = new System.Drawing.Size(303, 78);
            this.BaatLabel.TabIndex = 16;
            this.BaatLabel.Text = "Let\'s make every rep count and turn your ambitions into achievements.";
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("MS Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLabel.Location = new System.Drawing.Point(24, 183);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(281, 111);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Join The Flex Trainer Family!";
            // 
            // LogLink
            // 
            this.LogLink.AutoSize = true;
            this.LogLink.BackColor = System.Drawing.Color.Transparent;
            this.LogLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLink.Location = new System.Drawing.Point(231, 370);
            this.LogLink.Name = "LogLink";
            this.LogLink.Size = new System.Drawing.Size(55, 20);
            this.LogLink.TabIndex = 13;
            this.LogLink.TabStop = true;
            this.LogLink.Text = "Log In";
            this.LogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.Location = new System.Drawing.Point(39, 372);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(176, 18);
            this.LogLabel.TabIndex = 12;
            this.LogLabel.Text = "Already have an account?";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.SignUpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.Load += new System.EventHandler(this.SignUp_Load);
            this.SignUpPanel.ResumeLayout(false);
            this.SignUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SidePanel.ResumeLayout(false);
            this.SidePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SignUpPanel;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.LinkLabel LogLink;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.TextBox LNameText;
        private System.Windows.Forms.TextBox FNameText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.ComboBox DateBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.Label BaatLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label PassLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label LNameLabel;
        private System.Windows.Forms.Label FNameLabel;
    }
}