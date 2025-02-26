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
    public partial class RiderAcceptInterface : Form
    {
        public RiderAcceptInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select UserName,RequestTime,Fromm,Too,Ammount from RideRequest Where Acceptance=0";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                RideracceptView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderInterface f1 = new RiderInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void rideracceptinterface_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Accept";
            btn.Name = "Accept";
            btn.Text = "Accept";
            btn.UseColumnTextForButtonValue = true;
            RideracceptView.Columns.Add(btn);
            populate();
        }

        private void FireServiceView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (RideracceptView.Columns[e.ColumnIndex].Name == "Accept")
            {
                try
                {
                    // Assuming conn is your SqlConnection object
                    Con.Open();


                    String riderName = Class1.ridername;
                    
                    DateTime currentTime2 = DateTime.Now;

                    // Provide the SqlConnection to the SqlCommand constructor
                    SqlCommand sq1 = new SqlCommand("UPDATE RideRequest SET [RiderName] = @RiderName, [AcceptTime] = @AcceptTime, Acceptance = @Acceptance WHERE UserName= @UserName", Con);
                    sq1.Parameters.AddWithValue("@UserName", Class1.username);
                    sq1.Parameters.AddWithValue("@RiderName", riderName);
                    sq1.Parameters.AddWithValue("@AcceptTime", currentTime2);
                    sq1.Parameters.AddWithValue("@Acceptance", 1);
                    sq1.ExecuteNonQuery();

                    RunningUser f1 = new RunningUser();
                    f1.Show();
                    f1.Visible = true;

                    RunningRider f2 = new RunningRider();
                    f2.Show();
                    f1.Visible = true;

                    // Assuming that RunningRider is the correct form to hide
                    waitingTimerUser f3 = Application.OpenForms.OfType<waitingTimerUser>().FirstOrDefault();
                    if (f3 != null)
                    {
                        f3.Hide();
                        f3.Visible = false;
                    }

                    this.Hide();
                }
                catch (Exception ex)
                {
                    // Handle exceptions appropriately, log or show an error message
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    // Ensure the connection is closed, whether an exception occurs or not
                    Con.Close();
                }
            }
        }
    }
}
