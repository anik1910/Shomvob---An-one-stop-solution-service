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
    public partial class AuHelpReqInterface : Form
    {
        public AuHelpReqInterface()
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
            UserControlInterface f1 = new UserControlInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void AuHelpReqInterface_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void userhistoryview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            username.Text = userhistoryview.SelectedRows[0].Cells[0].Value.ToString();
        }
    }
}
