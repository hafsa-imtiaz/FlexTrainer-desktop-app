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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class MemberProfile : Form
    {
        int UserID;
        string connectionString;
        public MemberProfile(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;
            allergeninput.Text = string.Empty;
            allergeninput.Visible = false;
            pictureBox2.Visible = false;

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            string query = "SELECT Users.FName, Users.LName, Users.Email, Users.UPassword, Users.UAddress, Users.PhoneNo, Users.DoB, Users.Gender, Member.Goal, Member.Weight, Member.Height FROM Users INNER JOIN MEMBER ON MEMBER.MemID = Users.UserID WHERE Users.UserID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Fnamebox.Text = reader["FName"].ToString();
                    Lnamebox.Text = reader["LName"].ToString();
                    memname.Text = Fnamebox.Text + ' ' + Lnamebox.Text;
                    emailbox.Text = reader["Email"].ToString();
                    passwordbox.Text = reader["UPassword"].ToString();
                    address.Text = reader["UAddress"].ToString();
                    phonenumber.Text = reader["PhoneNo"].ToString();
                    DateTime dateOfBirth = Convert.ToDateTime(reader["DoB"]);
                    string gen = reader["Gender"].ToString();
                    weightbox.Text = reader["Weight"].ToString();
                    heightbox.Text = reader["Height"].ToString();
                    goalbox.Text = reader["Goal"].ToString();

                    datebox.Text = dateOfBirth.Day.ToString();
                    monthbox.Text = dateOfBirth.Month.ToString();
                    yearbox.Text = dateOfBirth.Year.ToString();
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

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                query = "SELECT Allergens FROM Member_Allergy WHERE MEMID = '" + UserID + "';";
                SqlCommand command = new SqlCommand(query, connection);

                try
                {
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader["Allergens"].ToString();
                        allergies.Items.Add(value);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
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
        private void dashbutton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dashbutton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void dashbutton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dashbutton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
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
        private void actButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            actButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void actButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            actButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void dietButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dietButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void dietButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            dietButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void trainButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            trainButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void trainButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            trainButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void outButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            outButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void outButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            outButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void profileButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            profileButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void workButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            workButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void workButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            workButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void profileButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            profileButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void settingButton_MouseHover(object sender, EventArgs e)
        {
            //do nothing  - stay here
            settingButton.ForeColor = Color.FromArgb(230, 1, 97, 100);

        }
        private void settingButton_MouseLeave(object sender, EventArgs e)
        {
            //do nothing  - stay here
            settingButton.ForeColor = Color.FromArgb(230, 240, 240, 240);

        }
        private void workButton_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(230, 66, 95, 84);
        }

        private void settingButton_Click(object sender, EventArgs e)
        {

        }
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void trainButton_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show();
            this.Hide();
        }

        private void dietButton_Click(object sender, EventArgs e)
        {
            new MemberDiet1(UserID, connectionString).Show();
            this.Hide();
        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            new MemberHome(UserID, connectionString).Show();
            this.Hide();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            //you are here
        }
        private void actButton_Click(object sender, EventArgs e)
        {
        }
        private void gymButton_Click(object sender, EventArgs e)
        {
            new MemberGym(UserID, connectionString).Show(); this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            weightbox.Focus();
        }

        private void heightbox_TextChanged(object sender, EventArgs e)
        {
            if (heightbox.Text != "") heightlabel.Visible = false;
            else heightlabel.Visible = true;
        }

        private void heightlabel_Click(object sender, EventArgs e)
        {
            heightbox.Focus();
        }

        private void weightbox_TextChanged(object sender, EventArgs e)
        {
            if (weightbox.Text!="")weightlabel.Visible = false;
            else weightlabel.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            goalbox.ReadOnly = false;
        }

        private void role_Click(object sender, EventArgs e)
        {

        }

        private void goalbox_TextChanged(object sender, EventArgs e)
        {
            if(goalbox.Text!="") role.Visible = false;
            else role.Visible = true;
        }

        private void Fnamebox_TextChanged(object sender, EventArgs e)
        {
            if(Fnamebox.Text != "") FNameLabel.Visible = false;
            else FNameLabel.Visible = true;
        }

        private void Lnamebox_TextChanged(object sender, EventArgs e)
        {
            if(Lnamebox.Text != "") LNameLabel.Visible = false;
            else LNameLabel.Visible = true;
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(address.Text)) { addresslabel.Visible = false; }
            else addresslabel.Visible = true;
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if(phonenumber.Text!="") numlabel.Visible = false;
            else numlabel.Visible = true;
        }

        private void emailbox_TextChanged(object sender, EventArgs e)
        {
            if(emailbox.Text!="") EmailLabel.Visible = false;
            else EmailLabel.Visible = true;
        }

        private void passwordbox_TextChanged(object sender, EventArgs e)
        {
            if(passwordbox.Text!="") PassLabel.Visible = false;
            else PassLabel.Visible = true;  
        }

        private void cardnum_TextChanged(object sender, EventArgs e)
        {
            if(cardnum.Text != "") cardlabel.Visible = false;
            else cardlabel.Visible = true;
        }

        private void cvv_TextChanged(object sender, EventArgs e)
        {
            if(cvv.Text!="") cvvlabel.Visible = false;
            else cvvlabel.Visible = true;
        }

        private void expiry_TextChanged(object sender, EventArgs e)
        {
            if(expiry.Text!="") datelabel.Visible = false;
            else datelabel.Visible = true;
        }

        private void malebox_CheckedChanged(object sender, EventArgs e)
        {
            if (malebox.Checked)
                femalebox.Checked = false;
        }

        private void femalebox_CheckedChanged(object sender, EventArgs e)
        {
            if(femalebox.Checked)
                malebox.Checked=false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();

            string query = "SELECT Users.FName, Users.LName, Users.Email, Users.UPassword, Users.UAddress, Users.PhoneNo, Users.DoB, Users.Gender, Member.Goal, Member.Weight, Member.Height FROM Users INNER JOIN MEMBER ON MEMBER.MemID = Users.UserID WHERE Users.UserID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.Read())
                {
                    Fnamebox.Text = reader["FName"].ToString();
                    Lnamebox.Text = reader["LName"].ToString();
                    memname.Text = Fnamebox.Text + ' ' + Lnamebox.Text;
                    emailbox.Text = reader["Email"].ToString();
                    passwordbox.Text = reader["UPassword"].ToString();
                    address.Text = reader["UAddress"].ToString();
                    phonenumber.Text = reader["PhoneNo"].ToString();
                    DateTime dateOfBirth = Convert.ToDateTime(reader["DoB"]);
                    string gen = reader["Gender"].ToString();
                    weightbox.Text = reader["Weight"].ToString();
                    heightbox.Text = reader["Height"].ToString();
                    goalbox.Text = reader["Goal"].ToString();

                    datebox.Text = dateOfBirth.Day.ToString();
                    monthbox.Text = dateOfBirth.Month.ToString();
                    yearbox.Text = dateOfBirth.Year.ToString();
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

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailbox.Text) || string.IsNullOrWhiteSpace(goalbox.Text) || string.IsNullOrWhiteSpace(passwordbox.Text) || string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(Fnamebox.Text) || string.IsNullOrWhiteSpace(Lnamebox.Text) || string.IsNullOrWhiteSpace(phonenumber.Text) || string.IsNullOrWhiteSpace(weightbox.Text) || string.IsNullOrWhiteSpace(heightbox.Text) || !(malebox.Checked || femalebox.Checked) || datebox.SelectedIndex == 0 || monthbox.SelectedIndex == 0 || yearbox.SelectedIndex == 0)
            {
                MessageBox.Show("All fields must be filled!", "Update Profile Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection connect = new SqlConnection(connectionString);
                    connect.Open();
                    string query = "SELECT dbo.CheckIfEmailExists('" + UserID + "','" + emailbox.Text + "') FROM Users;";
                    SqlCommand cmd = new SqlCommand(query, connect);
                    int count = (int)cmd.ExecuteScalar();
                    if (count == 1) //email does not exit
                    {
                        string gen; //find gender
                        if (malebox.Checked) gen = "Male";
                        else gen = "Female";

                        
                        query = query = "UPDATE Users SET Email = '" + emailbox.Text + "', UPassword = '"
                                + passwordbox.Text + "', UAddress = '" + address.Text + "', PhoneNo = '"
                                + phonenumber.Text + "', FName = '" + Fnamebox.Text
                                + "', LName = '" + Lnamebox.Text + "', Gender = '" + gen + "' WHERE UserID = '" + this.UserID + "';";
                        cmd.CommandText = query;
                        cmd.ExecuteNonQuery();

                        //update members
                        cmd.CommandText = "UPDATE Member SET Height = '" + heightbox.Text + "', Weight = '" + weightbox.Text + "', Goal = '" + goalbox.Text + "' WHERE memID = '" + this.UserID + "';";
                        cmd.ExecuteNonQuery();

                        foreach (var allergen in allergies.Items)
                        {
                            string allergenName = allergen.ToString();
                            using (SqlConnection connection = new SqlConnection(connectionString))
                            {
                                connection.Open();
                                string please = "SELECT COUNT(*) FROM MEMBER_ALLERGY WHERE MEMID = '" + UserID + "' AND Allergens = '" + allergenName + "';";
                                cmd.CommandText = please;
                                if ((int)cmd.ExecuteScalar() == 0)
                                {
                                    string insertAllergenQuery = "INSERT INTO Member_Allergy (MemID, Allergens) VALUES (@UserID, @Allergens)";
                                    using (SqlCommand command = new SqlCommand(insertAllergenQuery, connection))
                                    {
                                        try
                                        {
                                            command.Parameters.AddWithValue("@UserID", UserID);
                                            command.Parameters.AddWithValue("@Allergens", allergenName);
                                            command.ExecuteNonQuery();
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show("Error: " + ex.Message);
                                        }
                                    }
                                }
                            }
                        }


                        MessageBox.Show("Changes have been saved! Profile Updated successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Profile could not be updated! This email is already in use.");
                    }
                    cmd.Dispose();
                    connect.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Exception: " + ex.Message);
                }
            }
        }

        private void MemberProfile_Load(object sender, EventArgs e)
        {

        }

        private void addday_Click(object sender, EventArgs e)
        {
            allergeninput.Visible = true;
            allergeninput.Text = string.Empty;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            allergies.Items.Add(allergeninput.Text);
            allergeninput.Text = string.Empty;
            allergeninput.Visible = false;
            pictureBox2.Visible = false;
        }

        private void delbutton_Click(object sender, EventArgs e)
        {
            //delete account
            this.Hide();
            new LogIn().Show();
        }
    }
}
