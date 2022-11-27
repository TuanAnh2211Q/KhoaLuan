using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAO;
namespace BUS
{
    public class ThongTinChiTietPhieuDatHang_BUS
    {
        ThongTinChiTietPhieuDatHang_DAO thongTinChiTietPhieuDat_DAO = new ThongTinChiTietPhieuDatHang_DAO();

        public DataTable ds_SanPhamDat_BUS(string madat)
        {
            return thongTinChiTietPhieuDat_DAO.ds_SanPhamDatHang_DAO(madat);
        }
        public string tongGia_PhieuDat_BUS(string madat)
        {

            return thongTinChiTietPhieuDat_DAO.tongGia_PhieuDat_DAO(madat);
        }
        public bool insert_ThongTinDatHang(ThongTinChiTietPhieuDatHang_DTO thongTin)
        {
            return thongTinChiTietPhieuDat_DAO.insert_ThongTinDatHang(thongTin);
        }
        public bool update_ThongTinDatHang(ThongTinChiTietPhieuDatHang_DTO thongTin)
        {
            return thongTinChiTietPhieuDat_DAO.update_ThongTinDatHang(thongTin);
        }
        public bool delete_ThongTinDatHang(ThongTinChiTietPhieuDatHang_DTO thongTin)
        {
            return thongTinChiTietPhieuDat_DAO.delete_ThongTinDatHang(thongTin);
        }
    }
}
