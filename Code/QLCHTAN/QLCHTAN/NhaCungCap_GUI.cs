using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using DTO;
using BUS;

namespace QLCHTAN
{
    public partial class NhaCungCap_GUI : Form
    {
        NhaCungCap_BUS ncc = new NhaCungCap_BUS();
        public NhaCungCap_DTO nccDTO()
        {
            return new NhaCungCap_DTO(txtMaNhaCungCap.Text, txtTenNhaCungCap.Text, txtDiaChi.Text, txtEmail.Text, txtSDT.Text, rtxtGhiChu.Text);
        }
        public NhaCungCap_GUI()
        {
            InitializeComponent();
        }

        

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text != "" || txtTenNhaCungCap.Text != "" || txtDiaChi.Text != "")
            {
                    DialogResult rs = MessageBox.Show("Xác nhận xóa thông tin nhà cung cấp ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                       
                        if (ncc.delete_NCC_BUS(nccDTO()))
                        {
                            MessageBox.Show("Xóa nhà cung cấp thành công");
                            NhaCungCap_GUI_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa nhà cung cấp thất bại");
                        }
                    }
                }
            }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(txtMaNhaCungCap.Text!=""||txtTenNhaCungCap.Text!=""||txtDiaChi.Text!="")
            {
                if (txtEmail.Text == "" && txtSDT.Text == "")
                    MessageBox.Show("Vui lòng không để trống thông tin liên lạc với nhà cung cấp");
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận thêm thông tin nhà cung cấp ?", "Thông báo", MessageBoxButtons.YesNo);
                    if(rs==DialogResult.Yes)
                    {
                        for (int i = 0; i <= dgvNhaCungCap.Rows.Count - 1; i++)
                        {
                            if (txtMaNhaCungCap.Text == dgvNhaCungCap.Rows[i].Cells["maNhaCungCap"].Value.ToString())
                            {
                                MessageBox.Show("Mã nhà cung cấp đã tồn tại, không thể thêm");
                                return;
                            }
                        }
                        if(ncc.insert_NCC_BUS(nccDTO()))
                        {
                            MessageBox.Show("Thêm nhà cung cấp thành công");
                            NhaCungCap_GUI_Load(sender, e);
                        }    
                        else
                        {
                            MessageBox.Show("Thêm nhà cung cấp thất bại");
                        }    
                    }    
                }    
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaNhaCungCap.Text != "" || txtTenNhaCungCap.Text != "" || txtDiaChi.Text != "")
            {
                if (txtEmail.Text == "" && txtSDT.Text == "")
                    MessageBox.Show("Vui lòng không để trống thông tin liên lạc với nhà cung cấp");
                else
                {
                    DialogResult rs = MessageBox.Show("Xác nhận sửa thông tin nhà cung cấp ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (rs == DialogResult.Yes)
                    {
                        if (ncc.update_NCC_BUS(nccDTO()))
                        {
                            MessageBox.Show("Sửa thông tin nhà cung cấp thành công");
                            NhaCungCap_GUI_Load(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin nhà cung cấp thất bại");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng không để trống thông tin");
            }
        }
        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NhaCungCap_GUI_Load(sender, e);
        }

        private void NhaCungCap_GUI_Load(object sender, EventArgs e)
        {
            dgvNhaCungCap.DataSource = ncc.show_dsNCC_BUS();
            txtMaNhaCungCap.Text = txtTenNhaCungCap.Text = txtDiaChi.Text = txtEmail.Text = txtSDT.Text = rtxtGhiChu.Text = "";
            txtMaNhaCungCap.Enabled = true;
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNhaCungCap.Text = r.Cells[0].Value.ToString();
                txtTenNhaCungCap.Text = r.Cells[1].Value.ToString();
                txtDiaChi.Text = r.Cells[2].Value.ToString();
                txtEmail.Text = r.Cells[3].Value.ToString();
                txtSDT.Text = r.Cells[4].Value.ToString();
                rtxtGhiChu.Text = r.Cells[5].Value.ToString();
                txtMaNhaCungCap.Enabled = false;
            }    
        }

       
    }
}
