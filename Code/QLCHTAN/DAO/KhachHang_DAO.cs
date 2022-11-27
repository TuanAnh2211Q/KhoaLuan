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

        public bool update_KhachHang_DAO(KhachHang_DTO khachhang_DTO)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("update_KhachHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("idKhachHang", SqlDbType.VarChar).Value = khachhang_DTO.IdKhachHang;
                cmd.Parameters.Add("@SDT", SqlDbType.VarChar).Value = khachhang_DTO.SDT;
                cmd.Parameters.Add("@tenKhachHang", SqlDbType.VarChar).Value = khachhang_DTO.TenKhachHang;
                cmd.Parameters.Add("@Phai", SqlDbType.VarChar).Value = khachhang_DTO.Phai;
                cmd.Parameters.Add("@diaChi", SqlDbType.VarChar).Value = khachhang_DTO.DiaChi;
                cmd.Parameters.Add("@email", SqlDbType.VarChar).Value = khachhang_DTO.Email;
                cmd.Parameters.Add("@ghiChu", SqlDbType.VarChar).Value = khachhang_DTO.GhiChu;
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception)
            {
                throw;
            }
            return false;
        }


    }
}