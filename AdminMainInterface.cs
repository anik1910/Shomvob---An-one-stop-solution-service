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
    public partial class AdminMainInterface : Form
    {
        public AdminMainInterface()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            UserControlInterface f1 = new UserControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton210_Click(object sender, EventArgs e)
        {
            RiderControlInterface f1 = new RiderControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton215_Click(object sender, EventArgs e)
        {
            ExpertControlInterface f1 = new ExpertControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton220_Click(object sender, EventArgs e)
        {
            //AdminControlnterface f1 = new AdminControlnterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            ADataControlInterface f1 = new ADataControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            AdminAccountInterface f1 = new AdminAccountInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton214_Click(object sender, EventArgs e)
        {
            AdminBalanceInterface f1 = new AdminBalanceInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton219_Click(object sender, EventArgs e)
        {
            ASOS f1 = new ASOS();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {
            ADataControlInterface f1 = new ADataControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }
    }
}
