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
    public partial class GiaoDienNhanVien_GUI : Form
    {
        public GiaoDienNhanVien_GUI()
        {
            InitializeComponent();
            lblTenTaiKhoanNhanVien.Text = DangNhap_GUI.tenTaiKhoan;
        }

        private void lblkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            DangNhap_GUI dangNhap_GUI = new DangNhap_GUI();
            dangNhap_GUI.Show();
            this.Close();
        }

        private void lblkDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau_GUI doiMatKhau_GUI = new DoiMatKhau_GUI();
            doiMatKhau_GUI.Show();
        }

        private void btnLapPhieuNhapHang_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            PhieuNhapKho_GUI phieuNhapKho_GUI = new PhieuNhapKho_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true }; ;
            this.pCuaSoChucNang.Controls.Add(phieuNhapKho_GUI);
            phieuNhapKho_GUI.Show();
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            Order_GUI order = new Order_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true }; ;
            this.pCuaSoChucNang.Controls.Add(order);
            order.Show();
        }

        private void btnQuanLiKhachHang_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            KhachHang_GUI khachhang = new KhachHang_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true }; ;
            this.pCuaSoChucNang.Controls.Add(khachhang);
            khachhang.Show();
        }
    }
}
