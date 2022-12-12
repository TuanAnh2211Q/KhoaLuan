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
    public partial class NhanVienThanhToan_GUI : Form
    {
        public static string maNVTT;
        DangNhap_BUS dangNhap_BUS = new DangNhap_BUS();
        public DangNhap_DTO dangNhap_DTO()
        {
            return new DangNhap_DTO(txtTaiKhoan.Text.Trim(), txtMatKhau.Text.Trim());
        }
        public NhanVienThanhToan_GUI()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void btnHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '*')
            {
                btnKhongHienMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnKhongHienMatKhau_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                btnHienMatKhau.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTaiKhoan.Text.Trim() != "" || txtMatKhau.Text.Trim() != "")
                {
                    if (dangNhap_BUS.dangNhapHeThong_BUS(dangNhap_DTO()))
                    {
                        maNVTT = txtTaiKhoan.Text.Trim();
                        ThongTinDonHang_GUI ttdh = new ThongTinDonHang_GUI();
                        ttdh.Show();
                        this.Close();


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



      
    }
}
