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
    public class PhieuDatHang_DAO:DataProvider
    {
        public DataTable dsPhieuDat_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        
    }
}
