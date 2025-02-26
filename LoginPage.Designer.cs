
namespace Shomvob
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.password = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LoginButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ShowPasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.ClearLabel = new System.Windows.Forms.Label();
            this.UserRadio = new System.Windows.Forms.RadioButton();
            this.RiderRadio = new System.Windows.Forms.RadioButton();
            this.ExpertRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(381, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 351);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(94, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 8;
            this.label5.Text = "Login as: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Symbol", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(43, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(233, 40);
            this.label4.TabIndex = 5;
            this.label4.Text = "Welcome Back !";
            // 
            // name
            // 
            this.name.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.name.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.name.ForeColor = System.Drawing.Color.Black;
            this.name.HintForeColor = System.Drawing.Color.Empty;
            this.name.HintText = "";
            this.name.isPassword = false;
            this.name.LineFocusedColor = System.Drawing.Color.LawnGreen;
            this.name.LineIdleColor = System.Drawing.Color.Gray;
            this.name.LineMouseHoverColor = System.Drawing.Color.LawnGreen;
            this.name.LineThickness = 3;
            this.name.Location = new System.Drawing.Point(42, 185);
            this.name.Margin = new System.Windows.Forms.Padding(4);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(222, 33);
            this.name.TabIndex = 9;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.name.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
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
            this.password.Location = new System.Drawing.Point(42, 246);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(222, 33);
            this.password.TabIndex = 10;
            this.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LoginButton
            // 
            this.LoginButton.ActiveBorderThickness = 1;
            this.LoginButton.ActiveCornerRadius = 20;
            this.LoginButton.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.LoginButton.ActiveForecolor = System.Drawing.Color.Black;
            this.LoginButton.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.LoginButton.BackColor = System.Drawing.Color.MintCream;
            this.LoginButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoginButton.BackgroundImage")));
            this.LoginButton.ButtonText = "Log In";
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginButton.ForeColor = System.Drawing.Color.Black;
            this.LoginButton.IdleBorderThickness = 1;
            this.LoginButton.IdleCornerRadius = 20;
            this.LoginButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.LoginButton.IdleForecolor = System.Drawing.Color.Black;
            this.LoginButton.IdleLineColor = System.Drawing.Color.Black;
            this.LoginButton.Location = new System.Drawing.Point(80, 342);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(126, 47);
            this.LoginButton.TabIndex = 10;
            this.LoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoginButton.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // ShowPasswordCheckBox
            // 
            this.ShowPasswordCheckBox.AutoSize = true;
            this.ShowPasswordCheckBox.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowPasswordCheckBox.Location = new System.Drawing.Point(169, 303);
            this.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox";
            this.ShowPasswordCheckBox.Size = new System.Drawing.Size(107, 17);
            this.ShowPasswordCheckBox.TabIndex = 15;
            this.ShowPasswordCheckBox.Text = "Show Password";
            this.ShowPasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowPasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowPasswordCheckBox_CheckedChanged);
            // 
            // ClearLabel
            // 
            this.ClearLabel.AutoSize = true;
            this.ClearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearLabel.Location = new System.Drawing.Point(39, 302);
            this.ClearLabel.Name = "ClearLabel";
            this.ClearLabel.Size = new System.Drawing.Size(45, 16);
            this.ClearLabel.TabIndex = 16;
            this.ClearLabel.Text = "Clear";
            this.ClearLabel.Click += new System.EventHandler(this.ClearLabel_Click);
            // 
            // UserRadio
            // 
            this.UserRadio.AutoSize = true;
            this.UserRadio.Location = new System.Drawing.Point(44, 125);
            this.UserRadio.Name = "UserRadio";
            this.UserRadio.Size = new System.Drawing.Size(47, 17);
            this.UserRadio.TabIndex = 18;
            this.UserRadio.TabStop = true;
            this.UserRadio.Text = "User";
            this.UserRadio.UseVisualStyleBackColor = true;
            this.UserRadio.CheckedChanged += new System.EventHandler(this.UserRadio_CheckedChanged);
            // 
            // RiderRadio
            // 
            this.RiderRadio.AutoSize = true;
            this.RiderRadio.Location = new System.Drawing.Point(120, 125);
            this.RiderRadio.Name = "RiderRadio";
            this.RiderRadio.Size = new System.Drawing.Size(50, 17);
            this.RiderRadio.TabIndex = 19;
            this.RiderRadio.TabStop = true;
            this.RiderRadio.Text = "Rider";
            this.RiderRadio.UseVisualStyleBackColor = true;
            this.RiderRadio.CheckedChanged += new System.EventHandler(this.RiderRadio_CheckedChanged);
            // 
            // ExpertRadio
            // 
            this.ExpertRadio.AutoSize = true;
            this.ExpertRadio.Location = new System.Drawing.Point(200, 125);
            this.ExpertRadio.Name = "ExpertRadio";
            this.ExpertRadio.Size = new System.Drawing.Size(55, 17);
            this.ExpertRadio.TabIndex = 20;
            this.ExpertRadio.TabStop = true;
            this.ExpertRadio.Text = "Expert";
            this.ExpertRadio.UseVisualStyleBackColor = true;
            this.ExpertRadio.CheckedChanged += new System.EventHandler(this.ExpertRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Userame";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.MintCream;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.ExpertRadio);
            this.panel1.Controls.Add(this.RiderRadio);
            this.panel1.Controls.Add(this.UserRadio);
            this.panel1.Controls.Add(this.ClearLabel);
            this.panel1.Controls.Add(this.ShowPasswordCheckBox);
            this.panel1.Controls.Add(this.LoginButton);
            this.panel1.Controls.Add(this.password);
            this.panel1.Controls.Add(this.name);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(46, 91);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(306, 403);
            this.panel1.TabIndex = 9;
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.LawnGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.LawnGreen;
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Back";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.Black;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.Black;
            this.bunifuThinButton23.Location = new System.Drawing.Point(32, 29);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(53, 37);
            this.bunifuThinButton23.TabIndex = 115;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.bunifuThinButton23_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.bunifuThinButton23);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginPage";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox password;
        private Bunifu.Framework.UI.BunifuThinButton2 LoginButton;
        private System.Windows.Forms.CheckBox ShowPasswordCheckBox;
        private System.Windows.Forms.Label ClearLabel;
        private System.Windows.Forms.RadioButton UserRadio;
        private System.Windows.Forms.RadioButton RiderRadio;
        private System.Windows.Forms.RadioButton ExpertRadio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        public Bunifu.Framework.UI.BunifuMaterialTextbox name;
    }
}

