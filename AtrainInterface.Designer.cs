
namespace Shomvob
{
    partial class AtrainInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AtrainInterface));
            this.TrainView = new Guna.UI.WinForms.GunaDataGridView();
            this.RefreshBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.tfromtb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tnametb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tdistancetb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ttotb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.ttktb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.TrainView)).BeginInit();
            this.SuspendLayout();
            // 
            // TrainView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.TrainView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.TrainView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TrainView.BackgroundColor = System.Drawing.Color.White;
            this.TrainView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TrainView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TrainView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrainView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.TrainView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrainView.DefaultCellStyle = dataGridViewCellStyle3;
            this.TrainView.EnableHeadersVisualStyles = false;
            this.TrainView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrainView.Location = new System.Drawing.Point(456, 59);
            this.TrainView.Name = "TrainView";
            this.TrainView.RowHeadersVisible = false;
            this.TrainView.RowHeadersWidth = 51;
            this.TrainView.RowTemplate.Height = 25;
            this.TrainView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TrainView.Size = new System.Drawing.Size(375, 403);
            this.TrainView.TabIndex = 123;
            this.TrainView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.TrainView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.TrainView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.TrainView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.TrainView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.TrainView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.TrainView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.TrainView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrainView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LawnGreen;
            this.TrainView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.TrainView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TrainView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.TrainView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.TrainView.ThemeStyle.HeaderStyle.Height = 20;
            this.TrainView.ThemeStyle.ReadOnly = false;
            this.TrainView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.TrainView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.TrainView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.TrainView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TrainView.ThemeStyle.RowsStyle.Height = 25;
            this.TrainView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.TrainView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.TrainView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BusView_CellContentClick);
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
            this.RefreshBtn.Location = new System.Drawing.Point(231, 449);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(103, 42);
            this.RefreshBtn.TabIndex = 118;
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
            this.DeleteBtn.Location = new System.Drawing.Point(96, 449);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 42);
            this.DeleteBtn.TabIndex = 117;
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
            this.EditBtn.Location = new System.Drawing.Point(231, 388);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 42);
            this.EditBtn.TabIndex = 116;
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
            this.AddBtn.Location = new System.Drawing.Point(96, 388);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 42);
            this.AddBtn.TabIndex = 115;
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(26, 30);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(53, 37);
            this.bunifuThinButton22.TabIndex = 114;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 129;
            this.label2.Text = "From";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 128;
            this.label1.Text = "Train Name";
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.Location = new System.Drawing.Point(191, 367);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(45, 16);
            this.ClearLabel.TabIndex = 127;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // tfromtb
            // 
            this.tfromtb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tfromtb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tfromtb.ForeColor = System.Drawing.Color.Black;
            this.tfromtb.HintForeColor = System.Drawing.Color.Empty;
            this.tfromtb.HintText = "";
            this.tfromtb.isPassword = true;
            this.tfromtb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.tfromtb.LineIdleColor = System.Drawing.Color.Gray;
            this.tfromtb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.tfromtb.LineThickness = 3;
            this.tfromtb.Location = new System.Drawing.Point(112, 141);
            this.tfromtb.Margin = new System.Windows.Forms.Padding(4);
            this.tfromtb.Name = "tfromtb";
            this.tfromtb.Size = new System.Drawing.Size(222, 33);
            this.tfromtb.TabIndex = 125;
            this.tfromtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tnametb
            // 
            this.tnametb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tnametb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tnametb.ForeColor = System.Drawing.Color.Black;
            this.tnametb.HintForeColor = System.Drawing.Color.Empty;
            this.tnametb.HintText = "";
            this.tnametb.isPassword = false;
            this.tnametb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.tnametb.LineIdleColor = System.Drawing.Color.Gray;
            this.tnametb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.tnametb.LineThickness = 3;
            this.tnametb.Location = new System.Drawing.Point(112, 83);
            this.tnametb.Margin = new System.Windows.Forms.Padding(4);
            this.tnametb.Name = "tnametb";
            this.tnametb.Size = new System.Drawing.Size(222, 33);
            this.tnametb.TabIndex = 124;
            this.tnametb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tnametb.OnValueChanged += new System.EventHandler(this.tnametb_OnValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 133;
            this.label3.Text = "Distance (km)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 132;
            this.label4.Text = "To";
            // 
            // tdistancetb
            // 
            this.tdistancetb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tdistancetb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tdistancetb.ForeColor = System.Drawing.Color.Black;
            this.tdistancetb.HintForeColor = System.Drawing.Color.Empty;
            this.tdistancetb.HintText = "";
            this.tdistancetb.isPassword = true;
            this.tdistancetb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.tdistancetb.LineIdleColor = System.Drawing.Color.Gray;
            this.tdistancetb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.tdistancetb.LineThickness = 3;
            this.tdistancetb.Location = new System.Drawing.Point(112, 257);
            this.tdistancetb.Margin = new System.Windows.Forms.Padding(4);
            this.tdistancetb.Name = "tdistancetb";
            this.tdistancetb.Size = new System.Drawing.Size(222, 33);
            this.tdistancetb.TabIndex = 131;
            this.tdistancetb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ttotb
            // 
            this.ttotb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ttotb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ttotb.ForeColor = System.Drawing.Color.Black;
            this.ttotb.HintForeColor = System.Drawing.Color.Empty;
            this.ttotb.HintText = "";
            this.ttotb.isPassword = false;
            this.ttotb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ttotb.LineIdleColor = System.Drawing.Color.Gray;
            this.ttotb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ttotb.LineThickness = 3;
            this.ttotb.Location = new System.Drawing.Point(112, 199);
            this.ttotb.Margin = new System.Windows.Forms.Padding(4);
            this.ttotb.Name = "ttotb";
            this.ttotb.Size = new System.Drawing.Size(222, 33);
            this.ttotb.TabIndex = 130;
            this.ttotb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 296);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 146;
            this.label5.Text = "Fare (TK)";
            // 
            // ttktb
            // 
            this.ttktb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ttktb.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ttktb.ForeColor = System.Drawing.Color.Black;
            this.ttktb.HintForeColor = System.Drawing.Color.Empty;
            this.ttktb.HintText = "";
            this.ttktb.isPassword = false;
            this.ttktb.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ttktb.LineIdleColor = System.Drawing.Color.Gray;
            this.ttktb.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ttktb.LineThickness = 3;
            this.ttktb.Location = new System.Drawing.Point(112, 315);
            this.ttktb.Margin = new System.Windows.Forms.Padding(4);
            this.ttktb.Name = "ttktb";
            this.ttktb.Size = new System.Drawing.Size(222, 33);
            this.ttktb.TabIndex = 145;
            this.ttktb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // AtrainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ttktb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tdistancetb);
            this.Controls.Add(this.ttotb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.tfromtb);
            this.Controls.Add(this.tnametb);
            this.Controls.Add(this.TrainView);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.bunifuThinButton22);
            this.Name = "AtrainInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AtrainInterface";
            this.Load += new System.EventHandler(this.AtrainInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TrainView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView TrainView;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClearLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tfromtb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tnametb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tdistancetb;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ttotb;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ttktb;
    }
}