using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineFoodOrder_Website.Models
{
    public class HoaDonDatHang
    {
        public string IdHoaDon { get; set; }
        public int IdNguoiDat { get; set; }
        public string TenSanPham { get; set; } 
        public int MaSanPham { get; set; }  
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<decimal> TongGia { get; set; }

        public HoaDonDatHang(string idHoaDon, int idNguoiDat, string tenSanPham, int maSanPham, int? soLuong, decimal? donGia, decimal? tongGia)
        {
            IdHoaDon = idHoaDon;
            IdNguoiDat = idNguoiDat;
            TenSanPham = tenSanPham;
            MaSanPham = maSanPham;
            SoLuong = soLuong;
            DonGia = donGia;
            TongGia = tongGia;
        }

        public HoaDonDatHang()
        {

        }
    }
}