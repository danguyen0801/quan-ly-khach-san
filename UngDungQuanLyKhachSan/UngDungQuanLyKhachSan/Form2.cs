using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyKhachSan
{
    public partial class DangNhap : Form
    {
        public bool isLogin { get; set; }
        public string maNv { get; set; }
        public string fullName { get; set; }

        public DangNhap()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            isLogin = false;
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string tk = txt_TK.Text;
            string mk = txt_MK.Text;
            string truyVan = "SELECT * FROM ACCOUNT WHERE USERNAME = '" + tk + "' AND PASS = '" + mk + "'";
            string _err = string.Empty;
            if (tk == string.Empty)
                _err = " Bạn chưa nhập tên tài khoản";
            if (mk == string.Empty)
                _err += "\n Bạn chưa nhập mật khẩu";
            if (_err != string.Empty)
            {
                MessageBox.Show("Thông báo: \n" + _err);
                return;
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(truyVan, connection);
                    SqlDataReader data = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                    if (data.Read() == true)
                    {
                        maNv = data["EMPLOYEE_ID"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đăng nhập thất bại. \nSai tài khoản hoặc mật khẩu.");
                    }
                    
                    connection.Close();
                }
                using (SqlConnection connection = new SqlConnection(ConnectionString.connectionString))
                {
                    string truyVan2 = "SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = '" + maNv + "'";
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(truyVan2, connection);
                    SqlDataReader data = cmd.ExecuteReader();
                    if (data.Read() == true)
                    {
                        isLogin = true;
                        fullName = data["EMPLOYEE_NAME"].ToString();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi dữ liệu");
                    }

                    connection.Close();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi kết nối! ");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
