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
    public class LoaiKhuyenMai_BUS
    {
        LoaiKhuyenMai_DAO lkm = new LoaiKhuyenMai_DAO();
        public DataTable show_dsLoaiKM_BUS()
        {
            return lkm.show_dsLoaiKM_DAO();
        }
        public bool insert_LoaiKM_BUS(LoaiKhuyenMai_DTO lkmDTO)
        {
            return lkm.insert_LoaiKM_DAO(lkmDTO);
        }
        public bool delete_LoaiKM_BUS(LoaiKhuyenMai_DTO lkmDTO)
        {
            return lkm.delete_LoaiKM_DAO(lkmDTO);
        }
        public bool update_LoaiKM_BUS(LoaiKhuyenMai_DTO lkmDTO)
        {
            return lkm.update_LoaiKM_DAO(lkmDTO);
        }

    }
}
