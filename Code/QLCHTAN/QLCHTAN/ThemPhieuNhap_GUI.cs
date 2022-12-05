using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTAN
{
    public partial class ThemPhieuNhap_GUI : Form
    {
        public static string maNhapKho;
        public static DateTime ngayNhapKho;
        public static string maDatNhap;
        public static string ghiChuNhap;
        public ThemPhieuNhap_GUI()
        {
            InitializeComponent();
        }
       

        private void ThemPhieuNhap_GUI_Load(object sender, EventArgs e)
        {
            if(PhieuTra_GUI.maDat==null)
            {
                txtMaDat.Text = PhieuDatHang_GUI.maPhieuDat;
            }
            else
            {
                txtMaDat.Text = PhieuTra_GUI.maDat;
            }
        

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
           if(txtMaNhap.Text=="")
            {
                MessageBox.Show("Vui lòng nhập thông tin mã nhập");
            }
            else
            {
                maNhapKho = txtMaNhap.Text;
                ngayNhapKho = dtNgayNhap.Value;
                maDatNhap = txtMaDat.Text;
                ghiChuNhap = rtxtGhiChu.Text;
                tbThemPhieuNhap.SelectedTab = tbpThemChiTiet;
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            maNhapKho = null;
            ngayNhapKho = DateTime.Now;
            maDatNhap = null;
            ghiChuNhap = rtxtGhiChu.Text;
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            tbThemPhieuNhap.SelectedTab = tbpThemPhieuNhap;
        }

        private void ThemPhieuNhap_GUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            maNhapKho = null;
            ngayNhapKho = DateTime.Now;
            maDatNhap = null;
            ghiChuNhap = rtxtGhiChu.Text;
        }

   
      

        private void tbThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin mã nhập");
                tbThemPhieuNhap.SelectedTab = tbpThemPhieuNhap;
            }
        }


    }
}
