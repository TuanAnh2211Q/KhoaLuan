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
    public class DangNhap_BUS
    {
        DangNhap_DAO dangNhap_DAO = new DangNhap_DAO();

        public bool dangNhapHeThong_BUS(DangNhap_DTO dangNhap_DTO)
        {
            return dangNhap_DAO.dangNhapHeThong_DAO(dangNhap_DTO);
        }
        public int kiemTraQuyenHeThong_BUS( DangNhap_DTO dangNhap_DTO)
        {
            return dangNhap_DAO.kiemTraQuyenHeThong_DAO(dangNhap_DTO);
        }

    }
}
