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
    public class NuocUong_DAO:DataProvider
    {
        public DataTable show_dsNuocUong_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_NuocUong", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool insert_NuocUong_DAO(NuocUong_DTO NuocUong_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("insert_to_NuocUong", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@maNuocUong", SqlDbType.NChar).Value = NuocUong_DTO.MaNuoc;
                da.SelectCommand.Parameters.Add("@tenNuocUong", SqlDbType.NVarChar).Value = NuocUong_DTO.TenNuoc;
                da.SelectCommand.Parameters.Add("@donViBan", SqlDbType.NVarChar).Value = NuocUong_DTO.DonViBan;
                da.SelectCommand.Parameters.Add("@donGia", SqlDbType.Money).Value = NuocUong_DTO.DonGia;
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_NuocUong_DAO(NuocUong_DTO NuocUong_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("delete_to_NuocUong", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@maNuocUong", SqlDbType.NChar).Value = NuocUong_DTO.MaNuoc;
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_NuocUong_DAO(NuocUong_DTO NuocUong_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("update_to_NuocUong", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@maNuocUong", SqlDbType.NChar).Value = NuocUong_DTO.MaNuoc;
                da.SelectCommand.Parameters.Add("@tenNuocUong", SqlDbType.NVarChar).Value = NuocUong_DTO.TenNuoc;
                da.SelectCommand.Parameters.Add("@donViBan", SqlDbType.NVarChar).Value = NuocUong_DTO.DonViBan;
                da.SelectCommand.Parameters.Add("@donGia", SqlDbType.Money).Value = NuocUong_DTO.DonGia;
                if (da.SelectCommand.ExecuteNonQuery() > 0)
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
