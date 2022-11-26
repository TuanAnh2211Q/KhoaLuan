using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TaiKhoan_DTO
    {
        private int id;

        public int Id
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


        public TaiKhoan_DTO(int Id, string TenTaiKhoan,string MatKhau, string maNhanVien, string maQuyen)
        {
            this.id = Id;
            this.tenTaiKhoan = TenTaiKhoan;
            this.matKhau = MatKhau;
            this.maNhanVien = maNhanVien;
            this.maQuyen = maQuyen;
        }
    }
}
