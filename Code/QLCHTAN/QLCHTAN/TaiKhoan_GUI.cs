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
    public partial class TaiKhoan_GUI : Form
    {
        TaiKhoan_BUS taiKhoan_BUS = new TaiKhoan_BUS();
        PhanQuyen_BUS phanQuyen_BUS = new PhanQuyen_BUS();
     
        public TaiKhoan_GUI()
        {
            InitializeComponent();
        }
        public TaiKhoan_DTO taiKhoan_DTO()
        {
            return new TaiKhoan_DTO(Convert.ToInt32(lblID.Text), lblTenTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim(), lblTenTaiKhoan.Text.Trim(), cbbQuyen.SelectedValue.ToString().Trim());
        }
        private void lblkDanhSachQuyen_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PhanQuyen_GUI ttq = new PhanQuyen_GUI();
            ttq.Show();
        }

        private void btnDatLaiMatKhau_Click(object sender, EventArgs e)
        {
            if (lblTenTaiKhoan.Text.Trim() == "" || lblID.Text.Trim() == "")
            {
                MessageBox.Show("Vui lòng chọn tài khoản");
                return;
            }
            else
            {
                DialogResult rs = MessageBox.Show("Bạn muốn đặt lại mật khẩu cho tài khoản", "Thông báo", MessageBoxButtons.YesNo);
                    if(rs==DialogResult.Yes)
                {

                    if (taiKhoan_BUS.rs_MatKhau_BUS(taiKhoan_DTO()))
                    {
                        MessageBox.Show("Đặt lại mật khẩu thành công");
                        TaiKhoan_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Đặt lại mật khẩu thành công");
                    }
                }    
            }
        }

        private void btnGanQuyen_Click(object sender, EventArgs e)
        {
            if(lblTenTaiKhoan.Text.Trim()==""||lblID.Text.Trim()=="")
            {
                MessageBox.Show("Vui lòng chọn tài khoản");
                return;
            }
            else
            {
                if(lblTenTaiKhoan.Text.Trim()==DangNhap_GUI.tenTaiKhoan.Trim())
                {
                    MessageBox.Show("Không thể thay đổi quyền tài khoản đang đăng nhập");
                    TaiKhoan_GUI_Load(sender, e);
                }   
                else
                {
                    if (taiKhoan_BUS.ganQuyen_BUS(taiKhoan_DTO()))
                    {
                        MessageBox.Show("Gán quyền thành công");
                        TaiKhoan_GUI_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Gán quyền thất bại");
                    }
                }
            }
        }

        private void TaiKhoan_GUI_Load(object sender, EventArgs e)
        {
            dgvTaiKhoan.DataSource = taiKhoan_BUS.show_TTTK_BUS();
            cbbQuyen.DataSource = phanQuyen_BUS.dsQuyen_BUS();
            cbbQuyen.DisplayMember = "tenQuyen";
            cbbQuyen.ValueMember = "maQuyen";
           
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow r = dgvTaiKhoan.Rows[e.RowIndex];
                lblNhanVien.Text = r.Cells["tenNhanVien"].Value.ToString();
                lblTenTaiKhoan.Text = r.Cells["tenTaiKhoan"].Value.ToString();
                txtMatKhau.Text = r.Cells["matKhau"].Value.ToString();
                cbbQuyen.SelectedValue = r.Cells["maQuyen"].Value.ToString();
                lblID.Text = r.Cells["id"].Value.ToString();

            }    
        }
    }
}
