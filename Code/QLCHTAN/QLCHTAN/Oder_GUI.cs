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
    public partial class Oder_GUI : Form
    {
        public Oder_GUI()
        {
            InitializeComponent();
        }

        private void tbtnMenuDoAn_Click(object sender, EventArgs e)
        {
            DanhMucMon_GUI t = new DanhMucMon_GUI();
            t.MdiParent = this;
            t.Show(); 
            tbtnMenuDoAn.Enabled = false;
            tbtnThanhToan.Enabled = true;
        }





        private void tbtnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan_GUI t = new ThanhToan_GUI();
            t.MdiParent = this;
            t.Show();
            tbtnThanhToan.Enabled = false;
            tbtnMenuDoAn.Enabled = true;
        }
    }
}
