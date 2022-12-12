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
   public class KhoBan_BUS
    {
        KhoBan_DAO khoban_DAO = new KhoBan_DAO();

        public DataTable show_KhoBan_BUS()
        {
            return khoban_DAO.show_KhoBan_DAO();

        }    

    }
}
