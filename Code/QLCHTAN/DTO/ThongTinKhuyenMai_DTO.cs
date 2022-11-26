using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinKhuyenMai_DTO
    {
        private string maKM;

        public string MaKM
        {
            get { return maKM; }
            set { maKM = value; }
        }

        private string maSP;

        public string MaSP
        {
            get { return maSP; }
            set { maSP = value; }
        }

        private string ngayBD;

        public string NgayBD
        {
            get { return ngayBD; }
            set { ngayBD = value; }
        }

        private string ngayKT;

        public string NgayKT
        {
            get { return ngayKT; }
            set { ngayKT = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public ThongTinKhuyenMai_DTO(string MaKM, string MaSP, string NgayBD, string NgayKT, string GhiChu)
        {
            this.maKM = MaKM;
            this.maSP = MaSP;
            this.ngayBD = NgayBD;
            this.ngayKT = NgayKT;
            this.ghiChu = GhiChu;
        }

    }
}
