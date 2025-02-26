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
    public partial class AdminBalanceInterface : Form
    {
        public AdminBalanceInterface()
        {
            InitializeComponent();
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
