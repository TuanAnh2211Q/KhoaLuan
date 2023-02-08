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
    public class MatHang_DAO:DataProvider
    {
        public DataTable select_matHang_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_MatHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable show_dsMatHang_DA0()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_MatHang_DoAn", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable show_dsMatHang_Nuoc_DA0()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_MatHang_Nuoc", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable show_dsNCC_MatHang_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_NCC", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            dt.Rows.Add("tenNCC", "null");
            return dt;
        }

        public bool insert_MatHang_DAO(MatHang_DTO mathang)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_MatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = mathang.MaHang;
                cmd.Parameters.Add("@tenHang", SqlDbType.NVarChar).Value = mathang.TenHang;
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = mathang.MaNCC;
                cmd.Parameters.Add("@donVi", SqlDbType.NVarChar).Value = mathang.DonVi;
                cmd.Parameters.Add("@NSX", SqlDbType.Date).Value =  mathang.NSX;
                cmd.Parameters.Add("@HSD", SqlDbType.Date).Value = mathang.HSD;
                cmd.Parameters.Add("@donGia", SqlDbType.Money).Value = mathang.DonGia;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = mathang.GhiChu;
                cmd.Parameters.Add("@loaiHang", SqlDbType.Bit).Value = mathang.LoaiHang;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_MatHang_DAO(MatHang_DTO mathang)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_MatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = mathang.MaHang;
                cmd.Parameters.Add("@tenHang", SqlDbType.NVarChar).Value = mathang.TenHang;
                    if(mathang.MaNCC=="null")
                {
                    cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = DBNull.Value;
                }
                    else
                {
                    cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = mathang.MaNCC;
                }
                cmd.Parameters.Add("@donVi", SqlDbType.NVarChar).Value = mathang.DonVi;
                cmd.Parameters.Add("@NSX", SqlDbType.Date).Value = mathang.NSX;
                cmd.Parameters.Add("@HSD", SqlDbType.Date).Value = mathang.HSD;
                cmd.Parameters.Add("@donGia", SqlDbType.Money).Value = mathang.DonGia;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = mathang.GhiChu;
                cmd.Parameters.Add("@loaiHang", SqlDbType.Bit).Value = mathang.LoaiHang;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool delete_MatHang_DAO(MatHang_DTO mathang)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_MatHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = mathang.MaHang;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool check_MatHangTrongDoAn_DAO(MatHang_DTO mathang)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("check_MatHang_ThanhPhan", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = mathang.MaHang;
                if (cmd.ExecuteScalar()!=null)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }


        public string select_MatHang_NCC(string maHang)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_MatHang_NCC", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = maHang;
            if (cmd.ExecuteScalar() != null)
                return cmd.ExecuteScalar().ToString();
            return null;
        }

        public decimal select_DonGia_MatHang(string maHang)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_DonGia_MatHang", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = maHang;
            if (cmd.ExecuteScalar() != null)
                return Convert.ToDecimal( cmd.ExecuteScalar());
            return 0;
        }    

    }
}
