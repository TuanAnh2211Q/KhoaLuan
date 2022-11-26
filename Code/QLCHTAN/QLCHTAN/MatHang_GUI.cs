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
    public partial class MatHang_GUI : Form
    {
        MatHang_BUS mathang = new MatHang_BUS();
        NhaCungCap_BUS ncc = new NhaCungCap_BUS();
        public bool kt_MatHang()
        {
            for (int i = 0; i <= dgvMatHang.Rows.Count; i++)
            {
                if (txtMaHang.Text.Trim() == dgvMatHang.Rows[i].Cells["maHang"].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public MatHang_DTO mathangDTO()
        {
            string ncc;
            if (cbbNCC.Text=="null")
                ncc = "null";
            else
                ncc = cbbNCC.SelectedValue.ToString().Trim();
            return new MatHang_DTO(txtMaHang.Text.Trim(), txtTenHang.Text.Trim(),ncc, txtDonVi.Text.Trim(), dtNSX.Value.ToString().Trim(), dtHSD.Value.ToString().Trim(),txtDonGia.Text.Trim(), txtGhiChu.Text.Trim());
        }
        public MatHang_GUI()
        {
            InitializeComponent();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text != "" || txtTenHang.Text != "" || txtDonVi.Text != "" || txtDonGia.Text != "" )
            {
                long sp = dtHSD.Value.Subtract(dtNSX.Value).Ticks;
                if (sp <= 0)
                {
                    MessageBox.Show("Hạn sử dụng phải lớn hơn ngày sản xuất");
                }
                else
                {
                   if(!kt_MatHang())
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận thêm vào danh sách ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {

                            if (mathang.insert_MatHang_BUS(mathangDTO()))
                            {
                                MessageBox.Show("Thêm mặt hàng thành công");
                                MatHang_GUI_Load(sender, e);
                            }
                            else
                                MessageBox.Show("Thêm mặt hàng thất bại");
                        }
                    }  
                   else
                    {
                        MessageBox.Show("Mã mặt hàng đã tồn tại, vui lòng kiểm tra lại");
                    }    
                }

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng");
        }
       

        private void btnXoa_Click(object sender, EventArgs e)
        {

            if (txtMaHang.Text != "")
            {
                
                    DialogResult rs = MessageBox.Show("Xác nhận xóa hàng khỏi kho ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                    if(mathang.check_MatHangTrongDoAn_BUS(mathangDTO()))
                    {
                        MessageBox.Show("Mặt hàng vẫn còn sử dụng cho món ăn, không thể xóa");
                        return;
                    }
                    else
                    {
                        if(kt_MatHang())
                        {

                            if (mathang.delete_MatHang_BUS(mathangDTO()))
                            {
                                MessageBox.Show("Xóa mặt hàng thành công");
                                MatHang_GUI_Load(sender, e);
                            }
                            else
                                MessageBox.Show("Xóa mặt hàng thất bại");
                        }    
                        else
                        {
                            MessageBox.Show("Không tồn tại mặt hàng, không thể xóa");
                        }    
                    }
   
                    }

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng");
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaHang.Text != "" || txtTenHang.Text != "" || txtDonVi.Text != "" || txtDonGia.Text != "")
            {
                long sp = dtHSD.Value.Subtract(dtNSX.Value).Ticks;
                if (sp <= 0)
                {
                    MessageBox.Show("Hạn sử dụng phải lớn hơn ngày sản xuất");
                }
                else
                {
                   if(kt_MatHang())
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận sửa thông tin ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (mathang.update_MatHang_BUS(mathangDTO()))
                            {
                                MessageBox.Show("Chỉnh sửa thành công");
                                MatHang_GUI_Load(sender, e);
                            }
                            else
                                MessageBox.Show("Chỉnh sửa thất bại");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tồn tại mặt hàng, không thể sửa");
                    }
                }

            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng");
        }
        private void MatHang_GUI_Load(object sender, EventArgs e)
        {
            dgvMatHang.DataSource = mathang.show_dsMatHang_BUS();
            cbbNCC.DataSource = mathang.show_dsNCC_MatHang_BUS();
            cbbNCC.DisplayMember = "tenNCC";
            cbbNCC.ValueMember = "maNCC";
            txtMaHang.Text = txtTenHang.Text = txtGhiChu.Text = txtDonVi.Text = txtDonGia.Text = "";
            cbbNCC.Text = "null";
            txtMaHang.Enabled = true;
        }

        private void dgvMatHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvMatHang.Rows[e.RowIndex];
                txtMaHang.Text = r.Cells["maHang"].Value.ToString();
                txtTenHang.Text = r.Cells["tenHang"].Value.ToString();
                txtGhiChu.Text = r.Cells["ghiChu"].Value.ToString();
                txtDonGia.Text =Convert.ToSingle( r.Cells["donGia"].Value).ToString();
                txtDonVi.Text = r.Cells["donVi"].Value.ToString();
                if(r.Cells["maNCC"].Value.ToString()=="")
                {
                    cbbNCC.Text ="null";

                }
                else
                {
                    cbbNCC.SelectedValue = r.Cells["maNCC"].Value.ToString();
                }
                if(r.Cells["NSX"].Value.ToString()=="")
                {
                    dtNSX.CustomFormat = " ";
                }    
                else
                {
                    dtNSX.CustomFormat = "dd/MM/yyyy ";
                    dtNSX.Value = Convert.ToDateTime(r.Cells["NSX"].Value.ToString());
                }
                if(r.Cells["HSD"].Value.ToString()=="")
                {
                    dtHSD.CustomFormat = " ";
                }    
                else
                {
                    dtHSD.CustomFormat = "dd/MM/yyyy";
                    dtHSD.Value = Convert.ToDateTime(r.Cells["HSD"].Value.ToString());
                }
                txtMaHang.Enabled = false;
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            MatHang_GUI_Load(sender, e);


        }
    }
}
