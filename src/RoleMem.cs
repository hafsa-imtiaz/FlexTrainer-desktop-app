using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class RoleMem : Form
    {
        string fn, ln, email, password, connectionstring;
        public RoleMem(string fn, string ln, string email, string password, string connectionstring)
        {
            InitializeComponent();
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.password = password;
            this.connectionstring = connectionstring;
            idbox.Visible= false;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionstring))
                {
                    connection.Open();
                    string query = "SELECT GymName, GymID FROM Gym";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string gymName = reader["GymName"].ToString();
                                gymbox.Items.Add(gymName);
                                idbox.Items.Add(reader["GymID"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

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
        private void button1_Click(object sender, EventArgs e)
        {
            // do nothing
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }
        private void LogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(address.Text) || string.IsNullOrWhiteSpace(phonenumber.Text) || string.IsNullOrWhiteSpace(callcode.Text) || gymbox.SelectedIndex==-1 || (!premcheck.Checked && !pluscheck.Checked && !standcheck.Checked))
            {
                MessageBox.Show("All fields must be filled!", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string number = phonenumber.Text;
                string add = address.Text;
                int gymid = Convert.ToInt32(idbox.SelectedItem);
                string membership = (premcheck.Checked) ? "Platinum" : (pluscheck.Checked) ? "Gold" : "Bronze";
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        conn.Open();
                        string query = "INSERT INTO Users (URole, FName, LName, Email, UPassword, DoB, Gender, PhoneNo, UAddress, JoinDate) " +
                           "VALUES ('Member', @FName, @LName, @Email, @UPassword, NULL, 'Female', @PhoneNo, @UAddress, CURRENT_TIMESTAMP)";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@FName", fn);
                            command.Parameters.AddWithValue("@LName", ln);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@UPassword", password);
                            command.Parameters.AddWithValue("@PhoneNo", number);
                            command.Parameters.AddWithValue("@UAddress", add);

                            if ((int)command.ExecuteNonQuery() > 0)
                            {
                                query = "SELECT USERID FROM USERS WHERE Email = '" + email + "' AND UPassword = '" + password + "';";
                                command.CommandText = query;
                                int idval = Convert.ToInt32(command.ExecuteScalar());

                                query = "INSERT INTO Member (MemID, Height, Goal, Weight, DPlanID, WPlanID, GymID, MembershipType, Start_Date, End_Date, Account_Status) " +
                                "VALUES (@MemID, 0, 'N/A', 0, NULL, NULL, @GymID, @MembershipType, CURRENT_TIMESTAMP, NULL, 'Active')";
                                using (SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    cmd.Parameters.AddWithValue("@MemID", idval);
                                    cmd.Parameters.AddWithValue("@GymID", gymid);
                                    cmd.Parameters.AddWithValue("@MembershipType", membership);

                                    if ((int)cmd.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("Member Added!");
                                        new MemberHome(idval, connectionstring).Show();
                                        this.Hide();
                                    }
                                    else
                                    {
                                        MessageBox.Show("Your Data could not be loaded!", "Database Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                this.Hide();
            }
        }
        private void SignUpPanel_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            new RoleTrain(fn, ln, email, password, connectionstring).Show(); 
            this.Hide();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            new RoleAdmin(fn, ln, email, password, connectionstring).Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new RoleOwner(fn, ln, email, password, connectionstring).Show();
            this.Hide();
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
        }
        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
        }
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            //button1.ForeColor = Color.Black;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            //button1.ForeColor = Color.White;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (pluscheck.Checked)
            {
                standcheck.Checked = false;
                premcheck.Checked = false;
            }
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (standcheck.Checked)
            {
                premcheck.Checked = false;
                pluscheck.Checked = false;
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(address.Text != "") { addlabel.Visible = false; }
            else { addlabel.Visible = true; }
        }

        private void gymbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            idbox.SelectedIndex = gymbox.SelectedIndex;
        }

        private void premcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (premcheck.Checked)
            {
                standcheck.Checked = false;
                pluscheck.Checked = false;
            }
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if(phonenumber.Text != "") { phonelabel.Visible = false; }
            else { phonelabel.Visible = true; }
        }

        private void phonelabel_Click(object sender, EventArgs e)
        {
            phonenumber.Focus();
        }

        private void addlabel_Click(object sender, EventArgs e)
        {
            address.Focus();
        }
    }
}

//230, 16, 48, 46