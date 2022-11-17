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
    public partial class PhieuDatHang_GUI : Form
    {
        PhieuDatHang_BUS phieuDatHang_BUS = new PhieuDatHang_BUS();
        public static string maPhieuDat;
        public PhieuDatHang_GUI()
        {
            InitializeComponent();
        }
        public PhieuDatHang_DTO phieuDatHang_DTO()
        {
            return new PhieuDatHang_DTO(txtMaDat.Text.Trim(), dtNgayDat.Value, dtNgayDuKienGiao.Value, ccbPhuongThucThanhToan.Text.Trim(), txtGhiChu.Text);
        }

        private void btnThongTinChiTiet_Click(object sender, EventArgs e)
        {
            if(txtMaDat.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xem thông tin");
                return;
            }
            else
            {
                ThongTinChiTietPhieuDat_GUI thongTinChiTietPhieuDat_GUI = new ThongTinChiTietPhieuDat_GUI();
                thongTinChiTietPhieuDat_GUI.Show();
            }
          
        }

        private void PhieuDatHang_GUI_Load(object sender, EventArgs e)
        {
            dgvPhieuDat.DataSource = phieuDatHang_BUS.dsPhieuDatHang_BUS();
        }

        private void dgvPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvPhieuDat.Rows[e.RowIndex];
                txtMaDat.Text = r.Cells[0].Value.ToString();
                dtNgayDat.Value = Convert.ToDateTime( r.Cells[1].Value.ToString());
                dtNgayDuKienGiao.Value = Convert.ToDateTime(r.Cells[2].Value.ToString());
                ccbPhuongThucThanhToan.Text = r.Cells[3].Value.ToString();
                txtGhiChu.Text = r.Cells[4].Value.ToString();
            }    
        }

        private void txtMaDat_TextChanged(object sender, EventArgs e)
        {
            maPhieuDat = txtMaDat.Text;
        }
    }
}
