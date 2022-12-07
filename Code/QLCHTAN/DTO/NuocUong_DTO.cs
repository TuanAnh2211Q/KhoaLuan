using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NuocUong_DTO
    {
        private string maNuoc;

        public string MaNuoc
        {
            get { return maNuoc; }
            set { maNuoc = value; }
        }

        private string tenNuoc;

        public string TenNuoc
        {
            get { return tenNuoc; }
            set { tenNuoc = value; }
        }

        private string donViBan;

        public string DonViBan
        {
            get { return donViBan; }
            set { donViBan = value; }
        }

        private string donGia;

        public string DonGia
        {
            get { return donGia; }
            set { donGia = value; }
        }
       

        public NuocUong_DTO (string MaNuoc, string TenNuoc, string DonViBan, string DonGia)
        {
            this.maNuoc = MaNuoc;
            this.tenNuoc = TenNuoc;
            this.donViBan = DonViBan;
            this.donGia = DonGia;
            
        }
    }
}
