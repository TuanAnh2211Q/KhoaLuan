using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoAn_DTO
    {
        private string maDoAn;

        public string MaDoAn
        {
            get { return maDoAn; }
            set { maDoAn = value; }
        }

        private string tenDoAn;

        public string TenDoAn
        {
            get { return tenDoAn; }
            set { tenDoAn = value; }
        }

        private string maLoaiDoAn;

        public string MaLoaiDoAn
        {
            get { return maLoaiDoAn; }
            set { maLoaiDoAn = value; }
        }

        private string donViBan;

        public string DonViBan
        {
            get { return donViBan; }
            set { donViBan = value; }
        }

        private float donGia;

        public float DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }

        private string  ghiChu;

        public string  GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public DoAn_DTO (string MaDoAn, string TenDoAn, string MaLoaiDoAn, string DonViBan, float DonGia, string GhiChu)
        {
            this.maDoAn = MaDoAn;
            this.tenDoAn = TenDoAn;
            this.maLoaiDoAn = MaLoaiDoAn;
            this.donViBan = DonViBan;
            this.donGia = DonGia;
            this.ghiChu = GhiChu;
        }

    }
}
