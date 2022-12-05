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
   public class NuocUong_BUS
    {
        NuocUong_DAO nuocUong_DAO = new NuocUong_DAO();
        public DataTable show_dsNuocUong_BUS()
        {
            return nuocUong_DAO.show_dsNuocUong_DAO();
        }

        public bool insert_NuocUong_BUS(NuocUong_DTO NuocUong_DTO)
        {
            return nuocUong_DAO.insert_NuocUong_DAO(NuocUong_DTO);
        }
        public bool delete_NuocUong_BUS(NuocUong_DTO NuocUong_DTO)
        {
            return nuocUong_DAO.delete_NuocUong_DAO(NuocUong_DTO);
        }
        public bool update_NuocUong_BUS(NuocUong_DTO NuocUong_DTO)
        {
            return nuocUong_DAO.update_NuocUong_DAO(NuocUong_DTO);
        }
        public DataTable show_dsLoaiNuocUong_BUS(string maNuoc)
        {
            return nuocUong_DAO.show_dsLoaiNuocUong_DAO(maNuoc);
        }
        public string select_DonViBanNuocUong_BUS(string maNuoc)
        {
            return nuocUong_DAO.select_DonViBanNuocUong(maNuoc);
        }
    }
}
