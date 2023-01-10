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
using BUS;
using DTO;
namespace QLCHTAN
{
    public partial class KhoBan_GUI : Form
    {
        KhoBan_BUS khoban_BUS = new KhoBan_BUS();
        public KhoBan_GUI()
        {
            InitializeComponent();
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void KhoBan_GUI_Load(object sender, EventArgs e)
        {
            dgvKhoBan.DataSource = khoban_BUS.show_list_KhoBan_BUS();
        }

        private void dgvKhoBan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvKhoBan.Rows[e.RowIndex];
                lblMaHang.Text = r.Cells["maHang"].Value.ToString();
                lblSoLuong.Text = r.Cells["soLuong"].Value.ToString();
                lblTenHang.Text = r.Cells["tenHang"].Value.ToString();
                lblTongGia.Text = r.Cells["tongGia"].Value.ToString() + " VNĐ";
            }    
        }

        private void lblkTaoPhieuXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThemPhieuXuat_GUI phieuXuat = new ThemPhieuXuat_GUI();
            phieuXuat.Show();
        }
    }
}
