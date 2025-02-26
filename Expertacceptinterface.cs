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
    public partial class Expertacceptinterface : Form
    {
        public Expertacceptinterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select RiderName,RequestTime,Location,Vehicletype,Ammount from Fixing Where Acceptance=0";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ExpertView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ExpertInterface f1 = new ExpertInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void Expertacceptinterface_Load(object sender, EventArgs e)
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Accept";
            btn.Name = "Accept";
            btn.Text = "Accept";
            btn.UseColumnTextForButtonValue = true;
            ExpertView.Columns.Add(btn);
            populate();
        }

        private void FireServiceView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Assuming conn is your SqlConnection object
                Con.Open();


                String expertname = Class1.expertname;

                DateTime currentTime2 = DateTime.Now;

                // Provide the SqlConnection to the SqlCommand constructor
                SqlCommand sq1 = new SqlCommand("UPDATE Fixing SET [ExpertName] = @ExpertName, [AcceptTime] = @AcceptTime, Acceptance = @Acceptance WHERE RiderName= @RiderName", Con);
                sq1.Parameters.AddWithValue("@RiderName", Class1.ridername);
                sq1.Parameters.AddWithValue("@ExpertName", expertname);
                sq1.Parameters.AddWithValue("@AcceptTime", currentTime2);
                sq1.Parameters.AddWithValue("@Acceptance", 1);
                sq1.ExecuteNonQuery();

                RepairingExpert f1 = new RepairingExpert();
                f1.Show();
                f1.Visible = true;

                RepairingRider f2 = new RepairingRider();
                f2.Show();
                f1.Visible = true;

                WaitingRider f3 = Application.OpenForms.OfType<WaitingRider>().FirstOrDefault();
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
