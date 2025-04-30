namespace proj
{
    partial class Exercise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exercise));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.musclabel = new System.Windows.Forms.Label();
            this.desclabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.muscle = new System.Windows.Forms.TextBox();
            this.machine = new System.Windows.Forms.ComboBox();
            this.diffi = new System.Windows.Forms.ComboBox();
            this.descrip = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.infotable = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.infotable)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.toppanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 500);
            this.panel1.TabIndex = 2;
            // 
            // toppanel
            // 
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Controls.Add(this.musclabel);
            this.toppanel.Controls.Add(this.desclabel);
            this.toppanel.Controls.Add(this.namelabel);
            this.toppanel.Controls.Add(this.label3);
            this.toppanel.Controls.Add(this.Logo);
            this.toppanel.Controls.Add(this.cancel);
            this.toppanel.Controls.Add(this.button3);
            this.toppanel.Controls.Add(this.muscle);
            this.toppanel.Controls.Add(this.machine);
            this.toppanel.Controls.Add(this.diffi);
            this.toppanel.Controls.Add(this.descrip);
            this.toppanel.Controls.Add(this.name);
            this.toppanel.Controls.Add(this.infotable);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(900, 500);
            this.toppanel.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(839, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(61, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // musclabel
            // 
            this.musclabel.AutoSize = true;
            this.musclabel.BackColor = System.Drawing.Color.White;
            this.musclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musclabel.Location = new System.Drawing.Point(629, 333);
            this.musclabel.Name = "musclabel";
            this.musclabel.Size = new System.Drawing.Size(102, 18);
            this.musclabel.TabIndex = 54;
            this.musclabel.Text = "Target Muscle";
            this.musclabel.Click += new System.EventHandler(this.musclabel_Click);
            // 
            // desclabel
            // 
            this.desclabel.AutoSize = true;
            this.desclabel.BackColor = System.Drawing.Color.White;
            this.desclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclabel.Location = new System.Drawing.Point(629, 165);
            this.desclabel.Name = "desclabel";
            this.desclabel.Size = new System.Drawing.Size(83, 18);
            this.desclabel.TabIndex = 53;
            this.desclabel.Text = "Description";
            this.desclabel.Click += new System.EventHandler(this.desclabel_Click);
            // 
            // namelabel
            // 
            this.namelabel.AutoSize = true;
            this.namelabel.BackColor = System.Drawing.Color.White;
            this.namelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namelabel.Location = new System.Drawing.Point(629, 106);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(109, 18);
            this.namelabel.TabIndex = 52;
            this.namelabel.Text = "Exercise Name";
            this.namelabel.Click += new System.EventHandler(this.namelabel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 38);
            this.label3.TabIndex = 51;
            this.label3.Text = "Exercise Info!";
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.Transparent;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(643, -19);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(200, 100);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 50;
            this.Logo.TabStop = false;
            // 
            // cancel
            // 
            this.cancel.BackColor = System.Drawing.Color.White;
            this.cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel.Location = new System.Drawing.Point(675, 434);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(145, 35);
            this.cancel.TabIndex = 49;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(675, 387);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 35);
            this.button3.TabIndex = 48;
            this.button3.Text = "Add Exercise";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // muscle
            // 
            this.muscle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muscle.Location = new System.Drawing.Point(622, 325);
            this.muscle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.muscle.Multiline = true;
            this.muscle.Name = "muscle";
            this.muscle.Size = new System.Drawing.Size(250, 35);
            this.muscle.TabIndex = 44;
            this.muscle.TextChanged += new System.EventHandler(this.muscle_TextChanged);
            // 
            // machine
            // 
            this.machine.DropDownHeight = 80;
            this.machine.FormattingEnabled = true;
            this.machine.IntegralHeight = false;
            this.machine.Location = new System.Drawing.Point(622, 271);
            this.machine.Name = "machine";
            this.machine.Size = new System.Drawing.Size(120, 24);
            this.machine.TabIndex = 43;
            this.machine.Text = "Machine";
            // 
            // diffi
            // 
            this.diffi.DropDownHeight = 60;
            this.diffi.FormattingEnabled = true;
            this.diffi.IntegralHeight = false;
            this.diffi.Items.AddRange(new object[] {
            "Easy",
            "Medium",
            "Hard"});
            this.diffi.Location = new System.Drawing.Point(622, 226);
            this.diffi.Name = "diffi";
            this.diffi.Size = new System.Drawing.Size(120, 24);
            this.diffi.TabIndex = 42;
            this.diffi.Text = "Difficulty";
            // 
            // descrip
            // 
            this.descrip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrip.Location = new System.Drawing.Point(622, 157);
            this.descrip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.descrip.Multiline = true;
            this.descrip.Name = "descrip";
            this.descrip.Size = new System.Drawing.Size(250, 35);
            this.descrip.TabIndex = 36;
            this.descrip.TextChanged += new System.EventHandler(this.descrip_TextChanged);
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(622, 98);
            this.name.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(250, 35);
            this.name.TabIndex = 35;
            this.name.TextChanged += new System.EventHandler(this.name_TextChanged);
            // 
            // infotable
            // 
            this.infotable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.infotable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.infotable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.infotable.Location = new System.Drawing.Point(24, 98);
            this.infotable.Name = "infotable";
            this.infotable.ReadOnly = true;
            this.infotable.RowHeadersVisible = false;
            this.infotable.RowHeadersWidth = 51;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            this.infotable.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.infotable.RowTemplate.Height = 24;
            this.infotable.Size = new System.Drawing.Size(574, 371);
            this.infotable.TabIndex = 17;
            this.infotable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infotable_CellContentClick);
            // 
            // Exercise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exercise";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exercise";
            this.panel1.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.infotable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.DataGridView infotable;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox muscle;
        private System.Windows.Forms.ComboBox machine;
        private System.Windows.Forms.ComboBox diffi;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label musclabel;
        private System.Windows.Forms.Label desclabel;
        private System.Windows.Forms.TextBox descrip;
    }
}