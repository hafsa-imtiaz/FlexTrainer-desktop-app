using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class MemberWO3 : Form
    {
        int UserID;
        string connectionString;
        int selected;
        public MemberWO3(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;
            creatorlabel.Visible = false;
            creatorname.Visible = false;
            role.Visible = false;
            selected = -1;

            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                int gymid;
                string query = "SELECT gymid from member where memid = '" + userID + "';";
                SqlCommand cmd = new SqlCommand(query, connect);
                gymid = Convert.ToInt32(cmd.ExecuteScalar());

                if (gymid == 0) { 
                    dataGridView2.Visible = false; wogrid.Visible = false;
                    dataGridView2.Enabled = wogrid.Enabled = update.Enabled = false;
                    creatorlabel.Visible=false;
                    role.Visible=false;
                    update.Visible=false;
                    label6.Visible=false;
                    creatorname.Text = "Join a gym to view plans!";
                }
                else
                {
                    query = "select WorkoutPlan.PlanName, WorkoutPlan.Description, WorkoutPlan.Goal, WorkoutPlan.Difficulty, WPlanID " +
                    "from WorkoutPlan WHERE CreatorID IN " +
                        " (SELECT memid AS ID FROM member where GymID ='" + gymid + "' UNION SELECT TrainerID AS ID FROM gym_employment WHERE gymid = '" + gymid + "' AND endDate IS NULL) AND Share_Status = 'Public'";
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    wogrid.DataSource = userdata;
                }

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
        private void dashbutton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dashbutton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dashbutton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void gymButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            gymButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void gymButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            gymButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void actButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            actButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void actButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            actButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void dietButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dietButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void dietButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dietButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void trainButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            trainButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void trainButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            trainButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void outButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            outButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void outButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            outButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void profileButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            profileButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void workButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            workButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void workButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            workButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            profileButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void settingButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            settingButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void settingButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            settingButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void dashbutton_Click(object sender, EventArgs e)
        {
            new MemberHome(UserID, connectionString).Show();
            this.Hide();
        }
        private void workButton_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show(); this.Hide(); 
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {
            SideBar.BackColor = Color.FromArgb(230, 16, 48, 41);
        }
        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
                searchlabel.Visible = true;
            else
                searchlabel.Visible = false;
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(230, 66, 95, 84);
        }
        private void mywo_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show();
            this.Hide();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new MemberWO4(UserID, connectionString).Show();
            this.Hide();    
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show(); this.Hide();
        }
        private void trainButton_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show(); this.Hide();
        }
        private void dietButton_Click(object sender, EventArgs e)
        {
            new MemberDiet1(UserID, connectionString).Show(); this.Hide();
        }
        private void searchlabel_Click(object sender, EventArgs e)
        {
            SearchBox.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //do nothing
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new MemberGym(UserID, connectionString).Show(); this.Hide();
        }

        private void actButton_Click(object sender, EventArgs e)
        {
            new MemberAct(UserID, connectionString).Show(); this.Hide();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {

        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(SearchBox.Text))
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    int gymid;
                    string query = "SELECT gymid from member where memid = '" + UserID + "';";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    gymid = Convert.ToInt32(cmd.ExecuteScalar());
                    if (gymid == 0)
                    {
                        dataGridView2.Visible = false; wogrid.Visible = false;
                        creatorlabel.Visible = false;
                        role.Visible = false;
                        update.Visible = false;
                        label6.Visible = false;
                        creatorname.Text = "Join a gym to view plans!";
                    }
                    else
                    {
                        query = "select WorkoutPlan.PlanName, WorkoutPlan.Description, WorkoutPlan.Goal, WorkoutPlan.Difficulty, WPlanID " +
                    "from WorkoutPlan WHERE CreatorID IN " +
                        " (SELECT memid AS ID FROM member where GymID ='" + gymid + "' UNION SELECT TrainerID AS ID FROM gym_employment WHERE gymid = '" + gymid + "' AND endDate IS NULL) AND Share_Status = 'Public'";
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        wogrid.DataSource = userdata;
                    }

                    cmd.Dispose();
                    connect.Close();
                }
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    int gymid;
                    string query = "SELECT gymid from member where memid = '" + UserID + "';";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    gymid = Convert.ToInt32(cmd.ExecuteScalar());

                    if (gymid == 0)
                    {
                        dataGridView2.Visible = false; wogrid.Visible = false;
                        creatorlabel.Visible = false;
                        role.Visible = false;
                        update.Visible = false;
                        label6.Visible = false;
                        creatorname.Text = "Join a gym to view plans!";
                    }
                    else
                    {
                        query = "select WorkoutPlan.PlanName, WorkoutPlan.Description, WorkoutPlan.Goal, WorkoutPlan.Difficulty, WPlanID " +
                        "from WorkoutPlan WHERE CreatorID IN " +
                            " (SELECT memid AS ID FROM member where GymID ='" + gymid + "' UNION SELECT TrainerID AS ID FROM gym_employment WHERE gymid = '" + gymid + "' AND endDate IS NULL) AND (PlanName LIKE '%" + SearchBox.Text + "%' OR Goal  LIKE '%" + SearchBox.Text + "%' OR Description  LIKE '%" + SearchBox.Text + "%' OR Difficulty  LIKE '%" + SearchBox.Text + "%') AND Share_Status = 'Public';";
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        wogrid.DataSource = userdata;
                    }

                    cmd.Dispose();
                    connect.Close();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new MemberWO2(UserID, connectionString).Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < wogrid.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = wogrid.Rows[selected];
                int id = Convert.ToInt32(targetRow.Cells[4].Value);
                creatorname.Text = id.ToString();
                creatorname.Visible = true;
                creatorlabel.Visible = true;
                role.Visible = true;

                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string query = "SELECT Users.FName + ' ' + users.LName AS Name, users.URole FROM WorkoutPlan INNER JOIN Users ON WorkoutPlan.CreatorID = Users.UserID WHERE WPlanID = '" + id + "';";
                using (SqlCommand pls = new SqlCommand(query, connect))
                {
                    using (SqlDataReader reader = pls.ExecuteReader())
                    {
                        if (reader.Read()) // Move to the first row if available
                        {
                            creatorname.Text = reader["Name"].ToString();
                            role.Text = reader["URole"].ToString();
                        }
                    }
                }

                query = " SELECT * FROM Schedule_Exercise WHERE PlanID = '" + id + "';";//select the exercise day by day
                SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                dataGridView2.DataSource = userdata;
                connect.Close();
            }
            else
            {
                creatorname.Visible = false;
                creatorlabel.Visible = false;
                role.Visible = false;
                dataGridView2.DataSource = null;    
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (selected >= 0 && selected <= wogrid.Rows.Count)
            {
                DataGridViewRow targetRow = wogrid.Rows[selected];
                int id = Convert.ToInt32(targetRow.Cells[4].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Member SET WPlanID = '" + id + "';";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((int)command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("New workoutplan has been adopted!", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Workout Plan could not be changed!", "ERROR");
                        }
                    }
                    connection.Close();
                }
                selected = -1;
            }
            else
            {
                MessageBox.Show("Choose a plan!");
                selected = -1;
            }
        }

        private void role_Click(object sender, EventArgs e)
        {

        }

        private void creatorname_Click(object sender, EventArgs e)
        {

        }

        private void creatorlabel_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
