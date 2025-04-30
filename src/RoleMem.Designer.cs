namespace proj
{
    partial class RoleMem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoleMem));
            this.SignUpPanel = new System.Windows.Forms.Panel();
            this.callcode = new System.Windows.Forms.TextBox();
            this.phonelabel = new System.Windows.Forms.Label();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.DoBLabel = new System.Windows.Forms.Label();
            this.standcheck = new System.Windows.Forms.CheckBox();
            this.premcheck = new System.Windows.Forms.CheckBox();
            this.pluscheck = new System.Windows.Forms.CheckBox();
            this.addlabel = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.TextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.SignUpButton = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.LogLink = new System.Windows.Forms.LinkLabel();
            this.LogLabel = new System.Windows.Forms.Label();
            this.gymbox = new System.Windows.Forms.ComboBox();
            this.idbox = new System.Windows.Forms.ComboBox();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.SignUpPanel.Controls.Add(this.gymbox);
            this.SignUpPanel.Controls.Add(this.callcode);
            this.SignUpPanel.Controls.Add(this.phonelabel);
            this.SignUpPanel.Controls.Add(this.phonenumber);
            this.SignUpPanel.Controls.Add(this.DoBLabel);
            this.SignUpPanel.Controls.Add(this.standcheck);
            this.SignUpPanel.Controls.Add(this.premcheck);
            this.SignUpPanel.Controls.Add(this.pluscheck);
            this.SignUpPanel.Controls.Add(this.addlabel);
            this.SignUpPanel.Controls.Add(this.address);
            this.SignUpPanel.Controls.Add(this.Logo);
            this.SignUpPanel.Controls.Add(this.SignUpButton);
            this.SignUpPanel.Location = new System.Drawing.Point(75, 50);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(800, 450);
            this.SignUpPanel.TabIndex = 1;
            this.SignUpPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.SignUpPanel_Paint);
            // 
            // callcode
            // 
            this.callcode.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callcode.Location = new System.Drawing.Point(50, 175);
            this.callcode.Multiline = true;
            this.callcode.Name = "callcode";
            this.callcode.Size = new System.Drawing.Size(37, 29);
            this.callcode.TabIndex = 37;
            this.callcode.Text = "+92";
            this.callcode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phonelabel
            // 
            this.phonelabel.AutoSize = true;
            this.phonelabel.BackColor = System.Drawing.Color.White;
            this.phonelabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phonelabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonelabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.phonelabel.Location = new System.Drawing.Point(93, 178);
            this.phonelabel.Name = "phonelabel";
            this.phonelabel.Size = new System.Drawing.Size(96, 17);
            this.phonelabel.TabIndex = 36;
            this.phonelabel.Text = "Phone Number";
            this.phonelabel.Click += new System.EventHandler(this.phonelabel_Click);
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(93, 175);
            this.phonenumber.Multiline = true;
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(133, 29);
            this.phonenumber.TabIndex = 35;
            this.phonenumber.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // DoBLabel
            // 
            this.DoBLabel.AutoSize = true;
            this.DoBLabel.BackColor = System.Drawing.Color.Transparent;
            this.DoBLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DoBLabel.Location = new System.Drawing.Point(46, 294);
            this.DoBLabel.Name = "DoBLabel";
            this.DoBLabel.Size = new System.Drawing.Size(167, 16);
            this.DoBLabel.TabIndex = 32;
            this.DoBLabel.Text = "Choose Membership Type";
            // 
            // standcheck
            // 
            this.standcheck.AutoSize = true;
            this.standcheck.BackColor = System.Drawing.Color.Transparent;
            this.standcheck.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.standcheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.standcheck.Location = new System.Drawing.Point(51, 323);
            this.standcheck.Name = "standcheck";
            this.standcheck.Size = new System.Drawing.Size(85, 27);
            this.standcheck.TabIndex = 31;
            this.standcheck.Text = "Bronze";
            this.standcheck.UseVisualStyleBackColor = false;
            this.standcheck.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // premcheck
            // 
            this.premcheck.AutoSize = true;
            this.premcheck.BackColor = System.Drawing.Color.Transparent;
            this.premcheck.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.premcheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.premcheck.Location = new System.Drawing.Point(310, 323);
            this.premcheck.Name = "premcheck";
            this.premcheck.Size = new System.Drawing.Size(100, 27);
            this.premcheck.TabIndex = 30;
            this.premcheck.Text = "Platinum";
            this.premcheck.UseVisualStyleBackColor = false;
            this.premcheck.CheckedChanged += new System.EventHandler(this.premcheck_CheckedChanged);
            // 
            // pluscheck
            // 
            this.pluscheck.AutoSize = true;
            this.pluscheck.BackColor = System.Drawing.Color.Transparent;
            this.pluscheck.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pluscheck.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pluscheck.Location = new System.Drawing.Point(199, 323);
            this.pluscheck.Name = "pluscheck";
            this.pluscheck.Size = new System.Drawing.Size(67, 27);
            this.pluscheck.TabIndex = 29;
            this.pluscheck.Text = "Goal";
            this.pluscheck.UseVisualStyleBackColor = false;
            this.pluscheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // addlabel
            // 
            this.addlabel.AutoSize = true;
            this.addlabel.BackColor = System.Drawing.Color.White;
            this.addlabel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addlabel.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addlabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addlabel.Location = new System.Drawing.Point(55, 140);
            this.addlabel.Name = "addlabel";
            this.addlabel.Size = new System.Drawing.Size(56, 17);
            this.addlabel.TabIndex = 28;
            this.addlabel.Text = "Address";
            this.addlabel.Click += new System.EventHandler(this.addlabel_Click);
            // 
            // address
            // 
            this.address.Location = new System.Drawing.Point(51, 134);
            this.address.Multiline = true;
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(360, 35);
            this.address.TabIndex = 27;
            this.address.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
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
            // 
            // SignUpButton
            // 
            this.SignUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignUpButton.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignUpButton.Location = new System.Drawing.Point(96, 372);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.Size = new System.Drawing.Size(262, 42);
            this.SignUpButton.TabIndex = 7;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.UseVisualStyleBackColor = true;
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SidePanel.Controls.Add(this.button4);
            this.SidePanel.Controls.Add(this.button3);
            this.SidePanel.Controls.Add(this.button2);
            this.SidePanel.Controls.Add(this.button1);
            this.SidePanel.Controls.Add(this.pictureBox1);
            this.SidePanel.Controls.Add(this.TitleLabel);
            this.SidePanel.Controls.Add(this.LogLink);
            this.SidePanel.Controls.Add(this.LogLabel);
            this.SidePanel.Location = new System.Drawing.Point(535, 50);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(350, 450);
            this.SidePanel.TabIndex = 22;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(0, 310);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(350, 50);
            this.button4.TabIndex = 21;
            this.button4.Text = "Admin";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            this.button4.MouseLeave += new System.EventHandler(this.button4_MouseLeave);
            this.button4.MouseHover += new System.EventHandler(this.button4_MouseHover);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(0, 260);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(350, 50);
            this.button3.TabIndex = 20;
            this.button3.Text = "Gym Owner";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.MouseLeave += new System.EventHandler(this.button3_MouseLeave);
            this.button3.MouseHover += new System.EventHandler(this.button3_MouseHover);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(0, 210);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(350, 50);
            this.button2.TabIndex = 19;
            this.button2.Text = "Trainer";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            this.button2.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            this.button2.MouseHover += new System.EventHandler(this.button2_MouseHover);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(0, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(350, 50);
            this.button1.TabIndex = 18;
            this.button1.Text = "Member";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(30, 103);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TitleLabel
            // 
            this.TitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.TitleLabel.Font = new System.Drawing.Font("MS Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLabel.Location = new System.Drawing.Point(25, 29);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(281, 111);
            this.TitleLabel.TabIndex = 15;
            this.TitleLabel.Text = "Welcome to Flex Trainer!";
            // 
            // LogLink
            // 
            this.LogLink.AutoSize = true;
            this.LogLink.BackColor = System.Drawing.Color.Transparent;
            this.LogLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLink.LinkColor = System.Drawing.Color.White;
            this.LogLink.Location = new System.Drawing.Point(235, 394);
            this.LogLink.Name = "LogLink";
            this.LogLink.Size = new System.Drawing.Size(55, 20);
            this.LogLink.TabIndex = 13;
            this.LogLink.TabStop = true;
            this.LogLink.Text = "Log In";
            this.LogLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogLink_LinkClicked);
            // 
            // LogLabel
            // 
            this.LogLabel.AutoSize = true;
            this.LogLabel.BackColor = System.Drawing.Color.Transparent;
            this.LogLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogLabel.Location = new System.Drawing.Point(42, 396);
            this.LogLabel.Name = "LogLabel";
            this.LogLabel.Size = new System.Drawing.Size(176, 18);
            this.LogLabel.TabIndex = 12;
            this.LogLabel.Text = "Already have an account?";
            // 
            // gymbox
            // 
            this.gymbox.FormattingEnabled = true;
            this.gymbox.Location = new System.Drawing.Point(49, 236);
            this.gymbox.Name = "gymbox";
            this.gymbox.Size = new System.Drawing.Size(362, 24);
            this.gymbox.TabIndex = 38;
            this.gymbox.SelectedIndexChanged += new System.EventHandler(this.gymbox_SelectedIndexChanged);
            // 
            // idbox
            // 
            this.idbox.FormattingEnabled = true;
            this.idbox.Location = new System.Drawing.Point(12, 514);
            this.idbox.Name = "idbox";
            this.idbox.Size = new System.Drawing.Size(362, 24);
            this.idbox.TabIndex = 39;
            // 
            // RoleMem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.idbox);
            this.Controls.Add(this.SidePanel);
            this.Controls.Add(this.SignUpPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RoleMem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RoleMem";
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
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button SignUpButton;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.LinkLabel LogLink;
        private System.Windows.Forms.Label LogLabel;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label addlabel;
        private System.Windows.Forms.TextBox address;
        private System.Windows.Forms.CheckBox pluscheck;
        private System.Windows.Forms.CheckBox standcheck;
        private System.Windows.Forms.CheckBox premcheck;
        private System.Windows.Forms.Label DoBLabel;
        private System.Windows.Forms.TextBox callcode;
        private System.Windows.Forms.Label phonelabel;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.ComboBox gymbox;
        private System.Windows.Forms.ComboBox idbox;
    }
}