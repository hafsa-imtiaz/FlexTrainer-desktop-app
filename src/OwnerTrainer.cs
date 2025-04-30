using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class OwnerTrainer : Form
    {
        int exselect;
        int rselect;
        int UserID;
        string connectionString;
        public OwnerTrainer(int UserID, string connectionStr)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.connectionString = connectionStr;
            exselect = -1;
            rselect = -1;


            try
            {
                using(SqlConnection conn = new SqlConnection(connectionStr))
                {
                    conn.Open();
                    string query = "select Gym_Employment.TrainerID, concat(u.fname, ' ', u.lname) AS Name, gym.gymname, DATEDIFF(day, Gym_Employment.startDate, CURRENT_TIMESTAMP) As DurationDays, gym.GymID from gym_employment inner join gym on gym.gymID = gym_employment.gymid " +
                                "inner join users u on u.UserID = Gym_Employment.TrainerID where gym_employment.enddate IS NULL AND gym.OwnerID  = '" + UserID + "';";
                    using(SqlDataAdapter userTable = new SqlDataAdapter(query, conn))
                    {
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;
                    }

                    query = "select Trainer_Request.TrainerID, concat(u.fname, ' ', u.lname) AS Name, gym.GymName, Trainer_Request.Status, Trainer_Request.Date, Trainer_Request.GymID from Trainer_Request inner join gym on gym.GymID = Trainer_Request.GymID inner join users u on u.userid= Trainer_Request.TrainerID where trainer_request.status = 'Pending' AND gym.OwnerID = '" + UserID + "';";
                    using (SqlDataAdapter userTable2 = new SqlDataAdapter(query, conn))
                    {
                        DataTable userdata2 = new DataTable();
                        userTable2.Fill(userdata2);
                        dataGridView1.DataSource = userdata2;
                    }
                    conn.Close();
                }

            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void bgpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void meminfo_CellContentClick(object sender, DataGridViewCellEventArgs e)//current
        {
            exselect = e.RowIndex;
            if(exselect >= 0 && info.Rows.Count > 0 )
            {
                DataGridViewRow targetRow = info.Rows[exselect];

                memname.Text= targetRow.Cells["Name"].Value?.ToString();
                durationbox.Text = targetRow.Cells["DurationDays"].Value?.ToString();
            }
            else
            {
                memname.Text = string.Empty;
                durationbox.Text = string.Empty;
            }
        }

        private void durationbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//accept
        {
            if (rselect >= 0 && dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow targetRow = dataGridView1.Rows[rselect];

                int trainid = Convert.ToInt32(targetRow.Cells["TrainerID"].Value);
                int gymid = Convert.ToInt32(targetRow.Cells["GymID"].Value);
                string 

                query = "INSERT INTO Gym_Employment (GymID, TrainerID, endDate, startDate, Salary, Status) " +
                               "VALUES (@GymID, @TrainerID, NULL, CURRENT_TIMESTAMP, @Salary, 'Working')";

                if (!string.IsNullOrEmpty(salary.Text))
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.CommandText = query;
                        command.Parameters.AddWithValue("@GymID", gymid);
                        command.Parameters.AddWithValue("@TrainerID", trainid);
                        command.Parameters.AddWithValue("@Salary", salary.Text);

                        try
                        {
                            connection.Open();
                            if ((int)command.ExecuteNonQuery() > 0)
                            {
                                MessageBox.Show("Request Status Changed.");


                                query = "UPDATE Trainer_Request " +
                                           "SET Status = 'Accepted' " +
                                           "WHERE TrainerID = '" + trainid + "' AND GymID = '" + gymid + "';";
                                if ((int)command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Trainer added!");
                                }
                                else
                                {
                                    MessageBox.Show("Failure in adding trainer!");
                                }


                            }
                            else
                            {
                                MessageBox.Show("Failure in adding trainer!");
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("An error occurred: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Enter a salary.");
                }


            }
            else textBox2.Text = "";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)//request

        {
            rselect = e.RowIndex;
            if (rselect >= 0 && dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow targetRow = dataGridView1.Rows[rselect];

                textBox2.Text = targetRow.Cells["Name"].Value?.ToString();

            }
            else textBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)//reject
        {
            if (rselect >= 0 && dataGridView1.Rows.Count > 0)
            {
                DataGridViewRow targetRow = dataGridView1.Rows[rselect];

                int trainid = Convert.ToInt32(targetRow.Cells["TrainerID"].Value);
                int gymid = Convert.ToInt32(targetRow.Cells["GymID"].Value);
                string query = "UPDATE Trainer_Request " +
                           "SET Status = 'Rejected' " +
                           "WHERE TrainerID = '" + trainid + "' AND GymID = '" + gymid + "';";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);

                    try
                    {
                        connection.Open();
                        if ((int)command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Request Status Changed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }

            }
            else textBox2.Text = "";
        }

        private void remove_Click(object sender, EventArgs e)//remove current
        {
            if (exselect >= 0 && info.Rows.Count > 0)
            {
                DataGridViewRow targetRow = info.Rows[exselect];

                int trainid = Convert.ToInt32(targetRow.Cells["TrainerID"].Value);
                int gymid = Convert.ToInt32(targetRow.Cells["GymID"].Value);

                string query = "UPDATE Gym_Employment " +
                           "SET endDate = CURRENT_TIMESTAMP " +
                           "WHERE GymID = '"+gymid+"' AND TrainerID = '"+trainid+"'  AND ENDDATE IS NULL;";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    try
                    {
                        connection.Open();
                        if ((int)command.ExecuteNonQuery() > 0)
                        {
                            
                            query = "select Gym_Employment.TrainerID, concat(u.fname, ' ', u.lname) AS Name, gym.gymname, DATEDIFF(day, Gym_Employment.startDate, CURRENT_TIMESTAMP) As DurationDays, gym.gymid from gym_employment inner join gym on gym.gymID = gym_employment.gymid " +
                                "inner join users u on u.UserID = Gym_Employment.TrainerID where gym_employment.enddate IS NULL AND gym.OwnerID  = '" + UserID + "';";
                            using (SqlDataAdapter userTable = new SqlDataAdapter(query, connection))
                            {
                                DataTable userdata = new DataTable();
                                userTable.Fill(userdata);
                                info.DataSource = userdata;
                            }
                            MessageBox.Show("Trainer Removed.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }

            }
            else memname.Text = "";
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new OwnerProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new OwnerMember(UserID, connectionString).Show();
            this.Hide();
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new OwnerGym(UserID, connectionString).Show();
            this.Hide();
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new OwnerHome(UserID, connectionString).Show();
            this.Hide();
        }

        private void resultpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new OwnerTrainer(UserID, connectionString).Show();
        }
    }
}
