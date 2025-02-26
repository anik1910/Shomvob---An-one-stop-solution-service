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
    public partial class BusInterface : Form
    {
        public BusInterface()
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
                String Myquery = "select * from BusInfoTbl";
                SqlDataAdapter da = new SqlDataAdapter(Myquery, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                BusInfoView.DataSource = ds.Tables[0];
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
                    string query = "SELECT DISTINCT Fromm FROM BusInfoTbl";
                    string query2 = "SELECT DISTINCT Too FROM BusInfoTbl";


                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "BusInfoTbl");

                        comboBox1.DataSource = dataSet.Tables["BusInfoTbl"];
                        comboBox1.DisplayMember = "Fromm";
                        comboBox1.ValueMember = "Fromm";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            MainPage f1 = new MainPage();
            f1.Show();
            f1.Visible = true;
            this.Hide();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                // Get the selected values from comboBox1 and comboBox2
                string selectedFromm = comboBox1.Text;
                string selectedToo = comboBox2.Text;

                // Check if both comboBoxes have selected values
                if (!string.IsNullOrEmpty(selectedFromm) && !string.IsNullOrEmpty(selectedToo))
                {
                    Con.Open();

                    
                    string query = "SELECT * FROM BusInfoTbl WHERE Fromm = @SelectedFromm AND Too = @SelectedToo";

                    using (SqlCommand cmd = new SqlCommand(query, Con))
                    {
                        cmd.Parameters.AddWithValue("@SelectedFromm", selectedFromm);
                        cmd.Parameters.AddWithValue("@SelectedToo", selectedToo);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable searchResultTable = new DataTable();
                            adapter.Fill(searchResultTable);

                            if (searchResultTable.Rows.Count > 0)
                            {
                                BusInfoView.DataSource = searchResultTable;
                                MessageBox.Show("Search successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                BusInfoView.DataSource = null; // Clear the DataGridView
                                MessageBox.Show("No matching data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                    Con.Close();
                }
                else
                {
                    MessageBox.Show("Please select both From and To.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during search: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadDataIntoComboBox2()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename='D:\4th Sem\Project Shomvob\DataBase\Shomvob.mdf';Integrated Security=True;Connect Timeout=30"))
                {
                    connection.Open();
                    string query2 = "SELECT DISTINCT Too FROM BusInfoTbl";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(query2, connection))
                    {
                        DataSet dataSet = new DataSet();
                        adapter.Fill(dataSet, "BusInfoTbl");

                        comboBox2.DataSource = dataSet.Tables["BusInfoTbl"];
                        comboBox2.DisplayMember = "Too";
                        comboBox2.ValueMember = "Too";
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
        private void BusInterface_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
            LoadDataIntoComboBox2();
            populate();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
