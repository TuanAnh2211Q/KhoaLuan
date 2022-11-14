using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using System.Windows.Forms;

namespace DAO
{
    public class LoaiDoAn_DAO:DataProvider
    {
        public DataTable dsLoaiDoAn_DAO()
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_LoaiDoAn", conn)
            {
                CommandType = CommandType.StoredProcedure
            };
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dslda = new DataTable();
            da.Fill(dslda);
            return dslda;
        }

        public bool insert_LoaiDoAn_DAO(LoaiDoAn_DTO loaiDoAn_DTO)
        {
            try
            {
                Open();
                SqlCommand kt = new SqlCommand()
                {
                    CommandText = "chect_exist_LoaiDoAn",
                    Connection = conn,
                    CommandType = CommandType.StoredProcedure
                };

                kt.Parameters.Add("@maLoaiDoAn", SqlDbType.VarChar).Value = loaiDoAn_DTO.MaLoaiDoAn;
                if(kt.ExecuteScalar()==null)
                {
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "insert_LoaiDoAn",
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@maLoaiDoAn", SqlDbType.VarChar).Value = loaiDoAn_DTO.MaLoaiDoAn;
                    cmd.Parameters.Add("@tenLoaiDoAN", SqlDbType.NVarChar).Value = loaiDoAn_DTO.TenLoaiDoAn;
                    if(cmd.ExecuteNonQuery()>0)
                    return true;
                }    
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool delete_LoaiDoAn_DAO(LoaiDoAn_DTO loaiDoAn_DTO)
        {

            try
            {
                Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "delete_LoaiDoAn",
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@maLoaiDoAn", SqlDbType.VarChar).Value = loaiDoAn_DTO.MaLoaiDoAn;
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_LoaiDoAn_DAO(LoaiDoAn_DTO loaiDoAn_DTO)
        {

            try
            {
                Open();
                    SqlCommand cmd = new SqlCommand()
                    {
                        CommandText = "update_LoaiDoAn",
                        Connection = conn,
                        CommandType = CommandType.StoredProcedure
                    };
                    cmd.Parameters.Add("@maLoaiDoAn", SqlDbType.VarChar).Value = loaiDoAn_DTO.MaLoaiDoAn;
                    cmd.Parameters.Add("@tenLoaiDoAN", SqlDbType.NVarChar).Value = loaiDoAn_DTO.TenLoaiDoAn;
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

