﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Shomvob
{
    public partial class UserSOSMassage : Form
    {
        public UserSOSMassage()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");


        private void UserSOSMassage_Load(object sender, EventArgs e)
        {

        }

        private void SOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (sos1.Checked == true)
            {
                try
                {
                    con.Open();
                    DateTime currentTime = DateTime.Now;
                    SqlCommand sq1 = new SqlCommand("INSERT INTO SOS(UserName,SendTime,RiderName,SOSMessage)VALUES(@UserName,@SendTime,@RiderName,@SOSMessage)", con);
                    sq1.Parameters.AddWithValue("@UserName", "Victim: " + Class1.username);
                    sq1.Parameters.AddWithValue("@SendTime", currentTime);
                    sq1.Parameters.AddWithValue("@RiderName", "Suspect: " + Class1.ridername);
                    sq1.Parameters.AddWithValue("@SOSMessage", sos1.Text);
                    sq1.ExecuteNonQuery();
                    MessageBox.Show("Please, wait patiently");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else if (sos2.Checked == true)
            {
                try
                {
                    con.Open();
                    DateTime currentTime = DateTime.Now;
                    SqlCommand sq1 = new SqlCommand("INSERT INTO SOS(UserName,SendTime,RiderName,SOSMessage)VALUES(@UserName,@SendTime,@RiderName,@SOSMessage)", con);
                    sq1.Parameters.AddWithValue("@UserName", "Victim: " + Class1.username);
                    sq1.Parameters.AddWithValue("@SendTime", currentTime);
                    sq1.Parameters.AddWithValue("@RiderName", "Suspect: " + Class1.ridername);
                    sq1.Parameters.AddWithValue("@SOSMessage", sos2.Text);
                    sq1.ExecuteNonQuery();
                    MessageBox.Show("Please, wait patiently");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else if (sos3.Checked == true)
            {
                try
                {
                    con.Open();
                    DateTime currentTime = DateTime.Now;
                    SqlCommand sq1 = new SqlCommand("INSERT INTO SOS(UserName,SendTime,RiderName,SOSMessage)VALUES(@UserName,@SendTime,@RiderName,@SOSMessage)", con);
                    sq1.Parameters.AddWithValue("@UserName", "Victim: " + Class1.username);
                    sq1.Parameters.AddWithValue("@SendTime", currentTime);
                    sq1.Parameters.AddWithValue("@RiderName", "Suspect: " + Class1.ridername);
                    sq1.Parameters.AddWithValue("@SOSMessage", sos3.Text);
                    sq1.ExecuteNonQuery();
                    MessageBox.Show("Please, wait patiently");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
            else if (sos4.Checked == true)
            {
                try
                {
                    con.Open();
                    DateTime currentTime = DateTime.Now;
                    SqlCommand sq1 = new SqlCommand("INSERT INTO SOS(UserName,SendTime,RiderName,SOSMessage)VALUES(@UserName,@SendTime,@RiderName,@SOSMessage)", con);
                    sq1.Parameters.AddWithValue("@UserName", "Victim: " + Class1.username);
                    sq1.Parameters.AddWithValue("@SendTime", currentTime);
                    sq1.Parameters.AddWithValue("@RiderName", "Suspect: " + Class1.ridername);
                    sq1.Parameters.AddWithValue("@SOSMessage", sos4.Text);
                    sq1.ExecuteNonQuery();
                    MessageBox.Show("Please, wait patiently");
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
