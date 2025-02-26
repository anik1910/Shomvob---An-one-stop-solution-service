using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Shomvob
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                if (UserRadio.Checked == true)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                    {
                        conn.Open();
                        String Name, Password;
                        Name = name.Text;
                        Password = password.Text;
                        
                        
                        String querry = "SELECT * FROM UserInfo WHERE UserName='" + name.Text + "' AND Password='" + password.Text + "'";

                        using (SqlDataAdapter sda = new SqlDataAdapter(querry, conn))
                        {
                            DataTable dttable = new DataTable();
                            sda.Fill(dttable);

                            if (dttable.Rows.Count > 0)
                            {
                                Name = name.Text;
                                Password = password.Text;
                                Class1.username = dttable.Rows[0]["UserName"].ToString();
                                //name.Text = Class1.username;
                                UserInterface f1 = new UserInterface();
                                f1.Show();
                                f1.Visible = true;
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Log In Details");
                            }
                        }
                    }
                }
                else if (RiderRadio.Checked == true)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                    {
                        conn.Open();
                        String Name, Password;
                        Name = name.Text;
                        Password = password.Text;
                        String querry = "SELECT * FROM RiderInfo WHERE RiderName='" + name.Text + "' AND Password='" + password.Text + "'";

                        using (SqlDataAdapter sda = new SqlDataAdapter(querry, conn))
                        {
                            DataTable dttable = new DataTable();
                            sda.Fill(dttable);

                            if (dttable.Rows.Count > 0)
                            {
                                Name = name.Text;
                                Password = password.Text;
                                Class1.ridername = dttable.Rows[0]["RiderName"].ToString();
                                Class1.vehicle = dttable.Rows[0]["Vehicle"].ToString();
                                RiderInterface f1 = new RiderInterface();
                                f1.Show();
                                f1.Visible = true;
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Log In Details");
                            }
                        }
                    }
                }
                else if (ExpertRadio.Checked == true)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                    {
                        conn.Open();
                        String Name, Password;
                        Name = name.Text;
                        Password = password.Text;
                        String querry = "SELECT * FROM ExpertInfo WHERE ExpertName='" + name.Text + "' AND Password='" + password.Text + "'";

                        using (SqlDataAdapter sda = new SqlDataAdapter(querry, conn))
                        {
                            DataTable dttable = new DataTable();
                            sda.Fill(dttable);

                            if (dttable.Rows.Count > 0)
                            {
                                Name = name.Text;
                                Password = password.Text;
                                Class1.expertname = dttable.Rows[0]["ExpertName"].ToString();
                                ExpertInterface f1 = new ExpertInterface();
                                f1.Show();
                                f1.Visible = true;
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Log In Details");
                            }
                        }
                    }
                }
                else
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                    {
                        conn.Open();
                        String Name, Password;
                        Name = name.Text;
                        Password = password.Text;
                        String querry = "SELECT * FROM Admin WHERE UserName='" + name.Text + "' AND Password='" + password.Text + "'";

                        using (SqlDataAdapter sda = new SqlDataAdapter(querry, conn))
                        {
                            DataTable dttable = new DataTable();
                            sda.Fill(dttable);

                            if (dttable.Rows.Count > 0)
                            {
                                Name = name.Text;
                                Password = password.Text;
                                AdminMainInterface f1 = new AdminMainInterface();
                                f1.Show();
                                f1.Visible = true;
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Invalid Log In Details");
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void ShowPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(ShowPasswordCheckBox.Checked == false)
            {
                password.isPassword = true;
            }
            else
            {
                password.isPassword = false;
            }
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            name.Text = "";
            password.Text = "";
        }

        private void UserRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void RiderRadio_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void ExpertRadio_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MainPage f3 = new MainPage();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
