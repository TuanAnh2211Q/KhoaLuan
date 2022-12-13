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
    public partial class ThongTinThanhPhanDoAn_GUI : Form
    {
        ThongTinThanhPhanDoAn_BUS tttpda_BUS = new ThongTinThanhPhanDoAn_BUS();
        public ThongTinThanhPhanDoAn_DTO tttpda()
        {
            return new ThongTinThanhPhanDoAn_DTO(cbbTenThanhPhan.SelectedValue.ToString().Trim(), cbbTenThanhPhan.Text.Trim(), txtDinhLuong.Text.Trim(), DoAn_GUI.maDoAn.Trim(),Convert.ToInt32(txtSoLuong.Text.Trim()));
        }
        public ThongTinThanhPhanDoAn_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinThanhPhanDoAn_GUI_Load(object sender, EventArgs e)
        {
            lblTenMonAn.Text = DoAn_GUI.tenDoAn;
            dgvThanhPhanMon.DataSource = tttpda_BUS.show_ThanhPhanDoAn_BUS(DoAn_GUI.maDoAn);
            cbbTenThanhPhan.DataSource = tttpda_BUS.show_dsthanhPhanDoAn_BUS();
            cbbTenThanhPhan.DisplayMember = "TenHang";
            cbbTenThanhPhan.ValueMember = "MaHang";
            txtDinhLuong.Enabled = false;
        }

        private void dgvThanhPhanMon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThanhPhanMon.Rows[e.RowIndex];
                cbbTenThanhPhan.Text = r.Cells["tenThanhPhan"].Value.ToString().Trim();
                txtDinhLuong.Text = r.Cells["dinhLuong"].Value.ToString();
                txtSoLuong.Text = r.Cells["soLuong"].Value.ToString();
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn muốn thêm thành phần này vào món ăn ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                try
                {
                    if (txtDinhLuong.Text != "" && cbbTenThanhPhan.Text != "")
                    {
                        if (tttpda_BUS.insert_ThanhPhanDoAn_DAO(tttpda()))
                        {
                            MessageBox.Show("Thêm thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm thành phần thất bại, vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm thành phần thất bại, vui lòng kiểm tra lại thông tin nhập");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult xoa = MessageBox.Show("Bạn muốn xóa thành phần này khỏi món ăn ?", "Thông báo", MessageBoxButtons.YesNo);
            if (xoa == DialogResult.Yes)
            {
                try
                {
                    if ( cbbTenThanhPhan.Text != "")
                    {
                        if (tttpda_BUS.delete_ThanhPhanDoAn_DAO(tttpda()))
                        {
                            MessageBox.Show("Xóa thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa thất bại, vui lòng kiểm tra lại thông tin nhập");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Bạn muốn sửa thành phần món ăn ?", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                try
                {
                    if (txtDinhLuong.Text != "" && cbbTenThanhPhan.Text != "")
                    {
                        if (tttpda_BUS.update_ThanhPhanDoAn_DAO(tttpda()))
                        {
                            MessageBox.Show("Sửa thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thành phần thất bại, vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thành phần thất bại, vui lòng kiểm tra lại thông tin nhập");
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtDinhLuong.Clear();
            ThongTinThanhPhanDoAn_GUI_Load(sender, e);
        }

        private void cbbTenThanhPhan_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbTenThanhPhan.SelectedValue!=null)
            {
                txtDinhLuong.Text = tttpda_BUS.select_donViThanhPhan_BUS(cbbTenThanhPhan.SelectedValue.ToString());
            }    
        }
    }
}
