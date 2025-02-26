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
    public partial class ArHistoryInterface : Form
    {
        public ArHistoryInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from RideRequest";
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
                String Myquery = "select * from Fixing";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                rehistroy.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderControlInterface f1 = new RiderControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void ArAccountInterface_Load(object sender, EventArgs e)
        {
            populate();
            epopulate();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String Myquery = "select * from RideRequest where RiderName='" + username.Text + "'";
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

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                String Myquery = "select * from Fixing where RiderName='" + username1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                rehistroy.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            epopulate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            populate();
        }
    }
}
