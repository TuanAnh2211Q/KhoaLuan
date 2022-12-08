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
    public class ThongTinTonKho_BUS
    {
        ThongTinTonKho_DAO thongTinTonKho_DAO = new ThongTinTonKho_DAO();
        public DataTable show_DS_HangTon_DAO()
        {
            return thongTinTonKho_DAO.show_DS_HangTon_DAO();
        }
    }
}
