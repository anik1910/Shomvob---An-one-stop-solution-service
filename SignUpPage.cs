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
    public partial class SignUpPage : Form
    {
        public SignUpPage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SignUpPage_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {
            LoginPage f1 = new LoginPage();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string phoneNumber = PhoneNo.Text;
            string email = Email.Text;
            string password = Password.Text;
            if (Isvalidphoneno(phoneNumber) && Isvalidemail(email))//&& Isvalidpassword(password))
            {
                if (UserRadio.Checked == true)
                {

                    try
                    {
                        con.Open();
                        SqlCommand sq1 = new SqlCommand("INSERT INTO UserInfo (UserName, Email, PhoneNo, Password) VALUES (@UName, @Email, @PhoneNo, @Password)", con);
                        sq1.Parameters.AddWithValue("@UName", UName.Text);
                        sq1.Parameters.AddWithValue("@Email", Email.Text);
                        sq1.Parameters.AddWithValue("@PhoneNo", PhoneNo.Text);
                        sq1.Parameters.AddWithValue("@Password", Password.Text);
                        sq1.ExecuteNonQuery();
                        MessageBox.Show("Sign up complete");
                        UserInterface f1 = new UserInterface();
                        f1.Show();
                        f1.Visible = true;
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Duplicate Username. Please, try with an unique name");
                    }
                    finally
                    {
                        con.Close();
                    }

                }
                else if (RiderRadio.Checked == true)
                {
                    try
                    {
                        con.Open();
                        SqlCommand sq1 = new SqlCommand("INSERT INTO RiderInfo (RiderName, Email, PhoneNo, Password) VALUES (@UName, @Email, @PhoneNo, @Password)", con);
                        sq1.Parameters.AddWithValue("@UName", UName.Text);
                        sq1.Parameters.AddWithValue("@Email", Email.Text);
                        sq1.Parameters.AddWithValue("@PhoneNo", PhoneNo.Text);
                        sq1.Parameters.AddWithValue("@Password", Password.Text);
                        sq1.ExecuteNonQuery();
                        MessageBox.Show("Sign up complete");
                        RiderInterface f1 = new RiderInterface();
                        f1.Show();
                        f1.Visible = true;
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Duplicate Username. Please, try with an unique name");
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else if (ExpertRadio.Checked == true)
                {
                    try
                    {
                        con.Open();
                        SqlCommand sq1 = new SqlCommand("INSERT INTO ExpertInfo (ExpertName, Email, PhoneNo, Password) VALUES (@UName, @Email, @PhoneNo, @Password)", con);
                        sq1.Parameters.AddWithValue("@UName", UName.Text);
                        sq1.Parameters.AddWithValue("@Email", Email.Text);
                        sq1.Parameters.AddWithValue("@PhoneNo", PhoneNo.Text);
                        sq1.Parameters.AddWithValue("@Password", Password.Text);
                        sq1.ExecuteNonQuery();
                        MessageBox.Show("Sign up complete");
                        ExpertInterface f1 = new ExpertInterface();
                        f1.Show();
                        f1.Visible = true;
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Duplicate Username. Please, try with an unique name");

                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Warning! Please, Select one for SignUp.");
                }
            }
            else
            {
                MessageBox.Show("Error: please make sure the Email, Phone and Password are valid");
            }
        }
        private bool Isvalidphoneno(string phoneNumber)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNumber, @"^01\d{9}$");
        }

        private bool Isvalidemail(string email)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z]+\.com$");
        }
        /*private bool Isvalidpassword(string password)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$");
        }*/

        private void UserRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RiderRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ExpertRadio_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {
            LoginPage f3 = new LoginPage();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            MainPage f3 = new MainPage();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }
    }
}
