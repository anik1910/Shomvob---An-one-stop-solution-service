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
    public partial class RiderComplain : Form
    {
        public RiderComplain()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");

        private void RiderComplain_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                DateTime currentTime = DateTime.Now;
                SqlCommand sq1 = new SqlCommand("INSERT into RiderComplain(RiderName, Complain, ComplainAgainst, ComplainTime) VALUES (@RiderName,@Complain, @ComplainAgainst, @ComplainTime)", Con);
                sq1.Parameters.AddWithValue("@RiderName", Class1.ridername);
                sq1.Parameters.AddWithValue("@Complain", complain.Text);
                sq1.Parameters.AddWithValue("@ComplainAgainst", Class1.username);
                sq1.Parameters.AddWithValue("@ComplainTime", currentTime);
                sq1.ExecuteNonQuery();
                MessageBox.Show("Complain added successfully");
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Con.Close();
            }
            
        }
    }
}
