using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class AddDay : Form
    {
        int planid;
        int din;
        string connectionString;
        bool exist;

        public AddDay(int id, int din, string connectionString)
        {
            InitializeComponent();
            this.planid = id;
            this.din = din;
            this.dayno.Text = "Day " + din.ToString();
            this.connectionString = connectionString;
            exist = false;

            refresh();
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                connect.Open();
                string query = "SELECT ExerciseName FROM Exercise";
                using (SqlCommand command = new SqlCommand(query, connect))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        konsi.Items.Add(reader["ExerciseName"].ToString());
                        donekonsi.Items.Add(reader["ExerciseName"].ToString());
                    }
                    reader.Close();
                }
                using (SqlConnection omg = new SqlConnection(connectionString))
                {
                    omg.Open();
                    string countquery = "SELECT COUNT(*) FROM SCHEDULE_EXERCISE WHERE PlanID = '" + planid + "' AND Day = '" + din + "';";
                    SqlCommand cmd = new SqlCommand(countquery, omg);
                    if ((int)cmd.ExecuteScalar() > 0)
                    {
                        exist = true;
                    }
                    omg.Close();
                }
                if (exist)
                {
                    query = "SELECT MuscleGroup FROM WorkOutSchedule WHERE WPlanID = '" + planid + "' AND day = '" + din + "';";
                    using (SqlCommand pls = new SqlCommand(@query, connect))
                    {
                        targetbox.Text = (pls.ExecuteScalar()).ToString();
                    }
                }
                query = "SELECT PlanName FROM WorkOutPlan WHERE WPlanID = '" + planid + "';";
                using (SqlCommand pls = new SqlCommand(@query, connect))
                {
                    name.Text = (pls.ExecuteScalar()).ToString();
                }

                connect.Close();
            }
        }

        void refresh()
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Schedule_Exercise.ExerciseName, Schedule_Exercise.Sets, " +
                            "Schedule_Exercise.Reps, Schedule_Exercise.Rest_Interval, Exercise.MachineName " +
                            "FROM Schedule_Exercise " +
                            "INNER JOIN Exercise ON Exercise.ExerciseName = Schedule_Exercise.ExerciseName " +
                            "WHERE Schedule_Exercise.PlanID = '" + planid.ToString() + "' AND Schedule_Exercise.Day = '" + din.ToString() + "';";

            using (SqlCommand pls = new SqlCommand(query, connect))
            {
                using (SqlDataAdapter adapter = new SqlDataAdapter(pls))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    infotable.DataSource = table;
                }

            }
            connect.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form is MemberWO4)
                {
                    form.Enabled = true;
                    break;
                }
            }
            if (!exist)
            {
                MessageBox.Show("No exercises were added!", "Day not saved!");
            }
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!exist) {
                if (string.IsNullOrWhiteSpace(targetbox.Text))
                {
                    MessageBox.Show("Enter a target muscle-group for the day!", "Input Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection plswork = new SqlConnection(connectionString))
                    {
                        plswork.Open();
                        string query = @"INSERT INTO WorkOutSchedule (WPlanID, Day, MuscleGroup)
                                     VALUES (@WID, @Din, @Group)";


                        using (SqlCommand plspls = new SqlCommand(query, plswork))
                        {
                            plspls.Parameters.AddWithValue("@WID", planid);
                            plspls.Parameters.AddWithValue("@Din", din);
                            plspls.Parameters.AddWithValue("@Group", targetbox.Text);

                            if ((int)plspls.ExecuteNonQuery() > 0)
                            {
                                exist = true;
                            }
                        }
                        plswork.Close();
                    }
                }
            }
            if (exist)
            {
                if (string.IsNullOrWhiteSpace(sets.Text) || string.IsNullOrWhiteSpace(reps.Text) || string.IsNullOrWhiteSpace(intezaar.Text) || konsi.SelectedIndex == -1)
                {
                    MessageBox.Show("All fields must be filled!", "Input Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string query = @"SELECT COUNT(*) FROM Schedule_Exercise " +
                                            "WHERE PlanID = @PlanID AND Day = @Day AND ExerciseName = @ExerciseName";

                        using (SqlCommand pls = new SqlCommand(query, connect))
                        {
                            pls.Parameters.AddWithValue("@PlanID", planid);
                            pls.Parameters.AddWithValue("@Day", din);
                            pls.Parameters.AddWithValue("@ExerciseName", konsi.SelectedItem.ToString());
                            if ((int)pls.ExecuteScalar() > 0)
                            {
                                MessageBox.Show("Exercise already exists for this day.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                query = @"INSERT INTO Schedule_Exercise (PlanID, Day, ExerciseName, Sets, Reps, Rest_Interval) " +
                                        "VALUES (@ID, @Din, @Name, @Sets, @Reps, @RestInterval)";

                                pls.CommandText = query;
                                pls.Parameters.AddWithValue("@ID", planid);
                                pls.Parameters.AddWithValue("@Din", din);
                                pls.Parameters.AddWithValue("@Name", konsi.SelectedItem.ToString());
                                pls.Parameters.AddWithValue("@Sets", sets.Text);
                                pls.Parameters.AddWithValue("@Reps", reps.Text);
                                pls.Parameters.AddWithValue("@RestInterval", intezaar.Text);

                                if ((int)pls.ExecuteNonQuery() > 0)
                                {
                                    refresh();
                                }

                            }
                        }
                        connect.Close();
                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            new Exercise(connectionString).Show();//allow them to add new exercises and view their descriptions
        }

        private void dayno_Click(object sender, EventArgs e)
        {

        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selected = e.RowIndex;
            if (selected >= 0 && selected < infotable.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow chosenrow = infotable.Rows[selected];

                string work = Convert.ToString(chosenrow.Cells["ExerciseName"].Value);
                donekonsi.SelectedIndex = donekonsi.FindStringExact(work);
                donesets.Text = Convert.ToString(chosenrow.Cells["Sets"].Value);
                donereps.Text = Convert.ToString(chosenrow.Cells["Reps"].Value);
                donerest.Text = Convert.ToString(chosenrow.Cells["Rest_Interval"].Value);
            }
            else
            {
                donekonsi.SelectedIndex = -1;
                donesets.Text = "";
                donereps.Text = "";
                donerest.Text = "";
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //the day target has been changed - badal do
            if (!string.IsNullOrWhiteSpace(targetbox.Text))
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = @"UPDATE WorkOutSchedule 
                                SET MuscleGroup = @MuscleGroup 
                                WHERE WPlanID = @PlanID AND Day = @Day";
                    using (SqlCommand pls = new SqlCommand(query, connect))
                    {
                        pls.Parameters.AddWithValue("@PlanID", planid);
                        pls.Parameters.AddWithValue("@Day", din);
                        pls.Parameters.AddWithValue("@MuscleGroup", targetbox.Text);

                        if (pls.ExecuteNonQuery() > 0)  //notify of changes
                        {
                            MessageBox.Show("Target Muscle changed successfully!", "Successful Change!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    connect.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sets.Text = "";
            reps.Text = "";
            intezaar.Text = "";
            konsi.SelectedIndex = -1;
            donekonsi.SelectedIndex = -1;
            donesets.Text = "";
            donereps.Text = "";
            donerest.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(donesets.Text) && string.IsNullOrWhiteSpace(donereps.Text) && string.IsNullOrWhiteSpace(donerest.Text))
            {
                MessageBox.Show("Fill All Fields.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = @"UPDATE Schedule_Exercise 
                                     SET Sets = @Sets, Reps = @Reps, Rest_Interval = @RestInterval
                                     WHERE PlanID = @PlanID AND Day = @Day AND ExerciseName = @Name";

                    using (SqlCommand pls = new SqlCommand(query, connect))
                    {
                        pls.Parameters.AddWithValue("@PlanID", planid);
                        pls.Parameters.AddWithValue("@Day", din);
                        pls.Parameters.AddWithValue("@Name", donekonsi.SelectedItem.ToString());
                        pls.Parameters.AddWithValue("@Sets", donesets.Text);
                        pls.Parameters.AddWithValue("@Reps", donereps.Text);
                        pls.Parameters.AddWithValue("@RestInterval", donerest.Text);

                        if (pls.ExecuteNonQuery() > 0)  //notify of changes
                        {
                            refresh();
                            MessageBox.Show("Exercise updated successfully!", "Successful Change!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            donekonsi.SelectedIndex = -1;
                            donesets.Text = "";
                            donereps.Text = "";
                            donerest.Text = "";
                        }
                    }
                    connect.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(donesets.Text) && !string.IsNullOrWhiteSpace(donereps.Text) && !string.IsNullOrWhiteSpace(donerest.Text))
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = @"DELETE FROM Schedule_Exercise
                                        WHERE PlanID = @PlanID
                                        AND Day = @Day
                                        AND ExerciseName = @Name;";

                    using (SqlCommand pls = new SqlCommand(query, connect))
                    {
                        pls.Parameters.AddWithValue("@PlanID", planid);
                        pls.Parameters.AddWithValue("@Day", din);
                        pls.Parameters.AddWithValue("@Name", donekonsi.SelectedItem.ToString());
                        pls.Parameters.AddWithValue("@Sets", donesets.Text);
                        pls.Parameters.AddWithValue("@Reps", donereps.Text);
                        pls.Parameters.AddWithValue("@RestInterval", donerest.Text);

                        if (pls.ExecuteNonQuery() > 0)  //notify of changes
                        {
                            refresh();
                            MessageBox.Show("Exercise deleted successfully!", "Successful Change!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            donekonsi.SelectedIndex = -1;
                            donesets.Text = "";
                            donereps.Text = "";
                            donerest.Text = "";
                            using (SqlConnection omg = new SqlConnection(connectionString))
                            {
                                omg.Open();
                                string countquery = "SELECT COUNT(*) FROM SCHEDULE_EXERCISE WHERE PlanID = '" + planid + "' AND Day = '" + din + "';";
                                SqlCommand cmd = new SqlCommand(countquery, omg);
                                if ((int)cmd.ExecuteScalar() <= 0)
                                {
                                    exist = false;
                                }
                                omg.Close();
                            }
                        }
                    }
                    connect.Close();
                }
            }
        }
    }
}
