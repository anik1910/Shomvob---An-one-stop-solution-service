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
    public partial class AeDetailsInterface : Form
    {
        public AeDetailsInterface()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from ExpertInfo";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                expertView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void expertView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            expertname.Text = expertView.SelectedRows[0].Cells[0].Value.ToString();
            email.Text = expertView.SelectedRows[0].Cells[1].Value.ToString();
            contactno.Text = expertView.SelectedRows[0].Cells[2].Value.ToString();
            password.Text = expertView.SelectedRows[0].Cells[3].Value.ToString();
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Delete Button
            if (expertname.Text == "")
            {
                MessageBox.Show("Enter the Expert name");
            }
            else
            {
                try
                {
                    Con.Open();
                    string myquery = "DELETE FROM ExpertInfo WHERE ExpertName = '" + expertname.Text + "'; ";
                    SqlCommand cmd = new SqlCommand(myquery, Con);
                    cmd.Parameters.AddWithValue("@ExpertName", expertname.Text);
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
                SqlCommand cmd = new SqlCommand("update ExpertInfo set Email='" + email.Text + "', PhoneNo='" + contactno.Text + "', Password='" + password.Text + "' where ExpertName='" + expertname.Text + "'", Con);
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
                SqlCommand cmd = new SqlCommand("Insert into ExpertInfo values('" + expertname.Text + "','" + email.Text + "','" + contactno.Text + "','" + password.Text + "')", Con);
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

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            ExpertControlInterface f3 = new ExpertControlInterface();
            f3.Show();
            f3.Visible = true;
            this.Hide();
        }

        private void AeDetailsInterface_Load(object sender, EventArgs e)
        {

        }

        private void ClearLabel_Click(object sender, EventArgs e)
        {
            expertname.Text = "";
            email.Text = "";
            contactno.Text = "";
            password.Text = "";
        }
    }
}
