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
        public DataTable dsChucDanh_BUS()
        {
            return nhanVien_DAO.dsChucDanh_DAO();
        }

        public DataTable dsLoaiNhanVien_BUS()
        {
            return nhanVien_DAO.dsLoaiNhanVien_DAO();
        }

        public DataTable dsNhanVien_BUS()
        {
            return nhanVien_DAO.dsNhanVien_DAO();
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

    }
}
