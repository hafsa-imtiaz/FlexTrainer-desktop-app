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
    public partial class SignUp : Form
    {
        public string connectionString = "Data Source=HAFSA\\SQLEXPRESS;Initial Catalog=FlexTrainer;Integrated Security=True;Encrypt=False";
        public SignUp()
        {
            InitializeComponent();
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
        private void SignUpPanel_Paint(object sender, PaintEventArgs e)
        {
            SignUpPanel.BackColor = Color.FromArgb(250, 62, 134, 147);
            //(50, 124, 108, 10);
            //Color.FromArgb(200, 128, 128, 128);  //panel color
        }
        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {
            SidePanel.BackColor = Color.FromArgb(170, 68, 138, 123);
            //(220, 88, 108, 10);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }
        private void LNameText_TextChanged(object sender, EventArgs e)
        {
            if (LNameText.Text == "")
                LNameLabel.Visible = true;
            else
                LNameLabel.Visible = false;
        }
        private void FNameText_TextChanged(object sender, EventArgs e)
        {
            if(FNameText.Text == "")
                FNameLabel.Visible = true;
            else
                FNameLabel.Visible = false;
        }
        private void EmailText_TextChanged(object sender, EventArgs e)
        {
            if(EmailText.Text == "")
                EmailLabel.Visible = true;
            else
                EmailLabel.Visible = false;
        }
        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            if(PasswordText.Text == "")
                PassLabel.Visible = true;
            else
                PassLabel.Visible = false;
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            //check if all info has been added
            if (string.IsNullOrWhiteSpace(FNameText.Text) || string.IsNullOrWhiteSpace(LNameText.Text) || string.IsNullOrWhiteSpace(EmailText.Text) || string.IsNullOrWhiteSpace(PasswordText.Text) || DateBox.SelectedIndex == -1 || YearBox.SelectedIndex == -1 || MonthBox.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled!", "Sign-Up Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                SqlConnection connect = new SqlConnection(connectionString);
                connect.Open();
                string query = "SELECT dbo.GeneralCheckForEmail('" + EmailText.Text + "') FROM Users;";
                SqlCommand cmd = new SqlCommand(query, connect);
                int count = (int)cmd.ExecuteScalar();

                if(count == 1)  //does not exist
                {
                    string fn =FNameText.Text;
                    string ln = LNameText.Text;
                    string email = EmailText.Text;
                    string password = PasswordText.Text;
                    
                    connect.Close();
                    new RoleMem(fn, ln, email, password, connectionString).Show();
                    this.Hide();
                }
                else    //does exist
                {
                    MessageBox.Show("Account cannot be created! This email is already in use.");
                }
                connect.Close();
            }
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }
        private void FNameLabel_Click(object sender, EventArgs e)
        {
            FNameText.Focus();
        }
        private void LNameLabel_Click(object sender, EventArgs e)
        {
            LNameText.Focus();
        }
        private void EmailLabel_Click(object sender, EventArgs e)
        {
            EmailText.Focus();
        }
        private void PassLabel_Click(object sender, EventArgs e)
        {
            PasswordText.Focus();
        }
    }
}
