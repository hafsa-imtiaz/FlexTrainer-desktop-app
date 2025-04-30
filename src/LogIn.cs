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
    public partial class LogIn : Form
    {
        string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog = FlexTrainer; Integrated Security = True; Encrypt=False";
        public LogIn()
        {
            InitializeComponent();
        }

        private const int CS_DROPshadow = 0x00030000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams plsParam = base.CreateParams;
                plsParam.ExStyle |= 0x02000000;  //preveny flickering
                plsParam.ClassStyle = CS_DROPshadow; //create form drop shadow
                return plsParam;
            }
        }
        private void LogInPanel_Paint(object sender, PaintEventArgs e)
        {
            FullPanel.BackColor = Color.FromArgb(150, 62, 134, 147);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LogInPanel.BackColor = Color.FromArgb(250, 68, 138, 123);
        }
        private void EmailBox_TextChanged(object sender, EventArgs e)
        {
            if (EmailBox.Text == "")
                EmailLabel.Visible = true;
            else
                EmailLabel.Visible = false;
        }
        private void SignUpLInk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
        private void LogInButton_Click(object sender, EventArgs e) //when user logs in
        {
            // Checks if email or password fields are empty
            if (string.IsNullOrWhiteSpace(EmailBox.Text) || string.IsNullOrWhiteSpace(PasswordBox.Text))
            {
                MessageBox.Show("Email and Password fields must not be empty!", "Log-In Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordBox.Text == "")
            {
                MessageBox.Show("Password cannot be empty!");
                PasswordBox.Clear();
                PasswordBox.Focus();
            }
            else if (string.IsNullOrEmpty(EmailBox.Text))
            {
                MessageBox.Show("Email cannot be empty!");
                PasswordBox.Clear();
                EmailBox.Clear();
                EmailBox.Focus();
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open(); //MessageBox.Show("Connection Show");
                

                string email = EmailBox.Text;
                string pass = PasswordBox.Text;
                string query = "SELECT Users.UserID FROM Users WHERE Users.Email = '" + email + "' AND Users.UPassword = '" + pass + "';";

                SqlCommand cmd = new SqlCommand(query, connect);// Query to check if the user exists with the given email and password
                
                object count = cmd.ExecuteScalar();
                cmd.Dispose();
                if (count != null)
                {
                    int UserID = (int)count;
                    //label1.Text = UserID.ToString();
                    MessageBox.Show("Log In Successful");
                    query = "SELECT URole FROM Users WHERE UserID = '" + UserID + "'";
                    SqlCommand mainkon = new SqlCommand(query, connect);
                    string role = (string)mainkon.ExecuteScalar();
                    mainkon.Dispose();
                    connect.Close();
                    if (role == "Member")
                    {
                        new MemberHome(UserID, connectionString).Show();
                        this.Hide();
                    }
                    else if (role == "Trainer")
                    {
                        new TrainHome(UserID, connectionString).Show(); this.Hide();
                    }
                    else if (role == "Gym Owner")
                    {
                        new OwnerHome(UserID, connectionString).Show();
                        this.Hide();
                    }
                    else if (role == "Admin")
                    {
                        new AdminHome(UserID, connectionString).Show();
                        this.Hide();
                    }
                }
                else
                {
                    MessageBox.Show("Log In Failed");
                    EmailBox.Clear();
                    PasswordBox.Clear();
                }
                connect.Close();
                //this.Close();
            }
        }
        private void PasswordBox_TextChanged(object sender, EventArgs e)
        {
            if(PasswordBox.Text == "")
                PasswordLabel.Visible = true;
            else 
                PasswordLabel.Visible = false;
        }
        private void PasswordLabel_Click(object sender, EventArgs e)
        {
            PasswordBox.Focus();//no farq
        }
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            EmailBox.Focus();//no farq
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }

        private void RememberCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (RememberCheck.Checked)
            {
                PasswordBox.PasswordChar = '\0';
            }
            else
            {
                PasswordBox.PasswordChar = '*';
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
