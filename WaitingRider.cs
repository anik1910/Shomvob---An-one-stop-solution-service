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
    public partial class WaitingRider : Form
    {
        private Timer timer;
        private int seconds;
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
        public WaitingRider()
        {
            InitializeComponent();

            // Initialize and configure the timer
            timer = new Timer();
            timer.Interval = 1000; // 1 second
            timer.Tick += Timer_Tick;

            // Set initial time (in seconds)
            seconds = 0;
        }

        private void WaitingRider_Load(object sender, EventArgs e)
        {
            // Start the timer when the form is loaded
            timer.Start();
        }
    }
}
