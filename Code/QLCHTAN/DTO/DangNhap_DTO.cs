using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class DangNhap_DTO
   {
        private string id;
        public string ID
        {
            get { return id; }
            set { id = value; }
        }
        private string tenTaiKhoan;
        public string TenTaiKhoan
        {
            get { return tenTaiKhoan; }
            set { tenTaiKhoan = value; }
        }
        private string matKhau;
        public string MatKhau
        {
            get { return matKhau; }
            set { matKhau = value; }
        }
        private string maNhanVien;
        public string MaNhanVien
        {
            get { return maNhanVien; }
            set { maNhanVien = value; }
        }
        private string maQuyen;
        public string MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }
        public DangNhap_DTO(string id, String TenTaiKhoan, string MatKhau,string MaNhanVien,String MaQuyen)
        {
            this.id = ID;
            this.tenTaiKhoan = TenTaiKhoan;
            this.matKhau = MatKhau;
            this.maNhanVien = MaNhanVien;
            this.maQuyen = MaQuyen;
        }
    }
}
