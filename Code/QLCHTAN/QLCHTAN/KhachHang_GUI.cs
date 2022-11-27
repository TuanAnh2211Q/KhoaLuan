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
        private void KhachHang_GUI_Load(object sender, EventArgs e)
        {
            dgvThongTinKhachHang.DataSource = khachhang_BUS.show_dsKhachHang_BUS();
            txtSDT.Text = txtTenKhachHang.Text = txtGmail.Text = rtbGhiChu.Text = "";
            txtSDT.Enabled = true;

        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtSDT.Clear();
            txtTenKhachHang.Clear();
            txtGmail.Clear();
            rtbGhiChu.Clear();
            rdbNam.Checked = rdbNu.Checked = false;
            txtSDT.Focus();
            dgvThongTinKhachHang.DataSource = khachhang_BUS.show_dsKhachHang_BUS();
            txtMaKhachHang.Clear();
        }
        public bool kt_KhachHang()
        {
            for(int i=0;i<=dgvThongTinKhachHang.Rows.Count-1;i++)
            {
                if (txtMaKhachHang.Text != dgvThongTinKhachHang.Rows[i].Cells["idKhachHang"].Value.ToString())
                {
                    return true;
                }
                

            }
            return false;
        }
        public KhachHang_DTO khachHang_DTO()
        {
            return new KhachHang_DTO(txtMaKhachHang.Text.Trim(), txtTenKhachHang.Text, txtSDT.Text.Trim(),txtGmail.Text.Trim(),GioiTinh.Trim(),rtbGhiChu.Text.Trim(),txtDiaChi.Text.Trim());
        }
     
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có chắc muốn sửa thông tin nhân viên ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if(txtSDT.Text.Trim()!="" && txtTenKhachHang.Text.Trim()!="" && txtDiaChi.Text.Trim()!="" && txtGmail.Text.Trim()!="" && rtbGhiChu.Text.Trim()!="")
                {
                    if(kt_KhachHang())
                    {
                        if(khachhang_BUS.update_KhachHang_BUS(khachHang_DTO()))
                        {
                            MessageBox.Show("Sửa Thông Tin Khách Hàng Thành Công");
                            KhachHang_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Chỉnh sửa thông tin nhân viên thất bại");
                    }
                    else
                        MessageBox.Show("Nhân viên không tồn tại, vui lòng kiểm tra lại");
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

        private void dgvThongTinKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvThongTinKhachHang.Rows[e.RowIndex];
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtTenKhachHang.Text = row.Cells["tenKhachHang"].Value.ToString();
                if (row.Cells[1].Value.ToString().Trim() == "Nam")
                    rdbNam.Checked = true;
                else if (row.Cells[1].Value.ToString().Trim() == "Nữ")
                    rdbNu.Checked = true;
                txtGmail.Text= row.Cells["Email"].Value.ToString();
                txtDiaChi.Text= row.Cells["diaChi"].Value.ToString();
                rtbGhiChu.Text= row.Cells["ghiChu"].Value.ToString();
               // txtMaKhachHang.Text = row.Cells["idKhacHang"].Value.ToString();
                //txtMaKhachHang.Enabled = false;
            }
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
    }
}
