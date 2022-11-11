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

namespace QLCHTAN
{
    public partial class DangNhap_GUI : Form
    {
        public DangNhap_GUI()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToLongTimeString();
            lblDate.Text = DateTime.Now.ToShortDateString();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            try
            {

                 MessageBox.Show("Chúc Bạn Một Ngày Làm Việc Vui Vẻ!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
