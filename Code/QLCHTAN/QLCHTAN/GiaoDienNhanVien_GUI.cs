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
    public partial class GiaoDienNhanVien_GUI : Form
    {
        public GiaoDienNhanVien_GUI()
        {
            InitializeComponent();
        }

        private void lblkDangXuat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            DangNhap_GUI dangNhap_GUI = new DangNhap_GUI();
            dangNhap_GUI.Show();
        }

        private void lblkDoiMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DoiMatKhau_GUI doiMatKhau_GUI = new DoiMatKhau_GUI();
            doiMatKhau_GUI.Show();
        }
    }
}
