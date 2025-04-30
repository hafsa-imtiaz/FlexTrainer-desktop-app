using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class TrainHome : Form
    {
        int UserID;
        string connectionString;
        public TrainHome(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Users.FName + ' ' + Users.LName FROM Users WHERE Users.UserID = '" + UserID + "';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    terenaam.Text = (command.ExecuteScalar()).ToString();
                    query = "SELECT Email FROM Users WHERE Users.UserID = '" + UserID + "';";
                    command.CommandText = query;
                    traineremail.Text = (command.ExecuteScalar()).ToString();

                    query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Date, Time, Status FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "' AND DATE > CURRENT_TIMESTAMP;";
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    dataGridView1.DataSource = userdata;

                    query = "SELECT TOP 3 Users.FName + ' ' + Users.LName AS Member_Name, Rating, Comment FROM Trainer_Feedback INNER JOIN Users ON Users.UserID = Trainer_Feedback.MemID WHERE TrainerID = '" + UserID + "';";
                    SqlDataAdapter userTable2 = new SqlDataAdapter(query, connection);
                    DataTable userdata2 = new DataTable();
                    userTable2.Fill(userdata2);
                    dataGridView2.DataSource = userdata2;

                }
                connection.Close();
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

        private void TrainHome_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void schedule_Click(object sender, EventArgs e)
        {

        }

        private void schedule_MouseHover(object sender, EventArgs e)
        {
            schedule.ForeColor = Color.FromArgb(230, 0, 0, 0);
            schedule.BackColor = Color.FromArgb(230, 6, 57, 112);
        }
        private void Schedule_MouseLeave(object sender, EventArgs e)
        {
            schedule.ForeColor = Color.FromArgb(230, 0, 26, 71);
            schedule.BackColor = Color.FromArgb(10, 6, 57, 112);
        }

        private void panel4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show(); this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new TrainerProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new TrainerSchedule(UserID, connectionString).Show(); 
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new TrainWO(UserID, connectionString).Show(); this.Hide();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new TrainGym(UserID, connectionString).Show(); this.Hide();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            new TrainerFeedback(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
