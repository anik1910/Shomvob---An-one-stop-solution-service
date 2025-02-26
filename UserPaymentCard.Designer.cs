
namespace Shomvob
{
    partial class UserPaymentCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPaymentCard));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gunaGradientCircleButton1 = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CardHolder = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CVC = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.MM = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.CardNumber = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Amount = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Magenta;
            this.button1.Location = new System.Drawing.Point(0, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(224, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Card Payment";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(209, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "Mobile Banking";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // gunaGradientCircleButton1
            // 
            this.gunaGradientCircleButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientCircleButton1.AnimationSpeed = 0.03F;
            this.gunaGradientCircleButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientCircleButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientCircleButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientCircleButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientCircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaGradientCircleButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.Image = null;
            this.gunaGradientCircleButton1.ImageSize = new System.Drawing.Size(52, 52);
            this.gunaGradientCircleButton1.Location = new System.Drawing.Point(154, 12);
            this.gunaGradientCircleButton1.Name = "gunaGradientCircleButton1";
            this.gunaGradientCircleButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientCircleButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientCircleButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientCircleButton1.OnHoverImage = null;
            this.gunaGradientCircleButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientCircleButton1.Size = new System.Drawing.Size(114, 109);
            this.gunaGradientCircleButton1.TabIndex = 6;
            this.gunaGradientCircleButton1.Text = "sslcommerz";
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(217, 599);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 50);
            this.button4.TabIndex = 247;
            this.button4.Text = "Pay";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(317, 15);
            this.label2.TabIndex = 246;
            this.label2.Text = "If you agree to pay, then proceed for the payment";
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
            this.CardHolder.Location = new System.Drawing.Point(12, 456);
            this.CardHolder.Margin = new System.Windows.Forms.Padding(4);
            this.CardHolder.Name = "CardHolder";
            this.CardHolder.Size = new System.Drawing.Size(410, 44);
            this.CardHolder.TabIndex = 244;
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
            this.CVC.Location = new System.Drawing.Point(217, 387);
            this.CVC.Margin = new System.Windows.Forms.Padding(4);
            this.CVC.Name = "CVC";
            this.CVC.Size = new System.Drawing.Size(204, 44);
            this.CVC.TabIndex = 243;
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
            this.MM.Location = new System.Drawing.Point(12, 387);
            this.MM.Margin = new System.Windows.Forms.Padding(4);
            this.MM.Name = "MM";
            this.MM.Size = new System.Drawing.Size(206, 44);
            this.MM.TabIndex = 242;
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
            this.CardNumber.Location = new System.Drawing.Point(13, 320);
            this.CardNumber.Margin = new System.Windows.Forms.Padding(4);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(408, 44);
            this.CardNumber.TabIndex = 241;
            this.CardNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(315, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 15);
            this.label1.TabIndex = 240;
            this.label1.Text = "Cards Payment";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 224);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 238;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 224);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 239;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(13, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 248;
            this.label3.Text = "Card Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 249;
            this.label4.Text = "Year";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(214, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 15);
            this.label5.TabIndex = 250;
            this.label5.Text = "CVC/CVV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 437);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 15);
            this.label6.TabIndex = 251;
            this.label6.Text = "Card Holder";
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
            this.Amount.Location = new System.Drawing.Point(11, 598);
            this.Amount.Margin = new System.Windows.Forms.Padding(4);
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(204, 50);
            this.Amount.TabIndex = 252;
            this.Amount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Rockwell", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(13, 581);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 15);
            this.label7.TabIndex = 253;
            this.label7.Text = "Amount";
            // 
            // UserPaymentCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 661);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CardHolder);
            this.Controls.Add(this.CVC);
            this.Controls.Add(this.MM);
            this.Controls.Add(this.CardNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.gunaGradientCircleButton1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "UserPaymentCard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserPayment";
            this.Load += new System.EventHandler(this.UserPayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Guna.UI.WinForms.GunaGradientCircleButton gunaGradientCircleButton1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMetroTextbox CardHolder;
        private Bunifu.Framework.UI.BunifuMetroTextbox CVC;
        private Bunifu.Framework.UI.BunifuMetroTextbox MM;
        private Bunifu.Framework.UI.BunifuMetroTextbox CardNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuMetroTextbox Amount;
        private System.Windows.Forms.Label label7;
    }
}