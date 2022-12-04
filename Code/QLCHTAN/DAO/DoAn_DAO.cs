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
    public class DoAn_DAO:DataProvider
    {
        public DataTable show_ds_DoAn_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("show_dsDoAn", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable show_ds_LoaiDoAn_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_LoaiDoAn",conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dslda = new DataTable();
            da.Fill(dslda);
            return dslda;
        }
        public DataTable show_dsMon_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DoAnTheoYeuCau",conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dsMon = new DataTable();
            da.Fill(dsMon);
            return dsMon;
        }
        public DataTable show_dsLoaiDoAn_DAO( string maLoaiDoAn)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_dsDoAnTheoLoai", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maLoaiDoAn", SqlDbType.NChar).Value = maLoaiDoAn;
            DataTable dslda = new DataTable();
            da.Fill(dslda);
            return dslda;
        }
        public bool insert_DoAn_DAO(DoAn_DTO doAn_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("insert_DoAn_ThongTinDoAn", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = doAn_DTO.MaDoAn;
                da.SelectCommand.Parameters.Add("@maLoaiDoAn", SqlDbType.NChar).Value = doAn_DTO.MaLoaiDoAn;
                da.SelectCommand.Parameters.Add("@tenDoAn", SqlDbType.NVarChar).Value = doAn_DTO.TenDoAn;
                da.SelectCommand.Parameters.Add("@donViBan", SqlDbType.NVarChar).Value = doAn_DTO.DonViBan;
                da.SelectCommand.Parameters.Add("@donGia", SqlDbType.Money).Value = doAn_DTO.DonGia;
                da.SelectCommand.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = doAn_DTO.GhiChu;
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_DoAn_DAO(DoAn_DTO doAn_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("delete_DoAn_ThongTinDoAn", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = doAn_DTO.MaDoAn;
                if (da.SelectCommand.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_DoAn_DAO(DoAn_DTO doAn_DTO)
        {
            try
            {
                Open();
                SqlDataAdapter da = new SqlDataAdapter("update_DoAn_ThongTinDoAn", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = doAn_DTO.MaDoAn;
                da.SelectCommand.Parameters.Add("@maLoaiDoAn", SqlDbType.NChar).Value = doAn_DTO.MaLoaiDoAn;
                da.SelectCommand.Parameters.Add("@tenDoAn", SqlDbType.NVarChar).Value = doAn_DTO.TenDoAn;
                da.SelectCommand.Parameters.Add("@donViBan", SqlDbType.NVarChar).Value = doAn_DTO.DonViBan;
                da.SelectCommand.Parameters.Add("@donGia", SqlDbType.Money).Value = doAn_DTO.DonGia;
                da.SelectCommand.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = doAn_DTO.GhiChu;
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
