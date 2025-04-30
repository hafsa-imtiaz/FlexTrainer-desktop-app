using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class TrainMem : Form
    {
        int memID;
        int TrainerID;
        string connectionString;
        public TrainMem(int memid, int trainid, string conns)
        {
            InitializeComponent();
            memID = memid;
            TrainerID = trainid;
            connectionString = conns;


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + TrainerID + "' AND MemID = '" + memID + "';";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    info.DataSource = userdata;

                }
                connection.Close();


                try
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        query = "select fname, lname, Member.Weight AS Weight, Member.Height AS Height, Member.Goal AS Goal, DATEDIFF(YEAR, Dob, CURRENT_TIMESTAMP) AS Age, WorkoutPlan.PlanName AS WorkOut, DietPlan.PlanName AS Diet FROM USERS INNER JOIN Member ON Member.MemID = USERS.UserID INNER JOIN DietPlan ON Member.DPlanID = DietPlan.DPlanID INNER JOIN WorkoutPlan ON Member.WPlanID = WorkoutPlan.WPlanID WHERE Users.UserID = '" + memID + "';";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    memname.Text = reader["FName"].ToString() + " " + reader["LName"].ToString();
                                    weightinfo.Text = "Weight: " + reader["Weight"].ToString() + "kg";
                                    heightinfo.Text = "Height: " + reader["Height"].ToString() + "cm";
                                    goalinfo.Text = reader["Goal"].ToString();
                                    ageinfo.Text = "Age: " + reader["Age"].ToString();
                                    workinfo.Text = "DietPlan: " + reader["WorkOut"].ToString();
                                    dietinfo.Text = "WorkoutPlan: " + reader["Diet"].ToString();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Your Data could not be loaded!", "Database Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        connect.Close();
                    }
                }
                catch(Exception ex) { MessageBox.Show("Exception: " + ex.Message); }
            }

            try
            {
                string query = @"SELECT Rating, Comment
                         FROM Trainer_Feedback
                         WHERE MemID = @MemID AND TrainerID = @TrainerID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MemID", memID);
                        command.Parameters.AddWithValue("@TrainerID",TrainerID);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                date.Text = (reader.GetOrdinal("Rating")).ToString();
                                descrip.Text = reader.GetString(reader.GetOrdinal("Comment"));
                            }
                            else
                            {
                                descrip.Text = "No feedback yet";
                                date.Visible = datelabel.Visible = false;
                            }
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        }

        private void TrainMem_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
