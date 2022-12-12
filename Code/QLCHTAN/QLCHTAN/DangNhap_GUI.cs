using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace QLCHTAN
{
    public partial class DangNhap_GUI : Form
    {
        DangNhap_BUS dangNhap_BUS = new DangNhap_BUS();
        public static string tenTaiKhoan;
        public DangNhap_GUI()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }
        public DangNhap_DTO dangNhap_DTO()
        {
            return new DangNhap_DTO(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string time= DateTime.Now.ToLongTimeString();
            string date= DateTime.Now.ToShortDateString();
            lblTime.Text = time;
            lblDate.Text = date;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtTaiKhoan.Text.Trim()!=""||txtMatKhau.Text.Trim()!="")
                {
                    if(dangNhap_BUS.dangNhapHeThong_BUS(dangNhap_DTO()))
                    {
                        if (dangNhap_BUS.kiemTraQuyenHeThong_BUS(dangNhap_DTO()) == 1)
                        {
                            MessageBox.Show("Đăng nhập thành công \n Bạn đang đăng nhập bằng quyền Quản lí");
                            tenTaiKhoan = txtTaiKhoan.Text.Trim();
                            GiaoDienQuanLi_GUI giaoDienQuanLi_GUI = new GiaoDienQuanLi_GUI();
                            giaoDienQuanLi_GUI.Show();
                            timer1.Enabled = false;
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Đăng nhập thành công \n Bạn đang đăng nhập bằng quyền Nhân viên");
                            tenTaiKhoan = txtTaiKhoan.Text.Trim();
                            GiaoDienNhanVien_GUI giaoDienNhanVien_GUI = new GiaoDienNhanVien_GUI();
                            giaoDienNhanVien_GUI.Show();
                            timer1.Enabled = false;
                            this.Hide();
                        }

                    }
                    else
                        MessageBox.Show("Tên đăng nhập hoặc mất khẩu không đúng, vui lòng kiểm tra lại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch
            {

                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
        private void llblQuenMatKhau_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Vui lòng liên hệ quản lí để đặt lại mật khẩu");
        }

        

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar=='*')
            {
                btnKhongHienMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }    
        }

        private void btnKhongHienMatKhau_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar=='\0')
            {
                btnHienMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_GUI_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void DangNhap_GUI_Load(object sender, EventArgs e)
        {
            btnDangNhap.Focus();
        }
    }
    
}
