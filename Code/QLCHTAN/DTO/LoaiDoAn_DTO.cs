using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiDoAn_DTO
    {
        private string maLoaiDoAn;

        public string MaLoaiDoAn
        {
            get { return maLoaiDoAn; }
            set { maLoaiDoAn = value; }
        }

        private string tenLoaiDoAn;

        public string TenLoaiDoAn
        {
            get { return tenLoaiDoAn; }
            set { tenLoaiDoAn = value; }
        }

        public LoaiDoAn_DTO(string MaLoaiDoAn, string TenLoaiDoAn)
        {
            this.maLoaiDoAn = MaLoaiDoAn;
            this.tenLoaiDoAn = TenLoaiDoAn;
        }
    }
}
