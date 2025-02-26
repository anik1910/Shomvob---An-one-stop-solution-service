
namespace Shomvob
{
    partial class Cards
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cards));
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CheckBox = new System.Windows.Forms.CheckBox();
            this.CardHolder = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CVC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.MM = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CardNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Amount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(215, 384);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 50);
            this.button4.TabIndex = 236;
            this.button4.Text = "Pay";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(11, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 15);
            this.label2.TabIndex = 235;
            this.label2.Text = "If you agree to pay, then proceed for the payment";
            // 
            // CheckBox
            // 
            this.CheckBox.AutoSize = true;
            this.CheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckBox.Location = new System.Drawing.Point(12, 286);
            this.CheckBox.Name = "CheckBox";
            this.CheckBox.Size = new System.Drawing.Size(107, 17);
            this.CheckBox.TabIndex = 234;
            this.CheckBox.Text = "Remember Card";
            this.CheckBox.UseVisualStyleBackColor = true;
            // 
            // CardHolder
            // 
            this.CardHolder.BorderColorFocused = System.Drawing.Color.Blue;
            this.CardHolder.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CardHolder.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.CardHolder.BorderThickness = 3;
            this.CardHolder.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardHolder.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CardHolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CardHolder.isPassword = false;
            this.CardHolder.Location = new System.Drawing.Point(11, 224);
            this.CardHolder.Margin = new System.Windows.Forms.Padding(4);
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.Size = new System.Drawing.Size(410, 44);
            this.CardHolder.TabIndex = 233;
            this.CardHolder.Text = "Card Holder";
            this.CardHolder.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CVC
            // 
            this.CVC.BorderColorFocused = System.Drawing.Color.Blue;
            this.CVC.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CVC.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.CVC.BorderThickness = 3;
            this.CVC.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CVC.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CVC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CVC.isPassword = false;
            this.CVC.Location = new System.Drawing.Point(216, 172);
            this.CVC.Margin = new System.Windows.Forms.Padding(4);
            this.CVC.Name = "CVC";
            this.CVC.Size = new System.Drawing.Size(204, 44);
            this.CVC.TabIndex = 232;
            this.CVC.Text = "CVC/CVV";
            this.CVC.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MM
            // 
            this.MM.BorderColorFocused = System.Drawing.Color.Blue;
            this.MM.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MM.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.MM.BorderThickness = 3;
            this.MM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MM.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MM.isPassword = false;
            this.MM.Location = new System.Drawing.Point(11, 172);
            this.MM.Margin = new System.Windows.Forms.Padding(4);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(206, 44);
            this.MM.TabIndex = 231;
            this.MM.Text = "MM/YY";
            this.MM.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // CardNumber
            // 
            this.CardNumber.BorderColorFocused = System.Drawing.Color.Blue;
            this.CardNumber.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CardNumber.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.CardNumber.BorderThickness = 3;
            this.CardNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CardNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CardNumber.isPassword = false;
            this.CardNumber.Location = new System.Drawing.Point(12, 120);
            this.CardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(408, 44);
            this.CardNumber.TabIndex = 230;
            this.CardNumber.Text = "Card Number";
            this.CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(314, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 229;
            this.label1.Text = "Cards Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 227;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(117, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 228;
            this.pictureBox2.TabStop = false;
            // 
            // Amount
            // 
            this.Amount.BorderColorFocused = System.Drawing.Color.Blue;
            this.Amount.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Amount.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.Amount.BorderThickness = 3;
            this.Amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Amount.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Amount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Amount.isPassword = false;
            this.Amount.Location = new System.Drawing.Point(11, 384);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(205, 50);
            this.Amount.TabIndex = 237;
            this.Amount.Text = "Ammount";
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Cards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CheckBox);
            this.Controls.Add(this.CardHolder);
            this.Controls.Add(this.CVC);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Cards";
            this.Size = new System.Drawing.Size(433, 443);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox CheckBox;
        private Bunifu.Framework.UI.BunifuMetroTextbox CardHolder;
        private Bunifu.Framework.UI.BunifuMetroTextbox CVC;
        private Bunifu.Framework.UI.BunifuMetroTextbox MM;
        private Bunifu.Framework.UI.BunifuMetroTextbox CardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuMetroTextbox Amount;
    }
}
