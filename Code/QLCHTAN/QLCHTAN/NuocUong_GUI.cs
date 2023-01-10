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
        MatHang_BUS mathang = new MatHang_BUS();
        public NuocUong_DTO nuocUong_DTO()
        {
            return new NuocUong_DTO(cbbNuoc.SelectedValue.ToString(), txtTenNuoc.Text, txtDonViBan.Text, txtDonGia.Text);
        }
        public bool kt_NuocUong()
        {
            for (int i = 0; i <= dgvNuocUong.Rows.Count - 1; i++)
            {
                if (cbbNuoc.SelectedValue.ToString().Trim() == dgvNuocUong.Rows[i].Cells["MaNuoc"].Value.ToString().Trim())
                {
                    return true;
                }
            }
            return false;
        }
        public NuocUong_GUI()
        {
            InitializeComponent();
        }

        private void NuocUong_GUI_Load(object sender, EventArgs e)
        {
            dgvNuocUong.DataSource = nuocuong.show_dsNuocUong_BUS();
            cbbNuoc.DataSource = mathang.show_dsMatHang_Nuoc_BUS();
            cbbNuoc.DisplayMember = "tenHang";
            cbbNuoc.ValueMember = "maHang";
        }

        private void dgvNuocUong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvNuocUong.Rows[e.RowIndex];
                cbbNuoc.SelectedValue = r.Cells[0].Value.ToString();
                txtTenNuoc.Text = r.Cells[1].Value.ToString();
                txtDonViBan.Text = r.Cells[2].Value.ToString();
                txtDonGia.Text = r.Cells[3].Value.ToString();
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            NuocUong_GUI_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn muốn thêm nước uống này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (!kt_NuocUong())
                {
                    try
                    {
                        if ( txtTenNuoc.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
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
                        MessageBox.Show("Thêm nước thất bại vui lòng kiểm tra lại thông tin nước");
                    }
                }
                else
                    MessageBox.Show("Mã nước uống đã tồn tại, không thể thêm");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Bạn có muốn xóa nước uống này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                if (kt_NuocUong())
                {

                    try
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
                  
                    
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa nước uống thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                    }
                }
                else
                    MessageBox.Show("Mã nước không tồn tại, không thể xóa");
            }
        }

        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    DialogResult sua = MessageBox.Show("Bạn muốn sửa thông tin nước uống này ?", "Thông báo", MessageBoxButtons.YesNo);
        //    if (sua == DialogResult.Yes)
        //    {
        //        if (kt_NuocUong())
        //        {
        //            try
        //            {
        //                if ( txtTenNuoc.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
        //                {
        //                    if (nuocuong.update_NuocUong_BUS(nuocUong_DTO()))
        //                    {
        //                        MessageBox.Show("Sửa thông tin nước thành công");
        //                        btnLamMoi_Click(sender, e);
        //                    }
        //                    else
        //                    {
        //                        MessageBox.Show("Sửa thông tin nước thất bại vui lòng kiểm tra lại thông tin nhập");
        //                    }
        //                }
        //                else
        //                { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

        //            }
        //            catch (Exception)
        //            {
        //                MessageBox.Show("Sửa thông tin nước thất bại vui lòng kiểm tra lại thông tin đồ ăn");
        //            }
        //        }
        //        else
        //            MessageBox.Show("Mã nước không tồn tại, không thể sửa");
        //    }
        //}

        private void cbbNuoc_SelectedValueChanged(object sender, EventArgs e)
        {
           if(cbbNuoc.SelectedValue!=null)
            {
                DataTable da = nuocuong.select_thongTin_MatHangNuoc_BUS(cbbNuoc.SelectedValue.ToString());
                if (da.Rows.Count > 0)
                {
                    foreach (DataRow r in da.Rows)
                    {
                        txtDonGia.Text = (r.Field<decimal>("donGia")).ToString();
                        txtDonViBan.Text = r.Field<string>("donVi");
                        txtTenNuoc.Text = r.Field<string>("tenHang");
                    }
                }
            }    
        }
    }
}
