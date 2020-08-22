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
using System.Runtime.InteropServices;

namespace UngDungQuanLyKhachSan
{
    public partial class thuePhong : Form
    {
        public string soPhong;
        public thuePhong(string phong)
        {
            InitializeComponent();
            soPhong = phong;
            soPhong2TP.Text = soPhong;
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
        private void thuePhong_Load(object sender, EventArgs e)
        {

        }
        private void diachiTP_Click(object sender, EventArgs e)
        {

        }
        bool themDuLieu(string queryInsert)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(queryInsert, connection);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Them thanh cong");
                    connection.Close();
                }
                return true;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi kết nối! " + ex.Message + "\t" + ex.GetType());
                return false;
            }
        }
        private void button_LuuTP_Click(object sender, EventArgs e)
        {
            //tạo mã khách hàng
            string query_id_KH = "SELECT dbo.AUTO_CUSTOMER() GO";
            string id_KH = truyVanDuLieu(query_id_KH).Tables[0].Rows[0][0].ToString();
            //
            string query_Them = "INSERT INTO CUSTOMER (CUSTOMER_ID,CUSTOMER_NAME, TYPE_CUSTOMER,ID_CARD, ADDRESS)" +
                "VALUES ('"+id_KH+"',N'" + txt_hotenTP.Text + "' ,N'" + comboBox_loaiTP.Text + "','" + txt_cmndTP.Text + "',N'" + txt_diachiTP.Text + "')";
            //if (themDuLieu(query_Them))
            //{
            //    string query_Update = "UPDATE ";


            //}
        }

        private void button_testTP_Click(object sender, EventArgs e)
        {
            soPhongTP.Text = soPhong;
            hoTenTP.Text = txt_hotenTP.Text;
            cmndTP.Text = txt_cmndTP.Text;
            diachiTP.Text = txt_diachiTP.Text;
            loaikhachTP.Text = comboBox_loaiTP.Text;
            ngayThueTP.Text = DateTime.Today.ToString("d");
        }

        private void button_HuyTP_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
