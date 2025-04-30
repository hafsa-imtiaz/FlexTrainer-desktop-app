using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proj
{
    public partial class OwnerGym : Form
    {
        private int selected;
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        public OwnerGym(int userID, string connection)
        {
            InitializeComponent();
            UserID = userID;
            connectionString = connection;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT GymName, PhoneNo, Address, dbo.TotalMembers('" + UserID + "', GymID) AS 'Members', dbo.TotalTrainers('" + UserID + "', GymID) AS 'Trainers' FROM Gym WHERE OwnerID = '" + UserID + "';";
            SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
            DataTable userdata = new DataTable();
            userTable.Fill(userdata);
            gyminfo.DataSource = userdata;
            connect.Close();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new OwnerProfile(UserID, connectionString).Show();
            this.Hide();
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new OwnerHome(UserID, connectionString).Show();
            this.Hide();
        }

        private void gyminfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            selected = e.RowIndex;
            if (selected >= 0 && selected < gyminfo.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = gyminfo.Rows[selected];
                namebox.Text = targetRow.Cells[0].Value?.ToString(); 
                addressbox.Text = targetRow.Cells[2].Value?.ToString(); 
                nobox.Text = targetRow.Cells[1].Value?.ToString(); 
            }
            else
            {
                namebox.Text = "";
                addressbox.Text = "";
                nobox.Text = "";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new GymAdd(UserID, connectionString).Show(); //this.Hide(); //open add gym form
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new OwnerGym(UserID, connectionString).Show();
            this.Hide();//you are here
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new OwnerMember(UserID, connectionString).Show();
            this.Hide();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            new OwnerFinance(UserID, connectionString).Show();
            this.Hide();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namebox.Text) || string.IsNullOrWhiteSpace(addressbox.Text) || string.IsNullOrWhiteSpace(nobox.Text))
            {
                MessageBox.Show("No gym chosen! Choose a gym to update.", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selected >= 0 && selected < gyminfo.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = gyminfo.Rows[selected]; //get email for identification

                string name = targetRow.Cells[0].Value?.ToString();
                string gymjagah = targetRow.Cells[2].Value?.ToString();
                string duration = targetRow.Cells[1].Value?.ToString();

                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();

                string query = "SELECT GymID FROM Gym WHERE GymName = '" + name + "' AND Address = '" + gymjagah + "' AND PhoneNo = '" + duration + "';";
                SqlCommand cmd = new SqlCommand(query, connect);
                
                int id = (int)cmd.ExecuteScalar();

                query = "SELECT count(*) FROM Gym WHERE (GymName = '" + name + "' OR Address = '" + gymjagah + "' OR PhoneNo = '" + duration + "') AND GymID != '" + id + "';";
                cmd.CommandText = query;
                int count = (int)cmd.ExecuteScalar();
                if (count > 0)
                {
                    MessageBox.Show("Your gym must have unique information!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else { 
                    query = "EXEC GymOwnerUpdateGym @gymID = '" + id + "', @GymName = '" + namebox.Text + "', @PhoneNo = '" + nobox.Text + "', @Address = '" + addressbox.Text + "';";

                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Gym data has been updated successfully!", "Update Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    query = "SELECT GymName, PhoneNo, Address, dbo.TotalMembers('" + UserID + "', GymID) AS 'Members', dbo.TotalTrainers('" + UserID + "', GymID) AS 'Trainers' FROM Gym WHERE OwnerID = '" + UserID + "';";
                    SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                    DataTable userdata = new DataTable();
                    userTable.Fill(userdata);
                    gyminfo.DataSource = userdata;
                    connect.Close();
                    namebox.Text = "";
                    nobox.Text = "";
                    addressbox.Text = "";
                }
                cmd.Dispose();
                connect.Close();
            }
        }

        private void bgpanel_Click(object sender, EventArgs e)
        {
            namebox.Text = "";
            nobox.Text = "";
            addressbox.Text = "";
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(namebox.Text) || string.IsNullOrWhiteSpace(addressbox.Text) || string.IsNullOrWhiteSpace(nobox.Text))
            {
                MessageBox.Show("No gym chosen!", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selected >= 0 && selected < gyminfo.Rows.Count)   //selected valid hai??
            {
                DataGridViewRow targetRow = gyminfo.Rows[selected]; //get email for identification

                string name = targetRow.Cells[0].Value?.ToString();
                string gymjagah = targetRow.Cells[2].Value?.ToString();
                string duration = targetRow.Cells[1].Value?.ToString();

                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();

                string query = "SELECT GymID FROM Gym WHERE GymName = '" + name + "' AND Address = '" + gymjagah + "' AND PhoneNo = '" + duration + "';";
                SqlCommand cmd = new SqlCommand(query, connect);

                int id = (int)cmd.ExecuteScalar();
                query = "EXEC GymOwnerDeleteGym @gymID = '" + id + "';";

                cmd.CommandText = query;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Gym data has been removed from the database permanently!", "Deleted Successful!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                query = "SELECT GymName, PhoneNo, Address, dbo.TotalMembers('" + UserID + "', GymID) AS 'Members', dbo.TotalTrainers('" + UserID + "', GymID) AS 'Trainers' FROM Gym WHERE OwnerID = '" + UserID + "';";
                SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                gyminfo.DataSource = userdata;
                connect.Close();
                namebox.Text = "";
                nobox.Text = "";
                addressbox.Text = "";
            }
        }

        private void bgpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new OwnerTrainer(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
