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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label_SoPhong = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.rOOMBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new UngDungQuanLyKhachSan.DataSet1();
            this.Button_XemThongtin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rOOMTableAdapter = new UngDungQuanLyKhachSan.DataSet1TableAdapters.ROOMTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rOOMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.cUSTOMERBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cUSTOMERTableAdapter = new UngDungQuanLyKhachSan.DataSet1TableAdapters.CUSTOMERTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bunifuCustomLabel1);
            this.groupBox1.Controls.Add(this.Label_SoPhong);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.bunifuThinButton21);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.Button_XemThongtin);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(973, 296);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Phòng";
            // 
            // Label_SoPhong
            // 
            this.Label_SoPhong.AutoSize = true;
            this.Label_SoPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_SoPhong.Location = new System.Drawing.Point(5, 24);
            this.Label_SoPhong.Name = "Label_SoPhong";
            this.Label_SoPhong.Size = new System.Drawing.Size(89, 20);
            this.Label_SoPhong.TabIndex = 15;
            this.Label_SoPhong.Text = "Số Phòng";
            this.Label_SoPhong.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(187, 127);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(312, 22);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Xem chi tiết";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(750, 57);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(130, 37);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox2.DataSource = this.cUSTOMERBindingSource;
            this.comboBox2.DisplayMember = "CUSTOMER_NAME";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(161, 70);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(422, 24);
            this.comboBox2.TabIndex = 12;
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
            // Button_XemThongtin
            // 
            this.Button_XemThongtin.ActiveBorderThickness = 1;
            this.Button_XemThongtin.ActiveCornerRadius = 20;
            this.Button_XemThongtin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.ActiveForecolor = System.Drawing.Color.White;
            this.Button_XemThongtin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Button_XemThongtin.BackColor = System.Drawing.SystemColors.Control;
            this.Button_XemThongtin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Button_XemThongtin.BackgroundImage")));
            this.Button_XemThongtin.ButtonText = "Xem chi tiết";
            this.Button_XemThongtin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_XemThongtin.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.Button_XemThongtin.ForeColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.IdleBorderThickness = 1;
            this.Button_XemThongtin.IdleCornerRadius = 20;
            this.Button_XemThongtin.IdleFillColor = System.Drawing.Color.White;
            this.Button_XemThongtin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.Button_XemThongtin.Location = new System.Drawing.Point(750, 15);
            this.Button_XemThongtin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_XemThongtin.Name = "Button_XemThongtin";
            this.Button_XemThongtin.Size = new System.Drawing.Size(130, 37);
            this.Button_XemThongtin.TabIndex = 11;
            this.Button_XemThongtin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Button_XemThongtin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DataSource = this.rOOMBindingSource;
            this.comboBox1.DisplayMember = "ROOM_ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(161, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(422, 24);
            this.comboBox1.TabIndex = 8;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
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
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(945, 296);
            this.dataGridView1.TabIndex = 12;
            // 
            // rOOMBindingSource1
            // 
            this.rOOMBindingSource1.DataMember = "ROOM";
            this.rOOMBindingSource1.DataSource = this.dataSet1BindingSource;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 314);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(973, 335);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(6, 74);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(111, 20);
            this.bunifuCustomLabel1.TabIndex = 17;
            this.bunifuCustomLabel1.Text = "Khách Hàng";
            // 
            // cUSTOMERBindingSource
            // 
            this.cUSTOMERBindingSource.DataMember = "CUSTOMER";
            this.cUSTOMERBindingSource.DataSource = this.dataSet1BindingSource;
            // 
            // cUSTOMERTableAdapter
            // 
            this.cUSTOMERTableAdapter.ClearBeforeFill = true;
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 648);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form_Main";
            this.Text = "Giao Diện Chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rOOMBindingSource1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cUSTOMERBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource rOOMBindingSource;
        private DataSet1TableAdapters.ROOMTableAdapter rOOMTableAdapter;
        private Bunifu.Framework.UI.BunifuThinButton2 Button_XemThongtin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rOOMBindingSource1;
        private System.Windows.Forms.GroupBox groupBox2;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel Label_SoPhong;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.BindingSource cUSTOMERBindingSource;
        private DataSet1TableAdapters.CUSTOMERTableAdapter cUSTOMERTableAdapter;
    }
}

