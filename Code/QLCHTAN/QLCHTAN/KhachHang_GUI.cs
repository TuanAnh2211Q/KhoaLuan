using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using DTO;
using BUS;

namespace QLCHTAN
{
    public partial class KhachHang_GUI : Form
    {
        KhachHang_BUS khachhang_BUS = new KhachHang_BUS();
        public string GioiTinh { get; set; }
        public KhachHang_GUI()
        {
            InitializeComponent();
        }

        #region Method
        public bool kt_KhachHang()
        {
            for (int i = 0; i <= dgvThongTinKhachHang.Rows.Count - 1; i++)
            {
                if (txtSDT.Text == dgvThongTinKhachHang.Rows[i].Cells["SDT"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public KhachHang_DTO khachHang_DTO()
        {
            return new KhachHang_DTO(txtSDT.Text.Trim(), txtTenKhachHang.Text.Trim(),  GioiTinh.Trim(), txtDiaChi.Text.Trim(), txtGmail.Text.Trim(), rtbGhiChu.Text.Trim(),ccbLoaiKhach.SelectedValue.ToString());
        }

        #endregion
        //==================================================================================================================================================
        #region Event
        private void KhachHang_GUI_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
            ccbLoaiKhach.DataSource = khachhang_BUS.select_LoaiKhach_BUS();
            ccbLoaiKhach.DisplayMember = "tenLoaiKhach";
            ccbLoaiKhach.ValueMember = "maLoaiKhach";

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSDT.Clear();
            txtTenKhachHang.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            txtGmail.Clear();
            txtDiaChi.Clear();
            rtbGhiChu.Clear();
            dgvThongTinKhachHang.DataSource = khachhang_BUS.show_dsKhachHang_BUS();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có chắc muốn sửa thông tin khách hàng ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtSDT.Text.Trim() != "" && txtTenKhachHang.Text.Trim() != "" &&  txtDiaChi.Text.Trim() != "" && txtGmail.Text.Trim() != "" )
                {
                    if (kt_KhachHang())
                    {
                        if (khachhang_BUS.update_KhachHang_BUS(khachHang_DTO()))
                        {
                            MessageBox.Show("Sửa Thông Tin Khách Hàng Thành Công");
                            KhachHang_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Chỉnh sửa thông tin khách hàng thất bại");
                    }
                    else
                        MessageBox.Show("Khách hàng không tồn tại, vui lòng kiểm tra lại");
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
                GioiTinh = "Nam";
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
                GioiTinh = "Nữ";
        }


        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenKhachHang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void dgvThongTinKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvThongTinKhachHang.Rows[e.RowIndex];
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["tenKhachHang"].Value.ToString();
                if (row.Cells["Phai"].Value.ToString().Trim() == "Nam")
                    rdbNam.Checked = true;
                else if (row.Cells["Phai"].Value.ToString().Trim() == "Nữ")
                    rdbNu.Checked = true;
                txtDiaChi.Text = row.Cells["diaChi"].Value.ToString();
                txtGmail.Text = row.Cells["Email"].Value.ToString();
                rtbGhiChu.Text = row.Cells["ghiChu"].Value.ToString();
                txtMaKhachHang.Text = row.Cells["idKhachHang"].Value.ToString();
                txtMaKhachHang.Enabled = false;
                ccbLoaiKhach.SelectedValue = row.Cells["maLoaiKhach"].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có chắc muốn xóa khách hàng này không ?", "Thông Báo ", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaKhachHang.Text.Trim() != "")
                {

                    if (kt_KhachHang())
                    {
                        if (khachhang_BUS.delete_KhachHang_BUS(khachHang_DTO()))
                        {
                            MessageBox.Show("Xóa thông tin khách hàng thành công");
                            KhachHang_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Xóa Khách hàng Thất Bại");
                    }
                    else
                        MessageBox.Show("Khách không tồn tại, vui lòng kiểm tra lại ");
                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
        #endregion

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
            else if(txtSDT.Text.Length>11 && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }    
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if(txtTimKiem.Text=="")
            {
                KhachHang_GUI_Load(sender, e);
            }    
            else
            {
               dgvThongTinKhachHang.DataSource = khachhang_BUS.search_KhachHang_BUS(txtTimKiem.Text.Trim());
            }    
        }

        private void cbbTieuChiLoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbTieuChiLoc.SelectedItem.ToString()=="Khách hàng thân thiết")
            {
                dgvThongTinKhachHang.DataSource = khachhang_BUS.sort_KhachHang_BUS(1);
            }    
            else if (cbbTieuChiLoc.SelectedItem.ToString()=="Khách hàng phổ thông")
            {
                dgvThongTinKhachHang.DataSource = khachhang_BUS.sort_KhachHang_BUS(0);
            }
            else
            {
                dgvThongTinKhachHang.DataSource = khachhang_BUS.show_dsKhachHang_BUS();
            }    

        }
    }
}
