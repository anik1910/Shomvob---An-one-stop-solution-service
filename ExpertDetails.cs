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
    public partial class ExpertDetails : Form
    {
        public ExpertDetails()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
            {
                connection.Open();

                string query = $"SELECT ExpertName, Email, PhoneNo, Password FROM ExpertInfo WHERE ExpertName = '{name.Text}'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            name.Text = $"{reader["ExpertName"].ToString()}";
                            email.Text = $"{reader["Email"].ToString()}";
                            phone.Text = $"{reader["PhoneNo"].ToString()}";
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
            ExpertInterface f1 = new ExpertInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            ExpertInterface f1 = new ExpertInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //ExpertBalanceInterface f1 = new ExpertBalanceInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            ExpertHistoryInterface f1 = new ExpertHistoryInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            //ExpertReferInterface f1 = new ExpertReferInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            ExpertPrivacyNPolicyInterface f1 = new ExpertPrivacyNPolicyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the expert detals interface.");
        }

        private void ExpertDetails_Load(object sender, EventArgs e)
        {
            name.Text = Class1.expertname;
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update ExpertInfo set Email='" + email.Text + "', PhoneNo='" + phone.Text + "', Password='" + password.Text + "' where ExpertName='" + name.Text + "'", Con);
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
    }
}
