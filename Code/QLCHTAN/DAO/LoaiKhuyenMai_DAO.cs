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
    public class LoaiKhuyenMai_DAO:DataProvider
    {

        public DataTable show_dsLoaiKM_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_LoaiKM", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insert_LoaiKM_DAO(LoaiKhuyenMai_DTO lkm)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_LoaiKM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maLoai", SqlDbType.VarChar).Value = lkm.MaLoaiKhuyenMai;
                cmd.Parameters.Add("@tenLoai", SqlDbType.NVarChar).Value = lkm.TenLoaiKhuyenMai;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_LoaiKM_DAO(LoaiKhuyenMai_DTO lkm)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_LoaiKM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maLoai", SqlDbType.VarChar).Value = lkm.MaLoaiKhuyenMai;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool update_LoaiKM_DAO(LoaiKhuyenMai_DTO lkm)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_LoaiKM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maLoai", SqlDbType.VarChar).Value = lkm.MaLoaiKhuyenMai;
                cmd.Parameters.Add("@tenLoai", SqlDbType.NVarChar).Value = lkm.TenLoaiKhuyenMai;
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
