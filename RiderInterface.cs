﻿using System;
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
    public partial class RiderInterface : Form
    {
        public RiderInterface()
        {
            InitializeComponent();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            RiderDetails f1 = new RiderDetails();
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
            RiderAcceptInterface f1 = new RiderAcceptInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void RiderInterface_Load(object sender, EventArgs e)
        {

        }

        private void Fix_Click(object sender, EventArgs e)
        {
            ExpertMapinterface f1 = new ExpertMapinterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }
    }
}
