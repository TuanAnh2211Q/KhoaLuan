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
    public class ThongTinChiTietPhieuDatHang_DAO:DataProvider
    {
        public DataTable ds_SanPhamDatHang_DAO(string madat)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinDatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("maDatHang", SqlDbType.VarChar).Value =  madat;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public string tongGia_PhieuDat_DAO()
        {

            Open();
            SqlDataAdapter da = new SqlDataAdapter("tongGia_DatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            string dc = (da.SelectCommand.ExecuteScalar()).ToString();
            return dc;
        }
    }
}
