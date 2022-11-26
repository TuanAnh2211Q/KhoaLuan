using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
   public  class TaiKhoan_BUS
    {
        TaiKhoan_DAO taiKhoan_DAO = new TaiKhoan_DAO();
        public DataTable show_TTTK_BUS()
        {
            return taiKhoan_DAO.show_TTTK_DAO();
        }
        public bool ganQuyen_BUS(TaiKhoan_DTO taiKhoan_DTO)
        {
            return taiKhoan_DAO.ganQuyen_DAO(taiKhoan_DTO);
        }
        public bool rs_MatKhau_BUS(TaiKhoan_DTO taikhoan)
        {
            return taiKhoan_DAO.rs_MatKhau_DAO(taikhoan);
        }
    }
}
