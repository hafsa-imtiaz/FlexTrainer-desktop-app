using System.Drawing;
using System.Windows.Forms;

namespace proj
{
    partial class MemberBookSession
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberBookSession));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toppanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.descrip = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.descriplabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ghanta = new System.Windows.Forms.ComboBox();
            this.mins = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infotable = new System.Windows.Forms.DataGridView();
            this.specialinfo = new System.Windows.Forms.DataGridView();
            this.qualitable = new System.Windows.Forms.DataGridView();
            this.duration = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.top3 = new System.Windows.Forms.Panel();
            this.top3id = new System.Windows.Forms.Label();
            this.top3bakistuff = new System.Windows.Forms.Label();
            this.top3name = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.top2 = new System.Windows.Forms.Panel();
            this.top2id = new System.Windows.Forms.Label();
            this.top2bakistuff = new System.Windows.Forms.Label();
            this.top2name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.top1 = new System.Windows.Forms.Panel();
            this.top1id = new System.Windows.Forms.Label();
            this.top1bakistuff = new System.Windows.Forms.Label();
            this.top1name = new System.Windows.Forms.Label();
            this.Profilepic = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.waqt = new System.Windows.Forms.ComboBox();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infotable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualitable)).BeginInit();
            this.panel1.SuspendLayout();
            this.top3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.top2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.top1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Profilepic)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.toppanel.Controls.Add(this.label3);
            this.toppanel.Controls.Add(this.Logo);
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(900, 90);
            this.toppanel.TabIndex = 30;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toppanel_Paint);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(23, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 38);
            this.label3.TabIndex = 20;
            this.label3.Text = "Book Training!";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(700, -13);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 16;
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(371, 750);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(538, 750);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 35);
            this.button2.TabIndex = 32;
            this.button2.Text = "Confirm Booking!";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // descrip
            // 
            this.descrip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrip.Location = new System.Drawing.Point(30, 140);
            this.descrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descrip.Multiline = true;
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(414, 35);
            this.descrip.TabIndex = 34;
            this.descrip.TextChanged += new System.EventHandler(this.descrip_TextChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.AllowDrop = true;
            this.dateTimePicker1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(30, 229);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(150, 24);
            this.dateTimePicker1.TabIndex = 40;
            // 
            // descriplabel
            // 
            this.descriplabel.AutoSize = true;
            this.descriplabel.BackColor = System.Drawing.Color.White;
            this.descriplabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriplabel.Location = new System.Drawing.Point(35, 148);
            this.descriplabel.Name = "descriplabel";
            this.descriplabel.Size = new System.Drawing.Size(141, 18);
            this.descriplabel.TabIndex = 37;
            this.descriplabel.Text = "Session Description";
            this.descriplabel.Click += new System.EventHandler(this.descriplabel_Click);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(28, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(220, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Session Date / Time";
            // 
            // ghanta
            // 
            this.ghanta.DropDownHeight = 60;
            this.ghanta.FormattingEnabled = true;
            this.ghanta.IntegralHeight = false;
            this.ghanta.Items.AddRange(new object[] {
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
            this.ghanta.Location = new System.Drawing.Point(30, 270);
            this.ghanta.Name = "ghanta";
            this.ghanta.Size = new System.Drawing.Size(120, 24);
            this.ghanta.TabIndex = 41;
            this.ghanta.Text = "Hours";
            // 
            // mins
            // 
            this.mins.DropDownHeight = 80;
            this.mins.FormattingEnabled = true;
            this.mins.IntegralHeight = false;
            this.mins.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
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
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59"});
            this.mins.Location = new System.Drawing.Point(180, 270);
            this.mins.Name = "mins";
            this.mins.Size = new System.Drawing.Size(120, 24);
            this.mins.TabIndex = 42;
            this.mins.Text = "Minutes";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.infotable);
            this.panel2.Controls.Add(this.specialinfo);
            this.panel2.Controls.Add(this.qualitable);
            this.panel2.Controls.Add(this.duration);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.cancel);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.waqt);
            this.panel2.Controls.Add(this.mins);
            this.panel2.Controls.Add(this.ghanta);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.descriplabel);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Controls.Add(this.descrip);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.toppanel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 650);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(475, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 20);
            this.label6.TabIndex = 59;
            this.label6.Text = "Trainers";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(671, 380);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Specializations";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(475, 380);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 20);
            this.label1.TabIndex = 57;
            this.label1.Text = "Qualifications";
            // 
            // infotable
            // 
            this.infotable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.infotable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.infotable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infotable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(50)))), ((int)(((byte)(45)))));
            this.infotable.Location = new System.Drawing.Point(478, 172);
            this.infotable.Name = "infotable";
            this.infotable.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.SlateGray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.infotable.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.infotable.RowHeadersVisible = false;
            this.infotable.RowHeadersWidth = 51;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.SlateGray;
            this.infotable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.infotable.RowTemplate.Height = 24;
            this.infotable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.infotable.Size = new System.Drawing.Size(386, 200);
            this.infotable.TabIndex = 0;
            this.infotable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infotable_CellContentClick);
            // 
            // specialinfo
            // 
            this.specialinfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.specialinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specialinfo.GridColor = System.Drawing.Color.Teal;
            this.specialinfo.Location = new System.Drawing.Point(674, 400);
            this.specialinfo.Name = "specialinfo";
            this.specialinfo.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.specialinfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.specialinfo.RowHeadersVisible = false;
            this.specialinfo.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Teal;
            this.specialinfo.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.specialinfo.RowTemplate.Height = 24;
            this.specialinfo.Size = new System.Drawing.Size(190, 100);
            this.specialinfo.TabIndex = 56;
            // 
            // qualitable
            // 
            this.qualitable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.qualitable.ColumnHeadersHeight = 29;
            this.qualitable.GridColor = System.Drawing.Color.Teal;
            this.qualitable.Location = new System.Drawing.Point(478, 399);
            this.qualitable.Name = "qualitable";
            this.qualitable.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.qualitable.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.qualitable.RowHeadersVisible = false;
            this.qualitable.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            this.qualitable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.qualitable.RowTemplate.Height = 24;
            this.qualitable.Size = new System.Drawing.Size(190, 100);
            this.qualitable.TabIndex = 54;
            // 
            // duration
            // 
            this.duration.DropDownHeight = 80;
            this.duration.FormattingEnabled = true;
            this.duration.IntegralHeight = false;
            this.duration.Items.AddRange(new object[] {
            "30",
            "45",
            "60",
            "75",
            "90",
            "105",
            "120",
            "135",
            "150",
            "165",
            "180",
            "195",
            "210",
            "225",
            "240"});
            this.duration.Location = new System.Drawing.Point(303, 229);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(141, 24);
            this.duration.TabIndex = 49;
            this.duration.Text = "Duration (mins)";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(306, 555);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 35);
            this.button3.TabIndex = 47;
            this.button3.Text = "Confirm Booking";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(141, 555);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(145, 35);
            this.cancel.TabIndex = 46;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.top3);
            this.panel1.Controls.Add(this.top2);
            this.panel1.Controls.Add(this.top1);
            this.panel1.Location = new System.Drawing.Point(30, 375);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(418, 165);
            this.panel1.TabIndex = 45;
            // 
            // top3
            // 
            this.top3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.top3.Controls.Add(this.top3id);
            this.top3.Controls.Add(this.top3bakistuff);
            this.top3.Controls.Add(this.top3name);
            this.top3.Controls.Add(this.panel6);
            this.top3.Controls.Add(this.pictureBox2);
            this.top3.Location = new System.Drawing.Point(352, 19);
            this.top3.Name = "top3";
            this.top3.Size = new System.Drawing.Size(150, 117);
            this.top3.TabIndex = 47;
            this.top3.Click += new System.EventHandler(this.Top3_Click);
            // 
            // top3id
            // 
            this.top3id.BackColor = System.Drawing.Color.Transparent;
            this.top3id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top3id.Location = new System.Drawing.Point(108, 91);
            this.top3id.Name = "top3id";
            this.top3id.Size = new System.Drawing.Size(32, 21);
            this.top3id.TabIndex = 54;
            this.top3id.Text = "ID";
            // 
            // top3bakistuff
            // 
            this.top3bakistuff.BackColor = System.Drawing.Color.Transparent;
            this.top3bakistuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3bakistuff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top3bakistuff.Location = new System.Drawing.Point(5, 65);
            this.top3bakistuff.Name = "top3bakistuff";
            this.top3bakistuff.Size = new System.Drawing.Size(97, 52);
            this.top3bakistuff.TabIndex = 53;
            this.top3bakistuff.Text = "Name";
            // 
            // top3name
            // 
            this.top3name.BackColor = System.Drawing.Color.Transparent;
            this.top3name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top3name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top3name.Location = new System.Drawing.Point(56, 3);
            this.top3name.Name = "top3name";
            this.top3name.Size = new System.Drawing.Size(97, 52);
            this.top3name.TabIndex = 52;
            this.top3name.Text = "Name";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.panel6.Controls.Add(this.pictureBox3);
            this.panel6.Location = new System.Drawing.Point(146, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 117);
            this.panel6.TabIndex = 51;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(0, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(56, 53);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 50;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 53);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 50;
            this.pictureBox2.TabStop = false;
            // 
            // top2
            // 
            this.top2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.top2.Controls.Add(this.top2id);
            this.top2.Controls.Add(this.top2bakistuff);
            this.top2.Controls.Add(this.top2name);
            this.top2.Controls.Add(this.pictureBox1);
            this.top2.Location = new System.Drawing.Point(185, 19);
            this.top2.Name = "top2";
            this.top2.Size = new System.Drawing.Size(150, 117);
            this.top2.TabIndex = 47;
            this.top2.Click += new System.EventHandler(this.Top2_Click);
            // 
            // top2id
            // 
            this.top2id.BackColor = System.Drawing.Color.Transparent;
            this.top2id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top2id.Location = new System.Drawing.Point(108, 91);
            this.top2id.Name = "top2id";
            this.top2id.Size = new System.Drawing.Size(32, 21);
            this.top2id.TabIndex = 53;
            this.top2id.Text = "ID";
            // 
            // top2bakistuff
            // 
            this.top2bakistuff.BackColor = System.Drawing.Color.Transparent;
            this.top2bakistuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2bakistuff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top2bakistuff.Location = new System.Drawing.Point(5, 60);
            this.top2bakistuff.Name = "top2bakistuff";
            this.top2bakistuff.Size = new System.Drawing.Size(97, 52);
            this.top2bakistuff.TabIndex = 52;
            this.top2bakistuff.Text = "Name";
            // 
            // top2name
            // 
            this.top2name.BackColor = System.Drawing.Color.Transparent;
            this.top2name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top2name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top2name.Location = new System.Drawing.Point(53, 0);
            this.top2name.Name = "top2name";
            this.top2name.Size = new System.Drawing.Size(97, 52);
            this.top2name.TabIndex = 51;
            this.top2name.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            // 
            // top1
            // 
            this.top1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.top1.Controls.Add(this.top1id);
            this.top1.Controls.Add(this.top1bakistuff);
            this.top1.Controls.Add(this.top1name);
            this.top1.Controls.Add(this.Profilepic);
            this.top1.Location = new System.Drawing.Point(18, 19);
            this.top1.Name = "top1";
            this.top1.Size = new System.Drawing.Size(150, 117);
            this.top1.TabIndex = 46;
            this.top1.Click += new System.EventHandler(this.panel3_Click);
            // 
            // top1id
            // 
            this.top1id.BackColor = System.Drawing.Color.Transparent;
            this.top1id.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1id.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top1id.Location = new System.Drawing.Point(115, 91);
            this.top1id.Name = "top1id";
            this.top1id.Size = new System.Drawing.Size(32, 21);
            this.top1id.TabIndex = 52;
            this.top1id.Text = "ID";
            // 
            // top1bakistuff
            // 
            this.top1bakistuff.BackColor = System.Drawing.Color.Transparent;
            this.top1bakistuff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1bakistuff.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top1bakistuff.Location = new System.Drawing.Point(5, 60);
            this.top1bakistuff.Name = "top1bakistuff";
            this.top1bakistuff.Size = new System.Drawing.Size(97, 52);
            this.top1bakistuff.TabIndex = 51;
            this.top1bakistuff.Text = "Name";
            // 
            // top1name
            // 
            this.top1name.BackColor = System.Drawing.Color.Transparent;
            this.top1name.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.top1name.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.top1name.Location = new System.Drawing.Point(53, 3);
            this.top1name.Name = "top1name";
            this.top1name.Size = new System.Drawing.Size(97, 52);
            this.top1name.TabIndex = 50;
            this.top1name.Text = "Name";
            // 
            // Profilepic
            // 
            this.Profilepic.BackColor = System.Drawing.Color.Transparent;
            this.Profilepic.Image = ((System.Drawing.Image)(resources.GetObject("Profilepic.Image")));
            this.Profilepic.Location = new System.Drawing.Point(3, 2);
            this.Profilepic.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Profilepic.Name = "Profilepic";
            this.Profilepic.Size = new System.Drawing.Size(56, 53);
            this.Profilepic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Profilepic.TabIndex = 49;
            this.Profilepic.TabStop = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Top Trainers!";
            // 
            // waqt
            // 
            this.waqt.DropDownHeight = 40;
            this.waqt.FormattingEnabled = true;
            this.waqt.IntegralHeight = false;
            this.waqt.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.waqt.Location = new System.Drawing.Point(324, 270);
            this.waqt.Name = "waqt";
            this.waqt.Size = new System.Drawing.Size(120, 24);
            this.waqt.TabIndex = 43;
            this.waqt.Text = "Time";
            // 
            // MemberBookSession
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 650);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemberBookSession";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberBookSession";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.infotable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specialinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qualitable)).EndInit();
            this.panel1.ResumeLayout(false);
            this.top3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.top2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.top1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Profilepic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label descriplabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox ghanta;
        private System.Windows.Forms.ComboBox mins;
        private System.Windows.Forms.Panel panel2;
        private ComboBox waqt;
        private Panel panel1;
        private Panel top3;
        private Panel top2;
        private Panel top1;
        private Label label5;
        private Button button3;
        private Button cancel;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox Profilepic;
        private Panel panel6;
        private PictureBox pictureBox3;
        private ComboBox duration;
        private Label top3bakistuff;
        private Label top3name;
        private Label top2bakistuff;
        private Label top2name;
        private Label top1bakistuff;
        private Label top1name;
        private Label top3id;
        private Label top2id;
        private Label top1id;
        private DataGridView specialinfo;
        private DataGridView qualitable;
        private DataGridView infotable;
        private Label label6;
        private Label label2;
        private Label label1;
    }
}