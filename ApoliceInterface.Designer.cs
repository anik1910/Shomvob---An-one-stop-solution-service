
namespace Shomvob
{
    partial class ApoliceInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApoliceInterface));
            this.label4 = new System.Windows.Forms.Label();
            this.apcnotb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.apaddresstb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.apnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PoliceView = new Guna.UI.WinForms.GunaDataGridView();
            this.RefreshBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.aputb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.apdtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.PoliceView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 184;
            this.label4.Text = "Contact No";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // apcnotb
            // 
            this.apcnotb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apcnotb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apcnotb.ForeColor = System.Drawing.Color.Black;
            this.apcnotb.HintForeColor = System.Drawing.Color.Empty;
            this.apcnotb.HintText = "";
            this.apcnotb.isPassword = false;
            this.apcnotb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.apcnotb.LineIdleColor = System.Drawing.Color.Gray;
            this.apcnotb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.apcnotb.LineThickness = 3;
            this.apcnotb.Location = new System.Drawing.Point(120, 177);
            this.apcnotb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apcnotb.Name = "apcnotb";
            this.apcnotb.Size = new System.Drawing.Size(222, 33);
            this.apcnotb.TabIndex = 183;
            this.apcnotb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apcnotb.OnValueChanged += new System.EventHandler(this.apnotb_OnValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 182;
            this.label2.Text = "Address";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 181;
            this.label1.Text = "Police Station";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.Location = new System.Drawing.Point(199, 345);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(45, 16);
            this.ClearLabel.TabIndex = 180;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // apaddresstb
            // 
            this.apaddresstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apaddresstb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apaddresstb.ForeColor = System.Drawing.Color.Black;
            this.apaddresstb.HintForeColor = System.Drawing.Color.Empty;
            this.apaddresstb.HintText = "";
            this.apaddresstb.isPassword = true;
            this.apaddresstb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.apaddresstb.LineIdleColor = System.Drawing.Color.Gray;
            this.apaddresstb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.apaddresstb.LineThickness = 3;
            this.apaddresstb.Location = new System.Drawing.Point(120, 119);
            this.apaddresstb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apaddresstb.Name = "apaddresstb";
            this.apaddresstb.Size = new System.Drawing.Size(222, 33);
            this.apaddresstb.TabIndex = 179;
            this.apaddresstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apaddresstb.OnValueChanged += new System.EventHandler(this.apaddresstb_OnValueChanged);
            // 
            // apnametb
            // 
            this.apnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apnametb.ForeColor = System.Drawing.Color.Black;
            this.apnametb.HintForeColor = System.Drawing.Color.Empty;
            this.apnametb.HintText = "";
            this.apnametb.isPassword = false;
            this.apnametb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.apnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.apnametb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.apnametb.LineThickness = 3;
            this.apnametb.Location = new System.Drawing.Point(120, 61);
            this.apnametb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apnametb.Name = "apnametb";
            this.apnametb.Size = new System.Drawing.Size(222, 33);
            this.apnametb.TabIndex = 178;
            this.apnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.apnametb.OnValueChanged += new System.EventHandler(this.apnametb_OnValueChanged);
            // 
            // PoliceView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.PoliceView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PoliceView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PoliceView.BackgroundColor = System.Drawing.Color.White;
            this.PoliceView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PoliceView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PoliceView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PoliceView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.PoliceView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PoliceView.DefaultCellStyle = dataGridViewCellStyle3;
            this.PoliceView.EnableHeadersVisualStyles = false;
            this.PoliceView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PoliceView.Location = new System.Drawing.Point(453, 73);
            this.PoliceView.Name = "PoliceView";
            this.PoliceView.RowHeadersVisible = false;
            this.PoliceView.RowHeadersWidth = 51;
            this.PoliceView.RowTemplate.Height = 25;
            this.PoliceView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PoliceView.Size = new System.Drawing.Size(375, 403);
            this.PoliceView.TabIndex = 177;
            this.PoliceView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.PoliceView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.PoliceView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.PoliceView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.PoliceView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.PoliceView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.PoliceView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.PoliceView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PoliceView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LawnGreen;
            this.PoliceView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.PoliceView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PoliceView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.PoliceView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.PoliceView.ThemeStyle.HeaderStyle.Height = 20;
            this.PoliceView.ThemeStyle.ReadOnly = false;
            this.PoliceView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.PoliceView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.PoliceView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.PoliceView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PoliceView.ThemeStyle.RowsStyle.Height = 25;
            this.PoliceView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.PoliceView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.PoliceView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusView_CellContentClick);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.ActiveBorderThickness = 1;
            this.RefreshBtn.ActiveCornerRadius = 20;
            this.RefreshBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.RefreshBtn.ActiveForecolor = System.Drawing.Color.Black;
            this.RefreshBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.RefreshBtn.BackColor = System.Drawing.SystemColors.Control;
            this.RefreshBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.BackgroundImage")));
            this.RefreshBtn.ButtonText = "Refresh";
            this.RefreshBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RefreshBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshBtn.ForeColor = System.Drawing.Color.Black;
            this.RefreshBtn.IdleBorderThickness = 1;
            this.RefreshBtn.IdleCornerRadius = 20;
            this.RefreshBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.RefreshBtn.IdleForecolor = System.Drawing.Color.Black;
            this.RefreshBtn.IdleLineColor = System.Drawing.Color.Black;
            this.RefreshBtn.Location = new System.Drawing.Point(239, 441);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(103, 42);
            this.RefreshBtn.TabIndex = 176;
            this.RefreshBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.ActiveBorderThickness = 1;
            this.DeleteBtn.ActiveCornerRadius = 20;
            this.DeleteBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.DeleteBtn.ActiveForecolor = System.Drawing.Color.Black;
            this.DeleteBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.DeleteBtn.BackColor = System.Drawing.SystemColors.Control;
            this.DeleteBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteBtn.BackgroundImage")));
            this.DeleteBtn.ButtonText = "Delete";
            this.DeleteBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.Color.Black;
            this.DeleteBtn.IdleBorderThickness = 1;
            this.DeleteBtn.IdleCornerRadius = 20;
            this.DeleteBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.DeleteBtn.IdleForecolor = System.Drawing.Color.Black;
            this.DeleteBtn.IdleLineColor = System.Drawing.Color.Black;
            this.DeleteBtn.Location = new System.Drawing.Point(104, 441);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 42);
            this.DeleteBtn.TabIndex = 175;
            this.DeleteBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.ActiveBorderThickness = 1;
            this.EditBtn.ActiveCornerRadius = 20;
            this.EditBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.EditBtn.ActiveForecolor = System.Drawing.Color.Black;
            this.EditBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.EditBtn.BackColor = System.Drawing.SystemColors.Control;
            this.EditBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("EditBtn.BackgroundImage")));
            this.EditBtn.ButtonText = "Edit";
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.Color.Black;
            this.EditBtn.IdleBorderThickness = 1;
            this.EditBtn.IdleCornerRadius = 20;
            this.EditBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.EditBtn.IdleForecolor = System.Drawing.Color.Black;
            this.EditBtn.IdleLineColor = System.Drawing.Color.Black;
            this.EditBtn.Location = new System.Drawing.Point(239, 379);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 42);
            this.EditBtn.TabIndex = 174;
            this.EditBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.ActiveBorderThickness = 1;
            this.AddBtn.ActiveCornerRadius = 20;
            this.AddBtn.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.AddBtn.ActiveForecolor = System.Drawing.Color.Black;
            this.AddBtn.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.AddBtn.BackColor = System.Drawing.SystemColors.Control;
            this.AddBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddBtn.BackgroundImage")));
            this.AddBtn.ButtonText = "Add";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.AddBtn.IdleForecolor = System.Drawing.Color.Black;
            this.AddBtn.IdleLineColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(104, 379);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 42);
            this.AddBtn.TabIndex = 173;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(23, 27);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(53, 37);
            this.bunifuThinButton22.TabIndex = 172;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 277);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 188;
            this.label5.Text = "Upozila";
            // 
            // aputb
            // 
            this.aputb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.aputb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.aputb.ForeColor = System.Drawing.Color.Black;
            this.aputb.HintForeColor = System.Drawing.Color.Empty;
            this.aputb.HintText = "";
            this.aputb.isPassword = false;
            this.aputb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.aputb.LineIdleColor = System.Drawing.Color.Gray;
            this.aputb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.aputb.LineThickness = 3;
            this.aputb.Location = new System.Drawing.Point(120, 296);
            this.aputb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.aputb.Name = "aputb";
            this.aputb.Size = new System.Drawing.Size(222, 33);
            this.aputb.TabIndex = 187;
            this.aputb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 186;
            this.label3.Text = "District";
            // 
            // apdtb
            // 
            this.apdtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.apdtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.apdtb.ForeColor = System.Drawing.Color.Black;
            this.apdtb.HintForeColor = System.Drawing.Color.Empty;
            this.apdtb.HintText = "";
            this.apdtb.isPassword = false;
            this.apdtb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.apdtb.LineIdleColor = System.Drawing.Color.Gray;
            this.apdtb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.apdtb.LineThickness = 3;
            this.apdtb.Location = new System.Drawing.Point(120, 235);
            this.apdtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apdtb.Name = "apdtb";
            this.apdtb.Size = new System.Drawing.Size(222, 33);
            this.apdtb.TabIndex = 185;
            this.apdtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ApoliceInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.aputb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apdtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.apcnotb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.apaddresstb);
            this.Controls.Add(this.apnametb);
            this.Controls.Add(this.PoliceView);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.bunifuThinButton22);
            this.Name = "ApoliceInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ApoliceInterface";
            this.Load += new System.EventHandler(this.ApoliceInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PoliceView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox apcnotb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClearLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox apaddresstb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox apnametb;
        private Guna.UI.WinForms.GunaDataGridView PoliceView;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox aputb;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox apdtb;
    }
}