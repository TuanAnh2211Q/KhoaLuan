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
    public partial class FormTaiKhoan : Form
    {
        public FormTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                //ThemNhanVien_GUI t = new ThemNhanVien_GUI();
                //t.Show();
            }
            catch
            {

                MessageBox.Show("Thêm Thất Bại!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("Xóa Tài Khoản Thành Công!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Xóa Thất Bại!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {

                MessageBox.Show("Sửa Tài Khoản Thành Công!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {

                MessageBox.Show("Sửa Thất Bại!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                FormThongTinNhanVien t = new FormThongTinNhanVien();
                t.Show();
            }
            catch
            {

                MessageBox.Show(" Không Có Nhân Viên Này!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
