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
        ThongTinChiTietPhieuDatHang_BUS thongTinChiTietPhieuDatHang_BUS = new ThongTinChiTietPhieuDatHang_BUS();
        public static string maPhieuDat=null;
        public static bool trangThaiPhieu;
        public PhieuDatHang_GUI()
        {
            InitializeComponent();
        }
        public PhieuDatHang_DTO phieuDatHang_DTO()
        {
            return new PhieuDatHang_DTO(txtMaDat.Text.Trim(), dtNgayDat.Value, dtNgayDuKienGiao.Value, ccbPhuongThucThanhToan.Text.Trim(), txtGhiChu.Text,trangThaiPhieu);
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
                txtMaDat.Text = r.Cells["maDatHang"].Value.ToString();
                dtNgayDat.Value = Convert.ToDateTime( r.Cells["ngayDatHang"].Value.ToString());
                dtNgayDuKienGiao.Value = Convert.ToDateTime(r.Cells["ngayDuKienGiao"].Value.ToString());
                ccbPhuongThucThanhToan.Text = r.Cells["phuongThucThanhToan"].Value.ToString();
                txtGhiChu.Text = r.Cells["ghiChu"].Value.ToString();
                if(r.Cells["trangThai"].Value is true)
                {
                    lblTrangThai.Text = "Đã hoàn thành";
                    trangThaiPhieu = true;
                }    
                else
                {
                    lblTrangThai.Text = "Chưa hoàn thành";
                    trangThaiPhieu = false;
                }
                txtMaDat.Enabled = false;
            }
        }

        private void txtMaDat_TextChanged(object sender, EventArgs e)
        {
            maPhieuDat = txtMaDat.Text.Trim();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuDatHang_GUI_Load(sender, e);
            txtMaDat.Clear();
            dtNgayDat.Value = dtNgayDuKienGiao.Value = DateTime.Now;
            txtGhiChu.Clear();
            txtMaDat.Enabled = true;
            ccbPhuongThucThanhToan.SelectedIndex = 0;
            btnCapNhat.Enabled = true;
            btnHuyPhieuDat.Enabled = true;
            lblTrangThai.Text = "............................................................................";
            lblTrangThai.ForeColor = Color.Black;


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
                ThongTinPhieuDat_GUI thongTinChiTietPhieuDat_GUI = new ThongTinPhieuDat_GUI();
                thongTinChiTietPhieuDat_GUI.Show();
            }
        }

        private void btnHuyPhieuDat_Click(object sender, EventArgs e)
        {

            if (txtMaDat.Text != "")
            {
                  if(lblTrangThai.Text=="Đã hoàn thành")
                {
                    MessageBox.Show("Phiếu đặt đã hoàn thành, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }   
                  else
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


                        else
                        {
                            MessageBox.Show("Phiếu đặt không tồn tại, vui lòng kiểm tra lại thông tin");
                        }
                    }
                }    
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaDat.Text != "")
            {

                if (lblTrangThai.Text == "Đã hoàn thành")
                {
                    MessageBox.Show("Phiếu đặt đã hoàn thành, không thể chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
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
               
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void lblTrangThai_TextChanged(object sender, EventArgs e)
        {
            lblTrangThai.ForeColor = Color.Red;
        }

        private void lblkTaoPhieuTra_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtMaDat.Text!="")
            {
                PhieuTra_GUI phieuTra = new PhieuTra_GUI();
                phieuTra.Show();
            }    
            else
            {
                    MessageBox.Show("Vui lòng chọn đơn đặt muốn tạo phiếu trả");    
            }
        }

        private void lblkTaoPhieuNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtMaDat.Text=="")
            {
                MessageBox.Show("Vui lòng chọn phiếu đặt muốn lập phiếu nhập");
            }
            else
            {
                maPhieuDat = txtMaDat.Text;
                if (phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuTra(phieuDatHang_DTO()) != null)
                    PhieuTra_GUI.maPhieuTra = phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuTra(phieuDatHang_DTO());
                else
                {
                    if (thongTinChiTietPhieuDatHang_BUS.ds_SanPhamDat_BUS(maPhieuDat).Rows.Count <= 0)
                    {
                        MessageBox.Show("Không có thông tin lập phiếu nhập");
                        return;
                    }
                    else
                        PhieuTra_GUI.maPhieuTra = null;
                }
                
                ThemPhieuNhap_GUI themPhieuNhap = new ThemPhieuNhap_GUI();
                themPhieuNhap.Show();
            }    
        }

        private void PhieuDatHang_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            maDatHang = null;
        }

        private void btnThayDoiTrangThai_Click(object sender, EventArgs e)
        {
            if (txtMaDat.Text != "")
            {

                if (phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuTra(phieuDatHang_DTO())!=null||!phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuNhap(phieuDatHang_DTO()))
                {
                    MessageBox.Show("Phiếu đặt này đã được hoàn thiện, không thể thay đổi trạng thái", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
               
                else
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
                            DialogResult rs = MessageBox.Show("Xác nhận hoàn thành phiếu đặt ?", "Thông báo", MessageBoxButtons.YesNo);
                            if (rs == DialogResult.Yes)
                            {
                                if(trangThaiPhieu is false)
                                {
                                    trangThaiPhieu = true;
                                }
                                else
                                {
                                    trangThaiPhieu = false;
                                }
                                PhieuDatHang_DTO pd = new PhieuDatHang_DTO(txtMaDat.Text.Trim(), dtNgayDat.Value, dtNgayDuKienGiao.Value, ccbPhuongThucThanhToan.Text.Trim(), txtGhiChu.Text, trangThaiPhieu);

                                if (phieuDatHang_BUS.update_PhieuDat_BUS(pd))
                                {
                                    MessageBox.Show("Thành công");
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

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
