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
    public class DoiMatKhau_DAO:DataProvider
    {
        public bool updateMatKhau_DAO(DoiMatKhau_DTO doiMatKhau_DTO)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("doi_MatKhau_TaiKhoanNhanVien",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenTaiKhoan", SqlDbType.VarChar).Value = doiMatKhau_DTO.TenTaiKhoan;
                cmd.Parameters.Add("@matKhauCu", SqlDbType.VarChar).Value = doiMatKhau_DTO.MatKhauCu;
                cmd.Parameters.Add("@matKhauMoi", SqlDbType.VarChar).Value = doiMatKhau_DTO.MatKhauMoi;
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
