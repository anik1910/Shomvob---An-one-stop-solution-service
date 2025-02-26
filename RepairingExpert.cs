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
    public partial class RepairingExpert : Form
    {
        private Timer timer;
        private int elapsedTimeInSeconds;

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                // Modify the SQL query to retrieve only accepted rows


                String Myquery = "select RiderName, Location, Vehicletype, RequestTime, AcceptTime from Fixing where Acceptance = 1";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                gunaDataGridView1.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public RepairingExpert()
        {
            InitializeComponent();

            // Initialize the timer
            timer = new Timer();
            timer.Interval = 1000; // Interval is in milliseconds (1000ms = 1 second)
            timer.Tick += Timer_Tick;

            // Set initial time
            elapsedTimeInSeconds = 0;
            UpdateLabel();
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update elapsed time and update the label
            elapsedTimeInSeconds++;
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            // Format the time and update the label
            TimeSpan time = TimeSpan.FromSeconds(elapsedTimeInSeconds);
            label2.Text = time.ToString(@"hh\:mm\:ss");
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void RepairingExpert_Load(object sender, EventArgs e)
        {
            // Start the timer when the form loads
            timer.Start();
            populate();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
            }
            else
            {
                timer.Start();
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {

        }
    }
}
