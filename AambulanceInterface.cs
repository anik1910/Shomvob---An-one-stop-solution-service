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
    public partial class AambulanceInterface : Form
    {
        public AambulanceInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from AmbulanceData";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                AmbulanceView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AemergencyInterface f3 = new AemergencyInterface();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into AmbulanceData values('" + danametb.Text + "','" + danotb.Text + "','" + dacnotb.Text + "','" + dadtb.Text + "','" + dattb.Text + "')", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successful");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate();
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update AmbulanceData set DriverName='" + danametb.Text + "', ContactNo='" + dacnotb.Text + "', District='" + dadtb.Text + "',Thana='" + dattb.Text + "' where AmbulanceNo='" + danotb.Text + "'", Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Successfully updated ");
                Con.Close();
                populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Delete Button
            if (danotb.Text == "")
            {
                MessageBox.Show("Enter the Bus name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM AmbulanceData WHERE AmbulanceNo = '" + danotb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@AmbulanceNo", danotb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                    populate();
                }
            }
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void BusView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            danametb.Text = AmbulanceView.SelectedRows[0].Cells[0].Value.ToString();
            danotb.Text = AmbulanceView.SelectedRows[0].Cells[1].Value.ToString();
            dacnotb.Text = AmbulanceView.SelectedRows[0].Cells[2].Value.ToString();
            dadtb.Text = AmbulanceView.SelectedRows[0].Cells[3].Value.ToString();
            dattb.Text = AmbulanceView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void danametb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void dadtb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AambulanceInterface_Load(object sender, EventArgs e)
        {

        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            danametb.Text = "";
            danotb.Text = "";
            dacnotb.Text = "";
            dadtb.Text = "";
            dattb.Text = "";
            populate();
        }
    }
}
