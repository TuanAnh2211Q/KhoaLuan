using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTAN
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
            //Application.Run(new DangNhap_GUI());
            //Application.Run(new LoaiDoAn_GUI());
            //Application.Run(new TaiKhoan_GUI());
            //Application.Run(new Order_GUI());
            //Application.Run(new NhaCungCap_GUI());
            //Application.Run(new NuocUong_GUI());
            //Application.Run(new MatHang_GUI());
            //Application.Run(new CSDL());
            //Application.Run(new LoaiKhuyenMai_GUI());
            //Application.Run(new KhuyenMai_GUI());
            //Application.Run(new DoAn_GUI());
            //Application.Run(new NhanVien_GUI());
            Application.Run(new PhieuDatHang_GUI());
        }
    }
}
