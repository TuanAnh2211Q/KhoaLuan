using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class OrderNuoc_DTO
    {
        public static int rong = 100;
        public static int dai = 100;
        private string maNuoc;
        private string tenNuoc;
        private string donViBan;
        private string giaBan;
        public string MaNuoc { get => maNuoc; set => maNuoc = value; }
        public string TenNuoc { get => tenNuoc; set => tenNuoc = value; }
        public string DonViBan { get => donViBan; set => donViBan = value; }
        public string GiaBan { get => giaBan; set => giaBan = value; }
        public OrderNuoc_DTO(string maNuoc,string tenNuoc,string donViBan,string giaBan)
        {
            this.maNuoc = MaNuoc;
            this.tenNuoc = TenNuoc;
            this.donViBan = DonViBan;
            this.giaBan = giaBan;
        }
        public OrderNuoc_DTO(DataRow row)
        {
            this.maNuoc = (string)row["maNuoc"].ToString();
            this.tenNuoc = (string)row["tenNuoc"].ToString();
            this.donViBan = (string)row["donViBan"].ToString();
            this.giaBan = (string)row["giaBanNuoc"].ToString();
        }
    }
}
