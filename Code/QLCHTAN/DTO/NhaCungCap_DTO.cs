using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhaCungCap_DTO
    {

        private string maNCC;

        public string MaNCC
        {
            get { return maNCC; }
            set { maNCC = value; }
        }

        private string tenNCC;

        public string TenNCC
        {
            get { return tenNCC; }
            set { tenNCC = value; }
        }

        private string diaChiNCC;

        public string DiaChiNCC
        {
            get { return diaChiNCC; }
            set { diaChiNCC = value; }
        }

        private string emailNCC;

        public string EmailNCC
        {
            get { return emailNCC; }
            set { emailNCC = value; }
        }

        private string sdtNCC;

        public string SdtNCC
        {
            get { return sdtNCC; }
            set { sdtNCC = value; }
        }

        private string ghiChu;

        public string GhiChu
        {
            get { return ghiChu; }
            set { ghiChu = value; }
        }

        public NhaCungCap_DTO (string MaNCC, string TenNCC, string DiachiNCC, string EmailNCC, string SdtNCC, string GhiChu)
        {
            this.maNCC = MaNCC;
            this.tenNCC = TenNCC;
            this.diaChiNCC = DiachiNCC;
            this.emailNCC = EmailNCC;
            this.sdtNCC = SdtNCC;
            this.ghiChu = GhiChu;
        }
    }
}
