using System;
using System.Collections;
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

namespace proj
{
    public partial class TrainerProfile : Form
    {
        int UserID;
        string connectionString;
        public TrainerProfile(int UserID, string connectionS)
        {
            InitializeComponent();
            this.UserID = UserID;
            this.connectionString = connectionS;
            allergeninput.Text = special.Text = string.Empty;
            allergeninput.Visible = special.Visible = false;
            pictureBox2.Visible = plus.Visible = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Users.FName + ' ' + Users.LName FROM Users WHERE Users.UserID = '" + UserID + "';";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    terenaam.Text = (command.ExecuteScalar()).ToString();
                    query = "SELECT Email FROM Users WHERE Users.UserID = '" + UserID + "';";
                    command.CommandText = query;
                    traineremail.Text = (command.ExecuteScalar()).ToString();


                }

                query = "SELECT Users.FName, Users.LName, Users.Email, Users.UPassword, Users.UAddress, Users.PhoneNo, Users.DoB, Users.Gender FROM Users WHERE Users.UserID = '" + UserID + "';";
                SqlCommand cmd = new SqlCommand(query, connection);
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

                        emailbox.Text = email;
                        Fname.Text = fn;
                        Lname.Text = ln;
                        passwordbox.Text = password;
                        addressbox.Text = address;
                        phonenumberbox.Text = phoneNumber;
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

                query = "SELECT Qualification FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "';";
                SqlCommand pls = new SqlCommand(query, connection);

                try
                {
                    SqlDataReader reader = pls.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader["Qualification"].ToString();
                        quali.Items.Add(value);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


                query = "SELECT Specialization FROM Trainer_Specializations WHERE TRAINERID = '" + UserID + "';";
                pls.CommandText = query;

                try
                {
                    SqlDataReader reader = pls.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader["Specialization"].ToString();
                        comboBox1.Items.Add(value);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

                connection.Close();
            }
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

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dashbutton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string totalcheck = "SELECT count(*) FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "';";
                using (SqlCommand cmd = new SqlCommand(totalcheck, connection))
                {
                    int counter = (int)cmd.ExecuteScalar();
                    if (counter <= 0)
                    {
                        MessageBox.Show("You must add atleast one qualification!");
                    }
                    else
                        new TrainHome(UserID, connectionString).Show(); this.Hide();
                }
                connection.Close();
            }
        }

        private void outButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string totalcheck = "SELECT count(*) FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "';";
                using (SqlCommand cmd = new SqlCommand(totalcheck, connection))
                {
                    int counter = (int)cmd.ExecuteScalar();
                    if (counter <= 0)
                    {
                        MessageBox.Show("You must add atleast one qualification!");
                    }
                    else
                        new LogIn().Show(); this.Hide();
                }
                connection.Close ();
            }
        }

        private void malebox_CheckedChanged(object sender, EventArgs e)
        {
            if (malebox.Checked) femalebox.Checked = false;
        }
        private void femalebox_CheckedChanged(object sender, EventArgs e)
        {
            if (femalebox.Checked) malebox.Checked = false;
        }

        private void cancel_Click(object sender, EventArgs e)
        {
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

                    emailbox.Text = email;
                    Fname.Text = fn;
                    Lname.Text = ln;
                    passwordbox.Text = password;
                    addressbox.Text = address;
                    phonenumberbox.Text = phoneNumber;
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

            query = "SELECT Qualification FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "';";
            SqlCommand pls = new SqlCommand(query, connect);

            try
            {
                SqlDataReader reader = pls.ExecuteReader();

                while (reader.Read())
                {
                    string value = reader["Qualification"].ToString();
                    quali.Items.Add(value);
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            cmd.Dispose();
            connect.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
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

                    int day = int.Parse(datebox.SelectedItem.ToString());
                    int month = int.Parse(monthbox.SelectedItem.ToString());
                    int year = int.Parse(yearbox.SelectedItem.ToString());
                    DateTime nayadob = new DateTime(year, month, day);
                    query = "UPDATE Users SET Email = '" + emailbox.Text + "', UPassword = '"
                            + passwordbox.Text + "', UAddress = '" + addressbox.Text + "', PhoneNo = '"
                            + phonenumberbox.Text + "', DoB = '" + nayadob + "', FName = '" + Fname.Text
                            + "', LName = '" + Lname.Text + "', Gender = '" + gen + "' WHERE UserID = '" + this.UserID + "';";

                    cmd = new SqlCommand(query, connect);
                    cmd.ExecuteNonQuery();


                    foreach (var goodstuff in quali.Items)
                    {
                        string trainquali = goodstuff.ToString();
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();

                            string addqualifities = "INSERT INTO Trainer_Qualifications (TrainerID, Qualification) VALUES (@UserID, @qualifi)";
                            string querycheck = "SELECT count(*) FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "' AND Qualification = '" + trainquali + "';";
                            cmd.CommandText = querycheck;
                            int counting = (int)cmd.ExecuteScalar();
                            if (counting <= 0)
                            {
                                using (SqlCommand command = new SqlCommand(addqualifities, connection))
                                {
                                    try
                                    {
                                        command.Parameters.AddWithValue("@UserID", UserID);
                                        command.Parameters.AddWithValue("@qualifi", trainquali);
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

                    string totalcheck = "SELECT count(*) FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "';";
                    cmd.CommandText = totalcheck;
                    int counter = (int)cmd.ExecuteScalar();
                    if(counter <= 0)
                    {
                        MessageBox.Show("You must add atleast one qualification!");
                    }
                    else
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

        private void addday_Click(object sender, EventArgs e)
        {
            allergeninput.Visible = true;
            allergeninput.Text = string.Empty;
            pictureBox2.Visible = true;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            quali.Items.Add(allergeninput.Text);
            allergeninput.Text = string.Empty;
            allergeninput.Visible = false;
            pictureBox2.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (quali.SelectedIndex != -1)
            {
                string trainquali = quali.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string querycheck = "DELETE FROM Trainer_Qualifications WHERE TRAINERID = '" + UserID + "' AND Qualification = '" + trainquali + "';";
                    using (SqlCommand cmd = new SqlCommand(querycheck, connection))
                    {
                        try
                        {
                            int counting = (int)cmd.ExecuteNonQuery();
                            if (counting > 0)
                            {
                                MessageBox.Show("Qualification Deleted!");
                                quali.Items.Remove(quali.SelectedItem.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            }
            allergeninput.Text = string.Empty;
            allergeninput.Visible = false;
            pictureBox2.Visible = false;
        }

        private void profileButton_Click(object sender, EventArgs e)
        {

        }

        private void speacialadd_Click(object sender, EventArgs e)
        {
            special.Visible = true;
            special.Text = string.Empty;
            plus.Visible = true;
        }

        private void speacialremove_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string trainquali = comboBox1.SelectedItem.ToString();
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string querycheck = "DELETE FROM Trainer_Specializations WHERE TRAINERID = '" + UserID + "' AND Specialization = '" + trainquali + "';";
                    using (SqlCommand cmd = new SqlCommand(querycheck, connection))
                    {
                        try
                        {
                            int counting = (int)cmd.ExecuteNonQuery();
                            if (counting > 0)
                            {
                                MessageBox.Show("Specialization Deleted!");
                                comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

            }
            special.Visible = false;
            special.Text = string.Empty;
            plus.Visible = false;
        }

        private void plus_Click(object sender, EventArgs e)
        {
            string trainquali = special.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string addqualifities = "INSERT INTO Trainer_Specializations (TrainerID, Specialization) VALUES (@UserID, @qualifi)";
                string querycheck = "SELECT count(*) FROM Trainer_Specializations WHERE TRAINERID = '" + UserID + "' AND Specialization = '" + trainquali + "';";
                SqlCommand pls = new SqlCommand(querycheck, connection);    
                int counting = (int)pls.ExecuteScalar();
                if (counting <= 0)
                {
                    using (SqlCommand command = new SqlCommand(addqualifities, connection))
                    {
                        try
                        {
                            command.Parameters.AddWithValue("@UserID", UserID);
                            command.Parameters.AddWithValue("@qualifi", trainquali);
                            command.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                }

                string query = "SELECT Specialization FROM Trainer_Specializations WHERE TRAINERID = '" + UserID + "';";
                pls.CommandText = query;

                try
                {
                    SqlDataReader reader = pls.ExecuteReader();

                    while (reader.Read())
                    {
                        string value = reader["Specialization"].ToString();
                        comboBox1.Items.Add(value);
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }


            }
            special.Visible = false;
            special.Text = string.Empty;
            plus.Visible = false;
        }

        private void gymButton_Click(object sender, EventArgs e)
        {
            new TrainerSchedule(UserID, connectionString).Show();
            this.Hide();
        }

        private void memButton_Click(object sender, EventArgs e)
        {
            new TrainWO(UserID, connectionString).Show(); this.Hide();
        }

        private void financeButton_Click(object sender, EventArgs e)
        {
            new TrainerFeedback(UserID, connectionString).Show();
            this.Hide();
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            new TrainGym(UserID, connectionString).Show();
            this.Hide();
        }
    }
}
