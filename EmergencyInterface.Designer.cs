
namespace Shomvob
{
    partial class EmergencyInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmergencyInterface));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.FireServicebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Hospitalbtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Policebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Ambulacebtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EmergencyView = new Guna.UI.WinForms.GunaDataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.FireServicebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospitalbtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Policebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ambulacebtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyView)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dhaka",
            "Magura",
            "Cumilla"});
            this.comboBox1.Location = new System.Drawing.Point(56, 130);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 21);
            this.label1.TabIndex = 14;
            this.label1.Text = "District";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 21);
            this.label2.TabIndex = 16;
            this.label2.Text = "Thana/Upazila";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Mohammadpur",
            "Badda",
            "Shripur",
            "Sreepur",
            "Sadar",
            "Savar"});
            this.comboBox2.Location = new System.Drawing.Point(56, 197);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 15;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // FireServicebtn
            // 
            this.FireServicebtn.BackColor = System.Drawing.Color.Transparent;
            this.FireServicebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FireServicebtn.Image = ((System.Drawing.Image)(resources.GetObject("FireServicebtn.Image")));
            this.FireServicebtn.ImageActive = null;
            this.FireServicebtn.Location = new System.Drawing.Point(127, 328);
            this.FireServicebtn.Name = "FireServicebtn";
            this.FireServicebtn.Size = new System.Drawing.Size(50, 50);
            this.FireServicebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FireServicebtn.TabIndex = 42;
            this.FireServicebtn.TabStop = false;
            this.FireServicebtn.Zoom = 10;
            this.FireServicebtn.Click += new System.EventHandler(this.bunifuImageButton4_Click);
            // 
            // Hospitalbtn
            // 
            this.Hospitalbtn.BackColor = System.Drawing.Color.Transparent;
            this.Hospitalbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Hospitalbtn.Image = ((System.Drawing.Image)(resources.GetObject("Hospitalbtn.Image")));
            this.Hospitalbtn.ImageActive = null;
            this.Hospitalbtn.Location = new System.Drawing.Point(55, 328);
            this.Hospitalbtn.Name = "Hospitalbtn";
            this.Hospitalbtn.Size = new System.Drawing.Size(50, 50);
            this.Hospitalbtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Hospitalbtn.TabIndex = 41;
            this.Hospitalbtn.TabStop = false;
            this.Hospitalbtn.Zoom = 10;
            this.Hospitalbtn.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // Policebtn
            // 
            this.Policebtn.BackColor = System.Drawing.Color.Transparent;
            this.Policebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Policebtn.Image = ((System.Drawing.Image)(resources.GetObject("Policebtn.Image")));
            this.Policebtn.ImageActive = null;
            this.Policebtn.Location = new System.Drawing.Point(127, 245);
            this.Policebtn.Name = "Policebtn";
            this.Policebtn.Size = new System.Drawing.Size(50, 50);
            this.Policebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Policebtn.TabIndex = 40;
            this.Policebtn.TabStop = false;
            this.Policebtn.Zoom = 10;
            this.Policebtn.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // Ambulacebtn
            // 
            this.Ambulacebtn.BackColor = System.Drawing.Color.Transparent;
            this.Ambulacebtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Ambulacebtn.Image = ((System.Drawing.Image)(resources.GetObject("Ambulacebtn.Image")));
            this.Ambulacebtn.ImageActive = null;
            this.Ambulacebtn.Location = new System.Drawing.Point(55, 245);
            this.Ambulacebtn.Name = "Ambulacebtn";
            this.Ambulacebtn.Size = new System.Drawing.Size(50, 50);
            this.Ambulacebtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Ambulacebtn.TabIndex = 39;
            this.Ambulacebtn.TabStop = false;
            this.Ambulacebtn.Zoom = 10;
            this.Ambulacebtn.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(337, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 37);
            this.label3.TabIndex = 44;
            this.label3.Text = "OUR EMERGENCY SERVICES ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            this.bunifuThinButton22.TabIndex = 67;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // EmergencyView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmergencyView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmergencyView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.EmergencyView.BackgroundColor = System.Drawing.Color.White;
            this.EmergencyView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmergencyView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmergencyView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmergencyView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmergencyView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmergencyView.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmergencyView.EnableHeadersVisualStyles = false;
            this.EmergencyView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmergencyView.Location = new System.Drawing.Point(226, 58);
            this.EmergencyView.Name = "EmergencyView";
            this.EmergencyView.RowHeadersVisible = false;
            this.EmergencyView.RowHeadersWidth = 51;
            this.EmergencyView.RowTemplate.Height = 25;
            this.EmergencyView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.EmergencyView.Size = new System.Drawing.Size(600, 433);
            this.EmergencyView.TabIndex = 192;
            this.EmergencyView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.EmergencyView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmergencyView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmergencyView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmergencyView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmergencyView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmergencyView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.EmergencyView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmergencyView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LawnGreen;
            this.EmergencyView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmergencyView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmergencyView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmergencyView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmergencyView.ThemeStyle.HeaderStyle.Height = 20;
            this.EmergencyView.ThemeStyle.ReadOnly = false;
            this.EmergencyView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmergencyView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmergencyView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.EmergencyView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmergencyView.ThemeStyle.RowsStyle.Height = 25;
            this.EmergencyView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmergencyView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmergencyView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmergencyView_CellContentClick);
            // 
            // EmergencyInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.EmergencyView);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.FireServicebtn);
            this.Controls.Add(this.Hospitalbtn);
            this.Controls.Add(this.Policebtn);
            this.Controls.Add(this.Ambulacebtn);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "EmergencyInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmergencyInterface";
            this.Load += new System.EventHandler(this.EmergencyInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FireServicebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hospitalbtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Policebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Ambulacebtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmergencyView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox2;
        private Bunifu.Framework.UI.BunifuImageButton FireServicebtn;
        private Bunifu.Framework.UI.BunifuImageButton Hospitalbtn;
        private Bunifu.Framework.UI.BunifuImageButton Policebtn;
        private Bunifu.Framework.UI.BunifuImageButton Ambulacebtn;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Guna.UI.WinForms.GunaDataGridView EmergencyView;
    }
}