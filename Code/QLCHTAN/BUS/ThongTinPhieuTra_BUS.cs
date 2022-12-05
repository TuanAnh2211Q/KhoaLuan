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
   public class ThongTinPhieuTra_BUS
    {
        ThongTinPhieuTra_DAO thongTinPhieuTra_DAO = new ThongTinPhieuTra_DAO();

        public DataTable ds_SanPhamTra_BUS(string matra)
        {
            return thongTinPhieuTra_DAO.ds_SanPhamTra_DAO(matra);
        }
        public string select_SoLuongDat_DAO(string madat, string mahang)
        {
            return thongTinPhieuTra_DAO.select_SoLuongDat_DAO(madat, mahang);
        }
        public string tongGia_PhieuTra_BUS(string matra)
        {

            return thongTinPhieuTra_DAO.tongGia_PhieuTra_DAO(matra);
        }

        public int soLuong_hangTra(ThongTinPhieuTra_DTO thongTin)
        {
            return thongTinPhieuTra_DAO.soLuong_hangTra(thongTin);
        }
        public bool insert_ThongTinPhieuTra(ThongTinPhieuTra_DTO thongTin)
        {
            return thongTinPhieuTra_DAO.insert_ThongTinPhieuTra(thongTin);
        }
      
        public bool delete_ThongTinTraHang(ThongTinPhieuTra_DTO thongTin)
        {
            return thongTinPhieuTra_DAO.delete_ThongTinTraHang(thongTin);
        }

        public bool update_ThongTinTraHang(ThongTinPhieuTra_DTO thongTin)
        {
            return thongTinPhieuTra_DAO.update_ThongTinTraHang(thongTin);
        }

    }
}
