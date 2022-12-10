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
    public partial class ThongTinPhieuXuat_GUI : Form
    {
        ThongTinPhieuXuat_BUS ttpx_BUS = new ThongTinPhieuXuat_BUS();
        ThongTinTonKho_BUS tttk_BUS = new ThongTinTonKho_BUS();

        public ThongTinPhieuXuat_DTO ttctpx()
        {
            return new ThongTinPhieuXuat_DTO(PhieuXuatKho_GUI.maxuat, lblMaHangXuat.Text, Convert.ToInt32(txtSoLuongXuat.Text), txtGhiChu.Text);
        }
        public ThongTinPhieuXuat_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinPhieuXuat_GUI_Load(object sender, EventArgs e)
        {
            if (PhieuXuatKho_GUI.tt is true)
            {
                btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = false;
            }
            else
            {
                btnXoa.Enabled = btnThem.Enabled = btnSua.Enabled = true;
            }
            lblThongTinPhieuXuat.Text = "THÔNG TIN PHIẾU XUẤT: " + PhieuXuatKho_GUI.maxuat;
            dgvThongTinPhieuXuat.DataSource = ttpx_BUS.select_ThongTinPhieuXuat_BUS(PhieuXuatKho_GUI.maxuat);
            cbbMatHang.DataSource = tttk_BUS.show_DS_HangTon_DAO();
            cbbMatHang.DisplayMember = "tenHang";
            cbbMatHang.ValueMember = "maHang";

        }

        private void cbbMatHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cbbMatHang.SelectedValue!=null)
            {
                lblMaHangXuat.Text = cbbMatHang.SelectedValue.ToString();
                lblSoLuongTon.Text = tttk_BUS.select_SoLuong_TonKho_DAO(cbbMatHang.SelectedValue.ToString()).ToString();
            }
        }

        private void txtSoLuongXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
            txtSoLuongXuat.MaxLength = lblSoLuongTon.Text.Length;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtSoLuongXuat.Text=="")
            {
                MessageBox.Show("Vui lòng nhập số lượng hàng muốn xuất ");
            }    
            else
            {
                if(Convert.ToInt32(txtSoLuongXuat.Text)>Convert.ToInt32(lblSoLuongTon.Text) || (ttpx_BUS.select_SoLuong_ThongTinXuatKho_DAO(PhieuXuatKho_GUI.maxuat,lblMaHangXuat.Text)+Convert.ToInt32(txtSoLuongXuat.Text)) >Convert.ToInt32(lblSoLuongTon.Text))
                {
                    MessageBox.Show("Số lượng xuất không được phép vượt quá số lượng hàng tồn");
                }    
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận thêm hàng xuất", "Thông báo", MessageBoxButtons.YesNo);
                    if(rs==DialogResult.Yes)
                    {
                        if (ttpx_BUS.insert_ThongTinXuatKho_BUS(ttctpx()))
                        { 
                            MessageBox.Show("Thêm hàng xuất thành công");
                            ThongTinPhieuXuat_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    }    
                }    
            }    
        }

        private void dgvThongTinPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThongTinPhieuXuat.Rows[e.RowIndex];
                cbbMatHang.SelectedValue = r.Cells["maHang"].Value;
                txtSoLuongXuat.Text = r.Cells["soLuong"].Value.ToString();
                txtGhiChu.Text = r.Cells["ghiChu"].Value.ToString();
            }    
        }
    }
}
