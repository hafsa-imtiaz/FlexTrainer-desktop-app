using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class JoinGym : Form
    {
        int UserID;
        string connectionString;
        string who;
        int selected;
        public JoinGym(int userid, string conns, string kon)
        {
            InitializeComponent();
            this.UserID = userid;
            this.connectionString = conns;
            this.who = kon;
            selected = -1;
            address.Visible = false;
            ownername.Visible = false;
            gymname.Visible = false;
            gymphoneno.Visible = false;
            label6.Visible = false;


            try
            {
                string query = @"SELECT Gym.GymName, Gym.PhoneNo, Gym.Address, CONCAT(Users.FName, ' ', Users.LName) AS OwnerName, Gym.GymID
                                 FROM Gym
                                 INNER JOIN Users on Users.UserID=Gym.OwnerID";
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

        private void JoinGym_Load(object sender, EventArgs e)
        {

        }

        private void info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selected = (int)e.RowIndex;
                if (selected >= 0 && selected <= info.Rows.Count)
                {
                    DataGridViewRow targetRow = info.Rows[selected];
                    address.Text = targetRow.Cells["Address"].Value.ToString();
                    ownername.Text = targetRow.Cells["OwnerName"].Value.ToString();
                    gymname.Text = targetRow.Cells["GymName"].Value.ToString();
                    gymphoneno.Text = targetRow.Cells["PhoneNo"].Value.ToString();

                    address.Visible = true;
                    ownername.Visible = true;
                    gymname.Visible = true;
                    gymphoneno.Visible = true;
                    label6.Visible = true;
                }
                else
                {
                    address.Visible = false;
                    ownername.Visible = false;
                    gymname.Visible = false;
                    gymphoneno.Visible = false;
                    label6.Visible = false;

                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void viemember_Paint(object sender, PaintEventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (selected >= 0 && selected < info.Rows.Count)
            {
                DataGridViewRow targetRow = info.Rows[selected];
                int gymid = Convert.ToInt32(targetRow.Cells["GymID"].Value);
                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        string q2 = "SELECT Count(*) FROM TRAINER_REQUEST WHERE TrainerID = '" + UserID + "' AND GymID = '" + gymid + "' AND STATUS = 'Pending';";
                        SqlCommand command = new SqlCommand(q2, connection);
                        if ((int)command.ExecuteScalar() > 0)
                        {
                            MessageBox.Show("You already have a pending request to this gym!");
                        }
                        else
                        {
                            string query = "INSERT INTO Trainer_Request (TrainerID, GymID, Status, Date) " +
                                   "VALUES (@TrainerID, @GymID, 'Pending', CURRENT_TIMESTAMP)";
                            command.CommandText = query;
                            command.Parameters.AddWithValue("@TrainerID", UserID);
                            command.Parameters.AddWithValue("@GymID", gymid);
                            try
                            {
                                if ((int)command.ExecuteNonQuery() > 0)
                                {
                                    MessageBox.Show("Request send successfully!", "Success");
                                }
                                else
                                {
                                    MessageBox.Show("Request could not be made!", "Database Failure");
                                }

                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("An error occurred: " + ex.Message);
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            selected = -1;
            address.Visible = false;
            ownername.Visible = false;
            gymname.Visible = false;
            gymphoneno.Visible = false;
            label6.Visible = false;

        }
    }
}
