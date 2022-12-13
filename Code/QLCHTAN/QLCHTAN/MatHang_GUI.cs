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
            for (int i = 0; i <= dgvMatHang.Rows.Count-1; i++)
            {
                if (txtMaHang.Text.Trim() == dgvMatHang.Rows[i].Cells["maHang"].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public bool kt_MatHangNuoc()
        {
            for (int i = 0; i <= dgvMatHangNuoc.Rows.Count-1; i++)
            {
                if (txtMaHangNuoc.Text.Trim() == dgvMatHangNuoc.Rows[i].Cells["maHangNuoc"].Value.ToString().Trim())
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
            return new MatHang_DTO(txtMaHang.Text.Trim(), txtTenHang.Text.Trim(),ncc, txtDonVi.Text.Trim(), dtNSX.Value.ToString().Trim(), dtHSD.Value.ToString().Trim(),Convert.ToDecimal(txtDonGia.Text.Trim()), txtGhiChu.Text.Trim(),true);
        }

        public MatHang_DTO mathangNuocDTO()
        {
            string nccnuoc;
            if (cbbNCCNuoc.Text == "null")
                nccnuoc = "null";
            else
                nccnuoc = cbbNCCNuoc.SelectedValue.ToString().Trim();
            return new MatHang_DTO(txtMaHangNuoc.Text.Trim(), txtTenHangNuoc.Text.Trim(), nccnuoc, txtDonViNuoc.Text.Trim(), dtNSXNuoc.Value.ToString().Trim(), dtHSDNuoc.Value.ToString().Trim(), Convert.ToDecimal(txtDonGiaNuoc.Text.Trim()), txtGhiChuNuoc.Text.Trim(),false);
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
            dgvMatHangNuoc.DataSource = mathang.show_dsMatHang_Nuoc_BUS();
            cbbNCC.DataSource = mathang.show_dsNCC_MatHang_BUS();
            cbbNCC.DisplayMember = "tenNCC";
            cbbNCC.ValueMember = "maNCC";

            cbbNCCNuoc.DataSource = mathang.show_dsNCC_MatHang_BUS();
            cbbNCCNuoc.DisplayMember = "tenNCC";
            cbbNCCNuoc.ValueMember = "maNCC";

            txtMaHang.Text = txtTenHang.Text = txtGhiChu.Text = txtDonVi.Text = txtDonGia.Text = "";
            cbbNCC.Text = "null";
            txtMaHang.Enabled = true;

            txtMaHangNuoc.Text = txtTenHangNuoc.Text = txtGhiChuNuoc.Text = txtDonViNuoc.Text = txtDonGiaNuoc.Text = "";
            txtMaHangNuoc.Enabled = true;

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

        private void btnThemNuoc_Click(object sender, EventArgs e)
        {

            if (txtMaHangNuoc.Text != "" || txtTenHangNuoc.Text != "" || txtDonViNuoc.Text != "" || txtDonGiaNuoc.Text != "")
            {
                long sp = dtHSDNuoc.Value.Subtract(dtNSXNuoc.Value).Ticks;
                if (sp <= 0)
                {
                    MessageBox.Show("Hạn sử dụng phải lớn hơn ngày sản xuất");
                }
                else
                {
                    if (!kt_MatHangNuoc())
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận thêm vào danh sách ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {

                            if (mathang.insert_MatHang_BUS(mathangNuocDTO()))
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

        private void btnXoaNuoc_Click(object sender, EventArgs e)
        {
            if (txtMaHangNuoc.Text != "")
            {

                DialogResult rs = MessageBox.Show("Xác nhận xóa hàng khỏi kho ?", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                        if (kt_MatHangNuoc())
                        {
                            if (mathang.delete_MatHang_BUS(mathangNuocDTO()))
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
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mặt hàng");
        }

        private void btnSuaNuoc_Click(object sender, EventArgs e)
        {
            if (txtMaHangNuoc.Text != "" || txtTenHangNuoc.Text != "" || txtDonViNuoc.Text != "" || txtDonGiaNuoc.Text != "")
            {
                long sp = dtHSDNuoc.Value.Subtract(dtNSXNuoc.Value).Ticks;
                if (sp <= 0)
                {
                    MessageBox.Show("Hạn sử dụng phải lớn hơn ngày sản xuất");
                }
                else
                {
                    if (kt_MatHangNuoc())
                    {
                        DialogResult rs = MessageBox.Show("Xác nhận sửa thông tin ?", "Thông báo", MessageBoxButtons.YesNo);
                        if (rs == DialogResult.Yes)
                        {
                            if (mathang.update_MatHang_BUS(mathangNuocDTO()))
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

        private void dgvMatHangNuoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvMatHangNuoc.Rows[e.RowIndex];
                txtMaHangNuoc.Text = r.Cells["maHangNuoc"].Value.ToString();
                txtTenHangNuoc.Text = r.Cells["tenHangNuoc"].Value.ToString();
                txtGhiChuNuoc.Text = r.Cells["ghiChuNuoc"].Value.ToString();
                txtDonGiaNuoc.Text = Convert.ToSingle(r.Cells["donGiaNuoc"].Value).ToString();
                txtDonViNuoc.Text = r.Cells["donViNuoc"].Value.ToString();
                if (r.Cells["maNCCNuoc"].Value.ToString() == "")
                {
                    cbbNCCNuoc.Text = "null";

                }
                else
                {
                    cbbNCCNuoc.SelectedValue = r.Cells["maNCCNuoc"].Value.ToString();
                }
                if (r.Cells["NSXNuoc"].Value.ToString() == "")
                {
                    dtNSXNuoc.CustomFormat = " ";
                }
                else
                {
                    dtNSXNuoc.CustomFormat = "dd/MM/yyyy ";
                    dtNSXNuoc.Value = Convert.ToDateTime(r.Cells["NSXNuoc"].Value.ToString());
                }
                if (r.Cells["HSDNuoc"].Value.ToString() == "")
                {
                    dtHSDNuoc.CustomFormat = " ";
                }
                else
                {
                    dtHSDNuoc.CustomFormat = "dd/MM/yyyy";
                    dtHSDNuoc.Value = Convert.ToDateTime(r.Cells["HSDNuoc"].Value.ToString());
                }
                txtMaHangNuoc.Enabled = false;
            }
        }

        private void btnLamMoiNuoc_Click(object sender, EventArgs e)
        {
            MatHang_GUI_Load(sender, e);

        }
    }
}
