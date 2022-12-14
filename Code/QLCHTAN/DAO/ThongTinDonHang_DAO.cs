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
    public class ThongTinDonHang_DAO: DataProvider
    {
        public bool insert_ThongTinDonHang_DAO(ThongTinDonHang_DTO thongTinDonHang_DTO)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ThongTinDonHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDonHang",SqlDbType.VarChar).Value=thongTinDonHang_DTO.MaDonHang;
                cmd.Parameters.Add("@maSanPham", SqlDbType.VarChar).Value = thongTinDonHang_DTO.MaSanPham;
                cmd.Parameters.Add("@giaTien", SqlDbType.Money).Value = thongTinDonHang_DTO.GiaTien;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = thongTinDonHang_DTO.SoLuong;
                cmd.Parameters.Add("@thanhTien", SqlDbType.Money).Value = thongTinDonHang_DTO.ThanhTien;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch
            {
                throw;
            }
            return false;
        }

        public DataTable check_ThongTinDonHang_KhoBan_DAO(string masp,int sl)
        {

            Open();
            SqlDataAdapter da = new SqlDataAdapter("check_ThongTinDonHang_KhoBan", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maSanPham", SqlDbType.VarChar).Value = masp;
            da.SelectCommand.Parameters.Add("@soLuong", SqlDbType.Int).Value = sl;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
