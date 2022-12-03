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
    public partial class Order_GUI : Form
    {
        KhachHang_BUS khachHang_BUS = new KhachHang_BUS();
        public string loaiDichVu { get; set; }
        public string GioiTinh { get; set; }
        public Order_GUI()
        {
            InitializeComponent();
        }
        #region Method
        public KhachHang_DTO khachHang_DTO()
        {
            return new KhachHang_DTO(cbbSDT.SelectedValue.ToString().Trim(), txtTenKhach.Text.Trim(), GioiTinh.Trim(), txtDiaChi.Text.Trim(), txtEmail.Text.Trim(), loaiDichVu.Trim(), rtxtGhiChu.Text.Trim()) ;
        }
        private void clearData(object sender,EventArgs e)
        {
            cbbSDT.DataSource = khachHang_BUS.show_dsKhachHang_BUS();
            cbbSDT.ValueMember = "SDT";
            cbbSDT.DisplayMember = "SDT";
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            rtxtGhiChu.Clear();
        }
        #endregion


        #region Event
        //private void cbbSDT_SelectedValueChanged(object sender, EventArgs e)
        //{
        //    cbbSDT.DataSource = khachHang_BUS.show_dsKhachHang_BUS();
        //    txtTenKhach.Text()=khachHang_DTO.
        //}
        private void Order_GUI_Load(object sender, EventArgs e)
        {
            clearData(sender,e);
        }
     
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            NhanVienThanhToan_GUI t = new NhanVienThanhToan_GUI();
            t.Show();
        }
        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNam.Checked)
            {
                GioiTinh = "Nam";
            }
        }

        private void rdbNu_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbNu.Checked)
            {
                GioiTinh = "Nữ";
            }
        }

        private void rdbAnTaiCho_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAnTaiCho.Checked)
            {
                loaiDichVu = "Ăn Tại Chổ";
            }
        }

        private void rdbMangVe_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbMangVe.Checked)
            {
                loaiDichVu = "Mang Về";
            }
        }

        private void rdbGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGiaoHang.Checked)
            {
                loaiDichVu = "Giao Hàng";
            }

        }

        private void cbbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtTenKhach_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        #endregion

       
    }
}
