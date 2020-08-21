using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UngDungQuanLyKhachSan
{
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
                Form_Main giaoDien = new Form_Main(dangNhap.fullName);
                Application.Run(giaoDien);
            }
        }
    }
}
