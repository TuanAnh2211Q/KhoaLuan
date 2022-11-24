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
   public class ThongTinThanhPhanDoAn_BUS
    {
        ThongTinThanhPhanDoAn_DAO tttpda_DAO = new ThongTinThanhPhanDoAn_DAO();

        public DataTable show_ThanhPhanDoAn_BUS(string maDoAn)
        {
            return tttpda_DAO.show_thanhPhanDoAn_DAO(maDoAn);
        }
        public DataTable show_dsthanhPhanDoAn_BUS()
        {
            return tttpda_DAO.show_dsthanhPhanDoAn_DAO();
        }
        public bool insert_ThanhPhanDoAn_DAO(ThongTinThanhPhanDoAn_DTO tttpda)
        {
            return tttpda_DAO.insert_ThanhPhanDoAn_DAO(tttpda);
        }
        public bool update_ThanhPhanDoAn_DAO(ThongTinThanhPhanDoAn_DTO tttpda)
        {
            return tttpda_DAO.update_ThanhPhanDoAn_DAO(tttpda);
        }
        public bool delete_ThanhPhanDoAn_DAO(ThongTinThanhPhanDoAn_DTO tttpda)
        {
            return tttpda_DAO.delete_ThanhPhanDoAn_DAO(tttpda);
        }

    }
}
