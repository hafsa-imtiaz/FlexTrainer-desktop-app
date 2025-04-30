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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class MemberAct : Form
    {
        int UserID;
        string connectionString;
        public MemberAct(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            string query = "SELECT ExerciseName, Sets, Reps, Calories, Duration, Date FROM Exercise_Log WHERE MemID = '" + UserID + "';";
            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
            DataTable userdata = new DataTable();
            userTable.Fill(userdata);
            infotable.DataSource = userdata;

            query = "SELECT ExerciseName FROM Exercise";
            using (SqlCommand command = new SqlCommand(query, connect))
            {
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    konsi.Items.Add(reader["ExerciseName"].ToString());
                }
                reader.Close();
            }
            connect.Close();
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
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string query = "SELECT ExerciseName, Sets, Reps, Calories, Duration, Date FROM Exercise_Log WHERE MemID = @UserID;";
                using (SqlDataAdapter userTable = new SqlDataAdapter(query, connect))
                {
                    userTable.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    infotable.DataSource = null;
                    infotable.Columns.Clear();
                    infotable.Rows.Clear();
                    infotable.DataSource = userdata;
                }
                connect.Close();
            }
            else
                searchlabel.Visible = false;
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
            new MemberDiet1(UserID, connectionString).Show();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void searchButton_Click(Object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchBox.Text))
            {
                //do nothing --- can't search for nothing
            }
            else
            {
                string search = "%" + SearchBox.Text +"%";
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string query = "SELECT ExerciseName, Sets, Reps, Calories, Duration, Date FROM Exercise_Log WHERE MemID = @UserID AND ExerciseName LIKE @Search;";
                using (SqlDataAdapter userTable = new SqlDataAdapter(query, connect))
                {
                    userTable.SelectCommand.Parameters.AddWithValue("@UserID", UserID);
                    userTable.SelectCommand.Parameters.AddWithValue("@Search", "%" + search + "%");

                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    infotable.DataSource = null;
                    infotable.Columns.Clear();
                    infotable.Rows.Clear();
                    infotable.DataSource = userdata;
                }
                connect.Close();

            }
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show();
            this.Hide();
        }

        private void find_Click(object sender, EventArgs e)
        {
            new MemberDiet3(UserID, connectionString).Show();
            this.Hide();
        }

        private void create_Click(object sender, EventArgs e)
        {
            new MemberDiet4(UserID, connectionString).Show();
            this.Hide();
        }

        private void searchlabel_Click(object sender, EventArgs e)
        {
            SearchBox.Focus();
        }

        private void actButton_Click(object sender, EventArgs e)
        {

        }
        private void gymButton_Click(object sender, EventArgs e)
        {
            new MemberGym(UserID, connectionString).Show(); this.Hide();
        }
        private void settingButton_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(sets.Text) || string.IsNullOrWhiteSpace(reps.Text) || string.IsNullOrWhiteSpace(calories.Text) || konsi.SelectedIndex == -1 || duration.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled!", "Input Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                DateTime selectedDate = dateTimePicker1.Value;
                string waqt = selectedDate.ToString("yyyy-MM-dd");
                string query = "INSERT INTO Exercise_Log VALUES(" + UserID + ", '" + konsi.SelectedItem.ToString() + "', '" + sets.Text + "', '" + reps.Text + "', '" + calories.Text + "', '" + waqt + "','" + duration.SelectedItem.ToString() + "');";
                SqlCommand cmd = new SqlCommand(query, connect);
                cmd.ExecuteNonQuery();

                query = "SELECT ExerciseName, Sets, Reps, Calories, Duration, Date FROM Exercise_Log WHERE MemID = '" + UserID + "';";
                SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                infotable.DataSource = userdata;

                cmd.Dispose();
                connect.Close();


            }
        }

        private void duration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Exercise(connectionString).Show();//allow them to add new exercises and view their descriptions
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
