using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Shomvob
{
    public partial class waitingTimerUser : Form
    {
        private Timer timer;
        private int seconds;
        public waitingTimerUser()
        {
            InitializeComponent();

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;

            // Set initial time (in seconds)
            seconds = 0;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Check if elapsed time is less than 2 minutes
            if (seconds < 120)
            {
                // Update the label with the remaining time
                int remainingSeconds = 120 - seconds;
                label4.Text = $"{remainingSeconds / 60:D2}:{remainingSeconds % 60:D2}";

                // Increment the seconds
                seconds++;
            }
            else
            {
                // Stop the timer when 2 minutes is reached
                timer.Stop();
                label4.Text = "2:00";
            }
        }

        private void waitingTimerUser_Load(object sender, EventArgs e)
        {
            // Start the timer when the form is loaded
            timer.Start();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            //this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
