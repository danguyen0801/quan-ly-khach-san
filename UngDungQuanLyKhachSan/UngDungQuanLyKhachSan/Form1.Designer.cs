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
            this.txt_tenKhachhang = new System.Windows.Forms.TextBox();
            this.label_Khachhang = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Label_SoPhong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button_TimTen = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_XemThongtin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_phongDaThue = new System.Windows.Forms.ComboBox();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UngDungQuanLyKhachSan.DataSet1();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.rOOMTableAdapter = new UngDungQuanLyKhachSan.DataSet1TableAdapters.ROOMTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rOOMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupbox_ThongTin = new System.Windows.Forms.GroupBox();
            this.cUSTOMERTableAdapter = new UngDungQuanLyKhachSan.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button_Thoat = new Bunifu.Framework.UI.BunifuThinButton2();
            this.button_DSPhong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.button_xemPhongTrong = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_PhongTrong = new System.Windows.Forms.ComboBox();
            this.groupbox_Timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).BeginInit();
            this.groupbox_ThongTin.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_Timkiem
            // 
            this.groupbox_Timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.groupbox_Timkiem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupbox_Timkiem.Controls.Add(this.txt_tenKhachhang);
            this.groupbox_Timkiem.Controls.Add(this.label_Khachhang);
            this.groupbox_Timkiem.Controls.Add(this.Label_SoPhong);
            this.groupbox_Timkiem.Controls.Add(this.button_TimTen);
            this.groupbox_Timkiem.Controls.Add(this.Button_XemThongtin);
            this.groupbox_Timkiem.Controls.Add(this.comboBox_phongDaThue);
            this.groupbox_Timkiem.Location = new System.Drawing.Point(563, 11);
            this.groupbox_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_Timkiem.Name = "groupbox_Timkiem";
            this.groupbox_Timkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_Timkiem.Size = new System.Drawing.Size(577, 118);
            this.groupbox_Timkiem.TabIndex = 0;
            this.groupbox_Timkiem.TabStop = false;
            this.groupbox_Timkiem.Text = "Thanh toán";
            this.groupbox_Timkiem.Enter += new System.EventHandler(this.groupbox_Timkiem_Enter);
            // 
            // txt_tenKhachhang
            // 
            this.txt_tenKhachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenKhachhang.Location = new System.Drawing.Point(149, 73);
            this.txt_tenKhachhang.Name = "txt_tenKhachhang";
            this.txt_tenKhachhang.Size = new System.Drawing.Size(160, 22);
            this.txt_tenKhachhang.TabIndex = 18;
            // 
            // label_Khachhang
            // 
            this.label_Khachhang.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Khachhang.AutoSize = true;
            this.label_Khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khachhang.Location = new System.Drawing.Point(19, 74);
            this.label_Khachhang.Name = "label_Khachhang";
            this.label_Khachhang.Size = new System.Drawing.Size(111, 20);
            this.label_Khachhang.TabIndex = 17;
            this.label_Khachhang.Text = "Khách Hàng";
            this.label_Khachhang.Click += new System.EventHandler(this.label_Khachhang_Click);
            // 
            // Label_SoPhong
            // 
            this.Label_SoPhong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Label_SoPhong.AutoSize = true;
            this.Label_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SoPhong.Location = new System.Drawing.Point(19, 25);
            this.Label_SoPhong.Name = "Label_SoPhong";
            this.Label_SoPhong.Size = new System.Drawing.Size(89, 20);
            this.Label_SoPhong.TabIndex = 15;
            this.Label_SoPhong.Text = "Số Phòng";
            this.Label_SoPhong.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // button_TimTen
            // 
            this.button_TimTen.ActiveBorderThickness = 1;
            this.button_TimTen.ActiveCornerRadius = 20;
            this.button_TimTen.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.ActiveForecolor = System.Drawing.Color.White;
            this.button_TimTen.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_TimTen.BackColor = System.Drawing.SystemColors.Control;
            this.button_TimTen.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_TimTen.BackgroundImage")));
            this.button_TimTen.ButtonText = "Tìm ";
            this.button_TimTen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_TimTen.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button_TimTen.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.IdleBorderThickness = 1;
            this.button_TimTen.IdleCornerRadius = 20;
            this.button_TimTen.IdleFillColor = System.Drawing.Color.White;
            this.button_TimTen.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_TimTen.Location = new System.Drawing.Point(316, 66);
            this.button_TimTen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_TimTen.Name = "button_TimTen";
            this.button_TimTen.Size = new System.Drawing.Size(159, 37);
            this.button_TimTen.TabIndex = 13;
            this.button_TimTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_TimTen.Click += new System.EventHandler(this.button_TimTen_Click);
            // 
            // Button_XemThongtin
            // 
            this.Button_XemThongtin.ActiveBorderThickness = 1;
            this.Button_XemThongtin.ActiveCornerRadius = 20;
            this.Button_XemThongtin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.ActiveForecolor = System.Drawing.Color.White;
            this.Button_XemThongtin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_XemThongtin.BackColor = System.Drawing.SystemColors.Control;
            this.Button_XemThongtin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_XemThongtin.BackgroundImage")));
            this.Button_XemThongtin.ButtonText = "Xem thông tin";
            this.Button_XemThongtin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_XemThongtin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Button_XemThongtin.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.IdleBorderThickness = 1;
            this.Button_XemThongtin.IdleCornerRadius = 20;
            this.Button_XemThongtin.IdleFillColor = System.Drawing.Color.White;
            this.Button_XemThongtin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.Location = new System.Drawing.Point(316, 17);
            this.Button_XemThongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_XemThongtin.Name = "Button_XemThongtin";
            this.Button_XemThongtin.Size = new System.Drawing.Size(159, 37);
            this.Button_XemThongtin.TabIndex = 11;
            this.Button_XemThongtin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_XemThongtin.Click += new System.EventHandler(this.Button_XemThongtin_Click);
            // 
            // comboBox_phongDaThue
            // 
            this.comboBox_phongDaThue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBox_phongDaThue.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_phongDaThue.FormattingEnabled = true;
            this.comboBox_phongDaThue.Location = new System.Drawing.Point(149, 23);
            this.comboBox_phongDaThue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_phongDaThue.Name = "comboBox_phongDaThue";
            this.comboBox_phongDaThue.Size = new System.Drawing.Size(160, 24);
            this.comboBox_phongDaThue.TabIndex = 8;
            this.comboBox_phongDaThue.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 33);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1157, 323);
            this.dataGridView1.TabIndex = 12;
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
            this.groupbox_ThongTin.Controls.Add(this.dataGridView1);
            this.groupbox_ThongTin.Location = new System.Drawing.Point(12, 133);
            this.groupbox_ThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ThongTin.Name = "groupbox_ThongTin";
            this.groupbox_ThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ThongTin.Size = new System.Drawing.Size(1185, 399);
            this.groupbox_ThongTin.TabIndex = 1;
            this.groupbox_ThongTin.TabStop = false;
            this.groupbox_ThongTin.Text = "Thông Tin Phòng";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.groupBox1.Controls.Add(this.button_Thoat);
            this.groupBox1.Controls.Add(this.button_DSPhong);
            this.groupBox1.Controls.Add(this.bunifuThinButton22);
            this.groupBox1.Controls.Add(this.bunifuCustomLabel2);
            this.groupBox1.Controls.Add(this.button_xemPhongTrong);
            this.groupBox1.Controls.Add(this.comboBox_PhongTrong);
            this.groupBox1.Location = new System.Drawing.Point(20, 11);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(537, 118);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tra cứu phòng trống";
            // 
            // button_Thoat
            // 
            this.button_Thoat.ActiveBorderThickness = 1;
            this.button_Thoat.ActiveCornerRadius = 20;
            this.button_Thoat.ActiveFillColor = System.Drawing.Color.Red;
            this.button_Thoat.ActiveForecolor = System.Drawing.Color.White;
            this.button_Thoat.ActiveLineColor = System.Drawing.Color.Red;
            this.button_Thoat.BackColor = System.Drawing.SystemColors.Control;
            this.button_Thoat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_Thoat.BackgroundImage")));
            this.button_Thoat.ButtonText = "Thoát";
            this.button_Thoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Thoat.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button_Thoat.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_Thoat.IdleBorderThickness = 1;
            this.button_Thoat.IdleCornerRadius = 20;
            this.button_Thoat.IdleFillColor = System.Drawing.Color.White;
            this.button_Thoat.IdleForecolor = System.Drawing.Color.Red;
            this.button_Thoat.IdleLineColor = System.Drawing.Color.Red;
            this.button_Thoat.Location = new System.Drawing.Point(355, 64);
            this.button_Thoat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_Thoat.Name = "button_Thoat";
            this.button_Thoat.Size = new System.Drawing.Size(159, 37);
            this.button_Thoat.TabIndex = 18;
            this.button_Thoat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_Thoat.Click += new System.EventHandler(this.button_Thoat_Click);
            // 
            // button_DSPhong
            // 
            this.button_DSPhong.ActiveBorderThickness = 1;
            this.button_DSPhong.ActiveCornerRadius = 20;
            this.button_DSPhong.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_DSPhong.ActiveForecolor = System.Drawing.Color.White;
            this.button_DSPhong.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_DSPhong.BackColor = System.Drawing.SystemColors.Control;
            this.button_DSPhong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_DSPhong.BackgroundImage")));
            this.button_DSPhong.ButtonText = "DS Phòng";
            this.button_DSPhong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DSPhong.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button_DSPhong.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_DSPhong.IdleBorderThickness = 1;
            this.button_DSPhong.IdleCornerRadius = 20;
            this.button_DSPhong.IdleFillColor = System.Drawing.Color.White;
            this.button_DSPhong.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_DSPhong.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_DSPhong.Location = new System.Drawing.Point(17, 64);
            this.button_DSPhong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_DSPhong.Name = "button_DSPhong";
            this.button_DSPhong.Size = new System.Drawing.Size(159, 37);
            this.button_DSPhong.TabIndex = 17;
            this.button_DSPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_DSPhong.Click += new System.EventHandler(this.button_DSPhong_Click);
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
            this.bunifuThinButton22.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.Blue;
            this.bunifuThinButton22.Location = new System.Drawing.Point(188, 64);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(159, 37);
            this.bunifuThinButton22.TabIndex = 16;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(17, 25);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(115, 20);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "Phòng Trống";
            // 
            // button_xemPhongTrong
            // 
            this.button_xemPhongTrong.ActiveBorderThickness = 1;
            this.button_xemPhongTrong.ActiveCornerRadius = 20;
            this.button_xemPhongTrong.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrong.ActiveForecolor = System.Drawing.Color.White;
            this.button_xemPhongTrong.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrong.BackColor = System.Drawing.SystemColors.Control;
            this.button_xemPhongTrong.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_xemPhongTrong.BackgroundImage")));
            this.button_xemPhongTrong.ButtonText = "Xem chi tiết";
            this.button_xemPhongTrong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xemPhongTrong.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.button_xemPhongTrong.ForeColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrong.IdleBorderThickness = 1;
            this.button_xemPhongTrong.IdleCornerRadius = 20;
            this.button_xemPhongTrong.IdleFillColor = System.Drawing.Color.White;
            this.button_xemPhongTrong.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrong.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.button_xemPhongTrong.Location = new System.Drawing.Point(355, 17);
            this.button_xemPhongTrong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_xemPhongTrong.Name = "button_xemPhongTrong";
            this.button_xemPhongTrong.Size = new System.Drawing.Size(159, 37);
            this.button_xemPhongTrong.TabIndex = 11;
            this.button_xemPhongTrong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.button_xemPhongTrong.Click += new System.EventHandler(this.button_xemPhongTrong_Click);
            // 
            // comboBox_PhongTrong
            // 
            this.comboBox_PhongTrong.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_PhongTrong.FormattingEnabled = true;
            this.comboBox_PhongTrong.Location = new System.Drawing.Point(159, 23);
            this.comboBox_PhongTrong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_PhongTrong.Name = "comboBox_PhongTrong";
            this.comboBox_PhongTrong.Size = new System.Drawing.Size(160, 24);
            this.comboBox_PhongTrong.TabIndex = 8;
            this.comboBox_PhongTrong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 717);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).EndInit();
            this.groupbox_ThongTin.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private Bunifu.Framework.UI.BunifuThinButton2 Button_XemThongtin;
        private System.Windows.Forms.DataGridView dataGridView1;
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
        private Bunifu.Framework.UI.BunifuThinButton2 button_xemPhongTrong;
        private System.Windows.Forms.ComboBox comboBox_PhongTrong;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private Bunifu.Framework.UI.BunifuThinButton2 button_DSPhong;
        private Bunifu.Framework.UI.BunifuThinButton2 button_Thoat;
    }
}

