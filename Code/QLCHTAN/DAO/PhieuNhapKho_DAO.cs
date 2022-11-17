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
    public class PhieuNhapKho_DAO:DataProvider
    {
        public DataTable dsPhieuNhap_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_NhapKho", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable dsPhieuDat_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
