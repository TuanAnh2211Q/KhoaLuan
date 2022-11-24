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
namespace QLCHTAN
{
    public partial class ThongTinThanhPhanDoAn_GUI : Form
    {
        ThongTinThanhPhanDoAn_BUS tttpda_BUS = new ThongTinThanhPhanDoAn_BUS();
        public ThongTinThanhPhanDoAn_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinThanhPhanDoAn_GUI_Load(object sender, EventArgs e)
        {
            lblTenMonAn.Text = DoAn_GUI.tenDoAn;
            dgvThanhPhanMon.DataSource = tttpda_BUS.show_ThanhPhanDoAn_BUS(DoAn_GUI.maDoAn);
            cbbTenThanhPhan.DataSource = tttpda_BUS.show_dsthanhPhanDoAn_BUS();
            cbbTenThanhPhan.DisplayMember = "TenHang";
            cbbTenThanhPhan.ValueMember = "MaHang";
        }

        private void dgvThanhPhanMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThanhPhanMon.Rows[e.RowIndex];
                cbbTenThanhPhan.Text = r.Cells[1].Value.ToString();
                txtDinhLuong.Text = r.Cells[2].Value.ToString();
            }    
        }
    }
}
