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
    public partial class AfireserviceInterface : Form
    {
        public AfireserviceInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from FireServiceData";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                FireSView.DataSource = ds.Tables[0];
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

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void AfireserviceInterface_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into FireServiceData values('" + afnametb.Text + "','" + afaddresstb.Text + "','" + afcnotb.Text + "','" + afdtb.Text + "','" + afutb.Text + "')", Con);
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
                SqlCommand cmd = new SqlCommand("update FireServiceData set Address='" + afaddresstb.Text + "', ContactNo='" + afcnotb.Text + "', District='" + afdtb.Text + "',Upozila='" + afutb.Text + "' where FireStationName='" + afnametb.Text + "'", Con);
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
            if (afnametb.Text == "")
            {
                MessageBox.Show("Enter the Fire Station name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM FireServiceData WHERE FireStationName = '" + afnametb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@FireStationName", afnametb.Text);
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

        private void FireSView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            afnametb.Text = FireSView.SelectedRows[0].Cells[0].Value.ToString();
            afaddresstb.Text = FireSView.SelectedRows[0].Cells[1].Value.ToString();
            afcnotb.Text = FireSView.SelectedRows[0].Cells[2].Value.ToString();
            afdtb.Text = FireSView.SelectedRows[0].Cells[3].Value.ToString();
            afutb.Text = FireSView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            afnametb.Text = "";
            afaddresstb.Text = "";
            afcnotb.Text = "";
            afdtb.Text = "";
            afutb.Text = "";
        }
    }
}
