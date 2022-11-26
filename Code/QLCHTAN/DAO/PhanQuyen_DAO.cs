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
    public class PhanQuyen_DAO:DataProvider
    {
        public DataTable dsQuyen_DAO()
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_PhanQuyen", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }
        public bool update_Quyen_DAO(PhanQuyen_DTO phanQuyen)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_Quyen", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maQuyen", SqlDbType.VarChar).Value = phanQuyen.MaQuyen;
                cmd.Parameters.Add("@tenQuyen", SqlDbType.NVarChar).Value = phanQuyen.TenQuyen;
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = phanQuyen.GhiChu;
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
