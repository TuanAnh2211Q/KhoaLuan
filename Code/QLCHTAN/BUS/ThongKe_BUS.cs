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

    }
}
