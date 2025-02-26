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
    public partial class RiderHistoryInterface : Form
    {
        public RiderHistoryInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from RideRequest where RiderName='" + Class1.ridername + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ruhistory.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void epopulate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from Fixing where RiderName='" + Class1.ridername + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                rehistory.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            RiderDetails f1 = new RiderDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //RiderBalanceInterface f1 = new RiderBalanceInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the rider history interface.");
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            //RiderReferInterface f1 = new RiderReferInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            RiderPrivacyNPolicyInterface f1 = new RiderPrivacyNPolicyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderInterface f1 = new RiderInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void RiderHistoryInterface_Load(object sender, EventArgs e)
        {
            populate();
            epopulate();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
