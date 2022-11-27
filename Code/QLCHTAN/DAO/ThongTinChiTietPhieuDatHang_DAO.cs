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
    public class ThongTinChiTietPhieuDatHang_DAO:DataProvider
    {
        public DataTable ds_SanPhamDatHang_DAO(string madat)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinDatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("maDatHang", SqlDbType.VarChar).Value =  madat;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public string tongGia_PhieuDat_DAO(string madat)
        {

            Open();
            SqlDataAdapter da = new SqlDataAdapter("tongGia_DatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = madat;
            string dc = (da.SelectCommand.ExecuteScalar()).ToString();
            return dc;
        }


        public bool insert_ThongTinDatHang(ThongTinChiTietPhieuDatHang_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ThongTinDatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = thongTin.MaDat;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTin.MaHang;
                cmd.Parameters.Add("@soLuongDat", SqlDbType.Int).Value = thongTin.SoLuongDat;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_ThongTinDatHang(ThongTinChiTietPhieuDatHang_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_ThongTinDatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = thongTin.MaDat;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTin.MaHang;
                cmd.Parameters.Add("@soLuongDat", SqlDbType.Int).Value = thongTin.SoLuongDat;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool delete_ThongTinDatHang(ThongTinChiTietPhieuDatHang_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_ThongTinDatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDatHang", SqlDbType.VarChar).Value = thongTin.MaDat;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTin.MaHang;
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
