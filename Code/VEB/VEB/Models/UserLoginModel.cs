using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VEB.Models
{
    public class UserLoginModel
    {
        public int ID { get; set; }
        public string tenDangNhap { get; set; }
        public string matKhau { get; set; }
        public string maNhanVien { get; set; }
        public string maQuyen { get; set; }
    }
}