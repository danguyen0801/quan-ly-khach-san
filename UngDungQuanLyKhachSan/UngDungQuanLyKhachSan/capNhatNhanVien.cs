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
    public partial class capNhatNhanVien : Form
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
        void fill_BoxNV()
        {
            NVXoa.Items.Clear();
            string query = "SELECT * FROM EMPLOYEE ORDER BY EMPLOYEE_ID ASC";
            fill_ComboBox(NVXoa, query, "EMPLOYEE_ID");
        }
        public void showAllEmployee()
        {
            string query_DSPhong = "select * from employee ORDER BY employee_ID ASC";
            gridView_1.DataSource = truyVanDuLieu(query_DSPhong).Tables[0];
        }
        public capNhatNhanVien()
        {
            InitializeComponent();
            fill_BoxNV();
            showAllEmployee();
        }

        private void button_ThemTK_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "")
            {
                MessageBox.Show("Mời nhập mã NV");
            }
            else
            {
                string query_check = "SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = '" + txtMaNV.Text + "'";
                if (truyVanDuLieu(query_check).Tables[0].Rows.Count != 0)
                    MessageBox.Show("Mã nhân viên đã tồn tại, mời nhập lại mã nhân viên khác");
                else
                {
                    string query = "EXEC ADD_EMPLOYEE @EMPLOYEE_ID = '" + txtMaNV.Text + "', @EMPLOYEE_NAME= '" + txtTenNV.Text + "' , @ADDRESS='" + txtDiaChi.Text + "', @PHONE='" + txtPhone.Text + "', @ROLE =" + checkBox1.Checked + "";
                    truyVanDuLieu(query);
                    MessageBox.Show("Thêm nhân viên  thành công");
                }
            }
        }

        private void button_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_checkRoom_Click(object sender, EventArgs e)
        {
            if (NVXoa.Text == "")
            {
                MessageBox.Show("Mời chọn mã nhân viên muốn xóa");
            }
            else
            {
                string check_account = " SELECT * FROM ACCOUNT WHERE EMPLOYEE_ID = '" + NVXoa.Text + "'";
                if (truyVanDuLieu(check_account).Tables[0].Rows.Count != 0)
                {
                    checkBox2.Checked = true;
                    //MessageBox.Show("Nhân viên đang có tài khoản, mời xóa tài khoản thuộc về nhân viên trước khi thực hiện");
                }
                else
                {
                    checkBox2.Checked = false;
                }

                string query_getdata = "SELECT EMPLOYEE_NAME, ADDRESS, PHONE FROM EMPLOYEE WHERE EMPLOYEE_ID ='" + NVXoa.Text + "'";
                DataTable data = truyVanDuLieu(query_getdata).Tables[0];
                textBox1.Text = data.Rows[0][0].ToString();
                textBox2.Text = data.Rows[0][1].ToString();
                textBox3.Text = data.Rows[0][2].ToString();
            }
        }

        private void button_CapNhat_Click(object sender, EventArgs e)
        {
            fill_BoxNV();
            showAllEmployee(); 
        }

        private void button_XoaTK_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                MessageBox.Show("Nhân viên đang có tài khoản, mời xóa tài khoản thuộc về nhân viên trước khi thực hiện");
            }
            else
            {
                string query_delete = "DELETE FROM EMPLOYEE WHERE EMPLOYEE_ID = '" + NVXoa.Text + "'";
                truyVanDuLieu(query_delete);
                MessageBox.Show("Xóa thông tin nhân viên thanh công");
                NVXoa.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }

        }
    }
}
