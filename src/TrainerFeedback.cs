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
    public partial class TrainerFeedback : Form
    {
        int UserID;
        string connectionString;
        int selected;
        public TrainerFeedback(int UserID, string connectionString)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.connectionString = connectionString;
            selected = -1;

            try
            {
                string query = @"SELECT CONCAT(U.FName, ' ', U.LName) AS MemberName, TF.Rating, TF.Comment, TF.Date, TF.Time, TF.MemID
                                 FROM Trainer_Feedback TF
                                 INNER JOIN Users U ON TF.MemID = U.UserID
                                 WHERE TF.TrainerID = @TrainerID";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrainerID", UserID);
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            info.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void TrainerFeedback_Load(object sender, EventArgs e)
        {

        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new TrainHome(UserID, connectionString).Show();
            this.Hide();
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new TrainerSchedule(UserID, connectionString).Show();
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new TrainWO(UserID, connectionString).Show();
            this.Hide();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new TrainGym(UserID, connectionString).Show();
            this.Hide();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {

        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new TrainerProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < info.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = info.Rows[selected];

                name.Text = (targetRow.Cells["MemberName"].Value).ToString();
                descrip.Text = (targetRow.Cells["Comment"].Value).ToString();

                DateTime dateValue = Convert.ToDateTime(targetRow.Cells["Date"].Value);
                DateTime dateOnly = dateValue.Date;
                string dateString = dateOnly.ToShortDateString();
                status.Text = dateString + ' ' + (targetRow.Cells["Time"].Value).ToString();
                date.Text = (targetRow.Cells["Rating"].Value).ToString();
            }
            else
            {
                selected = -1;
            }
        }

        private void memberhistory_Click(object sender, EventArgs e)
        {
            if (selected >= 0 && selected < info.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = info.Rows[selected];
                int memid = Convert.ToInt32(targetRow.Cells["MemID"].Value);
                new TrainMem(memid, UserID, connectionString).Show();
            }
            else
            {
                selected = -1;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(searchbox.Text))
            {
                try
                {
                    string query = @"SELECT CONCAT(U.FName, ' ', U.LName) AS MemberName, TF.Rating, TF.Comment, TF.Date, TF.Time, TF.MemID
                                 FROM Trainer_Feedback TF
                                 INNER JOIN Users U ON TF.MemID = U.UserID
                                 WHERE TF.TrainerID = @TrainerID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TrainerID", UserID);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                info.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    string query = @"SELECT CONCAT(U.FName, ' ', U.LName) AS MemberName, TF.Rating, TF.Comment, TF.Date, TF.Time, TF.MemID
                                 FROM Trainer_Feedback TF
                                 INNER JOIN Users U ON TF.MemID = U.UserID
                                 WHERE TF.TrainerID = @TrainerID AND (Ratine ='" + searchbox.Text + "' OR Comment LIKE '%" + searchbox.Text + "%' OR CONCAT(U.FName, ' ', U.LName) LIKE '%" + searchbox.Text + "%';";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TrainerID", UserID);
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                info.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
