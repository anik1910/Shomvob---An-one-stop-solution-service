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
    public partial class RiderReferInterface : Form
    {
        public RiderReferInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            RiderDetails f1 = new RiderDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the rider reference interface.");
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            RiderHistoryInterface f1 = new RiderHistoryInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            RiderBalanceInterface f1 = new RiderBalanceInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            RiderPrivacyNPolicyInterface f1 = new RiderPrivacyNPolicyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderInterface f1 = new RiderInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
