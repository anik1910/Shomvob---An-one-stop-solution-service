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
    public partial class AhospitalInterface : Form
    {
        public AhospitalInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from HospitalData";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                HospitalView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            AemergencyInterface f1 = new AemergencyInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void AhospitalInterface_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into HospitalData values('" + ahnametb.Text + "','" + ahaddresstb.Text + "','" + ahcnotb.Text + "','" + ahdtb.Text + "','" + ahttb.Text + "')", Con);
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
                SqlCommand cmd = new SqlCommand("update HospitalData set Address='" + ahaddresstb.Text + "', ContactNo='" + ahcnotb.Text + "', District='" + ahdtb.Text + "',Thana='" + ahttb.Text + "' where HospitalName='" + ahnametb.Text + "'", Con);
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
            if (ahnametb.Text == "")
            {
                MessageBox.Show("Enter the Hospital name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM HospitalData WHERE HospitalName = '" + ahnametb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@HospitalName", ahnametb.Text);
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

        private void HospitalView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ahnametb.Text = HospitalView.SelectedRows[0].Cells[0].Value.ToString();
            ahaddresstb.Text = HospitalView.SelectedRows[0].Cells[1].Value.ToString();
            ahcnotb.Text = HospitalView.SelectedRows[0].Cells[2].Value.ToString();
            ahdtb.Text = HospitalView.SelectedRows[0].Cells[3].Value.ToString();
            ahttb.Text = HospitalView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            ahnametb.Text = "";
            ahaddresstb.Text = "";
            ahcnotb.Text = "";
            ahdtb.Text = "";
            ahttb.Text = "";
        }
    }
}
