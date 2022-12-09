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
        PhieuXuat_BUS phieuXuat_BUS = new PhieuXuat_BUS();
        public bool tt;
        public static string maxuat=null;
        public PhieuXuatKho_GUI()
        {
            InitializeComponent();
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
                txtMaXuat.Text = r.Cells["maXuat"].Value.ToString();
                dtNgayNhap.Value =Convert.ToDateTime( r.Cells["ngayXuat"].Value);
                if(r.Cells["trangThai"].Value is true)
                {
                    tt = true;
                    lblTrangThai.Text = "Đã duỵệt";
                }    
                else
                {
                    tt = false;
                    lblTrangThai.Text = "Chưa duyệt";
                }    


            }    
        }
    }
}
