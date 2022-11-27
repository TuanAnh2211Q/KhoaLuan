using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLCHTAN
{
    public partial class NhanVienThanhToan_GUI : Form
    {
        public NhanVienThanhToan_GUI()
        {
            InitializeComponent();
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



        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("Thanh Toán Thành Công !!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tài Khoản hoặc Mật Khẩu không đúng!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
