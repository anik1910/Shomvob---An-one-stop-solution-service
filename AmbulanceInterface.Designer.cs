
namespace Shomvob
{
    partial class AmbulanceInterface
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AmbulanceInterface));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.Searchbtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label4 = new System.Windows.Forms.Label();
            this.AmbulanceView = new Guna.UI.WinForms.GunaDataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.AmbulanceView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Back";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton22.Location = new System.Drawing.Point(13, 14);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(53, 37);
            this.bunifuThinButton22.TabIndex = 68;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 183;
            this.label3.Text = "Thana";
            // 
            // Searchbtn
            // 
            this.Searchbtn.ActiveBorderThickness = 1;
            this.Searchbtn.ActiveCornerRadius = 20;
            this.Searchbtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.Searchbtn.ActiveForecolor = System.Drawing.Color.Black;
            this.Searchbtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.Searchbtn.BackColor = System.Drawing.SystemColors.Control;
            this.Searchbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbtn.BackgroundImage")));
            this.Searchbtn.ButtonText = "Search";
            this.Searchbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Searchbtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.Black;
            this.Searchbtn.IdleBorderThickness = 1;
            this.Searchbtn.IdleCornerRadius = 20;
            this.Searchbtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.Searchbtn.IdleForecolor = System.Drawing.Color.Black;
            this.Searchbtn.IdleLineColor = System.Drawing.Color.Black;
            this.Searchbtn.Location = new System.Drawing.Point(129, 308);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(103, 42);
            this.Searchbtn.TabIndex = 179;
            this.Searchbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Searchbtn.Click += new System.EventHandler(this.bunifuThinButton24_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 182;
            this.label4.Text = "District";
            // 
            // AmbulanceView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.AmbulanceView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.AmbulanceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AmbulanceView.BackgroundColor = System.Drawing.Color.White;
            this.AmbulanceView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AmbulanceView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AmbulanceView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.AmbulanceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.AmbulanceView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.AmbulanceView.DefaultCellStyle = dataGridViewCellStyle3;
            this.AmbulanceView.EnableHeadersVisualStyles = false;
            this.AmbulanceView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AmbulanceView.Location = new System.Drawing.Point(429, 59);
            this.AmbulanceView.Name = "AmbulanceView";
            this.AmbulanceView.RowHeadersVisible = false;
            this.AmbulanceView.RowHeadersWidth = 51;
            this.AmbulanceView.RowTemplate.Height = 25;
            this.AmbulanceView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AmbulanceView.Size = new System.Drawing.Size(375, 400);
            this.AmbulanceView.TabIndex = 184;
            this.AmbulanceView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.AmbulanceView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.AmbulanceView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.AmbulanceView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.AmbulanceView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.AmbulanceView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.AmbulanceView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.AmbulanceView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AmbulanceView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LawnGreen;
            this.AmbulanceView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.AmbulanceView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AmbulanceView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.AmbulanceView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.AmbulanceView.ThemeStyle.HeaderStyle.Height = 20;
            this.AmbulanceView.ThemeStyle.ReadOnly = false;
            this.AmbulanceView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.AmbulanceView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.AmbulanceView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.AmbulanceView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AmbulanceView.ThemeStyle.RowsStyle.Height = 25;
            this.AmbulanceView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.AmbulanceView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.AmbulanceView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusView_CellContentClick);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(75, 180);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(253, 21);
            this.comboBox1.TabIndex = 185;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(75, 252);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(253, 21);
            this.comboBox2.TabIndex = 186;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // AmbulanceInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.AmbulanceView);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.bunifuThinButton22);
            this.Name = "AmbulanceInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AmbulanceInterface";
            this.Load += new System.EventHandler(this.AmbulanceInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AmbulanceView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 Searchbtn;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView AmbulanceView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}