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
    public partial class ADataControlInterface : Form
    {
        public ADataControlInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            //AcngInterface f1 = new AcngInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            AdminMainInterface f1 = new AdminMainInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //AcarInterface f1 = new AcarInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            //Abikenterface f1 = new Abikenterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton219_Click(object sender, EventArgs e)
        {
            AbusInterface f1 = new AbusInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            AtrainInterface f1 = new AtrainInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AemergencyInterface f1 = new AemergencyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }
    }
}
