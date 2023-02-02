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
    public partial class LoaiKhuyenMai_GUI : Form
    {
        LoaiKhuyenMai_BUS lkm = new LoaiKhuyenMai_BUS();
        public LoaiKhuyenMai_DTO lkmDTO()
        {
            return new LoaiKhuyenMai_DTO(txtMaLoaiKhuyenMai.Text.Trim(), txtTenLoaiKhuyenMai.Text.Trim());
        }
        public LoaiKhuyenMai_GUI()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiKhuyenMai.Text != "" || txtTenLoaiKhuyenMai.Text != "")
            {
                DialogResult rs = MessageBox.Show("Xác nhận thêm loại khuyến mãi mới", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                  
                        for (int i = 0; i <= dgvLoaiKhuyenMai.Rows.Count-1; i++)
                        {
                            if (txtMaLoaiKhuyenMai.Text == dgvLoaiKhuyenMai.Rows[i].Cells["MaLoaiKhuyenMai"].Value.ToString())
                            {
                                MessageBox.Show("Mã loại khuyến mãi này đã tồn tại, vui lòng nhập khác");
                            return;
                            }

                        }
                    
                    if (lkm.insert_LoaiKM_BUS(lkmDTO()))
                    {
                        MessageBox.Show("Thêm thành công");
                        LoaiKhuyenMai_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Thêm thất bại");
                    
                    
                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiKhuyenMai.Text != "" )
            {
                DialogResult rs = MessageBox.Show("Xác nhận xóa loại khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (lkm.delete_LoaiKM_BUS(lkmDTO()))
                    {
                        MessageBox.Show("Xóa thành công");
                        LoaiKhuyenMai_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Xóa thất bại");


                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaLoaiKhuyenMai.Text != "" || txtTenLoaiKhuyenMai.Text != "")
            {
                DialogResult rs = MessageBox.Show("Xác nhận sửa thông tin loại khuyến mãi ", "Thông báo", MessageBoxButtons.YesNo);
                if (rs == DialogResult.Yes)
                {
                    if (lkm.update_LoaiKM_BUS(lkmDTO()))
                    {
                        MessageBox.Show("Sửa thành công");
                        LoaiKhuyenMai_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Sửa thất bại");


                }
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoaiKhuyenMai_GUI_Load(sender, e);
            txtMaLoaiKhuyenMai.Enabled = true;
        }

        private void LoaiKhuyenMai_GUI_Load(object sender, EventArgs e)
        {
            dgvLoaiKhuyenMai.DataSource = lkm.show_dsLoaiKM_BUS();
            txtMaLoaiKhuyenMai.Text = txtTenLoaiKhuyenMai.Text = "";
        }

      

        private void dgvLoaiKhuyenMai_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtMaLoaiKhuyenMai.Text = dgvLoaiKhuyenMai.Rows[e.RowIndex].Cells["MaLoaiKhuyenMai"].Value.ToString();
                if(txtMaLoaiKhuyenMai.Text=="MLKM000")
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = false;
                }
                else
                {
                    btnThem.Enabled = btnXoa.Enabled = btnSua.Enabled = true;
                }
                txtTenLoaiKhuyenMai.Text = dgvLoaiKhuyenMai.Rows[e.RowIndex].Cells["TenLoaiKhuyenMai"].Value.ToString();
                txtMaLoaiKhuyenMai.Enabled = false;
            }
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
    }
}
