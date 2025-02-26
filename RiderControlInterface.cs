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
    public partial class RiderControlInterface : Form
    {
        public RiderControlInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            ArDetailsInterface f1 = new ArDetailsInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            ArHistoryInterface f1 = new ArHistoryInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            ArComplainIterface f1 = new ArComplainIterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton220_Click(object sender, EventArgs e)
        {
            //ArComplainIterface f1 = new ArComplainIterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AdminMainInterface f1 = new AdminMainInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }
    }
}
