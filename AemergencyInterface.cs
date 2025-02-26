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
    public partial class AemergencyInterface : Form
    {
        public AemergencyInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            AambulanceInterface f1 = new AambulanceInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            AhospitalInterface f1 = new AhospitalInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            ApoliceInterface f1 = new ApoliceInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton219_Click(object sender, EventArgs e)
        {
            AfireserviceInterface f1 = new AfireserviceInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            //AsosInterface f1 = new AsosInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            ADataControlInterface f1 = new ADataControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();

        }

        private void AemergencyInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
