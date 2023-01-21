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
using System.Globalization;

namespace QLCHTAN
{
    public partial class ThongTinPhieuDat_GUI : Form
    {
        ThongTinChiTietPhieuDatHang_BUS thongTinChiTietPhieuDatHang_BUS = new ThongTinChiTietPhieuDatHang_BUS();
        MatHang_BUS matHang = new MatHang_BUS();
        public bool kiemtra_MatHangDat()
        {
            foreach(DataGridViewRow r in dgvThongTinChiTietPhieuDat.Rows)
            {
                if (cbbMatHang.SelectedValue.ToString().Trim() == r.Cells["maHang"].Value.ToString().Trim())
                    return true;
            }
            return false;

        }
        public ThongTinChiTietPhieuDatHang_DTO thongTinChiTietPhieuDatHang_DTO()
        {
          
            return new ThongTinChiTietPhieuDatHang_DTO(txtMaDatHang.Text.Trim(), cbbMatHang.SelectedValue.ToString().Trim(), Convert.ToInt32(txtSoLuong.Text));
        }
        public ThongTinPhieuDat_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinChiTietPhieuDat_GUI_Load(object sender, EventArgs e)
        {
            txtMaDatHang.Text = PhieuDatHang_GUI.maPhieuDat;
            dgvThongTinChiTietPhieuDat.DataSource = thongTinChiTietPhieuDatHang_BUS.ds_SanPhamDat_BUS(PhieuDatHang_GUI.maPhieuDat);

           
            lblTongGia.Text = thongTinChiTietPhieuDatHang_BUS.tongGia_PhieuDat_BUS(PhieuDatHang_GUI.maPhieuDat) +"VNĐ";



            cbbMatHang.DataSource = thongTinChiTietPhieuDatHang_BUS.ds_matHang_BUS();
            cbbMatHang.DisplayMember = "tenHang";
            cbbMatHang.ValueMember = "maHang";
            txtSoLuong.Text = "";
            cbbMatHang.SelectedIndex = 0;

            if(PhieuDatHang_GUI.trangThaiPhieu)
            {
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
                btnThem.BackColor = btnXoa.BackColor = btnSua.BackColor = Color.Transparent;
            }    
            else
            {
                btnThem.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }
        }

        private void lblThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lblkLamMoi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ThongTinChiTietPhieuDat_GUI_Load(sender,e);
        }

        private void dgvThongTinChiTietPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThongTinChiTietPhieuDat.Rows[e.RowIndex];
                cbbMatHang.SelectedValue = r.Cells["maHang"].Value.ToString();
                txtSoLuong.Text = r.Cells["soLuongDat"].Value.ToString();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                DialogResult rs = MessageBox.Show("Xác nhận thêm mặt hàng vào đơn nhập ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (thongTinChiTietPhieuDatHang_BUS.insert_ThongTinDatHang(thongTinChiTietPhieuDatHang_DTO()))
                    {
                        MessageBox.Show("Thêm mặt hàng thành công");
                        ThongTinChiTietPhieuDat_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    }

                }
            }
            else
                MessageBox.Show("Vui lòng nhập số lượng hàng thêm");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
                DialogResult rs = MessageBox.Show("Xác nhận thay đổi số lượng đặt hàng ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (thongTinChiTietPhieuDatHang_BUS.update_ThongTinDatHang(thongTinChiTietPhieuDatHang_DTO()))
                    {
                        MessageBox.Show("Thay đổi thành công");
                        ThongTinChiTietPhieuDat_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    }

                }
            }
            else
                MessageBox.Show("Vui lòng nhập số lượng hàng cần chỉnh sửa");
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Char.IsNumber(e.KeyChar) && e.KeyChar > 0) ||Char.IsControl(e.KeyChar) )
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(kiemtra_MatHangDat())
            {
                DialogResult rs = MessageBox.Show("Xác nhận xóa mặt hàng khỏi đơn đặt ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (txtSoLuong.Text == "")
                    {
                        txtSoLuong.Text = "0";
                    }
                    if (thongTinChiTietPhieuDatHang_BUS.delete_ThongTinDatHang(thongTinChiTietPhieuDatHang_DTO()))
                    {
                        MessageBox.Show("Xóa mặt hàng đặt thành công");
                        ThongTinChiTietPhieuDat_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    }

                }
            }    
           else
            {
                MessageBox.Show("Mặt hàng không tồn tại trong danh sách đặt");
            }    
              
           
        }

        private void cbbMatHang_SelectedValueChanged(object sender, EventArgs e)
        {
            lblMaHangNhap.Text = cbbMatHang.SelectedValue.ToString();
        }

      
    }
}
