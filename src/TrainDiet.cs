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
    public partial class TrainDiet : Form
    {
        int UserID;
        string connectionString;
        bool done;
        int days;
        int id;
        int daily;
        public TrainDiet(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;
            done = false;
            addday.Visible = false;
            days = 0;
            id = -1;
            daily = -1;
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
        private void button1_Click(object sender, EventArgs e)
        {

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

        private void outButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new LogIn().Show();
                    this.Hide();
                }
            }
            else
            {
                new LogIn().Show();
                this.Hide();
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

        private void gymButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new TrainerSchedule(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainerSchedule(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void mywo_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new TrainWO(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainWO(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new TrainWO(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new TrainWO(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void namelabel_Click(object sender, EventArgs e)
        {
            name.Focus();
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text.Length > 0) label1.Visible = false;
            else label1.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            descrip.Focus();
        }

        private void goallabel_Click(object sender, EventArgs e)
        {
            goal.Focus();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (calorie.Text.Length > 0) calorielabel.Visible = false;
            else calorielabel.Visible = true;
        }

        private void calorielabel_Click(object sender, EventArgs e)
        {
            calorie.Focus();
        }

        private void plantype_Click(object sender, EventArgs e)
        {
            typebox.Focus();
        }

        private void typebox_TextChanged(object sender, EventArgs e)
        {
            if (typebox.Text.Length > 0) plantype.Visible = false; else plantype.Visible = true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if (name.Text.Length != 0) namelabel.Visible = false;
            else namelabel.Visible = true;
        }

        private void goal_TextChanged(object sender, EventArgs e)
        {
            if (goal.Text.Length > 0) goallabel.Visible = false;
            else goallabel.Visible = true;
        }

        private void status_CheckedChanged(object sender, EventArgs e)
        {
            if (!status.Checked) { apnapna.Checked = true; }
            else apnapna.Checked = false;
        }

        private void apnapna_CheckedChanged(object sender, EventArgs e)
        {
            if (apnapna.Checked) status.Checked = false; else status.Checked = true;
        }

        private void diffi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void calorie_TextChanged(object sender, EventArgs e)
        {
            if (calorie.Text.Length > 0) calorielabel.Visible = false;
            else calorielabel.Visible = true;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            descrip.Text = string.Empty;
            goal.Text = string.Empty;
            diffi.SelectedIndex = -1;
            status.Checked = false;
            typebox.Text = string.Empty;
            calorie.Text = string.Empty;
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
                    string query = @"INSERT INTO DietPlan (PlanName, Type, Goal, Description, calorie_intake, CreationDate, CreatorID, Share_Status) " +
                             "VALUES(@PlanName, @Type, @Goal, @Description, @CalorieIntake, @CreationDate, @CreatorID, @ShareStatus)";
                    ;
                    try
                    {
                        using (SqlCommand pls = new SqlCommand(query, connect))
                        {
                            string lmfaotype = (status.Checked) ? "Public" : "Private";
                            pls.Parameters.AddWithValue("@PlanName", name.Text);
                            pls.Parameters.AddWithValue("@Description", descrip.Text);
                            pls.Parameters.AddWithValue("@ShareStatus", lmfaotype);
                            pls.Parameters.AddWithValue("@Goal", goal.Text);
                            pls.Parameters.AddWithValue("@Difficulty", diffi.SelectedItem.ToString());
                            pls.Parameters.AddWithValue("@CreationDate", DateTime.Now); // Current timestamp as date
                            pls.Parameters.AddWithValue("@CreatorID", UserID);
                            pls.Parameters.AddWithValue("@Type", typebox.Text);
                            pls.Parameters.AddWithValue("@CalorieIntake", calorie.Text);
                            daily = Convert.ToInt32(calorie.Text);


                            if (pls.ExecuteNonQuery() > 0)
                            {
                                done = true;
                                cancel.Visible = false;
                                cancel.Enabled = false;
                                create.Enabled = false;
                                create.Visible = false;
                                addday.Visible = true;
                                addday.Enabled = true;
                                query = "SELECT max(DPlanID) FROM DietPlan;";
                                pls.CommandText = query;
                                id = (int)pls.ExecuteScalar();
                                MessageBox.Show("Diet Plan added successfully!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Failed to add Diet Plan.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch(Exception ex) { MessageBox.Show("Exception: ", ex.Message.ToString()); }
                }
            }
        }

        private void addday_Click(object sender, EventArgs e)
        {
            if (!done) { MessageBox.Show("Please create a plan!"); }
            else
            {
                new AddMeal(id, days + 1, connectionString, daily).Show();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (SqlConnection omg = new SqlConnection(connectionString))
            {
                omg.Open();
                string countquery = "SELECT COUNT(*) FROM Diet_Meal WHERE DPlanID = '" + id + "';";
                SqlCommand cmd = new SqlCommand(countquery, omg);
                days = (int)cmd.ExecuteScalar();

                string query = "SELECT Diet_Meal.Day, Meal.Name, Diet_Meal.MealType FROM Diet_Meal INNER JOIN MEAL ON MEAL.MEALID = Diet_Meal.MEALID WHERE DPlanID = '" + id + "';";

                SqlDataAdapter adapter = new SqlDataAdapter(query, omg);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                infotable.DataSource = dataTable;

                omg.Close();
            }
        }

        void removePlan()
        {
            using (SqlConnection connect = new SqlConnection(connectionString))
            {
                try
                {
                    connect.Open();
                    string query = "DELETE FROM DietPlan WHERE DPlanID = @DPlanID";

                    using (SqlCommand pls = new SqlCommand(query, connect))
                    {
                        pls.CommandText = query;
                        pls.Parameters.AddWithValue("@DPlanID", id.ToString());

                        int rowsAffected = pls.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Diet Plan removed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No record found with the provided Diet Plan ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            new MeraForm(UserID, connectionString, "D").Show();
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
