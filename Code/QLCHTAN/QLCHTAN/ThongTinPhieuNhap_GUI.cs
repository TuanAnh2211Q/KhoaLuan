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
    public partial class ThongTinPhieuNhap_GUI : Form
    {
        ThongTinChiTietPhieuNhap_BUS thongTinChiTietPhieuNhap_BUS = new ThongTinChiTietPhieuNhap_BUS();
        public ThongTinPhieuNhap_GUI()
        {
            InitializeComponent();
        }
       
        private void ThongTinPhieuNhap_GUI_Load(object sender, EventArgs e)
        {
            lblThongTinPhieuNhap.Text = lblThongTinPhieuNhap.Text + " " + PhieuNhapKho_GUI.maNhapKho;
            dgvThongTinChiTietPhieuNhap.DataSource = thongTinChiTietPhieuNhap_BUS.dsThongTinChiTietPhieuNhap(PhieuNhapKho_GUI.maNhapKho);
            string tongGia = thongTinChiTietPhieuNhap_BUS.select_TongGiaNhap_DAO(PhieuNhapKho_GUI.maNhapKho).ToString();
            lblTongGiaNhap.Text =lblTongGiaNhap.Text+" "+tongGia +" " + "VNĐ";
        }

      

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
