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
    public partial class DoAn_GUI : Form
    {
        public DoAn_GUI()
        {
            InitializeComponent();
        }

        private void btnThanhPhanDoAn_Click(object sender, EventArgs e)
        {
            ThongTinThanhPhanDoAn_GUI tp = new ThongTinThanhPhanDoAn_GUI();
            tp.Show();
        }
    }
}
