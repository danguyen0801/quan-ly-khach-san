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
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_return = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).BeginInit();
            this.ChucNang.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button_return);
            this.groupBox2.Controls.Add(this.gridView_1);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(19, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1068, 459);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
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
            this.ChucNang.Controls.Add(this.button_CapNhatNhanVien);
            this.ChucNang.Controls.Add(this.bunifuThinButton21);
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
            this.button_CapNhatNhanVien.Location = new System.Drawing.Point(8, 134);
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
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Danh sách Phòng";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton21.Location = new System.Drawing.Point(8, 22);
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
            this.button_CapNhatPhong.Location = new System.Drawing.Point(8, 78);
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
            this.button_XemDSHoaDon.Location = new System.Drawing.Point(10, 134);
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
            this.comboBox_Thang.Location = new System.Drawing.Point(88, 31);
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
            this.button_ThongKe.Location = new System.Drawing.Point(10, 78);
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
            this.label5.Location = new System.Drawing.Point(6, 33);
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
            this.button_CapNhatQuyDinh.Location = new System.Drawing.Point(559, 132);
            this.button_CapNhatQuyDinh.Margin = new System.Windows.Forms.Padding(6);
            this.button_CapNhatQuyDinh.Name = "button_CapNhatQuyDinh";
            this.button_CapNhatQuyDinh.Size = new System.Drawing.Size(89, 36);
            this.button_CapNhatQuyDinh.TabIndex = 3;
            this.button_CapNhatQuyDinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_CapNhatQuyDinh.Click += new System.EventHandler(this.button_CapNhatQuyDinh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.button_CapNhatQuyDinh);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
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
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(425, 34);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(144, 27);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(425, 86);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(144, 27);
            this.textBox4.TabIndex = 11;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(311, 143);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 23);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Chỉnh sửa";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(132, 144);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(144, 27);
            this.textBox3.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(132, 88);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 27);
            this.textBox2.TabIndex = 7;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(132, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 27);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 19);
            this.label6.TabIndex = 4;
            this.label6.Text = "Khách tối đa: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(307, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Phụ thu: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá loại C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đơn giá loại B:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đơn giá loại A: ";
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
            this.button_return.ButtonText = "Thoát";
            this.button_return.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_return.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_return.ForeColor = System.Drawing.Color.Red;
            this.button_return.IdleBorderThickness = 1;
            this.button_return.IdleCornerRadius = 20;
            this.button_return.IdleFillColor = System.Drawing.Color.White;
            this.button_return.IdleForecolor = System.Drawing.Color.Red;
            this.button_return.IdleLineColor = System.Drawing.Color.Red;
            this.button_return.Location = new System.Drawing.Point(967, 424);
            this.button_return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(89, 35);
            this.button_return.TabIndex = 22;
            this.button_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.TextBox textBox4;
        private Bunifu.Framework.UI.BunifuThinButton2 button_CapNhatNhanVien;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private Bunifu.Framework.UI.BunifuThinButton2 button_return;
    }
}