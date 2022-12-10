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
    public class ThongTinDonHang_BUS
    {
        ThongTinDonHang_DAO thongTinDonHang_DAO = new ThongTinDonHang_DAO();
        public bool insert_ThongTinDonHang_BUS(ThongTinDonHang_DTO thongTinDonHang_DTO)
        {
            return thongTinDonHang_DAO.insert_ThongTinDonHang_DAO(thongTinDonHang_DTO);
        }
    }
}
