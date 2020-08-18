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
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Button_XemThongtin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox_soPhong = new System.Windows.Forms.ComboBox();
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
            this.groupbox_Timkiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).BeginInit();
            this.groupbox_ThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox_Timkiem
            // 
            this.groupbox_Timkiem.AccessibleRole = System.Windows.Forms.AccessibleRole.PageTabList;
            this.groupbox_Timkiem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupbox_Timkiem.Controls.Add(this.txt_tenKhachhang);
            this.groupbox_Timkiem.Controls.Add(this.label_Khachhang);
            this.groupbox_Timkiem.Controls.Add(this.Label_SoPhong);
            this.groupbox_Timkiem.Controls.Add(this.bunifuThinButton21);
            this.groupbox_Timkiem.Controls.Add(this.Button_XemThongtin);
            this.groupbox_Timkiem.Controls.Add(this.comboBox_soPhong);
            this.groupbox_Timkiem.Location = new System.Drawing.Point(64, 12);
            this.groupbox_Timkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_Timkiem.Name = "groupbox_Timkiem";
            this.groupbox_Timkiem.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_Timkiem.Size = new System.Drawing.Size(973, 295);
            this.groupbox_Timkiem.TabIndex = 0;
            this.groupbox_Timkiem.TabStop = false;
            this.groupbox_Timkiem.Text = "Danh Sách Phòng";
            this.groupbox_Timkiem.Enter += new System.EventHandler(this.groupbox_Timkiem_Enter);
            // 
            // txt_tenKhachhang
            // 
            this.txt_tenKhachhang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txt_tenKhachhang.Location = new System.Drawing.Point(161, 73);
            this.txt_tenKhachhang.Name = "txt_tenKhachhang";
            this.txt_tenKhachhang.Size = new System.Drawing.Size(423, 22);
            this.txt_tenKhachhang.TabIndex = 18;
            // 
            // label_Khachhang
            // 
            this.label_Khachhang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Khachhang.AutoSize = true;
            this.label_Khachhang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Khachhang.Location = new System.Drawing.Point(5, 74);
            this.label_Khachhang.Name = "label_Khachhang";
            this.label_Khachhang.Size = new System.Drawing.Size(111, 20);
            this.label_Khachhang.TabIndex = 17;
            this.label_Khachhang.Text = "Khách Hàng";
            this.label_Khachhang.Click += new System.EventHandler(this.label_Khachhang_Click);
            // 
            // Label_SoPhong
            // 
            this.Label_SoPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Label_SoPhong.AutoSize = true;
            this.Label_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SoPhong.Location = new System.Drawing.Point(5, 25);
            this.Label_SoPhong.Name = "Label_SoPhong";
            this.Label_SoPhong.Size = new System.Drawing.Size(89, 20);
            this.Label_SoPhong.TabIndex = 15;
            this.Label_SoPhong.Text = "Số Phòng";
            this.Label_SoPhong.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Tìm kiếm theo tên";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(637, 66);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(211, 37);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click_1);
            // 
            // Button_XemThongtin
            // 
            this.Button_XemThongtin.ActiveBorderThickness = 1;
            this.Button_XemThongtin.ActiveCornerRadius = 20;
            this.Button_XemThongtin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.ActiveForecolor = System.Drawing.Color.White;
            this.Button_XemThongtin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Button_XemThongtin.BackColor = System.Drawing.SystemColors.Control;
            this.Button_XemThongtin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_XemThongtin.BackgroundImage")));
            this.Button_XemThongtin.ButtonText = "Xem thông tin phòng";
            this.Button_XemThongtin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_XemThongtin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Button_XemThongtin.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.IdleBorderThickness = 1;
            this.Button_XemThongtin.IdleCornerRadius = 20;
            this.Button_XemThongtin.IdleFillColor = System.Drawing.Color.White;
            this.Button_XemThongtin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.Location = new System.Drawing.Point(637, 17);
            this.Button_XemThongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_XemThongtin.Name = "Button_XemThongtin";
            this.Button_XemThongtin.Size = new System.Drawing.Size(211, 37);
            this.Button_XemThongtin.TabIndex = 11;
            this.Button_XemThongtin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_XemThongtin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // comboBox_soPhong
            // 
            this.comboBox_soPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox_soPhong.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox_soPhong.DataSource = this.rOOMBindingSource;
            this.comboBox_soPhong.DisplayMember = "ROOM_ID";
            this.comboBox_soPhong.FormattingEnabled = true;
            this.comboBox_soPhong.Location = new System.Drawing.Point(161, 23);
            this.comboBox_soPhong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_soPhong.Name = "comboBox_soPhong";
            this.comboBox_soPhong.Size = new System.Drawing.Size(423, 24);
            this.comboBox_soPhong.TabIndex = 8;
            this.comboBox_soPhong.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dataGridView1.Size = new System.Drawing.Size(1048, 323);
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
            this.groupbox_ThongTin.Location = new System.Drawing.Point(12, 314);
            this.groupbox_ThongTin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ThongTin.Name = "groupbox_ThongTin";
            this.groupbox_ThongTin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupbox_ThongTin.Size = new System.Drawing.Size(1076, 399);
            this.groupbox_ThongTin.TabIndex = 1;
            this.groupbox_ThongTin.TabStop = false;
            this.groupbox_ThongTin.Text = "Thông Tin";
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 717);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox_Timkiem;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox_soPhong;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        private DataSet1TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_XemThongtin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rOOMBindingSource1;
        private System.Windows.Forms.GroupBox groupbox_ThongTin;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_SoPhong;
        private Bunifu.Framework.UI.BunifuCustomLabel label_Khachhang;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
        private System.Windows.Forms.TextBox txt_tenKhachhang;
    }
}

