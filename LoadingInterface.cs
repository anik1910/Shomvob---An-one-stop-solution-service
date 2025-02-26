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
    public partial class LoadingInterface : Form
    {
        public LoadingInterface()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel.Width += 3;
            if(panel.Width>321)
            {
                timer1.Stop();
                MainPage f1 = new MainPage();
                f1.Show();
                this.Hide();
            }
        }
    }
}
