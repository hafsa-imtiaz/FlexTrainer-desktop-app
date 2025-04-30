using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class OwnerFinance : Form
    {
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";

        public OwnerFinance(int UserID, string connection)
        {
            this.UserID = UserID;
            connectionString = connection;
            InitializeComponent();
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new OwnerHome(UserID, connectionString).Show();
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new OwnerGym(UserID, connectionString).Show();
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new OwnerMember(UserID, connectionString).Show();
            this.Hide();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {

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
    }
}
