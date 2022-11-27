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
    public class KhachHang_DAO: DataProvider
    {
        public DataTable show_dsKhachHang_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("dbo.select_KhachHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool update_KhachHang_DAO(KhachHang_DTO khachhang)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_KhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                //cmd.Parameters.Add("@SDT",sqlDbType.)
            }
            catch
            {

            }
            return false;
        }


    }
}
