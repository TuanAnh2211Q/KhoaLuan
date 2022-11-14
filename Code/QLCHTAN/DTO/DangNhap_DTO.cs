using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DangNhap_DTO
    {
        private string tenDangNhap;

        public string TenDangNhap
        {
            get { return tenDangNhap; }
            set { tenDangNhap = value; }
        }

        private string matKhau;

        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }


     
        public DangNhap_DTO (string TenDangNhap, string MatKhau)
        {
            this.tenDangNhap = TenDangNhap;
            this.matKhau = MatKhau;
        }
    }
}
