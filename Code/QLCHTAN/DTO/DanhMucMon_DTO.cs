using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DanhMucMon_DTO
    {
        private string maMonAn;
        public string MaMonAn { get => maMonAn; set => maMonAn = value; }
        private string tenMonAn;
        public string TenMonAn { get => tenMonAn; set => tenMonAn = value; }

        public DanhMucMon_DTO (string maMonAn,string tenMonAn)
        {
            this.MaMonAn = maMonAn;
            this.TenMonAn = tenMonAn;
        }
        
    }
}
