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
    public partial class UserPaymentBkash : Form
    {
        public UserPaymentBkash()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");

        private void button1_Click(object sender, EventArgs e)
        {
            UserPaymentCard f1 = new UserPaymentCard();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void mobile1_Load(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                // Assuming conn is your SqlConnection object
                conn.Open();


                String ridername = Class1.ridername;
                String username = Class1.username;
                DateTime currentTime = DateTime.Now;

                // Provide the SqlConnection to the SqlCommand constructor
                SqlCommand sq1 = new SqlCommand("INSERT into BkashPayUser(UserName, PayTime, BkashNumber, Pin, Amount, RiderName) VALUES (@UserName, @PayTime, @BkashNumber, @Pin, @Amount, @RiderName)", conn);

                sq1.Parameters.AddWithValue("@RiderName", ridername);
                sq1.Parameters.AddWithValue("@UserName", username);
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Amount_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Pin_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void BkashNumber_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void UserPaymentBkash_Load(object sender, EventArgs e)
        {

        }
    }
}
