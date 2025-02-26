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
    public partial class EmergencyInterface : Form
    {
        public EmergencyInterface()
        {
            InitializeComponent();
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
        }

        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30");
        void populate()
        {
            try
            {
                Con.Open();
                String Myquery = "select * from AmbulanceData && select * from HospitalData && select * from PoliceData && select * from FireServiceData";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                EmergencyView.DataSource = ds.Tables[0];
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

                    string query = "SELECT DISTINCT District FROM HospitalData UNION " +
                                   "SELECT DISTINCT District FROM AmbulanceData UNION " +
                                   "SELECT DISTINCT District FROM PoliceData UNION " +
                                   "SELECT DISTINCT District FROM FireServiceData";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataTable districtTable = new DataTable();
                        adapter.Fill(districtTable);

                        comboBox1.DataSource = districtTable;
                        comboBox1.DisplayMember = "District";
                        comboBox1.ValueMember = "District";
                    }

                    string query2 = "SELECT DISTINCT Thana FROM HospitalData UNION " +
                                    "SELECT DISTINCT Thana FROM AmbulanceData UNION " +
                                    "SELECT DISTINCT Upozila FROM PoliceData UNION " +
                                    "SELECT DISTINCT Upozila FROM FireServiceData";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query2, connection))
                    {
                        DataTable upozilaTable = new DataTable();
                        adapter.Fill(upozilaTable);

                        comboBox2.DataSource = upozilaTable;
                        comboBox2.DisplayMember = "Upozila"; // Assuming 'Upozila' is the correct column name
                        comboBox2.ValueMember = "Upozila";
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query2, connection))
                    {
                        DataTable upozilaTable = new DataTable();
                        adapter.Fill(upozilaTable);

                        comboBox2.DataSource = upozilaTable;
                        comboBox2.DisplayMember = "Thana";
                        comboBox2.ValueMember = "Thana";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataIntoComboBox2()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();

                    string query2 = "SELECT DISTINCT Thana FROM HospitalData UNION " +
                                    "SELECT DISTINCT Thana FROM AmbulanceData UNION " +
                                    "SELECT DISTINCT Upozila FROM PoliceData UNION " +
                                    "SELECT DISTINCT Upozila FROM FireServiceData";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query2, connection))
                    {
                        DataTable upozilaTable = new DataTable();
                        adapter.Fill(upozilaTable);

                        comboBox2.DataSource = upozilaTable;
                        comboBox2.DisplayMember = "Thana";
                        comboBox2.ValueMember = "Thana";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data for comboBox2: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void EmergencyInterface_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
            LoadDataIntoComboBox2();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            UserInterface f1 = new UserInterface();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
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
                    string query = "SELECT * FROM AmbulanceData WHERE District = @SelectedDistrict AND Thana = @SelectedThana";

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
                                EmergencyView.DataSource = searchResultTable;
                                MessageBox.Show("Search successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                EmergencyView.DataSource = null; // Clear the DataGridView
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
            }
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
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
                                EmergencyView.DataSource = searchResultTable;
                                MessageBox.Show("Search successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                EmergencyView.DataSource = null; // Clear the DataGridView
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
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
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
                    string query = "SELECT * FROM PoliceData WHERE District = @SelectedDistrict AND Upozila = @SelectedThana";

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
                                EmergencyView.DataSource = searchResultTable;
                                MessageBox.Show("Search successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                EmergencyView.DataSource = null; // Clear the DataGridView
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
            }
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
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
                    string query = "SELECT * FROM FireServiceData WHERE District = @SelectedDistrict AND Upozila = @SelectedThana";

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
                                EmergencyView.DataSource = searchResultTable;
                                MessageBox.Show("Search successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                EmergencyView.DataSource = null; // Clear the DataGridView
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
            }
        }

        private void EmergencyView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
