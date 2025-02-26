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
    public partial class ASOS : Form
    {
        public ASOS()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from SOS";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                usersos.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        void rpopulate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from RSOS";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                ridersos.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AdminMainInterface f1 = new AdminMainInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void ASOS_Load(object sender, EventArgs e)
        {
            populate();
            rpopulate();
        }

        private void usersrh_Click(object sender, EventArgs e)
        {
            
        }

        private void userrfh_Click(object sender, EventArgs e)
        {
            
        }

        private void ridersrh_Click(object sender, EventArgs e)
        {
            
        }

        private void usersos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
