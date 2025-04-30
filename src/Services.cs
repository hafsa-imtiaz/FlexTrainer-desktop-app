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
    public partial class Services : Form
    {
        public Services()
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
        private void Services_Load(object sender, EventArgs e)
        {
            
        }
        private void HomeLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Welcome().Show();
            this.Hide();
        }
        private void ServicesLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //do nothing - stay on this form
        }
        private void Main_Paint(object sender, PaintEventArgs e)
        {
            Main.BackColor = Color.FromArgb(200, 62, 134, 147);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            //do nothing
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.BackColor = Color.FromArgb(200, 5, 58, 64);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            panel2.BackColor = Color.FromArgb(200, 5, 58, 64);
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.BackColor = Color.FromArgb(200, 5, 58, 64);
        }
        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
