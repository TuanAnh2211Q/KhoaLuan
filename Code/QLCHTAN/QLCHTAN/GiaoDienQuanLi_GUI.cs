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
namespace QLCHTAN
{
    public partial class GiaoDienQuanLi_GUI : Form
    {
        NhanVien_BUS nhanVien_BUS = new NhanVien_BUS();
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

      

        private void btnQLNV_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            NhanVien_GUI nhanvien = new NhanVien_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize=true };
            this.pCuaSoChucNang.Controls.Add(nhanvien);
            nhanvien.Show();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            TaiKhoan_GUI taiKhoan = new TaiKhoan_GUI(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(taiKhoan);
            taiKhoan.Show();
 
        }

        private void btnQLLDA_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            LoaiDoAn_GUI loaiDoAn = new LoaiDoAn_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(loaiDoAn);
            loaiDoAn.Show();
    
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            DoAn_GUI doan = new DoAn_GUI(){ Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(doan);
            doan.Show();
        }

        private void btnQLNU_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            NuocUong_GUI nuocuong = new NuocUong_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(nuocuong);
            nuocuong.Show();
          
        }

        private void btnQLNCC_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            NhaCungCap_GUI nhacungcap = new NhaCungCap_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(nhacungcap);
            nhacungcap.Show();
           
        }

        private void btnQLKM_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            KhuyenMai_GUI khuyenmai = new KhuyenMai_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(khuyenmai);
            khuyenmai.Show();
        }

        private void btnQLLKM_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            LoaiKhuyenMai_GUI loaikhuyenmai = new LoaiKhuyenMai_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(loaikhuyenmai);
            loaikhuyenmai.Show();
    
        }

        private void btnQLNH_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            PhieuNhapKho_GUI phieunhap = new PhieuNhapKho_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(phieunhap);
            phieunhap.Show();
 
        }

        private void btnQLXH_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            PhieuXuatKho_GUI phieuxuat = new PhieuXuatKho_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(phieuxuat);
            phieuxuat.Show();
    
        }

        private void btnQLDH_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            PhieuDatHang_GUI phieudat = new PhieuDatHang_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(phieudat);
            phieudat.Show();
       
        }

        private void btnQLTH_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            PhieuTra_GUI phieuTra = new PhieuTra_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(phieuTra);
            phieuTra.Show();
        }

        private void btnQLMH_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            MatHang_GUI mathang = new MatHang_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(mathang);
            mathang.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.panel3.ClientRectangle, Color.Red, ButtonBorderStyle.Solid);
        }

        private void pChucNang_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.pChucNang.ClientRectangle, Color.DarkCyan, ButtonBorderStyle.Solid);
        }

        private void GiaoDienQuanLi_GUI_Load(object sender, EventArgs e)
        {
            lblTenTaiKhoan.Text = nhanVien_BUS.select_TenNhanVien_BUS(DangNhap_GUI.tenTaiKhoan);

        }

        private void lblkDangXuat_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangNhap_GUI dangNhap = new DangNhap_GUI();
            dangNhap.Show();
            this.Close();
        }

        private void btnQLHT_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            ThongTinTonKho_GUI qltk = new ThongTinTonKho_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(qltk);
            qltk.Show();
        }

        private void btnQLHKB_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            KhoBan_GUI khoban = new KhoBan_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true };
            this.pCuaSoChucNang.Controls.Add(khoban);
            khoban.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            Order_GUI order = new Order_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true }; ;
            this.pCuaSoChucNang.Controls.Add(order);
            order.Show();
        }

        private void btnQLKH_Click(object sender, EventArgs e)
        {
            pCuaSoChucNang.Controls.Clear();
            KhachHang_GUI khachHang = new KhachHang_GUI() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, AutoSize = true }; ;
            this.pCuaSoChucNang.Controls.Add(khachHang);
            khachHang.Show();
        }
    }
}
