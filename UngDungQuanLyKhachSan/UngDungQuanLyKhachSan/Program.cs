using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyKhachSan
{
    static class quyDinh
    {
        public static double dongiaA = 150000;
        public static double dongiaB = 170000;
        public static double dongiaC = 200000;
        public static int max_number= 3;
        public static double phuThu= 0.25;
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

            DangNhap dangNhap = new DangNhap();
            Application.Run(dangNhap);
            if (dangNhap.isLogin == true)
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
