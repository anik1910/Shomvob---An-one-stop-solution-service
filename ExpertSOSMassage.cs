using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Shomvob
{
    public partial class ExpertSOSMassage : Form
    {
        public ExpertSOSMassage()
        {
            InitializeComponent();
        }

        private void SOS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (SOS.Columns[e.ColumnIndex].Name == "Send")
            {
                MainPage f1 = new MainPage();
                f1.Show();
                f1.Visible = true;
                this.Hide();
            }
        }

        private void ExpertSOSMassage_Load(object sender, EventArgs e)
        {
            SOS.ColumnCount = 1;
            SOS.Columns[0].Name = "Massage";

            ArrayList AL = new ArrayList();
            AL.Add("Help Me");
            SOS.Rows.Add(AL.ToArray());

            AL = new ArrayList();
            AL.Add("Rider is a theif");
            SOS.Rows.Add(AL.ToArray());

            AL = new ArrayList();
            AL.Add("Rider has weapons");
            SOS.Rows.Add(AL.ToArray());

            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.HeaderText = "Send";
            btn.Name = "Send";
            btn.Text = "Send";
            btn.UseColumnTextForButtonValue = true;
            SOS.Columns.Add(btn);
        }
    }
}
