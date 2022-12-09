using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;
using DAO;
namespace BUS
{
    public class MatHang_BUS
    {
        MatHang_DAO mathang = new MatHang_DAO();

        public DataTable show_dsNCC_MatHang_BUS()
        {
            return mathang.show_dsNCC_MatHang_DAO();
        }
        public DataTable show_dsMatHang_Nuoc_BUS()
        {
            return mathang.show_dsMatHang_Nuoc_DA0();
        }
        public DataTable show_dsMatHang_BUS()
        {
            return mathang.show_dsMatHang_DA0();
        }
        public bool insert_MatHang_BUS(MatHang_DTO mathangDTO)
        {
            return mathang.insert_MatHang_DAO(mathangDTO);
        }

        public bool update_MatHang_BUS(MatHang_DTO mathangDTO)
        {
            return mathang.update_MatHang_DAO(mathangDTO);
        }

        public bool delete_MatHang_BUS(MatHang_DTO mathangDTO)
        {
            return mathang.delete_MatHang_DAO(mathangDTO);
        }

        public bool check_MatHangTrongDoAn_BUS(MatHang_DTO mathangDTO)
        {
            return mathang.check_MatHangTrongDoAn_DAO(mathangDTO);
        }
        public string select_MatHang_NCC(string maHang)
        {
            return mathang.select_MatHang_NCC(maHang);
        }

        public decimal select_DonGia_MatHang(string maHang)
        {
            return mathang.select_DonGia_MatHang(maHang);
        }
    }
}
