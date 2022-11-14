using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class NhanVien_DTO
    {
        private string maNhanVien;

        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }

        private string tenNhanVien;

        public string TenNhanVien
        {
            get { return tenNhanVien; }
            set { tenNhanVien = value; }
        }

        private string phai;

        public string Phai
        {
            get { return phai; }
            set { phai = value; }
        }

        private string sdt;

        public string SDT
        {
            get { return sdt; }
            set { sdt = value; }
        }

        private string eMail;

        public string Email
        {
            get { return eMail; }
            set { eMail = value; }
        }

        private string diaChi;

        public string DiaChi
        {
            get { return diaChi; }
            set { diaChi = value; }
        }

        private string maChucDanh;

        public string MaChucDanh
        {
            get { return maChucDanh; }
            set { maChucDanh = value; }
        }

        private string maLoaiNhanVien;

        public string MaLoaiNhanVien
        {
            get { return maLoaiNhanVien; }
            set { maLoaiNhanVien = value; }
        }

        public NhanVien_DTO (string MaNhanVien, string TenNhanVien, string Phai, string SDT, string Email, string DiaChi, string MaChucDanh, string MaLoaiNhanVien)
        {
            this.maNhanVien = MaNhanVien;
            this.tenNhanVien = TenNhanVien;
            this.phai = Phai;
            this.sdt = SDT;
            this.eMail = Email;
            this.diaChi = DiaChi;
            this.maChucDanh = MaChucDanh;
            this.maLoaiNhanVien = MaLoaiNhanVien;
        }
    }
}
