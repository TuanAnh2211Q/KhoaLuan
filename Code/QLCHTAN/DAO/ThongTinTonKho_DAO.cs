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
        public int select_SoLuong_TonKho_DAO(string mahang)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_SoLuong_TonKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = mahang;
            if (cmd.ExecuteScalar() != null)
                return Convert.ToInt32(cmd.ExecuteScalar());
            return 0;
        }
    }
}
