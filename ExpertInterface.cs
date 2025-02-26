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
    public partial class ExpertInterface : Form
    {
        public ExpertInterface()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            ExpertDetails f1 = new ExpertDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            f1.Show();
            f1.Visible = true;
            this.Hide();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            Expertacceptinterface f1 = new Expertacceptinterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }
    }
}
