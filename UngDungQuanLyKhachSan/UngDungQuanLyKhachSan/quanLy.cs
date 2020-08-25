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
        public quanLy( string fullname)
        {
            InitializeComponent();
            this.Text = "Xin chào " + fullname;
        }
        
        void fill_QuyDinh()
        {
            textBox1.Text = quyDinh.dongiaA.ToString();
            textBox2.Text = quyDinh.dongiaB.ToString();
            textBox3.Text = quyDinh.dongiaC.ToString();
            textBox4.Text = quyDinh.phuThu.ToString();
            numericUpDown1.Value = quyDinh.max_number;
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

        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = !textBox1.Enabled;
            textBox2.Enabled = !textBox2.Enabled;
            textBox3.Enabled = !textBox3.Enabled;
            textBox4.Enabled = !textBox4.Enabled;
            numericUpDown1.Enabled = !numericUpDown1.Enabled;
        }

        private void button_CapNhatPhong_Click(object sender, EventArgs e)
        {
            capNhatDanhMucPhong capNhat = new capNhatDanhMucPhong();
            capNhat.ShowDialog();
        }

        private void button_CapNhatQuyDinh_Click(object sender, EventArgs e)
        {

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
    }
}
