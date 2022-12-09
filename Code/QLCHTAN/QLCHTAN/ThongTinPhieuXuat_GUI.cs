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
    public partial class ThongTinPhieuXuat_GUI : Form
    {
        ThongTinPhieuXuat_BUS ttpx_BUS = new ThongTinPhieuXuat_BUS();
        public ThongTinPhieuXuat_GUI()
        {
            InitializeComponent();
        }

        private void ThongTinPhieuXuat_GUI_Load(object sender, EventArgs e)
        {
            lblThongTinPhieuXuat.Text = "THÔNG TIN PHIẾU XUẤT: " + PhieuXuatKho_GUI.maxuat;
            dgvThongTinPhieuXuat.DataSource = ttpx_BUS.select_ThongTinPhieuXuat_BUS(PhieuXuatKho_GUI.maxuat);
        }
    }
}
