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
        public bool insert_PhieuDat_BUS(PhieuDatHang_DTO phieudat)
        {
            return phieuDatHang_DAO.insert_PhieuDat_DAO(phieudat);
        }
        public bool delete_PhieuDat_BUS(PhieuDatHang_DTO phieudat)
        {
            return phieuDatHang_DAO.delete_PhieuDat_DAO(phieudat);
        }
        public bool update_PhieuDat_BUS(PhieuDatHang_DTO phieudat)
        {
            return phieuDatHang_DAO.update_PhieuDat_DAO(phieudat);
        }
        public string check_TrangThai_PhieuDat_PhieuTra(PhieuDatHang_DTO phieudat)
        {
            return phieuDatHang_DAO.check_TrangThai_PhieuDat_PhieuTra(phieudat);
        }
        public bool check_TrangThai_PhieuDat_PhieuNhap(PhieuDatHang_DTO phieudat)
        {
            return phieuDatHang_DAO.check_TrangThai_PhieuDat_PhieuNhap(phieudat);
        }
    }
}
