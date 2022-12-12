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
    public class PhieuXuat_BUS
    {
        PhieuXuat_DAO phieuXuat_DAO = new PhieuXuat_DAO();
        public DataTable select_PhieuXuat_BUS()
        {
            return phieuXuat_DAO.select_PhieuXuat_DAO();
        }
        public bool insert_PhieuXuat_BUS(PhieuXuat_DTO phieuXuat)
        {
            return phieuXuat_DAO.insert_PhieuXuat_DAO(phieuXuat);
        }
        public bool check_MaXuat_BUS(String maXuat)
        {
            return phieuXuat_DAO.check_MaXuat_DAO(maXuat);
        }
        public bool update_PhieuXuat_BUS(String maXuat)
        {
            return phieuXuat_DAO.update_PhieuXuat_DAO(maXuat);
        }
        public bool delete_PhieuXuat_DAO(PhieuXuat_DTO phieuXuat)
        {
            return phieuXuat_DAO.delete_PhieuXuat_DAO(phieuXuat);

        }
    }
}
