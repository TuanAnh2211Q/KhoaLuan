using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
namespace BUS
{
    public class ThongKe_BUS
    {
        ThongKe_DAO thongKe_DAO = new ThongKe_DAO();
        public DataTable thongKeDoanhThu_BUS(string loaiThongKe, DateTime thoiGian)
        {
            return thongKe_DAO.thongKeDoanhThu_DAO(loaiThongKe, thoiGian);
        }
        public DataTable thongKeDoanhThu_MTG_BUS(DateTime tg1, DateTime tg2)
        {
            return thongKe_DAO.thongKeDoanhThu_MTG_DAO(tg1, tg2);

        }
        public DataSet thongKeDoanhThu_TQ_BUS(int nam, string quy)
        {
            return thongKe_DAO.thongKeDoanhThu_TQ_DAO(nam, quy);
        }

        public DataTable thongKeHangHoa_NTN_BUS(string loai, DateTime thoiGian)
        {
            return thongKe_DAO.thongKeHangHoa_NTN_DAO(loai, thoiGian);
        }
        public DataTable thongKeHangHoa_MTG_BUS(DateTime tg1, DateTime tg2)
        {
            return thongKe_DAO.thongKeHangHoa_MTG_DAO(tg1, tg2);
        }

        public DataSet thongKeHangHoa_TQ_BUS(int nam, string quy)
        {
            return thongKe_DAO.thongKeHangHoa_TQ_DAO(nam, quy);
        }
        public DataTable thongKeHangHoa_TMH_BUS(string mahang)
        {
            return thongKe_DAO.thongKeHangHoa_TMH_DAO(mahang);
        }
        public DataTable thongKeSanPham_NTN_BUS(string loai, DateTime ngay)
        {
            return thongKe_DAO.thongKeSanPham_NTN_DAO(loai, ngay);
        }
        public DataTable thongKeSanPham_MTG_BUS(DateTime tg1, DateTime tg2)
        {
            return thongKe_DAO.thongKeSanPham_MTG_DAO(tg1, tg2);
        }
        public DataSet thongKeSanPham_TQ_BUS(int nam, string quy)
        {
            return thongKe_DAO.thongKeSanPham_TQ_DAO(nam, quy);
        }
        public DataTable thongKeSanPham_TSP_BUS(string masp)
        {
            return thongKe_DAO.thongKeSanPham_TSP_DAO(masp);
        }
    }
}
