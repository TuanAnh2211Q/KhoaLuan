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
        DoAn_BUS doAn_BUS = new DoAn_BUS();
        NuocUong_BUS nuocUong_BUS = new NuocUong_BUS();
        KhuyenMai_BUS khuyenMai_BUS = new KhuyenMai_BUS();
        public string loaiDichVu { get; set; }
        public decimal TongTien { get; set; }
        public decimal MucKhuyenMai { get; set; }


        //Khai báo truy vấn đơn hàng
        public static DataTable spOrder;

        public static string sdt;
        public static string tenKH;
        public static string diaChi;
        public static string email;
        public static string GioiTinh { get; set; }
        public static string maLoaiDon;
        public static bool htThanhToan;
        public static string maKM;
        public static string ghiChu;
        public static string tongGia;
        public static DataTable ttdh;
        

        public Order_GUI()
        {
            InitializeComponent();
        }
        #region Method
        public KhachHang_DTO khachHang_DTO()
        {
            return new KhachHang_DTO(cbbSDT.Text.ToString().Trim(), txtTenKhach.Text.Trim(), GioiTinh.Trim(), txtDiaChi.Text.Trim(), txtEmail.Text.Trim(), rtxtGhiChu.Text.Trim());
        }
        public bool ktra_MonAn()
        {
            for (int i = 0; i <= dgvThongTinDonHang.Rows.Count - 1; i++)
            {
                if ((dgvThongTinDonHang.Rows[i].Cells["tenMon"].Value == null)&&(dgvThongTinDonHang.Rows[i].Cells["donViBan"].Value==null))
                {
                    return false;
                }
                else if( (cbbTenMon.SelectedValue.ToString().Trim() == dgvThongTinDonHang.Rows[i].Cells["maSanPham"].Value.ToString().Trim())&&(cbbSizeDoAn.SelectedValue.ToString().Trim()==dgvThongTinDonHang.Rows[i].Cells["donViBan"].Value.ToString())) 

                {
                    return true;
                }
            }
            return false;
        }
        public bool ktra_Nuoc()
        {
            for (int i = 0; i <= dgvThongTinDonHang.Rows.Count - 1; i++)
            {

                if ((dgvThongTinDonHang.Rows[i].Cells["tenMon"].Value == null) && (dgvThongTinDonHang.Rows[i].Cells["donViBan"].Value == null))
                {
                    return false;
                }
                else if ((cbbTenNuoc.SelectedValue.ToString().Trim() == dgvThongTinDonHang.Rows[i].Cells["maSanPham"].Value.ToString().Trim())&&(txtSizeNuoc.Text.ToString().Trim() == dgvThongTinDonHang.Rows[i].Cells["donViBan"].Value.ToString()) )
                {
                    return true;
                }
            }
            return false;
        }
        private void clearData(object sender, EventArgs e)
        {
            cbbSDT.DataSource = khachHang_BUS.show_dsKhachHang_BUS();
            cbbSDT.ValueMember = "SDT";
            cbbSDT.DisplayMember = "SDT";
            cbbSDT.SelectedValue = -1;
            cbbSDT.Text = " ";
            txtTenKhach.Clear();
            txtDiaChi.Clear();
            txtEmail.Clear();
            rtxtGhiChu.Clear();
            rdbNam.Checked = false;
            rdbNu.Checked = false;
            rdbAnTaiCho.Checked = false;
            rdbGiaoHang.Checked = false;
            rdbMangVe.Checked = false;
            dgvThongTinDonHang.Rows.Clear();
            rdbNam.Enabled = true;
            txtTongTien.Clear();
            rdbOnline.Checked = false;
            rdbTienMat.Checked = false;
        }


        #endregion


        #region Event

        private void Order_GUI_Load(object sender, EventArgs e)
        {
            clearData(sender, e);
            ////load dữ liệu dồ ăn
            cbbDanhMucMon.DataSource = doAn_BUS.show_dsLoaiDoAn_BUS();
            cbbDanhMucMon.DisplayMember = "tenLoaiDoAn";
            cbbDanhMucMon.ValueMember = "maLoaiDoAn";
            cbbSDT.SelectedValue = -1;
            cbbSizeDoAn.DataSource = doAn_BUS.select_DonViBanDoAn_BUS();
            cbbSizeDoAn.DisplayMember = "donViBan";
            cbbSizeDoAn.ValueMember = "donViBan";
            rdbNam.Enabled = true;
            //load dữ liệu nước uống
            cbbTenNuoc.DataSource = nuocUong_BUS.show_dsNuocUong_BUS();
            cbbTenNuoc.DisplayMember = "tenNuoc";
            cbbTenNuoc.ValueMember = "maNuoc";
       
            //Load khuyến mãi
            cbbMaGiamGia.DataSource = khuyenMai_BUS.show_KM_BUS();
            cbbMaGiamGia.DisplayMember = "tenKhuyenMai";
            cbbMaGiamGia.ValueMember = "maKhuyenMai";
          
            

        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
           // Thêm thông tin khách hàng vào database
           if(cbbSDT.Text!=""&& txtTenKhach.Text!=""&&txtDiaChi.Text!=""&&GioiTinh!=null)
            {
                if(txtTongTien.Text!="")
                {
                    if(!rdbAnTaiCho.Checked &&!rdbGiaoHang.Checked &&!rdbMangVe.Checked)
                    {
                        MessageBox.Show("Vui lòng chọn hình thức dùng món", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                    else
                    {
                        if(!rdbTienMat.Checked&& !rdbOnline.Checked)
                        {
                            MessageBox.Show("Vui lòng chọn hình thức thanh toán", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                        else
                        {
                            sdt = cbbSDT.Text;
                            tenKH = txtTenKhach.Text;
                            diaChi = txtDiaChi.Text;
                            email = txtEmail.Text;
                            maLoaiDon = loaiDichVu;
                            ghiChu = rtxtGhiChu.Text;
                            if (cbbMaGiamGia.SelectedValue != null)
                            {
                                maKM = cbbMaGiamGia.SelectedValue.ToString();
                            }
                            else
                                maKM = null;
                            tongGia = txtTongTien.Text;
                            ttdh = new DataTable();
                            ttdh.Columns.Add("maSanPham");
                            ttdh.Columns.Add("tenSanPham");
                            ttdh.Columns.Add("soLuong");
                            ttdh.Columns.Add("donGia");
                            ttdh.Columns.Add("thanhTien");

                            foreach (DataGridViewRow r in dgvThongTinDonHang.Rows)
                            {
                                DataRow tr = ttdh.NewRow();
                                tr["maSanPham"] = r.Cells["maSanPham"].Value.ToString();
                                tr["tenSanPham"] = r.Cells["tenMon"].Value.ToString();
                                tr["soLuong"] = r.Cells["soLuong"].Value.ToString();
                                tr["donGia"] = r.Cells["donGia"].Value.ToString();
                                tr["thanhTien"] = r.Cells["thanhTien"].Value.ToString();
                                ttdh.Rows.Add(tr);
                            }    
                            NhanVienThanhToan_GUI t = new NhanVienThanhToan_GUI();
                            t.Show();

                        }
                      
                    }
                }    
               else
                {
                    MessageBox.Show("Vui lòng tổng kết tổng tiền", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }  
           else
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin khách hàng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }    
          
            
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
                loaiDichVu = "MLDH001";
            }
        }

        private void rdbMangVe_CheckedChanged(object sender, EventArgs e)
        {

            if (rdbMangVe.Checked)
            {
                loaiDichVu = "MLDH002";
            }
        }

        private void rdbGiaoHang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbGiaoHang.Checked)
            {
                loaiDichVu = "MLDH003";
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
        private void cbbSDT_SelectedValueChanged(object sender, EventArgs e)
        {

            if (cbbSDT.SelectedValue != null)
            {
                if (khachHang_BUS.find_KhachHang_BUS(cbbSDT.SelectedValue.ToString()) != null)
                {
                    DataTable tb = khachHang_BUS.find_KhachHang_BUS(cbbSDT.SelectedValue.ToString());
                    foreach (DataRow r in tb.Rows)
                    {
                        txtTenKhach.Text = r["tenKhachHang"].ToString();
                        if (r["Phai"].ToString().Trim() == "Nam")
                        {
                            rdbNam.Enabled = true;
                            rdbNam.Checked = true;
                            rdbNu.Enabled = false;
                        }
                        else
                        {
                            rdbNu.Enabled = true;
                            rdbNu.Checked = true;
                            rdbNam.Enabled = false;
                        }
                        txtDiaChi.Text = r["diaChi"].ToString();
                        txtEmail.Text = r["Email"].ToString();
                        rtxtGhiChu.Text = r["ghiChu"].ToString();
                    }
                }
            }


        }
        private void cbbDanhMucMon_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbDanhMucMon.SelectedValue != null)
            {
                string maloai = cbbDanhMucMon.SelectedValue.ToString().Trim();
                if (doAn_BUS.show_DSLoaiDoAn_BUS(maloai).Rows.Count > 0)
                {
                    cbbTenMon.DataSource = doAn_BUS.show_DSLoaiDoAn_BUS(maloai);
                    cbbTenMon.DisplayMember = "tenDoAn";
                    cbbTenMon.ValueMember = "maDoAn";
                }
                else
                {
                    cbbTenMon.DataSource = null;
                    cbbTenMon.Text = String.Empty;
                }
            }

        }


        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            clearData(sender, e);
        }
      
        private void btnThemMon_Click(object sender, EventArgs e)
        {
            string donViBan = cbbSizeDoAn.SelectedValue.ToString();
            string maSanPham = doAn_BUS.select_maSanPhamDoAn_BUS(cbbTenMon.SelectedValue.ToString());
            decimal donGia = doAn_BUS.select_donGia_BUS(maSanPham, donViBan);
            decimal thanhTien = nudSoLuongMon.Value * donGia;
            DialogResult them = MessageBox.Show("Bạn muốn thêm món ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (!ktra_MonAn())
                {
                    for (int i = dgvThongTinDonHang.Rows.Count + 1; ; i++)
                    {
                        i = dgvThongTinDonHang.Rows.Add();
                        DataGridViewRow r = dgvThongTinDonHang.Rows[i];
                        r.Cells["maSanPham"].Value = maSanPham.ToString();
                        r.Cells["tenMon"].Value = cbbTenMon.Text;
                        r.Cells["donViban"].Value = donViBan.ToString();
                        r.Cells["soLuong"].Value = nudSoLuongMon.Value.ToString();
                        r.Cells["donGia"].Value = donGia.ToString();
                        r.Cells["thanhTien"].Value = thanhTien.ToString() ;
                        break;
                    }
                }
                else
                {
                    for (int i = 0; i <= dgvThongTinDonHang.Rows.Count -1; i++)
                    {
                        if ((maSanPham.ToString() == dgvThongTinDonHang.Rows[i].Cells["maSanPham"].Value.ToString())&&(donViBan.ToString()==dgvThongTinDonHang.Rows[i].Cells["donViBan"].Value.ToString()))
                        {
                            dgvThongTinDonHang.Rows[i].Cells["soLuong"].Value = (Convert.ToInt32(dgvThongTinDonHang.Rows[i].Cells["soLuong"].Value) + Convert.ToInt32(nudSoLuongMon.Value)).ToString();
                            thanhTien = nudSoLuongMon.Value * donGia;
                            DataGridViewRow r = dgvThongTinDonHang.Rows[i];
                            r.Cells["thanhTien"].Value = (Convert.ToDecimal(r.Cells["thanhTien"].Value) +thanhTien).ToString();
                        }
                    }
                }
                
                thanhTien = 0;
                for (int i = 0; i <= dgvThongTinDonHang.Rows.Count - 1; i++)
                {
                    thanhTien += Convert.ToDecimal(dgvThongTinDonHang.Rows[i].Cells["thanhTien"].Value.ToString());
                }
                TongTien = Convert.ToDecimal(Convert.ToDecimal(thanhTien.ToString()));
                txtTongTien.Text = "";
            }
        }

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {
            string maSanPham = nuocUong_BUS.select_maSanPhamNuoc_BUS(cbbTenNuoc.SelectedValue.ToString());
            txtSizeNuoc.Text = nuocUong_BUS.select_DonViBanNuocUong_BUS(maSanPham);
            decimal donGia = nuocUong_BUS.selectselect_donGiaNuoc_BUS(maSanPham, txtSizeNuoc.Text);
            decimal thanhTien = nudSoLuongNuoc.Value * donGia;
            DialogResult them = MessageBox.Show("Bạn muốn thêm nước này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (!ktra_Nuoc())
                {
                    for (int i = dgvThongTinDonHang.Rows.Count + 1; ; i++)
                    {
                        i = dgvThongTinDonHang.Rows.Add();
                        DataGridViewRow r = dgvThongTinDonHang.Rows[i];
                        r.Cells["maSanPham"].Value = maSanPham.ToString();
                        r.Cells["tenMon"].Value = cbbTenNuoc.Text;
                        r.Cells["donViBan"].Value = txtSizeNuoc.Text;
                        r.Cells["soLuong"].Value = nudSoLuongNuoc.Value.ToString();
                        r.Cells["donGia"].Value = donGia.ToString();
                        r.Cells["thanhTien"].Value = thanhTien.ToString();
                        break;
                    }
                }
                else
                {
                    for (int i = 0; i <= dgvThongTinDonHang.Rows.Count - 1; i++)
                    {
                        if ((maSanPham.ToString() == dgvThongTinDonHang.Rows[i].Cells["maSanPham"].Value.ToString()) && (txtSizeNuoc.Text.ToString() == dgvThongTinDonHang.Rows[i].Cells["donViBan"].Value.ToString()))
                        {
                            dgvThongTinDonHang.Rows[i].Cells["soLuong"].Value = (Convert.ToInt32(dgvThongTinDonHang.Rows[i].Cells["soLuong"].Value) + Convert.ToInt32(nudSoLuongNuoc.Value)).ToString();
                            thanhTien = nudSoLuongNuoc.Value * donGia;
                            DataGridViewRow r = dgvThongTinDonHang.Rows[i];
                            r.Cells["thanhTien"].Value = r.Cells["thanhTien"].Value = (Convert.ToDecimal(r.Cells["thanhTien"].Value) + thanhTien).ToString();
                        }
                    }
                }
               
                thanhTien = 0;
                for (int i = 0; i <= dgvThongTinDonHang.Rows.Count - 1; i++)
                {
                    thanhTien += Convert.ToDecimal(dgvThongTinDonHang.Rows[i].Cells["thanhTien"].Value.ToString());
                }
                TongTien = Convert.ToDecimal(Convert.ToDecimal(thanhTien.ToString()));
                txtTongTien.Text = "";
            }
        }
        private void cbbTenNuoc_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbTenNuoc.SelectedValue != null)     
            {
                for (int i = 0; i <= nuocUong_BUS.show_dsNuocUong_BUS().Rows.Count-1; i++)
                {
                    DataRow r = nuocUong_BUS.show_dsNuocUong_BUS().Rows[i];
                    if (cbbTenNuoc.SelectedValue.ToString() == r.Field<string>("maNuoc"))
                    {
                        txtSizeNuoc.Text = r.Field<string>("donViBan");
                       
                        break;
                    }
                }
               
            }
            txtTongTien.Text = "";
        }

        private void btnXoaMon_Click_1(object sender, EventArgs e)
        {
           if(dgvThongTinDonHang.Rows.Count<=0)
            {
                MessageBox.Show("Không có sản phẩm xóa");
                return;
            }   
           else
                {
                DialogResult xoa = MessageBox.Show("Xác nhận xóa món ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    for (int i = 0; i <= dgvThongTinDonHang.Rows.Count; i++)
                    {
                        if(dgvThongTinDonHang.SelectedRows!=null && dgvThongTinDonHang.SelectedRows.Count>0)
                        {
                            DataGridViewRow r = dgvThongTinDonHang.SelectedRows[i];
                            TongTien = TongTien - Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                            dgvThongTinDonHang.Rows.RemoveAt(r.Index);
                            break;
                        }    
                        else
                        {
                            MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa");
                            break;
                        }

                    }
                   
                }
            }
            txtTongTien.Text = "";

        }
        private void btnXoaNuoc_Click(object sender, EventArgs e)
        {
            if (dgvThongTinDonHang.Rows.Count <= 0)
            {
                MessageBox.Show("Không có sản phẩm xóa");
                return;
            }
            else
            {
                DialogResult xoa = MessageBox.Show("Xác nhận xóa đồ uống này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (xoa == DialogResult.Yes)
                {
                    for (int i = 0; i <= dgvThongTinDonHang.Rows.Count; i++)
                    {
                        if (dgvThongTinDonHang.SelectedRows != null && dgvThongTinDonHang.SelectedRows.Count > 0)
                        {
                            DataGridViewRow r = dgvThongTinDonHang.SelectedRows[i];
                            TongTien = TongTien - Convert.ToDecimal(r.Cells["ThanhTien"].Value);
                            dgvThongTinDonHang.Rows.RemoveAt(r.Index);
                            break;
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa");
                            break;
                        }

                    }

                }
            }
            txtTongTien.Text = "";

        }

        #endregion

        private void rdbTienMat_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTienMat.Checked)
                htThanhToan = true;
        }

        private void rdbOnline_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbOnline.Checked)
                htThanhToan = false;
        }

       

        

        

        private void btnXemTongTien_Click(object sender, EventArgs e)
        {
            if (cbbMaGiamGia.SelectedValue != null )
            {
                decimal tongTienGiam =Convert.ToDecimal( TongTien) * khuyenMai_BUS.select_MucKhuyenMai_BUS(cbbMaGiamGia.SelectedValue.ToString());
                txtTongTien.Text = (Convert.ToInt32(Convert.ToDecimal(TongTien) - tongTienGiam)).ToString();
            }
            else
            {
                txtTongTien.Text = (Convert.ToInt32(Convert.ToDecimal(TongTien))).ToString();
            }
        }

        private void ckbKhongApDungKhuyenMai_CheckedChanged(object sender, EventArgs e)
        {
            if(ckbKhongApDungKhuyenMai.Checked)
            {
                cbbMaGiamGia.Enabled = false;
                cbbMaGiamGia.SelectedValue = 0;
            }
            else
            {
                cbbMaGiamGia.Enabled = true;
                cbbMaGiamGia.SelectedIndex = 0;
            }
            txtTongTien.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clearData(sender,e);
        }
    }
}