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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace proj
{
    public partial class RoleAdmin : Form
    {
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
        string fn;
        string ln;
        string email;
        string password;
        string connectionstring;
        public RoleAdmin(string fn, string ln, string email, string password, string connectionstring)
        {
            InitializeComponent();
            this.fn = fn;
            this.ln = ln;
            this.email = email;
            this.password = password;
            this.connectionstring = connectionstring;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            new RoleMem(fn, ln, email, password, connectionstring).Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            new RoleTrain(fn, ln, email, password, connectionstring).Show();
            this.Hide();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            new RoleOwner(fn, ln, email, password, connectionstring).Show();
            this.Hide();
        }
        private void button4_MouseHover(object sender, EventArgs e)
        {
            //button4.ForeColor = Color.Black;
        }
        private void button4_MouseLeave(object sender, EventArgs e)
        {
           // button4.ForeColor = Color.White;
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
            button1.ForeColor = Color.Black;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.White;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            phonenumber.Focus();
        }
        private void label_Click(object sender, EventArgs e)
        {
            phonenumber.Focus();
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(callcode.Text) || string.IsNullOrWhiteSpace(phonenumber.Text) || string.IsNullOrWhiteSpace(address.Text) || !TermsBox.Checked || gender.SelectedIndex == -1 )
            {
                MessageBox.Show("All fields must be filled!", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string number = phonenumber.Text;
                string gender2 = gender.SelectedItem.ToString();
                string add = address.Text;
                try
                {
                    using (SqlConnection conn = new SqlConnection(connectionstring))
                    {
                        conn.Open();
                        string query = "INSERT INTO Users (URole, FName, LName, Email, UPassword, DoB, Gender, PhoneNo, UAddress, JoinDate) " +
                           "VALUES ('Admin', @FName, @LName, @Email, @UPassword, NULL, @Gender, @PhoneNo, @UAddress, CURRENT_TIMESTAMP)";

                        using (SqlCommand command = new SqlCommand(query, conn))
                        {
                            command.Parameters.AddWithValue("@FName", fn);
                            command.Parameters.AddWithValue("@LName", ln);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@UPassword", password);
                            command.Parameters.AddWithValue("@Gender", gender2);
                            command.Parameters.AddWithValue("@PhoneNo", number);
                            command.Parameters.AddWithValue("@UAddress", add);

                            if ((int)command.ExecuteNonQuery() > 0)
                            {
                                query = "SELECT USERID FROM USERS WHERE Email = '" + email + "' AND UPassword = '" + password + "';";
                                command.CommandText = query;
                                int idval = Convert.ToInt32(command.ExecuteScalar());

                                MessageBox.Show("Request Added!");
                                this.Hide();
                                new ApprovalForm(idval, connectionstring, "A").Show();
                            }
                            else
                            {
                                MessageBox.Show("Your Data could not be loaded!", "Database Failure", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
        private void RoleAdmin_Load(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {
            address.Focus();
        }

        private void phonenumber_TextChanged(object sender, EventArgs e)
        {
            if(phonenumber.Text != "") { number.Visible = false; }
            else { number.Visible = true; }
        }

        private void address_TextChanged(object sender, EventArgs e)
        {
            if(address.Text != "") { add.Visible = false; }
            else { add.Visible = true; }
        }
    }
}
