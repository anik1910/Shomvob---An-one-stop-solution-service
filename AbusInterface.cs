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
    public partial class AbusInterface : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");

        public AbusInterface()
        {
            InitializeComponent();
        }

        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from BusInfoTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                BusView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into BusInfoTbl values('" + bnametb.Text + "','" + bfromtb.Text + "','" + btotb.Text + "','" + bdistancetb.Text + "','"+ btktb.Text+"')", Con);
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
               // populate();
            }
        }

        /*private void BusView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = BusView.Rows[e.RowIndex];
                bnametb.Text = row.Cells["BusName"].Value.ToString();
                bfromtb.Text = row.Cells["Fromm"].Value.ToString();
                btotb.Text = row.Cells["Too"].Value.ToString();
                bdistancetb.Text = row.Cells["Distance"].Value.ToString();
                btktb.Text = row.Cells["Fare"].Value.ToString();
            }
        }*/

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            // Update data
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE BusInfoTbl SET [Fromm] = @Fromm, [Too] = @Too, Distance = @Distance,Fare=@Fare WHERE BusName = @BusName", Con);
                cmd.Parameters.AddWithValue("@BusName", bnametb.Text);
                cmd.Parameters.AddWithValue("@Fromm", bfromtb.Text);
                cmd.Parameters.AddWithValue("@Too", btotb.Text);
                cmd.Parameters.AddWithValue("@Distance", bdistancetb.Text);
                cmd.Parameters.AddWithValue("@Fare", btktb.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                populate(); // Refresh the data
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            // Delete Button
            if (bnametb.Text == "")
            {
                MessageBox.Show("Enter the Bus name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM BusInfoTbl WHERE BusName = '" + bnametb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@BusName", bnametb.Text);
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
                SqlCommand cmd = new SqlCommand("update BusInfoTbl set Fromm='"+bfromtb.Text +"', Too='"+btotb.Text+"', Distance='"+bdistancetb.Text+"',Fare='"+btktb.Text+"' where BusName='"+bnametb.Text+"'", Con);
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
        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            // Refresh Button
            populate();
        }

        private void AbusInterface_Load(object sender, EventArgs e)
        {
            populate();
        }
        private void BusView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            bnametb.Text = BusView.SelectedRows[0].Cells[0].Value.ToString();
            bfromtb.Text = BusView.SelectedRows[0].Cells[1].Value.ToString();
            btotb.Text = BusView.SelectedRows[0].Cells[2].Value.ToString();
            bdistancetb.Text = BusView.SelectedRows[0].Cells[3].Value.ToString();
            btktb.Text = BusView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            ADataControlInterface f3 = new ADataControlInterface();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void btktb_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            bnametb.Text = "";
            bfromtb.Text = "";
            btotb.Text = "";
            bdistancetb.Text = "";
            btktb.Text = "";
        }
    }
}
