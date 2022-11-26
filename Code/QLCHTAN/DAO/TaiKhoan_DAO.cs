using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using DTO;
namespace DAO
{
     public class TaiKhoan_DAO:DataProvider
    {
        public DataTable show_TTTK_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_TKNV", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool ganQuyen_DAO(TaiKhoan_DTO taikhoan)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_QuyenTKNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = taikhoan.Id;
                cmd.Parameters.Add("@maQuyen", SqlDbType.VarChar).Value = taikhoan.MaQuyen;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool rs_MatKhau_DAO(TaiKhoan_DTO taikhoan)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("rs_mkTKNV", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@id", SqlDbType.Int).Value = taikhoan.Id;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }
}
