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
   public class PhieuDatHang_BUS
    {
        PhieuDatHang_DAO phieuDatHang_DAO = new PhieuDatHang_DAO();
        public DataTable dsPhieuDatHang_BUS()
        {
            return phieuDatHang_DAO.dsPhieuDat_DAO();
        }    
    }
}
