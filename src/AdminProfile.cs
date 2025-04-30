using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace proj
{
    public partial class AdminProfile : Form
    {
        public int UserID;
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        public AdminProfile(int userID, string connection)
        {
            InitializeComponent();
            UserID = userID;
            connectionString = connection;
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            string query = "SELECT Users.FName, Users.LName, Users.Email, Users.UPassword, Users.UAddress, Users.PhoneNo, Users.DoB, Users.Gender FROM Users WHERE Users.UserID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string fn = reader["FName"].ToString();
                    string ln = reader["LName"].ToString();
                    string email = reader["Email"].ToString();
                    string password = reader["UPassword"].ToString();
                    string address = reader["UAddress"].ToString();
                    string phoneNumber = reader["PhoneNo"].ToString();
                    DateTime dateOfBirth = Convert.ToDateTime(reader["DoB"]);
                    string gen = reader["Gender"].ToString();

                    // Now you can use these values as needed
                    adminname.Text = fn + " " + ln;
                    adminemail.Text = email;
                    emailbox.Text = email;
                    Fname.Text = fn;
                    Lname.Text = ln;
                    passwordbox.Text = password;
                    addressbox.Text = address;
                    phonenumberbox.Text = phoneNumber;
                    datebox.Text = dateOfBirth.Day.ToString();
                    monthbox.Text = dateOfBirth.Month.ToString();
                    Yearbox.Text = dateOfBirth.Year.ToString();
                    if (gen == "Female")
                    {
                        femalebox.Checked = true;
                    }
                    else
                    {
                        malebox.Checked = true;
                    }
                }
                else
                {
                    // Handle the case when no user is found with the provided UserID
                }
            }

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
        private void Lname_TextChanged(object sender, EventArgs e)
        {
            if (Lname.Text != "") { LNameLabel.Visible = false; }
            else { LNameLabel.Visible = true; }
        }
        private void Year_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void month_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }

        private void profileButton_Click(object sender, EventArgs e)
        {
            //do nothing you are here
        }

        private void Lname_TextChanged_1(object sender, EventArgs e)
        {
            if (LNameLabel.Text != "") { LNameLabel.Visible = false; }
            else { LNameLabel.Visible = true; }
        }
        private void Fname_TextChanged(object sender, EventArgs e)
        {
            if (Fname.Text != "") { FNameLabel.Visible = false; }
            else { FNameLabel.Visible = true; }
        }
        private void FNameLabel_Click(object sender, EventArgs e)
        {
            Fname.Focus();
        }
        private void LNameLabel_Click(object sender, EventArgs e)
        {
            Lname.Focus();
        }
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            adminemail.Focus();
        }
        private void PassLabel_Click(object sender, EventArgs e)
        {
            passwordbox.Focus();
        }
        private void addresslabel_Click(object sender, EventArgs e)
        {
            addressbox.Focus();
        }
        private void numlabel_Click(object sender, EventArgs e)
        {
            phonenumberbox.Focus();
        }
        private void address_TextChanged(object sender, EventArgs e)
        {
            if (addressbox.Text != "") { addresslabel.Visible = false; }
            else { addresslabel.Visible = true; }
        }
        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if (phonenumberbox.Text != "") { numlabel.Visible = false; }
            else { numlabel.Visible = true; }
        }
        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            if (passwordbox.Text != "") { PassLabel.Visible = false; }
            else { PassLabel.Visible = true; }
        }
        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            if (emailbox.Text != "") { EmailLabel.Visible = false; }
            else { EmailLabel.Visible = true; }
        }
        private void dashbutton_MouseHover(object sender, EventArgs e)
        {
            dashbutton.BackColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            dashbutton.BackColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void logButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void date_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void male_Click(object sender, EventArgs e)
        {
            if (malebox.Checked) femalebox.Checked = false;
        }
        private void female_Click(object sender, EventArgs e)
        {
            if (femalebox.Checked) malebox.Checked = false;
        }
        private void cancel_Click(object sender, EventArgs e) {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            string query = "SELECT Users.FName, Users.LName, Users.Email, Users.UPassword, Users.UAddress, Users.PhoneNo, Users.DoB, Users.Gender FROM Users WHERE Users.UserID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    string fn = reader["FName"].ToString();
                    string ln = reader["LName"].ToString();
                    string email = reader["Email"].ToString();
                    string password = reader["UPassword"].ToString();
                    string address = reader["UAddress"].ToString();
                    string phoneNumber = reader["PhoneNo"].ToString();
                    DateTime dateOfBirth = Convert.ToDateTime(reader["DoB"]);
                    string gen = reader["Gender"].ToString();

                    // Now you can use these values as needed
                    adminname.Text = fn + " " + ln;
                    adminemail.Text = email;
                    emailbox.Text = email;
                    Fname.Text = fn;
                    Lname.Text = ln;
                    passwordbox.Text = password;
                    addressbox.Text = address;
                    phonenumberbox.Text = phoneNumber;
                    datebox.Text = dateOfBirth.Day.ToString();
                    monthbox.Text = dateOfBirth.Month.ToString();
                    Yearbox.Text = dateOfBirth.Year.ToString();
                    if (gen == "Female")
                    {
                        femalebox.Checked = true;
                    }
                    else
                    {
                        malebox.Checked = true;
                    }
                }
            }

            cmd.Dispose();
            connect.Close();
        }
        private void callcode_Click(object sender, EventArgs e) { }
        private void settingButton_Click(object sender, EventArgs e) { }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            //do nothing for now - stay here
        }
        private void dashbutton_Click(object sender, EventArgs e) { new AdminHome(UserID, connectionString).Show(); this.Hide(); }
        private void gymButton_Click(object sender, EventArgs e) { }
        private void savebutton_Click(object sender, EventArgs e) {
            if (string.IsNullOrWhiteSpace(emailbox.Text) || string.IsNullOrWhiteSpace(passwordbox.Text) || string.IsNullOrWhiteSpace(addressbox.Text) || string.IsNullOrWhiteSpace(Fname.Text) || string.IsNullOrWhiteSpace(Lname.Text) || string.IsNullOrWhiteSpace(phonenumberbox.Text) || !(malebox.Checked || femalebox.Checked))
            {
                MessageBox.Show("All fields must be filled!", "Update Profile Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string query = "SELECT dbo.CheckIfEmailExists('" + UserID + "','" + emailbox.Text + "') FROM Users;";
                SqlCommand cmd = new SqlCommand(query, connect);
                int count = (int)cmd.ExecuteScalar();
                if (count == 1)
                {
                    string gen;
                    if (malebox.Checked) gen = "Male";
                    else gen = "Female";

                    DateTime nayadob = DateTime.Now;
                    query = "UPDATE Users SET Email = '" + emailbox.Text + "', UPassword = '"
                            + passwordbox.Text + "', UAddress = '" + addressbox.Text + "', PhoneNo = '"
                            + phonenumberbox.Text + "', FName = '" + Fname.Text
                            + "', LName = '" + Lname.Text + "', Gender = '" + gen + "' WHERE UserID = '" + this.UserID + "';";

                    cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Changes have been saved! Profile Updated successfully!");
                }
                else
                {
                    MessageBox.Show("Profile could not be updated! This email is already in use.");
                }
                cmd.Dispose();
                connect.Close();
            }
        }
        private void addButton_Click(object sender, EventArgs e) { }
        private void userButton_Click(object sender, EventArgs e) { }
        private void gymButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            gymButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }

        private void gymButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            gymButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }

        private void userButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            userButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }

        private void userButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            userButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void addButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            addButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }

        private void addButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            addButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void logButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            logButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }

        private void logButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
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

        private void AdminProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
