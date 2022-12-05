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
    public class PhieuTra_BUS
    {
        PhieuTra_DAO phieuTra_DAO = new PhieuTra_DAO();

        public DataTable show_PhieuTra_BUS()
        {
            return phieuTra_DAO.show_PhieuTra_DAO();
        }
        public bool insert_PhieuTra_BUS(PhieuTra_DTO phieutra)
        {
            return phieuTra_DAO.insert_PhieuTra_DAO(phieutra);
        }
        public bool delete_PhieuTra_BUS(PhieuTra_DTO phieutra)
        {
            return phieuTra_DAO.delete_PhieuTra_DAO(phieutra);
        }
        public bool update_PhieuTra_BUS(PhieuTra_DTO phieutra)
        {
            return phieuTra_DAO.update_PhieuTra_DAO(phieutra);
        }
        public object check_date_TraHang_DAO(PhieuTra_DTO phieutra)
        {
            return phieuTra_DAO.check_date_TraHang_DAO(phieutra);
        }
    }
}
