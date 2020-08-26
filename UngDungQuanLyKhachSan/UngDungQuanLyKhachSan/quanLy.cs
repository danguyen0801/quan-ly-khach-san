using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UngDungQuanLyKhachSan
{
    public partial class quanLy : Form
    {
        DataSet truyVanDuLieu(string truyVan)
        {
            try
            {
                DataSet dataALL = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyVan, connection);
                    adapter.SelectCommand = new SqlCommand(truyVan, connection);
                    adapter.Fill(dataALL);
                    connection.Close();

                }
                return dataALL;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối! " + ex.Message);
                return null;
            }

        }
        void fill_ComboBox(ComboBox cbBox, string truyVan, string name_table)
        {
            DataSet dataBox = truyVanDuLieu(truyVan);

            foreach (DataRow dr in dataBox.Tables[0].Rows)
            {
                cbBox.Items.Add(dr[name_table].ToString());
            }
        }
        public void showAllRoom()
        {
            string query_DSPhong = "select * from ROOM ORDER BY ROOM_ID ASC";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
        }
        void fill_QuyDinh()
        {
            updateQuyDinh();
            donGiaA.Text = quyDinh.dongiaA.ToString();
            donGiaB.Text = quyDinh.dongiaB.ToString();
            donGiaC.Text = quyDinh.dongiaC.ToString();
            phuThu.Text = (quyDinh.phuThu * 100).ToString();
            maxKH.Value = quyDinh.max_number;
        }
        public void showBill(String query_Bill)
        {
            DataSet data = truyVanDuLieu(query_Bill);
            gridView_1.DataSource = data.Tables[0];

        }

        public void updateQuyDinh()
        {
            string query = "SELECT TOP(1) TYPE_A, TYPE_B, TYPE_C, MAX_CUSTOMER, SURCHARGE FROM REGULATIONS ORDER BY DATE_UPDATE DESC, REGULATIONS_ID DESC";
            DataTable data = truyVanDuLieu(query).Tables[0];
            int a = int.Parse(data.Rows[0][0].ToString());
            int b = int.Parse(data.Rows[0][1].ToString());
            int c = int.Parse(data.Rows[0][2].ToString());
            int d = int.Parse(data.Rows[0][3].ToString());
            double pt = Math.Round(double.Parse(data.Rows[0][4].ToString()) * 100);
            quyDinh.update(a, b, c, d, pt);
        }
        public quanLy(string fullname)
        {
            InitializeComponent();
            this.Text = "Xin chào " + fullname;
            fill_QuyDinh();
        }


        private void quanLy_Load(object sender, EventArgs e)
        {
            gridView_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            showAllRoom();
            fill_QuyDinh();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox_Thang_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_XemDSHoaDon_Click(object sender, EventArgs e)
        {
            string query = "EXEC SHOW_BILL_MONTH @MONTH = '" + comboBox_Thang.Text + "'";
            showBill(query);
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            string query = "EXEC REPORT_BILL_MONTH @MONTH = '" + comboBox_Thang.Text + "'";
            showBill(query);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            donGiaA.Enabled = !donGiaA.Enabled;
            donGiaB.Enabled = !donGiaB.Enabled;
            donGiaC.Enabled = !donGiaC.Enabled;
            phuThu.Enabled = !phuThu.Enabled;
            maxKH.Enabled = !maxKH.Enabled;
            button_CapNhatQuyDinh.Visible = !button_CapNhatQuyDinh.Visible;
        }

        private void button_CapNhatPhong_Click(object sender, EventArgs e)
        {
            capNhatDanhMucPhong capNhat = new capNhatDanhMucPhong();
            capNhat.ShowDialog();
        }

        private void button_CapNhatQuyDinh_Click(object sender, EventArgs e)
        {
            quyDinh.dongiaA = int.Parse(donGiaA.Value.ToString());
            quyDinh.dongiaB = int.Parse(donGiaB.Value.ToString());
            quyDinh.dongiaC = int.Parse(donGiaC.Value.ToString());
            quyDinh.phuThu = Math.Round(double.Parse(phuThu.Value.ToString()) / 100);
            quyDinh.max_number = int.Parse(maxKH.Value.ToString());
            string query = "EXEC UPDATE_REGULATIONS @TYPE_A=" + quyDinh.dongiaA + ", @TYPE_B= " + quyDinh.dongiaB + ", @TYPE_C=" + quyDinh.dongiaC + ", @MAX_CUSTOMER=" + quyDinh.max_number + ", @SURCHARGE=" + quyDinh.phuThu + "";
            truyVanDuLieu(query);
            fill_QuyDinh();
            MessageBox.Show("Lưu quy định mới thành công");
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            showAllRoom();
        }

        private void button_CapNhatNhanVien_Click(object sender, EventArgs e)
        {
            quanLyTaiKhoan qltaikhoan = new quanLyTaiKhoan();
            qltaikhoan.ShowDialog();
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            check_Login.isLogin = false;
            this.Close();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            capNhatNhanVien qly = new capNhatNhanVien();
            qly.ShowDialog();
        }
    }
}
