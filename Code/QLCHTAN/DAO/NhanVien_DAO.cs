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
    public class NhanVien_DAO:DataProvider
    {
        public DataTable show_list_LoaiNhanVien_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_LoaiNhanVien",conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable ();
            da.Fill(tb);
            return tb;
        }

        public DataTable show_list_ChucDanh_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_ChucDanh",conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public DataTable show_list_NhanVien_DAO()
        {
            Open();
            SqlCommand cmd = new SqlCommand("select_NhanVien", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public bool insert_NhanVien_DAO(NhanVien_DTO nhanVien_DTO)
        {
            try
            {
                Open();
                SqlCommand kt = new SqlCommand("check_exist_NhanVien", conn);
                kt.CommandType = CommandType.StoredProcedure;
                kt.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = nhanVien_DTO.MaNhanVien;
                if (kt.ExecuteScalar()==null)
                {
                    SqlCommand cmd = new SqlCommand("insert_NhanVien", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = nhanVien_DTO.MaNhanVien;
                    cmd.Parameters.Add("@tenNhanVien", SqlDbType.NVarChar).Value = nhanVien_DTO.TenNhanVien;
                    cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = nhanVien_DTO.Phai;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nhanVien_DTO.SDT;
                    cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanVien_DTO.Email;
                    cmd.Parameters.Add("@diaChi", SqlDbType.VarChar).Value = nhanVien_DTO.DiaChi;
                    cmd.Parameters.Add("@maChucDanh", SqlDbType.VarChar).Value = nhanVien_DTO.MaChucDanh;
                    cmd.Parameters.Add("@maLoaiNhanVien", SqlDbType.VarChar).Value = nhanVien_DTO.MaLoaiNhanVien;
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }    
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool delete_NhanVien_DAO(NhanVien_DTO nhanVien_DTO)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("delete_NhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = nhanVien_DTO.MaNhanVien;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public bool update_NhanVien_DAO(NhanVien_DTO nhanVien_DTO)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("update_NhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = nhanVien_DTO.MaNhanVien;
                cmd.Parameters.Add("@tenNhanVien", SqlDbType.NVarChar).Value = nhanVien_DTO.TenNhanVien;
                cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = nhanVien_DTO.Phai;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = nhanVien_DTO.SDT;
                cmd.Parameters.Add("@Email", SqlDbType.VarChar).Value = nhanVien_DTO.Email;
                cmd.Parameters.Add("@diaChi", SqlDbType.VarChar).Value = nhanVien_DTO.DiaChi;
                cmd.Parameters.Add("@maChucDanh", SqlDbType.VarChar).Value = nhanVien_DTO.MaChucDanh;
                cmd.Parameters.Add("@maLoaiNhanVien", SqlDbType.VarChar).Value = nhanVien_DTO.MaLoaiNhanVien;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
                
            }
            catch (Exception)
            {

                throw;
            }
            return false;
        }

        public string select_TenNhanVien_DAO(string manv)
        {
            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("select_TenNhanVien", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = manv;
                if (cmd.ExecuteScalar()!=null)
                    return cmd.ExecuteScalar().ToString();

            }
            catch (Exception)
            {

                throw;
            }
            return null;
        }


    }
}
