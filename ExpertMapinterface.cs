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
    public partial class ExpertMapinterface : Form
    {
        public ExpertMapinterface()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");

        private void AddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming conn is your SqlConnection object
                conn.Open();


                String ridername = Class1.ridername;
                DateTime currentTime = DateTime.Now;

                // Provide the SqlConnection to the SqlCommand constructor
                SqlCommand sq1 = new SqlCommand("INSERT into Fixing(RiderName, RequestTime, Vehicletype, Location, Ammount, Acceptance) VALUES (@ridername, @RequestTime, @Vehicletype, @Location, @Ammount, @Acceptance)", conn);

                sq1.Parameters.AddWithValue("@RiderName", ridername);
                sq1.Parameters.AddWithValue("@RequestTime", currentTime);
                sq1.Parameters.AddWithValue("@Vehicletype", vehicle.Text);
                sq1.Parameters.AddWithValue("@Location", location.Text);
                sq1.Parameters.AddWithValue("@Ammount", ammount.Text);
                sq1.Parameters.AddWithValue("@Acceptance", 0);

                sq1.ExecuteNonQuery();

                WaitingRider f1 = new WaitingRider();
                f1.Show();
                f1.Visible = true;
                this.Hide();

                RiderInterface f2 = new RiderInterface();
                f2.Show();
                f2.Visible = true;
            }
            catch (Exception ex)
            {
                // Handle exceptions appropriately, log or show an error message
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Ensure the connection is closed, whether an exception occurs or not
                conn.Close();
            }
        }

        private void ExpertMapinterface_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderInterface f1 = new RiderInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
