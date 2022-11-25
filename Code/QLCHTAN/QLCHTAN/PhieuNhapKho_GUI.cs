using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
namespace QLCHTAN
{
    public partial class PhieuNhapKho_GUI : Form
    {
        PhieuNhapKho_BUS phieuNhapKho_BUS = new PhieuNhapKho_BUS();
        public static string maNhapKho;
        public PhieuNhapKho_GUI()
        {
            InitializeComponent();
        }
        public PhieuNhapKho_DTO phieuNhapKho_DTO()
        {
            return new PhieuNhapKho_DTO(txtMaNhap.Text.Trim(), dtNgayNhap.Value, ccbMaDatHang.Text, txtGhiChu.Text);
        }
     

        private void PhieuNhapKho_GUI_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = phieuNhapKho_BUS.dsPhieuNhap_BUS();
            ccbMaDatHang.DataSource = phieuNhapKho_BUS.dsPhieuDat_BUS();
            ccbMaDatHang.DisplayMember = "maDatHang";
            ccbMaDatHang.ValueMember = "maDatHang";
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvPhieuNhap.Rows[e.RowIndex];
                txtMaNhap.Text = r.Cells[0].Value.ToString();
                dtNgayNhap.Value = Convert.ToDateTime(r.Cells[1].Value.ToString());
                ccbMaDatHang.Text = r.Cells[2].Value.ToString();
                txtGhiChu.Text = r.Cells[3].Value.ToString();
                txtMaNhap.Enabled = false;
            }
            else
            {
                dtNgayNhap.Value = DateTime.Now;
            }    
                
        }

        private void btnThemPhieuNhap_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap_GUI themPhieuNhap_GUI = new ThemPhieuNhap_GUI();
            themPhieuNhap_GUI.Show();
        }

        private void btnThongTinChiTiet_Click(object sender, EventArgs e)
        {
            ThongTinPhieuNhap_GUI thongTinPhieuNhap_GUI = new ThongTinPhieuNhap_GUI();
            thongTinPhieuNhap_GUI.Show();
        }

        private void txtMaNhap_TextChanged(object sender, EventArgs e)
        {
            maNhapKho = txtMaNhap.Text;
        }
    }
}
