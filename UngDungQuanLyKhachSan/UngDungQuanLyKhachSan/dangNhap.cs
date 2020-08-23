using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = truyVan;
                    cmd.Connection = connection;
                    // kiem tra tai khoan, lay maNv
                   
                    using (SqlDataReader data = cmd.ExecuteReader())
                    {
                        if (data.Read() == true)
                        {
                            isLogin = true;
                            maNv = data["EMPLOYEE_ID"].ToString();
                            
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thất bại. \nSai tài khoản hoặc mật khẩu.");
                        }
                    }
                    // lay ten Nhan Vien, chuyen ve giao dien chinh
                    string truyVan2 = "SELECT * FROM EMPLOYEE WHERE EMPLOYEE_ID = '"+maNv+"'";
                    cmd.CommandText = truyVan2;
                    using (SqlDataReader data2 = cmd.ExecuteReader())
                    {
                        if (data2.Read() == true)
                        {
                            
                            fullName = data2["EMPLOYEE_NAME"].ToString();
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Lỗi dữ liệu");
                        }
                    }
                    connection.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối! " + ex.Message);
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
