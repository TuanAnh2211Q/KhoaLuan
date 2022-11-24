using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinThanhPhanDoAn_DTO
    {
        private string maThanhPhan;

        public string MaThanhPhan
        {
            get { return maThanhPhan; }
            set { maThanhPhan = value; }
        }

        private string tenThanhPhan;

        public string TenThanhPhan
        {
            get { return tenThanhPhan; }
            set { tenThanhPhan = value; }
        }

        private string dinhLuong;

        public string DinhLuong
        {
            get { return dinhLuong; }
            set { dinhLuong = value; }
        }

        private string maDoAn;

        public string MaDoAn
        {
            get { return maDoAn; }
            set { maDoAn = value; }
        }

        public ThongTinThanhPhanDoAn_DTO (string MaThanhPhan, string TenThanhPhan, string DinhLuong, string MaDoAn)
        {
            this.maThanhPhan = MaThanhPhan;
            this.tenThanhPhan = TenThanhPhan;
            this.dinhLuong = DinhLuong;
            this.maDoAn = MaDoAn;
        }
    }
}
