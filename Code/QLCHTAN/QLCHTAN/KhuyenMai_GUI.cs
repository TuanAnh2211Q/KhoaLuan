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
    public partial class KhuyenMai_GUI : Form
    {
        KhuyenMai_BUS km_BUS = new KhuyenMai_BUS();
        LoaiKhuyenMai_BUS lkm_BUS = new LoaiKhuyenMai_BUS();
        public static string tenKM;
        public static string maKM;

        public bool kt_KhuyenMai()
        {
            for (int i = 0; i <= dgvThongTinKhuyenMai.Rows.Count - 1; i++)
            {
                if (txtMaKhuyenMai.Text.Trim() == dgvThongTinKhuyenMai.Rows[i].Cells["maKhuyenMai"].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public KhuyenMai_DTO km_DTO()
        {
            float mucGiam;
            if (txtMucGiam.Text=="")
            {
                mucGiam = 0; 
            }    
            else
            {
                float f = float.Parse(txtMucGiam.Text.Trim());
                 mucGiam= (float)Math.Round(f * 100f) / 100f;
            }    
            return new KhuyenMai_DTO(txtMaKhuyenMai.Text.Trim(), txtTenKhuyenMai.Text.Trim(), cbbLoaiKhuyenMai.SelectedValue.ToString(),mucGiam);
        }
        public KhuyenMai_GUI()
        {
            InitializeComponent();
        }

       
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaKhuyenMai.Text != "" || txtTenKhuyenMai.Text != "" || txtMucGiam.Text != "")
            {
                if (!kt_KhuyenMai())
                {
                    DialogResult rs = MessageBox.Show("Xác nhận thêm khuyến mãi ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {

                        if (km_BUS.insert_KM_BUS(km_DTO()))
                        {
                            MessageBox.Show("Thêm thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                    MessageBox.Show("Mã khuyến mãi đã tồn tại");
                
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaKhuyenMai.Text != "" )
            {
                if (kt_KhuyenMai())
                {
                    DialogResult rs = MessageBox.Show("Xác nhận xóa khuyến mãi ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        DialogResult rs2 = MessageBox.Show("Xóa khuyến mãi " +
                            "đồng nghĩa với việc xóa toàn bộ danh sách sản phẩm đang áp dụng khuyến mãi đó" +
                            " \n Vẫn muốn tiếp tục xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (rs2 == DialogResult.Yes)
                        {
                            if (km_BUS.delete_KM_BUS(km_DTO()))
                            {
                                MessageBox.Show("Xóa thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                                MessageBox.Show("Xóa thất bại");
                        }
                    }
                }
                else
                    MessageBox.Show("Khuyến mãi không tồn tại, vui lòng kiểm tra lại");
                
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaKhuyenMai.Text != " " || txtTenKhuyenMai.Text != " " || txtMucGiam.Text != "")
            {  
               if(kt_KhuyenMai())
                {
                    DialogResult rs = MessageBox.Show("Xác nhận sửa thông tin khuyến mãi ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {

                        if (km_BUS.update_KM_BUS(km_DTO()))
                        {
                            MessageBox.Show("Sửa thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                            MessageBox.Show("Sửa thất bại");
                    }
                }  
               else
                    MessageBox.Show("Khuyến mãi không tồn tại, vui lòng kiểm tra lại");
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaKhuyenMai.Text = txtTenKhuyenMai.Text = txtMucGiam.Text = "";
            KhuyenMai_GUI_Load(sender, e);
        }

        private void KhuyenMai_GUI_Load(object sender, EventArgs e)
        {
            dgvThongTinKhuyenMai.DataSource = km_BUS.show_KM_BUS();
            cbbLoaiKhuyenMai.DataSource = lkm_BUS.show_dsLoaiKM_BUS();
            cbbLoaiKhuyenMai.DisplayMember = "tenLoaiKhuyenMai";
            cbbLoaiKhuyenMai.ValueMember = "maLoaiKhuyenMai";
            txtMaKhuyenMai.Enabled = true;

        }

        private void dgvThongTinKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvThongTinKhuyenMai.Rows[e.RowIndex];
                txtMaKhuyenMai.Text = r.Cells["maKhuyenMai"].Value.ToString();
                if(txtMaKhuyenMai.Text=="MKM000")
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                }    
                else
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                }
                txtTenKhuyenMai.Text = r.Cells["tenKhuyenMai"].Value.ToString();
                cbbLoaiKhuyenMai.SelectedValue = r.Cells["maLoaiKhuyenMai"].Value.ToString();
                txtMucGiam.Text = Math.Round( Convert.ToDouble( r.Cells["mucGiam"].Value), 4).ToString();
                txtMaKhuyenMai.Enabled = false;
            }    
        }

      

        private void txtMucGiam_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)&&!(e.KeyChar.ToString()==","))
                e.Handled = true;
        }


        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void txtMucGiam_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
