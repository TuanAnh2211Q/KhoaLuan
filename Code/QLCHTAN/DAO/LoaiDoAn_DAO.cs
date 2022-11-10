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
    public class LoaiDoAn_DAO:DataProvider
    {
        public DataTable dsLoaiDoAn_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("Select * from LoaiDoAn",conn);
            DataTable dslda = new DataTable();
            da.Fill(dslda);
            return dslda;
        }

        public bool insert_LoaiDoAn_DAO(LoaiDoAn_DTO loaiDoAn_DTO)
        {
            try
            {
                Open();
                string kt = "select * from LoaiDoAn where maLoaiDoAn ='" + loaiDoAn_DTO.MaLoaiDoAn + "'";
                if(ExecuteScalar(kt)==null)
                {
                    string sql = "Insert into LoaiDoAn values ('" + loaiDoAn_DTO.MaLoaiDoAn + "',N'" + loaiDoAn_DTO.TenLoaiDoAn + "')";
                    if (ExecuteNonQuery(sql) > 0)
                        return true;
                }    
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }
    }
}

