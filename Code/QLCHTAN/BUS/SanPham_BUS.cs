using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace BUS
{
    public class SanPham_BUS
    {
        SanPham_DAO sanPham_DAO = new SanPham_DAO();
        public DataTable select_SanPham_DAO()
        {
            return sanPham_DAO.select_SanPham_DAO();
        }

    }
}
