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
    public partial class ThongTinChiTietPhieuDat_GUI : Form
    {
        ThongTinChiTietPhieuDatHang_BUS thongTinChiTietPhieuDatHang_BUS = new ThongTinChiTietPhieuDatHang_BUS();
        public ThongTinChiTietPhieuDat_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinChiTietPhieuDat_GUI_Load(object sender, EventArgs e)
        {
            txtMaDatHang.Text = PhieuDatHang_GUI.maPhieuDat;
            dgvThongTinChiTietPhieuDat.DataSource = thongTinChiTietPhieuDatHang_BUS.ds_SanPhamDat_BUS(PhieuDatHang_GUI.maPhieuDat);
            lblTongGia.Text = thongTinChiTietPhieuDatHang_BUS.tongGia_PhieuDat_BUS() + "VND";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
