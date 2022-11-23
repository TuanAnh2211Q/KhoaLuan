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
    public class OrderDoAn_DAO:DataProvider
    {
        private static OrderDoAn_DAO instance;

        public static OrderDoAn_DAO Instance 
        {
            get 
            {
                if (instance == null)
                    instance = new OrderDoAn_DAO();
                return OrderDoAn_DAO.instance;
            }
            private set => OrderDoAn_DAO.instance = value; 
        }
        private OrderDoAn_DAO()
        { }

        public List<OrderDoAn_DTO> loadDanhSachMonAnChinh_DAO()
        {
            Open();
            List<OrderDoAn_DTO> monChinhList = new List<OrderDoAn_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.Load_MonAnChin");
            foreach (DataRow item in data.Rows)
            {
                OrderDoAn_DTO monAn = new OrderDoAn_DTO(item);
                monChinhList.Add(monAn);
            }
            return monChinhList;
        }
        public List<OrderDoAn_DTO> loadDanhSachMonAnPhu_DAO()
        {
            Open();
            List<OrderDoAn_DTO> monChinhList = new List<OrderDoAn_DTO>();
            DataTable data = DataProvider.Instance.ExecuteQuery("dbo.Load_MonAnPhu");
            foreach (DataRow item in data.Rows)
            {
                OrderDoAn_DTO monAn = new OrderDoAn_DTO(item);
                monChinhList.Add(monAn);
            }
            return monChinhList;
        }

    }
}
