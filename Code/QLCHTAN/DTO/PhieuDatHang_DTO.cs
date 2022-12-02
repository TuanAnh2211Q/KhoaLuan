using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuDatHang_DTO
    {
        private string maDatHang;

        public string MaDatHang
        {
            get { return maDatHang; }
            set { maDatHang = value; }
        }

        private DateTime ngayDatHang;

        public DateTime NgayDatHang
        {
            get { return ngayDatHang; }
            set { ngayDatHang = value; }
        }

        private DateTime ngayDuKienGiao;

        public DateTime NgayDuKienGiao
        {
            get { return ngayDuKienGiao; }
            set { ngayDuKienGiao = value; }
        }

        private string phuongThucThanhToan;

        public string PhuongThucThanhToan
        {
            get { return phuongThucThanhToan; }
            set { phuongThucThanhToan = value; }
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


        public PhieuDatHang_DTO(string MaDatHang, DateTime NgayDatHang, DateTime NgayDuKienGiao, string PhuongThucThanhToan, string GhiChu,bool TrangThai )
        {
            this.maDatHang = MaDatHang;
            this.ngayDatHang = NgayDatHang;
            this.ngayDuKienGiao = NgayDuKienGiao;
            this.phuongThucThanhToan = PhuongThucThanhToan;
            this.ghiChu = GhiChu;
            this.trangThai = TrangThai;
        }


    }
}
