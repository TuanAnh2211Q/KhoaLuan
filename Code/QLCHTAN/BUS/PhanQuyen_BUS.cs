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
    public class PhanQuyen_BUS
    {
        PhanQuyen_DAO phanQuyen_DAO = new PhanQuyen_DAO();

        public DataTable dsQuyen_BUS()
        {
            return phanQuyen_DAO.dsQuyen_DAO();
        }
       public bool update_Quyen_BUS(PhanQuyen_DTO phanQuyen)
        {
            return phanQuyen_DAO.update_Quyen_DAO(phanQuyen);
        }
    }
}
