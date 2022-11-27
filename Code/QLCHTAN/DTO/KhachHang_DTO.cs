using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhachHang_DTO
    {
        private string sDT;
        private string tenKhachHang;
        private string diaChi;
        private string ghiChu;


        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        public KhachHang_DTO(string sDT,string tenKhachHang, string diaChi, string ghiChu)
        {
            this.sDT = SDT;
            this.tenKhachHang = TenKhachHang;
            this.diaChi = DiaChi;
            this.ghiChu = GhiChu;
        }
    }
}
