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
    public class KhuyenMai_DAO:DataProvider
    {
        public DataTable show_KM_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_KhuyenMai",conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insert_KM_DAO(KhuyenMai_DTO km)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_KM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKM", SqlDbType.VarChar).Value = km.MaKhuyenMai;
                cmd.Parameters.Add("@tenKM", SqlDbType.NVarChar).Value = km.TenKhuyenMai;
                cmd.Parameters.Add("@maLoaiKM", SqlDbType.VarChar).Value = km.MaLoaiKM;
                cmd.Parameters.Add("@mucGiam", SqlDbType.Float).Value = km.MucGiam;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_KM_DAO(KhuyenMai_DTO km)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_KM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKM", SqlDbType.VarChar).Value = km.MaKhuyenMai;
                cmd.Parameters.Add("@tenKM", SqlDbType.NVarChar).Value = km.TenKhuyenMai;
                cmd.Parameters.Add("@maLoaiKM", SqlDbType.VarChar).Value = km.MaLoaiKM;
                cmd.Parameters.Add("@mucGiam", SqlDbType.Float).Value = km.MucGiam;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_KM_DAO(KhuyenMai_DTO km)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_KM", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKM", SqlDbType.VarChar).Value = km.MaKhuyenMai;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public decimal select_MucKhuyenMai_DAO( string maKhuyenMai)
        {
            Open();   
            try{
                SqlCommand cmd = new SqlCommand("select_MucKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKhuyenMai", SqlDbType.VarChar).Value = maKhuyenMai;
                if (cmd.ExecuteScalar() != null)
                {
                    return Convert.ToDecimal(cmd.ExecuteScalar());
                }
                return 0;

            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }
    }
}
