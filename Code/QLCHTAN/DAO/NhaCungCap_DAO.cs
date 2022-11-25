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
    public class NhaCungCap_DAO:DataProvider
    {
        public DataTable show_dsNCC()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_NCC", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insert_NCC_DAO(NhaCungCap_DTO ncc)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_to_NCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = ncc.MaNCC;
                cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
                cmd.Parameters.Add("@diachiNCC", SqlDbType.NVarChar).Value = ncc.DiaChiNCC;
                cmd.Parameters.Add("@emailNCC", SqlDbType.VarChar).Value = ncc.EmailNCC;
                cmd.Parameters.Add("@sdtNCC", SqlDbType.VarChar).Value = ncc.SdtNCC;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = ncc.GhiChu;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_NCC_DAO(NhaCungCap_DTO ncc)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_to_NCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = ncc.MaNCC;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_NCC_DAO(NhaCungCap_DTO ncc)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_to_NCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = ncc.MaNCC;
                cmd.Parameters.Add("@tenNCC", SqlDbType.NVarChar).Value = ncc.TenNCC;
                cmd.Parameters.Add("@diachiNCC", SqlDbType.NVarChar).Value = ncc.DiaChiNCC;
                cmd.Parameters.Add("@emailNCC", SqlDbType.VarChar).Value = ncc.EmailNCC;
                cmd.Parameters.Add("@sdtNCC", SqlDbType.VarChar).Value = ncc.SdtNCC;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = ncc.GhiChu;
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
