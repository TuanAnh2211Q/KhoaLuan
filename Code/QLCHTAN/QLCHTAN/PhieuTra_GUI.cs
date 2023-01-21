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
    public partial class PhieuTra_GUI : Form
    {
        PhieuDatHang_BUS phieuDatHang_BUS = new PhieuDatHang_BUS();
        PhieuTra_BUS phieuTra_BUS = new PhieuTra_BUS();
        public static bool trangThaiTra;
        public static string maDat;
        public static string maTraHang;
        public static string maPhieuTra=null;
        public PhieuTra_DTO phieuTra()
        {
            if (cbbMaDat.SelectedValue != null)
            {
                return new PhieuTra_DTO(txtMaTra.Text.Trim(), cbbMaDat.SelectedValue.ToString().Trim(), dtNgayTra.Value, txtGhiChu.Text);
            }
            else
            {
                return new PhieuTra_DTO(txtMaTra.Text.Trim(), null, dtNgayTra.Value, txtGhiChu.Text);
            }
        }

        public bool kt_PhieuTra()
        {
            for (int i = 0; i <= dgvPhieuTra.Rows.Count - 1; i++)
            {
                if (txtMaTra.Text.Trim() == dgvPhieuTra.Rows[i].Cells["maTra"].Value.ToString().Trim())
                    return true;
            }
            return false;
        }
        public PhieuTra_GUI()
        {
            InitializeComponent();
        }

        private void PhieuTra_GUI_Load(object sender, EventArgs e)
        {
            if (cbbMaDat.SelectedValue!=null)
            {
              
                dtNgayTra.Value = Convert.ToDateTime(phieuTra_BUS.check_date_TraHang_DAO(phieuTra()));
            }
            dgvPhieuTra.DataSource = phieuTra_BUS.show_PhieuTra_BUS();
            cbbMaDat.DataSource = phieuDatHang_BUS.dsPhieuDatHang_BUS();
            cbbMaDat.DisplayMember = "maDatHang";
            cbbMaDat.ValueMember = "maDatHang";
            if(PhieuDatHang_GUI.maPhieuDat!=null)
            {
                cbbMaDat.SelectedValue = PhieuDatHang_GUI.maPhieuDat;
            }

        }

        private void btnThemPhieuTra_Click(object sender, EventArgs e)
        {
            if (txtMaTra.Text != "")
            {
                if (!kt_PhieuTra())
                {
                    long sp =dtNgayTra.Value.Subtract(Convert.ToDateTime(phieuTra_BUS.check_date_TraHang_DAO(phieuTra()))).Ticks;
                    if (sp < 0)
                    {
                        MessageBox.Show("Ngày lập phiếu trả phải lớn hơn ngày dự kiến giao của phiếu đặt \n" +
                            " (Ngày dự kiến giao của phiếu đặt này là " + Convert.ToDateTime(phieuTra_BUS.check_date_TraHang_DAO(phieuTra())).ToShortDateString() + ")");
                    }
                    else 
                    {
                        if (phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuNhap(cbbMaDat.SelectedValue.ToString()))
                        {
                            if (phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuTra(cbbMaDat.SelectedValue.ToString()) == null)
                            {
                                DialogResult rs = MessageBox.Show("Xác nhận thêm phiếu trả mới ?", "Thông báo", MessageBoxButtons.YesNo);
                                if (rs == DialogResult.Yes)
                                {
                                    if (phieuTra_BUS.insert_PhieuTra_BUS(phieuTra()))
                                    {
                                        MessageBox.Show("Thêm phiếu trả mới thành công");
                                        btnLamMoi_Click(sender, e);
                                    }
                                    else
                                        MessageBox.Show("Thêm phiếu trả thất bại, vui lòng kiểm tra lại thông tin");
                                }
                            }
                            else
                                MessageBox.Show("Không thể thêm phiếu trả do đã tồn tại phiếu trả hàng trên phiếu đặt này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }
                        else
                        {
                            MessageBox.Show("Phiếu đặt đã tồn tại nhập hàng tương ứng, không thể trả hàng");
                        }    

                    }
                   
                }
                else
                {
                    MessageBox.Show("Mã trả đã tồn tại vui lòng nhập mã khác");
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnHuyPhieuTra_Click(object sender, EventArgs e)
        {
            if (txtMaTra.Text != "")
            {
                if (lblTrangThai.Text == "Đã hoàn thành")
                {
                    MessageBox.Show("Phiếu trả đã hoàn thành, không thể xóa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (kt_PhieuTra())
                    {

                        DialogResult rs = MessageBox.Show("Xác nhận xóa phiếu trả ? ", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (phieuTra_BUS.delete_PhieuTra_BUS(phieuTra()))
                            {
                                MessageBox.Show("Xóa phiếu trả thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Phiếu trả còn sử dụng, không thể xóa");
                        }


                        else
                        {
                            MessageBox.Show("Phiếu trả không tồn tại, vui lòng kiểm tra lại thông tin");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaTra.Text != "")
            {

                if (lblTrangThai.Text == "Đã hoàn thành")
                {
                    MessageBox.Show("Phiếu trả đã hoàn thành, không thể chỉnh sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                else
                {
                    if (kt_PhieuTra())
                    {
                        long sp = dtNgayTra.Value.Subtract(Convert.ToDateTime(phieuTra_BUS.check_date_TraHang_DAO(phieuTra()))).Ticks;
                        if (sp < 0)
                        {
                            MessageBox.Show("Ngày lập phiếu trả phải lớn hơn ngày dự kiến giao của phiếu đặt \n" +
                           " (Ngày dự kiến giao của phiếu đặt này là " + Convert.ToDateTime(phieuTra_BUS.check_date_TraHang_DAO(phieuTra())).ToShortDateString() + ")");
                        }
                        else
                        {
                            DialogResult rs = MessageBox.Show("Xác nhận cập nhật phiếu đặt ?", "Thông báo", MessageBoxButtons.YesNo);
                            if (rs == DialogResult.Yes)
                            {
                                if (phieuTra_BUS.update_PhieuTra_BUS(phieuTra()))
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
                        MessageBox.Show("Phiếu trả không tồn tại, vui lòng kiểm tra lại thông tin");
                    }
                }

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            PhieuTra_GUI_Load(sender, e);
            txtMaTra.Text = "";
            txtMaTra.Enabled = true;
            cbbMaDat.Enabled = true;
        }

        private void dgvPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvPhieuTra.Rows[e.RowIndex];
                cbbMaDat.SelectedValue = r.Cells["maDatHang"].Value.ToString();
                dtNgayTra.Value = Convert.ToDateTime(r.Cells["ngayTra"].Value.ToString());
                txtGhiChu.Text = r.Cells["ghiChu"].Value.ToString();
                txtMaTra.Text= r.Cells["maTra"].Value.ToString();
                if (r.Cells["trangThai"].Value is true)
                {
                    trangThaiTra = true;
                    lblTrangThai.Text = "Đã hoàn thành";
                }
                else
                {
                    trangThaiTra = false;
                    lblTrangThai.Text = "Chưa hoàn thành";
                }
                txtMaTra.Enabled = false;
                cbbMaDat.Enabled = false;
            }
        }

        private void lblkThongTinPhieuDat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
          if(kt_PhieuTra())
            {
                if (txtMaTra.Text != "")
                {
                    maDat = cbbMaDat.SelectedValue.ToString();
                    maTraHang = txtMaTra.Text;
                    ThongTinPhieuTra_GUI thongTinPhieuTra = new ThongTinPhieuTra_GUI();
                    thongTinPhieuTra.Show();
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn phiếu trả");
                }
            }    
          else
            {
                MessageBox.Show("Phiếu trả chưa được tạo", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }    
        }

        private void lblkTaoPhieuNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (phieuDatHang_BUS.check_TrangThai_PhieuDat_PhieuNhap(cbbMaDat.SelectedValue.ToString()))
            {
                if (txtMaTra.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn phiếu trả muốn lập phiếu nhập");
                }
                else
                {
                    maDat = cbbMaDat.SelectedValue.ToString();
                    ThemPhieuNhap_GUI taoPhieuNhap = new ThemPhieuNhap_GUI();
                    taoPhieuNhap.Show();
                }
            }
            else
            {
                MessageBox.Show("Đã tồn tại phiếu nhập trên mã đặt hàng này");
            }

        }

        private void PhieuTra_GUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            maDat = null;
            maTraHang = null; 
        }

        private void lbkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            maPhieuTra = null;
            this.Close();
        }

        private void txtMaTra_TextChanged(object sender, EventArgs e)
        {
            maPhieuTra = txtMaTra.Text.Trim();
        }

        private void dtNgayTra_ValueChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ma = Convert.ToInt32(DateTime.Now.Day) + Convert.ToInt32(DateTime.Now.Month) + Convert.ToInt32(DateTime.Now.Year) + Convert.ToInt32(DateTime.Now.Hour) + Convert.ToInt32(DateTime.Now.Minute) + Convert.ToInt32(DateTime.Now.Millisecond) + rnd.Next(1, 1000);
            txtMaTra.Text = "MT" + "_" + ma.ToString();
        }
    }
}
