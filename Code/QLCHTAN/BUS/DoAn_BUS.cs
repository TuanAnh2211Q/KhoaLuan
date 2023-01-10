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
    public class DoAn_BUS
    {
        DoAn_DAO doAn_DAO = new DoAn_DAO();

        public DataTable show_list_DoAn_BUS()
        {
            return doAn_DAO.show_list_DoAn_DAO();
        }
        public DataTable show_list_LoaiDoAn_BUS()
        {
            return doAn_DAO.show_list_LoaiDoAn_DAO();
        }
        public bool insert_DoAn_ThongTinDoAn_BUS(DoAn_DTO doAn_DTO)
        {
            return doAn_DAO.insert_DoAn_DAO(doAn_DTO);
        }
        public bool delete_DoAn_ThongTinDoAn_BUS(DoAn_DTO doAn_DTO)
        {
            return doAn_DAO.delete_DoAn_DAO(doAn_DTO);
        }
        public bool update_DoAn_ThongTinDoAn_BUS(DoAn_DTO doAn_DTO)
        {
            return doAn_DAO.update_DoAn_DAO(doAn_DTO);
        }
        //public DataTable show_dsMon_BUS()
        //{
        //    return doAn_DAO.show_dsMon_DAO();
        //}


        public DataTable show_DoAnTheoLoai_BUS(string maLoaiDoAN)
        {
            return doAn_DAO.show_DoAnTheoLoai_DAO(maLoaiDoAN);

        }
        public DataTable select_DonViBanDoAn_BUS(string maDoAn)
        {
            return doAn_DAO.select_DonViBanDoAn_DAO(maDoAn);
        }
        public decimal select_donGia_BUS(string maSanPham,string donViBan)
        {
            return doAn_DAO.select_donGia_DAO(maSanPham,donViBan);
        }
        public string select_maSanPhamDoAn_BUS(string maDoAn)
        {
            return doAn_DAO.select_maSanPhamDoAn_DAO(maDoAn);
        }
    }
}
