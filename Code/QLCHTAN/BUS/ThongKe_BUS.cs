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

        public DataTable thongKeNguyenLieuSuDung_NTN_BUS(string loai, DateTime thoiGian)
        {
            return thongKe_DAO.thongKeNguyenLieuSuDung_NTN_DAO(loai, thoiGian);
        }
        public DataTable thongKeNguyenLieuSuDung_MTG_BUS(DateTime tg1, DateTime tg2)
        {
            return thongKe_DAO.thongKeNguyenLieuSuDung_NTG_DAO(tg1, tg2);
        }

        public DataSet thongKeNguyenLieuSuDung_Q_BUS(int nam, string quy)
        {
            return thongKe_DAO.thongKeNguyenLieuSuDung_Q_DAO(nam, quy);
        }

    }
}
