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
    public partial class AtrainInterface : Form
    {
        public AtrainInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ADataControlInterface f3 = new ADataControlInterface();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void tnametb_OnValueChanged(object sender, EventArgs e)
        {

        }
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from TrainInfoTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                TrainView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into TrainInfoTbl values('" + tnametb.Text + "','" + tfromtb.Text + "','" + ttotb.Text + "','" + tdistancetb.Text + "','" + ttktb.Text + "')", Con);
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
                SqlCommand cmd = new SqlCommand("update TrainInfoTbl set Fromm='" + tfromtb.Text + "', Too='" + ttotb.Text + "', Distance='" + tdistancetb.Text + "',Fare='" + ttktb.Text + "' where TrainName='" + tnametb.Text + "'", Con);
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
            if (tnametb.Text == "")
            {
                MessageBox.Show("Enter the Train name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM TrainInfoTbl WHERE TrainName = '" + tnametb.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@TrainName", tnametb.Text);
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
            tnametb.Text = TrainView.SelectedRows[0].Cells[0].Value.ToString();
            tfromtb.Text = TrainView.SelectedRows[0].Cells[1].Value.ToString();
            ttotb.Text = TrainView.SelectedRows[0].Cells[2].Value.ToString();
            tdistancetb.Text = TrainView.SelectedRows[0].Cells[3].Value.ToString();
            ttktb.Text = TrainView.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void AtrainInterface_Load(object sender, EventArgs e)
        {

        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            tnametb.Text = "";
            tfromtb.Text = "";
            ttotb.Text = "";
            tdistancetb.Text = "";
            ttktb.Text = "";
            populate();
        }
    }
}
