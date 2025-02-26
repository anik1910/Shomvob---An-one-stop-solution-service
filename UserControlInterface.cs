using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shomvob
{
    public partial class UserControlInterface : Form
    {
        public UserControlInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            AuserDetailsInterface f2 = new AuserDetailsInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            AuHistoryInterface f2 = new AuHistoryInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            //AuHelpReqInterface f2 = new AuHelpReqInterface();
            //f2.Show();
            //f2.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton220_Click(object sender, EventArgs e)
        {
            AuComplainBoxInterface f2 = new AuComplainBoxInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AdminMainInterface f2 = new AdminMainInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }
    }
}
