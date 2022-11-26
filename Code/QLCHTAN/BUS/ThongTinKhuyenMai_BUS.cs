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
    public class ThongTinKhuyenMai_BUS
    {
        ThongTinKhuyenMai_DAO ttkm_DAO = new ThongTinKhuyenMai_DAO();
        public DataTable select_TTSP_BUS()
        {
            return ttkm_DAO.select_TTSP_DAO();
        }
        public DataTable show_TTKM_BUS(string makm)
        {
            return ttkm_DAO.show_TTKM_DAO(makm);
        }

        public bool insert_TTKM_BUS(ThongTinKhuyenMai_DTO ttkm)
        {
            return ttkm_DAO.insert_TTKM_DAO(ttkm);
        }
        public bool update_TTKM_BUS(ThongTinKhuyenMai_DTO ttkm)
        {
            return ttkm_DAO.update_TTKM_DAO(ttkm);
        }
        public bool delete_TTKM_BUS(ThongTinKhuyenMai_DTO ttkm)
        {
            return ttkm_DAO.delete_TTKM_DAO(ttkm);
        }

    }
}
