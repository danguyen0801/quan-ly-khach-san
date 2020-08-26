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
    public partial class capNhatDanhMucPhong : Form
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
        public void loadComboBox()
        {
            comboBox_MaPhongXoa.Items.Clear();
            string query_dsPhong = "select * from ROOM where status = 0 order by ROOM_ID asc";
            fill_ComboBox(comboBox_MaPhongXoa, query_dsPhong, "ROOM_ID");
        }
        public capNhatDanhMucPhong()
        {
            InitializeComponent();
            showAllRoom();
            loadComboBox();
        }

        private void button_XoaPhong_Click(object sender, EventArgs e)
        {
            string query_delete_BILL = "DELETE FROM BILL WHERE ROOM_ID = '" + comboBox_MaPhongXoa.Text + "'";
            string query_delete_BILL_INFO = "DELETE FROM BILL_INFO WHERE ROOM_ID = '" + comboBox_MaPhongXoa.Text + "'";
            truyVanDuLieu(query_delete_BILL_INFO);
            truyVanDuLieu(query_delete_BILL);
            
            string query_delete = "DELETE FROM ROOM WHERE ROOM_ID = '"+comboBox_MaPhongXoa.Text+"'";
            truyVanDuLieu(query_delete);
            MessageBox.Show("Xóa thông tin phòng thanh công");
            comboBox_MaPhongXoa.Text = "";
            textBoxTenPhong.Text = "";
            textBoxLoaiPhong.Text ="";
            textBoxGhiChu.Text = "";
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            showAllRoom();
            loadComboBox();
        }

        private void button_ThemPhong_Click(object sender, EventArgs e)
        {
            if (txtMaPhong.Text == "")
            {
                MessageBox.Show("Mời nhập mã phòng");
            }
            else
            {
                string query_check = "SELECT * FROM ROOM WHERE ROOM_ID = '" + txtMaPhong.Text + "'";
                if (truyVanDuLieu(query_check).Tables[0].Rows.Count != 0)
                    MessageBox.Show("Mã phòng đã tồn tại, mời nhập mã phòng khác");
                else
                {
                    string query = "EXEC ADD_ROOM @ROOM_ID ='" + txtMaPhong.Text + "', @ROOM_NAME= '" + txtTenPhong.Text + "', @ROOM_TYPE ='" + comboBox_Loai.Text + "', @NOTE= '" + txtGhiChu.Text + "'";
                    truyVanDuLieu(query);
                    MessageBox.Show("Thêm phòng thành công");
                }
            }
            
        }

        private void button_checkRoom_Click(object sender, EventArgs e)
        {
            if (comboBox_MaPhongXoa.Text == "")
            {
                MessageBox.Show("Mời chọn mã phòng cần xóa");
            }
            else
            {
                string query_getdata = "SELECT ROOM_NAME, ROOM_TYPE, NOTE FROM ROOM WHERE ROOM_ID ='" + comboBox_MaPhongXoa.Text + "'";
                DataTable data = truyVanDuLieu(query_getdata).Tables[0];
                textBoxTenPhong.Text = data.Rows[0][0].ToString();
                textBoxLoaiPhong.Text = data.Rows[0][1].ToString();
                textBoxGhiChu.Text = data.Rows[0][2].ToString();
            }

        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void capNhatDanhMucPhong_Load(object sender, EventArgs e)
        {

        }
    }
}
