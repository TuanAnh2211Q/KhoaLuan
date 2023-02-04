using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAO
{
    public class ThongKe_DAO:DataProvider
    {
        public DataTable thongKeDoanhThu_DAO(string loaiThongKe,DateTime thoiGian)
        {
            SqlDataAdapter da = new SqlDataAdapter("select_ThongKeDoanhThu",conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@loaithongke", SqlDbType.VarChar).Value = loaiThongKe.Trim();
            da.SelectCommand.Parameters.Add("@thoigian", SqlDbType.DateTime).Value = thoiGian.ToString().Trim();
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataTable thongKeDoanhThu_MTG_DAO(DateTime tg1, DateTime tg2)
        {
            SqlDataAdapter da = new SqlDataAdapter("selectThongKeDoanhThuTheoMocThoiGian", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@tg1", SqlDbType.DateTime).Value = tg1.ToString().Trim();
            da.SelectCommand.Parameters.Add("@tg2", SqlDbType.DateTime).Value = tg2.ToString().Trim();
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataSet thongKeDoanhThu_TQ_DAO(int nam, string quy)
        {
            SqlDataAdapter da = new SqlDataAdapter("select_ThongKeDoanhThuTheoQuy", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nam", SqlDbType.Int).Value =nam;
            da.SelectCommand.Parameters.Add("@quyList", SqlDbType.VarChar).Value = quy.ToString(). Trim(); 
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;

        }

        public DataTable thongKeHangHoa_NTN_DAO(string loai, DateTime thoiGian)
        {
            SqlDataAdapter da = new SqlDataAdapter("select_HangHoa_NTN", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@loai", SqlDbType.VarChar).Value = loai.Trim();
            da.SelectCommand.Parameters.Add("@ngay", SqlDbType.DateTime).Value = thoiGian.ToString().Trim();
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataTable thongKeHangHoa_MTG_DAO(DateTime tg1, DateTime tg2)
        {
            SqlDataAdapter da = new SqlDataAdapter("select_HangHoa_MTG", conn);

            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@tg1", SqlDbType.DateTime).Value = tg1.ToString().Trim();
            da.SelectCommand.Parameters.Add("@tg2", SqlDbType.DateTime).Value = tg2.ToString().Trim();
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }


        public DataSet thongKeHangHoa_TQ(int nam, string quy)
        {
            SqlDataAdapter da = new SqlDataAdapter("select_HangHoa_TQ", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@nam", SqlDbType.Int).Value = nam;
            da.SelectCommand.Parameters.Add("@quyList", SqlDbType.VarChar).Value = quy.ToString().Trim();
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }

    }
}
