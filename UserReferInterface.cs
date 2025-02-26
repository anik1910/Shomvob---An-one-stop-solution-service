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
    public partial class UserReferInterface : Form
    {
        public UserReferInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            UserInterface f1 = new UserInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            UserPrivacyNPolicyInterface f1 = new UserPrivacyNPolicyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            UserHistoryInterface f1 = new UserHistoryInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            UserBalanceInterface f1 = new UserBalanceInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            UserDetails f1 = new UserDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
