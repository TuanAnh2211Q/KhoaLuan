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
    public class PhieuXuat_DAO:DataProvider
    {
        public DataTable select_PhieuXuat_DAO()

        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_XuatKho", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insert_PhieuXuat_DAO(PhieuXuat_DTO phieuXuat)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_XuatKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maXuat", SqlDbType.VarChar).Value = phieuXuat.MaXuat;
                cmd.Parameters.Add("@ngayXuat", SqlDbType.DateTime).Value = phieuXuat.NgayXuat;
                cmd.Parameters.Add("@trangThai", SqlDbType.Bit).Value = phieuXuat.TrangThai;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool check_MaXuat_DAO(String maXuat)
        {
            Open();
            SqlCommand cmd = new SqlCommand("check_PhieuXuat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maXuat", SqlDbType.VarChar).Value = maXuat;
            if (cmd.ExecuteScalar() != null)
                return true;
            return false;
        }
    }
}
