using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class TrainGym : Form
    {
        int UserID;
        string connectionString;
        int selected;
        int requestselect;
        public TrainGym(int userid, string conns)
        {
            InitializeComponent();
            this.UserID = userid;
            this.connectionString = conns;
            selected = -1;
            requestselect = -1;
            label1.Visible = false;

            try
            {
                string query = @"SELECT Gym.GymName, Gym.PHoneNo, Gym.Address, Gym_Employment.StartDate, Gym_Employment.Salary, Gym.GymID
                                 FROM Gym
                                 INNER JOIN Gym_Employment ON Gym.GymID = Gym_Employment.GymID
                                 WHERE Gym_Employment.TrainerID = @TrainerID
                                   AND Gym_Employment.startDate <= GETDATE()
                                   AND (Gym_Employment.endDate IS NULL OR Gym_Employment.endDate >= GETDATE())";
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
                            dataGridView1.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            try
            {
                string query = @"SELECT Gym.GymName, Trainer_Request.Status, Trainer_Request.Date, Trainer_Request.RequestID
                     FROM Trainer_Request
                     INNER JOIN Trainer ON Trainer_Request.TrainerID = Trainer.TrainerID
                     INNER JOIN Gym ON Trainer_Request.GymID = Gym.GymID WHERE Trainer_Request.TrainerID = '" + UserID + "';";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            infotable.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            selected = requestselect = -1;
            label1.Visible = false;
            namebox.Text = string.Empty;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            requestselect = -1;
            label1.Visible = false;
            if (selected >= 0 && selected < dataGridView1.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = dataGridView1.Rows[selected];
                namebox.Text = targetRow.Cells[0].Value?.ToString();
            }
            else
            {
                namebox.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selected >= 0 && selected < dataGridView1.Rows.Count && !record.Checked)   //selected valid hai??
            {
                DataGridViewRow targetRow = dataGridView1.Rows[selected];
                int gymID = Convert.ToInt32(targetRow.Cells[5].Value);
                try
                {
                    string query = @"UPDATE Gym_Employment
                     SET endDate = GETDATE()
                     WHERE GymID = @GymID
                       AND TrainerID = @TrainerID
                       AND endDate IS NULL";
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@GymID", gymID);
                            command.Parameters.AddWithValue("@TrainerID", UserID);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Employment ended successfully.");
                                try
                                {
                                    query = @"SELECT Gym.GymName, Gym.PHoneNo, Gym.Address, Gym_Employment.StartDate, Gym_Employment.Salary, Gym.GymID
                                     FROM Gym
                                     INNER JOIN Gym_Employment ON Gym.GymID = Gym_Employment.GymID
                                     WHERE Gym_Employment.TrainerID = @TrainerID
                                       AND Gym_Employment.startDate <= GETDATE()
                                       AND (Gym_Employment.endDate IS NULL OR Gym_Employment.endDate >= GETDATE())";

                                        connection.Open();
                                        using (SqlCommand cmd = new SqlCommand(query, connection))
                                        {
                                            cmd.Parameters.AddWithValue("@TrainerID", UserID);

                                            using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                                            {
                                                DataTable dataTable = new DataTable();
                                                adapter.Fill(dataTable);
                                                dataGridView1.DataSource = dataTable;
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
                                MessageBox.Show("No employment record found for the specified trainer and gym.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            selected = -1;

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (record.Checked)
            {
                title.Text = "All Employment";
                try
                {
                    string query = @"SELECT Gym.GymName, Gym.PHoneNo, Gym.Address, Gym_Employment.StartDate, Gym_Employment.EndDate, Gym_Employment.Salary, Gym.GymID
                     FROM Gym
                     INNER JOIN Gym_Employment ON Gym.GymID = Gym_Employment.GymID
                     WHERE Gym_Employment.TrainerID = @TrainerID
                     ORDER BY Gym_Employment.startDate DESC";
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
                                dataGridView1.DataSource = dataTable;
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
                title.Text = "Current Gyms";
                try
                {
                    string query = @"SELECT Gym.GymName, Gym.PHoneNo, Gym.Address, Gym_Employment.StartDate, Gym_Employment.EndDate, Gym_Employment.Salary, Gym.GymID
                                 FROM Gym
                                 INNER JOIN Gym_Employment ON Gym.GymID = Gym_Employment.GymID
                                 WHERE Gym_Employment.TrainerID = @TrainerID
                                   AND Gym_Employment.startDate <= GETDATE()
                                   AND (Gym_Employment.endDate IS NULL OR Gym_Employment.endDate >= GETDATE())";
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
                                dataGridView1.DataSource = dataTable;
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

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            requestselect = e.RowIndex;
            selected = -1;
            namebox.Text = string.Empty;
            if (requestselect >= 0 && requestselect < dataGridView1.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = dataGridView1.Rows[requestselect];
                label1.Text = "Selected: " + targetRow.Cells[0].Value?.ToString();
            }
            else
            {
                label1.Visible = false;
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (requestselect >= 0 && requestselect < dataGridView1.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = dataGridView1.Rows[requestselect];
                int requestId = Convert.ToInt32(targetRow.Cells[4].Value);


                try
                {
                    string query = @"DELETE FROM Trainer_Request
                     WHERE RequestID = @RequestID";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@RequestID", requestId);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Request deleted successfully.");
                            }
                            else
                            {
                                MessageBox.Show("No request found with the specified RequestID.");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                try
                {
                    string query = @"SELECT Gym.GymName, Trainer_Request.Status, Trainer_Request.Date, Trainer_Request.RequestID
                     FROM Trainer_Request
                     INNER JOIN Trainer ON Trainer_Request.TrainerID = Trainer.TrainerID
                     INNER JOIN Gym ON Trainer_Request.GymID = Gym.GymID WHERE Trainer_Request.TrainerID = '" + UserID + "';";

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                            {
                                DataTable dataTable = new DataTable();
                                adapter.Fill(dataTable);
                                infotable.DataSource = dataTable;
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }

            label1.Visible = false;
        }

        private void addday_Click(object sender, EventArgs e)
        {
            new JoinGym(UserID, connectionString, "T").Show();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            new TrainerFeedback(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
