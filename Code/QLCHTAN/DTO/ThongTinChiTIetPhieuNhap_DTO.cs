using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinChiTietPhieuNhap_DTO
    {
        private string maNhap;

        public string MaNhap
        {
            get { return maNhap; }
            set { maNhap = value; }
        }

        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        private string maHang;

        public string MaHang
        {
            get { return maHang; }
            set { maHang = value; }
        }

        private int soLuongNhap;

        public int SoLuongNhap
        {
            get { return soLuongNhap; }
            set { soLuongNhap = value; }
        }

        private decimal tongDonGia ;

        public  decimal TongDonGia
        {
            get { return tongDonGia; }
            set { tongDonGia = value; }
        }

        public ThongTinChiTietPhieuNhap_DTO (string MaNhap, string MaNCC, string MaHang, int SoLuongNhap, decimal TongDonGia)
        {
            this.maNhap = MaNhap;
            this.maNCC = MaNCC;
            this.maHang = MaHang;
            this.soLuongNhap = SoLuongNhap;
            this.tongDonGia = TongDonGia;
        }

    }
}
