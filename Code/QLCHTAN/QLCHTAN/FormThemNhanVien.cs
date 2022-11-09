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
    public partial class FormThemNhanVien : Form
    {
        public FormThemNhanVien()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Thêm Tài Khoản Thành Công!!!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
