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
    public partial class ThongTinDonHang_GUI : Form
    {
        public string gioiTinhKhach = Order_GUI.GioiTinh;
        public string diaChiKhach = Order_GUI.diaChi;
        public string emailKhach = Order_GUI.email;
        public int ttd = 0;
        KhachHang_BUS khachhang_BUS = new KhachHang_BUS();
        DonHang_BUS donhang_BUS = new DonHang_BUS();
        KhuyenMai_BUS khuyenMai_BUS = new KhuyenMai_BUS();
        NhanVien_BUS nhanVien_BUS = new NhanVien_BUS();
        ThongTinDonHang_BUS ttdh_BUS = new ThongTinDonHang_BUS();
        public KhachHang_DTO khachhang_DTO()
        {
            return new KhachHang_DTO(lblSDT.Text.Trim(), lblKhachHang.Text.Trim(), gioiTinhKhach.Trim(), diaChiKhach.Trim(), emailKhach.Trim(), txtGhiChu.Text.Trim());
        }
        public DonHang_DTO donHang_DTO()
        {
            string km = "";
            if (Order_GUI.maKM.Trim() is null)
            {
                km = "Null";
            }
            else
            {
                km = Order_GUI.maKM.Trim();
            }    
            return new DonHang_DTO(lblMaDonHang.Text.Trim(), lblTenDonHang.Text.Trim(), Order_GUI.maLoaiDon.Trim(), Order_GUI.htThanhToan, NhanVienThanhToan_GUI.maNVTT.Trim(), lblSDT.Text.Trim(), km.Trim(), DateTime.Today, 1, txtGhiChu.Text.Trim(),khachhang_BUS.select_id_KhachHang_BUS(lblSDT.Text.Trim()), Convert.ToDecimal(lblTongDonGia.Text));
        }
        public ThongTinDonHang_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinDonHang_GUI_Load(object sender, EventArgs e)
        {
            //Random mã đơn hàng dựa vào thời gian trong ngày
            Random rnd = new Random();
            int ma = Convert.ToInt32(DateTime.Now.Day) + Convert.ToInt32(DateTime.Now.Month) + Convert.ToInt32(DateTime.Now.Year) + Convert.ToInt32(DateTime.Now.Hour) + Convert.ToInt32(DateTime.Now.Minute) + Convert.ToInt32(DateTime.Now.Millisecond) + rnd.Next(1, 1000);

            lblNhanVien.Text = nhanVien_BUS.select_TenNhanVien_BUS(NhanVienThanhToan_GUI.maNVTT);
            lblMaDonHang.Text = "MHD" + ma;
            lblTenDonHang.Text = "Đơn hàng ngày " + DateTime.Now;
            lblLoaiDon.Text = donhang_BUS.select_TenLoaiDon_BUS(Order_GUI.maLoaiDon);
            if(Order_GUI.htThanhToan is true)
            {
                lblThanhToan.Text = "Tiền mặt";
            }    
            else
            {
                lblThanhToan.Text = "Chuyển khoản";
            }
            lblNhanVien.Text = nhanVien_BUS.select_TenNhanVien_BUS(NhanVienThanhToan_GUI.maNVTT);
            lblKhachHang.Text = Order_GUI.tenKH;
            lblSDT.Text = Order_GUI.sdt;
            lblDiaChi.Text = Order_GUI.diaChi;
            txtGhiChu.Text = Order_GUI.ghiChu;
            if(Order_GUI.maKM==null)
            {
                lblKhuyenMai.Text = "Không áp dụng khuyến mãi";
            }    
            else
            {
                lblKhuyenMai.Text = khuyenMai_BUS.select_TenKhuyenMai_BUS(Order_GUI.maKM) + "(" + khuyenMai_BUS.select_MucKhuyenMai_BUS(Order_GUI.maKM) + "%)";
            }
            lblThoiGian.Text = DateTime.Now.ToString();
            lblTrangThai.Text = "Chưa thanh toán";
            lblTongDonGia.Text =Order_GUI.tongGia ;
            dgvThongTinHoaDon.DataSource = Order_GUI.ttdh;



        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Xác nhận thanh toán hóa đơn " + lblMaDonHang.Text + "", "Thông báo", MessageBoxButtons.YesNo);
            if (rs == DialogResult.Yes)
            {
                if (khachhang_BUS.insert_KhachHang_BUS(khachhang_DTO()))
                {
                    if(donhang_BUS.insert_DonHang_BUS(donHang_DTO()))
                    {
                        foreach(DataRow r in Order_GUI.ttdh.Rows)
                        {
                            string masp = r.Field<string>("maSanPham");
                            string giatien = r.Field<string>("donGia");
                            string soluong = r.Field<string>("soLuong");
                            string thanhtien = r.Field<string>("thanhTien");
                            ThongTinDonHang_DTO ttdh_DTO = new ThongTinDonHang_DTO(lblMaDonHang.Text, masp,Convert.ToDecimal(giatien),Convert.ToInt32( soluong), Convert.ToDecimal(thanhtien));
                            try
                            {
                                if (!ttdh_BUS.insert_ThongTinDonHang_BUS(ttdh_DTO))
                                {
                                    MessageBox.Show("Thêm thất bại");
                                    return;
                                }
                            }
                            catch (Exception)
                            {

                                throw;
                            }  
                        }
                        MessageBox.Show("Hoàn tất đơn hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }    
                }
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            NhanVienThanhToan_GUI nvtt = new NhanVienThanhToan_GUI();
            nvtt.Show();
            this.Close();
            this.Dispose();
        }

       
    }
}
