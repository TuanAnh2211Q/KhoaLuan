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
                if(NuocUong_DTO.HinhURL!=null)
                    da.SelectCommand.Parameters.Add("@anh", SqlDbType.VarBinary).Value = NuocUong_DTO.HinhURL;
                else
                    da.SelectCommand.Parameters.Add("@anh", SqlDbType.VarBinary).Value = DBNull.Value;

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
                if (NuocUong_DTO.HinhURL != null)
                    da.SelectCommand.Parameters.Add("@anh", SqlDbType.VarBinary).Value = NuocUong_DTO.HinhURL;
                else
                    da.SelectCommand.Parameters.Add("@anh", SqlDbType.VarBinary).Value = DBNull.Value;
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public DataTable show_dsLoaiNuocUong_DAO( string maNuoc)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_dsNuocUong",conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maNuoc", SqlDbType.VarChar).Value = maNuoc;
            DataTable dsnu = new DataTable();
            da.Fill(dsnu);
            return dsnu;
        }
        public string select_DonViBanNuocUong(string maNuoc)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_DonViBanNuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maNuoc", SqlDbType.VarChar).Value = maNuoc;
            if (cmd.ExecuteScalar() != null)
                return cmd.ExecuteScalar().ToString();
            return null;
        }
        public DataTable select_thongTin_MatHangNuoc(string maNuoc)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_thongTin_MatHangNuoc", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maHang", SqlDbType.VarChar).Value = maNuoc;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public decimal select_donGiaNuoc_DAO(string maSanPham,string donViBan)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_donGia_SanPham", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maSanPham", SqlDbType.VarChar).Value = maSanPham;
            cmd.Parameters.Add("@donViBan", SqlDbType.NVarChar).Value = donViBan;
            if (cmd.ExecuteScalar() != null)
            {
                return Convert.ToDecimal(cmd.ExecuteScalar());
            }
            return 0;
        }
        public string select_maSanPhamNuoc_DAO(string maNuoc)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_SanPham_Nuoc", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maNuoc", SqlDbType.VarChar).Value = maNuoc;
            if (cmd.ExecuteScalar() != null)
            {
                return Convert.ToString(cmd.ExecuteScalar());
            }
            return null;
        }
    }
}
