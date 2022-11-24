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
    public partial class DoAn_GUI : Form
    {
        DoAn_BUS doAn_BUS = new DoAn_BUS();
        public static string tenDoAn;
        public static string maDoAn;
        public DoAn_DTO doAn_DTO()
        {
            return new DoAn_DTO(txtMaDoAn.Text, txtTenDoAn.Text, ccbLoaiDoAn.SelectedValue.ToString(), txtDonViBan.Text, Convert.ToSingle(txtDonGia.Text), rtxtGhiChu.Text);
        }
        public DoAn_GUI()
        {
            InitializeComponent();
        }

        private void btnThanhPhanDoAn_Click(object sender, EventArgs e)
        {
            if (txtTenDoAn.Text == ""&&txtMaDoAn.Text=="")
            {
                MessageBox.Show("Vui lòng không để trống tên đồ ăn và mã đồ ăn");
            }
            else
            {
                maDoAn = txtMaDoAn.Text;
                tenDoAn = txtTenDoAn.Text;
                ThongTinThanhPhanDoAn_GUI tp = new ThongTinThanhPhanDoAn_GUI();
                tp.Show();
            }

        }

        private void DoAn_GUI_Load(object sender, EventArgs e)
        {
            dgvDoAn.DataSource = doAn_BUS.show_dsDoAn_BUS();
            ccbLoaiDoAn.DataSource = doAn_BUS.show_dsLoaiDoAn_BUS();
            ccbLoaiDoAn.DisplayMember = "tenLoaiDoAn";
            ccbLoaiDoAn.ValueMember = "maLoaiDoAn";

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn muốn thêm đồ ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                try
                {
                    if (txtMaDoAn.Text != "" && txtTenDoAn.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
                    {
                        if (doAn_BUS.insert_DoAn_ThongTinDoAn_BUS(doAn_DTO()))
                        {
                            MessageBox.Show("Thêm đồ ăn thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Thêm đồ ăn thất bại vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Thêm đồ ăn thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                }
            }
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvDoAn.Rows[e.RowIndex];
                txtMaDoAn.Text = r.Cells[0].Value.ToString();
                txtTenDoAn.Text = r.Cells[1].Value.ToString();
                ccbLoaiDoAn.Text = r.Cells[2].Value.ToString();
                txtDonViBan.Text = r.Cells[3].Value.ToString();
                txtDonGia.Text = r.Cells[4].Value.ToString();
                rtxtGhiChu.Text = r.Cells[5].Value.ToString();
                txtMaDoAn.Enabled = false;
                if (txtTenDoAn.Text == "")
                    btnThanhPhanDoAn.Enabled = false;
                else
                    btnThanhPhanDoAn.Enabled = true;
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DoAn_GUI_Load(sender, e);
            txtMaDoAn.Text = txtTenDoAn.Text = txtDonGia.Text = txtDonViBan.Text = rtxtGhiChu.Text = "";
            ccbLoaiDoAn.SelectedIndex = 0;
            txtMaDoAn.Enabled = true;
            btnThanhPhanDoAn.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult delete = MessageBox.Show("Bạn có muốn xóa món ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (delete == DialogResult.Yes)
            {
                try
                {
                    if (txtMaDoAn.Text != "")
                    {
                        if (doAn_BUS.delete_DoAn_ThongTinDoAn_BUS(doAn_DTO()))
                        {
                            MessageBox.Show("Xóa đồ ăn thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Xóa đồ ăn ăn thất bại vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Xóa đồ ăn ăn thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult sua = MessageBox.Show("Bạn muốn sửa thông tin đồ ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
            if (sua == DialogResult.Yes)
            {
                try
                {
                    if (txtMaDoAn.Text != "" && txtTenDoAn.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
                    {
                        if (doAn_BUS.update_DoAn_ThongTinDoAn_BUS(doAn_DTO()))
                        {
                            MessageBox.Show("Sửa thông tin đồ ăn thành công");
                            btnLamMoi_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Sửa thông tin đồ ăn thất bại vui lòng kiểm tra lại thông tin nhập");
                        }
                    }
                    else
                    { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }

                }
                catch (Exception)
                {
                    MessageBox.Show("Sửa thông tin đồ ăn thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                }
            }
        }

        
    }
}
