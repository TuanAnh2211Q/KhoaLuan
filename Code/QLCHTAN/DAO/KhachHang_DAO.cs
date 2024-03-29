﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;

namespace DAO
{
    public class KhachHang_DAO: DataProvider
    {
        public DataTable show_dsKhachHang_DAO()
        {
            Open();
            SqlDataAdapter da = new SqlDataAdapter("select_KhachHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable Find_KhachHang_DAO(string sdt)
        {

            Open();
            SqlDataAdapter da = new SqlDataAdapter("find_KhachHang", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@SDT", SqlDbType.VarChar).Value = sdt;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool insert_KhachHang_DAO(KhachHang_DTO khachHang_DTO)
        {
            Open();
            try 
            {
                SqlCommand cmd = new SqlCommand("insert_thongTinKhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = khachHang_DTO.SDT.Trim();
                cmd.Parameters.Add("@tenKhachHang", SqlDbType.NVarChar).Value = khachHang_DTO.TenKhachHang.Trim();
                cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = khachHang_DTO.Phai.Trim();
                cmd.Parameters.Add("@diaChi", SqlDbType.NVarChar).Value = khachHang_DTO.DiaChi.Trim();
                cmd.Parameters.Add("@Email", SqlDbType.NVarChar).Value = khachHang_DTO.Email.Trim();
                cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = khachHang_DTO.GhiChu.Trim();
                if (khachHang_DTO.MaLoaiKhach == null)
                {
                    cmd.Parameters.Add("@maLoaiKhach", SqlDbType.NChar).Value = DBNull.Value;
                }
                else
                {
                    cmd.Parameters.Add("@maLoaiKhach", SqlDbType.NChar).Value = khachHang_DTO.MaLoaiKhach.Trim();
                }
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception)
            {
                throw;
            }
            return false;
        }
        public bool update_KhachHang_DAO(KhachHang_DTO khachhang_DTO)
        {
            
            try
            {
                Open();
                SqlCommand cmd1 = new SqlCommand("select_id_KhachHang", conn);
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.Parameters.Add("sdt", SqlDbType.VarChar).Value = khachhang_DTO.SDT.Trim();
                if(cmd1.ExecuteScalar()!=null)
                {
                    int id = Convert.ToInt32(cmd1.ExecuteScalar());

                    SqlCommand cmd = new SqlCommand("update_KhachHang", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = khachhang_DTO.SDT;
                    cmd.Parameters.Add("@tenKhachHang", SqlDbType.NVarChar).Value = khachhang_DTO.TenKhachHang;
                    cmd.Parameters.Add("@Phai", SqlDbType.NVarChar).Value = khachhang_DTO.Phai;
                    cmd.Parameters.Add("diaChi", SqlDbType.NVarChar).Value = khachhang_DTO.DiaChi;
                    cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = khachhang_DTO.Email;
                    cmd.Parameters.Add("@ghiChu", SqlDbType.NVarChar).Value = khachhang_DTO.GhiChu;
                    if(khachhang_DTO.MaLoaiKhach==null)
                    {
                        cmd.Parameters.Add("@maLoaiKhach", SqlDbType.NChar).Value = DBNull.Value;
                    }
                    else
                    {
                        cmd.Parameters.Add("@maLoaiKhach", SqlDbType.NChar).Value = khachhang_DTO.MaLoaiKhach.Trim();
                    }
                    cmd.Parameters.Add("idKhachHang", SqlDbType.Int).Value =id;
                    if (cmd.ExecuteNonQuery() > 0)
                        return true;
                }    

            }
            catch(Exception)
            {
                throw; 
            }
            return false;
        }
        public bool delete_KhachHang_DAO (KhachHang_DTO khachhang_DTO)
        {
            try 
            {
                Open();
                SqlCommand cmd = new SqlCommand("delete_KhachHang",conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@SDTKhachHang", SqlDbType.VarChar).Value = khachhang_DTO.SDT;
                if(cmd.ExecuteNonQuery()>0)
                     return true;
            }
            catch(Exception)
            {
                throw;
            }
            return false;
        }

        public int select_id_KhachHang_DAO(string sdt)
        {

            try
            {
                Open();
                SqlCommand cmd = new SqlCommand("select_id_KhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
                if (cmd.ExecuteScalar() != null)
                    return Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }

        public DataTable search_KhachHang_DAO(string timkiem)
        {

         
                Open();
                SqlDataAdapter da = new SqlDataAdapter("search_KhachHang", conn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.Add("@find", SqlDbType.NVarChar).Value = timkiem;
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
       
        }


        public DataTable select_LoaiKhach_DAO()
        {
            SqlDataAdapter da = new SqlDataAdapter("select_LoaiKhach", conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
