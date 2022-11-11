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
    public partial class LoaiDoAn_GUI : Form
    {
        LoaiDoAn_BUS loaiDoAn_BUS = new LoaiDoAn_BUS();
        public LoaiDoAn_GUI()
        {
            InitializeComponent();
        }
      
        public LoaiDoAn_DTO loaiDoAn_DTO()
        {
            return new LoaiDoAn_DTO(txtMaLoaiDoAn.Text.Trim(), txtTenLoaiDoAn.Text.Trim());
        }
        private void LoaiDoAn_GUI_Load(object sender, EventArgs e)
        {
            dgvLoaiDoAn.DataSource = loaiDoAn_BUS.dsLoaiDoAn_BUS();
        }

        private void dgvLoaiDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0)
            {
                DataGridViewRow row = this.dgvLoaiDoAn.Rows[e.RowIndex];
                txtMaLoaiDoAn.Text = row.Cells[0].Value.ToString();
                txtTenLoaiDoAn.Text = row.Cells[1].Value.ToString();
                txtMaLoaiDoAn.Enabled = false;
            }    
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            txtMaLoaiDoAn.Clear();
            txtTenLoaiDoAn.Clear();
            txtMaLoaiDoAn.Enabled = true;
            dgvLoaiDoAn.DataSource = loaiDoAn_BUS.dsLoaiDoAn_BUS();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có muốn thêm loại đồ ăn","Thông báo",MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaLoaiDoAn.Text != "" && txtTenLoaiDoAn.Text != "")
                {
                    if (loaiDoAn_BUS.insert_LoaiDoAn_BUS(loaiDoAn_DTO()))
                        MessageBox.Show("Thêm loại đồ ăn thành công");
                    else
                        MessageBox.Show("Thêm loại đồ ăn thất bại");
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
                return;
            btnLamMoi_Click(sender, e);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có muốn xóa loại đồ ăn", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaLoaiDoAn.Text != "" && txtTenLoaiDoAn.Text != "")
                {
                    if (loaiDoAn_BUS.delete_LoaiDoAn_BUS(loaiDoAn_DTO()))
                        MessageBox.Show("Xóa loại đồ ăn thành công");
                    else
                        MessageBox.Show("Xóa loại đồ ăn thất bại");
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
                return;
            btnLamMoi_Click(sender, e);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DialogResult them = MessageBox.Show("Bạn có muốn chỉnh sửa thông tin loại đồ ăn", "Thông báo", MessageBoxButtons.YesNo);
            if (them == DialogResult.Yes)
            {
                if (txtMaLoaiDoAn.Text != "" && txtTenLoaiDoAn.Text != "")
                {
                    if (loaiDoAn_BUS.update_LoaiDoAn_BUS(loaiDoAn_DTO()))
                        MessageBox.Show("Chỉnh sửa thông tin loại đồ ăn thành công");
                    else
                        MessageBox.Show("Chỉnh sửa thông tin loại đồ ăn thất bại");
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
                return;
            btnLamMoi_Click(sender, e);
        }
    }
}
