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
    public partial class ExpertHistoryInterface : Form
    {
        public ExpertHistoryInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from Fixing where ExpertName='" + Class1.expertname + "'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                History.DataSource = ds.Tables[0];
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

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            //ExpertPrivacyNPolicyInterface f1 = new ExpertPrivacyNPolicyInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            //ExpertReferInterface f1 = new ExpertReferInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Warning! You are in the expert history interface.");
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //ExpertBalanceInterface f1 = new ExpertBalanceInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            //ExpertDetails f1 = new ExpertDetails();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton25_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton27_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click_1(object sender, EventArgs e)
        {
            ExpertDetails f1 = new ExpertDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton28_Click_1(object sender, EventArgs e)
        {
            ExpertPrivacyNPolicyInterface f1 = new ExpertPrivacyNPolicyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void ExpertHistoryInterface_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
