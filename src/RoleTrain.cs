using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace proj
{
    public partial class RoleTrain : Form
    {
        string fn, ln, email, password, connectionstring;
        public RoleTrain(string fn, string ln, string email, string password, string connectionstring)
        {
            InitializeComponent();
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.password = password;
            this.connectionstring = connectionstring;
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
            new RoleMem(fn, ln, email, password, connectionstring).Show();
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
            //button2.ForeColor = Color.Black;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //button2.ForeColor = Color.White;
        }
        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void DoBLabel_Click(object sender, EventArgs e)
        {

        }
        private void LogLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }
        private void RoleTrain_Load(object sender, EventArgs e)
        {

        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if(phonenumber.Text != "")
            {
                phonelabel.Visible = false;
            }
            else
            {
                phonelabel.Visible=true;
            }
        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(saal.Text) || string.IsNullOrEmpty(address.Text))
            {
                MessageBox.Show("Fill all fields!");
            }
            else
            {
                string number = phonenumber.Text;
                string gender = comboBox1.SelectedItem.ToString();
                string add = address.Text;
                int years = Convert.ToInt32(saal.Text);
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        conn.Open();
                        string query = "INSERT INTO Users (URole, FName, LName, Email, UPassword, DoB, Gender, PhoneNo, UAddress, JoinDate) " +
                           "VALUES ('Trainer', @FName, @LName, @Email, @UPassword, NULL, @Gender, @PhoneNo, @UAddress, CURRENT_TIMESTAMP)";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@FName", fn);
                            command.Parameters.AddWithValue("@LName", ln);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@UPassword", password);
                            command.Parameters.AddWithValue("@Gender", gender);
                            command.Parameters.AddWithValue("@PhoneNo", number);
                            command.Parameters.AddWithValue("@UAddress", add);

                            if((int) command.ExecuteNonQuery() > 0) {
                                query = "SELECT USERID FROM USERS WHERE Email = '" + email + "' AND UPassword = '" + password + "';";
                                command.CommandText = query;
                                int idval = Convert.ToInt32(command.ExecuteScalar());
                                
                                
                                query = "INSERT INTO Trainer (TrainerID, Years) VALUES ('" +  idval + "', '" + years + "')";
                                using(SqlCommand cmd = new SqlCommand(query, conn))
                                {
                                    if((int)cmd.ExecuteNonQuery() > 0)
                                    {
                                        MessageBox.Show("Trainer Added!");
                                        new TrainHome(idval, connectionstring).Show();
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
            }

        }

        private void TermsBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if(address.Text != "") { addlabel.Visible = false; }
            else { addlabel.Visible=true; }
        }

        private void addlabel_Click(object sender, EventArgs e)
        {
            address.Focus();
        }

        private void phonelabel_Click(object sender, EventArgs e)
        {
            phonenumber.Focus();
        }
    }
}
