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
    public class PhieuNhapKho_BUS
    {
        PhieuNhapKho_DAO phieuNhapKho_DAO = new PhieuNhapKho_DAO();
        public DataTable dsPhieuNhap_BUS()
        {
            return phieuNhapKho_DAO.dsPhieuNhap_DAO();
        }
        public DataTable dsPhieuDat_BUS()
        {
            return phieuNhapKho_DAO.dsPhieuDat_DAO();
        }
    }
}
