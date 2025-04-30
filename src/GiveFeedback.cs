using System;
using System.Collections;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace proj
{
    public partial class GiveFeedback : Form
    {
        string connectionString;
        int UserID;
        int selected;
        public GiveFeedback(int UserID, string connec)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.connectionString = connec;
            selected = -1;

            try
            {
                using(SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string  query = "SELECT Gym_Employment.TrainerID, Users.FName + ' ' + Users.LName AS Name, Trainer.Years " +
                    "FROM Gym_Employment " +
                    "INNER JOIN member ON member.gymID = gym_employment.GymID " +
                    "INNER JOIN Users On Users.UserID = Gym_Employment.TrainerID " +
                    "INNER JOIN Trainer ON Trainer.TrainerID = Gym_Employment.TrainerID WHERE member.MemID = '" + UserID + "'";

                    SqlDataAdapter userTable = new SqlDataAdapter(query, conn);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    infotable.DataSource = userdata;
                    conn.Close();
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void descriplabel_Click(object sender, EventArgs e)
        {

        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {

        }

        private void cancel_Click(object sender, EventArgs e)
        {
            comment.Text = string.Empty;
            rating.SelectedIndex = -1;
            name.Text = string.Empty;
            name.Visible = false;
            selected = -1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(name.Text == string.Empty || string.IsNullOrEmpty(comment.Text) || rating.SelectedIndex == -1 || name.Text == "") {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                if (selected >= 0 && selected < infotable.Rows.Count)
                {
                    DataGridViewRow targetRow = infotable.Rows[selected];

                    int trainID = Convert.ToInt32(targetRow.Cells["TrainerID"].Value);

                    try
                    {
                        string query = "INSERT INTO Trainer_Feedback (MemID, TrainerID, Rating, Date, Comment) " +
                               "VALUES (@MemID, @TrainerID, @Rating, CURRENT_DATETIME, @Comment)";

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            SqlCommand command = new SqlCommand(query, connection);
                            command.Parameters.AddWithValue("@MemID", UserID);
                            command.Parameters.AddWithValue("@TrainerID", trainID);
                            command.Parameters.AddWithValue("@Rating", rating.SelectedIndex.ToString());
                            command.Parameters.AddWithValue("@Comment", comment.Text);

                            try
                            {
                                connection.Open();
                                if ((int)command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Feedback submitted!");
                                    comment.Text = string.Empty;
                                    rating.SelectedIndex = -1;
                                    name.Text = string.Empty;
                                    name.Visible = false;
                                    selected = -1;
                                }
                                else
                                {
                                    MessageBox.Show("Error submitting feedback!");
                                    comment.Text = string.Empty;
                                    rating.SelectedIndex = -1;
                                    name.Text = string.Empty;
                                    name.Visible = false;
                                    selected = -1;
                                }
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine("An error occurred: " + ex.Message);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < infotable.Rows.Count)
            {
                DataGridViewRow targetRow = infotable.Rows[selected];
                name.Visible = true;
                name.Text = (targetRow.Cells["Name"].Value).ToString();
            }
            else
            {
                name.Visible = false;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
