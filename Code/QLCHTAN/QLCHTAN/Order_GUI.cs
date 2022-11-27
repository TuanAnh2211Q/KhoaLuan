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
    public partial class Order_GUI : Form
    {
        public Order_GUI()
        {
            InitializeComponent();
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            NhanVienThanhToan_GUI t = new NhanVienThanhToan_GUI();
            t.Show();
        }
    }
}
