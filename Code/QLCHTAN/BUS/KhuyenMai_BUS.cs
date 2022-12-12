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
    public class KhuyenMai_BUS
    {
        KhuyenMai_DAO km_DAO = new KhuyenMai_DAO();
        public DataTable show_KM_BUS()
        {
            return km_DAO.show_KM_DAO();
        }
        public bool insert_KM_BUS(KhuyenMai_DTO km)
        {
            return km_DAO.insert_KM_DAO(km);
        }
        public bool update_KM_BUS(KhuyenMai_DTO km)
        {
            return km_DAO.update_KM_DAO(km);
        }
        public bool delete_KM_BUS(KhuyenMai_DTO km)
        {
            return km_DAO.delete_KM_DAO(km);
        }
        public decimal select_MucKhuyenMai_BUS(string maKhuyenMai)
        {
            return km_DAO.select_MucKhuyenMai_DAO(maKhuyenMai);
        }

    }
}
