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
    public partial class MapInterfaceCar : Form
    {
        public MapInterfaceCar()
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


                String userName = Class1.username;
                DateTime currentTime = DateTime.Now;

                // Provide the SqlConnection to the SqlCommand constructor
                SqlCommand sq1 = new SqlCommand("INSERT into RideRequest(UserName, RequestTime, Vehicle, Fromm, Too,Ammount,Acceptance) VALUES (@userName, @RequestTime, @Vehicle, @Fromm, @Too,@Ammount,@Acceptance)", conn);

                sq1.Parameters.AddWithValue("@UserName", userName);
                sq1.Parameters.AddWithValue("@RequestTime", currentTime);
                sq1.Parameters.AddWithValue("@Vehicle", "Car");
                sq1.Parameters.AddWithValue("@Fromm", fromm.Text);
                sq1.Parameters.AddWithValue("@Too", too.Text);
                sq1.Parameters.AddWithValue("@Ammount", ammount.Text);
                sq1.Parameters.AddWithValue("@Acceptance", 0);

                sq1.ExecuteNonQuery();

                waitingTimerUser f1 = new waitingTimerUser();
                f1.Show();
                f1.Visible = true;
                this.Hide();

                UserInterface f2 = new UserInterface();
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            UserInterface f1 = new UserInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void MapInterfaceCar_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }
    }
}
