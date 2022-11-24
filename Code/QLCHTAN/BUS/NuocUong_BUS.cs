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
        NuocUong_DAO nuocuong = new NuocUong_DAO();
        public DataTable show_dsNuocUong_BUS()
        {
            return nuocuong.show_dsNuocUong_DAO();
        }

        public bool insert_NuocUong_BUS(NuocUong_DTO NuocUong_DTO)
        {
            return nuocuong.insert_NuocUong_DAO(NuocUong_DTO);
        }
        public bool delete_NuocUong_BUS(NuocUong_DTO NuocUong_DTO)
        {
            return nuocuong.delete_NuocUong_DAO(NuocUong_DTO);
        }
        public bool update_NuocUong_BUS(NuocUong_DTO NuocUong_DTO)
        {
            return nuocuong.update_NuocUong_DAO(NuocUong_DTO);
        }
    }
}
