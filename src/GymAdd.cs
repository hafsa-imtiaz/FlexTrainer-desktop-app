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

namespace proj
{
    public partial class GymAdd : Form
    {
        int UserID;
        string connectionString;
        public GymAdd(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
        private void savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(gymname.Text) || string.IsNullOrWhiteSpace(gymaddress.Text) || string.IsNullOrWhiteSpace(phonenumber.Text) || string.IsNullOrWhiteSpace(callcode.Text))
            {
                MessageBox.Show("All fields must be filled!", "Failure to Add Gym", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else {
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();

                string query = "SELECT count(*) FROM Gym WHERE GymName = '" + gymname.Text + "' OR Address = '" + gymaddress.Text + "' OR PhoneNo = '" + phonenumber.Text + "';";
                SqlCommand cmd = new SqlCommand(query, connect);

                if((int)cmd.ExecuteScalar() > 0)
                {
                    MessageBox.Show("Your gym must have unique information!", "Gym-Add Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    cmd.Dispose();
                    connect.Close();
                }
                else
                {
                    query = "INSERT INTO Gym_Requests VALUES(" + UserID + ", '" + gymaddress.Text + "', '" + gymname.Text + "', '" + callcode.Text + phonenumber.Text + "', CURRENT_TIMESTAMP, 'Pending');";
                    cmd.CommandText = query;
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    connect.Close();
                    new GymAddPage2().Show();
                    this.Hide();
                }
            }
        }

        private void GymAdd_Load(object sender, EventArgs e)
        {

        }

        private void gym_Click(object sender, EventArgs e)
        {
            gymname.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            gymaddress.Focus();
        }

        private void numlabel_Click(object sender, EventArgs e)
        {
            phonenumber.Focus();
        }

        private void ziplabel_Click(object sender, EventArgs e)
        {
            zipcode.Focus();
        }

        private void gymname_TextChanged(object sender, EventArgs e)
        {
            if(gymname.Text != "") gym.Visible = false;
            else gym.Visible = true;
        }

        private void gymaddress_TextChanged(object sender, EventArgs e)
        {
            if(gymaddress.Text!="") label1.Visible = false;
            else label1.Visible = true;
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if(phonenumber.Text !="") numlabel.Visible = false;
            else numlabel.Visible = true;
        }

        private void zipcode_TextChanged(object sender, EventArgs e)
        {
            if(zipcode.Text != "") ziplabel.Visible = false;
            else zipcode.Visible = true;
        }
    }
}
