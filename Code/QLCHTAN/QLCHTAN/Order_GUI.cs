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
    public partial class Order_GUI : Form
    {
        KhachHang_BUS khachHang_BUS = new KhachHang_BUS();
        DoAn_BUS doAn_BUS = new DoAn_BUS();
        NuocUong_BUS nuocUong_BUS = new NuocUong_BUS();
        KhuyenMai_BUS khuyenMai_BUS = new KhuyenMai_BUS();
        public string loaiDichVu { get; set; }
        public string GioiTinh { get; set; }
        public Order_GUI()
        {
            InitializeComponent();
        }
        #region Method
        public KhachHang_DTO khachHang_DTO()
        {
            return new KhachHang_DTO(cbbSDT.SelectedValue.ToString().Trim(), txtTenKhach.Text.Trim(), GioiTinh.Trim(), txtDiaChi.Text.Trim(), txtEmail.Text.Trim(), loaiDichVu.Trim(), rtxtGhiChu.Text.Trim()) ;
        }
        private void clearData(object sender,EventArgs e)
        {
            cbbSDT.DataSource = khachHang_BUS.show_dsKhachHang_BUS();
            cbbSDT.ValueMember = "SDT";
            cbbSDT.DisplayMember = "SDT";
            cbbSDT.SelectedValue = -1;
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            rtxtGhiChu.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbAnTaiCho.Checked = false;
            rdbGiaoHang.Checked = false;
            rdbMangVe.Checked = false;
        }
        #endregion


        #region Event
        
        private void Order_GUI_Load(object sender, EventArgs e)
        {
            clearData(sender,e);
            ////load dữ liệu dồ ăn
            cbbDanhMucMon.DataSource = doAn_BUS.show_dsLoaiDoAn_BUS();
            cbbDanhMucMon.DisplayMember = "tenLoaiDoAn";
            cbbDanhMucMon.ValueMember = "maLoaiDoAn";
            cbbSDT.SelectedValue = -1;
            cbbSizeDoAn.DataSource = doAn_BUS.select_DonViBanDoAn_BUS();
            cbbSizeDoAn.DisplayMember = "donViBan";
            cbbSizeDoAn.ValueMember = "donViBan";
            //load dữ liệu nước uống
            cbbTenNuoc.DataSource = nuocUong_BUS.show_dsNuocUong_BUS();
            cbbTenNuoc.DisplayMember = "tenNuoc";
            cbbTenNuoc.ValueMember = "maNuoc";
            //Load khuyến mãi
            cbbMaGiamGia.DataSource = khuyenMai_BUS.show_KM_BUS();
            cbbMaGiamGia.DisplayMember = "tenKhuyenMai";
            cbbMaGiamGia.ValueMember = "maKhuyenMai";

           
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            NhanVienThanhToan_GUI t = new NhanVienThanhToan_GUI();
            t.Show();
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                GioiTinh = "Nam";
            }
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
            {
                GioiTinh = "Nữ";
            }
        }

        private void rdbAnTaiCho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAnTaiCho.Checked)
            {
                loaiDichVu = "Ăn Tại Chổ";
            }
        }

        private void rdbMangVe_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbMangVe.Checked)
            {
                loaiDichVu = "Mang Về";
            }
        }

        private void rdbGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGiaoHang.Checked)
            {
                loaiDichVu = "Giao Hàng";
            }

        }

        private void cbbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
         private void cbbSDT_SelectedValueChanged(object sender, EventArgs e)
        {

            if(cbbSDT.SelectedValue!=null)
            {
                if (khachHang_BUS.find_KhachHang_BUS(cbbSDT.SelectedValue.ToString()) != null)
                {
                    DataTable tb = khachHang_BUS.find_KhachHang_BUS(cbbSDT.SelectedValue.ToString());
                    foreach (DataRow r in tb.Rows)
                    {
                        txtTenKhach.Text = r["tenKhachHang"].ToString();
                        if (r["Phai"].ToString().Trim() == "Nam")
                        {
                            rdbNam.Enabled = true;
                            rdbNam.Checked = true;
                            rdbNu.Enabled = false;
                        }
                        else
                        {
                            rdbNu.Enabled = true;
                            rdbNu.Checked = true;
                            rdbNam.Enabled = false;
                        }
                        txtDiaChi.Text = r["diaChi"].ToString();
                        txtEmail.Text = r["Email"].ToString();
                        rtxtGhiChu.Text = r["ghiChu"].ToString();
                    }
                }
            }    
             
               
        }
        private void cbbDanhMucMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbDanhMucMon.SelectedValue != null)
            {
                string maloai = cbbDanhMucMon.SelectedValue.ToString().Trim();
                if (doAn_BUS.show_DSLoaiDoAn_BUS(maloai).Rows.Count > 0)
                {
                    cbbTenMon.DataSource = doAn_BUS.show_DSLoaiDoAn_BUS(maloai);
                    cbbTenMon.DisplayMember = "tenDoAn";
                    cbbTenMon.ValueMember = "maDoAn";
                }
                else
                {
                    cbbTenMon.DataSource = null;
                    cbbTenMon.Text = String.Empty;
                }
            }

        }

        
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearData(sender, e);
        }
        private void dgvDonHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string maDoAn ;
            DataTable thongtindonhang = (DataTable)dgvThongTinDonHang.DataSource;
            
            string maLoai = cbbDanhMucMon.SelectedValue.ToString().Trim();
            foreach(DataRow r in thongtindonhang.Rows)
            {
                cbbTenMon.DataSource = doAn_BUS.show_DSLoaiDoAn_BUS(maLoai);
                cbbTenMon.DisplayMember = "tenDoAn";
                cbbTenMon.ValueMember = "maDoAn";
                cbbTenMon.SelectedValue = r.Field<string>("tenDoAn");
                //int soLuong = nudSoLuongMon.Value;
                //soLuong = r.Field<int>("soLuong");
                //decimal donGia = doAn_BUS.select_GiaDoAn_BUS(cbbTenMon.ValueMember);
                //donGia = r.Field<decimal>("donGia");
                //decimal thanhTien = donGia * soLuong;

            }
        }




        #endregion

    }
}
