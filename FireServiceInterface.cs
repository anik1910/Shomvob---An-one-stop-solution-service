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
    public partial class FireServiceInterface : Form
    {
        public FireServiceInterface()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
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
                FireServiceView.DataSource = ds.Tables[0];
                Con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT District FROM FireServiceData";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "FireServiceData");

                        comboBox1.DataSource = dataSet.Tables["FireServiceData"];
                        comboBox1.DisplayMember = "District";
                        comboBox1.ValueMember = "District";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Check if an item is selected in comboBox1
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedDistrict = comboBox1.Text;
                string query2 = "SELECT DISTINCT Upozila FROM FireServiceData WHERE District = @SelectedDistrict";

                try
                {
                    using (SqlConnection connection2 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                    {
                        connection2.Open();

                        using (SqlDataAdapter adapter = new SqlDataAdapter(query2, connection2))
                        {
                            adapter.SelectCommand.Parameters.AddWithValue("@SelectedDistrict", selectedDistrict);

                            DataTable thanaTable = new DataTable();
                            adapter.Fill(thanaTable);

                            // Clear existing bindings
                            comboBox2.DataSource = null;
                            comboBox2.Items.Clear();

                            if (thanaTable.Rows.Count > 0)
                            {
                                comboBox2.DataSource = thanaTable;
                                comboBox2.DisplayMember = "Upozila";
                                comboBox2.ValueMember = "Upozila";
                            }
                            else
                            {
                                //MessageBox.Show("No Thana data found for the selected district.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void bunifuThinButton22_Click_1(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void UpdateFireServiceView()
        {
            try
            {
                // Get the selected values from comboBox1 and comboBox2
                string selectedDistrict = comboBox1.Text;
                string selectedUpozila = comboBox2.Text;

                // Check if both comboBoxes have selected values
                if (!string.IsNullOrEmpty(selectedDistrict) && !string.IsNullOrEmpty(selectedUpozila))
                {
                    Con.Open();

                    // Assuming 'ColumnNameDistrict' and 'ColumnNameUpozila' are the actual column names
                    string query = "SELECT * FROM FireServiceData WHERE District = @SelectedDistrict AND Upozila = @SelectedUpozila";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDistrict", selectedDistrict);
                        cmd.Parameters.AddWithValue("@SelectedUpozila", selectedUpozila);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable searchResultTable = new DataTable();
                            adapter.Fill(searchResultTable);

                            if (searchResultTable.Rows.Count > 0)
                            {
                                FireServiceView.DataSource = searchResultTable;
                            }
                            else
                            {
                                FireServiceView.DataSource = null; // Clear the DataGridView
                            }
                        }
                    }

                    Con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during update: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FireServiceView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FireServiceInterface_Load(object sender, EventArgs e)
        {
            populate();
            LoadDataIntoComboBox();
            comboBoxDistrict_SelectedIndexChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDistrict_SelectedIndexChanged(sender, e);
            UpdateFireServiceView();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFireServiceView();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }
    }
}
