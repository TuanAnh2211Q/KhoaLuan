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
   public class DangNhap_DAO:DataProvider
    {
        public bool dangNhapHeThong_DAO(DangNhap_DTO dangNhap_DTO)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("DangNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@tenTaiKhoan", SqlDbType.VarChar).Value = dangNhap_DTO.TenDangNhap;
                cmd.Parameters.Add("@matKhau", SqlDbType.VarChar).Value = dangNhap_DTO.MatKhau;
                if(cmd.ExecuteNonQuery()<0)
                {
                    return true;
                }
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public int kiemTraQuyenHeThong_DAO(DangNhap_DTO dangNhap_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("check_Quyen_DangNhap", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@tenTaiKhoan", SqlDbType.VarChar).Value = dangNhap_DTO.TenDangNhap;
                var quyen = da.SelectCommand.ExecuteScalar();
                if (da.SelectCommand.ExecuteScalar()!=null )
                {
                    if (quyen.ToString().Trim() == "MQ001" || quyen.ToString().Trim() == "Admin")
                    {
                        return 1;
                    }
                    else return 0;
      
                }
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
    }
}
