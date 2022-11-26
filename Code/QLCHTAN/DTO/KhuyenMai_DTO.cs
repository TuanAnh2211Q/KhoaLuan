using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class KhuyenMai_DTO
    {
        private string maKhuyenMai;

        public string MaKhuyenMai
        {
            get { return maKhuyenMai; }
            set { maKhuyenMai = value; }
        }

        private string tenKhuyenMai;

        public string TenKhuyenMai
        {
            get { return tenKhuyenMai; }
            set { tenKhuyenMai = value; }
        }

        private string maLoaiKM;

        public string MaLoaiKM
        {
            get { return maLoaiKM; }
            set { maLoaiKM = value; }
        }

        private float mucGiam;

        public float MucGiam
        {
            get { return mucGiam; }
            set { mucGiam = value; }
        }

        public KhuyenMai_DTO (string MaKhuyenMai, string TenKhuyenMai, string MaLoaiKM, float MucGiam)
        {
            this.maKhuyenMai = MaKhuyenMai;
            this.tenKhuyenMai = TenKhuyenMai;
            this.maLoaiKM = MaLoaiKM;
            this.mucGiam = MucGiam;
        }
    }
}
