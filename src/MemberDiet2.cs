using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class MemberDiet2 : Form
    {
        int UserID;
        string connectionString;
        int selected;
        public MemberDiet2(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT PlanName, Description, Goal, Type, Calorie_Intake, CreationDate, DPLANID FROM DIETPLAN INNER JOIN USERS ON USERS.USERID = DIETPLAN.CREATORID WHERE Share_Status = 'Public' AND CREATORID = '" + UserID + "';", conn);
                DataTable mealTable = new DataTable();
                adapter.Fill(mealTable);
                wogrid.DataSource = mealTable;

                creatorname.Visible = true;
                creatorlabel.Visible = true;
                role.Visible = true;
                string query = "SELECT FNAME + ' ' + LNAME FROM USERS WHERE USERID = '" + userID + "';";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.CommandText = query;
                creatorname.Text = (cmd.ExecuteScalar()).ToString();
                role.Text = "Member";

                conn.Close();
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
            dashButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            dashButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

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

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new MemberHome(UserID, connectionString).Show();
            this.Hide();
        }

        private void workButton_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show();
            this.Hide();
        }

        private void SideBar_Paint(object sender, PaintEventArgs e)
        {
            SideBar.BackColor = Color.FromArgb(230, 16, 48, 41);
        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            if (SearchBox.Text == "")
            {
                searchlabel.Visible = true;
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT PlanName, Description, Goal, Type, Calorie_Intake, DPLANID FROM DIETPLAN INNER JOIN USERS ON USERS.USERID = DIETPLAN.CREATORID WHERE Share_Status = 'Public' AND CreatorID = '" + UserID + "';", conn);
                    DataTable mealTable = new DataTable();
                    adapter.Fill(mealTable);
                    wogrid.DataSource = mealTable;
                    conn.Close();
                }
            }
            else
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT PlanName, Description, Goal, Type, Calorie_Intake, CreationDate, DPLANID FROM DIETPLAN INNER JOIN USERS ON USERS.USERID = DIETPLAN.CREATORID WHERE Share_Status = 'Public' AND CreatorID = '" + UserID + "';", conn);
                    DataTable mealTable = new DataTable();
                    adapter.Fill(mealTable);
                    wogrid.DataSource = mealTable;
                    conn.Close();
                }
                searchlabel.Visible = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(230, 53, 76, 67);
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void dietButton_Click(object sender, EventArgs e)
        {
            new MemberDiet1(UserID, connectionString).Show(); this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void searchButton_Click(Object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchBox.Text))
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT PlanName, Description, Goal, Type, Calorie_Intake, " +
                                   "CreationDate, DPLANID FROM DIETPLAN INNER JOIN USERS ON USERS.USERID = DIETPLAN.CREATORID WHERE Share_Status = 'Public' " +
                                   "AND (PlanName LIKE '%" + SearchBox.Text + "%' OR Goal  LIKE '%" + SearchBox.Text + "%' OR Description  LIKE '%" + SearchBox.Text + "%' OR (Users.FNAME + ' ' + USERS.LNAME) LIKE '%" + SearchBox.Text + "%' OR Type  LIKE '%" + SearchBox.Text + "%') AND CreatorID = '" + UserID + "'; ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable mealTable = new DataTable();
                    adapter.Fill(mealTable);
                    wogrid.DataSource = mealTable;
                    conn.Close();
                }
            }
        }
        private void trainButton_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show(); this.Hide();
        }
        private void findbutton_Click(object sender, EventArgs e)
        {
            new MemberDiet3(UserID, connectionString).Show();
            this.Hide();
        }

        private void createbutton_Click(object sender, EventArgs e)
        {
            new MemberDiet4(UserID, connectionString).Show();
            this.Hide();
        }

        private void searchlabel_Click(object sender, EventArgs e)
        {
            SearchBox.Focus();
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new MemberGym(UserID, connectionString).Show(); this.Hide();
        }

        private void actButton_Click(object sender, EventArgs e)
        {
            new MemberAct(UserID, connectionString).Show();
            this.Hide();
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
        }

        private void mywo_Click(object sender, EventArgs e)
        {  new MemberWO1(UserID, connectionString).Show(); this.Hide();
        }

        private void mybutton_Click(object sender, EventArgs e)
        {
        }

        private void wogrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < wogrid.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = wogrid.Rows[selected];
                int id = Convert.ToInt32(targetRow.Cells[6].Value);
                creatorname.Text = id.ToString();
                creatorname.Visible = true;
                creatorlabel.Visible = true;
                role.Visible = true;

                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string query = " SELECT DIET_MEAL.DAY, DIET_MEAL.MEALTYPE, MEAL.* FROM Meal INNER JOIN DIET_MEAL ON DIET_MEAL.MEALID = MEAL.MEALID WHERE DPlanID = '" + id + "';";//select the exercise day by day
                SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                dataGridView2.DataSource = userdata;
                connect.Close();
            }
            else
            {
                dataGridView2.DataSource = null;
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (selected >= 0 && selected <= wogrid.Rows.Count)
            {
                DataGridViewRow targetRow = wogrid.Rows[selected];
                int id = Convert.ToInt32(targetRow.Cells[6].Value);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Member SET DPlanID = '" + id + "';";
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
    }
}
