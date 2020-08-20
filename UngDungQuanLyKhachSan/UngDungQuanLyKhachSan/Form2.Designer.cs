namespace UngDungQuanLyKhachSan
{
    partial class DangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.customerTableAdapter1 = new UngDungQuanLyKhachSan.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt_MK = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.txt_TK = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button_DangNhap = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_Thoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(46, 137);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(109, 22);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Tài khoản:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // customerTableAdapter1
            // 
            this.customerTableAdapter1.ClearBeforeFill = true;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(46, 212);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(102, 22);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Mật khẩu:";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel2_Click);
            // 
            // txt_MK
            // 
            this.txt_MK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_MK.BorderColor = System.Drawing.Color.Blue;
            this.txt_MK.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.txt_MK.Location = new System.Drawing.Point(167, 212);
            this.txt_MK.Name = "txt_MK";
            this.txt_MK.Size = new System.Drawing.Size(450, 22);
            this.txt_MK.TabIndex = 2;
            this.txt_MK.Text = "123456";
            this.txt_MK.UseSystemPasswordChar = true;
            // 
            // txt_TK
            // 
            this.txt_TK.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_TK.BorderColor = System.Drawing.Color.Aqua;
            this.txt_TK.Location = new System.Drawing.Point(167, 137);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(450, 22);
            this.txt_TK.TabIndex = 1;
            this.txt_TK.Text = "thuyuyen";
            this.txt_TK.TextChanged += new System.EventHandler(this.bunifuCustomTextbox2_TextChanged);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(277, 40);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(117, 29);
            this.bunifuCustomLabel3.TabIndex = 0;
            this.bunifuCustomLabel3.Text = "Đăng nhập";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // button_DangNhap
            // 
            this.button_DangNhap.ActiveBorderThickness = 1;
            this.button_DangNhap.ActiveCornerRadius = 20;
            this.button_DangNhap.ActiveFillColor = System.Drawing.Color.Navy;
            this.button_DangNhap.ActiveForecolor = System.Drawing.Color.White;
            this.button_DangNhap.ActiveLineColor = System.Drawing.Color.Navy;
            this.button_DangNhap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_DangNhap.BackColor = System.Drawing.SystemColors.Control;
            this.button_DangNhap.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_DangNhap.BackgroundImage")));
            this.button_DangNhap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_DangNhap.ButtonText = "Đăng nhập";
            this.button_DangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DangNhap.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DangNhap.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_DangNhap.IdleBorderThickness = 1;
            this.button_DangNhap.IdleCornerRadius = 20;
            this.button_DangNhap.IdleFillColor = System.Drawing.Color.White;
            this.button_DangNhap.IdleForecolor = System.Drawing.Color.Blue;
            this.button_DangNhap.IdleLineColor = System.Drawing.Color.Blue;
            this.button_DangNhap.Location = new System.Drawing.Point(111, 294);
            this.button_DangNhap.Margin = new System.Windows.Forms.Padding(5);
            this.button_DangNhap.Name = "button_DangNhap";
            this.button_DangNhap.Size = new System.Drawing.Size(181, 50);
            this.button_DangNhap.TabIndex = 3;
            this.button_DangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_DangNhap.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // button_Thoat
            // 
            this.button_Thoat.ActiveBorderThickness = 1;
            this.button_Thoat.ActiveCornerRadius = 20;
            this.button_Thoat.ActiveFillColor = System.Drawing.Color.Navy;
            this.button_Thoat.ActiveForecolor = System.Drawing.Color.White;
            this.button_Thoat.ActiveLineColor = System.Drawing.Color.Navy;
            this.button_Thoat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.button_Thoat.BackColor = System.Drawing.SystemColors.Control;
            this.button_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Thoat.BackgroundImage")));
            this.button_Thoat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button_Thoat.ButtonText = "Thoát";
            this.button_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Thoat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button_Thoat.IdleBorderThickness = 1;
            this.button_Thoat.IdleCornerRadius = 20;
            this.button_Thoat.IdleFillColor = System.Drawing.Color.White;
            this.button_Thoat.IdleForecolor = System.Drawing.Color.Red;
            this.button_Thoat.IdleLineColor = System.Drawing.Color.Red;
            this.button_Thoat.Location = new System.Drawing.Point(367, 294);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(5);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(181, 50);
            this.button_Thoat.TabIndex = 4;
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Thoat.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Location = new System.Drawing.Point(2, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(671, 433);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Đăng nhập ứng dụng";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 450);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.button_DangNhap);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txt_TK);
            this.Controls.Add(this.txt_MK);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.groupBox1);
            this.Name = "DangNhap";
            this.Text = "Đăng nhập ứng dụng";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private DataSet1TableAdapters.CUSTOMERTableAdapter customerTableAdapter1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_MK;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txt_TK;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuThinButton2 button_DangNhap;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Thoat;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}