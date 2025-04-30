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
    public partial class ApprovalForm : Form
    {
        int UserID;
        string connectionstring;
        string role;
        public ApprovalForm(int userid, string conn, string role)
        {
            InitializeComponent();
            this.connectionstring
                = conn;
            this.UserID = userid;
            this.role = role;
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
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            if(role == "A")
            {
                new AdminHome(UserID, connectionstring).Show();
            }
            else
            {
                new OwnerHome(UserID, connectionstring).Show();
            }
            this.Hide();
        }
    }
}
