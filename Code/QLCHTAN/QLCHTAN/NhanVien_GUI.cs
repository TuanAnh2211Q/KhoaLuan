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
    public partial class NhanVien_GUI : Form
    {
        NhanVien_BUS nhanVien_BUS = new NhanVien_BUS();
        public string GioiTinh { get; set; }

        public bool kt_NhanVien()
        {
            for (int i = 0; i <= dgvNhanVien.Rows.Count - 1; i++)
            {
                if (txtMaNhanVien.Text == dgvNhanVien.Rows[i].Cells["maNhanVien"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        public NhanVien_GUI()
        {
            InitializeComponent();
        }

        private void NhanVien_GUI_Load(object sender, EventArgs e)
        {
            btnLamMoi_Click(sender, e);
        }
       
        public NhanVien_DTO nhanVien_DTO()
        {
            return new NhanVien_DTO(txtMaNhanVien.Text, txtTenNhanVien.Text, GioiTinh.Trim(), txtSDT.Text.Trim(),txtEmail.Text, txtDiaChi.Text.Trim(), cbbChucDanh.SelectedValue.ToString().Trim(), cbbLoaiNV.SelectedValue.ToString().Trim());
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có chắc muốn thêm nhân viên ?", "Thông báo", MessageBoxButtons.YesNo);
            if(them==DialogResult.Yes)
            {
                if (txtMaNhanVien.Text.Trim() != "" && txtTenNhanVien.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtDiaChi.Text.Trim() != "")
                {

                    if (!kt_NhanVien())
                    {
                        if (nhanVien_BUS.insert_NhanVien_BUS(nhanVien_DTO()))
                        {
                            MessageBox.Show("Thêm nhân viên thành công");
                            NhanVien_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Thêm nhân viên thất bại");
                    }
                    else
                        MessageBox.Show("Mã nhân viên đã tồn tại, vui lòng nhập lại");

                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
            }    
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có chắc muốn xóa nhân viên ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaNhanVien.Text.Trim() != "" )
                {
                    if (kt_NhanVien())
                    {

                        if (nhanVien_BUS.delete_NhanVien_BUS(nhanVien_DTO()))
                        {
                            MessageBox.Show("Xóa nhân viên thành công");
                            NhanVien_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Xóa nhân viên thất bại");
                    }
                    else
                        MessageBox.Show("Nhân viên không tồn tại, vui lòng kiểm tra lại");

                }
                else
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có chắc muốn sửa thông tin nhân viên ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaNhanVien.Text.Trim() != "" && txtTenNhanVien.Text.Trim() != "" && txtSDT.Text.Trim() != "" && txtEmail.Text.Trim() != "" && txtDiaChi.Text.Trim() != "")
                {
                    if(kt_NhanVien())
                    {
                        if (nhanVien_BUS.update_NhanVien_BUS(nhanVien_DTO()))
                        {
                            MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công");
                            NhanVien_GUI_Load(sender, e);
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
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNhanVien.Clear();
            txtMaNhanVien.Enabled = true;
            txtTenNhanVien.Clear();
            txtSDT.Clear();
            txtEmail.Clear();
            txtDiaChi.Clear();
            rdbNam1.Checked = rdbNu0.Checked = rdbKhac.Checked = false;
            txtMaNhanVien.Focus();
            dgvNhanVien.DataSource = nhanVien_BUS.dsNhanVien_BUS();

            cbbChucDanh.DataSource = nhanVien_BUS.dsChucDanh_BUS();
            cbbChucDanh.ValueMember = "maChucDanh";
            cbbChucDanh.DisplayMember = "tenChucDanh";

            cbbLoaiNV.DataSource = nhanVien_BUS.dsLoaiNhanVien_BUS();
            cbbLoaiNV.ValueMember = "maLoaiNhanVien";
            cbbLoaiNV.DisplayMember = "tenLoaiNhanVien";
        }
        private void rdbNam1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam1.Checked)
                GioiTinh = "Nam";
        }

        private void rdbNu0_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu0.Checked)
                GioiTinh = "Nữ";
        }

        private void rdbKhac_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbKhac.Checked)
                GioiTinh = "Khác";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvNhanVien.Rows[e.RowIndex];
                txtMaNhanVien.Text = row.Cells["maNhanVien"].Value.ToString();
                txtTenNhanVien.Text = row.Cells["tenNhanVien"].Value.ToString();
                if (row.Cells[2].Value.ToString().Trim() == "Nam")
                    rdbNam1.Checked = true;
                else if (row.Cells[2].Value.ToString().Trim() == "Nữ")
                    rdbNu0.Checked = true;
                else if (row.Cells[2].Value.ToString().Trim() == "Khác")
                    rdbKhac.Checked = true;
                cbbChucDanh.SelectedValue = row.Cells["maChucDanh"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtSDT.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChi.Text = row.Cells["diaChi"].Value.ToString();
                cbbLoaiNV.SelectedValue = row.Cells["maLoaiNhanVien"].Value.ToString();
                txtMaNhanVien.Enabled = false;
            }
        }

       

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenNhanVien_KeyPress(object sender, KeyPressEventArgs e)
        {
   
        }

        
    }
}
