using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class LoaiKhuyenMai_DTO
    {
        private string maLoaiKhuyenMai;

        public string MaLoaiKhuyenMai
        {
            get { return maLoaiKhuyenMai; }
            set { maLoaiKhuyenMai = value; }
        }

        private string tenLoaiKhuyenMai;

        public string TenLoaiKhuyenMai
        {
            get { return tenLoaiKhuyenMai; }
            set { tenLoaiKhuyenMai = value; }
        }

        public LoaiKhuyenMai_DTO(string MaLoaiKhuyenMai, string TenLoaiKhuyenMai)
        {
            this.maLoaiKhuyenMai = MaLoaiKhuyenMai;
            this.tenLoaiKhuyenMai = TenLoaiKhuyenMai;
        }
    }
}
