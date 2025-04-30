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
    public partial class AdminGym : Form
    {
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        int exselect;
        int rselect;

        public AdminGym(int UserID, string connectionString)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.connectionString = connectionString;
            exselect = -1;
            rselect = -1;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "select * from gym";
                    using (SqlDataAdapter userTable = new SqlDataAdapter(query, conn))
                    {
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;
                    }

                    query = "select * from gym_Requests where status = 'Pending' ;";
                    using (SqlDataAdapter userTable2 = new SqlDataAdapter(query, conn))
                    {
                        DataTable userdata2 = new DataTable();
                        userTable2.Fill(userdata2);
                        infotable.DataSource = userdata2;
                    }
                    conn.Close();
                }

            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new AdminHome(UserID, connectionString).Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new AdminProfile(UserID, connectionString).Show(); this.Hide();
        }

        private void info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            exselect = e.RowIndex;
            if (exselect >= 0 && info.Rows.Count > 0)
            {
                DataGridViewRow targetRow = info.Rows[exselect];

                memname.Text = targetRow.Cells["GymName"].Value?.ToString();
            }
            else
            {
                memname.Text = string.Empty;
            }
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rselect = e.RowIndex;
            if (rselect >= 0 && infotable.Rows.Count > 0)
            {
                DataGridViewRow targetRow = infotable.Rows[rselect];

                textBox2.Text = targetRow.Cells["GymName"].Value?.ToString();

            }
            else textBox2.Text = "";
        }

        private void remove_Click(object sender, EventArgs e)
        {
            if (exselect >= 0 && info.Rows.Count > 0)
            {
                DataGridViewRow targetRow = info.Rows[exselect];

                int gymid = Convert.ToInt32(targetRow.Cells["GymID"].Value);

                string query = "DELETE FROM Gym " +
                           "WHERE GymID = '" + gymid + "';";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    try
                    {
                        connection.Open();
                        if ((int)command.ExecuteNonQuery() > 0)
                        {
                             MessageBox.Show("Gym Removed.");
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (rselect >= 0 && infotable.Rows.Count > 0)
            {
                DataGridViewRow targetRow = infotable.Rows[rselect];

                int trainid = Convert.ToInt32(targetRow.Cells["RequestID"].Value);
                string query = "UPDATE Gym_Requests " +
                           "SET Status = 'Rejected' " +
                           "WHERE RequestID = '" + trainid + "';";

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

        private void button1_Click(object sender, EventArgs e)
        {
            if (rselect >= 0 && infotable.Rows.Count > 0)
            {
                DataGridViewRow targetRow = infotable.Rows[rselect];

                int trainid = Convert.ToInt32(targetRow.Cells["OwnerID"].Value);
                string gymid = (targetRow.Cells["GymName"].Value).ToString() ;
                string phoneno = (targetRow.Cells["PhoneNo"].Value).ToString();
                string address = (targetRow.Cells["Address"].Value).ToString();


                string query = "INSERT INTO Gym (GymName, PhoneNo, Address, OwnerID) " +
                           "VALUES (@GymName, @PhoneNo, @Address, @OwnerID)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@GymName", gymid);
                    command.Parameters.AddWithValue("@PhoneNo", phoneno);
                    command.Parameters.AddWithValue("@Address", address);
                    command.Parameters.AddWithValue("@OwnerID", trainid);

                    try
                    {
                        connection.Open();
                        if ((int)command.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Gym Added.");
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
            else textBox2.Text = "";
        }
    }
}
