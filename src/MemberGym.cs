using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class MemberGym : Form
    {
        int UserID;
        string connectionString;
        int memship;
        public MemberGym(int userID, string connectionString)
        {
            InitializeComponent();
            UserID = userID;
            this.connectionString = connectionString;

            SqlConnection connect = new SqlConnection(connectionString);
            connect.Open();
            
            string query = "select gym.GymName, gym.Address, gym.PhoneNo AS gymPhoneNo, users.FName + ' '+ Users.LName AS Name, users.Email, Users.PhoneNo, member.MembershipType, Member.Start_Date, Gym_Membership.Payment from gym inner join Users on Users.UserID = gym.OwnerID inner join Member on Member.GymID = gym.GymID  inner join gym_membership on gym_membership.gymID = Member.gymID where Member.memID = '" + UserID + "';";
            SqlCommand cmd = new SqlCommand(query, connect);
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        gymname.Text = reader["GymName"].ToString();
                        gymphoneno.Text = reader["gymPhoneNo"].ToString();
                        address.Text = reader["Address"].ToString();
                        ownername.Text = reader["Name"].ToString();
                        opn.Text = reader["PhoneNo"].ToString();
                        email.Text = reader["Email"].ToString();
                        datelabel.Text = reader["Start_Date"].ToString();
                        paisa.Text = reader["Payment"].ToString();

                        if (reader["MembershipType"].ToString() == "Bronze" || reader["MembershipType"].ToString() == "Standard")
                        {
                            memship = 1;
                            low.Checked = true;
                            mid.Checked = false;
                            high.Checked = false;
                        }
                        else if(reader["MembershipType"].ToString() == "Gold" || reader["MembershipType"].ToString() == "Plus")
                        {
                            memship = 2;
                            low.Checked = false;
                            mid.Checked = true;
                            high.Checked = false;
                        }
                        else
                        {
                            memship = 3;
                            low.Checked = false;
                            mid.Checked = false;
                            high.Checked = true;
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Your Data could not be loaded!", "Database Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            int id = 0;
            query = "SELECT GymID FROM Member;";
            cmd.CommandText = query;
            id = (int)cmd.ExecuteScalar();

            if (id != 0)
            {
                query = "SELECT MachineName, MachineCount FROM Gym_Equipment WHERE GymID = '" + id + "';";
                SqlDataAdapter userTable = new SqlDataAdapter(query, connect);
                DataTable userdata = new DataTable();
                userTable.Fill(userdata);
                facility.DataSource = userdata;
            }

            cmd.Dispose();
            connect.Close();
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void dashbutton_Click(object sender, EventArgs e)
        {
            new MemberHome(UserID, connectionString).Show();
            this.Hide();
        }
        private void profileButton_Click(object sender, EventArgs e)
        {
            new MemberProfile(UserID, connectionString).Show(); this.Hide();
        }
        private void outButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show(); this.Hide();
        }
        private void workButton_Click(object sender, EventArgs e)
        {
            new MemberWO1(UserID, connectionString).Show(); this.Hide();
        }
        private void dietButton_Click(object sender, EventArgs e)
        {
            new MemberDiet1(UserID, connectionString).Show(); this.Hide();
        }
        private void trainButton_Click(object sender, EventArgs e)
        {
            new MemberTraining(UserID, connectionString).Show(); this.Hide();
        }
        private void actButton_Click(object sender, EventArgs e)
        {
            new MemberAct(UserID, connectionString).Show(); this.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void high_CheckedChanged(object sender, EventArgs e)
        {
            if (high.Checked)
            {
                if(memship != 3)    //membership was just changed
                {
                    DialogResult result = MessageBox.Show("Are you serious about changing your membership type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        low.Checked = false;
                        mid.Checked = false;
                        memship = 3;

                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            string query = "UPDATE Member SET MembershipType = 'Bronze' WHERE MemID = '" + UserID + "';";
                            SqlCommand cmd = new SqlCommand(query, connect);
                            cmd.ExecuteNonQuery();


                            query = "SELECT Gym_Membership.Payment FROM Member INNER JOIN Gym_Membership ON Member.GymID = Gym_Membership.GymID WHERE MemID = '" + UserID + "' AND Gym_Membership.MembershipType = 'Platinum';";
                            cmd.CommandText = query;
                            paisa.Text = cmd.ExecuteScalar().ToString();
                            connect.Close();
                        }

                        MessageBox.Show("Membership type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        high.Checked = false;
                    }
                }
            }
        }

        private void mid_CheckedChanged(object sender, EventArgs e)
        {
            if(mid.Checked) { 
                if(memship != 2)
                {
                    DialogResult result = MessageBox.Show("Are you serious about changing your membership type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        low.Checked = false;
                        high.Checked = false;
                        memship = 2;

                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            string query = "UPDATE Member SET MembershipType = 'Bronze' WHERE MemID = '" + UserID + "';";
                            SqlCommand cmd = new SqlCommand(query, connect);
                            cmd.ExecuteNonQuery();


                            query = "SELECT Gym_Membership.Payment FROM Member INNER JOIN Gym_Membership ON Member.GymID = Gym_Membership.GymID WHERE MemID = '" + UserID + "' AND Gym_Membership.MembershipType = 'Gold';";
                            cmd.CommandText = query;
                            paisa.Text = cmd.ExecuteScalar().ToString();
                            connect.Close();
                        }
                        MessageBox.Show("Membership type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        mid.Checked = false;
                    }
                }
            }
        }

        private void low_CheckedChanged(object sender, EventArgs e)
        {
            if(low.Checked) { 
                if(memship != 1)
                {
                    DialogResult result = MessageBox.Show("Are you serious about changing your membership type?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        high.Checked = false;
                        mid.Checked = false;

                        using (SqlConnection connect = new SqlConnection(connectionString))
                        {
                            connect.Open();
                            string query = "UPDATE Member SET MembershipType = 'Bronze' WHERE MemID = '" + UserID + "';";
                            SqlCommand cmd = new SqlCommand(query, connect);
                            cmd.ExecuteNonQuery();


                            query = "SELECT Gym_Membership.Payment FROM Member INNER JOIN Gym_Membership ON Member.GymID = Gym_Membership.GymID WHERE MemID = '" + UserID + "' AND Gym_Membership.MembershipType = 'Bronze';";
                            cmd.CommandText = query;
                            paisa.Text = cmd.ExecuteScalar().ToString();
                            connect.Close();
                        }

                        memship =1;
                        MessageBox.Show("Membership type updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);               
                    }
                    else
                    {
                        low.Checked = false;
                    }
                }
            }
        }
    }
}
