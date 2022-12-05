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
    public class ThongTinPhieuTra_DAO:DataProvider
    {
        public DataTable ds_SanPhamTra_DAO(string matra)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinPhieuTra", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maTra", SqlDbType.VarChar).Value = matra;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public string select_SoLuongDat_DAO(string madat, string mahang)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_SoLuongDat", conn);
           cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDat", SqlDbType.VarChar).Value = madat;
            cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = mahang;
            if (cmd.ExecuteScalar() != null)
                return cmd.ExecuteScalar().ToString();
            return null;
        }
        public string tongGia_PhieuTra_DAO(string matra)
        {

            Open();
            SqlDataAdapter da = new SqlDataAdapter("tongGia_TraHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maTra", SqlDbType.VarChar).Value = matra;
            string dc = (da.SelectCommand.ExecuteScalar()).ToString();
            return dc;
        }

        public int soLuong_hangTra(ThongTinPhieuTra_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("soLuong_TraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = thongTin.MaTra;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTin.MaHang;
                if (cmd.ExecuteScalar() != null)
                    return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {

                throw;
            }
            return 0;
        }

        public bool insert_ThongTinPhieuTra(ThongTinPhieuTra_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ThongTinTraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = thongTin.MaTra;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTin.MaHang;
                cmd.Parameters.Add("@soLuongTra", SqlDbType.Int).Value = thongTin.SoLuong;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_ThongTinTraHang(ThongTinPhieuTra_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_ThongTinTraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = thongTin.MaTra;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTin.MaHang;
                cmd.Parameters.Add("@soLuongTra", SqlDbType.Int).Value = thongTin.SoLuong;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool delete_ThongTinTraHang(ThongTinPhieuTra_DTO thongTin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_ThongTinTraHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maTra", SqlDbType.VarChar).Value = thongTin.MaTra;
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
