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
    public partial class ThongTinKhuyenMai_GUI : Form
    {
        ThongTinKhuyenMai_BUS ttkm_BUS = new ThongTinKhuyenMai_BUS();
        public bool kiemtra_ThongTinKhuyenMai()
        {
            foreach (DataGridViewRow r in dgvSPKM.Rows)
            {
                if (r.Cells["MaSanPham"].Value.ToString().Trim() == cbbSanPham.SelectedValue.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public ThongTinKhuyenMai_DTO ttkm()
        {
            string ngayBD, ngayKT;
            if (cbKhongNgayBD.Checked)
            {
                ngayBD = "null";
            }
            else
            {
                ngayBD = dtNgayBatDau.Value.ToString();
            }
            if (cbKhongNgayKT.Checked)
            {
                ngayKT = "null";
            }
            else
            {
                ngayKT = dtNgayKetThuc.Value.ToString();
            }
            return new ThongTinKhuyenMai_DTO(KhuyenMai_GUI.maKM, cbbSanPham.SelectedValue.ToString(), ngayBD, ngayKT, txtGhiChu.Text);
        }
        public ThongTinKhuyenMai_GUI()
        {
            InitializeComponent();
        }

        private void DanhSachKhuyenMai_GUI_Load(object sender, EventArgs e)
        {
            lblTenKhuyenMai.Text = "Danh sách sản phẩm áp dụng khuyến mãi " + KhuyenMai_GUI.tenKM;
            cbbSanPham.DataSource = ttkm_BUS.select_TTSP_BUS();
            cbbSanPham.DisplayMember = "tenSanPham";
            cbbSanPham.ValueMember = "maSanPham";
            dgvSPKM.DataSource = ttkm_BUS.show_TTKM_BUS(KhuyenMai_GUI.maKM);
            txtGhiChu.Text = "";
            cbbSanPham.SelectedIndex = 0;
            dtNgayBatDau.Value = DateTime.Today;
            dtNgayKetThuc.Value = DateTime.Today;
            cbKhongNgayBD.Checked = false;
            cbKhongNgayKT.Checked = false;
            cbbSanPham.Enabled = true;

        }

        private void dgvSPKM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvSPKM.Rows[e.RowIndex];
                cbbSanPham.SelectedValue = r.Cells["maSanPham"].Value.ToString();
                if (r.Cells["ngayBatDau"].Value.ToString() == "")
                {
                    cbKhongNgayBD.Checked = true;
                }
                else
                {
                    cbKhongNgayBD.Checked = false;
                    dtNgayBatDau.Value = Convert.ToDateTime(r.Cells["ngayBatDau"].Value.ToString());
                }

                if (r.Cells["ngayKetThuc"].Value.ToString() == "")
                {
                    cbKhongNgayKT.Checked = true;
                }
                else
                {
                    cbKhongNgayKT.Checked = false;
                    dtNgayKetThuc.Value = Convert.ToDateTime(r.Cells["ngayKetThuc"].Value.ToString());
                }
                txtGhiChu.Text = r.Cells["ghiChu"].Value.ToString();
                cbbSanPham.Enabled = false;
            }
        }

        private void cbKhongNgayBD_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKhongNgayBD.Checked)
                dtNgayBatDau.Enabled = false;
            else
                dtNgayBatDau.Enabled = true;
        }

        private void cbKhongNgayKT_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKhongNgayKT.Checked)
                dtNgayKetThuc.Enabled = false;
            else
                dtNgayKetThuc.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (!kiemtra_ThongTinKhuyenMai())
            {
                long sp = dtNgayKetThuc.Value.Subtract(dtNgayBatDau.Value).Ticks;
                if (!cbKhongNgayBD.Checked && !cbKhongNgayKT.Checked)
                {
                    if (sp <= 0)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                        return;
                    }
                }
                DialogResult rs = MessageBox.Show("Xác nhận thêm sản phẩm vào danh sách khuyến mãi", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (ttkm_BUS.insert_TTKM_BUS(ttkm()))
                    {
                        MessageBox.Show("Thêm thành công");
                        btnLamMoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }

            }
            else
                MessageBox.Show("Sản phẩm đã tồn tại trong danh sách khuyến mãi");


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kiemtra_ThongTinKhuyenMai())
            {
                DialogResult rs = MessageBox.Show("Xác nhận xóa sản phẩm khỏi danh sách khuyến mãi", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (ttkm_BUS.delete_TTKM_BUS(ttkm()))
                    {
                        MessageBox.Show("Xóa thành công");
                        btnLamMoi_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");
                    }
                }
            }
            else
            {
                MessageBox.Show("Sản phẩm không tồn tại trong khuyến mãi này");
            }


        }

        private void btnSua_Click(object sender, EventArgs e)
        {

            if (kiemtra_ThongTinKhuyenMai())
            {
                long sp = dtNgayKetThuc.Value.Subtract(dtNgayBatDau.Value).Ticks;
                if (!cbKhongNgayBD.Checked && !cbKhongNgayKT.Checked)
                {
                    if (sp <= 0)
                    {
                        MessageBox.Show("Ngày kết thúc phải lớn hơn ngày bắt đầu");
                        return;
                    }
                }
                    DialogResult rs = MessageBox.Show("Xác nhận sửa sản phẩm trong danh sách ", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        if (ttkm_BUS.update_TTKM_BUS(ttkm()))
                        {
                            MessageBox.Show("Sửa thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thất bại");
                        }
                    }

                }
                else
                    MessageBox.Show("Sản phẩm không tồn tại trong khuyến mãi này");

            }
        
    
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DanhSachKhuyenMai_GUI_Load(sender, e);
        }
    }
}
