using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace UngDungQuanLyKhachSan
{
    public partial class Form_Main : Form
    {
        public Form_Main(string fullName)
        {
            InitializeComponent();
            this.Text = "Xin chào " + fullName;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            gridView_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //combobox phong con trong
            //Load danh sach phong 
            showAllRoom();
            loadComboBox();
        }
        public void showAllRoom()
        {
            string query_DSPhong = "select * from ROOM ORDER BY STATUS ASC";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
        }
        public void loadComboBox()
        {
            comboBox_PhongTrong.Items.Clear();
            comboBox_phongDaThue.Items.Clear();
            string query_phongTrong = "select * from ROOM where ROOM.STATUS = 0";
            string query_phongChoThue = "select * from ROOM where ROOM.STATUS = 1";
            fill_ComboBox(comboBox_PhongTrong, query_phongTrong, "ROOM_ID");
            fill_ComboBox(comboBox_phongDaThue, query_phongChoThue, "ROOM_ID");
        }
        void fill_ComboBox(ComboBox cbBox, string truyVan, string name_table)
        {
            DataSet dataBox = truyVanDuLieu(truyVan);

            foreach (DataRow dr in dataBox.Tables[0].Rows)
            {
                cbBox.Items.Add(dr[name_table].ToString());
            }
        }
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

        private void button_TimTen_Click(object sender, EventArgs e)
        {
            if (comboBox_phongDaThue.Text == "" && txt_tenKhachhang.Text == "")
            {
                MessageBox.Show("Mời chọn phòng hoặc nhập tên khách hàng cần tìm!!!");
            }
            else
            {
                if (comboBox_phongDaThue.Text != "")
                {
                    string truyVan = "select Distinct RENT_BILL.CUSTOMER_NAME, RENT_BILL.START_DATE, ROOM.*"
                        + "FROM  RENT_BILL , ROOM "
                        + "WHERE ROOM.ROOM_ID = '" + comboBox_phongDaThue.Text + "' AND ROOM.STATUS = 1 and ROOM.ROOM_ID = RENT_BILL.ROOM_ID";
                    DataSet data = truyVanDuLieu(truyVan);
                    //gridView_1.DataSource = data.Tables[0];
                    if (data.Tables[0].Rows.Count != 0)
                    {
                        gridView_1.DataSource = data.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Phòng chưa có khách thuê");
                    }
                }
                else
                {
                    string truyVan = "select Distinct RENT_BILL.CUSTOMER_NAME, RENT_BILL.START_DATE, ROOM.*"
                    + "FROM  RENT_BILL , ROOM "
                    + "WHERE RENT_BILL.CUSTOMER_NAME LIKE N'%" + txt_tenKhachhang.Text + "%' and  ROOM.ROOM_ID = RENT_BILL.ROOM_ID";
                    DataSet data = truyVanDuLieu(truyVan);
                    if (data.Tables[0].Rows.Count != 0)
                    {
                        gridView_1.DataSource = data.Tables[0];
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng tương ứng");
                    }
                }
            }

        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            showAllRoom();
            loadComboBox();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (comboBox_PhongTrong.Text != "")
            {
                thuePhong Thue = new thuePhong(comboBox_PhongTrong.Text);
                Thue.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn số phòng");
            }
        }

        private void button_ThemNguoi_Click(object sender, EventArgs e)
        {
            if (comboBox_phongDaThue.Text != "")
            {
                thuePhong Thue = new thuePhong(comboBox_phongDaThue.Text);
                Thue.ShowDialog();
            }
            else
            {
                MessageBox.Show("Chưa chọn số phòng");
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_TinhTien_Click(object sender, EventArgs e)
        {
            phongThanhToan.Text = comboBox_phongDaThue.Text;
            comboBox_tenKH.Items.Clear();
            string query_tenKHThanhToan = "select * from rent_bill where room_id = '" + comboBox_phongDaThue.Text + "'";
            fill_ComboBox(comboBox_tenKH, query_tenKHThanhToan, "CUSTOMER_NAME");
            traPhong.Text = DateTime.Today.ToString("d");
            string tongtien = "SELECT DBO.PAYMENT_BILL ('" + comboBox_phongDaThue.Text + "', (SELECT DBO.RENT_DAY('" + comboBox_phongDaThue.Text + "')))";
            tienThanhToan.Text = truyVanDuLieu(tongtien).Tables[0].Rows[0][0].ToString();
        }

        private void button_HoaDon_Click(object sender, EventArgs e)
        {
            string query_thanhToan = "EXEC THANHTOAN @ROOM_ID ='" + phongThanhToan.Text + "', @CUSTOMER_NAME = N'" + comboBox_tenKH.Text + "'";

            if (truyVanDuLieu(query_thanhToan) != null)
            {
                MessageBox.Show("Thanh toán thành công");
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công");
            }

        }

        private void button_xemPhongTrongA_Click(object sender, EventArgs e)
        {
            string truyVan = "select Distinct *"
                + "FROM  ROOM "
                + "WHERE ROOM_TYPE ='A' ORDER BY STATUS ASC, ROOM_ID";
            DataSet data = truyVanDuLieu(truyVan);
            if (data.Tables[0].Rows.Count != 0)
            {
                gridView_1.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("kHÔNG CÒN PHÒNG LOẠI A");
            }
        }

        private void button_xemPhongTrongB_Click(object sender, EventArgs e)
        {
            string truyVan = "select Distinct *"
                + "FROM  ROOM "
                + "WHERE ROOM_TYPE ='B' ORDER BY STATUS ASC, ROOM_ID";
            DataSet data = truyVanDuLieu(truyVan);
            if (data.Tables[0].Rows.Count != 0)
            {
                gridView_1.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("kHÔNG CÒN PHÒNG LOẠI A");
            }
        }

        private void button_xemPhongTrongC_Click(object sender, EventArgs e)
        {
            string truyVan = "select Distinct *"
                + "FROM  ROOM "
                + "WHERE ROOM_TYPE ='C' ORDER BY STATUS ASC, ROOM_ID";
            DataSet data = truyVanDuLieu(truyVan);
            if (data.Tables[0].Rows.Count != 0)
            {
                gridView_1.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("kHÔNG CÒN PHÒNG LOẠI A");
            }
        }

        private void gridView_1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}