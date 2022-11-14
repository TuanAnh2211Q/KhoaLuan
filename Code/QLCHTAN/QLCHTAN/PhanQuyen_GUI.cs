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
    public partial class PhanQuyen_GUI : Form
    {
        PhanQuyen_BUS phanQuyen_BUS = new PhanQuyen_BUS();
        public PhanQuyen_GUI()
        {
            InitializeComponent();
        }
        public PhanQuyen_DTO phanQuyen_DTO()
        {
            return new PhanQuyen_DTO(txtMaQuyen.Text.Trim(), txtTenQuyen.Text.Trim(), txtGhiChu.Text.Trim());
        }
        private void PhanQuyen_GUI_Load(object sender, EventArgs e)
        {
            dgvPhanQuyen.DataSource = phanQuyen_BUS.dsQuyen_BUS();
        }
        private void dgvPhanQuyen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvPhanQuyen.Rows[e.RowIndex];
                txtMaQuyen.Text = row.Cells[0].Value.ToString();
                txtTenQuyen.Text = row.Cells[1].Value.ToString();
                txtGhiChu.Text = row.Cells[2].Value.ToString();
                txtMaQuyen.Enabled = false;
            }
        }
       
      
    }
}
