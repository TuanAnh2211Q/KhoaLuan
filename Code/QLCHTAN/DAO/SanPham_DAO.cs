using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace DAO
{
    public class SanPham_DAO:DataProvider
    {
        public DataTable select_SanPham_DAO()
        {
            SqlDataAdapter da = new SqlDataAdapter("select_SanPham", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
    }
}
