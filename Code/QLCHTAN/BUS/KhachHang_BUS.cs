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
    public class KhachHang_BUS
    {
        KhachHang_DAO khachhang_DAO = new KhachHang_DAO();
        public DataTable show_dsKhachHang_BUS()
        {
            return khachhang_DAO.show_dsKhachHang_DAO();
        }
        public DataTable find_KhachHang_BUS(string sdt)
        {
            return khachhang_DAO.Find_KhachHang_DAO(sdt);
        }
        public bool update_KhachHang_BUS(KhachHang_DTO KhachHangDTO)
        {
            return khachhang_DAO.update_KhachHang_DAO(KhachHangDTO);
        }
        public bool delete_KhachHang_BUS(KhachHang_DTO khachHangDTO)
        {
            return khachhang_DAO.delete_KhachHang_DAO(khachHangDTO);
        }
            
    }
}
