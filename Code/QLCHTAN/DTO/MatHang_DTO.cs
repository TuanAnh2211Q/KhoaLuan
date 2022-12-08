using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class MatHang_DTO
    {
        private string maHang;

        public string MaHang
        {
            get { return  maHang; }
            set {  maHang = value; }
        }

        private string tenHang;

        public string TenHang
        {
            get { return tenHang; }
            set { tenHang = value; }
        }

        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        private string donVi;

        public string DonVi
        {
            get { return donVi; }
            set { donVi = value; }
        }

        private string nsx;

        public string NSX
        {
            get { return nsx; }
            set { nsx = value; }
        }

        private string hsd;

        public string HSD
        {
            get { return hsd; }
            set { hsd = value; }
        }

        private decimal donGia;

        public decimal DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }
        private bool loaiHang;

        public bool LoaiHang
        {
            get { return loaiHang; }
            set { loaiHang = value; }
        }


        public MatHang_DTO(string MaHang, string TenHang, string MaNCC, string DonVi, string NSX, string HSD, decimal DonGia, string GhiChu,bool LoaiHang)
        {
            this.maHang = MaHang;
            this.tenHang = TenHang;
            this.maNCC = MaNCC;
            this.donVi = DonVi;
            this.nsx = NSX;
            this.hsd = HSD;
            this.donGia = DonGia;
            this.ghiChu = GhiChu;
            this.loaiHang = LoaiHang;
        }
    }
}
