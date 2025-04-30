using System;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proj
{
    public partial class AdminHome : Form
    {
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        public AdminHome(int UserID, string connection)
        {
            InitializeComponent();
            connectionString = connection;
            this.UserID = UserID;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Users.FName + ' ' + Users.LName FROM Users WHERE Users.UserID = '" + UserID + "';";

            SqlCommand cmd = new SqlCommand(query, connect);
            object count = cmd.ExecuteScalar();
            AdminName.Text = count.ToString() + "!";

            cmd.CommandText = "SELECT Count(*) FROM Users WHERE Users.URole = 'Member';";
            count = cmd.ExecuteScalar();
            memcount.Text = count.ToString();

            cmd.CommandText = "SELECT Count(*) FROM Users WHERE Users.URole = 'Trainer';";
            count = cmd.ExecuteScalar();
            traincount.Text = count.ToString();

            cmd.CommandText = "SELECT Count(*) FROM Users WHERE Users.URole = 'Gym Owner';";
            count = cmd.ExecuteScalar();
            owncount.Text = count.ToString();

            cmd.CommandText = "SELECT Count(*) FROM Gym;";
            count = cmd.ExecuteScalar();
            gymcount.Text = count.ToString();

            cmd.Dispose();
            connect.Close();
        }

        private const int CS_DROPshadow = 0x00030000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams plsParam = base.CreateParams;
                plsParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED
                plsParam.ClassStyle = CS_DROPshadow;
                return plsParam;
            }
        }
        private void dashbutton_Click(object sender, EventArgs e)
        {
            //do nothing  - stay here
        }

        private void dashbutton_MouseHover(object sender, EventArgs e)
        {
            dashbutton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            dashbutton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }

        private void gymButton_MouseHover(object sender, EventArgs e)
        {
            gymButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void gymButton_MouseLeave(object sender, EventArgs e)
        {
            gymButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }

        private void userButton_MouseHover(object sender, EventArgs e)
        {
            userButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            userButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void addButton_MouseHover(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            addButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void logButton_MouseHover(object sender, EventArgs e)
        {
            logButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void logButton_MouseLeave(object sender, EventArgs e)
        {
            logButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void outButton_MouseHover(object sender, EventArgs e)
        {
            outButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }

        private void outButton_MouseLeave(object sender, EventArgs e)
        {
            outButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void profileButton_MouseHover(object sender, EventArgs e)
        {
            profileButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }

        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            profileButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void settingButton_MouseHover(object sender, EventArgs e)
        {
            settingButton.ForeColor = Color.FromArgb(230, 1, 97, 100);
        }
        private void settingButton_MouseLeave(object sender, EventArgs e)
        {
            settingButton.ForeColor = Color.FromArgb(230, 240, 240, 240);
        }
        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = Color.FromArgb(130, 79, 93, 107);
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {}

        private void pictureBox5_Click(object sender, EventArgs e)
        {}

        private void pictureBox4_Click(object sender, EventArgs e)
        {}
        private void logButton_Click(object sender, EventArgs e )
        {}
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            //do nothing for now - stay here
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            OwnPanel.BackColor = Color.FromArgb(230, 100, 148, 134);
        }
        private void panel3_MouseLeave(object sender, EventArgs e)
        {
            OwnPanel.BackColor = Color.FromArgb(230, 48, 66, 84);
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            infopanel.BackColor = Color.FromArgb(100, 48, 66, 84);
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            new AdminProfile(UserID, connectionString).Show(); this.Hide();
        }

        private void infotable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void viewdropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(choosewho.SelectedIndex == -1)
            {
                infotable.DataSource = null;
            }
            else if(choosewho.SelectedIndex == 0)
            {
                infotable.DataSource = null;
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlDataAdapter userTable = new SqlDataAdapter("SELECT FName + ' ' + LName AS Name, URole, Email, JoinDate, Gender FROM Users;", connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                //infotable.AutoGenerateColumns = false;
                infotable.DataSource = userdata;
                connect.Close();
            }
            else if(choosewho.SelectedIndex == 1)
            {
                infotable.DataSource = null;
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlDataAdapter userTable = new SqlDataAdapter("SELECT FName + ' ' + LName AS Name, Email, JoinDate, Gender FROM Users WHERE URole = 'Member';", connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                //infotable.AutoGenerateColumns = false;
                infotable.DataSource = userdata;
                connect.Close();
            }
            else if (choosewho.SelectedIndex == 2)
            {
                infotable.DataSource = null;
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlDataAdapter userTable = new SqlDataAdapter("SELECT FName + ' ' + LName AS Name, Email, JoinDate, Gender FROM Users WHERE URole = 'Trainer';", connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                //infotable.AutoGenerateColumns = false;
                infotable.DataSource = userdata;
                connect.Close();
            }
            else if (choosewho.SelectedIndex == 3)
            {
                infotable.DataSource = null;
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlDataAdapter userTable = new SqlDataAdapter("SELECT FName + ' ' + LName AS Name, Email, JoinDate, Gender, GymOwner.License FROM Users INNER JOIN GymOwner ON GymOwner.OwnerID=UserID WHERE URole = 'Gym Owner';", connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                //infotable.AutoGenerateColumns = false;
                infotable.DataSource = userdata;
                connect.Close();
            }
            else if (choosewho.SelectedIndex == 4) //gym show
            {
                infotable.DataSource = null;
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlDataAdapter userTable = new SqlDataAdapter("SELECT Gym.GymName, gym.PhoneNo, gym.Address, users.FName  +' ' + users.LName AS Name from gym inner join gymowner on GymOwner.OwnerID = Gym.OwnerID inner join Users on gymowner.OwnerID = users.UserID;", connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                //infotable.AutoGenerateColumns = false;
                infotable.DataSource = userdata;
                connect.Close();
            }
            else if (choosewho.SelectedIndex == 5)
            {
                infotable.DataSource = null;
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                SqlDataAdapter userTable = new SqlDataAdapter("SELECT FName + ' ' + LName AS Name, Email, JoinDate, Gender FROM Users WHERE URole = 'Admin';", connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                //infotable.AutoGenerateColumns = false;
                infotable.DataSource = userdata;
                connect.Close();
            }
        }

        private void GymPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new AdminGym(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
