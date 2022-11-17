using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DAO;
using DTO;
namespace BUS
{
    public class ThongTinChiTietPhieuNhap_BUS
    {
        ThongTinChiTietPhieuNhap_DAO thongTinChiTietPhieuNhap_DAO = new ThongTinChiTietPhieuNhap_DAO();
        public DataTable dsThongTinChiTietPhieuNhap(ThongTinChiTIetPhieuNhap_DTO thongTinChiTIetPhieuNhap_DTO)
        {
            return thongTinChiTietPhieuNhap_DAO.dsThongTinPhieuNhap(thongTinChiTIetPhieuNhap_DTO);
        }
    }
}
