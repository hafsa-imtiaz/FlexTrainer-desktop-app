using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proj
{
    public partial class Welcome : Form
    {
        public Welcome()
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
        private void Welcome_Load(object sender, EventArgs e)
        {
            Main.BackColor = Color.FromArgb(200, 62, 134, 147);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void LogInButton_Click(object sender, EventArgs e)
        {
            new LogIn().Show();
            this.Hide();
        }
        private void HomeLabel_Click(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //do nothing --- stay on this page
        }
        private void Main_Paint(object sender, PaintEventArgs e)
        {

        }
        private void SignButton_Click(object sender, EventArgs e)
        {
            new SignUp().Show();
            this.Hide();
        }
        private void ServicesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Services().Show();
            this.Hide();
        }
    }
}
