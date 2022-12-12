using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonHang_DTO
    {
        private string maDonHang;
        private string tenDonHang;
        private string maLoaiDonHang;
        private bool maHinhThucThanhToan;
        private string maNhanVien;
        private string sDTKhachHang;
        private string maKhuyenMai;
        private DateTime thoiGianDat;
        private int trangThai;
        private string ghiChu;
       // private int iDKhachHang;
        private decimal tongGia;

        public string MaDonHang { get => maDonHang; set => maDonHang = value; }
        public string TenDonHang { get => tenDonHang; set => tenDonHang = value; }
        public string MaLoaiDonHang { get => maLoaiDonHang; set => maLoaiDonHang = value; }
        public bool MaHinhThucThanhToan { get => maHinhThucThanhToan; set => maHinhThucThanhToan = value; }
        public string MaNhanVien { get => maNhanVien; set => maNhanVien = value; }
        public string SDTKhachHang { get => sDTKhachHang; set => sDTKhachHang = value; }
        public string MaKhuyenMai { get => maKhuyenMai; set => maKhuyenMai = value; }
        public DateTime ThoiGianDat { get => thoiGianDat; set => thoiGianDat = value; }
        public int TrangThai { get => trangThai; set => trangThai = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
       // public int IDKhachHang { get => iDKhachHang; set => iDKhachHang = value; }
        public decimal TongGia { get => tongGia; set => tongGia = value; }

        public DonHang_DTO(string MaDonHang, string TenDonHang, string MaLoaiDonHang,bool MaHinhThucThanhToan, string MaNhanVien, string SDTKhachHang,string MaKhuyenMai,DateTime ThoiGianDat, int TrangThai,string GhiChu, /*int iDKhachHang,*/decimal TongGia)
        {
            this.maDonHang = MaDonHang;
            this.tenDonHang = TenDonHang;
            this.MaLoaiDonHang = MaLoaiDonHang;
            this.maHinhThucThanhToan = MaHinhThucThanhToan;
            this.maNhanVien = MaNhanVien;
            this.sDTKhachHang = SDTKhachHang;
            this.maKhuyenMai = MaKhuyenMai;
            this.thoiGianDat = ThoiGianDat;
            this.trangThai = TrangThai;
            this.ghiChu = GhiChu;
//            this.iDKhachHang = IDKhachHang;
            this.tongGia = TongGia;
        }
    }
}
