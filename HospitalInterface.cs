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
    public partial class HospitalInterface : Form
    {
        public HospitalInterface()
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
                String Myquery = "select * from AmbulanceData";
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
        private void LoadDataIntoComboBox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT District FROM HospitalData";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "HospitalData");

                        comboBox1.DataSource = dataSet.Tables["HospitalData"];
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
                string query2 = "SELECT DISTINCT Thana FROM HospitalData WHERE District = @SelectedDistrict";

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
                                comboBox2.DisplayMember = "Thana";
                                comboBox2.ValueMember = "Thana";
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
        private void UpdateHospitalView()
        {
            try
            {
                // Get the selected values from comboBox1 and comboBox2
                string selectedDistrict = comboBox1.Text;
                string selectedThana = comboBox2.Text;

                // Check if both comboBoxes have selected values
                if (!string.IsNullOrEmpty(selectedDistrict) && !string.IsNullOrEmpty(selectedThana))
                {
                    Con.Open();

                    // Assuming 'ColumnNameDistrict' and 'ColumnNameThana' are the actual column names
                    string query = "SELECT * FROM HospitalData WHERE District = @SelectedDistrict AND Thana = @SelectedThana";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDistrict", selectedDistrict);
                        cmd.Parameters.AddWithValue("@SelectedThana", selectedThana);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable searchResultTable = new DataTable();
                            adapter.Fill(searchResultTable);

                            if (searchResultTable.Rows.Count > 0)
                            {
                                HospitalView.DataSource = searchResultTable;
                            }
                            else
                            {
                                HospitalView.DataSource = null; // Clear the DataGridView
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

        private void HospitalInterface_Load(object sender, EventArgs e)
        {
            populate();
            LoadDataIntoComboBox();
            comboBoxDistrict_SelectedIndexChanged(sender, e);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxDistrict_SelectedIndexChanged(sender, e);
            UpdateHospitalView();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateHospitalView();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            /*try
            {
                // Get the selected values from comboBox1 and comboBox2
                string selectedDistrict = comboBox1.Text;
                string selectedThana = comboBox2.Text;

                // Check if both comboBoxes have selected values
                if (!string.IsNullOrEmpty(selectedDistrict) && !string.IsNullOrEmpty(selectedThana))
                {
                    Con.Open();

                    // Assuming 'ColumnNameDistrict' and 'ColumnNameThana' are the actual column names
                    string query = "SELECT * FROM HospitalData WHERE District = @SelectedDistrict AND Thana = @SelectedThana";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedDistrict", selectedDistrict);
                        cmd.Parameters.AddWithValue("@SelectedThana", selectedThana);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable searchResultTable = new DataTable();
                            adapter.Fill(searchResultTable);

                            if (searchResultTable.Rows.Count > 0)
                            {
                                HospitalView.DataSource = searchResultTable;
                                MessageBox.Show("Search successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                HospitalView.DataSource = null; // Clear the DataGridView
                                MessageBox.Show("No matching data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Please select both District and Thana.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }*/
        }

        private void HospitalView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
