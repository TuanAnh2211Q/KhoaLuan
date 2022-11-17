using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThongTinChiTietPhieuDatHang_DTO
    {
        private string maDat;

        public string MaDat
        {
            get { return maDat; }
            set { maDat = value; }
        }

        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        private int soLuongDat;

        public int SoLuongDat
        {
            get { return soLuongDat; }
            set { soLuongDat = value; }
        }

        private decimal tongDonGia;

        public decimal TongDonGia
        {
            get { return tongDonGia; }
            set { tongDonGia = value; }
        }

        public ThongTinChiTietPhieuDatHang_DTO(string MaDat, string MaHang, string MaNCC, int SoLuongDat, decimal TongDonGia)
        {
            this.maDat = MaDat;
            this.maHang = MaHang;
            this.maNCC = MaNCC;
            this.soLuongDat = SoLuongDat;
            this.tongDonGia = TongDonGia;
        }
        
    }
}
