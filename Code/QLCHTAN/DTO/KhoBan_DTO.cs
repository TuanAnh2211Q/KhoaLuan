using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class KhoBan_DTO
    {
        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private int soLuong;

        public int SoLuong
        {
            get { return soLuong; }
            set { soLuong = value; }
        }

        private decimal tongGia;

        public decimal TongGia
        {
            get { return tongGia; }
            set { tongGia = value; }
        }

        private string maXuat;

        public string MaXuat
        {
            get { return maXuat; }
            set { maXuat = value; }
        }

        public KhoBan_DTO (string MaHang, int SoLuong, decimal TongGia, string MaXuat)
        {
            this.maHang = MaHang;
            this.soLuong = SoLuong;
            this.tongGia = TongGia;
            this.maXuat = MaXuat;
        }
    }
}
