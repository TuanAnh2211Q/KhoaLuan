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
    public class ThongTinChiTietPhieuNhap_DAO:DataProvider
    {
        public DataTable dsThongTinPhieuNhap(ThongTinChiTIetPhieuNhap_DTO thongTinChiTIetPhieuNhap_DTO)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinNhapKho", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = thongTinChiTIetPhieuNhap_DTO.MaNhap.Trim();
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;

        }
    }
}
