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
    public class PhieuNhapKho_DAO:DataProvider
    {
        public DataTable dsPhieuNhap_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_NhapKho", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable dsPhieuDat_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insert_PhieuNhap(PhieuNhapKho_DTO phieuNhapKho_DTO)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_PhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = phieuNhapKho_DTO.MaNhap;
                cmd.Parameters.Add("@ngayNhap", SqlDbType.VarChar).Value = phieuNhapKho_DTO.NgayNhap;
                cmd.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = phieuNhapKho_DTO.MaDatHang;
                cmd.Parameters.Add("@ghiChu", SqlDbType.VarChar).Value = phieuNhapKho_DTO.GhiChu;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_PhieuNhap(PhieuNhapKho_DTO phieuNhapKho_DTO)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_PhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = phieuNhapKho_DTO.MaNhap;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool update_PhieuNhap(PhieuNhapKho_DTO phieuNhapKho_DTO)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_PhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = phieuNhapKho_DTO.MaNhap;
                cmd.Parameters.Add("@ngayNhap", SqlDbType.VarChar).Value = phieuNhapKho_DTO.NgayNhap;
                cmd.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = phieuNhapKho_DTO.MaDatHang;
                cmd.Parameters.Add("@ghiChu", SqlDbType.VarChar).Value = phieuNhapKho_DTO.GhiChu;
                cmd.Parameters.Add("@trangThai", SqlDbType.Bit).Value = phieuNhapKho_DTO.TrangThai;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool check_PhieuNhap(string maphieu)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("check_PhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = maphieu;
                if (Convert.ToInt32(cmd.ExecuteScalar())==1)
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
