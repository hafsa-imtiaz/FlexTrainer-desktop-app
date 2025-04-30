using static System.Net.Mime.MediaTypeNames;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace proj
{
    partial class OwnerProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OwnerProfile));
            this.bigpanel = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.profiletitle = new System.Windows.Forms.Label();
            this.SideBar = new System.Windows.Forms.Panel();
            this.dashbutton = new System.Windows.Forms.Button();
            this.otherlabel = new System.Windows.Forms.Label();
            this.financeButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.trainButton = new System.Windows.Forms.Button();
            this.memButton = new System.Windows.Forms.Button();
            this.gymButton = new System.Windows.Forms.Button();
            this.profileButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.outButton = new System.Windows.Forms.Button();
            this.role = new System.Windows.Forms.Label();
            this.owneremail = new System.Windows.Forms.Label();
            this.ownername = new System.Windows.Forms.Label();
            this.Profilepic = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.License = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.licensebox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numlabel = new System.Windows.Forms.Label();
            this.addresslabel = new System.Windows.Forms.Label();
            this.PassLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.LNameLabel = new System.Windows.Forms.Label();
            this.FNameLabel = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.phonenumberbox = new System.Windows.Forms.TextBox();
            this.cancel = new System.Windows.Forms.Button();
            this.callcode = new System.Windows.Forms.Label();
            this.male = new System.Windows.Forms.Label();
            this.female = new System.Windows.Forms.Label();
            this.femalebox = new System.Windows.Forms.CheckBox();
            this.malebox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.yearbox = new System.Windows.Forms.ListBox();
            this.monthbox = new System.Windows.Forms.ListBox();
            this.emailbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datebox = new System.Windows.Forms.ListBox();
            this.addressbox = new System.Windows.Forms.TextBox();
            this.passwordbox = new System.Windows.Forms.TextBox();
            this.Lname = new System.Windows.Forms.TextBox();
            this.Fname = new System.Windows.Forms.TextBox();
            this.bigpanel.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SideBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profilepic)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bigpanel
            // 
            this.bigpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.bigpanel.Controls.Add(this.toppanel);
            this.bigpanel.Controls.Add(this.SideBar);
            this.bigpanel.Controls.Add(this.role);
            this.bigpanel.Controls.Add(this.owneremail);
            this.bigpanel.Controls.Add(this.ownername);
            this.bigpanel.Controls.Add(this.Profilepic);
            this.bigpanel.Controls.Add(this.panel1);
            this.bigpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigpanel.Location = new System.Drawing.Point(0, 0);
            this.bigpanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bigpanel.Name = "bigpanel";
            this.bigpanel.Size = new System.Drawing.Size(1100, 700);
            this.bigpanel.TabIndex = 2;
            this.bigpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bigpanel_Paint);
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.Logo);
            this.toppanel.Controls.Add(this.profiletitle);
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
            // profiletitle
            // 
            this.profiletitle.AutoSize = true;
            this.profiletitle.BackColor = System.Drawing.Color.Transparent;
            this.profiletitle.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profiletitle.ForeColor = System.Drawing.Color.White;
            this.profiletitle.Location = new System.Drawing.Point(43, 43);
            this.profiletitle.Name = "profiletitle";
            this.profiletitle.Size = new System.Drawing.Size(223, 38);
            this.profiletitle.TabIndex = 1;
            this.profiletitle.Text = "Personal Profile";
            // 
            // SideBar
            // 
            this.SideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(43)))), ((int)(((byte)(24)))), ((int)(((byte)(43)))));
            this.SideBar.Controls.Add(this.dashbutton);
            this.SideBar.Controls.Add(this.otherlabel);
            this.SideBar.Controls.Add(this.financeButton);
            this.SideBar.Controls.Add(this.label6);
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
            this.dashbutton.MouseLeave += new System.EventHandler(this.dashbutton_MouseLeave);
            this.dashbutton.MouseHover += new System.EventHandler(this.dashbutton_MouseHover);
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
            this.financeButton.MouseLeave += new System.EventHandler(this.financeButton_MouseLeave);
            this.financeButton.MouseHover += new System.EventHandler(this.financeButton_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.label6.Location = new System.Drawing.Point(12, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Main Menu";
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
            this.trainButton.MouseLeave += new System.EventHandler(this.trainButton_MouseLeave);
            this.trainButton.MouseHover += new System.EventHandler(this.trainButton_MouseHover);
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
            this.memButton.MouseLeave += new System.EventHandler(this.memButton_MouseLeave);
            this.memButton.MouseHover += new System.EventHandler(this.memButton_MouseHover);
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
            this.gymButton.MouseLeave += new System.EventHandler(this.gymButton_MouseLeave);
            this.gymButton.MouseHover += new System.EventHandler(this.gymButton_MouseHover);
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
            this.profileButton.MouseLeave += new System.EventHandler(this.profileButton_MouseLeave);
            this.profileButton.MouseHover += new System.EventHandler(this.profileButton_MouseHover);
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
            this.settingButton.MouseLeave += new System.EventHandler(this.settingButton_MouseLeave);
            this.settingButton.MouseHover += new System.EventHandler(this.settingButton_MouseHover);
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
            this.outButton.MouseLeave += new System.EventHandler(this.outButton_MouseLeave);
            this.outButton.MouseHover += new System.EventHandler(this.outButton_MouseHover);
            // 
            // role
            // 
            this.role.AutoSize = true;
            this.role.BackColor = System.Drawing.Color.Transparent;
            this.role.ForeColor = System.Drawing.Color.White;
            this.role.Location = new System.Drawing.Point(406, 195);
            this.role.Name = "role";
            this.role.Size = new System.Drawing.Size(76, 16);
            this.role.TabIndex = 5;
            this.role.Text = "Gym Owner";
            // 
            // owneremail
            // 
            this.owneremail.AutoSize = true;
            this.owneremail.BackColor = System.Drawing.Color.Transparent;
            this.owneremail.ForeColor = System.Drawing.Color.White;
            this.owneremail.Location = new System.Drawing.Point(406, 168);
            this.owneremail.Name = "owneremail";
            this.owneremail.Size = new System.Drawing.Size(112, 16);
            this.owneremail.TabIndex = 4;
            this.owneremail.Text = "gymowner@.com";
            // 
            // ownername
            // 
            this.ownername.AutoSize = true;
            this.ownername.BackColor = System.Drawing.Color.Transparent;
            this.ownername.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownername.ForeColor = System.Drawing.Color.White;
            this.ownername.Location = new System.Drawing.Point(406, 135);
            this.ownername.Name = "ownername";
            this.ownername.Size = new System.Drawing.Size(152, 23);
            this.ownername.TabIndex = 3;
            this.ownername.Text = "GymOwner Name";
            // 
            // Profilepic
            // 
            this.Profilepic.BackColor = System.Drawing.Color.Transparent;
            this.Profilepic.Image = ((System.Drawing.Image)(resources.GetObject("Profilepic.Image")));
            this.Profilepic.Location = new System.Drawing.Point(250, 117);
            this.Profilepic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Profilepic.Name = "Profilepic";
            this.Profilepic.Size = new System.Drawing.Size(150, 110);
            this.Profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profilepic.TabIndex = 0;
            this.Profilepic.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(79)))), ((int)(((byte)(65)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.License);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.licensebox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.numlabel);
            this.panel1.Controls.Add(this.addresslabel);
            this.panel1.Controls.Add(this.PassLabel);
            this.panel1.Controls.Add(this.EmailLabel);
            this.panel1.Controls.Add(this.LNameLabel);
            this.panel1.Controls.Add(this.FNameLabel);
            this.panel1.Controls.Add(this.savebutton);
            this.panel1.Controls.Add(this.phonenumberbox);
            this.panel1.Controls.Add(this.cancel);
            this.panel1.Controls.Add(this.callcode);
            this.panel1.Controls.Add(this.male);
            this.panel1.Controls.Add(this.female);
            this.panel1.Controls.Add(this.femalebox);
            this.panel1.Controls.Add(this.malebox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.yearbox);
            this.panel1.Controls.Add(this.monthbox);
            this.panel1.Controls.Add(this.emailbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.datebox);
            this.panel1.Controls.Add(this.addressbox);
            this.panel1.Controls.Add(this.passwordbox);
            this.panel1.Controls.Add(this.Lname);
            this.panel1.Controls.Add(this.Fname);
            this.panel1.Location = new System.Drawing.Point(250, 250);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(785, 374);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // License
            // 
            this.License.AutoSize = true;
            this.License.BackColor = System.Drawing.SystemColors.Window;
            this.License.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.License.Location = new System.Drawing.Point(41, 308);
            this.License.Name = "License";
            this.License.Size = new System.Drawing.Size(59, 18);
            this.License.TabIndex = 30;
            this.License.Text = "License";
            this.License.Click += new System.EventHandler(this.License_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(38, 279);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 19);
            this.label9.TabIndex = 29;
            this.label9.Text = "License";
            // 
            // licensebox
            // 
            this.licensebox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.licensebox.Location = new System.Drawing.Point(35, 300);
            this.licensebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.licensebox.Multiline = true;
            this.licensebox.Name = "licensebox";
            this.licensebox.Size = new System.Drawing.Size(310, 35);
            this.licensebox.TabIndex = 13;
            this.licensebox.TextChanged += new System.EventHandler(this.licensebox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(40, 145);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Address";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(40, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 19);
            this.label7.TabIndex = 27;
            this.label7.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(40, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 19);
            this.label5.TabIndex = 26;
            this.label5.Text = "First Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(440, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(440, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 24;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // numlabel
            // 
            this.numlabel.AutoSize = true;
            this.numlabel.BackColor = System.Drawing.SystemColors.Window;
            this.numlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numlabel.Location = new System.Drawing.Point(110, 240);
            this.numlabel.Name = "numlabel";
            this.numlabel.Size = new System.Drawing.Size(108, 18);
            this.numlabel.TabIndex = 23;
            this.numlabel.Text = "Phone Number";
            this.numlabel.Click += new System.EventHandler(this.numlabel_Click);
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.BackColor = System.Drawing.SystemColors.Window;
            this.addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(39, 175);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(62, 18);
            this.addresslabel.TabIndex = 20;
            this.addresslabel.Text = "Address";
            this.addresslabel.Click += new System.EventHandler(this.addresslabel_Click);
            // 
            // PassLabel
            // 
            this.PassLabel.AutoSize = true;
            this.PassLabel.BackColor = System.Drawing.SystemColors.Window;
            this.PassLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PassLabel.Location = new System.Drawing.Point(445, 112);
            this.PassLabel.Name = "PassLabel";
            this.PassLabel.Size = new System.Drawing.Size(75, 18);
            this.PassLabel.TabIndex = 20;
            this.PassLabel.Text = "Password";
            this.PassLabel.Click += new System.EventHandler(this.PassLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.SystemColors.Window;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(445, 46);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(45, 18);
            this.EmailLabel.TabIndex = 21;
            this.EmailLabel.Text = "Email";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // LNameLabel
            // 
            this.LNameLabel.AutoSize = true;
            this.LNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.LNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameLabel.Location = new System.Drawing.Point(39, 112);
            this.LNameLabel.Name = "LNameLabel";
            this.LNameLabel.Size = new System.Drawing.Size(80, 18);
            this.LNameLabel.TabIndex = 22;
            this.LNameLabel.Text = "Last Name";
            this.LNameLabel.Click += new System.EventHandler(this.LNameLabel_Click);
            // 
            // FNameLabel
            // 
            this.FNameLabel.AutoSize = true;
            this.FNameLabel.BackColor = System.Drawing.SystemColors.Window;
            this.FNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameLabel.Location = new System.Drawing.Point(38, 46);
            this.FNameLabel.Name = "FNameLabel";
            this.FNameLabel.Size = new System.Drawing.Size(81, 18);
            this.FNameLabel.TabIndex = 19;
            this.FNameLabel.Text = "First Name";
            this.FNameLabel.Click += new System.EventHandler(this.FNameLabel_Click);
            // 
            // savebutton
            // 
            this.savebutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(69)))), ((int)(((byte)(110)))));
            this.savebutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savebutton.FlatAppearance.BorderSize = 0;
            this.savebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebutton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savebutton.ForeColor = System.Drawing.Color.White;
            this.savebutton.Location = new System.Drawing.Point(595, 318);
            this.savebutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(145, 35);
            this.savebutton.TabIndex = 7;
            this.savebutton.Text = "Save Changes";
            this.savebutton.UseVisualStyleBackColor = false;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // phonenumberbox
            // 
            this.phonenumberbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonenumberbox.Location = new System.Drawing.Point(100, 234);
            this.phonenumberbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.phonenumberbox.Multiline = true;
            this.phonenumberbox.Name = "phonenumberbox";
            this.phonenumberbox.Size = new System.Drawing.Size(245, 35);
            this.phonenumberbox.TabIndex = 16;
            this.phonenumberbox.TextChanged += new System.EventHandler(this.phonenumber_TextChanged);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(439, 318);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(145, 35);
            this.cancel.TabIndex = 6;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // callcode
            // 
            this.callcode.BackColor = System.Drawing.Color.White;
            this.callcode.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.callcode.Location = new System.Drawing.Point(35, 237);
            this.callcode.Name = "callcode";
            this.callcode.Size = new System.Drawing.Size(54, 31);
            this.callcode.TabIndex = 15;
            this.callcode.Text = "+92";
            // 
            // male
            // 
            this.male.BackColor = System.Drawing.Color.White;
            this.male.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(443, 237);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(85, 28);
            this.male.TabIndex = 14;
            this.male.Text = "Male      ";
            // 
            // female
            // 
            this.female.BackColor = System.Drawing.Color.White;
            this.female.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.female.Location = new System.Drawing.Point(585, 237);
            this.female.Name = "female";
            this.female.Size = new System.Drawing.Size(99, 28);
            this.female.TabIndex = 13;
            this.female.Text = "Female     ";
            // 
            // femalebox
            // 
            this.femalebox.Location = new System.Drawing.Point(690, 237);
            this.femalebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.femalebox.Name = "femalebox";
            this.femalebox.Size = new System.Drawing.Size(18, 17);
            this.femalebox.TabIndex = 12;
            this.femalebox.UseVisualStyleBackColor = true;
            this.femalebox.CheckedChanged += new System.EventHandler(this.femalebox_CheckedChanged);
            // 
            // malebox
            // 
            this.malebox.Location = new System.Drawing.Point(534, 234);
            this.malebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.malebox.Name = "malebox";
            this.malebox.Size = new System.Drawing.Size(18, 17);
            this.malebox.TabIndex = 11;
            this.malebox.UseVisualStyleBackColor = true;
            this.malebox.CheckedChanged += new System.EventHandler(this.malebox_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(439, 211);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Gender";
            // 
            // yearbox
            // 
            this.yearbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearbox.FormattingEnabled = true;
            this.yearbox.HorizontalExtent = 20;
            this.yearbox.ItemHeight = 23;
            this.yearbox.Items.AddRange(new object[] {
            "Year",
            "1980",
            "1981",
            "1982",
            "1983",
            "1984",
            "1985",
            "1986",
            "1987",
            "1988",
            "1989",
            "1990",
            "1991",
            "1992",
            "1993",
            "1994",
            "1995",
            "1996",
            "1997",
            "1998",
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024"});
            this.yearbox.Location = new System.Drawing.Point(650, 169);
            this.yearbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.yearbox.Name = "yearbox";
            this.yearbox.Size = new System.Drawing.Size(90, 27);
            this.yearbox.TabIndex = 9;
            // 
            // monthbox
            // 
            this.monthbox.AllowDrop = true;
            this.monthbox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthbox.FormattingEnabled = true;
            this.monthbox.HorizontalExtent = 20;
            this.monthbox.ItemHeight = 23;
            this.monthbox.Items.AddRange(new object[] {
            "Month",
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
            "12"});
            this.monthbox.Location = new System.Drawing.Point(544, 169);
            this.monthbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthbox.Name = "monthbox";
            this.monthbox.Size = new System.Drawing.Size(90, 27);
            this.monthbox.TabIndex = 8;
            this.monthbox.SelectedIndexChanged += new System.EventHandler(this.month_SelectedIndexChanged);
            // 
            // emailbox
            // 
            this.emailbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailbox.Location = new System.Drawing.Point(439, 38);
            this.emailbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.emailbox.Multiline = true;
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(310, 35);
            this.emailbox.TabIndex = 2;
            this.emailbox.TextChanged += new System.EventHandler(this.emailbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(440, 147);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Date Of Birth";
            // 
            // datebox
            // 
            this.datebox.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datebox.FormattingEnabled = true;
            this.datebox.HorizontalExtent = 20;
            this.datebox.ItemHeight = 23;
            this.datebox.Items.AddRange(new object[] {
            "Date",
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
            this.datebox.Location = new System.Drawing.Point(439, 169);
            this.datebox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.datebox.Name = "datebox";
            this.datebox.Size = new System.Drawing.Size(90, 27);
            this.datebox.TabIndex = 6;
            // 
            // addressbox
            // 
            this.addressbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressbox.Location = new System.Drawing.Point(35, 169);
            this.addressbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addressbox.Multiline = true;
            this.addressbox.Name = "addressbox";
            this.addressbox.Size = new System.Drawing.Size(310, 35);
            this.addressbox.TabIndex = 4;
            this.addressbox.TextChanged += new System.EventHandler(this.address_TextChanged);
            // 
            // passwordbox
            // 
            this.passwordbox.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordbox.Location = new System.Drawing.Point(439, 104);
            this.passwordbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passwordbox.Multiline = true;
            this.passwordbox.Name = "passwordbox";
            this.passwordbox.Size = new System.Drawing.Size(310, 35);
            this.passwordbox.TabIndex = 3;
            this.passwordbox.TextChanged += new System.EventHandler(this.passwordbox_TextChanged);
            // 
            // Lname
            // 
            this.Lname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lname.Location = new System.Drawing.Point(35, 104);
            this.Lname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Lname.Multiline = true;
            this.Lname.Name = "Lname";
            this.Lname.Size = new System.Drawing.Size(310, 35);
            this.Lname.TabIndex = 1;
            this.Lname.TextChanged += new System.EventHandler(this.Lname_TextChanged);
            // 
            // Fname
            // 
            this.Fname.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fname.Location = new System.Drawing.Point(35, 38);
            this.Fname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Fname.Multiline = true;
            this.Fname.Name = "Fname";
            this.Fname.Size = new System.Drawing.Size(310, 35);
            this.Fname.TabIndex = 0;
            this.Fname.TextChanged += new System.EventHandler(this.Fname_TextChanged);
            // 
            // OwnerProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.bigpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OwnerProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.OwnerProfile_Load);
            this.bigpanel.ResumeLayout(false);
            this.bigpanel.PerformLayout();
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.SideBar.ResumeLayout(false);
            this.SideBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profilepic)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel bigpanel;
        private Panel panel1;
        private Label profiletitle;
        private TextBox emailbox;
        private TextBox Lname;
        private TextBox Fname;
        private PictureBox Profilepic;
        private Label ownername;
        private Label owneremail;
        private Label role;
        private TextBox passwordbox;
        private Button savebutton;
        private Button cancel;
        private TextBox addressbox;
        private ListBox datebox;
        private Label label1;
        private ListBox monthbox;
        private ListBox yearbox;
        private CheckBox malebox;
        private Label label2;
        private CheckBox femalebox;
        private Label male;
        private Label female;
        private TextBox phonenumberbox;
        private Label callcode;
        private Panel SideBar;
        private Label otherlabel;
        private Button financeButton;
        private Label label6;
        private Button trainButton;
        private Button memButton;
        private Button gymButton;
        private Button profileButton;
        private Button settingButton;
        private Button outButton;
        private Panel toppanel;
        private PictureBox Logo;
        private Label FNameLabel;
        private Label LNameLabel;
        private Label EmailLabel;
        private Label addresslabel;
        private Label PassLabel;
        private Label numlabel;
        private Button dashbutton;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label8;
        private Label label7;
        private Label label9;
        private TextBox licensebox;
        private Label License;
    }
}