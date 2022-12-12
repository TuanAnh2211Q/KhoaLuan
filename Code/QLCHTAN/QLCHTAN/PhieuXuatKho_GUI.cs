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
    public partial class PhieuXuatKho_GUI : Form
    {
        ThongTinPhieuXuat_BUS ttpx_BUS = new ThongTinPhieuXuat_BUS();
        ThongTinTonKho_BUS tttk_BUS = new ThongTinTonKho_BUS();
        PhieuXuat_BUS phieuXuat_BUS = new PhieuXuat_BUS();
        public static bool tt;
        public static string maxuat=null;
        public PhieuXuatKho_GUI()
        {
            InitializeComponent();
        }
        public PhieuXuat_DTO phieuxuat_DTO()
        {
            return new PhieuXuat_DTO(txtMaXuat.Text, dtNgayNhap.Value, tt);
        }

        private void lblkThongTinChiTiet_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           if(txtMaXuat.Text=="")
            {
                MessageBox.Show("Vui lòng chọn phiếu xuất muốn xem thông tin");
            }    
           else
            {
                maxuat = txtMaXuat.Text;
                ThongTinPhieuXuat_GUI ttpx = new ThongTinPhieuXuat_GUI();
                ttpx.Show();
            }    
        }

        private void PhieuXuatKho_GUI_Load(object sender, EventArgs e)
        {
            dgvPhieuXuat.DataSource = phieuXuat_BUS.select_PhieuXuat_BUS(); 
        }

        private void dgvPhieuXuat_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvPhieuXuat.Rows[e.RowIndex];
                txtMaXuat.Text = r.Cells["maXuatt"].Value.ToString();
                dtNgayNhap.Value =Convert.ToDateTime( r.Cells["ngayXuat"].Value);
                if(r.Cells["trangThai"].Value is true)
                {
                    tt = true;
                    lblTrangThai.Text = "Đã hoàn thành";
                }    
                else
                {
                    tt = false;
                    lblTrangThai.Text = "Chưa hoàn thành";
                }    


            }    
        }

        private void lblkDuyetPhieuXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(tt is true)
            {
                MessageBox.Show("Phiếu xuất này đã hoàn thành, không thể duyệt lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.None);
            }    
            else
            {
                if(txtMaXuat.Text==""||txtMaXuat.Text==null)
                {
                    MessageBox.Show("Vui lòng chọn phiếu xuất ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận hoàn thành phiếu xuất ?", "Thông báo", MessageBoxButtons.YesNo);
                    if(rs==DialogResult.Yes)
                    {
                         for (int i=0;i<=ttpx_BUS.select_ThongTinPhieuXuat_BUS(txtMaXuat.Text).Rows.Count-1; i++)
                        {
                            DataRow r = ttpx_BUS.select_ThongTinPhieuXuat_BUS(txtMaXuat.Text).Rows[i];

                            string mahang = r.Field<string>("maHang");
                            int slxuat = r.Field<int>("soLuong");
                            int slton = tttk_BUS.select_SoLuong_TonKho_DAO(mahang);
                            if (slxuat > slton)
                            {
                                MessageBox.Show("Không thể xuất vì số lượng hàng tồn không đủ");
                                return;
                            }
                        }    

                        if (phieuXuat_BUS.update_PhieuXuat_BUS(txtMaXuat.Text))
                            MessageBox.Show("Duyệt thành công");
                        PhieuXuatKho_GUI_Load(sender, e);
                    }    
                }    
            }    
        }

        private void lblkHuyPhieuXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(tt is true)
            {
                MessageBox.Show("Phiếu xuất đã hoàn thành, không thể xóa");
            }    
            else
            {
                if(txtMaXuat.Text=="")
                {
                    MessageBox.Show("Chọn phiếu xuất muốn hủy");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận xóa toàn bộ phiếu xuất ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
                    if (rs == DialogResult.Yes)
                    {
                        if (phieuXuat_BUS.delete_PhieuXuat_DAO(phieuxuat_DTO()))
                        {
                            MessageBox.Show("Hủy phiếu xuất thành công");
                            PhieuXuatKho_GUI_Load(sender, e);
                        }
                        else
                            MessageBox.Show("Hủy phiếu xuất thất bại");

                    }
                }    
            }    
        }
    }
}
