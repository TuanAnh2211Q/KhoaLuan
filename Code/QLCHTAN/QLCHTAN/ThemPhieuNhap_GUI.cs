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
namespace QLCHTAN
{
    public partial class ThemPhieuNhap_GUI : Form
    {
        public static string maNhapKho;
        public static DateTime ngayNhapKho;
        public static string maDatNhap;
        public static string ghiChuNhap;
        public static bool trangThai=false;
        ThongTinChiTietPhieuNhap_BUS thongTinChiTietPhieuNhap_BUS = new ThongTinChiTietPhieuNhap_BUS();
        PhieuNhapKho_BUS phieuNhapKho_BUS = new PhieuNhapKho_BUS();
        PhieuNhapKho_DTO phieuNhap_DTO()
        {
            return new PhieuNhapKho_DTO(maNhapKho, ngayNhapKho, maDatNhap, ghiChuNhap,trangThai);
        }
        
        public ThemPhieuNhap_GUI()
        {
            InitializeComponent();
        }
       

        private void ThemPhieuNhap_GUI_Load(object sender, EventArgs e)
        {
            dtNgayNhap.Value = DateTime.Today;
            if(PhieuDatHang_GUI.maPhieuDat==null)
            {
                txtMaDat.Text = PhieuTra_GUI.maDat;
            }
            else
            {
                txtMaDat.Text = PhieuDatHang_GUI.maPhieuDat;
            }

        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
           if(txtMaNhap.Text=="")
            {
                dgvThongTinChiTietPhieuNhap.DataSource = null;
                MessageBox.Show("Vui lòng nhập thông tin mã nhập");
            }
            else
            {
               if(phieuNhapKho_BUS.check_MaPhieu(txtMaNhap.Text)==false)
                {
                    maNhapKho = txtMaNhap.Text;
                    ngayNhapKho = dtNgayNhap.Value;
                    maDatNhap = txtMaDat.Text;
                    ghiChuNhap = rtxtGhiChu.Text;
                    tbThemPhieuNhap.SelectedTab = tbpThemChiTiet;
                    if (PhieuDatHang_GUI.maPhieuDat == null)
                    {
                        dgvThongTinChiTietPhieuNhap.DataSource = thongTinChiTietPhieuNhap_BUS.select_to_PhieuNhap_Temp(txtMaDat.Text, PhieuTra_GUI.maPhieuTra);
                    }
                    else
                    {
                        dgvThongTinChiTietPhieuNhap.DataSource = thongTinChiTietPhieuNhap_BUS.select_to_PhieuNhap_Temp(PhieuDatHang_GUI.maPhieuDat, PhieuTra_GUI.maPhieuTra);
                    }
                    if (dgvThongTinChiTietPhieuNhap.RowCount < 0)
                    {
                        MessageBox.Show("Không có thông tin nhập hàng");
                        return;
                    }
                }    
               else
                {
                    MessageBox.Show("Mã nhập đã tồn tại, vui lòng nhập lại");
                }    
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
            PhieuDatHang_GUI.maPhieuDat = null;
            PhieuTra_GUI.maPhieuTra = null;
        }

   
      

        private void tbThemPhieuNhap_Click(object sender, EventArgs e)
        {
            if (txtMaNhap.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin mã nhập");
                tbThemPhieuNhap.SelectedTab = tbpThemPhieuNhap;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
          if(phieuNhapKho_BUS.check_MaPhieu(txtMaNhap.Text))
            {
                MessageBox.Show("Mã phiếu nhập đã tồn tại vui lòng nhập mã khác");
            }
            else
            {
                DialogResult rs = MessageBox.Show("Xác nhận thêm phiếu nhập mới ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (phieuNhapKho_BUS.insert_PhieuNhap(phieuNhap_DTO()))
                    {
                        DataTable tb = (DataTable)dgvThongTinChiTietPhieuNhap.DataSource;
                        foreach (DataRow r in tb.Rows)
                        {
                            string maNhaCungCap = r.Field<string>("maNCC");
                            string maHangNhap = r.Field<string>("maHang");
                            int soLuongNhap = r.Field<int>("soLuongNhap");
                            decimal tongDGNhap = r.Field<decimal>("tongDonGia");
                            ThongTinChiTietPhieuNhap_DTO ttctpn = new ThongTinChiTietPhieuNhap_DTO(maNhapKho, maNhaCungCap, maHangNhap, soLuongNhap, tongDGNhap);
                            if (thongTinChiTietPhieuNhap_BUS.insert_ThongTinPhieuNhap_DAO(ttctpn))
                            {
                                trangThai = true;
                                phieuNhapKho_BUS.update_PhieuNhap(phieuNhap_DTO());
                            }
                            else
                                trangThai = false;
                        }
                        if (phieuNhapKho_BUS.check_PhieuNhap(maNhapKho))
                        {
                            MessageBox.Show("Xác nhận thêm phiếu nhập thành công");
                            this.Close();
                        }
                        else
                            MessageBox.Show("Xác nhận phiếu nhập thất bại");
                    }
                }
            }
        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ma = Convert.ToInt32(DateTime.Now.Day) + Convert.ToInt32(DateTime.Now.Month) + Convert.ToInt32(DateTime.Now.Year) + Convert.ToInt32(DateTime.Now.Hour) + Convert.ToInt32(DateTime.Now.Minute) + Convert.ToInt32(DateTime.Now.Millisecond) + rnd.Next(1, 1000);
            txtMaNhap.Text = "MN" + "_"+ma.ToString();
        }
    }
}
