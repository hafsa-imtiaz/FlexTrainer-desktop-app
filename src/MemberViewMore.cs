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
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Windows.Forms.VisualStyles;


/*
 * agar pending hai tou he can: change details/cancel booking
 * agar scheduled hai tou if he changes the time: it goes to pending
 * agar time was purana tou he can mark it as done
 */


namespace proj
{
    public partial class MemberViewMore : Form
    {
        int UserID;
        int sessID;
        string connectionString;
        public MemberViewMore(int userID, int trainID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            sessID = trainID;
            this.connectionString = connectionString;
            descrip.Text = sessID.ToString();

            string query = "SELECT Description, Date, Time, Status, Duration, DATEDIFF(minute, Date, GETDATE()) AS Difference FROM Training_Session WHERE SessID = @sessID";

            using (SqlConnection rabta = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand(query, rabta);
                cmd.Parameters.AddWithValue("@sessID", sessID);

                rabta.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()){
                    descrip.Text = reader["Description"].ToString();
                    status.Text = reader["Status"].ToString();

                    if(status.Text == "Pending")
                    {
                        greenbutton.Text = "Update Request";
                        greybutton.Text = "Cancel Booking";
                    }
                    else if(status.Text == "Cancelled" || status.Text == "Attended" || status.Text == "Not Attended")
                    {
                        greenbutton.Visible = greenbutton.Enabled = false;
                        greybutton.Enabled = greybutton.Visible = false;
                    }
                    else if (status.Text == "Scheduled")
                    {
                        if (Convert.ToInt32(reader["Difference"]) <= 0)
                        {
                            greenbutton.Text = "Attended";
                            greybutton.Text = "Not Attended";
                        }
                        else
                        {
                            greenbutton.Text = "Reschedule";
                            greybutton.Text = "Cancel Booking";
                        }
                    }
                        
                    DateTime date = Convert.ToDateTime(reader["Date"]);
                    when.Value = date;

                    string struggle = (reader["Duration"]).ToString();
                    duration.SelectedIndex = duration.FindStringExact(struggle);
                    TimeSpan time = (TimeSpan)reader["Time"];

                    mins.SelectedItem = time.Minutes.ToString();

                    ghanta.SelectedItem = (time.Hours % 12 == 0 ? 12 : time.Hours % 12).ToString();
                    waqt.SelectedItem = time.Hours < 12 ? "AM" : "PM";


                }
                else
                {
                    MessageBox.Show("Session not found.");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void descriplabel_Click(object sender, EventArgs e)
        {
            descrip.Focus();
        }

        private void descrip_TextChanged(object sender, EventArgs e)
        {
            if (descrip.Text != "") descriplabel.Visible = false;
            else descriplabel.Visible = true;   
        }

        private void greybutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descrip.Text) || duration.SelectedIndex == -1 || waqt.SelectedIndex == -1 || ghanta.SelectedIndex == -1 || mins.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled!", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (status.Text == "Pending")
                {
                    string query = "UPDATE Training_Session SET Status = 'Canceled' WHERE SessID = @SessionId";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessionId", sessID);
                        connect.Open();
                        if ((int)cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Status updated successfully.");
                            status.Text = "Canceled";
                            greenbutton.Visible = greenbutton.Enabled = false;
                            greybutton.Enabled = greybutton.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.");
                        }
                        connect.Close();
                    }
                }
                else if (greybutton.Text == "Cancel")
                {
                    string query = "UPDATE Training_Session SET Status = 'Canceled' WHERE SessID = @SessionId";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessionId", sessID);
                        connect.Open();
                        if ((int)cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Status updated successfully.");
                            status.Text = "Canceled";
                            greenbutton.Visible = greenbutton.Enabled = false;
                            greybutton.Enabled = greybutton.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.");
                        }
                        connect.Close();
                    }

                }
                else if (greybutton.Text == "Not Attended")
                {
                    string query = "UPDATE Training_Session SET Status = 'Not Attended' WHERE SessID = @SessionId";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessionId", sessID);
                        connect.Open();
                        if ((int)cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Status updated successfully.");
                            status.Text = "Not Attended";
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.");
                        }
                        connect.Close();
                    }
                }
            }
        }

        private void greenbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(descrip.Text) || duration.SelectedIndex == -1 || waqt.SelectedIndex == -1 || ghanta.SelectedIndex == -1 || mins.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled!", "Booking Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (status.Text == "Pending")
                {
                    string query = "UPDATE Training_Session SET Duration = @Duration, Date = @Date, Time = @Time, Description = @Description WHERE SessID = @SessionId";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        DateTime meridate = when.Value;
                        string din = meridate.ToString("yyyy-MM-dd");
                        string merawaqt = ghanta.Text + ":" + mins.Text + " " + this.waqt.Text;
                        TimeSpan timeSpan = DateTime.Parse(merawaqt).TimeOfDay;
                        string waqt = timeSpan.ToString(@"hh\:mm\:ss");

                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessionId", sessID);
                        cmd.Parameters.AddWithValue("@Duration", duration.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Date", din);
                        cmd.Parameters.AddWithValue("@Time", waqt);
                        cmd.Parameters.AddWithValue("@Description", descrip.Text);

                        if ((int)cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Details updated successfully.");
                            status.Text = "Pending";
                        }
                        else
                        {
                            MessageBox.Show("Failed to update details.");
                        }
                        connect.Close();
                    }
                }
                else if (status.Text == "Reschedule")
                {
                    string query = "UPDATE Training_Session SET Duration = @Duration, Date = @Date, Time = @Time, Description = @Description, status = 'Pending' WHERE SessID = @SessionId";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        DateTime meridate = when.Value;
                        string din = meridate.ToString("yyyy-MM-dd");
                        string merawaqt = ghanta.Text + ":" + mins.Text + " " + this.waqt.Text;
                        TimeSpan timeSpan = DateTime.Parse(merawaqt).TimeOfDay;
                        string waqt = timeSpan.ToString(@"hh\:mm\:ss");

                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessionId", sessID);
                        cmd.Parameters.AddWithValue("@Duration", duration.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@Date", din);
                        cmd.Parameters.AddWithValue("@Time", waqt);
                        cmd.Parameters.AddWithValue("@Description", descrip.Text);
                        if ((int)cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Session Rescheduled successfully.");
                            status.Text = "Pending";
                        }
                        else
                        {
                            MessageBox.Show("Failed to reschedule your session.");
                        }
                        connect.Close();
                    }
                }
                else if (status.Text == "Attended")
                {
                    string query = "UPDATE Training_Session SET Status = 'Attended' WHERE SessID = @SessionId";
                    using (SqlConnection connect = new SqlConnection(connectionString))
                    {
                        connect.Open();
                        SqlCommand cmd = new SqlCommand(query, connect);
                        cmd.Parameters.AddWithValue("@SessionId", sessID);
                        if ((int)cmd.ExecuteNonQuery() > 0)
                        {
                            MessageBox.Show("Status updated successfully.");
                            status.Text = "Attended";
                            greenbutton.Visible = greenbutton.Enabled = false;
                            greybutton.Enabled = greybutton.Visible = false;
                        }
                        else
                        {
                            MessageBox.Show("Failed to update status.");
                        }
                        connect.Close();
                    }
                }
            }
        }

        private void duration_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
