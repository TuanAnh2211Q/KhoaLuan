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
    public partial class ThemPhieuXuat_GUI : Form
    {
        ThongTinTonKho_BUS tttk = new ThongTinTonKho_BUS();
        MatHang_BUS matHang = new MatHang_BUS();
        PhieuXuat_BUS phieuXuat = new PhieuXuat_BUS();
        ThongTinPhieuXuat_BUS thongTinPhieuXuat = new ThongTinPhieuXuat_BUS();
        public PhieuXuat_DTO phieuXuat_DTO()
        {

            return new PhieuXuat_DTO(txtMaXuat.Text.Trim(), dtNgayXuat.Value,false);
        }

        public ThemPhieuXuat_GUI()
        {
            InitializeComponent();
        }
        public bool kt_PhieuXuat()
        {
            for(int i=0;i<=dgvPhieuXuat.Rows.Count-1;i++)
            {
                if(lblMaHang.Text==dgvPhieuXuat.Rows[i].Cells["maHang"].Value.ToString())
                {
                    return true;
                }
            }
            return false;
        }
        private void ThemPhieuXuat_GUI_Load(object sender, EventArgs e)
        {
            dtNgayXuat.Value = DateTime.Today;
            cbbMatHang.DataSource = tttk.show_DS_HangTon_DAO();
            cbbMatHang.DisplayMember = "tenHang";
            cbbMatHang.ValueMember = "maHang";
        }

        private void dtNgayNhap_ValueChanged(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int ma = Convert.ToInt32(DateTime.Now.Day)+Convert.ToInt32(DateTime.Now.Month)+Convert.ToInt32(DateTime.Now.Year)+Convert.ToInt32(DateTime.Now.Hour)+Convert.ToInt32(DateTime.Now.Minute)+Convert.ToInt32(DateTime.Now.Millisecond)+rnd.Next(1,1000);
            txtMaXuat.Text = "MX" + "_" + ma.ToString();
        }

        private void cbbMatHang_SelectedValueChanged(object sender, EventArgs e)
        {
            lblMaHang.Text = cbbMatHang.SelectedValue.ToString();
            lblSoLuongTon.Text = tttk.select_SoLuong_TonKho_DAO(cbbMatHang.SelectedValue.ToString()).ToString();
        }

        private void txtSoLuongXuat_Leave(object sender, EventArgs e)
        {
            if(txtSoLuongXuat.Text=="0")
            {
                MessageBox.Show("Số lượng xuất phải lớn hơn 0");
            }
            if (Convert.ToInt32(txtSoLuongXuat.Text )> Convert.ToInt32(lblSoLuongTon.Text))
            {
                MessageBox.Show("Số lượng xuất không vượt quá số lượng tồn trong kho");
                txtSoLuongXuat.Text = lblSoLuongTon.Text;
            }
        }

        private void btnThemMatHangXuat_Click(object sender, EventArgs e)
        {
           if(Convert.ToInt32(txtSoLuongXuat.Text)<=0)
            {
                MessageBox.Show("Số lượng xuất không được phép nhỏ hơn 0");
                txtSoLuongXuat.Text = "0";
                return;
            }
            else
            {
                if (Convert.ToInt32(lblSoLuongTon.Text) < Convert.ToInt32(txtSoLuongXuat.Text))
                {
                    MessageBox.Show("Số lượng xuất không vượt quá số lượng tồn trong kho");
                }
                else
                {
                    if (Convert.ToInt32(lblSoLuongTon.Text) > 0)
                    {
                        if (kt_PhieuXuat())
                        {
                            for (int i = 0; i <= dgvPhieuXuat.Rows.Count - 1; i++)
                            {
                                if (lblMaHang.Text == dgvPhieuXuat.Rows[i].Cells["maHang"].Value.ToString())
                                {
                                    int soLuongCbiXuat = Convert.ToInt32(dgvPhieuXuat.Rows[i].Cells["soLuong"].Value);
                                    int soLuongXuat = Convert.ToInt32(txtSoLuongXuat.Text);
                                    if (soLuongXuat + soLuongCbiXuat > tttk.select_SoLuong_TonKho_DAO(lblMaHang.Text))
                                    {
                                        MessageBox.Show("Số lượng hàng xuất không được vượt quá hàng tồn");
                                        break;
                                    }
                                    else

                                    {
                                        dgvPhieuXuat.Rows[i].Cells["soLuong"].Value = (soLuongXuat + soLuongCbiXuat).ToString();
                                    }
                                    break;

                                }
                            }
                        }
                        else
                        {
                            decimal tongGia = Convert.ToInt32(txtSoLuongXuat.Text) * matHang.select_DonGia_MatHang(lblMaHang.Text);
                            for (int i = dgvPhieuXuat.Rows.Count + 1; ; i++)
                            {
                                i = dgvPhieuXuat.Rows.Add();
                                DataGridViewRow r = dgvPhieuXuat.Rows[i];
                                r.Cells["maXuat"].Value = txtMaXuat.Text;
                                r.Cells["maHang"].Value = lblMaHang.Text;
                                r.Cells["tenHang"].Value = cbbMatHang.Text;
                                r.Cells["soLuong"].Value = txtSoLuongXuat.Text.ToString();
                                r.Cells["ghiChu"].Value = txtGhiChu.Text;
                                r.Cells["tongDonGia"].Value = tongGia.ToString();
                                break;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng tồn không đủ để xuất hàng", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
                   if(Convert.ToInt32(txtSoLuongXuat.Text)<0)
            {
                 MessageBox.Show("Số lượng xuất không được phép nhỏ hơn 0");
                txtSoLuongXuat.Text = "0";
                return;

            }
                   else

            {
                if (kt_PhieuXuat())
                {
                    for (int i = 0; i <= dgvPhieuXuat.Rows.Count - 1; i++)
                    {
                        if (lblMaHang.Text == dgvPhieuXuat.Rows[i].Cells["maHang"].Value.ToString())
                        {
                            if (tttk.select_SoLuong_TonKho_DAO(lblMaHang.Text) < (Convert.ToInt32(txtSoLuongXuat.Text)))
                            {
                                MessageBox.Show("Hàng xuất không được lớn hơn hàng tồn kho");
                                break;
                            }
                            else
                            {
                                decimal tongGia = Convert.ToInt32(txtSoLuongXuat.Text) * matHang.select_DonGia_MatHang(lblMaHang.Text);
                                DataGridViewRow r = dgvPhieuXuat.Rows[i];
                                r.Cells["maXuat"].Value = txtMaXuat.Text;
                                r.Cells["maHang"].Value = lblMaHang.Text;
                                r.Cells["tenHang"].Value = cbbMatHang.Text;
                                r.Cells["soLuong"].Value = txtSoLuongXuat.Text.ToString();
                                r.Cells["ghiChu"].Value = txtGhiChu.Text;
                                r.Cells["tongDonGia"].Value = tongGia.ToString();
                                break;
                            }
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Mặt hàng muốn sửa không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

            }

        }

        private void txtSoLuongXuat_KeyPress(object sender, KeyPressEventArgs e)
        {
            txtSoLuongXuat.MaxLength = lblSoLuongTon.Text.Length;
            if(!char.IsNumber(e.KeyChar)&&!char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }    
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
           if(txtMaXuat.Text=="")
            {
                MessageBox.Show("Vui lòng nhập mã xuất");
            }    
           else if(dtNgayXuat.Value<DateTime.Today)
            {
                MessageBox.Show("Ngày xuất không được nhỏ hơn ngày hiện tại");
            }    
           else if(dgvPhieuXuat.Rows.Count<=0)
            {
                MessageBox.Show("Vui lòng chọn mặt hàng muốn xuất kho");
            }    
           else
            {
                string maxuat = txtMaXuat.Text;
                if (phieuXuat.check_MaXuat_BUS(maxuat))
                {
                    MessageBox.Show("Mã xuất đã tồn tại, vui lòng nhập mã khác");
                    return;
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận thêm phiếu xuất ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        if (phieuXuat.insert_PhieuXuat_BUS(phieuXuat_DTO()))
                        {
                          
                            foreach (DataGridViewRow r in dgvPhieuXuat.Rows)
                            {
                                string mahang = r.Cells["maHang"].Value.ToString();
                                int soluong = Convert.ToInt32(r.Cells["soLuong"].Value);
                                string ghichu = r.Cells["ghiChu"].Value.ToString();
                                decimal tongdongia = Convert.ToDecimal(r.Cells["tongDonGia"].Value);
                                ThongTinPhieuXuat_DTO ttpx_dto = new ThongTinPhieuXuat_DTO(maxuat, mahang, soluong, ghichu, tongdongia);
                                thongTinPhieuXuat.insert_ThongTinXuatKho_BUS(ttpx_dto);
                            }
                        }
                        if (thongTinPhieuXuat.check_ThongTinXuatKho_BUS(maxuat))
                        {
                            MessageBox.Show("Thêm phiếu xuất thành công");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Thêm phiếu xuất thất bại");
                        }
                    }
                }

            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
