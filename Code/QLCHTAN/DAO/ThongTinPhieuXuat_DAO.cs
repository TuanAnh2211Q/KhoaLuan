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
    public class ThongTinPhieuXuat_DAO:DataProvider
    {
        public bool insert_ThongTinXuatKho_DAO(ThongTinPhieuXuat_DTO thongTinXuatKho)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ThongTinXuatKho", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maXuat", SqlDbType.VarChar).Value = thongTinXuatKho.MaXuat;
                cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = thongTinXuatKho.MaHang;
                cmd.Parameters.Add("@soLuong", SqlDbType.Int).Value = thongTinXuatKho.SoLuong;
                cmd.Parameters.Add("@ghiChu", SqlDbType.VarChar).Value = thongTinXuatKho.GhiChu;
                cmd.Parameters.Add("@tongDonGia", SqlDbType.Decimal).Value =DBNull.Value;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool check_ThongTinXuatKho_DAO(String maXuat)
        {
            Open();
            SqlCommand cmd = new SqlCommand("check_ThongTinPhieuXuat", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maXuat", SqlDbType.VarChar).Value = maXuat;
            if (cmd.ExecuteScalar() != null)
                return true;
            return false;
        }

        public DataTable select_ThongTinPhieuXuat_DAO(string maxuat)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinPhieuXuat", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maXuat", SqlDbType.VarChar).Value = maxuat;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public int select_SoLuong_ThongTinXuatKho_DAO(String maXuat,string maHang)
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_SoLuong_ThongTinXuatKho", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maXuat", SqlDbType.VarChar).Value = maXuat;
            cmd.Parameters.Add("@maHang", SqlDbType.VarChar).Value = maHang;
            if (cmd.ExecuteScalar() != null)
                return Convert.ToInt32(cmd.ExecuteScalar());
            return 0;
        }


    }
}
