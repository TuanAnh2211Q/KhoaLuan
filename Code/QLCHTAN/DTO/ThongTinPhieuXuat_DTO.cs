using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinPhieuXuat_DTO
    {
        private string maXuat;

        public string MaXuat
        {
            get { return maXuat; }
            set { maXuat = value; }
        }

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

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

   
        public ThongTinPhieuXuat_DTO(string MaXuat, string MaHang, int SoLuong, string GhiChu)
        {
            this.maXuat = MaXuat;
            this.maHang = MaHang;
            this.soLuong = SoLuong;
            this.ghiChu = GhiChu;
        }
    }
}
