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
    public class DonHang_BUS
    {
        DonHang_DAO donHang_DAO = new DonHang_DAO();
        public bool insert_DonHang_DAO(DonHang_DTO donHang_DTO)
        {
            return donHang_DAO.insert_DonHang_DAO(donHang_DTO);
        }
    }
}
