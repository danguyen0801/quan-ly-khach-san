namespace UngDungQuanLyKhachSan
{
    partial class quanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(quanLy));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_return = new Bunifu.Framework.UI.BunifuThinButton2();
            this.gridView_1 = new System.Windows.Forms.DataGridView();
            this.ChucNang = new System.Windows.Forms.GroupBox();
            this.button_CapNhatNhanVien = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_CapNhatPhong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_XemDSHoaDon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_Thang = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button_ThongKe = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.button_CapNhatQuyDinh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maxKH = new System.Windows.Forms.NumericUpDown();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.phuThu = new System.Windows.Forms.NumericUpDown();
            this.donGiaA = new System.Windows.Forms.NumericUpDown();
            this.donGiaB = new System.Windows.Forms.NumericUpDown();
            this.donGiaC = new System.Windows.Forms.NumericUpDown();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).BeginInit();
            this.ChucNang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxKH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuThu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaC)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_return);
            this.groupBox2.Controls.Add(this.gridView_1);
            this.groupBox2.Controls.Add(this.bunifuThinButton21);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 459);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // button_return
            // 
            this.button_return.ActiveBorderThickness = 1;
            this.button_return.ActiveCornerRadius = 20;
            this.button_return.ActiveFillColor = System.Drawing.Color.Red;
            this.button_return.ActiveForecolor = System.Drawing.Color.White;
            this.button_return.ActiveLineColor = System.Drawing.Color.Red;
            this.button_return.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_return.BackColor = System.Drawing.SystemColors.Control;
            this.button_return.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_return.BackgroundImage")));
            this.button_return.ButtonText = "Đăng xuất";
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.ForeColor = System.Drawing.Color.Red;
            this.button_return.IdleBorderThickness = 1;
            this.button_return.IdleCornerRadius = 20;
            this.button_return.IdleFillColor = System.Drawing.Color.White;
            this.button_return.IdleForecolor = System.Drawing.Color.Red;
            this.button_return.IdleLineColor = System.Drawing.Color.Red;
            this.button_return.Location = new System.Drawing.Point(944, 424);
            this.button_return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(112, 35);
            this.button_return.TabIndex = 22;
            this.button_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // gridView_1
            // 
            this.gridView_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridView_1.BackgroundColor = System.Drawing.Color.MintCream;
            this.gridView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_1.GridColor = System.Drawing.Color.MintCream;
            this.gridView_1.Location = new System.Drawing.Point(12, 30);
            this.gridView_1.Name = "gridView_1";
            this.gridView_1.RowHeadersWidth = 51;
            this.gridView_1.RowTemplate.Height = 24;
            this.gridView_1.Size = new System.Drawing.Size(1044, 385);
            this.gridView_1.TabIndex = 0;
            // 
            // ChucNang
            // 
            this.ChucNang.Controls.Add(this.bunifuThinButton22);
            this.ChucNang.Controls.Add(this.button_CapNhatNhanVien);
            this.ChucNang.Controls.Add(this.button_CapNhatPhong);
            this.ChucNang.Location = new System.Drawing.Point(19, 12);
            this.ChucNang.Margin = new System.Windows.Forms.Padding(2);
            this.ChucNang.Name = "ChucNang";
            this.ChucNang.Padding = new System.Windows.Forms.Padding(2);
            this.ChucNang.Size = new System.Drawing.Size(198, 204);
            this.ChucNang.TabIndex = 1;
            this.ChucNang.TabStop = false;
            this.ChucNang.Text = "Cập nhật";
            // 
            // button_CapNhatNhanVien
            // 
            this.button_CapNhatNhanVien.ActiveBorderThickness = 1;
            this.button_CapNhatNhanVien.ActiveCornerRadius = 20;
            this.button_CapNhatNhanVien.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_CapNhatNhanVien.ActiveForecolor = System.Drawing.Color.White;
            this.button_CapNhatNhanVien.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_CapNhatNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.button_CapNhatNhanVien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CapNhatNhanVien.BackgroundImage")));
            this.button_CapNhatNhanVien.ButtonText = "Cập nhật Tài khoản";
            this.button_CapNhatNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CapNhatNhanVien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhatNhanVien.ForeColor = System.Drawing.Color.Blue;
            this.button_CapNhatNhanVien.IdleBorderThickness = 1;
            this.button_CapNhatNhanVien.IdleCornerRadius = 20;
            this.button_CapNhatNhanVien.IdleFillColor = System.Drawing.Color.White;
            this.button_CapNhatNhanVien.IdleForecolor = System.Drawing.Color.Blue;
            this.button_CapNhatNhanVien.IdleLineColor = System.Drawing.Color.Blue;
            this.button_CapNhatNhanVien.Location = new System.Drawing.Point(10, 136);
            this.button_CapNhatNhanVien.Margin = new System.Windows.Forms.Padding(6);
            this.button_CapNhatNhanVien.Name = "button_CapNhatNhanVien";
            this.button_CapNhatNhanVien.Size = new System.Drawing.Size(178, 35);
            this.button_CapNhatNhanVien.TabIndex = 4;
            this.button_CapNhatNhanVien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CapNhatNhanVien.Click += new System.EventHandler(this.button_CapNhatNhanVien_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Danh sách phòng";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(756, 424);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(178, 35);
            this.bunifuThinButton21.TabIndex = 3;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // button_CapNhatPhong
            // 
            this.button_CapNhatPhong.ActiveBorderThickness = 1;
            this.button_CapNhatPhong.ActiveCornerRadius = 20;
            this.button_CapNhatPhong.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_CapNhatPhong.ActiveForecolor = System.Drawing.Color.White;
            this.button_CapNhatPhong.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_CapNhatPhong.BackColor = System.Drawing.SystemColors.Control;
            this.button_CapNhatPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CapNhatPhong.BackgroundImage")));
            this.button_CapNhatPhong.ButtonText = "Cập nhật Phòng";
            this.button_CapNhatPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CapNhatPhong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhatPhong.ForeColor = System.Drawing.Color.Blue;
            this.button_CapNhatPhong.IdleBorderThickness = 1;
            this.button_CapNhatPhong.IdleCornerRadius = 20;
            this.button_CapNhatPhong.IdleFillColor = System.Drawing.Color.White;
            this.button_CapNhatPhong.IdleForecolor = System.Drawing.Color.Blue;
            this.button_CapNhatPhong.IdleLineColor = System.Drawing.Color.Blue;
            this.button_CapNhatPhong.Location = new System.Drawing.Point(10, 85);
            this.button_CapNhatPhong.Margin = new System.Windows.Forms.Padding(6);
            this.button_CapNhatPhong.Name = "button_CapNhatPhong";
            this.button_CapNhatPhong.Size = new System.Drawing.Size(178, 35);
            this.button_CapNhatPhong.TabIndex = 2;
            this.button_CapNhatPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CapNhatPhong.Click += new System.EventHandler(this.button_CapNhatPhong_Click);
            // 
            // button_XemDSHoaDon
            // 
            this.button_XemDSHoaDon.ActiveBorderThickness = 1;
            this.button_XemDSHoaDon.ActiveCornerRadius = 20;
            this.button_XemDSHoaDon.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_XemDSHoaDon.ActiveForecolor = System.Drawing.Color.White;
            this.button_XemDSHoaDon.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_XemDSHoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.button_XemDSHoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_XemDSHoaDon.BackgroundImage")));
            this.button_XemDSHoaDon.ButtonText = "Xem Hóa Đơn";
            this.button_XemDSHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_XemDSHoaDon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_XemDSHoaDon.ForeColor = System.Drawing.Color.Blue;
            this.button_XemDSHoaDon.IdleBorderThickness = 1;
            this.button_XemDSHoaDon.IdleCornerRadius = 20;
            this.button_XemDSHoaDon.IdleFillColor = System.Drawing.Color.White;
            this.button_XemDSHoaDon.IdleForecolor = System.Drawing.Color.Blue;
            this.button_XemDSHoaDon.IdleLineColor = System.Drawing.Color.Blue;
            this.button_XemDSHoaDon.Location = new System.Drawing.Point(10, 136);
            this.button_XemDSHoaDon.Margin = new System.Windows.Forms.Padding(6);
            this.button_XemDSHoaDon.Name = "button_XemDSHoaDon";
            this.button_XemDSHoaDon.Size = new System.Drawing.Size(178, 35);
            this.button_XemDSHoaDon.TabIndex = 3;
            this.button_XemDSHoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_XemDSHoaDon.Click += new System.EventHandler(this.button_XemDSHoaDon_Click);
            // 
            // comboBox_Thang
            // 
            this.comboBox_Thang.FormattingEnabled = true;
            this.comboBox_Thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBox_Thang.Location = new System.Drawing.Point(88, 38);
            this.comboBox_Thang.Name = "comboBox_Thang";
            this.comboBox_Thang.Size = new System.Drawing.Size(100, 27);
            this.comboBox_Thang.TabIndex = 5;
            this.comboBox_Thang.Text = "1";
            this.comboBox_Thang.SelectedIndexChanged += new System.EventHandler(this.comboBox_Thang_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button_ThongKe);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.button_XemDSHoaDon);
            this.groupBox3.Controls.Add(this.comboBox_Thang);
            this.groupBox3.Location = new System.Drawing.Point(222, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(199, 204);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Báo cáo thống kê";
            // 
            // button_ThongKe
            // 
            this.button_ThongKe.ActiveBorderThickness = 1;
            this.button_ThongKe.ActiveCornerRadius = 20;
            this.button_ThongKe.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_ThongKe.ActiveForecolor = System.Drawing.Color.White;
            this.button_ThongKe.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_ThongKe.BackColor = System.Drawing.SystemColors.Control;
            this.button_ThongKe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ThongKe.BackgroundImage")));
            this.button_ThongKe.ButtonText = "Báo cáo tháng";
            this.button_ThongKe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThongKe.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThongKe.ForeColor = System.Drawing.Color.Blue;
            this.button_ThongKe.IdleBorderThickness = 1;
            this.button_ThongKe.IdleCornerRadius = 20;
            this.button_ThongKe.IdleFillColor = System.Drawing.Color.White;
            this.button_ThongKe.IdleForecolor = System.Drawing.Color.Blue;
            this.button_ThongKe.IdleLineColor = System.Drawing.Color.Blue;
            this.button_ThongKe.Location = new System.Drawing.Point(10, 85);
            this.button_ThongKe.Margin = new System.Windows.Forms.Padding(6);
            this.button_ThongKe.Name = "button_ThongKe";
            this.button_ThongKe.Size = new System.Drawing.Size(178, 35);
            this.button_ThongKe.TabIndex = 7;
            this.button_ThongKe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_ThongKe.Click += new System.EventHandler(this.button_ThongKe_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tháng: ";
            // 
            // button_CapNhatQuyDinh
            // 
            this.button_CapNhatQuyDinh.ActiveBorderThickness = 1;
            this.button_CapNhatQuyDinh.ActiveCornerRadius = 20;
            this.button_CapNhatQuyDinh.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_CapNhatQuyDinh.ActiveForecolor = System.Drawing.Color.White;
            this.button_CapNhatQuyDinh.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_CapNhatQuyDinh.BackColor = System.Drawing.SystemColors.Control;
            this.button_CapNhatQuyDinh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CapNhatQuyDinh.BackgroundImage")));
            this.button_CapNhatQuyDinh.ButtonText = "Lưu";
            this.button_CapNhatQuyDinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_CapNhatQuyDinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_CapNhatQuyDinh.ForeColor = System.Drawing.Color.Blue;
            this.button_CapNhatQuyDinh.IdleBorderThickness = 1;
            this.button_CapNhatQuyDinh.IdleCornerRadius = 20;
            this.button_CapNhatQuyDinh.IdleFillColor = System.Drawing.Color.White;
            this.button_CapNhatQuyDinh.IdleForecolor = System.Drawing.Color.Blue;
            this.button_CapNhatQuyDinh.IdleLineColor = System.Drawing.Color.Blue;
            this.button_CapNhatQuyDinh.Location = new System.Drawing.Point(457, 135);
            this.button_CapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(6);
            this.button_CapNhatQuyDinh.Name = "button_CapNhatQuyDinh";
            this.button_CapNhatQuyDinh.Size = new System.Drawing.Size(112, 35);
            this.button_CapNhatQuyDinh.TabIndex = 3;
            this.button_CapNhatQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CapNhatQuyDinh.Visible = false;
            this.button_CapNhatQuyDinh.Click += new System.EventHandler(this.button_CapNhatQuyDinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.donGiaC);
            this.groupBox1.Controls.Add(this.donGiaB);
            this.groupBox1.Controls.Add(this.donGiaA);
            this.groupBox1.Controls.Add(this.phuThu);
            this.groupBox1.Controls.Add(this.maxKH);
            this.groupBox1.Controls.Add(this.button_CapNhatQuyDinh);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(427, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 203);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Quy định";
            // 
            // maxKH
            // 
            this.maxKH.Enabled = false;
            this.maxKH.Location = new System.Drawing.Point(425, 38);
            this.maxKH.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxKH.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.maxKH.Name = "maxKH";
            this.maxKH.Size = new System.Drawing.Size(144, 27);
            this.maxKH.TabIndex = 5;
            this.maxKH.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(311, 142);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Chỉnh sửa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khách tối đa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phụ thu (%) : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá loại C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá loại B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn giá loại A: ";
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Cập nhật Nhân viên";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(10, 34);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(178, 35);
            this.bunifuThinButton22.TabIndex = 5;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // phuThu
            // 
            this.phuThu.Enabled = false;
            this.phuThu.Location = new System.Drawing.Point(425, 89);
            this.phuThu.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.phuThu.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.phuThu.Name = "phuThu";
            this.phuThu.Size = new System.Drawing.Size(144, 27);
            this.phuThu.TabIndex = 11;
            this.phuThu.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            // 
            // donGiaA
            // 
            this.donGiaA.Enabled = false;
            this.donGiaA.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.donGiaA.Location = new System.Drawing.Point(129, 38);
            this.donGiaA.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.donGiaA.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.donGiaA.Name = "donGiaA";
            this.donGiaA.Size = new System.Drawing.Size(144, 27);
            this.donGiaA.TabIndex = 12;
            this.donGiaA.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // donGiaB
            // 
            this.donGiaB.Enabled = false;
            this.donGiaB.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.donGiaB.Location = new System.Drawing.Point(129, 89);
            this.donGiaB.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.donGiaB.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.donGiaB.Name = "donGiaB";
            this.donGiaB.Size = new System.Drawing.Size(144, 27);
            this.donGiaB.TabIndex = 13;
            this.donGiaB.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // donGiaC
            // 
            this.donGiaC.Enabled = false;
            this.donGiaC.Increment = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.donGiaC.Location = new System.Drawing.Point(129, 140);
            this.donGiaC.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.donGiaC.Minimum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.donGiaC.Name = "donGiaC";
            this.donGiaC.Size = new System.Drawing.Size(144, 27);
            this.donGiaC.TabIndex = 14;
            this.donGiaC.Value = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            // 
            // quanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 692);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.ChucNang);
            this.Controls.Add(this.groupBox2);
            this.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "quanLy";
            this.Text = "quanLy";
            this.Load += new System.EventHandler(this.quanLy_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).EndInit();
            this.ChucNang.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxKH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phuThu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donGiaC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridView_1;
        private System.Windows.Forms.GroupBox ChucNang;
        private Bunifu.Framework.UI.BunifuThinButton2 button_XemDSHoaDon;
        private Bunifu.Framework.UI.BunifuThinButton2 button_CapNhatPhong;
        private System.Windows.Forms.ComboBox comboBox_Thang;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuThinButton2 button_CapNhatQuyDinh;
        private Bunifu.Framework.UI.BunifuThinButton2 button_ThongKe;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 button_CapNhatNhanVien;
        private System.Windows.Forms.NumericUpDown maxKH;
        private Bunifu.Framework.UI.BunifuThinButton2 button_return;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.NumericUpDown phuThu;
        private System.Windows.Forms.NumericUpDown donGiaC;
        private System.Windows.Forms.NumericUpDown donGiaB;
        private System.Windows.Forms.NumericUpDown donGiaA;
    }
}