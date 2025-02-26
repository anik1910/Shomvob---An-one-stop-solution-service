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
    public partial class ApoliceInterface : Form
    {
        public ApoliceInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from PoliceData";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                PoliceView.DataSource = ds.Tables[0];
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

        private void apnotb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            apnametb.Text = "";
            apaddresstb.Text = "";
            apcnotb.Text = "";
            apdtb.Text = "";
            aputb.Text = "";
        }

        private void apaddresstb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void apnametb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void BusView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            apnametb.Text = PoliceView.SelectedRows[0].Cells[0].Value.ToString();
            apaddresstb.Text = PoliceView.SelectedRows[0].Cells[1].Value.ToString();
            apcnotb.Text = PoliceView.SelectedRows[0].Cells[2].Value.ToString();
            apdtb.Text = PoliceView.SelectedRows[0].Cells[3].Value.ToString();
            aputb.Text = PoliceView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Delete Button
            if (apnametb.Text == "")
            {
                MessageBox.Show("Enter the Police Station name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM PoliceData WHERE PoliceStationName = '" + apnametb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@PoliceStationName", apnametb.Text);
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

        private void EditBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("update PoliceData set Address='" + apaddresstb.Text + "', ContactNo='" + apcnotb.Text + "', District='" + apdtb.Text + "',Upozila='" + aputb.Text + "' where PoliceStationName='" + apnametb.Text + "'", Con);
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

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into PoliceData values('" + apnametb.Text + "','" + apaddresstb.Text + "','" + apcnotb.Text + "','" + apdtb.Text + "','" + aputb.Text + "')", Con);
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void ApoliceInterface_Load(object sender, EventArgs e)
        {
            populate();
        }
    }
}
