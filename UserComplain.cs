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
    public partial class UserComplain : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        public UserComplain()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                DateTime currentTime = DateTime.Now;
                SqlCommand sq1 = new SqlCommand("INSERT into UserComplain(UserName, Complain, ComplainAgainst, ComplainTime) VALUES (@UserName,@Complain, @ComplainAgainst, @ComplainTime)", Con);
                sq1.Parameters.AddWithValue("@UserName", Class1.username);
                sq1.Parameters.AddWithValue("@Complain", richTextBox1.Text);
                sq1.Parameters.AddWithValue("@ComplainAgainst", Class1.ridername);
                sq1.Parameters.AddWithValue("@ComplainTime", currentTime);
                sq1.ExecuteNonQuery();
                MessageBox.Show("Complain added successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
            finally
            {
                Con.Close();
            }
        }

        private void UserComplain_Load(object sender, EventArgs e)
        {

        }
    }
}
