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
    public class ThongTinPhieuXuat_BUS
    {
        ThongTinPhieuXuat_DAO thongTinPhieuXuat_DAO = new ThongTinPhieuXuat_DAO();
        public bool insert_ThongTinXuatKho_BUS(ThongTinPhieuXuat_DTO thongTinXuatKho)
        {
            return thongTinPhieuXuat_DAO.insert_ThongTinXuatKho_DAO(thongTinXuatKho);
        }
        public bool check_ThongTinXuatKho_BUS(String maXuat)
        {
            return thongTinPhieuXuat_DAO.check_ThongTinXuatKho_DAO(maXuat);
        }
        public DataTable select_ThongTinPhieuXuat_BUS(string maxuat)
        {
            return thongTinPhieuXuat_DAO.select_ThongTinPhieuXuat_DAO(maxuat);
        }
    }
}
