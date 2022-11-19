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
    public partial class ThanhToan_GUI : Form
    {
        public ThanhToan_GUI()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            NhanVienThanhToan_GUI t = new NhanVienThanhToan_GUI();
            t.Show();
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgThongTinDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
