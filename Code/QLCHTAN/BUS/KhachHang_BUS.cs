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
        KhachHang_DAO khachhang = new KhachHang_DAO();
        public DataTable show_dsKhachHang_BUS()
        {
            return khachhang.show_dsKhachHang_DAO();
        }

        public bool update_KhachHang_BUS(KhachHang_DTO KhachHangDTO)
        {
            return khachhang.update_KhachHang_DAO(KhachHangDTO);
        }

    }
}
