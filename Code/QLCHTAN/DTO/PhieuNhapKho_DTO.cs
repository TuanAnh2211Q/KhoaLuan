using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapKho_DTO
    {
        private string maNhap;

        public string MaNhap
        {
            get { return maNhap; }
            set { maNhap = value; }
        }

        private DateTime ngayNhap;

        public DateTime NgayNhap
        {
            get { return ngayNhap; }
            set { ngayNhap = value; }
        }

        private string maDatHang;

        public string MaDatHang
        {
            get { return maDatHang; }
            set { maDatHang = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private bool trangThai;

        public bool TrangThai
        {
            get { return trangThai; }
            set { trangThai = value; }
        }

        public PhieuNhapKho_DTO(string MaNhap, DateTime NgayNhap, string MaDatHang, string GhiChu,bool TrangThai)
        {
            this.maNhap = MaNhap;
            this.ngayNhap = NgayNhap;
            this.maDatHang = MaDatHang;
            this.ghiChu = GhiChu;
            this.trangThai = TrangThai;
        }
    }
}
