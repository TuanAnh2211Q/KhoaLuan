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
    public class ThongTinThanhPhanDoAn_DAO:DataProvider
    {
        public DataTable show_thanhPhanDoAn_DAO(string maMonAn)
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_DoAn_ThanhPhanDoAn", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = maMonAn;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable show_dsthanhPhanDoAn_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_MatHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insert_ThanhPhanDoAn_DAO(ThongTinThanhPhanDoAn_DTO tttpda)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_DoAn_ThanhPhanDoAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maThanhPhan", SqlDbType.NChar).Value = tttpda.MaThanhPhan;
                cmd.Parameters.Add("@tenThanhPhan", SqlDbType.NVarChar).Value = tttpda.TenThanhPhan;
                cmd.Parameters.Add("@dinhLuong", SqlDbType.NVarChar).Value = tttpda.DinhLuong;
                cmd.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = tttpda.MaDoAn;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;

            }
            catch (Exception)
            {

                throw;
            }
            return false;

        }
        public bool update_ThanhPhanDoAn_DAO(ThongTinThanhPhanDoAn_DTO tttpda)
        {
                Open();
                try
                {
                    SqlCommand cmd = new SqlCommand("update_DoAn_ThanhPhanDoAn", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maThanhPhan", SqlDbType.NChar).Value = tttpda.MaThanhPhan;
                    cmd.Parameters.Add("@dinhLuong", SqlDbType.NVarChar).Value = tttpda.DinhLuong;
                    cmd.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = tttpda.MaDoAn;
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;

                }
                catch (Exception)
                {

                    throw;
                }
                return false;
        }

        public bool delete_ThanhPhanDoAn_DAO(ThongTinThanhPhanDoAn_DTO tttpda)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("delete_DoAn_ThanhPhanDoAn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maThanhPhan", SqlDbType.NChar).Value = tttpda.MaThanhPhan;
                cmd.Parameters.Add("@maDoAn", SqlDbType.NChar).Value = tttpda.MaDoAn;
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
