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
        public bool insert_PhieuNhap(PhieuNhapKho_DTO phieuNhapKho_DTO)
        {
            return phieuNhapKho_DAO.insert_PhieuNhap(phieuNhapKho_DTO);
        }
        public bool delete_PhieuNhap(PhieuNhapKho_DTO phieuNhapKho_DTO)
        {
            return phieuNhapKho_DAO.delete_PhieuNhap(phieuNhapKho_DTO);
        }
        public bool update_PhieuNhap(PhieuNhapKho_DTO phieuNhapKho_DTO)
        {
            return phieuNhapKho_DAO.update_PhieuNhap(phieuNhapKho_DTO);
        }
        public bool check_PhieuNhap(string maphieu)
        {
            return phieuNhapKho_DAO.check_PhieuNhap( maphieu);

        }
    }
}
