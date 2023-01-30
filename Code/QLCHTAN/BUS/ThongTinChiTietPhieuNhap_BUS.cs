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
    public class ThongTinChiTietPhieuNhap_BUS
    {
        ThongTinChiTietPhieuNhap_DAO thongTinChiTietPhieuNhap_DAO = new ThongTinChiTietPhieuNhap_DAO();
        public DataTable dsThongTinChiTietPhieuNhap(string manhap)
        {
            return thongTinChiTietPhieuNhap_DAO.dsThongTinPhieuNhap(manhap);
        }
        public decimal select_TongGiaNhap_DAO(string manhap)
        {
            return thongTinChiTietPhieuNhap_DAO.select_TongGiaNhap_DAO(manhap);
        }
        public DataTable select_to_PhieuNhap_Temp(string madat, string matra)
        {
            return thongTinChiTietPhieuNhap_DAO.select_to_PhieuNhap_Temp(madat, matra);
        }
        public bool insert_ThongTinPhieuNhap_DAO(ThongTinChiTietPhieuNhap_DTO thongtin)
        {
            return thongTinChiTietPhieuNhap_DAO.insert_ThongTinPhieuNhap_DAO(thongtin);
        }


    }
}
