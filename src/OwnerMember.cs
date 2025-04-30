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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace proj
{
    public partial class OwnerMember : Form
    {
        private int selected;
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        public OwnerMember(int userID, string connection)
        {
            InitializeComponent();
            UserID = userID;
            connectionString = connection;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Fname + ' ' + Lname AS Name, Email, users.PhoneNo AS PhoneNo, gym.GymName, Member.MembershipType AS Membership, DATEDIFF(Month, GETDATE(), Member.Start_Date) AS Duration, Member.Account_Status FROM Users INNER JOIN MEMBER ON member.MemID = users.UserID INNER JOIN Gym ON Gym.GymID = Member.GymID WHERE Gym.OwnerID = '" + UserID + "';";
            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
            DataTable userdata = new DataTable();
            userTable.Fill(userdata);
            meminfo.DataSource = userdata;
            connect.Close();
        }
        private void requestgrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dashbutton_Click(object sender, EventArgs e)
        {
            new OwnerHome(UserID, connectionString).Show();
            this.Hide();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            new OwnerProfile(UserID, connectionString).Show();
            this.Hide();
        }
        private void gymButton_Click(object sender, EventArgs e)
        {
            new OwnerGym(UserID, connectionString).Show();
            this.Hide();
        }
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void meminfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < meminfo.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = meminfo.Rows[selected];

                int nameColumnIndex = 0; 
                int gymNameColumnIndex = 3;
                int memtypeindex = 4;
                int durationColumnIndex = 5;

                memname.Text = targetRow.Cells[nameColumnIndex].Value?.ToString(); 
                gymname.Text = targetRow.Cells[gymNameColumnIndex].Value?.ToString();
                memship.Text = targetRow.Cells[memtypeindex].Value?.ToString();
                durationbox.Text = targetRow.Cells[durationColumnIndex].Value?.ToString(); 
            }
            else
            {
                memname.Text = "";
                gymname.Text = "";
                memship.Text = "";
                durationbox.Text = "";
            }
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(memname.Text) || string.IsNullOrWhiteSpace(gymname.Text) || string.IsNullOrWhiteSpace(memship.Text))
            {
                MessageBox.Show("No member chosen!", "Deactivate Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (selected >= 0 && selected < meminfo.Rows.Count)   //selected valid hai??
                {
                    DataGridViewRow targetRow = meminfo.Rows[selected]; //get email for identification
                    int emailindex = 1;
                    string email = targetRow.Cells[emailindex].Value?.ToString(); memname.Text = email;

                    SqlConnection connect = new SqlConnection(connectionString);
                    connect.Open();
                    string query = "EXEC DeactivateMember @Email = '" + email + "';";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Member account has been deactivated. All of their upcoming sessions have been cancelled. \n\nNote: The account will be reactivated once they log in!");
                    selected = -1;
                }
            }
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(memname.Text) || string.IsNullOrWhiteSpace(gymname.Text) || string.IsNullOrWhiteSpace(memship.Text))
            {
                MessageBox.Show("No member chosen! Choose a member to remove them from the gym.", "Remove Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (selected >= 0 && selected < meminfo.Rows.Count)   //selected valid hai??
                {
                    DataGridViewRow targetRow = meminfo.Rows[selected]; //get email for identification
                    int emailindex = 1;
                    string email = targetRow.Cells[emailindex].Value?.ToString(); 

                    SqlConnection connect = new SqlConnection(connectionString);
                    connect.Open();
                    string query = "EXEC RemoveMemberFromGym @Email = '" + email + "';";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The member has been removed successfully from the gym! They can, however, rejoin in the future!", "Member Removed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    query = "SELECT Fname + ' ' + Lname AS Name, Email, users.PhoneNo AS PhoneNo, gym.GymName, Member.MembershipType AS Membership, DATEDIFF(Month, GETDATE(), Member.Start_Date) AS Duration, Member.Account_Status FROM Users INNER JOIN MEMBER ON member.MemID = users.UserID INNER JOIN Gym ON Gym.GymID = Member.GymID WHERE Gym.OwnerID = '" + UserID + "';";
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    meminfo.DataSource = userdata;
                    connect.Close();
                    memname.Text = "";
                    gymname.Text = "";
                    memship.Text = "";
                    durationbox.Text = "";
                    selected = -1;
                }
            }
        }

        private void bgpanel_Click(object sender, EventArgs e)
        {
            memname.Text = "";
            gymname.Text = "";
            memship.Text = "";
            durationbox.Text = "";
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new OwnerTrainer(UserID, connectionString).Show();
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new OwnerMember(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
