
namespace Shomvob
{
    partial class ArDetailsInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArDetailsInterface));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contactno = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.email = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ridername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.riderView = new Guna.UI.WinForms.GunaDataGridView();
            this.RefreshBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DeleteBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.EditBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.riderView)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 174;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(107, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 173;
            this.label4.Text = "Contact";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.password.ForeColor = System.Drawing.Color.Black;
            this.password.HintForeColor = System.Drawing.Color.Empty;
            this.password.HintText = "";
            this.password.isPassword = true;
            this.password.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.password.LineIdleColor = System.Drawing.Color.Gray;
            this.password.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.password.LineThickness = 3;
            this.password.Location = new System.Drawing.Point(110, 261);
            this.password.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 33);
            this.password.TabIndex = 172;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // contactno
            // 
            this.contactno.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactno.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactno.ForeColor = System.Drawing.Color.Black;
            this.contactno.HintForeColor = System.Drawing.Color.Empty;
            this.contactno.HintText = "";
            this.contactno.isPassword = false;
            this.contactno.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.contactno.LineIdleColor = System.Drawing.Color.Gray;
            this.contactno.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.contactno.LineThickness = 3;
            this.contactno.Location = new System.Drawing.Point(110, 202);
            this.contactno.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(222, 33);
            this.contactno.TabIndex = 171;
            this.contactno.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 170;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 169;
            this.label1.Text = "Rider Name";
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.Location = new System.Drawing.Point(200, 364);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(45, 16);
            this.ClearLabel.TabIndex = 168;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // email
            // 
            this.email.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.email.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.HintForeColor = System.Drawing.Color.Empty;
            this.email.HintText = "";
            this.email.isPassword = true;
            this.email.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.email.LineIdleColor = System.Drawing.Color.Gray;
            this.email.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.email.LineThickness = 3;
            this.email.Location = new System.Drawing.Point(110, 145);
            this.email.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(222, 33);
            this.email.TabIndex = 167;
            this.email.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // ridername
            // 
            this.ridername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ridername.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ridername.ForeColor = System.Drawing.Color.Black;
            this.ridername.HintForeColor = System.Drawing.Color.Empty;
            this.ridername.HintText = "";
            this.ridername.isPassword = false;
            this.ridername.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ridername.LineIdleColor = System.Drawing.Color.Gray;
            this.ridername.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ridername.LineThickness = 3;
            this.ridername.Location = new System.Drawing.Point(110, 87);
            this.ridername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ridername.Name = "ridername";
            this.ridername.Size = new System.Drawing.Size(222, 33);
            this.ridername.TabIndex = 166;
            this.ridername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // riderView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.riderView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.riderView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.riderView.BackgroundColor = System.Drawing.Color.White;
            this.riderView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.riderView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.riderView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LawnGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.riderView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.riderView.ColumnHeadersHeight = 20;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.riderView.DefaultCellStyle = dataGridViewCellStyle3;
            this.riderView.EnableHeadersVisualStyles = false;
            this.riderView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.riderView.Location = new System.Drawing.Point(452, 61);
            this.riderView.Name = "riderView";
            this.riderView.RowHeadersVisible = false;
            this.riderView.RowHeadersWidth = 51;
            this.riderView.RowTemplate.Height = 25;
            this.riderView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.riderView.Size = new System.Drawing.Size(375, 403);
            this.riderView.TabIndex = 165;
            this.riderView.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.riderView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.riderView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.riderView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.riderView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.riderView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.riderView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.riderView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.riderView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.LawnGreen;
            this.riderView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.riderView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.riderView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.riderView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.riderView.ThemeStyle.HeaderStyle.Height = 20;
            this.riderView.ThemeStyle.ReadOnly = false;
            this.riderView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.riderView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.riderView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.riderView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.riderView.ThemeStyle.RowsStyle.Height = 25;
            this.riderView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.riderView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.riderView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.riderView_CellContentClick);
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
            this.RefreshBtn.Location = new System.Drawing.Point(238, 447);
            this.RefreshBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(103, 42);
            this.RefreshBtn.TabIndex = 164;
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
            this.DeleteBtn.Location = new System.Drawing.Point(104, 447);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(103, 42);
            this.DeleteBtn.TabIndex = 163;
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
            this.EditBtn.Location = new System.Drawing.Point(238, 384);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(103, 42);
            this.EditBtn.TabIndex = 162;
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
            this.AddBtn.Location = new System.Drawing.Point(104, 384);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(103, 42);
            this.AddBtn.TabIndex = 161;
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(40, 33);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(53, 37);
            this.bunifuThinButton22.TabIndex = 160;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // ArDetailsInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 522);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.password);
            this.Controls.Add(this.contactno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearLabel);
            this.Controls.Add(this.email);
            this.Controls.Add(this.ridername);
            this.Controls.Add(this.riderView);
            this.Controls.Add(this.RefreshBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.bunifuThinButton22);
            this.Name = "ArDetailsInterface";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArDetailsInterface";
            this.Load += new System.EventHandler(this.ArDetailsInterface_Load);
            ((System.ComponentModel.ISupportInitialize)(this.riderView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ClearLabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox email;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ridername;
        private Guna.UI.WinForms.GunaDataGridView riderView;
        private Bunifu.Framework.UI.BunifuThinButton2 RefreshBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 EditBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
    }
}