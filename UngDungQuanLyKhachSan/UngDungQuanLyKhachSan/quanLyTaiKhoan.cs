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
        public void showAllAccount()
        {
            string query_DSPhong = "select * from ACCOUNT ORDER BY EMPLOYEE_ID ASC";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
        }
        public void fill_comboBoxTK()
        {
            comboBox_TKXoa.Items.Clear();
            string query = "SELECT * FROM ACCOUNT ORDER BY EMPLOYEE_ID ASC";
            fill_ComboBox(comboBox_TKXoa, query, "USERNAME");
        }
        public quanLyTaiKhoan()
        {
            InitializeComponent();
            showAllAccount();
            fill_comboBoxTK();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            showAllAccount();
            fill_comboBoxTK();
        }

        private void button_ThemTK_Click(object sender, EventArgs e)
        {
            string err = "";
            if (txtMaNV.Text == "")
                err += "Chưa nhập mã nhân viên\n";
            if (txtTaiKhoan.Text == "")
                err += "Chưa nhập tên tài khoản\n";
            if (txtMatKhau.Text =="")
                err += "Chưa nhập mật khẩu\n";
            
            if (txtNhapLai.Text == "")
                err += "Chưa nhập mật khẩu xác nhận";
            if (err != "")
            {
                MessageBox.Show(err);
            }
            else
            {
                string query_check = "SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = '" + txtMaNV.Text + "'";
                if (truyVanDuLieu(query_check).Tables[0].Rows.Count != 0)
                {
                    string query_checkTK = "SELECT * FROM ACCOUNT WHERE USERNAME = '" + txtTaiKhoan.Text + "'";
                    if (truyVanDuLieu(query_checkTK).Tables[0].Rows.Count != 0)
                    {
                        MessageBox.Show("Tên tài khoản đã có, mời nhập tên mới");
                    }
                    else
                    {
                        if (txtMatKhau.Text != txtNhapLai.Text)
                        {
                            MessageBox.Show("Mật khẩu không trung khớp, mời nhập lại");
                        }
                        else
                        {
                            string query = "EXEC ADD_ACCOUNT @USERNAME='" + txtTaiKhoan.Text + "', @PASSWORD = '" + txtMatKhau.Text + "', @EMPLOYEE_ID = '" + txtMaNV.Text + "'";
                            truyVanDuLieu(query);
                            MessageBox.Show("Thêm tài khoản mới  thành công");
                        }
                    }
                }
                else
                {

                    MessageBox.Show("Mã nhân viên không tồn tại, mời nhập lại mã nhân viên");
                }
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_XoaTK_Click(object sender, EventArgs e)
        {
            string query_delete = "DELETE FROM ACCOUNT WHERE USERNAME = '" + comboBox_TKXoa.Text + "'";
            truyVanDuLieu(query_delete);
            MessageBox.Show("Xóa thông tin tài khoản thanh công");
            comboBox_TKXoa.Text = "";
            textBox1.Text = "";
        }

        private void button_kiemtra_Click(object sender, EventArgs e)
        {
            if(comboBox_TKXoa.Text=="")
            {
                MessageBox.Show("Mời chọn tên tài khoản cần xóa");
            }
            {
                string query_getdata = "SELECT  EMPLOYEE_ID FROM ACCOUNT WHERE USERNAME ='" + comboBox_TKXoa.Text + "'";
                DataTable data = truyVanDuLieu(query_getdata).Tables[0];
                textBox1.Text = data.Rows[0][0].ToString();
            }
        }

        private void quanLyTaiKhoan_Load(object sender, EventArgs e)
        {

        }
    }
}
