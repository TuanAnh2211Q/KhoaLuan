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
    public class DoiMatKhau_BUS
    {
        DoiMatKhau_DAO doiMatKhau_DAO = new DoiMatKhau_DAO();

        public bool updateDoiMatKhau_BUS(DoiMatKhau_DTO doiMatKhau_DTO)
        {
            return doiMatKhau_DAO.updateMatKhau_DAO(doiMatKhau_DTO);
        }
    }
}
