
namespace Shomvob
{
    partial class AhospitalInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AhospitalInterface));
            this.label4 = new System.Windows.Forms.Label();
            this.ahcnotb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.ahaddresstb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ahnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.HospitalView = new Guna.UI.WinForms.GunaDataGridView();
            this.RefreshBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.ahdtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ahttb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.HospitalView)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(117, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 171;
            this.label4.Text = "Contact No";
            // 
            // ahcnotb
            // 
            this.ahcnotb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ahcnotb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ahcnotb.ForeColor = System.Drawing.Color.Black;
            this.ahcnotb.HintForeColor = System.Drawing.Color.Empty;
            this.ahcnotb.HintText = "";
            this.ahcnotb.isPassword = false;
            this.ahcnotb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ahcnotb.LineIdleColor = System.Drawing.Color.Gray;
            this.ahcnotb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ahcnotb.LineThickness = 3;
            this.ahcnotb.Location = new System.Drawing.Point(120, 172);
            this.ahcnotb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ahcnotb.Name = "ahcnotb";
            this.ahcnotb.Size = new System.Drawing.Size(222, 33);
            this.ahcnotb.TabIndex = 170;
            this.ahcnotb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 169;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(117, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 168;
            this.label1.Text = "Hospital Name";
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.Location = new System.Drawing.Point(200, 351);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(45, 16);
            this.ClearLabel.TabIndex = 167;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // ahaddresstb
            // 
            this.ahaddresstb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ahaddresstb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ahaddresstb.ForeColor = System.Drawing.Color.Black;
            this.ahaddresstb.HintForeColor = System.Drawing.Color.Empty;
            this.ahaddresstb.HintText = "";
            this.ahaddresstb.isPassword = true;
            this.ahaddresstb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ahaddresstb.LineIdleColor = System.Drawing.Color.Gray;
            this.ahaddresstb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ahaddresstb.LineThickness = 3;
            this.ahaddresstb.Location = new System.Drawing.Point(120, 114);
            this.ahaddresstb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ahaddresstb.Name = "ahaddresstb";
            this.ahaddresstb.Size = new System.Drawing.Size(222, 33);
            this.ahaddresstb.TabIndex = 166;
            this.ahaddresstb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ahnametb
            // 
            this.ahnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ahnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ahnametb.ForeColor = System.Drawing.Color.Black;
            this.ahnametb.HintForeColor = System.Drawing.Color.Empty;
            this.ahnametb.HintText = "";
            this.ahnametb.isPassword = false;
            this.ahnametb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ahnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.ahnametb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ahnametb.LineThickness = 3;
            this.ahnametb.Location = new System.Drawing.Point(120, 56);
            this.ahnametb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ahnametb.Name = "ahnametb";
            this.ahnametb.Size = new System.Drawing.Size(222, 33);
            this.ahnametb.TabIndex = 165;
            this.ahnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // HospitalView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.HospitalView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.HospitalView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.HospitalView.BackgroundColor = System.Drawing.Color.White;
            this.HospitalView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.HospitalView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HospitalView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.HospitalView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.HospitalView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.HospitalView.DefaultCellStyle = dataGridViewCellStyle3;
            this.HospitalView.EnableHeadersVisualStyles = false;
            this.HospitalView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HospitalView.Location = new System.Drawing.Point(453, 73);
            this.HospitalView.Name = "HospitalView";
            this.HospitalView.RowHeadersVisible = false;
            this.HospitalView.RowHeadersWidth = 51;
            this.HospitalView.RowTemplate.Height = 25;
            this.HospitalView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.HospitalView.Size = new System.Drawing.Size(375, 403);
            this.HospitalView.TabIndex = 164;
            this.HospitalView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.HospitalView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.HospitalView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.HospitalView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.HospitalView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.HospitalView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.HospitalView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.HospitalView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HospitalView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LawnGreen;
            this.HospitalView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.HospitalView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.HospitalView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.HospitalView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.HospitalView.ThemeStyle.HeaderStyle.Height = 20;
            this.HospitalView.ThemeStyle.ReadOnly = false;
            this.HospitalView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.HospitalView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.HospitalView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.HospitalView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HospitalView.ThemeStyle.RowsStyle.Height = 25;
            this.HospitalView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.HospitalView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.HospitalView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.HospitalView_CellContentClick);
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
            this.RefreshBtn.Location = new System.Drawing.Point(239, 434);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(103, 42);
            this.RefreshBtn.TabIndex = 163;
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
            this.DeleteBtn.Location = new System.Drawing.Point(104, 434);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 42);
            this.DeleteBtn.TabIndex = 162;
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
            this.EditBtn.Location = new System.Drawing.Point(239, 372);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 42);
            this.EditBtn.TabIndex = 161;
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
            this.AddBtn.Location = new System.Drawing.Point(104, 372);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 42);
            this.AddBtn.TabIndex = 160;
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(30, 24);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(53, 37);
            this.bunifuThinButton22.TabIndex = 159;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 173;
            this.label3.Text = "District";
            // 
            // ahdtb
            // 
            this.ahdtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ahdtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ahdtb.ForeColor = System.Drawing.Color.Black;
            this.ahdtb.HintForeColor = System.Drawing.Color.Empty;
            this.ahdtb.HintText = "";
            this.ahdtb.isPassword = false;
            this.ahdtb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ahdtb.LineIdleColor = System.Drawing.Color.Gray;
            this.ahdtb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ahdtb.LineThickness = 3;
            this.ahdtb.Location = new System.Drawing.Point(120, 240);
            this.ahdtb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ahdtb.Name = "ahdtb";
            this.ahdtb.Size = new System.Drawing.Size(222, 33);
            this.ahdtb.TabIndex = 172;
            this.ahdtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(117, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 175;
            this.label5.Text = "Thana";
            // 
            // ahttb
            // 
            this.ahttb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ahttb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ahttb.ForeColor = System.Drawing.Color.Black;
            this.ahttb.HintForeColor = System.Drawing.Color.Empty;
            this.ahttb.HintText = "";
            this.ahttb.isPassword = false;
            this.ahttb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ahttb.LineIdleColor = System.Drawing.Color.Gray;
            this.ahttb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ahttb.LineThickness = 3;
            this.ahttb.Location = new System.Drawing.Point(120, 301);
            this.ahttb.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ahttb.Name = "ahttb";
            this.ahttb.Size = new System.Drawing.Size(222, 33);
            this.ahttb.TabIndex = 174;
            this.ahttb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AhospitalInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ahttb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ahdtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ahcnotb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.ahaddresstb);
            this.Controls.Add(this.ahnametb);
            this.Controls.Add(this.HospitalView);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.bunifuThinButton22);
            this.Name = "AhospitalInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AhospitalInterface";
            this.Load += new System.EventHandler(this.AhospitalInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HospitalView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ahcnotb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClearLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ahaddresstb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ahnametb;
        private Guna.UI.WinForms.GunaDataGridView HospitalView;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ahdtb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ahttb;
    }
}