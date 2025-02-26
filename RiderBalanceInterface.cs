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
    public partial class RiderBalanceInterface : Form
    {
        public RiderBalanceInterface()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            RiderDetails f2 = new RiderDetails();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the ridr balance interface.");
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            RiderHistoryInterface f2 = new RiderHistoryInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            RiderReferInterface f2 = new RiderReferInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            RiderPrivacyNPolicyInterface f2 = new RiderPrivacyNPolicyInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderInterface f1 = new RiderInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void RiderBalanceInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
