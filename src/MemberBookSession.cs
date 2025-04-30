using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class MemberBookSession : Form
    {
        int UserID; string connectionString;
        public int trainID;
        public MemberBookSession(int UserID, string connectionString)
        {
            InitializeComponent();
            this.UserID = UserID; 
            this.connectionString = connectionString;
            trainID = -1;


            using (SqlConnection connect = new SqlConnection(connectionString)) {
                connect.Open();
                string query = "SELECT Gym_Employment.TrainerID, Users.FName + ' ' + Users.LName AS Name, Trainer.Years, e.Rating " +
                    "FROM Gym_Employment " +
                    "INNER JOIN member ON member.gymID = gym_employment.GymID " +
                    "INNER JOIN Users On Users.UserID = Gym_Employment.TrainerID " +
                    "INNER JOIN Trainer ON Trainer.TrainerID = Gym_Employment.TrainerID " +
                    "INNER JOIN (SELECT TrainerID, AVG(Rating) AS Rating FROM Trainer_Feedback " +
                    "GROUP BY TrainerID) e ON e.TrainerID = Gym_Employment.TrainerID WHERE endDate IS NULL AND member.MemID = '" + UserID + "' ORDER BY e.Rating;";

                int index = 1;
                using (SqlCommand pls = new SqlCommand(query, connect))
                {

                    using (SqlDataReader reader = pls.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (index == 1)
                            {
                                top1id.Text = (reader["TrainerID"]).ToString();
                                top1id.Visible = false;
                                top1name.Text = reader["Name"].ToString();
                                top1bakistuff.Text = "Years: " + (reader["Years"]).ToString() + "\n Rating: " + (reader["Rating"]).ToString();
                            }
                            else if (index == 2)
                            {
                                top2id.Text = (reader["TrainerID"]).ToString();
                                top2id.Visible = false;
                                top2name.Text = reader["Name"].ToString();
                                top2bakistuff.Text = "Years: " + (reader["Years"]).ToString() + "\n Rating: " + (reader["Rating"]).ToString();
                            }
                            else
                            {
                                top3id.Text = (reader["TrainerID"]).ToString();
                                top3id.Visible = false;
                                top3name.Text = reader["Name"].ToString();
                                top3bakistuff.Text = "Years: " + (reader["Years"]).ToString() + "\n Rating: " + (reader["Rating"]).ToString();
                            }

                            index++;
                        }
                    }
                    if (index == 1)
                    {
                        top1.Visible = top2.Visible = top3.Visible = false;
                        MessageBox.Show("Bookings are not possible. Your gym does not have trainers!", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else if (index == 2)
                    {
                        top2.Visible = top3.Visible = false;
                    }
                    else if (index == 3) { top3.Visible = false; }
                }
                query = "SELECT Gym_Employment.TrainerID, Users.FName + ' ' + Users.LName AS Name, Trainer.Years, e.Rating " +
                    "FROM Gym_Employment " +
                    "INNER JOIN member ON member.gymID = gym_employment.GymID " +
                    "INNER JOIN Users On Users.UserID = Gym_Employment.TrainerID " +
                    "INNER JOIN Trainer ON Trainer.TrainerID = Gym_Employment.TrainerID " +
                    "INNER JOIN (SELECT TrainerID, AVG(Rating) AS Rating FROM Trainer_Feedback " +
                    "GROUP BY TrainerID) e ON e.TrainerID = Gym_Employment.TrainerID WHERE endDate IS NULL AND member.MemID = '" + UserID + "' ORDER BY e.Rating;";
                SqlCommand cmd = new SqlCommand(query, connect);

                SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                infotable.DataSource = userdata;

                cmd.Dispose();
                connect.Close();
            }

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
        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //save all data
            if (string.IsNullOrWhiteSpace(descrip.Text) || duration.SelectedIndex == -1 || waqt.SelectedIndex == -1 || ghanta.SelectedIndex == -1 || mins.SelectedIndex == -1 || trainID == -1)
            {
                MessageBox.Show("All fields must be filled!", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string cutuquery = "INSERT INTO Training_Session (MemID, TrainerID, Duration, Date, Time, Description, Status) " +
                                     "VALUES (@MemID, @TrainerID, @Duration, @Date, @Time, @Description, 'Pending')";
                DateTime meridate = dateTimePicker1.Value; 
                string din = meridate.ToString("yyyy-MM-dd");
                string merawaqt = ghanta.Text + ":" + mins.Text + " " + this.waqt.Text;
                TimeSpan timeSpan = DateTime.Parse(merawaqt).TimeOfDay;
                string waqt = timeSpan.ToString(@"hh\:mm\:ss");

                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    using (SqlCommand pls = new SqlCommand(cutuquery, connect))
                    {
                        pls.Parameters.AddWithValue("@MemID", UserID);
                        pls.Parameters.AddWithValue("@TrainerID", trainID);
                        pls.Parameters.AddWithValue("@Duration", duration.SelectedItem.ToString());
                        pls.Parameters.AddWithValue("@Date", din);
                        pls.Parameters.AddWithValue("@Time", waqt);
                        pls.Parameters.AddWithValue("@Description", descrip.Text);

                        connect.Open();
                        int done = pls.ExecuteNonQuery();
                        connect.Close();
                        if(done > 0)
                        {
                            MessageBox.Show("Your booking request has been sent to the trainer!","Booking Successful!");
                        }
                        else
                        {
                            MessageBox.Show("An error occurred. Please try again later!", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }


            }
            this.Hide();
        }
        private void TrainerIDBatao(object sender, string information)
        {
            trainID = Convert.ToInt32(information);
        }
        private void descriplabel_Click(object sender, EventArgs e)
        {
            descrip.Focus();
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text != "") descriplabel.Visible = false;
            else descriplabel.Visible = true;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            trainID = Convert.ToInt32(top1id.Text);
            findqualification();
            findSpecialization();
        }
        private void Top2_Click(object sender, EventArgs e)
        {
            trainID = Convert.ToInt32(top2id.Text);
            findqualification();
            findSpecialization();
        }
        private void Top3_Click(object sender, EventArgs e)
        {
            trainID = Convert.ToInt32(top3id.Text);
            findqualification();
            findSpecialization();
        }

        private void findqualification()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Qualification FROM Trainer_Qualifications WHERE TrainerID = '" + trainID + "';";
            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
            DataTable userdata = new DataTable();
            userTable.Fill(userdata);
            qualitable.DataSource = userdata;
            connect.Close();
        }

        private void findSpecialization()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Specialization FROM Trainer_Specializations WHERE TrainerID = '" + trainID + "';";
            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
            DataTable userdata = new DataTable();
            userTable.Fill(userdata);
            specialinfo.DataSource = userdata;
            connect.Close();
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            if (selected >= 0 && selected < infotable.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = infotable.Rows[selected];

                trainID = Convert.ToInt32(targetRow.Cells[0].Value);
                findqualification();
                findSpecialization();
            }
            else
            {
                qualitable.DataSource = null;
                specialinfo.DataSource = null;
            }
        }
    }
}
