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
        //public bool isLogin { get; set; }

        public bool isQuanLy { get; set; }
        public string maNv { get; set; }
        public string fullName { get; set; }

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
        public DangNhap()
        {
            InitializeComponent();
            SetStyle(ControlStyles.ResizeRedraw, true);
            //check_Login.isLogin = false;
            isQuanLy = false;
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            string tk = txt_TK.Text;
            string mk = txt_MK.Text;
            string truyVan = "EXEC CHECK_LOGIN @USERNAME = '"+tk+"', @PASS ='"+mk+"'";
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
            DataSet data = truyVanDuLieu(truyVan);
            if (data.Tables[0].Rows.Count !=0)
            {
                check_Login.isLogin = true; 
                maNv = data.Tables[0].Rows[0][0].ToString();
                string truyVan2 = "EXEC get_name_role @MANV = '"+maNv+"'";
                data = truyVanDuLieu(truyVan2);
                if (data != null)
                {
                    fullName = data.Tables[0].Rows[0][0].ToString();
                    if (data.Tables[0].Rows[0][1].ToString() == "True")
                    {
                        isQuanLy = true;
                        //MessageBox.Show("La quan ly");
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu");
                }
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại. \nSai tài khoản hoặc mật khẩu.");
            }
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            check_Login.isOut = true;
            Application.Exit();
        }
    }
}
