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
    public class PhieuDatHang_DAO:DataProvider
    {
        public DataTable dsPhieuDat_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insert_PhieuDat_DAO(PhieuDatHang_DTO phieudat)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_DatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDH", SqlDbType.VarChar).Value = phieudat.MaDatHang.Trim();
                cmd.Parameters.Add("@ngayDat", SqlDbType.DateTime).Value = phieudat.NgayDatHang;
                cmd.Parameters.Add("@ngaydukiengiao", SqlDbType.DateTime).Value = phieudat.NgayDuKienGiao;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = phieudat.GhiChu;
                cmd.Parameters.Add("@phuongthucthanhtoan", SqlDbType.NVarChar).Value = phieudat.PhuongThucThanhToan;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool delete_PhieuDat_DAO(PhieuDatHang_DTO phieudat)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_DatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDH", SqlDbType.VarChar).Value = phieudat.MaDatHang.Trim();
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {
                return false;
            }
            return false;
        }
        
        public bool update_PhieuDat_DAO(PhieuDatHang_DTO phieudat)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_DatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDH", SqlDbType.VarChar).Value = phieudat.MaDatHang.Trim();
                cmd.Parameters.Add("@ngayDat", SqlDbType.DateTime).Value = phieudat.NgayDatHang;
                cmd.Parameters.Add("@ngaydukiengiao", SqlDbType.DateTime).Value = phieudat.NgayDuKienGiao;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = phieudat.GhiChu;
                cmd.Parameters.Add("@phuongthucthanhtoan", SqlDbType.NVarChar).Value = phieudat.PhuongThucThanhToan;
                cmd.Parameters.Add("@trangThai", SqlDbType.Bit).Value = phieudat.TrangThai;

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
