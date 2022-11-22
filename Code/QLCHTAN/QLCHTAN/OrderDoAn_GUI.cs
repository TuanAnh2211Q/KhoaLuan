using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;
using DAO;

namespace QLCHTAN
{
    public partial class OrderDoAn_GUI : Form
    {
        OrderDoAn_BUS orderDoAn_BUS = new OrderDoAn_BUS();
        public OrderDoAn_GUI()
        {
            InitializeComponent();
        }
        #region Method
        public void loadMonAnChinh()
        {
            List<OrderDoAn_DTO> monChinhList = OrderDoAn_DAO.Instance.loadDanhSachMonAn_DAO();
            foreach( OrderDoAn_DTO item in monChinhList)
            {
                Button btn = new Button()
                {
                    Width = OrderDoAn_DTO.rong,
                    Height = OrderDoAn_DTO.dai
                };
                btn.Text = item.TenDoAn;
              flpDanhMucMonChinh.Controls.Add(btn);
              

            }
        }

        #endregion

        #region Event

        private void OrderDoAn_GUI_Load(object sender, EventArgs e)
        {
            loadMonAnChinh();
        }

        #endregion

    }
}
