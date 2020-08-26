using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyKhachSan
{
    static class quyDinh
    {
        public static int dongiaA = 150000;
        public static int dongiaB = 170000;
        public static int dongiaC = 200000;
        public static int max_number = 3;
        public static double phuThu = 0.25;
        public static void update(int a, int b, int c, int max, double pt)
        {
            dongiaA = a;
            dongiaB = b;
            dongiaC = c;
            max_number = max;
            phuThu = pt;
        }
    }
    static class check_Login
    {
        public static bool isLogin = false;
        public static bool isOut = false;
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //quanLy form_quanly = new quanLy("Thiện Tín");
            //Application.Run(form_quanly);

            while (check_Login.isLogin == false && check_Login.isOut == false)
            {
                DangNhap dangNhap = new DangNhap();
                Application.Run(dangNhap);
                if (check_Login.isLogin == true)
                {
                    if (dangNhap.isQuanLy == true)
                    {
                        quanLy form_quanly = new quanLy(dangNhap.fullName);
                        Application.Run(form_quanly);
                    }
                    else
                    {
                        Form_Main giaoDien = new Form_Main(dangNhap.fullName);
                        Application.Run(giaoDien);
                    }
                }
            }
        }
    }
}
