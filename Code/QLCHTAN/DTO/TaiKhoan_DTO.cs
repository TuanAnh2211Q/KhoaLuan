using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private string tenNhanVien;

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private string tenQuyen;

        public string TenQuyen
        {
            get { return tenQuyen; }
            set { tenQuyen = value; }
        }


        public TaiKhoan_DTO(string TenTaiKhoan, string TenNhanVien, string TenQuyen)
        {
            this.tenTaiKhoan = TenTaiKhoan;
            this.tenNhanVien = TenNhanVien;
            this.tenQuyen = TenQuyen;
        }
    }
}
