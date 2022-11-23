using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTAN
{
    public partial class GiaoDienQuanLi_GUI : Form
    {
        public GiaoDienQuanLi_GUI()
        {
            InitializeComponent();
            lblTenTaiKhoan.Text = DangNhap_GUI.tenTaiKhoan;
        }

        private void lblkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap_GUI dangNhap = new DangNhap_GUI();
            dangNhap.Show();
            this.Close();
        }

        private void GiaoDienQuanLi_GUI_Load(object sender, EventArgs e)
        {

        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            NhanVien_GUI nhanvien = new NhanVien_GUI();
            nhanvien.Show();
  
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            TaiKhoan_GUI taiKhoan = new TaiKhoan_GUI();
            taiKhoan.Show();
 
        }

        private void btnQLLDA_Click(object sender, EventArgs e)
        {
            LoaiDoAn_GUI loaiDoAn = new LoaiDoAn_GUI();
            loaiDoAn.Show();
    
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            DoAn_GUI doan = new DoAn_GUI();
            doan.Show();
           
        }

        private void btnQLNU_Click(object sender, EventArgs e)
        {
            NuocUong_GUI nuocuong = new NuocUong_GUI();
            nuocuong.Show();
          
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            NhaCungCap_GUI nhacungcap = new NhaCungCap_GUI();
            nhacungcap.Show();
           
        }

        private void btnQLKM_Click(object sender, EventArgs e)
        {
            ThongTinKhuyenMai_GUI khuyenmai = new ThongTinKhuyenMai_GUI();
            khuyenmai.Show();
        }

        private void btnQLLKM_Click(object sender, EventArgs e)
        {
            LoaiKhuyenMai_GUI loaikhuyenmai = new LoaiKhuyenMai_GUI();
            loaikhuyenmai.Show();
    
        }

        private void btnQLNH_Click(object sender, EventArgs e)
        {
            PhieuNhapKho_GUI phieunhap = new PhieuNhapKho_GUI();
            phieunhap.Show();
 
        }

        private void btnQLXH_Click(object sender, EventArgs e)
        {
            PhieuXuatKho_GUI phieuxuat = new PhieuXuatKho_GUI();
            phieuxuat.Show();
    
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            PhieuDatHang_GUI phieudat = new PhieuDatHang_GUI();
            phieudat.Show();
       
        }

        private void btnQLTH_Click(object sender, EventArgs e)
        {
        }
    }
}
