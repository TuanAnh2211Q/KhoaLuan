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
    public partial class ThongTinPhieuTra_GUI : Form
    {
        ThongTinChiTietPhieuDatHang_BUS ttctpd = new ThongTinChiTietPhieuDatHang_BUS();
        ThongTinPhieuTra_BUS ttpt = new ThongTinPhieuTra_BUS();
        public object mahang=null;
        public bool kiemtra_MatHangTra()
        {
            foreach (DataGridViewRow r in dgvThongTinPhieuTra.Rows)
            {
                if (cbbMatHang.SelectedValue.ToString().Trim() == r.Cells["maHang"].Value.ToString().Trim())
                    return true;
            }
            return false;

        }
        public ThongTinPhieuTra_DTO thongtinphieuTra_DTO()
        {
            return new ThongTinPhieuTra_DTO(txtMaTra.Text.Trim(), lblMaHangNhap.Text.Trim(), Convert.ToInt32(txtSoLuong.Text));
        }
        public ThongTinPhieuTra_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinPhieuTra_GUI_Load(object sender, EventArgs e)
        {
            txtMaDatHang.Text = PhieuTra_GUI.maDat;
            txtMaTra.Text = PhieuTra_GUI.maTraHang;
            dgvThongTinPhieuTra.DataSource = ttpt.ds_SanPhamTra_BUS(txtMaTra.Text);
          
            cbbMatHang.DataSource = ttctpd.ds_SanPhamDat_BUS(txtMaDatHang.Text);
            cbbMatHang.DisplayMember = "tenHang";
            cbbMatHang.ValueMember = "maHang";            
            if(cbbMatHang.SelectedValue!=null)
            {
                lblMaHangNhap.Text = cbbMatHang.SelectedValue.ToString();
            }
            else
            {
                DialogResult rs = MessageBox.Show("Không có mặt hàng nào trong phiếu đặt để thực hiện đổi trả", "Thông báo", MessageBoxButtons.OK);
                this.Close();
            }    
            lblTongGia.Text = ttpt.tongGia_PhieuTra_BUS(txtMaTra.Text);
            txtSoLuong.Clear();
        }



        private void cbbMatHang_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbbMatHang.SelectedValue!=null)
            {
                lblMaHangNhap.Text = cbbMatHang.SelectedValue.ToString();
                lblSoLuongDat.Text = ttpt.select_SoLuongDat_DAO(txtMaDatHang.Text, lblMaHangNhap.Text);
                txtSoLuong.Text = lblSoLuongDat.Text;
            }    
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtSoLuong.Text != "")
            {
               if((Convert.ToInt32(txtSoLuong.Text)>Convert.ToInt32(lblSoLuongDat.Text)) ||(((Convert.ToInt32(txtSoLuong.Text)+ttpt.soLuong_hangTra(thongtinphieuTra_DTO())> Convert.ToInt32(lblSoLuongDat.Text)))))
                {
                    MessageBox.Show("Số lượng trả không được vượt quá số lượng đặt");
                }   
               else if(Convert.ToInt32(txtSoLuong.Text) < 0)
                {
                    MessageBox.Show("Số lượng trả không được nhỏ hơn 0");
                }
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận thêm mặt hàng vào phiếu trả ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        if (ttpt.insert_ThongTinPhieuTra(thongtinphieuTra_DTO()))
                        {
                            MessageBox.Show("Thêm mặt hàng thành công");
                            ThongTinPhieuTra_GUI_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                        }

                    }
                }    
            }
            else
                MessageBox.Show("Vui lòng nhập số lượng hàng thêm");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (kiemtra_MatHangTra())
            {
                DialogResult rs = MessageBox.Show("Xác nhận xóa mặt hàng khỏi đơn trả ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                 
                    if (ttpt.delete_ThongTinTraHang(thongtinphieuTra_DTO()))
                    {
                        MessageBox.Show("Xóa mặt hàng đặt thành công");
                        ThongTinPhieuTra_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                    }

                }
            }
            else
            {
                MessageBox.Show("Mặt hàng không tồn tại trong danh sách trả");
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar) )
                e.Handled = true;
            txtSoLuong.MaxLength = lblSoLuongDat.Text.Length;

        }

        private void dgvThongTinPhieuTra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThongTinPhieuTra.Rows[e.RowIndex];
                cbbMatHang.SelectedValue = r.Cells["maHang"].Value.ToString();
                txtSoLuong.Text = r.Cells["soLuong"].Value.ToString();
            }    
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (kiemtra_MatHangTra())
            {
                if (txtSoLuong.Text != "")
                {
                    if ((Convert.ToInt32(txtSoLuong.Text) > Convert.ToInt32(lblSoLuongDat.Text)) )//|| (((Convert.ToInt32(txtSoLuong.Text) + ttpt.soLuong_hangTra(thongtinphieuTra_DTO()) > Convert.ToInt32(lblSoLuongDat.Text)))))
                    {
                        MessageBox.Show("Số lượng trả không được vượt quá số lượng đặt");
                    }
                    else if (Convert.ToInt32(txtSoLuong.Text) < 0)
                    {
                        MessageBox.Show("Số lượng trả không được nhỏ hơn 0");
                    }
                    else
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận chỉnh sửa mặt hàng trong phiếu trả ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (ttpt.update_ThongTinTraHang(thongtinphieuTra_DTO()))
                            {
                                MessageBox.Show("Chỉnh sửa thông tin mặt hàng thành công");
                                ThongTinPhieuTra_GUI_Load(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
                            }

                        }
                    }
                }
                else
                    MessageBox.Show("Vui lòng nhập số lượng hàng câ chỉnh sửa");
            }
            else
            {
                MessageBox.Show("Mặt hàng không tồn tại trong danh sách đặt");
            }
        }

       
    }
}
