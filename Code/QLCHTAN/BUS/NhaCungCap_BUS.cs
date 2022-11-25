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
    public class NhaCungCap_BUS
    {
        NhaCungCap_DAO ncc_DAO = new NhaCungCap_DAO();
        public DataTable show_dsNCC_BUS()
        {
            return ncc_DAO.show_dsNCC();
        }
        public bool insert_NCC_BUS(NhaCungCap_DTO ncc)
        {
            return ncc_DAO.insert_NCC_DAO(ncc);
        }
        public bool delete_NCC_BUS(NhaCungCap_DTO ncc)
        {
            return ncc_DAO.delete_NCC_DAO(ncc);
        }
        public bool update_NCC_BUS(NhaCungCap_DTO ncc)
        {
            return ncc_DAO.update_NCC_DAO(ncc);
        }
    }
}
