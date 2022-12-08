using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
namespace DAO
{
   public class ThongTinTonKho_DAO:DataProvider
    {
        public DataTable show_DS_HangTon_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_TonKho", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
