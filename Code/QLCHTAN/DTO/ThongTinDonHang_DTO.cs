using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinDonHang_DTO
    {
        private string maDonHang;
        private string maSanPham;
        private decimal giaTien;
        private int soLuong;
        private decimal thanhTien;

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string MaSanPham { get => maSanPham; set => maSanPham = value; }
        public decimal GiaTien { get => giaTien; set => giaTien = value; }
        public int SoLuong { get => soLuong; set => soLuong = value; }
        public decimal ThanhTien { get => thanhTien; set => thanhTien = value; }

        public ThongTinDonHang_DTO(string MaDonHang, string  MaSanPham, decimal GiaTien,int SoLuong, decimal ThanhTien)
        {
            this.maDonHang = MaDonHang;
            this.maSanPham = MaSanPham;
            this.giaTien = GiaTien;
            this.soLuong = SoLuong;
            this.thanhTien = ThanhTien;
        }
    }
}
