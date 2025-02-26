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
    public partial class ExpertControlInterface : Form
    {
        public ExpertControlInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            AeDetailsInterface f1 = new AeDetailsInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            AeHistoryInterface f1 = new AeHistoryInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            //AeHelpReqInterface f1 = new AeHelpReqInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton220_Click(object sender, EventArgs e)
        {
            //AeComplainInterface f1 = new AeComplainInterface();
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

        private void ExpertControlInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
