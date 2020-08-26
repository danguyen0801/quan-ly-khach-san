namespace UngDungQuanLyKhachSan
{
    partial class capNhatDanhMucPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(capNhatDanhMucPhong));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_ThemPhong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_Loai = new System.Windows.Forms.ComboBox();
            this.txtTenPhong = new System.Windows.Forms.TextBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaPhong = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_checkRoom = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_XoaPhong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_MaPhongXoa = new System.Windows.Forms.ComboBox();
            this.textBoxTenPhong = new System.Windows.Forms.TextBox();
            this.textBoxGhiChu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxLoaiPhong = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_return = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_CapNhat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gridView_1 = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_ThemPhong);
            this.groupBox1.Controls.Add(this.comboBox_Loai);
            this.groupBox1.Controls.Add(this.txtTenPhong);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMaPhong);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(444, 257);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thêm phòng";
            // 
            // button_ThemPhong
            // 
            this.button_ThemPhong.ActiveBorderThickness = 1;
            this.button_ThemPhong.ActiveCornerRadius = 20;
            this.button_ThemPhong.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_ThemPhong.ActiveForecolor = System.Drawing.Color.White;
            this.button_ThemPhong.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_ThemPhong.BackColor = System.Drawing.SystemColors.Control;
            this.button_ThemPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ThemPhong.BackgroundImage")));
            this.button_ThemPhong.ButtonText = "Thêm phòng";
            this.button_ThemPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThemPhong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemPhong.ForeColor = System.Drawing.Color.Blue;
            this.button_ThemPhong.IdleBorderThickness = 1;
            this.button_ThemPhong.IdleCornerRadius = 20;
            this.button_ThemPhong.IdleFillColor = System.Drawing.Color.White;
            this.button_ThemPhong.IdleForecolor = System.Drawing.Color.Blue;
            this.button_ThemPhong.IdleLineColor = System.Drawing.Color.Blue;
            this.button_ThemPhong.Location = new System.Drawing.Point(299, 194);
            this.button_ThemPhong.Margin = new System.Windows.Forms.Padding(6);
            this.button_ThemPhong.Name = "button_ThemPhong";
            this.button_ThemPhong.Size = new System.Drawing.Size(136, 35);
            this.button_ThemPhong.TabIndex = 1;
            this.button_ThemPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_ThemPhong.Click += new System.EventHandler(this.button_ThemPhong_Click);
            // 
            // comboBox_Loai
            // 
            this.comboBox_Loai.FormattingEnabled = true;
            this.comboBox_Loai.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.comboBox_Loai.Location = new System.Drawing.Point(120, 143);
            this.comboBox_Loai.Name = "comboBox_Loai";
            this.comboBox_Loai.Size = new System.Drawing.Size(136, 27);
            this.comboBox_Loai.TabIndex = 10;
            this.comboBox_Loai.Text = "A";
            // 
            // txtTenPhong
            // 
            this.txtTenPhong.Location = new System.Drawing.Point(120, 85);
            this.txtTenPhong.Name = "txtTenPhong";
            this.txtTenPhong.Size = new System.Drawing.Size(136, 27);
            this.txtTenPhong.TabIndex = 9;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(120, 202);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(136, 27);
            this.txtGhiChu.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã Phòng: ";
            // 
            // txtMaPhong
            // 
            this.txtMaPhong.BorderColor = System.Drawing.Color.SeaGreen;
            this.txtMaPhong.Location = new System.Drawing.Point(120, 27);
            this.txtMaPhong.Name = "txtMaPhong";
            this.txtMaPhong.Size = new System.Drawing.Size(136, 27);
            this.txtMaPhong.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Phòng: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 205);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ghi chú: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Loại: ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button_checkRoom);
            this.groupBox2.Controls.Add(this.button_XoaPhong);
            this.groupBox2.Controls.Add(this.comboBox_MaPhongXoa);
            this.groupBox2.Controls.Add(this.textBoxTenPhong);
            this.groupBox2.Controls.Add(this.textBoxGhiChu);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBoxLoaiPhong);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(468, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(444, 257);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Xóa phòng";
            // 
            // button_checkRoom
            // 
            this.button_checkRoom.ActiveBorderThickness = 1;
            this.button_checkRoom.ActiveCornerRadius = 20;
            this.button_checkRoom.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_checkRoom.ActiveForecolor = System.Drawing.Color.White;
            this.button_checkRoom.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_checkRoom.BackColor = System.Drawing.SystemColors.Control;
            this.button_checkRoom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_checkRoom.BackgroundImage")));
            this.button_checkRoom.ButtonText = "Kiểm tra";
            this.button_checkRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_checkRoom.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkRoom.ForeColor = System.Drawing.Color.Blue;
            this.button_checkRoom.IdleBorderThickness = 1;
            this.button_checkRoom.IdleCornerRadius = 20;
            this.button_checkRoom.IdleFillColor = System.Drawing.Color.White;
            this.button_checkRoom.IdleForecolor = System.Drawing.Color.Blue;
            this.button_checkRoom.IdleLineColor = System.Drawing.Color.Blue;
            this.button_checkRoom.Location = new System.Drawing.Point(299, 143);
            this.button_checkRoom.Margin = new System.Windows.Forms.Padding(6);
            this.button_checkRoom.Name = "button_checkRoom";
            this.button_checkRoom.Size = new System.Drawing.Size(136, 35);
            this.button_checkRoom.TabIndex = 11;
            this.button_checkRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_checkRoom.Click += new System.EventHandler(this.button_checkRoom_Click);
            // 
            // button_XoaPhong
            // 
            this.button_XoaPhong.ActiveBorderThickness = 1;
            this.button_XoaPhong.ActiveCornerRadius = 20;
            this.button_XoaPhong.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_XoaPhong.ActiveForecolor = System.Drawing.Color.White;
            this.button_XoaPhong.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_XoaPhong.BackColor = System.Drawing.SystemColors.Control;
            this.button_XoaPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_XoaPhong.BackgroundImage")));
            this.button_XoaPhong.ButtonText = "Xóa phòng";
            this.button_XoaPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_XoaPhong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XoaPhong.ForeColor = System.Drawing.Color.Blue;
            this.button_XoaPhong.IdleBorderThickness = 1;
            this.button_XoaPhong.IdleCornerRadius = 20;
            this.button_XoaPhong.IdleFillColor = System.Drawing.Color.White;
            this.button_XoaPhong.IdleForecolor = System.Drawing.Color.Blue;
            this.button_XoaPhong.IdleLineColor = System.Drawing.Color.Blue;
            this.button_XoaPhong.Location = new System.Drawing.Point(299, 197);
            this.button_XoaPhong.Margin = new System.Windows.Forms.Padding(6);
            this.button_XoaPhong.Name = "button_XoaPhong";
            this.button_XoaPhong.Size = new System.Drawing.Size(136, 35);
            this.button_XoaPhong.TabIndex = 1;
            this.button_XoaPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_XoaPhong.Click += new System.EventHandler(this.button_XoaPhong_Click);
            // 
            // comboBox_MaPhongXoa
            // 
            this.comboBox_MaPhongXoa.FormattingEnabled = true;
            this.comboBox_MaPhongXoa.Location = new System.Drawing.Point(120, 25);
            this.comboBox_MaPhongXoa.Name = "comboBox_MaPhongXoa";
            this.comboBox_MaPhongXoa.Size = new System.Drawing.Size(136, 27);
            this.comboBox_MaPhongXoa.TabIndex = 10;
            // 
            // textBoxTenPhong
            // 
            this.textBoxTenPhong.Enabled = false;
            this.textBoxTenPhong.Location = new System.Drawing.Point(120, 84);
            this.textBoxTenPhong.Name = "textBoxTenPhong";
            this.textBoxTenPhong.Size = new System.Drawing.Size(136, 27);
            this.textBoxTenPhong.TabIndex = 9;
            // 
            // textBoxGhiChu
            // 
            this.textBoxGhiChu.Enabled = false;
            this.textBoxGhiChu.Location = new System.Drawing.Point(120, 201);
            this.textBoxGhiChu.Name = "textBoxGhiChu";
            this.textBoxGhiChu.Size = new System.Drawing.Size(136, 27);
            this.textBoxGhiChu.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Phòng: ";
            // 
            // textBoxLoaiPhong
            // 
            this.textBoxLoaiPhong.BorderColor = System.Drawing.Color.SeaGreen;
            this.textBoxLoaiPhong.Enabled = false;
            this.textBoxLoaiPhong.Location = new System.Drawing.Point(120, 143);
            this.textBoxLoaiPhong.Name = "textBoxLoaiPhong";
            this.textBoxLoaiPhong.Size = new System.Drawing.Size(136, 27);
            this.textBoxLoaiPhong.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 19);
            this.label6.TabIndex = 3;
            this.label6.Text = "Tên Phòng: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ghi chú: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Loại: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_return);
            this.groupBox3.Controls.Add(this.button_CapNhat);
            this.groupBox3.Controls.Add(this.gridView_1);
            this.groupBox3.Location = new System.Drawing.Point(12, 275);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(900, 454);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chi tiết";
            // 
            // button_return
            // 
            this.button_return.ActiveBorderThickness = 1;
            this.button_return.ActiveCornerRadius = 20;
            this.button_return.ActiveFillColor = System.Drawing.Color.Red;
            this.button_return.ActiveForecolor = System.Drawing.Color.White;
            this.button_return.ActiveLineColor = System.Drawing.Color.Red;
            this.button_return.BackColor = System.Drawing.SystemColors.Control;
            this.button_return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_return.BackgroundImage")));
            this.button_return.ButtonText = "Thoát";
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.ForeColor = System.Drawing.Color.Red;
            this.button_return.IdleBorderThickness = 1;
            this.button_return.IdleCornerRadius = 20;
            this.button_return.IdleFillColor = System.Drawing.Color.White;
            this.button_return.IdleForecolor = System.Drawing.Color.Red;
            this.button_return.IdleLineColor = System.Drawing.Color.Red;
            this.button_return.Location = new System.Drawing.Point(755, 392);
            this.button_return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(136, 35);
            this.button_return.TabIndex = 21;
            this.button_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // button_CapNhat
            // 
            this.button_CapNhat.ActiveBorderThickness = 1;
            this.button_CapNhat.ActiveCornerRadius = 20;
            this.button_CapNhat.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_CapNhat.ActiveForecolor = System.Drawing.Color.White;
            this.button_CapNhat.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_CapNhat.BackColor = System.Drawing.SystemColors.Control;
            this.button_CapNhat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CapNhat.BackgroundImage")));
            this.button_CapNhat.ButtonText = "Cập nhật";
            this.button_CapNhat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CapNhat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhat.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_CapNhat.IdleBorderThickness = 1;
            this.button_CapNhat.IdleCornerRadius = 20;
            this.button_CapNhat.IdleFillColor = System.Drawing.Color.White;
            this.button_CapNhat.IdleForecolor = System.Drawing.Color.Blue;
            this.button_CapNhat.IdleLineColor = System.Drawing.Color.Blue;
            this.button_CapNhat.Location = new System.Drawing.Point(614, 392);
            this.button_CapNhat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_CapNhat.Name = "button_CapNhat";
            this.button_CapNhat.Size = new System.Drawing.Size(136, 35);
            this.button_CapNhat.TabIndex = 19;
            this.button_CapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CapNhat.Click += new System.EventHandler(this.button_CapNhat_Click);
            // 
            // gridView_1
            // 
            this.gridView_1.BackgroundColor = System.Drawing.Color.MintCream;
            this.gridView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_1.GridColor = System.Drawing.Color.MintCream;
            this.gridView_1.Location = new System.Drawing.Point(11, 21);
            this.gridView_1.Name = "gridView_1";
            this.gridView_1.RowHeadersWidth = 51;
            this.gridView_1.RowTemplate.Height = 24;
            this.gridView_1.Size = new System.Drawing.Size(880, 363);
            this.gridView_1.TabIndex = 14;
            // 
            // capNhatDanhMucPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 741);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "capNhatDanhMucPhong";
            this.Text = "capNhatDanhMucPhong";
            this.Load += new System.EventHandler(this.capNhatDanhMucPhong_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 button_ThemPhong;
        private System.Windows.Forms.ComboBox comboBox_Loai;
        private System.Windows.Forms.TextBox txtTenPhong;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label4;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox txtMaPhong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 button_XoaPhong;
        private System.Windows.Forms.ComboBox comboBox_MaPhongXoa;
        private System.Windows.Forms.TextBox textBoxTenPhong;
        private System.Windows.Forms.TextBox textBoxGhiChu;
        private System.Windows.Forms.Label label5;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox textBoxLoaiPhong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView gridView_1;
        private Bunifu.Framework.UI.BunifuThinButton2 button_CapNhat;
        private Bunifu.Framework.UI.BunifuThinButton2 button_return;
        private Bunifu.Framework.UI.BunifuThinButton2 button_checkRoom;
    }
}