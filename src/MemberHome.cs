using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace proj
{
    public partial class MemberHome : Form
    {
        string connectionString;
        int UserID;
        //Chaudhary.Azeem@gmail.com
        public MemberHome(int userID, string connection)
        {
            InitializeComponent();
            this.connectionString = connection;
            UserID = userID;

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    string query = "select fname, lname, Member.Weight AS Weight, Member.Height AS Height, Member.Goal AS Goal, DATEDIFF(YEAR, Dob, CURRENT_TIMESTAMP) AS Age FROM USERS INNER JOIN Member ON Member.MemID = USERS.UserID WHERE Users.UserID = '" + UserID + "';";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                memname.Text = reader["FName"].ToString() + " " + reader["LName"].ToString();
                                weightinfo.Text = reader["Weight"].ToString() + "kg";
                                heightinfo.Text = reader["Height"].ToString() + "cm";
                                goalinfo.Text = reader["Goal"].ToString();
                                ageinfo.Text = reader["Age"].ToString();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Your Data could not be loaded!", "Database Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                    query = "SELECT count(*) FROM MEMBER WHERE MEMID = '" + UserID + "' AND WPLANID IS NOT NULL";
                    SqlCommand cmd1 = new SqlCommand(query, connect);
                    if ((int)cmd1.ExecuteScalar() > 0)
                    {
                        query = "SELECT WORKOUTPLAN.PLANNAME FROM WORKOUTPLAN INNER JOIN MEMBER ON MEMBER.WPLANID = WORKOUTPLAN.WPLANID WHERE MEMID = '" + UserID + "';";
                        cmd1.CommandText = query;
                        workinfo.Text = cmd1.ExecuteScalar().ToString();
                        //dietinfo.Text = reader["Diet"].ToString();
                    }

                    query = "SELECT count(*) FROM MEMBER WHERE MEMID = '" + UserID + "' AND DPLANID IS NOT NULL";
                    cmd1.CommandText = query;
                    if ((int)cmd1.ExecuteScalar() > 0)
                    {
                        query = "SELECT DIETPLAN.PLANNAME FROM DIETPLAN INNER JOIN MEMBER ON MEMBER.DPLANID = DIETPLAN.DPLANID WHERE MEMID = '" + UserID + "';";
                        cmd1.CommandText = query;
                        dietinfo.Text = cmd1.ExecuteScalar().ToString();
                    }

                    cmd1.Dispose();
                    cmd.Dispose();

                    schedulebox.DataSource = null;
                    query = "SELECT Users.FName + ' ' + Users.LName AS Trainer_Name, Date, Time, Status FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.TrainerID WHERE MemID = '" + UserID + "' AND DATE > CURRENT_TIMESTAMP;";
                    using (SqlDataAdapter userTable = new SqlDataAdapter(query, connect))
                    {
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        schedulebox.DataSource = userdata;
                    }
                    connect.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
        }
        private void dashbutton_MouseHover(object sender, EventArgs e)
        {
            dashbutton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            dashbutton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void gymButton_MouseHover(object sender, EventArgs e)
        {
            gymButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void gymButton_MouseLeave(object sender, EventArgs e)
        {
            gymButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void actButton_MouseHover(object sender, EventArgs e)
        {
            actButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void actButton_MouseLeave(object sender, EventArgs e)
        {
            actButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void dietButton_MouseLeave(object sender, EventArgs e)
        {
            dietButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void dietButton_MouseHover(object sender, EventArgs e)
        {
            dietButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void trainButton_MouseHover(object sender, EventArgs e)
        {
            trainButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void trainButton_MouseLeave(object sender, EventArgs e)
        {
            trainButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void outButton_MouseHover(object sender, EventArgs e)
        {
            outButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void outButton_MouseLeave(object sender, EventArgs e)
        {
            outButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void profileButton_MouseHover(object sender, EventArgs e)
        {
            profileButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void workButton_MouseLeave(object sender, EventArgs e)
        {
            workButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void workButton_MouseHover(object sender, EventArgs e)
        {
            workButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void settingButton_MouseHover(object sender, EventArgs e)
        {
            settingButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void settingButton_MouseLeave(object sender, EventArgs e)
        {
            settingButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(170, 23, 23, 20);
        }
        private void button1_Click(object sender, EventArgs e)
        {}
        private void button3_Click(object sender, EventArgs e)
        {}
        private void panel2_Paint(object sender, PaintEventArgs e)
        {}
        private void panel9_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show();
            this.Hide();
        }
        private void Schedule_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show(); this.Hide();
        }
        private void Schedule_MouseHover(object sender, EventArgs e)
        {
            schedule.ForeColor = Color.FromArgb(230, 0, 0,0);
            schedule.BackColor = Color.FromArgb(230, 83, 181, 193);
        }
        private void Schedule_MouseLeave(object sender, EventArgs e)
        {
            schedule.ForeColor = Color.FromArgb(230, 0, 26, 71);
            schedule.BackColor = Color.FromArgb(0, 83, 181, 193);
        }
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void workButton_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show();
            this.Hide();
        }
        private void dietButton_Click(object sender, EventArgs e)
        {
            new MemberDiet1(UserID, connectionString).Show();
            this.Hide();
        }
        private void trainButton_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show();
            this.Hide();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show(); this.Hide();
        }
        private void actButton_Click(object sender, EventArgs e)
        {
            new MemberAct(UserID, connectionString).Show();
            this.Hide();
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new MemberGym(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
