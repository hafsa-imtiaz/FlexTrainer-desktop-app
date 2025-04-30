using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class TrainerSchedule : Form
    {
        int UserID;
        string connectionString;
        int selected;
        public TrainerSchedule(int UserID, string connectionstring)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.connectionString = connectionstring;
            choosewho.SelectedIndex = 0;

            role.Visible = false;
            status.Visible = false;
            statuslabel.Visible = false;
            descrip.Visible = false;
            name.Visible = false;
            date.Visible = false;
            datelabel.Visible = false;
            status.Visible = false;
            statuslabel.Visible = false;
            memberhistory.Visible = false;
            memberhistory.Enabled = false;
            approve.Visible = false;
            cancel.Visible = false;
            approve.Enabled = false;
            cancel.Enabled = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "';";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    info.DataSource = userdata;

                }
                connection.Close();
            }
        }

        private void viemember_Paint(object sender, PaintEventArgs e)
        {

        }

        private void choosewho_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(choosewho.SelectedIndex == 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                }
            }
            else if(choosewho.SelectedIndex == 1)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "' AND status = 'Pending';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                }
            }
            else if (choosewho.SelectedIndex == 2)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "' AND status = 'Scheduled';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                }
            }
            else if (choosewho.SelectedIndex == 3)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "' AND status = 'Cancelled';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                }
            }
            else if ((choosewho.SelectedIndex == 4))
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "' AND status = 'Attended';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                }
            }
            else if (choosewho.SelectedIndex == 5){
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID, Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "' AND status = 'Not Attended';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                }

            }
        }

        private void info_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < info.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = info.Rows[selected];

                name.Text = (targetRow.Cells["Member_Name"].Value).ToString();
                descrip.Text = (targetRow.Cells["Description"].Value).ToString();

                DateTime dateValue = Convert.ToDateTime(targetRow.Cells["Date"].Value);
                DateTime dateOnly = dateValue.Date;
                string dateString = dateOnly.ToShortDateString();
                date.Text = dateString + ' ' + (targetRow.Cells["Time"].Value).ToString();
                status.Text = (targetRow.Cells["Status"].Value).ToString();
                if(status.Text == "Pending")
                {
                    approve.Enabled = true;
                    approve.Visible = true;
                    cancel.Visible = true;
                    cancel.Enabled = true;
                }
                else if(status.Text == "Scheduled")
                {
                    cancel.Visible = true;
                    cancel.Enabled = true;
                }

                role.Visible = true;
                status.Visible = true;
                statuslabel.Visible = true;
                descrip.Visible = true;
                name.Visible = true;
                date.Visible = true;
                datelabel.Visible = true;
                status.Visible = true;
                statuslabel.Visible = true;
                memberhistory.Visible = true;
                memberhistory.Enabled = true;
            }
            else
            {
                role.Visible = false;
                status.Visible = false;
                statuslabel.Visible = false;
                descrip.Visible = false;
                name.Visible = false;
                date.Visible = false;
                datelabel.Visible = false;
                status.Visible = false;
                statuslabel.Visible = false;
                memberhistory.Visible = false;
                memberhistory.Enabled = false;
                approve.Visible = false;
                cancel.Visible = false;
                approve.Enabled = false;
                cancel.Enabled = false;
                selected = -1;
            }
        }

        private void approve_Click(object sender, EventArgs e)
        {
            if(approve.Enabled && approve.Visible)
            {
                
                if (selected >= 0 && selected < info.Rows.Count)   //selected valid hai??
                {
                    DataGridViewRow targetRow = info.Rows[selected];status.Text = "Scheduled";

                    int sessID = Convert.ToInt32(targetRow.Cells["SessID"].Value);
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string query = "UPDATE Training_Session SET Status = 'Scheduled' WHERE SessID = @SessID";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessID", sessID);
                        cmd.ExecuteNonQuery();
                        connect.Close();
                    }
                }
                using(SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessIDTraining_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                    choosewho.SelectedIndex = 0;
                }
                approve.Visible = false;
                approve.Enabled = false;
                selected = -1;

            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if(cancel.Enabled && cancel.Visible)
            {
                

                if (selected >= 0 && selected < info.Rows.Count)   //selected valid hai??
                {
                    DataGridViewRow targetRow = info.Rows[selected];status.Text = "Cancelled";
                    int sessID = Convert.ToInt32(targetRow.Cells["SessID"].Value);

                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        string query = "UPDATE Training_Session SET Status = 'Cancelled' WHERE SessID = @SessID";
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessID", sessID);
                        cmd.ExecuteNonQuery();
                        connect.Close();
                    }
                }

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT Users.FName + ' ' + Users.LName AS Member_Name, Description, Date, Time, Status, SessID,Training_Session.MemID FROM Training_Session INNER JOIN Users ON Users.UserID = Training_Session.MemID WHERE TrainerID = '" + UserID + "';";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter userTable = new SqlDataAdapter(query, connection);
                        DataTable userdata = new DataTable();
                        userTable.Fill(userdata);
                        info.DataSource = userdata;

                    }
                    connection.Close();
                    choosewho.SelectedIndex = 0;
                }
                cancel.Visible = false;
                cancel.Enabled = false;
                selected = -1;
            }
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new TrainHome(UserID, connectionString).Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new TrainerProfile(UserID, connectionString).Show();    this.Hide();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new TrainWO(UserID, connectionString).Show(); this.Hide();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new TrainGym(UserID, connectionString).Show();
            this.Hide();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            new TrainerFeedback(UserID, connectionString).Show();
            this.Hide();
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
    }
}
