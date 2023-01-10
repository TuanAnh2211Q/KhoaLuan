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
    public class NhanVien_BUS
    {
        NhanVien_DAO nhanVien_DAO = new NhanVien_DAO();
        public DataTable show_list_ChucDanh_BUS()
        {
            return nhanVien_DAO.show_list_ChucDanh_DAO();
        }

        public DataTable show_list_LoaiNhanVien_BUS()
        {
            return nhanVien_DAO.show_list_LoaiNhanVien_DAO();
        }

        public DataTable show_list_NhanVien_BUS()
        {
            return nhanVien_DAO.show_list_NhanVien_DAO();
        }

        public bool insert_NhanVien_BUS(NhanVien_DTO nhanVien_DTO)
        {
            return nhanVien_DAO.insert_NhanVien_DAO(nhanVien_DTO);
        }
        public bool delete_NhanVien_BUS(NhanVien_DTO nhanVien_DTO)
        {
            return nhanVien_DAO.delete_NhanVien_DAO(nhanVien_DTO);
        }
        public bool update_NhanVien_BUS(NhanVien_DTO nhanVien_DTO)
        {
            return nhanVien_DAO.update_NhanVien_DAO(nhanVien_DTO);
        }
        public string select_TenNhanVien_BUS(string manv)
        {
            return nhanVien_DAO.select_TenNhanVien_DAO(manv);
        }

    }
}
