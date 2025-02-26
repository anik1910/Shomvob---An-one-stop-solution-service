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
    public partial class UserHistoryInterface : Form
    {
        public UserHistoryInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from RideRequest where UserName='"+Class1.username+"'";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                userhistoryview.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            UserInterface f1 = new UserInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            UserPrivacyNPolicyInterface f1 = new UserPrivacyNPolicyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            //UserReferInterface f1 = new UserReferInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            //UserBalanceInterface f1 = new UserBalanceInterface();
            //f1.Show();
            //f1.Visible = true;
            //this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            UserDetails f1 = new UserDetails();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void UserHistoryInterface_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void userhistoryview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
