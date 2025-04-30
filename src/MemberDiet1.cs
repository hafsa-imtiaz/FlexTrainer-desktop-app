using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class MemberDiet1 : Form
    {
        int UserID;
        string connectionString;
        public MemberDiet1(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;

            try
            {
                using (SqlConnection omg = new SqlConnection(connectionString))
                {
                    omg.Open();

                    string countquery = "SELECT count(*) FROM Member WHERE MEMID = '" + UserID + "' AND DPLANID IS NOT NULL;";
                    SqlCommand cmd1 = new SqlCommand(countquery, omg);
                    if((int)cmd1.ExecuteScalar() > 0){ 
                        int planID;
                        countquery = "SELECT Member.DPlanID FROM Member WHERE MEMID = '" + UserID + "';";
                        SqlCommand cmd = new SqlCommand(countquery, omg);
                        cmd = new SqlCommand(countquery, omg);
                        planID = Convert.ToInt32(cmd.ExecuteScalar());
                        string query = "SELECT wp.PlanName, wp.Description, " +
                                            "wp.Goal, wp.Type, wp.CreationDate, wp.Calorie_Intake, " +
                                            "u.FName + ' ' + u.LName AS CreatorName, u.URole " +
                                            "FROM DietPlan wp " +
                                            "INNER JOIN Users u ON wp.CreatorID = u.UserID WHERE DPlanID = '" + planID + "';";
                        cmd.CommandText = query;
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows) //agar records hain
                            {
                                while (reader.Read())
                                {
                                    name.Text = reader["PlanName"].ToString();
                                    descrip.Text = reader["Description"].ToString();
                                    kab.Text = reader["CreationDate"].ToString();
                                    goal.Text = reader["Goal"].ToString();
                                    ownername.Text = reader["CreatorName"].ToString();
                                    role.Text = reader["URole"].ToString();
                                    diffi.Text = reader["Type"].ToString();
                                }
                            }
                            reader.Close();
                        }
                        //print table
                        query = "SELECT Day, Meal.Name FROM Diet_Meal INNER JOIN MEAL ON MEAL.MEALID = DIET_MEAL.MEALID WHERE  DPLANID = '" + planID + "'; ";
                        SqlDataAdapter adapter = new SqlDataAdapter(query, omg);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        infotable.DataSource = dataTable;
                    }
                    else
                    {
                        update.Enabled = update.Visible = false;
                        panel4.Enabled = panel4.Visible = false;
                        name.Enabled = name.Visible = false;
                        descrip.Enabled = descrip.Visible = false;
                        goal.Enabled = goal.Visible = false;
                        ownername.Enabled = ownername.Visible = false;
                        role.Enabled = role.Visible = false;
                        kab.Enabled = kab.Visible = false;
                        diffi.Enabled = diffi.Visible = false;
                        label14.Text = "No current Diet Plan";
                        label6.Enabled = label6.Visible = false;
                    }

                    omg.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
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
            //do nothing
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void searchButton_Click(Object sender, EventArgs e)
        {
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

        private void create_Click(object sender, EventArgs e)
        {
            new MemberDiet4(UserID, connectionString).Show();
            this.Hide();
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
        {
        }

        private void mybutton_Click(object sender, EventArgs e)
        {
            new MemberDiet2(UserID, connectionString).Show(); this.Hide();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE Member SET DPlanID = NULL";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        if ((int)command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Workout Plan Removed!", "Success");
                        }
                        else
                        {
                            MessageBox.Show("Workout Plan could not be removed!", "ERROR");
                        }
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}
