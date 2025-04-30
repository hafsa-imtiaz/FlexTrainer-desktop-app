using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class MemberTraining : Form
    {
        int UserID;
        string connectionString;
        Panel[] trainings;
        int panelcount;

        private void TrainingBuilder(string q2)
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string query = "SELECT count(*) FROM Training_Session " +
                                "INNER JOIN member ON member.MemID = Training_Session.MemID " +
                                "WHERE Member.MemID = '" + UserID + "' AND Training_Session.Status IN ('Scheduled','Pending', 'Canceled', 'Attended', 'Not Attended');";
                using (SqlCommand pls = new SqlCommand(query, connect))
                {
                    panelcount = (int)pls.ExecuteScalar();
                    trainings = new Panel[panelcount];
                }

                query = q2;

                using (SqlCommand pls = new SqlCommand(query, connect))
                {
                    pls.Parameters.AddWithValue("@UserID", UserID); //handles stupid string error
                    using (SqlDataReader reader = pls.ExecuteReader())
                    {
                        int i = 0;  //flows through panels
                        while (reader.Read())
                        {
                            trainings[i] = new Panel();
                            trainings[i].Size = new System.Drawing.Size(450, 60);
                            trainings[i].Location = new System.Drawing.Point(8, 7 + i * 60 + i * 7);
                            trainings[i].BorderStyle = BorderStyle.FixedSingle;
                            trainings[i].BackColor = Color.FromArgb(200, 66, 95, 84);
                            trainings[i].Visible = true;
                            infopanel.Controls.Add(trainings[i]);

                            System.Windows.Forms.Label ID = new System.Windows.Forms.Label();
                            ID.Text = reader["SessID"].ToString();
                            ID.Size = new System.Drawing.Size(50, 20);
                            ID.Location = new System.Drawing.Point(0, 0);
                            ID.ForeColor = System.Drawing.Color.White;
                            ID.BackColor = Color.FromArgb(0, 0, 0, 0);
                            ID.Font = new System.Drawing.Font("Nirmala UI", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            ID.Visible = false;
                            trainings[i].Controls.Add(ID);

                            System.Windows.Forms.Label sessiontitle = new System.Windows.Forms.Label();
                            sessiontitle.Text = reader["Description"].ToString();
                            sessiontitle.Size = new System.Drawing.Size(180, 20);
                            //sessiontitle.AutoSize = false;
                            sessiontitle.Location = new System.Drawing.Point(10, 10);
                            sessiontitle.ForeColor = System.Drawing.Color.White;
                            sessiontitle.BackColor = Color.FromArgb(0, 0, 0, 0);
                            sessiontitle.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            trainings[i].Controls.Add(sessiontitle);

                            System.Windows.Forms.Label trainer = new System.Windows.Forms.Label();
                            trainer.Text = "Trainer: " + reader["Name"].ToString();
                            trainer.Size = new System.Drawing.Size(180, 50);
                            trainer.Location = new System.Drawing.Point(10, 30);
                            trainer.ForeColor = System.Drawing.Color.White;
                            trainer.BackColor = Color.FromArgb(0, 0, 0, 0);
                            trainer.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            trainings[i].Controls.Add(trainer);

                            System.Windows.Forms.Label status = new System.Windows.Forms.Label();
                            status.Text = reader["Status"].ToString();
                            status.Size = new System.Drawing.Size(100, 20);
                            status.Location = new System.Drawing.Point(200, 30);
                            status.ForeColor = System.Drawing.Color.White;
                            status.BackColor = Color.FromArgb(0, 0, 0, 0);
                            status.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            trainings[i].Controls.Add(status);

                            System.Windows.Forms.Label datetime = new System.Windows.Forms.Label();
                            datetime.Text = reader["Date_Time"].ToString();
                            datetime.Size = new System.Drawing.Size(100, 20);
                            datetime.Location = new System.Drawing.Point(200, 10);
                            datetime.ForeColor = System.Drawing.Color.White;
                            datetime.BackColor = Color.FromArgb(0, 0, 0, 0);
                            datetime.Font = new System.Drawing.Font("Nirmala UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                            trainings[i].Controls.Add(datetime);

                            System.Windows.Forms.Button more = new System.Windows.Forms.Button();
                            more.Text = "View More";
                            more.Size = new System.Drawing.Size(70, 30);
                            more.Location = new System.Drawing.Point(360, 15);
                            more.BackColor = Color.FromArgb(100, 0, 30, 30);
                            more.FlatAppearance.BorderSize = 0;
                            more.FlatStyle = FlatStyle.Flat;
                            more.ForeColor = System.Drawing.Color.White;
                            more.Click += new System.EventHandler(this.ViewMore_Click);
                            trainings[i].Controls.Add(more);

                            i++;
                        }
                    }
                }
                connect.Close();
            }
        }

        public void ViewMore_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Button clickedButton = (System.Windows.Forms.Button)sender;
            Panel clickedPanel = (Panel)clickedButton.Parent;
            int sessID = -1;
            foreach (Control control in clickedPanel.Controls)
            {
                if (control is System.Windows.Forms.Label)
                {
                    System.Windows.Forms.Label label = (System.Windows.Forms.Label)control;
                    if (!label.Visible) { 
                        sessID = Convert.ToInt32(label.Text);label3.Text = label.Text; 
                        break; 
                    }
                }
            }
            new MemberViewMore(UserID, sessID, connectionString).Show();
        }

        public MemberTraining(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Count(*) FROM Training_Session WHERE Training_Session.MemID = '" + UserID + "' AND Training_Session.Status = 'Attended';";

            SqlCommand cmd = new SqlCommand(query, connect);
            object count = cmd.ExecuteScalar();
            completeCount.Text = count.ToString();

            cmd.CommandText = "SELECT Count(*) FROM Training_Session WHERE Training_Session.MemID = '" + UserID + "' AND Training_Session.Status = 'Pending';";
            count = cmd.ExecuteScalar();
            pendingCount.Text = count.ToString();

            cmd.CommandText = "SELECT Sum(Training_Session.Duration) FROM Training_Session WHERE Training_Session.MemID = '" + UserID + "' AND Training_Session.Status = 'Attended';";
            count = cmd.ExecuteScalar();
            hourCount.Text = count.ToString();
            if(hourCount.Text == "") {
                hourCount.Text = "0";
            }

            cmd.CommandText = "SELECT Count(*) FROM Training_Session WHERE Training_Session.MemID = '" + UserID + "' AND Training_Session.Status = 'Cancelled';";
            count = cmd.ExecuteScalar();
            cancelCount.Text = count.ToString();

            cmd.Dispose();
            connect.Close();

            query = "SELECT Training_Session.SessID, " +
                            "Training_Session.Description, " +
                            "CONVERT(VARCHAR(20), Training_Session.Date, 100) + ' ' + CONVERT(VARCHAR(20), Training_Session.Time, 100) AS Date_Time, " +
                            "Training_Session.Status, Users.FName + ' ' + Users.LName As Name " +
                            "FROM Training_Session " +
                            "INNER JOIN Member ON Member.MemID = Training_Session.MemID " +
                            "INNER JOIN Users ON Users.UserID = Training_Session.TrainerID " +
                            "WHERE Member.MemID = @UserID ORDER BY Date DESC;";
            TrainingBuilder(query);
        }
        private const int CS_DROPshadow = 0x00030000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams plsParam = base.CreateParams;
                plsParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                plsParam.ClassStyle = CS_DROPshadow;
                return plsParam;
            }
        }
        private void dashbutton_Click(object sender, EventArgs e)
        {
            new MemberHome(UserID, connectionString).Show();
            this.Hide();
        }
        private void dietButton_Click(object sender, EventArgs e)
        {
            new MemberDiet1(UserID, connectionString).Show();
            this.Hide();
        }
        private void workButton_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show();  
            this.Hide();
        }
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(searchbox.Text != "") { searchlabel.Visible = false; }
            else { searchlabel.Visible = true; }
        }
        private void label10_Click(object sender, EventArgs e)
        {
            searchbox.Focus();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show(); this.Hide();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            Form book = new MemberBookSession(UserID, connectionString);
            book.Show();
            string query = "SELECT Training_Session.SessID, " +
                            "Training_Session.Description, " +
                            "CONVERT(VARCHAR(20), Training_Session.Date, 100) + ' ' + CONVERT(VARCHAR(20), Training_Session.Time, 100) AS Date_Time, " +
                            "Training_Session.Status, Users.FName + ' ' + Users.LName As Name " +
                            "FROM Training_Session " +
                            "INNER JOIN Member ON Member.MemID = Training_Session.MemID " +
                            "INNER JOIN Users ON Users.UserID = Training_Session.TrainerID " +
                            "WHERE Member.MemID = @UserID ORDER BY Date DESC;";
            TrainingBuilder(query);
        }

        private void upcomingbutton_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "All Trainings";//set query criteria
            string query = "SELECT Training_Session.SessID, " +
                            "Training_Session.Description, " +
                            "CONVERT(VARCHAR(20), Training_Session.Date, 100) + ' ' + CONVERT(VARCHAR(20), Training_Session.Time, 100) AS Date_Time, " +
                            "Training_Session.Status, Users.FName + ' ' + Users.LName As Name " +
                            "FROM Training_Session " +
                            "INNER JOIN Member ON Member.MemID = Training_Session.MemID " +
                            "INNER JOIN Users ON Users.UserID = Training_Session.TrainerID " +
                            "WHERE Member.MemID = @UserID ORDER BY Date DESC;";
            TrainingBuilder(query);
        }

        private void pendingbutton_Click(object sender, EventArgs e)
        {
            infoLabel.Text = "Upcoming Trainings";//set query criteria
            string query = "SELECT Training_Session.SessID, " +
                            "Training_Session.Description, " +
                            "CONVERT(VARCHAR(20), Training_Session.Date, 100) + ' ' + CONVERT(VARCHAR(20), Training_Session.Time, 100) AS Date_Time, " +
                            "Training_Session.Status, Users.FName + ' ' + Users.LName As Name " +
                            "FROM Training_Session " +
                            "INNER JOIN Member ON Member.MemID = Training_Session.MemID " +
                            "INNER JOIN Users ON Users.UserID = Training_Session.TrainerID " +
                            "WHERE Member.MemID = @UserID AND (Status = 'Pending' OR Status = 'Scheduled') ORDER BY Date DESC;";
            TrainingBuilder(query);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string query = "SELECT Training_Session.SessID, " +
                            "Training_Session.Description, " +
                            "CONVERT(VARCHAR(20), Training_Session.Date, 100) + ' ' + CONVERT(VARCHAR(20), Training_Session.Time, 100) AS Date_Time, " +
                            "Training_Session.Status, Users.FName + ' ' + Users.LName As Name " +
                            "FROM Training_Session " +
                            "INNER JOIN Member ON Member.MemID = Training_Session.MemID " +
                            "INNER JOIN Users ON Users.UserID = Training_Session.TrainerID " +
                            "WHERE Member.MemID = @UserID AND (Training_Session.Description LIKE '%" + searchbox.Text + "%' OR Users.FName LIKE '%" + searchbox.Text + "%') ORDER BY Date DESC;";
            TrainingBuilder(query);
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new MemberGym(UserID, connectionString).Show(); this.Hide();
        }

        private void actButton_Click(object sender, EventArgs e)
        {
            new MemberAct(UserID, connectionString).Show(); this.Hide();    
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            new GiveFeedback(UserID, connectionString).Show(); ;
        }
    }
}
