using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinTonKho_DTO
    {
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private int soLuongTon;

        public int SoLuongTon
        {
            get { return soLuongTon; }
            set { soLuongTon = value; }
        }

        private decimal tongDonGia;

        public decimal TongDonGia
        {
            get { return tongDonGia; }
            set { tongDonGia = value; }
        }

        public ThongTinTonKho_DTO(string MaHang, int SoLuongTon, decimal TongDonGia)
        {
            this.maHang = MaHang;
            this.soLuongTon = SoLuongTon;
            this.tongDonGia = TongDonGia;
        }

    }
}
