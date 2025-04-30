namespace proj
{
    partial class Khana
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Khana));
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.desclabel = new System.Windows.Forms.Label();
            this.namelabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.cancel = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.descrip = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.mealtable = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.calories = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.proteins = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fibre = new System.Windows.Forms.TextBox();
            this.carbs = new System.Windows.Forms.TextBox();
            this.fats = new System.Windows.Forms.TextBox();
            this.allergies = new System.Windows.Forms.ComboBox();
            this.addday = new System.Windows.Forms.PictureBox();
            this.allergeninput = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealtable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addday)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(20)))));
            this.toppanel.Controls.Add(this.pictureBox2);
            this.toppanel.Controls.Add(this.allergeninput);
            this.toppanel.Controls.Add(this.addday);
            this.toppanel.Controls.Add(this.allergies);
            this.toppanel.Controls.Add(this.label9);
            this.toppanel.Controls.Add(this.calories);
            this.toppanel.Controls.Add(this.label1);
            this.toppanel.Controls.Add(this.proteins);
            this.toppanel.Controls.Add(this.label6);
            this.toppanel.Controls.Add(this.label7);
            this.toppanel.Controls.Add(this.label8);
            this.toppanel.Controls.Add(this.fibre);
            this.toppanel.Controls.Add(this.carbs);
            this.toppanel.Controls.Add(this.fats);
            this.toppanel.Controls.Add(this.pictureBox1);
            this.toppanel.Controls.Add(this.desclabel);
            this.toppanel.Controls.Add(this.namelabel);
            this.toppanel.Controls.Add(this.label3);
            this.toppanel.Controls.Add(this.Logo);
            this.toppanel.Controls.Add(this.cancel);
            this.toppanel.Controls.Add(this.button3);
            this.toppanel.Controls.Add(this.descrip);
            this.toppanel.Controls.Add(this.name);
            this.toppanel.Controls.Add(this.mealtable);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(900, 500);
            this.toppanel.TabIndex = 12;
            this.toppanel.Paint += new System.Windows.Forms.PaintEventHandler(this.toppanel_Paint);
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
            // desclabel
            // 
            this.desclabel.AutoSize = true;
            this.desclabel.BackColor = System.Drawing.Color.White;
            this.desclabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desclabel.Location = new System.Drawing.Point(629, 151);
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
            this.namelabel.Size = new System.Drawing.Size(84, 18);
            this.namelabel.TabIndex = 52;
            this.namelabel.Text = "Meal Name";
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
            this.label3.Size = new System.Drawing.Size(153, 38);
            this.label3.TabIndex = 51;
            this.label3.Text = "Meal Info!";
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
            this.cancel.Location = new System.Drawing.Point(622, 434);
            this.cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(125, 35);
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
            this.button3.Location = new System.Drawing.Point(759, 434);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 35);
            this.button3.TabIndex = 48;
            this.button3.Text = "Add Meal";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // descrip
            // 
            this.descrip.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descrip.Location = new System.Drawing.Point(622, 143);
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
            // mealtable
            // 
            this.mealtable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.mealtable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mealtable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(48)))), ((int)(((byte)(41)))));
            this.mealtable.Location = new System.Drawing.Point(24, 98);
            this.mealtable.Name = "mealtable";
            this.mealtable.ReadOnly = true;
            this.mealtable.RowHeadersVisible = false;
            this.mealtable.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Teal;
            this.mealtable.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.mealtable.RowTemplate.Height = 24;
            this.mealtable.Size = new System.Drawing.Size(574, 371);
            this.mealtable.TabIndex = 17;
            this.mealtable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.infotable_CellContentClick);
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(686, 250);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 22);
            this.label9.TabIndex = 84;
            this.label9.Text = "Calories";
            // 
            // calories
            // 
            this.calories.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calories.Location = new System.Drawing.Point(686, 272);
            this.calories.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.calories.Multiline = true;
            this.calories.Name = "calories";
            this.calories.Size = new System.Drawing.Size(60, 25);
            this.calories.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(620, 250);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 22);
            this.label1.TabIndex = 82;
            this.label1.Text = "Proteins";
            // 
            // proteins
            // 
            this.proteins.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.proteins.Location = new System.Drawing.Point(620, 272);
            this.proteins.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.proteins.Multiline = true;
            this.proteins.Name = "proteins";
            this.proteins.Size = new System.Drawing.Size(60, 25);
            this.proteins.TabIndex = 81;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(753, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 22);
            this.label6.TabIndex = 80;
            this.label6.Text = "Fibre";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(691, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 79;
            this.label7.Text = "Carbs";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(617, 201);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 22);
            this.label8.TabIndex = 78;
            this.label8.Text = "Fats";
            // 
            // fibre
            // 
            this.fibre.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fibre.Location = new System.Drawing.Point(753, 223);
            this.fibre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fibre.Multiline = true;
            this.fibre.Name = "fibre";
            this.fibre.Size = new System.Drawing.Size(60, 25);
            this.fibre.TabIndex = 77;
            // 
            // carbs
            // 
            this.carbs.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbs.Location = new System.Drawing.Point(688, 223);
            this.carbs.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.carbs.Multiline = true;
            this.carbs.Name = "carbs";
            this.carbs.Size = new System.Drawing.Size(60, 25);
            this.carbs.TabIndex = 76;
            // 
            // fats
            // 
            this.fats.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fats.Location = new System.Drawing.Point(621, 223);
            this.fats.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fats.Multiline = true;
            this.fats.Name = "fats";
            this.fats.Size = new System.Drawing.Size(60, 25);
            this.fats.TabIndex = 75;
            // 
            // allergies
            // 
            this.allergies.DropDownHeight = 80;
            this.allergies.FormattingEnabled = true;
            this.allergies.IntegralHeight = false;
            this.allergies.Location = new System.Drawing.Point(620, 316);
            this.allergies.Name = "allergies";
            this.allergies.Size = new System.Drawing.Size(180, 24);
            this.allergies.TabIndex = 85;
            this.allergies.Text = "Allergens";
            // 
            // addday
            // 
            this.addday.Image = ((System.Drawing.Image)(resources.GetObject("addday.Image")));
            this.addday.Location = new System.Drawing.Point(814, 313);
            this.addday.Name = "addday";
            this.addday.Size = new System.Drawing.Size(57, 27);
            this.addday.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.addday.TabIndex = 86;
            this.addday.TabStop = false;
            this.addday.Click += new System.EventHandler(this.addday_Click);
            // 
            // allergeninput
            // 
            this.allergeninput.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allergeninput.Location = new System.Drawing.Point(620, 356);
            this.allergeninput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allergeninput.Multiline = true;
            this.allergeninput.Name = "allergeninput";
            this.allergeninput.Size = new System.Drawing.Size(180, 35);
            this.allergeninput.TabIndex = 87;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(814, 364);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 88;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Khana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 500);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Khana";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khana";
            this.toppanel.ResumeLayout(false);
            this.toppanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mealtable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addday)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label desclabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox descrip;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.DataGridView mealtable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox calories;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox proteins;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox fibre;
        private System.Windows.Forms.TextBox carbs;
        private System.Windows.Forms.TextBox fats;
        private System.Windows.Forms.ComboBox allergies;
        private System.Windows.Forms.PictureBox addday;
        private System.Windows.Forms.TextBox allergeninput;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}