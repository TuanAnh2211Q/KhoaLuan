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
    public partial class OrderNuoc_GUI : Form
    {
        public OrderNuoc_GUI()
        {
            InitializeComponent();
        }
        #region method
        public void loadTenNuoc()
        {
            List<OrderNuoc_DTO> tenNuocList = OrderNuoc_DAO.Instance.loadDanhSachNuoc_DAO();
            foreach(OrderNuoc_DTO item in tenNuocList)
            {
                Button btn = new Button()
                {
                    Width = OrderNuoc_DTO.rong,
                    Height = OrderNuoc_DTO.dai
                };
                btn.Text = item.TenNuoc + Environment.NewLine + item.DonViBan + Environment.NewLine + item.GiaBan;
                btn.BackColor = Color.LightGreen;
                flpDanhMucNuoc.Controls.Add(btn);
            }    
        }

        #endregion

        #region Event
        private void OrderNuoc_GUI_Load(object sender, EventArgs e)
        {
            loadTenNuoc();
 
        }
        #endregion


    }
}
