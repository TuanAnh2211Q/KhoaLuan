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
    public partial class NuocUong_GUI : Form
    {
        NuocUong_BUS nuocuong = new NuocUong_BUS();
        public NuocUong_DTO nuocUong_DTO()
        {
            return new NuocUong_DTO(txtMaNuoc.Text, txtTenNuoc.Text, txtDonViBan.Text, txtDonGia.Text);
        }
        public NuocUong_GUI()
        {
            InitializeComponent();
        }

        private void NuocUong_GUI_Load(object sender, EventArgs e)
        {
            dgvNuocUong.DataSource = nuocuong.show_dsNuocUong_BUS();
        }

        private void dgvNuocUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvNuocUong.Rows[e.RowIndex];
                txtMaNuoc.Text = r.Cells[0].Value.ToString();
                txtTenNuoc.Text = r.Cells[1].Value.ToString();
                txtDonViBan.Text = r.Cells[2].Value.ToString();
                txtDonGia.Text = r.Cells[3].Value.ToString();
                txtMaNuoc.Enabled = false;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaNuoc.Text = txtTenNuoc.Text = txtDonViBan.Text = txtDonGia.Text = "";
            txtMaNuoc.Enabled = true;
            NuocUong_GUI_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn muốn thêm nước uống này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                try
                {
                    if (txtMaNuoc.Text != "" && txtTenNuoc.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
                    {
                        if (nuocuong.insert_NuocUong_BUS(nuocUong_DTO()))
                        {
                            MessageBox.Show("Thêm nước thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm nước thất bại vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm nước thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Bạn có muốn xóa nước uống này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                try
                {
                    if (txtMaNuoc.Text != "")
                    {
                        if (nuocuong.delete_NuocUong_BUS(nuocUong_DTO()))
                        {
                            MessageBox.Show("Xóa nước uống thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa nước uống thất bại vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa nước uống thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Bạn muốn sửa thông tin nước uống này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                try
                {
                    if (txtMaNuoc.Text != "" && txtTenNuoc.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
                    {
                        if (nuocuong.update_NuocUong_BUS(nuocUong_DTO()))
                        {
                            MessageBox.Show("Sửa thông tin nước thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin nước thất bại vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin nước thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                }
            }
        }
    }
}
