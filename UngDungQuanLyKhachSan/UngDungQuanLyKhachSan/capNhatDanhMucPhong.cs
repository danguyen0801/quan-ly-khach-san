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
            string query_dsPhong = "select * from ROOM order by ROOM_ID asc";
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

        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            showAllRoom();
            loadComboBox();
        }
    }
}
