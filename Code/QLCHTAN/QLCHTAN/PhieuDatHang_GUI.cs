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
using BUS;
using DTO;
namespace QLCHTAN
{
    public partial class PhieuDatHang_GUI : Form
    {
        PhieuDatHang_BUS phieuDatHang_BUS = new PhieuDatHang_BUS();
        public static string maPhieuDat;
        public PhieuDatHang_GUI()
        {
            InitializeComponent();
        }
        public PhieuDatHang_DTO phieuDatHang_DTO()
        {
            return new PhieuDatHang_DTO(txtMaDat.Text.Trim(), dtNgayDat.Value, dtNgayDuKienGiao.Value, ccbPhuongThucThanhToan.Text.Trim(), txtGhiChu.Text);
        }
        public bool kt_Dondat()
        {
            for(int i=0;i<=dgvPhieuDat.Rows.Count-1;i++)
            {
                if (txtMaDat.Text.Trim() == dgvPhieuDat.Rows[i].Cells["maDatHang"].Value.ToString().Trim())
                    return true;
            }
            return false;
        }
       

        private void PhieuDatHang_GUI_Load(object sender, EventArgs e)
        {
            dgvPhieuDat.DataSource = phieuDatHang_BUS.dsPhieuDatHang_BUS();
            ccbPhuongThucThanhToan.SelectedIndex = 0;
        }

        private void dgvPhieuDat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvPhieuDat.Rows[e.RowIndex];
                txtMaDat.Text = r.Cells[0].Value.ToString();
                dtNgayDat.Value = Convert.ToDateTime( r.Cells[1].Value.ToString());
                dtNgayDuKienGiao.Value = Convert.ToDateTime(r.Cells[2].Value.ToString());
                ccbPhuongThucThanhToan.Text = r.Cells[3].Value.ToString();
                txtGhiChu.Text = r.Cells[4].Value.ToString();
                txtMaDat.Enabled = false;
            }    
        }

        private void txtMaDat_TextChanged(object sender, EventArgs e)
        {
            maPhieuDat = txtMaDat.Text;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuDatHang_GUI_Load(sender, e);
            txtMaDat.Clear();
            dtNgayDat.Value = dtNgayDuKienGiao.Value = DateTime.Now;
            txtGhiChu.Clear();
            txtMaDat.Enabled = true;
            ccbPhuongThucThanhToan.SelectedIndex = 0;
        }

        private void btnThemPhieuDat_Click(object sender, EventArgs e)
        {
            if (txtMaDat.Text != "")
            {
                if (!kt_Dondat())
                {
                    long sp = dtNgayDuKienGiao.Value.Subtract(dtNgayDat.Value).Ticks;
                    if (sp < 0)
                    {
                        MessageBox.Show("Ngày dự kiến giao không được nhỏ hơn ngày đặt");
                    }
                    else
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận thêm phiếu đặt mới ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (phieuDatHang_BUS.insert_PhieuDat_BUS(phieuDatHang_DTO()))
                            {
                                MessageBox.Show("Thêm phiếu đặt mới thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Thêm phiếu đặt thất bại, vui lòng kiểm tra lại thông tin");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Mã đặt đã tồn tại vui lòng nhập mã khác");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void lblkThongTinPhieuDat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaDat.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn phiếu nhập muốn xem thông tin");
                return;
            }
            else
            {
                ThongTinChiTietPhieuDat_GUI thongTinChiTietPhieuDat_GUI = new ThongTinChiTietPhieuDat_GUI();
                thongTinChiTietPhieuDat_GUI.Show();
            }
        }

        private void btnHuyPhieuDat_Click(object sender, EventArgs e)
        {

            if (txtMaDat.Text != "")
            {
                if (kt_Dondat())
                {
                    
                        DialogResult rs = MessageBox.Show("Xác nhận xóa phiếu đặt ? ", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (phieuDatHang_BUS.delete_PhieuDat_BUS(phieuDatHang_DTO()))
                            {
                                MessageBox.Show("Xóa phiếu đặt thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Phiếu đặt còn sử dụng, không thể xóa");
                        }
                   
                }
                else
                {
                    MessageBox.Show("Phiếu đặt không tồn tại, vui lòng kiểm tra lại thông tin");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMaDat.Text != "")
            {
                if (kt_Dondat())
                {
                    long sp = dtNgayDuKienGiao.Value.Subtract(dtNgayDat.Value).Ticks;
                    if (sp < 0)
                    {
                        MessageBox.Show("Ngày dự kiến giao không được nhỏ hơn ngày đặt");
                    }
                    else
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận cập nhật phiếu đặt ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (phieuDatHang_BUS.update_PhieuDat_BUS(phieuDatHang_DTO()))
                            {
                                MessageBox.Show("Cập nhật thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Cập nhật thất bại, vui lòng kiểm tra lại thông tin");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Phiếu đặt không tồn tại, vui lòng kiểm tra lại thông tin");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }
    }
}
