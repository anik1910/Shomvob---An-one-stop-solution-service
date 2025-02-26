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
    public partial class RiderPaymentBkash : Form
    {
        public RiderPaymentBkash()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");

        private void mobile1_Load(object sender, EventArgs e)
        {

        }

        private void mobile1_Load_1(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RiderPaymentBkash_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming conn is your SqlConnection object
                conn.Open();


                String ridername = Class1.ridername;
                String expertname = Class1.expertname;
                DateTime currentTime = DateTime.Now;

                // Provide the SqlConnection to the SqlCommand constructor
                SqlCommand sq1 = new SqlCommand("INSERT into BkashPayRider(RiderName, PayTime, BkashNumber, Pin, Amount, ExpertName) VALUES (@RiderName, @PayTime, @BkashNumber, @Pin, @Amount, @ExpertName)", conn);

                sq1.Parameters.AddWithValue("@RiderName", ridername);
                sq1.Parameters.AddWithValue("@ExpertName", expertname);
                sq1.Parameters.AddWithValue("@PayTime", currentTime);
                sq1.Parameters.AddWithValue("@BkashNumber", BkashNumber.Text);
                sq1.Parameters.AddWithValue("@Pin", Pin.Text);
                sq1.Parameters.AddWithValue("@Amount", Amount.Text);


                sq1.ExecuteNonQuery();

                UserInterface f1 = new UserInterface();
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
    }
}
