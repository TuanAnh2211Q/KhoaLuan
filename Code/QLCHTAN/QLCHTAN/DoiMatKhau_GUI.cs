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
    public partial class DoiMatKhau_GUI : Form
    {
        DoiMatKhau_BUS doiMatKhau_BUS = new DoiMatKhau_BUS();
        public DoiMatKhau_GUI()
        {
            InitializeComponent();
        }

        private void DoiMatKhau_GUI_Load(object sender, EventArgs e)
        {
            lblTenDangNhap.Text = DangNhap_GUI.tenTaiKhoan;
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            if(txtMatKhauMoi.Text.Trim()!=""||txtMatKhauCu.Text.Trim()!="")
            {
                DoiMatKhau_DTO doiMatKhau_DTO = new DoiMatKhau_DTO(lblTenDangNhap.Text.Trim(),txtMatKhauCu.Text.Trim(),txtMatKhauMoi.Text.Trim());
                if (doiMatKhau_BUS.updateDoiMatKhau_BUS(doiMatKhau_DTO))
                {
                    MessageBox.Show("Đổi mật khẩu thành công", "Thông báo", MessageBoxButtons.OK);
                    DangNhap_GUI dangNhap_GUI = new DangNhap_GUI();
                    dangNhap_GUI.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Đổi mật khẩu thất bại, vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);

        }
    }
}
