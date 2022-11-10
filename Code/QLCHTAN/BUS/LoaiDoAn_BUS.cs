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
    public class LoaiDoAn_BUS
    {
        LoaiDoAn_DAO loaiDoAn_DAO = new LoaiDoAn_DAO();

        public DataTable dsLoaiDoAn_BUS()
        {
            return loaiDoAn_DAO.dsLoaiDoAn_DAO();
        }
        public bool insert_LoaiDoAn_BUS(LoaiDoAn_DTO loaiDoAn_DTO)
        {
            return loaiDoAn_DAO.insert_LoaiDoAn_DAO(loaiDoAn_DTO);
        }
    }
}
