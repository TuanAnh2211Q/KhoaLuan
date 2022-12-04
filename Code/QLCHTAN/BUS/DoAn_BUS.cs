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

        public DataTable show_dsDoAn_BUS()
        {
            return doAn_DAO.show_ds_DoAn_DAO();
        }
        public DataTable show_dsLoaiDoAn_BUS()
        {
            return doAn_DAO.show_ds_LoaiDoAn_DAO();
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
        public DataTable show_dsMon_BUS()
        {
            return doAn_DAO.show_dsMon_DAO();
        }
        public DataTable show_DSLoaiDoAn_BUS(string maLoaiDoAN)
        {
            return doAn_DAO.show_dsLoaiDoAn_DAO(maLoaiDoAN);

        }
    }
}
