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
    public class ThongTinThanhPhanDoAn_DAO:DataProvider
    {
        public DataTable show_thanhPhanDoAn_DAO(string maMonAn)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DoAn_ThanhPhanDoAn", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = maMonAn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable show_dsthanhPhanDoAn_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_MatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }
}
