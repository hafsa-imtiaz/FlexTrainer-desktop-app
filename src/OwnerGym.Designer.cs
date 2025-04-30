namespace proj
{
    partial class OwnerGym
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerGym));
            this.bgpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.welcome = new System.Windows.Forms.Label();
            this.requestpanel = new System.Windows.Forms.Panel();
            this.resultpanel = new System.Windows.Forms.Panel();
            this.delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nobox = new System.Windows.Forms.TextBox();
            this.address = new System.Windows.Forms.Label();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.savebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.namebox = new System.Windows.Forms.TextBox();
            this.gyminfo = new System.Windows.Forms.DataGridView();
            this.toppanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.dashbutton = new System.Windows.Forms.Button();
            this.otherlabel = new System.Windows.Forms.Label();
            this.financeButton = new System.Windows.Forms.Button();
            this.menulabel = new System.Windows.Forms.Label();
            this.trainButton = new System.Windows.Forms.Button();
            this.memButton = new System.Windows.Forms.Button();
            this.gymButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.bgpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.requestpanel.SuspendLayout();
            this.resultpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyminfo)).BeginInit();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SideBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // bgpanel
            // 
            this.bgpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.bgpanel.Controls.Add(this.pictureBox1);
            this.bgpanel.Controls.Add(this.welcome);
            this.bgpanel.Controls.Add(this.requestpanel);
            this.bgpanel.Controls.Add(this.toppanel);
            this.bgpanel.Controls.Add(this.SideBar);
            this.bgpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bgpanel.Location = new System.Drawing.Point(0, 0);
            this.bgpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bgpanel.Name = "bgpanel";
            this.bgpanel.Size = new System.Drawing.Size(1100, 700);
            this.bgpanel.TabIndex = 4;
            this.bgpanel.Click += new System.EventHandler(this.bgpanel_Click);
            this.bgpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bgpanel_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1001, 132);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(54, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // welcome
            // 
            this.welcome.AutoSize = true;
            this.welcome.BackColor = System.Drawing.Color.Transparent;
            this.welcome.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcome.ForeColor = System.Drawing.Color.White;
            this.welcome.Location = new System.Drawing.Point(254, 93);
            this.welcome.Name = "welcome";
            this.welcome.Size = new System.Drawing.Size(273, 40);
            this.welcome.TabIndex = 17;
            this.welcome.Text = "Gym Managament";
            // 
            // requestpanel
            // 
            this.requestpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.requestpanel.Controls.Add(this.resultpanel);
            this.requestpanel.Location = new System.Drawing.Point(235, 200);
            this.requestpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.requestpanel.Name = "requestpanel";
            this.requestpanel.Size = new System.Drawing.Size(830, 460);
            this.requestpanel.TabIndex = 22;
            // 
            // resultpanel
            // 
            this.resultpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.resultpanel.Controls.Add(this.delete);
            this.resultpanel.Controls.Add(this.label2);
            this.resultpanel.Controls.Add(this.nobox);
            this.resultpanel.Controls.Add(this.address);
            this.resultpanel.Controls.Add(this.addressbox);
            this.resultpanel.Controls.Add(this.savebutton);
            this.resultpanel.Controls.Add(this.label5);
            this.resultpanel.Controls.Add(this.namebox);
            this.resultpanel.Controls.Add(this.gyminfo);
            this.resultpanel.Location = new System.Drawing.Point(15, 15);
            this.resultpanel.Name = "resultpanel";
            this.resultpanel.Size = new System.Drawing.Size(800, 429);
            this.resultpanel.TabIndex = 2;
            // 
            // delete
            // 
            this.delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(0)))), ((int)(((byte)(41)))));
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.FlatAppearance.BorderSize = 0;
            this.delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.Location = new System.Drawing.Point(684, 361);
            this.delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(100, 35);
            this.delete.TabIndex = 38;
            this.delete.Text = "Delete";
            this.delete.UseVisualStyleBackColor = false;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(355, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 19);
            this.label2.TabIndex = 37;
            this.label2.Text = "Phone Number";
            // 
            // nobox
            // 
            this.nobox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nobox.Location = new System.Drawing.Point(350, 361);
            this.nobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nobox.Multiline = true;
            this.nobox.Name = "nobox";
            this.nobox.Size = new System.Drawing.Size(160, 35);
            this.nobox.TabIndex = 35;
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.Transparent;
            this.address.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.address.Location = new System.Drawing.Point(189, 335);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(58, 19);
            this.address.TabIndex = 34;
            this.address.Text = "Address";
            // 
            // addressbox
            // 
            this.addressbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbox.Location = new System.Drawing.Point(184, 361);
            this.addressbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(160, 35);
            this.addressbox.TabIndex = 32;
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(578, 361);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(100, 35);
            this.savebutton.TabIndex = 31;
            this.savebutton.Text = "Save \r\n";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(23, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Gym Name";
            // 
            // namebox
            // 
            this.namebox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namebox.Location = new System.Drawing.Point(18, 361);
            this.namebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.namebox.Multiline = true;
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(160, 35);
            this.namebox.TabIndex = 27;
            // 
            // gyminfo
            // 
            this.gyminfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gyminfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.gyminfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gyminfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.gyminfo.Location = new System.Drawing.Point(0, 0);
            this.gyminfo.Name = "gyminfo";
            this.gyminfo.ReadOnly = true;
            this.gyminfo.RowHeadersVisible = false;
            this.gyminfo.RowHeadersWidth = 51;
            this.gyminfo.RowTemplate.Height = 24;
            this.gyminfo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.gyminfo.Size = new System.Drawing.Size(800, 310);
            this.gyminfo.TabIndex = 0;
            this.gyminfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gyminfo_CellContentClick);
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.Logo);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Location = new System.Drawing.Point(200, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(909, 90);
            this.toppanel.TabIndex = 12;
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(625, 3);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(196, 93);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 16;
            this.Logo.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(54, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 40);
            this.label1.TabIndex = 18;
            this.label1.Text = "Welcome to";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(43)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
            this.SideBar.Controls.Add(this.dashbutton);
            this.SideBar.Controls.Add(this.otherlabel);
            this.SideBar.Controls.Add(this.financeButton);
            this.SideBar.Controls.Add(this.menulabel);
            this.SideBar.Controls.Add(this.trainButton);
            this.SideBar.Controls.Add(this.memButton);
            this.SideBar.Controls.Add(this.gymButton);
            this.SideBar.Controls.Add(this.profileButton);
            this.SideBar.Controls.Add(this.settingButton);
            this.SideBar.Controls.Add(this.outButton);
            this.SideBar.Location = new System.Drawing.Point(0, 0);
            this.SideBar.Name = "SideBar";
            this.SideBar.Size = new System.Drawing.Size(200, 700);
            this.SideBar.TabIndex = 7;
            // 
            // dashbutton
            // 
            this.dashbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.dashbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashbutton.FlatAppearance.BorderSize = 0;
            this.dashbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dashbutton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashbutton.Location = new System.Drawing.Point(0, 158);
            this.dashbutton.Name = "dashbutton";
            this.dashbutton.Size = new System.Drawing.Size(200, 42);
            this.dashbutton.TabIndex = 14;
            this.dashbutton.Text = "Dashboard";
            this.dashbutton.UseVisualStyleBackColor = false;
            this.dashbutton.Click += new System.EventHandler(this.dashbutton_Click);
            // 
            // otherlabel
            // 
            this.otherlabel.AutoSize = true;
            this.otherlabel.BackColor = System.Drawing.Color.Transparent;
            this.otherlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otherlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.otherlabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.otherlabel.Location = new System.Drawing.Point(12, 470);
            this.otherlabel.Name = "otherlabel";
            this.otherlabel.Size = new System.Drawing.Size(88, 16);
            this.otherlabel.TabIndex = 8;
            this.otherlabel.Text = "Other Options";
            // 
            // financeButton
            // 
            this.financeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.financeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.financeButton.FlatAppearance.BorderSize = 0;
            this.financeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.financeButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.financeButton.Location = new System.Drawing.Point(0, 330);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(200, 40);
            this.financeButton.TabIndex = 13;
            this.financeButton.Text = "Finances";
            this.financeButton.UseVisualStyleBackColor = false;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            // 
            // menulabel
            // 
            this.menulabel.AutoSize = true;
            this.menulabel.BackColor = System.Drawing.Color.Transparent;
            this.menulabel.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.menulabel.Location = new System.Drawing.Point(12, 132);
            this.menulabel.Name = "menulabel";
            this.menulabel.Size = new System.Drawing.Size(72, 16);
            this.menulabel.TabIndex = 12;
            this.menulabel.Text = "Main Menu";
            // 
            // trainButton
            // 
            this.trainButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.trainButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trainButton.FlatAppearance.BorderSize = 0;
            this.trainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.trainButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.trainButton.Location = new System.Drawing.Point(0, 288);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(200, 40);
            this.trainButton.TabIndex = 10;
            this.trainButton.Text = "Trainers";
            this.trainButton.UseVisualStyleBackColor = false;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // memButton
            // 
            this.memButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.memButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.memButton.FlatAppearance.BorderSize = 0;
            this.memButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.memButton.Location = new System.Drawing.Point(0, 246);
            this.memButton.Name = "memButton";
            this.memButton.Size = new System.Drawing.Size(200, 40);
            this.memButton.TabIndex = 10;
            this.memButton.Text = "Members";
            this.memButton.UseVisualStyleBackColor = false;
            this.memButton.Click += new System.EventHandler(this.memButton_Click);
            // 
            // gymButton
            // 
            this.gymButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.gymButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gymButton.FlatAppearance.BorderSize = 0;
            this.gymButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gymButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gymButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gymButton.Location = new System.Drawing.Point(0, 202);
            this.gymButton.Name = "gymButton";
            this.gymButton.Size = new System.Drawing.Size(200, 42);
            this.gymButton.TabIndex = 9;
            this.gymButton.Text = "Gym Management";
            this.gymButton.UseVisualStyleBackColor = false;
            this.gymButton.Click += new System.EventHandler(this.gymButton_Click);
            // 
            // profileButton
            // 
            this.profileButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.profileButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileButton.FlatAppearance.BorderSize = 0;
            this.profileButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.profileButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.profileButton.Location = new System.Drawing.Point(0, 500);
            this.profileButton.Name = "profileButton";
            this.profileButton.Size = new System.Drawing.Size(200, 40);
            this.profileButton.TabIndex = 9;
            this.profileButton.Text = "Profile";
            this.profileButton.UseVisualStyleBackColor = false;
            this.profileButton.Click += new System.EventHandler(this.profileButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.settingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingButton.FlatAppearance.BorderSize = 0;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.settingButton.Location = new System.Drawing.Point(0, 542);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(200, 40);
            this.settingButton.TabIndex = 10;
            this.settingButton.Text = "Settings";
            this.settingButton.UseVisualStyleBackColor = false;
            // 
            // outButton
            // 
            this.outButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(32)))), ((int)(((byte)(19)))), ((int)(((byte)(32)))));
            this.outButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.outButton.FlatAppearance.BorderSize = 0;
            this.outButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.outButton.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.outButton.Location = new System.Drawing.Point(0, 584);
            this.outButton.Name = "outButton";
            this.outButton.Size = new System.Drawing.Size(200, 40);
            this.outButton.TabIndex = 8;
            this.outButton.Text = "Log Out";
            this.outButton.UseVisualStyleBackColor = false;
            this.outButton.Click += new System.EventHandler(this.outButton_Click);
            // 
            // OwnerGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.bgpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OwnerGym";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OwnwerGym";
            this.bgpanel.ResumeLayout(false);
            this.bgpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.requestpanel.ResumeLayout(false);
            this.resultpanel.ResumeLayout(false);
            this.resultpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gyminfo)).EndInit();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bgpanel;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label welcome;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Panel SideBar;
        private System.Windows.Forms.Button dashbutton;
        private System.Windows.Forms.Label otherlabel;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.Label menulabel;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button memButton;
        private System.Windows.Forms.Button gymButton;
        private System.Windows.Forms.Button profileButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button outButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel requestpanel;
        private System.Windows.Forms.Panel resultpanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nobox;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.TextBox addressbox;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.DataGridView gyminfo;
        private System.Windows.Forms.Button delete;
    }
}