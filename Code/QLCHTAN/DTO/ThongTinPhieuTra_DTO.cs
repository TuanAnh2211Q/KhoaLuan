using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinPhieuTra_DTO
    {
        private string maTra;

        public string MaTra
        {
            get { return maTra; }
            set { maTra = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        public ThongTinPhieuTra_DTO(string MaTra, string MaHang, int SoLuong)
        {
            this.maTra = MaTra;
            this.maHang = MaHang;
            this.soLuong = SoLuong;
        }
    }
}
