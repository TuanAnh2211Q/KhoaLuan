using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuTra_DTO
    {
        private string maTra;

        public string MaTra
        {
            get { return maTra; }
            set { maTra = value; }
        }

        private string maDat;

        public string MaDat
        {
            get { return maDat; }
            set { maDat = value; }
        }

        private DateTime ngayTra;

        public DateTime NgayTra
        {
            get { return ngayTra; }
            set { ngayTra = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

  
        public PhieuTra_DTO (string MaTra, string MaDat, DateTime NgayTra, string GhiChu)
        {
            this.maTra = MaTra;
            this.maDat = MaDat;
            this.ngayTra = NgayTra;
            this.ghiChu = GhiChu;
        }
    }
}
