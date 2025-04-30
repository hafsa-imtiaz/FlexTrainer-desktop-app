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

namespace proj
{
    public partial class MeraForm : Form
    {
        int UserID;
        string connectionString;
        string which;
        int selected;
        public MeraForm(int userid, string connstring, string kon)
        {
            InitializeComponent();
            this.UserID = userid;
            this.connectionString = connstring;
            this.which = kon;
            selected = -1;

            if (which == "W")
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    try
                    {
                        string query = "select WorkoutPlan.PlanName, WorkoutPlan.Description, WorkoutPlan.Goal, WorkoutPlan.Difficulty, WPlanID " +
                        "from WorkoutPlan WHERE CreatorID = '" + UserID + "';";
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        wogrid.DataSource = userdata;


                    }
                    catch(Exception ex) { MessageBox.Show("Exception: ", ex.Message.ToString()); }
                }
            }
            else
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter("SELECT PlanName, Description, Goal, Type, calorie_intake, CreationDate, DPLANID FROM DIETPLAN INNER JOIN USERS ON USERS.USERID = DIETPLAN.CREATORID WHERE Share_Status = 'Public' AND CREATORID = '" + UserID + "';", conn);
                        DataTable mealTable = new DataTable();
                        adapter.Fill(mealTable);
                        wogrid.DataSource = mealTable;

                        conn.Close();
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Exceptions: " + ex.Message);
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void wogrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(which == "W")
            {
                selected = e.RowIndex;
                if (selected >= 0 && selected < wogrid.Rows.Count)   //selected valid hai??
                {
                    DataGridViewRow targetRow = wogrid.Rows[selected];
                    int id = Convert.ToInt32(targetRow.Cells[4].Value);


                    SqlConnection connect = new SqlConnection(connectionString);
                    connect.Open();

                    string query = " SELECT Day, ExerciseName, Sets, Reps, Rest_Interval FROM Schedule_Exercise WHERE PlanID = '" + id + "';";//select the exercise day by day
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    dataGridView2.DataSource = userdata;
                    connect.Close();
                }

            }
            else
            {
                selected = e.RowIndex;
                if (selected >= 0 && selected < wogrid.Rows.Count)   //selected valid hai??
                {
                    DataGridViewRow targetRow = wogrid.Rows[selected];
                    int id = Convert.ToInt32(targetRow.Cells[6].Value);
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
        }

        private void update_Click(object sender, EventArgs e)
        {
            if(which == "W")
            {

            }
            else
            {

            }
        }
    }
}
