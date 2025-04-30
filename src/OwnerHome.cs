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
    public partial class OwnerHome : Form
    {
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        public OwnerHome(int userID, string connection)
        {
            InitializeComponent();
            UserID = userID;
            connectionString = connection;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            string query = "SELECT Users.FName + ' ' + Users.LName FROM Users WHERE Users.UserID = '" + UserID + "';";

            SqlCommand cmd = new SqlCommand(query, connect);
            object count = cmd.ExecuteScalar();
            gymownername.Text = count.ToString();
            ownername.Text = gymownername.Text + "!";

            cmd.CommandText = "SELECT Count(*) FROM Gym WHERE OwnerID = '" + UserID + "';";
            count = cmd.ExecuteScalar();
            gymcount.Text = count.ToString();

            cmd.CommandText = "SELECT License FROM GymOwner WHERE OwnerID = '" + UserID + "';";
            count = cmd.ExecuteScalar();
            description.Text = "Licensed by: " + count.ToString();

            cmd.CommandText = "select count(*) from member inner join gym on gym.GymID = member.GymID inner join GymOwner on GymOwner.OwnerID = gym.OwnerID where GymOwner.OwnerID = '" + UserID + "';";
            count = cmd.ExecuteScalar();
            memcount.Text = count.ToString();

            cmd.CommandText = "select count(Gym_Employment.TrainerID) from gym_employment inner join gym on gym.gymID = gym_employment.gymid where gym.OwnerID = '" + UserID + "';";
            count = cmd.ExecuteScalar();
            traincount.Text = count.ToString();

            cmd.CommandText = "select avg(gym_review.rating) from gym_review inner join gym on gym.gymID = gym_review.gymid where gym.OwnerID  = '" + UserID + "';";
            count = cmd.ExecuteScalar();
            gymrates.Text = count.ToString();

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
            new OwnerHome(UserID, connectionString).Show(); this.Hide();//do nothing  - stay here
        }
        private void gymButton_Click(object sender, EventArgs e)
        {
            new OwnerGym(UserID, connectionString).Show(); this.Hide();
        }
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void SideBar_Paint(object sender, PaintEventArgs e)
        {
            SideBar.BackColor = Color.FromArgb(240, 131, 72, 108);//194, 29, 67);
        }
        private void bgpanel_Paint(object sender, PaintEventArgs e)
        {
            bgpanel.BackColor = Color.FromArgb(50, 135, 151, 168);
        }
        private void toppanel_Paint(object sender, PaintEventArgs e)
        {
            toppanel.BackColor = Color.FromArgb(50, 131, 72, 108);
        }
        private void outButton_Click_1(object sender, EventArgs e)
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
        private void trainButton_Click(object sender, EventArgs e)
        {
            new OwnerTrainer(UserID, connectionString).Show();
            this.Hide();
        }
        private void financeButton_Click(object sender, EventArgs e)
        {
            new OwnerFinance(UserID, connectionString).Show();
            this.Hide();
        }
        private void settingButton_Click(object sender, EventArgs e)
        {

        }
        private void dashbutton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dashbutton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dashbutton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void gymButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            gymButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void gymButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            gymButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void memButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            memButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void memButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            memButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void trainButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            trainButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void trainButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            trainButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void outButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            outButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void outButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            outButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void profileButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            profileButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void financeButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            financeButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void financeButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            financeButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            profileButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }
        private void settingButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            settingButton.BackColor = Color.FromArgb(230, 110, 69, 110);

        }
        private void settingButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            settingButton.BackColor = Color.FromArgb(170, 32, 19, 32);

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gynownername_Click(object sender, EventArgs e)
        {

        }

        private void bgpanel_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
