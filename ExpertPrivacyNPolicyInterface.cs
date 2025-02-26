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
    public partial class ExpertPrivacyNPolicyInterface : Form
    {
        public ExpertPrivacyNPolicyInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ExpertInterface f1 = new ExpertInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ExpertDetails f1 = new ExpertDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //ExpertBalanceInterface f1 = new ExpertBalanceInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            ExpertHistoryInterface f1 = new ExpertHistoryInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            //ExpertReferInterface f1 = new ExpertReferInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the expert privacy and policy interface.");
        }
    }
}
