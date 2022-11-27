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

     
        private int soLuongDat;

        public int SoLuongDat
        {
            get { return soLuongDat; }
            set { soLuongDat = value; }
        }

     
        public ThongTinChiTietPhieuDatHang_DTO(string MaDat, string MaHang, int SoLuongDat)
        {
            this.maDat = MaDat;
            this.maHang = MaHang;
            this.soLuongDat = SoLuongDat;

        }
        
    }
}
