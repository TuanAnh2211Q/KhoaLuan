using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;

namespace BUS
{
    class DangNhap_BUS
    {
        DangNhap_DAO dangNhap_DAO = new DangNhap_DAO();
        public bool kiemTraDangNhap(string taiKhoan, string matKhau)
        { return dangNhap_DAO.kiemTraDangNhap(taiKhoan, matKhau); }

    }
}
