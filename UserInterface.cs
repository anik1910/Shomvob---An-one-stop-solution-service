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
    public partial class UserInterface : Form
    {
        public UserInterface()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            UserDetails f1 = new UserDetails();
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

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
           
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            MapInterfaceUser f1 = new MapInterfaceUser();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            EmergencyInterface f1 = new EmergencyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            MapInterfaceCNG f1 = new MapInterfaceCNG();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            MapInterfaceCar f1 = new MapInterfaceCar();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void UserInterface_Load(object sender, EventArgs e)
        {
            uname.Text = Class1.username;
        }

        private void uname_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click_1(object sender, EventArgs e)
        {
            MapInterfaceUser f1 = new MapInterfaceUser();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton3_Click_1(object sender, EventArgs e)
        {
            MapInterfaceCar f1 = new MapInterfaceCar();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton2_Click_1(object sender, EventArgs e)
        {
            MapInterfaceCNG f1 = new MapInterfaceCNG();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton4_Click_1(object sender, EventArgs e)
        {
            EmergencyInterface f1 = new EmergencyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

        }
    }
}
