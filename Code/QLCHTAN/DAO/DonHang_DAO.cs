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
    public class DonHang_DAO: DataProvider
    {
        public bool insert_DonHang_DAO(DonHang_DTO donHang_DTO)
        {
            Open();
            try
            {
                SqlCommand cmd = new SqlCommand("insert_DonHang", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = donHang_DTO.MaDonHang;
                cmd.Parameters.Add("@tenDonHang", SqlDbType.NVarChar).Value = donHang_DTO.TenDonHang;
                cmd.Parameters.Add("@maLoaiDon", SqlDbType.VarChar).Value = donHang_DTO.MaLoaiDonHang ;
                cmd.Parameters.Add("@maHinhThuc", SqlDbType.Bit).Value = donHang_DTO.MaHinhThucThanhToan;
                cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = donHang_DTO.MaNhanVien;
                cmd.Parameters.Add("@SDTKhachHang", SqlDbType.VarChar).Value = donHang_DTO.SDTKhachHang;
                cmd.Parameters.Add("@maKhuyenMai", SqlDbType.VarChar).Value = donHang_DTO.MaKhuyenMai;
                cmd.Parameters.Add("@thoiGianDat", SqlDbType.DateTime).Value = donHang_DTO.ThoiGianDat;
                cmd.Parameters.Add("@trangThai", SqlDbType.Int).Value = donHang_DTO.TrangThai;
                cmd.Parameters.Add("@ghiChu", SqlDbType.VarChar).Value = donHang_DTO.MaNhanVien;
                cmd.Parameters.Add("@maNhanVien", SqlDbType.VarChar).Value = donHang_DTO.MaNhanVien;
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
