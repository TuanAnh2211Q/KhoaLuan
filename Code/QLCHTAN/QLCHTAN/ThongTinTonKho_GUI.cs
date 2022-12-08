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
    public partial class ThongTinTonKho_GUI : Form
    {
        ThongTinTonKho_BUS thongTinTonKho_BUS = new ThongTinTonKho_BUS();
        MatHang_BUS matHang_BUS = new MatHang_BUS();
        NhaCungCap_BUS nhaCungCap_BUS = new NhaCungCap_BUS();
        public ThongTinTonKho_GUI()
        {
            InitializeComponent();
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhieuNhapKho_GUI pnk = new PhieuNhapKho_GUI();
            pnk.Show();
        }

        private void ThongTinTonKho_GUI_Load(object sender, EventArgs e)
        {
            dgvThongTinHangTon.DataSource = thongTinTonKho_BUS.show_DS_HangTon_DAO();

            cbbMaHang.DataSource = matHang_BUS.show_dsMatHang_BUS();
            cbbMaHang.DisplayMember = "maHang";
            cbbMaHang.ValueMember = "tenHang";

            cbbNCC.DataSource = nhaCungCap_BUS.show_dsNCC_BUS();
            cbbNCC.DisplayMember = "tenNCC";
            cbbNCC.ValueMember = "maNCC";


        }

        private void dgvThongTinHangTon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvThongTinHangTon.Rows[e.RowIndex];
                cbbMaHang.SelectedValue = r.Cells["tenHang"].Value.ToString();
                lblSoLuongTon.Text = r.Cells["soLuongTon"].Value.ToString();
                lblTongDonGia.Text = r.Cells["tongDonGia"].Value.ToString() + " VNĐ";
            }    
        }

        private void cbbMaHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbMaHang.SelectedValue!=null)
            {
                txtTenHang.Text = cbbMaHang.SelectedValue.ToString();
                cbbNCC.SelectedValue = matHang_BUS.select_MatHang_NCC(cbbMaHang.Text);
            }    
        }

      
    }
}
