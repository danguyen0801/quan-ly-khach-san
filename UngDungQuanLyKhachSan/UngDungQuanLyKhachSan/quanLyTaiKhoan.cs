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
    public partial class quanLyTaiKhoan : Form
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

        public void loadComboBox()
        {
            comboBox_TKXoa.Items.Clear();
            string query_dsTK = "select * from ACCOUNT order by USERNAME asc";
            fill_ComboBox(comboBox_TKXoa, query_dsTK, "USERNAME");
        }
        public void showAllAccount()
        {
            string query_DSPhong = "select * from ACCOUNT ORDER BY EMPLOYEE_ID ASC";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
        }
        public quanLyTaiKhoan()
        {
            InitializeComponent();
            showAllAccount();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {

        }
    }
}
