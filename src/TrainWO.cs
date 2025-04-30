using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class TrainWO : Form
    {
        int UserID;
        string connectionString;
        bool done;
        int days;
        int id;
        public TrainWO(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;
            done = false;
            addday.Visible = false;
            days = 0;
            id = -1;
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

        private void viemember_Paint(object sender, PaintEventArgs e)
        {

        }

        private void diffi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apnapna_CheckedChanged(object sender, EventArgs e)
        {
            if (apnapna.Checked)
            {
                status.Checked = false;
            }
            else status.Checked = true;
        }
        private void status_CheckedChanged(object sender, EventArgs e)
        {
            if (status.Checked) { apnapna.Checked = false; }
            else apnapna.Checked = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            descrip.Text = string.Empty;
            goal.Text = string.Empty;
            diffi.SelectedIndex = -1;
            status.Checked = false;
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(goal.Text) || string.IsNullOrWhiteSpace(descrip.Text) || diffi.SelectedIndex == -1 || (!status.Checked && !apnapna.Checked))
            {
                MessageBox.Show("Fill All Details to create a plan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "INSERT INTO WorkoutPlan (PlanName, Description, Share_Status, Goal, Difficulty, CreatedDate, CreatorID) " +
                                       "VALUES (@PlanName, @Description, @ShareStatus, @Goal, @Difficulty, @CreatedDate, @CreatorID)";
                    try
                    {
                        using (SqlCommand pls = new SqlCommand(query, connect))
                        {
                            string type = (status.Checked) ? "Public" : "Private";
                            pls.Parameters.AddWithValue("@PlanName", name.Text);
                            pls.Parameters.AddWithValue("@Description", descrip.Text);
                            pls.Parameters.AddWithValue("@ShareStatus", type);
                            pls.Parameters.AddWithValue("@Goal", goal.Text);
                            pls.Parameters.AddWithValue("@Difficulty", diffi.SelectedItem.ToString());
                            pls.Parameters.AddWithValue("@CreatedDate", DateTime.Now); // Current timestamp as date
                            pls.Parameters.AddWithValue("@CreatorID", UserID);


                            if (pls.ExecuteNonQuery() > 0)
                            {
                                done = true;
                                cancel.Visible = false;
                                cancel.Enabled = false;
                                create.Enabled = false;
                                create.Visible = false;
                                addday.Visible = true;
                                query = "SELECT max(WPlanID) FROM WorkoutPlan;";
                                pls.CommandText = query;
                                id = (int)pls.ExecuteScalar();
                                MessageBox.Show("Workout plan added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add workout plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch(Exception ex) { MessageBox.Show("Execption: ", ex.ToString());  }
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection omg = new SqlConnection(connectionString))
            {
                omg.Open();
                string countquery = "SELECT COUNT(*) FROM WORKOUTSCHEDULE WHERE WPlanID = '" + id + "';";
                SqlCommand cmd = new SqlCommand(countquery, omg);
                days = (int)cmd.ExecuteScalar();

                string query = "SELECT Schedule_Exercise.Day, MuscleGroup, Schedule_Exercise.ExerciseName FROM WorkOutSchedule INNER JOIN SCHEDULE_EXERCISE ON SCHEDULE_EXERCISE.PLANID = WORKOUTSCHEDULE.WPLANID WHERE WPlanID = '" + id + "';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, omg);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                infotable.DataSource = dataTable;

                omg.Close();
            }
        }

        private void addday_Click(object sender, EventArgs e)
        {
            if (!done) { MessageBox.Show("Please create a plan!"); }
            else
            {
                new AddDay(id, days + 1, connectionString).Show();
            }
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new TrainHome(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainHome(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void goallabel_Click(object sender, EventArgs e)
        {
            goal.Focus();
        }

        private void goal_TextChanged(object sender, EventArgs e)
        {
            if (goal.Text.Length > 0) { goallabel.Visible = false; }
            else { goallabel.Visible = true; }
        }

        private void desclabel_Click(object sender, EventArgs e)
        {
            descrip.Focus();
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Length > 0) { desclabel.Visible = false; }
            else desclabel.Visible = true;
        }

        private void namelabel_Click(object sender, EventArgs e)
        {
            name.Focus();
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text.Length > 0) { namelabel.Visible = false; }
            else namelabel.Visible = true;
        }

        void removePlan()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string query = "DELETE FROM WorkoutPlan WHERE WPlanID = @WPlanID";

                    using (SqlCommand pls = new SqlCommand(query, connect))
                    {
                        pls.CommandText = query;
                        pls.Parameters.AddWithValue("@WPlanID", id.ToString());

                        int rowsAffected = pls.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Workout plan removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided Workout Plan ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connect.Close();
            }
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    removePlan();
                    new TrainerProfile(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainerProfile(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    removePlan();
                    new LogIn().Show(); this.Hide();
                }
            }
            else
            {
                new LogIn().Show(); this.Hide();
            }
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    removePlan();
                    new TrainerSchedule(UserID, connectionString).Show(); this.Hide();
                }
            }
            else
            {
                new TrainerSchedule(UserID, connectionString).Show(); this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    removePlan();
                    new TrainDiet(UserID, connectionString).Show(); this.Hide();
                }
            }
            else
            {
                new TrainDiet(UserID, connectionString).Show(); this.Hide();
            }
        }

        private void memButton_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MeraForm(UserID, connectionString, "W").Show();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {

            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    removePlan();
                    new TrainerFeedback(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainerFeedback(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            

            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {

                    removePlan();
                    new TrainGym(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainGym(UserID, connectionString).Show();
                this.Hide();
            }
        }
    }
}
