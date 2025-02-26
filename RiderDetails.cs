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
    public partial class RiderDetails : Form
    {
        public RiderDetails()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = $"SELECT RiderName, Email, PhoneNo, Vehicle, Password FROM RiderInfo WHERE RiderName = '{name.Text}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name.Text = $"{reader["RiderName"].ToString()}";
                            email.Text = $"{reader["Email"].ToString()}";
                            phone.Text = $"{reader["PhoneNo"].ToString()}";
                            vehicle.Text = $"{reader["Vehicle"].ToString()}";
                            password.Text = $"{reader["Password"].ToString()}";
                        }
                        else
                        {
                            name.Text = "User not found.";
                            email.Text = "";
                            phone.Text = "";
                            password.Text = "";
                        }
                    }
                }
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderInterface f1 = new RiderInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            RiderHistoryInterface f2 = new RiderHistoryInterface();
            f2.Show();
            f2.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //RiderBalanceInterface f3 = new RiderBalanceInterface();
            //f3.Show();
            //f3.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            //RiderReferInterface f4 = new RiderReferInterface();
            //f4.Show();
            //f4.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            RiderPrivacyNPolicyInterface f5 = new RiderPrivacyNPolicyInterface();
            f5.Show();
            f5.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the ridr details interface.");
        }

        private void RiderDetails_Load(object sender, EventArgs e)
        {
            name.Text = Class1.ridername;
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update RiderInfo set Email='" + email.Text + "', PhoneNo='" + phone.Text + "',Vehicle='"+vehicle.Text+"', Password='" + password.Text + "' where RiderName='" + name.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated ");
                Con.Close();
                //populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                //populate();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
