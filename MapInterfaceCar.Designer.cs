
namespace Shomvob
{
    partial class MapInterfaceCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MapInterfaceCar));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.AddBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.too = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.fromm = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label3 = new System.Windows.Forms.Label();
            this.ammount = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(439, 1);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(719, 639);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
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
            this.AddBtn.ButtonText = "Request For a Ride";
            this.AddBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.Color.Black;
            this.AddBtn.IdleBorderThickness = 1;
            this.AddBtn.IdleCornerRadius = 20;
            this.AddBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.AddBtn.IdleForecolor = System.Drawing.Color.Black;
            this.AddBtn.IdleLineColor = System.Drawing.Color.Black;
            this.AddBtn.Location = new System.Drawing.Point(80, 442);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(236, 52);
            this.AddBtn.TabIndex = 196;
            this.AddBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 251);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 195;
            this.label2.Text = "To";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 162);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 194;
            this.label1.Text = "From";
            // 
            // too
            // 
            this.too.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.too.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.too.ForeColor = System.Drawing.Color.Black;
            this.too.HintForeColor = System.Drawing.Color.Empty;
            this.too.HintText = "";
            this.too.isPassword = true;
            this.too.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.too.LineIdleColor = System.Drawing.Color.Gray;
            this.too.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.too.LineThickness = 3;
            this.too.Location = new System.Drawing.Point(53, 274);
            this.too.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.too.Name = "too";
            this.too.Size = new System.Drawing.Size(296, 41);
            this.too.TabIndex = 193;
            this.too.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // fromm
            // 
            this.fromm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fromm.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.fromm.ForeColor = System.Drawing.Color.Black;
            this.fromm.HintForeColor = System.Drawing.Color.Empty;
            this.fromm.HintText = "";
            this.fromm.isPassword = false;
            this.fromm.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.fromm.LineIdleColor = System.Drawing.Color.Gray;
            this.fromm.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.fromm.LineThickness = 3;
            this.fromm.Location = new System.Drawing.Point(53, 185);
            this.fromm.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.fromm.Name = "fromm";
            this.fromm.Size = new System.Drawing.Size(296, 41);
            this.fromm.TabIndex = 192;
            this.fromm.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuThinButton22.Location = new System.Drawing.Point(17, 17);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(71, 46);
            this.bunifuThinButton22.TabIndex = 191;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 198;
            this.label3.Text = "Amount";
            // 
            // ammount
            // 
            this.ammount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ammount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ammount.ForeColor = System.Drawing.Color.Black;
            this.ammount.HintForeColor = System.Drawing.Color.Empty;
            this.ammount.HintText = "";
            this.ammount.isPassword = true;
            this.ammount.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.ammount.LineIdleColor = System.Drawing.Color.Gray;
            this.ammount.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.ammount.LineThickness = 3;
            this.ammount.Location = new System.Drawing.Point(53, 362);
            this.ammount.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.ammount.Name = "ammount";
            this.ammount.Size = new System.Drawing.Size(296, 41);
            this.ammount.TabIndex = 197;
            this.ammount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ammount.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // MapInterfaceCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 642);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ammount);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.too);
            this.Controls.Add(this.fromm);
            this.Controls.Add(this.bunifuThinButton22);
            this.Controls.Add(this.pictureBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MapInterfaceCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MapInterfaceCar";
            this.Load += new System.EventHandler(this.MapInterfaceCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 AddBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox too;
        private Bunifu.Framework.UI.BunifuMaterialTextbox fromm;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ammount;
    }
}