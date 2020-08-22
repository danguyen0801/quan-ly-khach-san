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
            //this.cUSTOMERTableAdapter.Fill(this.dataSet1.CUSTOMER);
            //this.rOOMTableAdapter.Fill(this.dataSet1.ROOM);
            gridView_1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //combobox phong con trong
            comboBox_PhongTrong.Items.Clear();
            comboBox_phongDaThue.Items.Clear();
            string query_phongTrong = "select * from ROOM where ROOM.STATUS = N'Trống'";
            string query_phongChoThue = "select * from ROOM where ROOM.STATUS = N'Có Khách'";
            fill_ComboBox(comboBox_PhongTrong, query_phongTrong, "ROOM_ID");
            fill_ComboBox(comboBox_phongDaThue, query_phongChoThue, "ROOM_ID");

            //Load danh sach phong 
            string query_DSPhong = "select * from ROOM";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
            //label_TenKhach.Text += " P101";

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
                DataSet data = new DataSet();
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(truyVan, connection);
                    adapter.Fill(data);
                    connection.Close();

                }
                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối! " + ex.Message);
                return null;
            }

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Button_XemThongtin_Click(object sender, EventArgs e)
        {
            if (comboBox_phongDaThue.Text != "")
            {
                string truyVan = "select Distinct RENT_BILL.CUSTOMER_NAME, RENT_BILL.START_DATE, ROOM.*"
                    + "FROM  RENT_BILL , ROOM "
                    + "WHERE ROOM.ROOM_ID = '" + comboBox_phongDaThue.Text + "' AND ROOM.STATUS = N'Có Khách' and ROOM.ROOM_ID = RENT_BILL.ROOM_ID";
                DataSet data = truyVanDuLieu(truyVan);
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
                MessageBox.Show("Chưa chọn số phòng");
            }
        }
        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void groupbox_Timkiem_Enter(object sender, EventArgs e)
        {

        }

        private void label_Khachhang_Click(object sender, EventArgs e)
        {

        }

        private void button_TimTen_Click(object sender, EventArgs e)
        {
            if (txt_tenKhachhang.Text != "")
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
            else
            {
                MessageBox.Show("Chưa nhập tên khách hàng");
            }

        }

        private void button_xemPhongTrong_Click(object sender, EventArgs e)
        {
            if (comboBox_PhongTrong.Text != "")
            {
                string truyVan = "select Distinct *"
                    + "FROM  ROOM "
                    + "WHERE ROOM.ROOM_ID = '" + comboBox_PhongTrong.Text + "'";
                DataSet data = truyVanDuLieu(truyVan);
                if (data.Tables[0].Rows.Count != 0)
                {
                    gridView_1.DataSource = data.Tables[0];
                }
                else
                {
                    MessageBox.Show("Phòng đã có khách thuê");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn số phòng");
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button_DSPhong_Click(object sender, EventArgs e)
        {

            string truyVan = "select Distinct *"
                            + "FROM  ROOM "
                            + "WHERE ROOM.STATUS = N'Trống' ";
            DataSet data = truyVanDuLieu(truyVan);
            if (data.Tables[0].Rows.Count != 0)
            {
                gridView_1.DataSource = data.Tables[0];
            }
            else
            {
                MessageBox.Show("Không có phòng trống");
            }


        }

        private void button_Thoat_Click(object sender, EventArgs e)
        {
            string query_DSPhong = "select * from ROOM";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
    }

}
