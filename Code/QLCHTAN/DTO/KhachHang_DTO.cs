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
        //private string idKhachHang;
        private string phai;
        private string email;

        public string TenKhachHang { get => tenKhachHang; set => tenKhachHang = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string DiaChi { get => diaChi; set => diaChi = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        //public string IdKhachHang { get => idKhachHang; set => idKhachHang = value; }
        public string Phai { get => phai; set => phai = value; }
        public string Email { get => email; set => email = value; }
        public string MaLoaiKhach { get => email; set => email = value; }

        public KhachHang_DTO(/*string idKhachHang,*/string sDT,string tenKhachHang,  string phai, string diaChi, string email, string ghiChu,string maLoaiKhach)
        {
            //this.IdKhachHang = idKhachHang;
            this.SDT = sDT;
            this.TenKhachHang = tenKhachHang;
            this.Phai = phai;
            this.DiaChi = diaChi;
            this.Email = email;
            this.GhiChu = ghiChu;
            this.MaLoaiKhach = maLoaiKhach;
        }
    }
}
