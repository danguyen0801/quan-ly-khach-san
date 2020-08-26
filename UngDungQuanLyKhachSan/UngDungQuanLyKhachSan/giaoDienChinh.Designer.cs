namespace UngDungQuanLyKhachSan
{
    partial class Form_Main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.groupbox_Timkiem = new System.Windows.Forms.GroupBox();
            this.button_TinhTien = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_ThemNguoi = new Bunifu.Framework.UI.BunifuThinButton2();
            this.txt_tenKhachhang = new System.Windows.Forms.TextBox();
            this.label_Khachhang = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_SoPhong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button_TimTen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_phongDaThue = new System.Windows.Forms.ComboBox();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UngDungQuanLyKhachSan.DataSet1();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rOOMTableAdapter = new UngDungQuanLyKhachSan.DataSet1TableAdapters.ROOMTableAdapter();
            this.gridView_1 = new System.Windows.Forms.DataGridView();
            this.rOOMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupbox_ThongTin = new System.Windows.Forms.GroupBox();
            this.button_HoaDon = new Bunifu.Framework.UI.BunifuThinButton2();
            this.traPhong = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phongThanhToan = new System.Windows.Forms.Label();
            this.tienThanhToan = new System.Windows.Forms.Label();
            this.ngayThue = new System.Windows.Forms.Label();
            this.comboBox_tenKH = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Ngay = new System.Windows.Forms.Label();
            this.label_PhongThanhToan = new System.Windows.Forms.Label();
            this.label_TenKhach = new System.Windows.Forms.Label();
            this.cUSTOMERTableAdapter = new UngDungQuanLyKhachSan.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_xemPhongTrongC = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_xemPhongTrongB = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button_xemPhongTrongA = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_PhongTrong = new System.Windows.Forms.ComboBox();
            this.button_Thoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button_return = new Bunifu.Framework.UI.BunifuThinButton2();
            this.groupbox_Timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).BeginInit();
            this.groupbox_ThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_Timkiem
            // 
            this.groupbox_Timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.groupbox_Timkiem.Controls.Add(this.button_TinhTien);
            this.groupbox_Timkiem.Controls.Add(this.button_ThemNguoi);
            this.groupbox_Timkiem.Controls.Add(this.txt_tenKhachhang);
            this.groupbox_Timkiem.Controls.Add(this.label_Khachhang);
            this.groupbox_Timkiem.Controls.Add(this.Label_SoPhong);
            this.groupbox_Timkiem.Controls.Add(this.button_TimTen);
            this.groupbox_Timkiem.Controls.Add(this.comboBox_phongDaThue);
            this.groupbox_Timkiem.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_Timkiem.Location = new System.Drawing.Point(12, 149);
            this.groupbox_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_Timkiem.Name = "groupbox_Timkiem";
            this.groupbox_Timkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_Timkiem.Size = new System.Drawing.Size(467, 178);
            this.groupbox_Timkiem.TabIndex = 0;
            this.groupbox_Timkiem.TabStop = false;
            this.groupbox_Timkiem.Text = "Tra cứu phòng đang thuê";
            // 
            // button_TinhTien
            // 
            this.button_TinhTien.ActiveBorderThickness = 1;
            this.button_TinhTien.ActiveCornerRadius = 20;
            this.button_TinhTien.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_TinhTien.ActiveForecolor = System.Drawing.Color.White;
            this.button_TinhTien.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_TinhTien.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TinhTien.BackColor = System.Drawing.SystemColors.Control;
            this.button_TinhTien.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_TinhTien.BackgroundImage")));
            this.button_TinhTien.ButtonText = "Thanh Toán";
            this.button_TinhTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TinhTien.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TinhTien.ForeColor = System.Drawing.Color.Blue;
            this.button_TinhTien.IdleBorderThickness = 1;
            this.button_TinhTien.IdleCornerRadius = 20;
            this.button_TinhTien.IdleFillColor = System.Drawing.Color.White;
            this.button_TinhTien.IdleForecolor = System.Drawing.Color.Blue;
            this.button_TinhTien.IdleLineColor = System.Drawing.Color.Blue;
            this.button_TinhTien.Location = new System.Drawing.Point(292, 136);
            this.button_TinhTien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TinhTien.Name = "button_TinhTien";
            this.button_TinhTien.Size = new System.Drawing.Size(136, 35);
            this.button_TinhTien.TabIndex = 19;
            this.button_TinhTien.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_TinhTien.Click += new System.EventHandler(this.button_TinhTien_Click);
            // 
            // button_ThemNguoi
            // 
            this.button_ThemNguoi.ActiveBorderThickness = 1;
            this.button_ThemNguoi.ActiveCornerRadius = 20;
            this.button_ThemNguoi.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_ThemNguoi.ActiveForecolor = System.Drawing.Color.White;
            this.button_ThemNguoi.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_ThemNguoi.BackColor = System.Drawing.SystemColors.Control;
            this.button_ThemNguoi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_ThemNguoi.BackgroundImage")));
            this.button_ThemNguoi.ButtonText = "Thêm người";
            this.button_ThemNguoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_ThemNguoi.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ThemNguoi.ForeColor = System.Drawing.Color.Blue;
            this.button_ThemNguoi.IdleBorderThickness = 1;
            this.button_ThemNguoi.IdleCornerRadius = 20;
            this.button_ThemNguoi.IdleFillColor = System.Drawing.Color.White;
            this.button_ThemNguoi.IdleForecolor = System.Drawing.Color.Blue;
            this.button_ThemNguoi.IdleLineColor = System.Drawing.Color.Blue;
            this.button_ThemNguoi.Location = new System.Drawing.Point(148, 136);
            this.button_ThemNguoi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_ThemNguoi.Name = "button_ThemNguoi";
            this.button_ThemNguoi.Size = new System.Drawing.Size(136, 35);
            this.button_ThemNguoi.TabIndex = 18;
            this.button_ThemNguoi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_ThemNguoi.Click += new System.EventHandler(this.button_ThemNguoi_Click);
            // 
            // txt_tenKhachhang
            // 
            this.txt_tenKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenKhachhang.Location = new System.Drawing.Point(148, 100);
            this.txt_tenKhachhang.Name = "txt_tenKhachhang";
            this.txt_tenKhachhang.Size = new System.Drawing.Size(280, 22);
            this.txt_tenKhachhang.TabIndex = 18;
            // 
            // label_Khachhang
            // 
            this.label_Khachhang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Khachhang.AutoSize = true;
            this.label_Khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khachhang.Location = new System.Drawing.Point(17, 101);
            this.label_Khachhang.Name = "label_Khachhang";
            this.label_Khachhang.Size = new System.Drawing.Size(111, 20);
            this.label_Khachhang.TabIndex = 17;
            this.label_Khachhang.Text = "Khách Hàng";
            // 
            // Label_SoPhong
            // 
            this.Label_SoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SoPhong.AutoSize = true;
            this.Label_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SoPhong.Location = new System.Drawing.Point(17, 46);
            this.Label_SoPhong.Name = "Label_SoPhong";
            this.Label_SoPhong.Size = new System.Drawing.Size(89, 20);
            this.Label_SoPhong.TabIndex = 15;
            this.Label_SoPhong.Text = "Số Phòng";
            // 
            // button_TimTen
            // 
            this.button_TimTen.ActiveBorderThickness = 1;
            this.button_TimTen.ActiveCornerRadius = 20;
            this.button_TimTen.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.ActiveForecolor = System.Drawing.Color.White;
            this.button_TimTen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TimTen.BackColor = System.Drawing.SystemColors.Control;
            this.button_TimTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_TimTen.BackgroundImage")));
            this.button_TimTen.ButtonText = "Tìm ";
            this.button_TimTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TimTen.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_TimTen.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.IdleBorderThickness = 1;
            this.button_TimTen.IdleCornerRadius = 20;
            this.button_TimTen.IdleFillColor = System.Drawing.Color.White;
            this.button_TimTen.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.Location = new System.Drawing.Point(3, 136);
            this.button_TimTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TimTen.Name = "button_TimTen";
            this.button_TimTen.Size = new System.Drawing.Size(136, 35);
            this.button_TimTen.TabIndex = 13;
            this.button_TimTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_TimTen.Click += new System.EventHandler(this.button_TimTen_Click);
            // 
            // comboBox_phongDaThue
            // 
            this.comboBox_phongDaThue.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_phongDaThue.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_phongDaThue.FormattingEnabled = true;
            this.comboBox_phongDaThue.Location = new System.Drawing.Point(148, 44);
            this.comboBox_phongDaThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_phongDaThue.Name = "comboBox_phongDaThue";
            this.comboBox_phongDaThue.Size = new System.Drawing.Size(280, 24);
            this.comboBox_phongDaThue.TabIndex = 8;
            // 
            // rOOMBindingSource
            // 
            this.rOOMBindingSource.DataMember = "ROOM";
            this.rOOMBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // rOOMTableAdapter
            // 
            this.rOOMTableAdapter.ClearBeforeFill = true;
            // 
            // gridView_1
            // 
            this.gridView_1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridView_1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.gridView_1.BackgroundColor = System.Drawing.Color.MintCream;
            this.gridView_1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridView_1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridView_1.Location = new System.Drawing.Point(3, 18);
            this.gridView_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridView_1.Name = "gridView_1";
            this.gridView_1.RowHeadersVisible = false;
            this.gridView_1.RowHeadersWidth = 51;
            this.gridView_1.RowTemplate.Height = 24;
            this.gridView_1.Size = new System.Drawing.Size(1006, 293);
            this.gridView_1.TabIndex = 12;
            this.gridView_1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridView_1_CellContentClick);
            // 
            // rOOMBindingSource1
            // 
            this.rOOMBindingSource1.DataMember = "ROOM";
            this.rOOMBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // groupbox_ThongTin
            // 
            this.groupbox_ThongTin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox_ThongTin.Controls.Add(this.button_HoaDon);
            this.groupbox_ThongTin.Controls.Add(this.traPhong);
            this.groupbox_ThongTin.Controls.Add(this.label2);
            this.groupbox_ThongTin.Controls.Add(this.phongThanhToan);
            this.groupbox_ThongTin.Controls.Add(this.tienThanhToan);
            this.groupbox_ThongTin.Controls.Add(this.ngayThue);
            this.groupbox_ThongTin.Controls.Add(this.comboBox_tenKH);
            this.groupbox_ThongTin.Controls.Add(this.label4);
            this.groupbox_ThongTin.Controls.Add(this.label_Ngay);
            this.groupbox_ThongTin.Controls.Add(this.label_PhongThanhToan);
            this.groupbox_ThongTin.Controls.Add(this.label_TenKhach);
            this.groupbox_ThongTin.Location = new System.Drawing.Point(494, 11);
            this.groupbox_ThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ThongTin.Name = "groupbox_ThongTin";
            this.groupbox_ThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ThongTin.Size = new System.Drawing.Size(530, 316);
            this.groupbox_ThongTin.TabIndex = 1;
            this.groupbox_ThongTin.TabStop = false;
            this.groupbox_ThongTin.Text = "Thông Tin Thanh Toán";
            // 
            // button_HoaDon
            // 
            this.button_HoaDon.ActiveBorderThickness = 1;
            this.button_HoaDon.ActiveCornerRadius = 20;
            this.button_HoaDon.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_HoaDon.ActiveForecolor = System.Drawing.Color.White;
            this.button_HoaDon.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_HoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button_HoaDon.BackColor = System.Drawing.SystemColors.Control;
            this.button_HoaDon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_HoaDon.BackgroundImage")));
            this.button_HoaDon.ButtonText = "Xác nhận";
            this.button_HoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_HoaDon.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_HoaDon.ForeColor = System.Drawing.Color.Blue;
            this.button_HoaDon.IdleBorderThickness = 1;
            this.button_HoaDon.IdleCornerRadius = 20;
            this.button_HoaDon.IdleFillColor = System.Drawing.Color.White;
            this.button_HoaDon.IdleForecolor = System.Drawing.Color.Blue;
            this.button_HoaDon.IdleLineColor = System.Drawing.Color.Blue;
            this.button_HoaDon.Location = new System.Drawing.Point(371, 274);
            this.button_HoaDon.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_HoaDon.Name = "button_HoaDon";
            this.button_HoaDon.Size = new System.Drawing.Size(136, 35);
            this.button_HoaDon.TabIndex = 20;
            this.button_HoaDon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_HoaDon.Click += new System.EventHandler(this.button_HoaDon_Click);
            // 
            // traPhong
            // 
            this.traPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.traPhong.AutoSize = true;
            this.traPhong.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traPhong.Location = new System.Drawing.Point(223, 146);
            this.traPhong.Name = "traPhong";
            this.traPhong.Size = new System.Drawing.Size(73, 19);
            this.traPhong.TabIndex = 25;
            this.traPhong.Text = "1/1/2020";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 19);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ngày trả phòng: ";
            // 
            // phongThanhToan
            // 
            this.phongThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.phongThanhToan.AutoSize = true;
            this.phongThanhToan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phongThanhToan.Location = new System.Drawing.Point(223, 70);
            this.phongThanhToan.Name = "phongThanhToan";
            this.phongThanhToan.Size = new System.Drawing.Size(47, 19);
            this.phongThanhToan.TabIndex = 23;
            this.phongThanhToan.Text = "P000";
            // 
            // tienThanhToan
            // 
            this.tienThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tienThanhToan.AutoSize = true;
            this.tienThanhToan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tienThanhToan.Location = new System.Drawing.Point(223, 184);
            this.tienThanhToan.Name = "tienThanhToan";
            this.tienThanhToan.Size = new System.Drawing.Size(72, 19);
            this.tienThanhToan.TabIndex = 22;
            this.tienThanhToan.Text = "0000000";
            // 
            // ngayThue
            // 
            this.ngayThue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ngayThue.AutoSize = true;
            this.ngayThue.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ngayThue.Location = new System.Drawing.Point(223, 108);
            this.ngayThue.Name = "ngayThue";
            this.ngayThue.Size = new System.Drawing.Size(73, 19);
            this.ngayThue.TabIndex = 21;
            this.ngayThue.Text = "1/1/2020";
            // 
            // comboBox_tenKH
            // 
            this.comboBox_tenKH.FormattingEnabled = true;
            this.comboBox_tenKH.Location = new System.Drawing.Point(227, 27);
            this.comboBox_tenKH.Name = "comboBox_tenKH";
            this.comboBox_tenKH.Size = new System.Drawing.Size(280, 24);
            this.comboBox_tenKH.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền: ";
            // 
            // label_Ngay
            // 
            this.label_Ngay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Ngay.AutoSize = true;
            this.label_Ngay.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ngay.Location = new System.Drawing.Point(39, 108);
            this.label_Ngay.Name = "label_Ngay";
            this.label_Ngay.Size = new System.Drawing.Size(93, 19);
            this.label_Ngay.TabIndex = 2;
            this.label_Ngay.Text = "Ngày thuê: ";
            // 
            // label_PhongThanhToan
            // 
            this.label_PhongThanhToan.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_PhongThanhToan.AutoSize = true;
            this.label_PhongThanhToan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PhongThanhToan.Location = new System.Drawing.Point(39, 70);
            this.label_PhongThanhToan.Name = "label_PhongThanhToan";
            this.label_PhongThanhToan.Size = new System.Drawing.Size(91, 19);
            this.label_PhongThanhToan.TabIndex = 1;
            this.label_PhongThanhToan.Text = "Số Phòng: ";
            // 
            // label_TenKhach
            // 
            this.label_TenKhach.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_TenKhach.AutoSize = true;
            this.label_TenKhach.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_TenKhach.Location = new System.Drawing.Point(39, 32);
            this.label_TenKhach.Name = "label_TenKhach";
            this.label_TenKhach.Size = new System.Drawing.Size(141, 19);
            this.label_TenKhach.TabIndex = 0;
            this.label_TenKhach.Text = "Tên Khách Hàng: ";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.groupBox1.Controls.Add(this.button_xemPhongTrongC);
            this.groupBox1.Controls.Add(this.button_xemPhongTrongB);
            this.groupBox1.Controls.Add(this.bunifuThinButton22);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.button_xemPhongTrongA);
            this.groupBox1.Controls.Add(this.comboBox_PhongTrong);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(467, 118);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu phòng trống";
            // 
            // button_xemPhongTrongC
            // 
            this.button_xemPhongTrongC.ActiveBorderThickness = 1;
            this.button_xemPhongTrongC.ActiveCornerRadius = 20;
            this.button_xemPhongTrongC.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongC.ActiveForecolor = System.Drawing.Color.White;
            this.button_xemPhongTrongC.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongC.BackColor = System.Drawing.SystemColors.Control;
            this.button_xemPhongTrongC.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_xemPhongTrongC.BackgroundImage")));
            this.button_xemPhongTrongC.ButtonText = "Loại C";
            this.button_xemPhongTrongC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xemPhongTrongC.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xemPhongTrongC.ForeColor = System.Drawing.Color.DeepPink;
            this.button_xemPhongTrongC.IdleBorderThickness = 1;
            this.button_xemPhongTrongC.IdleCornerRadius = 20;
            this.button_xemPhongTrongC.IdleFillColor = System.Drawing.Color.White;
            this.button_xemPhongTrongC.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongC.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongC.Location = new System.Drawing.Point(291, 66);
            this.button_xemPhongTrongC.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xemPhongTrongC.Name = "button_xemPhongTrongC";
            this.button_xemPhongTrongC.Size = new System.Drawing.Size(136, 35);
            this.button_xemPhongTrongC.TabIndex = 18;
            this.button_xemPhongTrongC.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_xemPhongTrongC.Click += new System.EventHandler(this.button_xemPhongTrongC_Click);
            // 
            // button_xemPhongTrongB
            // 
            this.button_xemPhongTrongB.ActiveBorderThickness = 1;
            this.button_xemPhongTrongB.ActiveCornerRadius = 20;
            this.button_xemPhongTrongB.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongB.ActiveForecolor = System.Drawing.Color.White;
            this.button_xemPhongTrongB.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongB.BackColor = System.Drawing.SystemColors.Control;
            this.button_xemPhongTrongB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_xemPhongTrongB.BackgroundImage")));
            this.button_xemPhongTrongB.ButtonText = "Loại B";
            this.button_xemPhongTrongB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xemPhongTrongB.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xemPhongTrongB.ForeColor = System.Drawing.Color.DeepPink;
            this.button_xemPhongTrongB.IdleBorderThickness = 1;
            this.button_xemPhongTrongB.IdleCornerRadius = 20;
            this.button_xemPhongTrongB.IdleFillColor = System.Drawing.Color.White;
            this.button_xemPhongTrongB.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongB.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongB.Location = new System.Drawing.Point(147, 66);
            this.button_xemPhongTrongB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xemPhongTrongB.Name = "button_xemPhongTrongB";
            this.button_xemPhongTrongB.Size = new System.Drawing.Size(136, 35);
            this.button_xemPhongTrongB.TabIndex = 17;
            this.button_xemPhongTrongB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_xemPhongTrongB.Click += new System.EventHandler(this.button_xemPhongTrongB_Click);
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
            this.bunifuThinButton22.ButtonText = "Thuê Phòng";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(292, 19);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(136, 35);
            this.bunifuThinButton22.TabIndex = 16;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.bunifuThinButton22_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 27);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(85, 19);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Số phòng";
            // 
            // button_xemPhongTrongA
            // 
            this.button_xemPhongTrongA.ActiveBorderThickness = 1;
            this.button_xemPhongTrongA.ActiveCornerRadius = 20;
            this.button_xemPhongTrongA.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongA.ActiveForecolor = System.Drawing.Color.White;
            this.button_xemPhongTrongA.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongA.BackColor = System.Drawing.SystemColors.Control;
            this.button_xemPhongTrongA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_xemPhongTrongA.BackgroundImage")));
            this.button_xemPhongTrongA.ButtonText = "Loại A";
            this.button_xemPhongTrongA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xemPhongTrongA.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xemPhongTrongA.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.button_xemPhongTrongA.IdleBorderThickness = 1;
            this.button_xemPhongTrongA.IdleCornerRadius = 20;
            this.button_xemPhongTrongA.IdleFillColor = System.Drawing.Color.White;
            this.button_xemPhongTrongA.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongA.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrongA.Location = new System.Drawing.Point(3, 66);
            this.button_xemPhongTrongA.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xemPhongTrongA.Name = "button_xemPhongTrongA";
            this.button_xemPhongTrongA.Size = new System.Drawing.Size(136, 35);
            this.button_xemPhongTrongA.TabIndex = 11;
            this.button_xemPhongTrongA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_xemPhongTrongA.Click += new System.EventHandler(this.button_xemPhongTrongA_Click);
            // 
            // comboBox_PhongTrong
            // 
            this.comboBox_PhongTrong.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_PhongTrong.FormattingEnabled = true;
            this.comboBox_PhongTrong.Location = new System.Drawing.Point(148, 24);
            this.comboBox_PhongTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_PhongTrong.Name = "comboBox_PhongTrong";
            this.comboBox_PhongTrong.Size = new System.Drawing.Size(136, 24);
            this.comboBox_PhongTrong.TabIndex = 8;
            // 
            // button_Thoat
            // 
            this.button_Thoat.ActiveBorderThickness = 1;
            this.button_Thoat.ActiveCornerRadius = 20;
            this.button_Thoat.ActiveFillColor = System.Drawing.Color.Blue;
            this.button_Thoat.ActiveForecolor = System.Drawing.Color.White;
            this.button_Thoat.ActiveLineColor = System.Drawing.Color.Blue;
            this.button_Thoat.BackColor = System.Drawing.SystemColors.Control;
            this.button_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Thoat.BackgroundImage")));
            this.button_Thoat.ButtonText = "Cập nhật";
            this.button_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Thoat.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Thoat.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Thoat.IdleBorderThickness = 1;
            this.button_Thoat.IdleCornerRadius = 20;
            this.button_Thoat.IdleFillColor = System.Drawing.Color.White;
            this.button_Thoat.IdleForecolor = System.Drawing.Color.Blue;
            this.button_Thoat.IdleLineColor = System.Drawing.Color.Blue;
            this.button_Thoat.Location = new System.Drawing.Point(721, 654);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(136, 35);
            this.button_Thoat.TabIndex = 18;
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridView_1);
            this.groupBox2.Location = new System.Drawing.Point(12, 332);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1012, 314);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin chi tiết";
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
            this.button_return.Location = new System.Drawing.Point(865, 654);
            this.button_return.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_return.Name = "button_return";
            this.button_return.Size = new System.Drawing.Size(136, 35);
            this.button_return.TabIndex = 20;
            this.button_return.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_return.Click += new System.EventHandler(this.button_return_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1036, 695);
            this.Controls.Add(this.button_return);
            this.Controls.Add(this.button_Thoat);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupbox_ThongTin);
            this.Controls.Add(this.groupbox_Timkiem);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form_Main";
            this.Text = "Giao Diện Chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupbox_Timkiem.ResumeLayout(false);
            this.groupbox_Timkiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).EndInit();
            this.groupbox_ThongTin.ResumeLayout(false);
            this.groupbox_ThongTin.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_Timkiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_phongDaThue;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        private DataSet1TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private System.Windows.Forms.DataGridView gridView_1;
        private System.Windows.Forms.BindingSource rOOMBindingSource1;
        private System.Windows.Forms.GroupBox groupbox_ThongTin;
        private Bunifu.Framework.UI.BunifuThinButton2 button_TimTen;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_SoPhong;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Khachhang;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.TextBox txt_tenKhachhang;
        private System.Windows.Forms.GroupBox groupBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuThinButton2 button_xemPhongTrongA;
        private System.Windows.Forms.ComboBox comboBox_PhongTrong;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Thoat;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label_Ngay;
        private System.Windows.Forms.Label label_PhongThanhToan;
        private System.Windows.Forms.Label label_TenKhach;
        private Bunifu.Framework.UI.BunifuThinButton2 button_TinhTien;
        private Bunifu.Framework.UI.BunifuThinButton2 button_ThemNguoi;
        private System.Windows.Forms.ComboBox comboBox_tenKH;
        private System.Windows.Forms.Label phongThanhToan;
        private System.Windows.Forms.Label tienThanhToan;
        private System.Windows.Forms.Label ngayThue;
        private Bunifu.Framework.UI.BunifuThinButton2 button_return;
        private System.Windows.Forms.Label traPhong;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuThinButton2 button_HoaDon;
        private Bunifu.Framework.UI.BunifuThinButton2 button_xemPhongTrongC;
        private Bunifu.Framework.UI.BunifuThinButton2 button_xemPhongTrongB;
    }
}

