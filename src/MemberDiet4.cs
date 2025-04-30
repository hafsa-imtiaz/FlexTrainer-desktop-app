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
    public partial class MemberDiet4 : Form
    {
        int UserID;
        string connectionString;
        bool done;
        int days;
        int id;
        int daily;
        public MemberDiet4(int userID, string connectionString)
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

        private void MemberDiet4_Load(object sender, EventArgs e)
        {

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
        private void dashbutton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberHome(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberHome(UserID, connectionString).Show();
                this.Hide();
            }
        }
        private void workButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberWO1(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberWO1(UserID, connectionString).Show();
                this.Hide();
            }
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
            panel2.BackColor = Color.FromArgb(230, 53, 76, 67);
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
        private void dietButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberDiet1(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberDiet1(UserID, connectionString).Show();
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
                    new MemberProfile(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberProfile(UserID, connectionString).Show();
                this.Hide();
            }
        }
        private void searchButton_Click(Object sender, EventArgs e)
        {

        }
        private void trainButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberTraining(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberTraining(UserID, connectionString).Show();
                this.Hide();
            }
        }
        private void settingButton_Click(object sender, EventArgs e)
        {
        }
        private void findbutton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberDiet3(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberDiet3(UserID, connectionString).Show();
                this.Hide();
            }
        }
        private void createbutton_Click(object sender, EventArgs e)
        {
            //do nothing - you are here
        }
        private void mywo_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberDiet1(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberDiet1(UserID, connectionString).Show();
                this.Hide();
            }
        }
        private void actButton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberAct(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberAct(UserID, connectionString).Show();
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

                    new MemberGym(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberGym(UserID, connectionString).Show();
                this.Hide();
            }
        }
        private void searchlabel_Click(object sender, EventArgs e)
        {
            SearchBox.Focus();
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
            if(calorie.Text.Length > 0) calorielabel.Visible = false;
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
            if (typebox.Text.Length > 0) plantype.Visible = false; else plantype.Visible =true;
        }

        private void name_TextChanged(object sender, EventArgs e)
        {
            if(name.Text.Length != 0) namelabel.Visible = false;
            else namelabel.Visible = true;
        }

        private void goal_TextChanged(object sender, EventArgs e)
        {
            if(goal.Text.Length > 0)  goallabel.Visible = false;
            else goallabel.Visible = true;
        }

        private void status_CheckedChanged(object sender, EventArgs e)
        {
            if(!status.Checked) { apnapna.Checked = true; }
            else apnapna.Checked = false;
        }

        private void apnapna_CheckedChanged(object sender, EventArgs e)
        {
            if (apnapna.Checked) status.Checked = false; else status.Checked = true;
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void create_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(goal.Text) || string.IsNullOrWhiteSpace(descrip.Text) || diffi.SelectedIndex == -1 || (!status.Checked && !apnapna.Checked))
            {
                MessageBox.Show("Fill All Details to create a plan!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();

                        string q2 = "SELECT MAX(DPLANID) FROM DIETPLAN";
                        SqlCommand cmd = new SqlCommand(q2, connect);
                        int idval = (int)cmd.ExecuteScalar();
                        idval++;


                        string query = @"INSERT INTO DietPlan (DPlanID, PlanName, Type, Goal, Description, calorie_intake, CreationDate, CreatorID, Share_Status) " +
                                 "VALUES(@id, @PlanName, @Type, @Goal, @Description, @CalorieIntake, @CreationDate, @CreatorID, @ShareStatus)";
                        ;
                        using (SqlCommand pls = new SqlCommand(query, connect))
                        {
                            string lmfaotype = (status.Checked) ? "Public" : "Private";
                            pls.Parameters.AddWithValue("@id", idval);
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
                }
                catch(Exception ex) { MessageBox.Show(ex.Message); }
            }
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

        private void addday_Click(object sender, EventArgs e)
        {
            if (!done) { MessageBox.Show("Please create a plan!"); }
            else
            {
                new AddMeal(id, days + 1, connectionString, daily).Show();
                this.Enabled = false;

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

        private void myplanbutton_Click(object sender, EventArgs e)
        {
            if (done && days == 0)
            {
                DialogResult result = MessageBox.Show("You haven't added a day to your plan.\nIf you leave, your plan will be deleted.", "Are you sure you wish to leave?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    removePlan();

                    new MemberDiet2(UserID, connectionString).Show();
                    this.Hide();
                }
            }
            else
            {
                new MemberDiet2(UserID, connectionString).Show();
                this.Hide();
            }
        }

        private void diffi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
