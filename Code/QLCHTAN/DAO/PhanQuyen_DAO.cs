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
    public class PhanQuyen_DAO:DataProvider
    {
        public DataTable dsQuyen_DAO()
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_PhanQuyen", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

    }

}
