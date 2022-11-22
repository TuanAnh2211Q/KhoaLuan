using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DTO
{
    public class OrderDoAn_DTO
    {
        private string maDoAn;
        public string MaDoAn { get => maDoAn; set => maDoAn = value; }
        private string maLoaiDoAn;
        public string MaLoaiDoAn { get => maLoaiDoAn; set => maLoaiDoAn = value; }
        public string TenDoAn { get => tenDoAn; set => tenDoAn = value; }
        public string GhiChu { get => ghiChu; set => ghiChu = value; }
        
        private string tenDoAn;
        private string ghiChu;
        public static int rong = 100;
        public static int dai = 100;
        public OrderDoAn_DTO(string maDoAn,string maLoaiDoAn, string tenDoAn,string ghiChu)
        {
            this.maDoAn = MaDoAn;
            this.maLoaiDoAn = MaLoaiDoAn;
            this.tenDoAn = TenDoAn;
            this.ghiChu = GhiChu;
        }
        public OrderDoAn_DTO(DataRow row)
        {
            this.maDoAn = (string)row["maDoAn"].ToString();
            this.maLoaiDoAn = (string)row["maLoaiDoAn"].ToString();
            this.tenDoAn = (string)row["tenDoAn"].ToString();
            this.ghiChu = (string)row["ghiChu"].ToString();
        }
       
    }
}
