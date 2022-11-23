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
    public class OrderNuoc_DAO:DataProvider
    {
        private static OrderNuoc_DAO instance;
        public static OrderNuoc_DAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new OrderNuoc_DAO();
                return OrderNuoc_DAO.instance;
            }
            private set => OrderNuoc_DAO.instance = value;
        }
        private OrderNuoc_DAO()
        { }
        public List<OrderNuoc_DTO>loadDanhSachNuoc_DAO()
        {
            Open();
            List<OrderNuoc_DTO> tenNuocList = new List<OrderNuoc_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.Load_NuocUong");
            foreach(DataRow item in data.Rows)
            {
                OrderNuoc_DTO tenNuoc = new OrderNuoc_DTO(item);
                tenNuocList.Add(tenNuoc);
            }
            return tenNuocList;
        }

    }
}
