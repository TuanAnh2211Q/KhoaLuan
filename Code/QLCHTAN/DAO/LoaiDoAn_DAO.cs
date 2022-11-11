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

        public bool delete_LoaiDoAn_DAO(LoaiDoAn_DTO loaiDoAn_DTO)
        {

            try
            {
                Open();
                string kt = "select * from DoAn where maLoaiDoAn ='" + loaiDoAn_DTO.MaLoaiDoAn + "'";
                if (ExecuteScalar(kt) == null)
                {
                    string sql = "delete from LoaiDoAn where MaLoaiDoAn='"+loaiDoAn_DTO.MaLoaiDoAn+"'";
                    if (ExecuteNonQuery(sql) > 0)
                        return true;
                }
                else
                {
                    MessageBox.Show("Tồn tại đồ ăn thuộc loại này, không thể xóa");
                }    
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
               
                    string sql = "Update LoaiDoAn set TenLoaiDoAn=N'" + loaiDoAn_DTO.TenLoaiDoAn + "' where MaLoaiDoAn='" + loaiDoAn_DTO.MaLoaiDoAn + "'";
                    if (ExecuteNonQuery(sql) > 0)
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

