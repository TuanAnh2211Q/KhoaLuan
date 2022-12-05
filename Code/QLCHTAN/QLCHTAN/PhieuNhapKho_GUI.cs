using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Data.SqlClient;
namespace QLCHTAN
{
    public partial class PhieuNhapKho_GUI : Form
    {
        PhieuNhapKho_BUS phieuNhapKho_BUS = new PhieuNhapKho_BUS();
        public static string maNhapKho;
        public static bool trangThaiNhap;
        public PhieuNhapKho_GUI()
        {
            InitializeComponent();
        }
        public PhieuNhapKho_DTO phieuNhapKho_DTO()
        {
            return new PhieuNhapKho_DTO(txtMaNhap.Text.Trim(), dtNgayNhap.Value, txtMaDatHang.Text, txtGhiChu.Text,true);
        }
     

        private void PhieuNhapKho_GUI_Load(object sender, EventArgs e)
        {
            dgvPhieuNhap.DataSource = phieuNhapKho_BUS.dsPhieuNhap_BUS();
        }

        private void dgvPhieuNhap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvPhieuNhap.Rows[e.RowIndex];
                txtMaNhap.Text = r.Cells["maNhap"].Value.ToString();
                dtNgayNhap.Value = Convert.ToDateTime(r.Cells["ngayNhap"].Value.ToString());
                txtMaDatHang.Text = r.Cells["maDatHang"].Value.ToString();
                txtGhiChu.Text = r.Cells["ghiChu"].Value.ToString();
                txtMaNhap.Enabled = false;
                txtMaDatHang.Enabled = false;
                trangThaiNhap =Convert.ToBoolean( r.Cells["trangThai"].Value);
                lblTrangThai_TextChanged(sender, e);      
            }
             
                
        }

       

    
        private void txtMaNhap_TextChanged(object sender, EventArgs e)
        {
            maNhapKho = txtMaNhap.Text;
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void lblkThongTinChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(txtMaNhap.Text!="")
            {
               if(trangThaiNhap==false)
                {
                    MessageBox.Show("Phiếu nhập không có thông tin, vui lòng hủy phiếu để tạo lại");
                    return;
                }    
               else
                {
                    ThongTinPhieuNhap_GUI thongTinPhieuNhap_GUI = new ThongTinPhieuNhap_GUI();
                    thongTinPhieuNhap_GUI.Show();
                }    
            }    
            else
            {
                MessageBox.Show("Chọn phiếu nhập muốn xem thông tin");
            }

        }

        private void lblkHuyPhieuNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtMaNhap.Text != "")
            {
                if (trangThaiNhap == true)
                {
                    MessageBox.Show("Phiếu nhập đã hoàn thành, không thể xóa");
                    return;
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận xóa phiếu nhập ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        if (phieuNhapKho_BUS.delete_PhieuNhap(phieuNhapKho_DTO()))
                            MessageBox.Show("Xóa phiếu nhập thành công");
                        else
                            MessageBox.Show("Xóa phiếu nhập thất bại");
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn phiếu nhập cần xóa");
        }

        private void lblTrangThai_TextChanged(object sender, EventArgs e)
        {
            if (trangThaiNhap == true)
                lblTrangThai.Text = "Đã hoàn thành";
            else if (trangThaiNhap == false)
                lblTrangThai.Text = "Chưa hoàn thành";
            else
                lblTrangThai.Text = "..............................................................................";
        }
    }
}
