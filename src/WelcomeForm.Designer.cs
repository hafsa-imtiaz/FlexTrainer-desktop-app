namespace proj
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.Main = new System.Windows.Forms.Panel();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.EquipmentImage = new System.Windows.Forms.PictureBox();
            this.AboutLabel = new System.Windows.Forms.LinkLabel();
            this.ServicesLabel = new System.Windows.Forms.LinkLabel();
            this.HomeLabel = new System.Windows.Forms.LinkLabel();
            this.LogInButton = new System.Windows.Forms.Button();
            this.SignButton = new System.Windows.Forms.Button();
            this.Descrip = new System.Windows.Forms.Label();
            this.TitlePhrase = new System.Windows.Forms.Label();
            this.Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentImage)).BeginInit();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Main.Controls.Add(this.logoPic);
            this.Main.Controls.Add(this.EquipmentImage);
            this.Main.Controls.Add(this.AboutLabel);
            this.Main.Controls.Add(this.ServicesLabel);
            this.Main.Controls.Add(this.HomeLabel);
            this.Main.Controls.Add(this.LogInButton);
            this.Main.Controls.Add(this.SignButton);
            this.Main.Controls.Add(this.Descrip);
            this.Main.Controls.Add(this.TitlePhrase);
            this.Main.Location = new System.Drawing.Point(76, 45);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(800, 455);
            this.Main.TabIndex = 0;
            this.Main.Paint += new System.Windows.Forms.PaintEventHandler(this.Main_Paint);
            // 
            // logoPic
            // 
            this.logoPic.BackColor = System.Drawing.Color.Transparent;
            this.logoPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoPic.BackgroundImage")));
            this.logoPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPic.Location = new System.Drawing.Point(45, 0);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(264, 83);
            this.logoPic.TabIndex = 13;
            this.logoPic.TabStop = false;
            // 
            // EquipmentImage
            // 
            this.EquipmentImage.BackColor = System.Drawing.Color.Transparent;
            this.EquipmentImage.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EquipmentImage.BackgroundImage")));
            this.EquipmentImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.EquipmentImage.Location = new System.Drawing.Point(475, 118);
            this.EquipmentImage.Name = "EquipmentImage";
            this.EquipmentImage.Size = new System.Drawing.Size(335, 370);
            this.EquipmentImage.TabIndex = 12;
            this.EquipmentImage.TabStop = false;
            // 
            // AboutLabel
            // 
            this.AboutLabel.ActiveLinkColor = System.Drawing.Color.Gold;
            this.AboutLabel.AutoSize = true;
            this.AboutLabel.BackColor = System.Drawing.Color.Transparent;
            this.AboutLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutLabel.LinkColor = System.Drawing.Color.SeaShell;
            this.AboutLabel.Location = new System.Drawing.Point(537, 12);
            this.AboutLabel.Name = "AboutLabel";
            this.AboutLabel.Size = new System.Drawing.Size(70, 20);
            this.AboutLabel.TabIndex = 11;
            this.AboutLabel.TabStop = true;
            this.AboutLabel.Text = "About Us";
            // 
            // ServicesLabel
            // 
            this.ServicesLabel.ActiveLinkColor = System.Drawing.Color.Gold;
            this.ServicesLabel.AutoSize = true;
            this.ServicesLabel.BackColor = System.Drawing.Color.Transparent;
            this.ServicesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServicesLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ServicesLabel.LinkColor = System.Drawing.Color.SeaShell;
            this.ServicesLabel.Location = new System.Drawing.Point(643, 12);
            this.ServicesLabel.Name = "ServicesLabel";
            this.ServicesLabel.Size = new System.Drawing.Size(91, 20);
            this.ServicesLabel.TabIndex = 10;
            this.ServicesLabel.TabStop = true;
            this.ServicesLabel.Text = "Our Services";
            this.ServicesLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ServicesLabel_LinkClicked);
            // 
            // HomeLabel
            // 
            this.HomeLabel.ActiveLinkColor = System.Drawing.Color.Gold;
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.HomeLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HomeLabel.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeLabel.LinkColor = System.Drawing.Color.Navy;
            this.HomeLabel.Location = new System.Drawing.Point(437, 12);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(50, 20);
            this.HomeLabel.TabIndex = 9;
            this.HomeLabel.TabStop = true;
            this.HomeLabel.Text = "Home";
            this.HomeLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.HomeLabel_Click);
            // 
            // LogInButton
            // 
            this.LogInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInButton.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogInButton.Location = new System.Drawing.Point(233, 339);
            this.LogInButton.Name = "LogInButton";
            this.LogInButton.Size = new System.Drawing.Size(181, 45);
            this.LogInButton.TabIndex = 3;
            this.LogInButton.Text = "LOG IN";
            this.LogInButton.UseVisualStyleBackColor = true;
            this.LogInButton.Click += new System.EventHandler(this.LogInButton_Click);
            // 
            // SignButton
            // 
            this.SignButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SignButton.Font = new System.Drawing.Font("MS Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SignButton.Location = new System.Drawing.Point(45, 339);
            this.SignButton.Name = "SignButton";
            this.SignButton.Size = new System.Drawing.Size(182, 45);
            this.SignButton.TabIndex = 2;
            this.SignButton.Text = "SIGN UP";
            this.SignButton.UseVisualStyleBackColor = true;
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // Descrip
            // 
            this.Descrip.BackColor = System.Drawing.Color.Transparent;
            this.Descrip.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Descrip.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.Descrip.Location = new System.Drawing.Point(41, 206);
            this.Descrip.Name = "Descrip";
            this.Descrip.Size = new System.Drawing.Size(401, 120);
            this.Descrip.TabIndex = 1;
            this.Descrip.Text = resources.GetString("Descrip.Text");
            // 
            // TitlePhrase
            // 
            this.TitlePhrase.BackColor = System.Drawing.Color.Transparent;
            this.TitlePhrase.Font = new System.Drawing.Font("MS Gothic", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitlePhrase.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.TitlePhrase.Location = new System.Drawing.Point(38, 118);
            this.TitlePhrase.Name = "TitlePhrase";
            this.TitlePhrase.Size = new System.Drawing.Size(500, 100);
            this.TitlePhrase.TabIndex = 0;
            this.TitlePhrase.Text = "Empowering Every Rep, Inspiring Every Step";
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(950, 550);
            this.Controls.Add(this.Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Welcome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogIn";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.Main.ResumeLayout(false);
            this.Main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Main;
        private System.Windows.Forms.Label TitlePhrase;
        private System.Windows.Forms.Button LogInButton;
        private System.Windows.Forms.Button SignButton;
        private System.Windows.Forms.Label Descrip;
        private System.Windows.Forms.LinkLabel HomeLabel;
        private System.Windows.Forms.LinkLabel AboutLabel;
        private System.Windows.Forms.LinkLabel ServicesLabel;
        private System.Windows.Forms.PictureBox EquipmentImage;
        private System.Windows.Forms.PictureBox logoPic;
    }
}