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
    public class ThongTinKhuyenMai_DAO:DataProvider
    {
        public DataTable select_TTSP_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_TTSP", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataTable show_TTKM_DAO(string makm)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ThongTinKhuyenMai", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maKhuyenMai", SqlDbType.VarChar).Value = makm;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public bool insert_TTKM_DAO(ThongTinKhuyenMai_DTO ttkm)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_ThongTinKhuyenMai",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKM", SqlDbType.VarChar).Value = ttkm.MaKM;
                cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = ttkm.MaSP;
                if(ttkm.NgayBD!="null")
                {
                    cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = Convert.ToDateTime(ttkm.NgayBD);
                }
                else
                {
                    cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = DBNull.Value;
                }
                if(ttkm.NgayKT!="null")
                {
                    cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = Convert.ToDateTime(ttkm.NgayKT);
                }
                else
                {
                    cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = DBNull.Value;
                }
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = ttkm.GhiChu;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_TTKM_DAO(ThongTinKhuyenMai_DTO ttkm)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_ThongTinKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKM", SqlDbType.VarChar).Value = ttkm.MaKM;
                cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = ttkm.MaSP;
                if (ttkm.NgayBD != "null")
                {
                    cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = Convert.ToDateTime(ttkm.NgayBD);
                }
                else
                {
                    cmd.Parameters.Add("@ngayBD", SqlDbType.DateTime).Value = DBNull.Value;
                }
                if (ttkm.NgayKT != "null")
                {
                    cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = Convert.ToDateTime(ttkm.NgayKT);
                }
                else
                {
                    cmd.Parameters.Add("@ngayKT", SqlDbType.DateTime).Value = DBNull.Value;
                }
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = ttkm.GhiChu;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
        public bool delete_TTKM_DAO(ThongTinKhuyenMai_DTO ttkm)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_ThongTinKhuyenMai", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maKM", SqlDbType.VarChar).Value = ttkm.MaKM;
                cmd.Parameters.Add("@maSP", SqlDbType.VarChar).Value = ttkm.MaSP;
               
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
