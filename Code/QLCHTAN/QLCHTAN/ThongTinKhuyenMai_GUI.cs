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
    public partial class ThongTinKhuyenMai_GUI : Form
    {
        public ThongTinKhuyenMai_GUI()
        {
            InitializeComponent();
        }

        private void btnDanhSachSanPhamApDung_Click(object sender, EventArgs e)
        {
            DanhSachKhuyenMai_GUI dssp = new DanhSachKhuyenMai_GUI();
            dssp.Show();
        }
    }
}