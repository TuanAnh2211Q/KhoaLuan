﻿using System;
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


        private void tbtnMenuDoAn_Click(object sender, EventArgs e)
        {
            DanhMucMon_GUI danhMuc = new DanhMucMon_GUI();
            danhMuc.MdiParent = this;
            danhMuc.Show();
            tbtnThanhToan.Enabled = true;
            tbtnMenuDoAn.Enabled = false;  
        }





        private void tbtnThanhToan_Click(object sender, EventArgs e)
        {
            ThanhToan_GUI thanhToan = new ThanhToan_GUI();
            thanhToan.MdiParent = this;
            thanhToan.Show();
            tbtnThanhToan.Enabled = false;
            tbtnMenuDoAn.Enabled = true;

        }

       
    }
}