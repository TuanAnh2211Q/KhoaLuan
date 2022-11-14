using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhanQuyen_DTO
    {
        private string maQuyen;

        public string MaQuyen
        {
            get { return maQuyen; }
            set { maQuyen = value; }
        }

        private string tenQuyen;

        public string TenQuyen
        {
            get { return tenQuyen; }
            set { tenQuyen = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public PhanQuyen_DTO(string MaQuyen, string TenQuyen, string GhiChu)
        {
            this.maQuyen = MaQuyen;
            this.tenQuyen = TenQuyen;
            this.ghiChu = GhiChu;
        }



    }
}
