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
    public class PhieuTra_DAO:DataProvider
    {
        public DataTable show_PhieuTra_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_PhieuTra", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public bool insert_PhieuTra_DAO(PhieuTra_DTO phieutra)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_TraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = phieutra.MaTra.Trim();
                cmd.Parameters.Add("@ngayTra", SqlDbType.DateTime).Value = phieutra.NgayTra;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = phieutra.GhiChu;
                cmd.Parameters.Add("@maDat", SqlDbType.VarChar).Value = phieutra.MaDat.Trim();
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }


        public bool delete_PhieuTra_DAO(PhieuTra_DTO phieutra)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_TraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = phieutra.MaTra.Trim();
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }

        public object check_date_TraHang_DAO(PhieuTra_DTO phieutra)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("check_date_TraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = phieutra.MaDat.Trim();

                if (cmd.ExecuteScalar() != null)
                    return cmd.ExecuteScalar();

            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }
        public bool update_PhieuTra_DAO(PhieuTra_DTO phieutra)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_TraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = phieutra.MaTra.Trim();
                cmd.Parameters.Add("@ngayTra", SqlDbType.DateTime).Value = phieutra.NgayTra;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = phieutra.GhiChu;
                cmd.Parameters.Add("@maDat", SqlDbType.VarChar).Value = phieutra.MaDat.Trim();

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
