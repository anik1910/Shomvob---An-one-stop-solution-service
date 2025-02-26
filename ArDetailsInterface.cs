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
    public partial class ArDetailsInterface : Form
    {
        public ArDetailsInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from RiderInfo";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                riderView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void ArDetailsInterface_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            // Add Button
            try
            {
                Con.Open();
                SqlCommand cmd = new SqlCommand("Insert into RiderInfo values('" + ridername.Text + "','" + email.Text + "','" + contactno.Text + "','" + password.Text + "')", Con);
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
                SqlCommand cmd = new SqlCommand("update RiderInfo set Email='" + email.Text + "', PhoneNo='" + contactno.Text + "', Password='" + password.Text + "' where RiderName='" + ridername.Text + "'", Con);
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
            if (ridername.Text == "")
            {
                MessageBox.Show("Enter the User name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM RiderInfo WHERE RiderName = '" + ridername.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@RiderName", ridername.Text);
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            RiderControlInterface f3 = new RiderControlInterface();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void riderView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ridername.Text = riderView.SelectedRows[0].Cells[0].Value.ToString();
            email.Text = riderView.SelectedRows[0].Cells[1].Value.ToString();
            contactno.Text = riderView.SelectedRows[0].Cells[2].Value.ToString();
            password.Text = riderView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            ridername.Text = "";
            email.Text = "";
            contactno.Text = "";
            password.Text = "";
        }
    }
}
