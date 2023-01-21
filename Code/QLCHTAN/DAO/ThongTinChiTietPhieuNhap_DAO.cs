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
    public class ThongTinChiTietPhieuNhap_DAO:DataProvider
    {
        public DataTable dsThongTinPhieuNhap(string manhap)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinNhapKho", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = manhap;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public int select_TongGiaNhap_DAO(string manhap)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_TongGiaNhap", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = manhap;
            object c = cmd.ExecuteScalar();
            if (ReferenceEquals(c,null))
                return Convert.ToInt32(cmd.ExecuteScalar());
            else
            return 0;
        }
        public DataTable select_to_PhieuNhap_Temp(string madat, string matra)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_to_PhieuNhapTemp", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maDat", SqlDbType.VarChar).Value = madat;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool insert_ThongTinPhieuNhap_DAO(ThongTinChiTietPhieuNhap_DTO thongtin)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ThongTinPhieuNhap", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhap", SqlDbType.VarChar).Value = thongtin.MaNhap;
                cmd.Parameters.Add("@maNCC", SqlDbType.VarChar).Value = thongtin.MaNCC;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongtin.MaHang;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = thongtin.SoLuongNhap;
                cmd.Parameters.Add("@tongDonGia", SqlDbType.Money).Value = thongtin.TongDonGia;
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
