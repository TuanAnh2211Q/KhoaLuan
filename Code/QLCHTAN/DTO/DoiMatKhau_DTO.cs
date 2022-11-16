using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiMatKhau_DTO
    {
        private string tenTaiKhoan;

        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }

        private string matKhauCu;

        public string MatKhauCu
        {
            get { return matKhauCu; }
            set { matKhauCu = value; }
        }

        private string matKhauMoi;

        public string MatKhauMoi
        {
            get { return matKhauMoi; }
            set { matKhauMoi = value; }
        }
        
        public DoiMatKhau_DTO (string TenTaiKhoan, string MatKhauCu, string MatKhauMoi)
        {
            this.tenTaiKhoan = TenTaiKhoan;
            this.matKhauCu = MatKhauCu;
            this.matKhauMoi = MatKhauMoi;
        }

    }
}
