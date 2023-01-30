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
using DAO;
using BUS;
namespace QLCHTAN
{
    public partial class ChiTietHoaDon_GUI : Form
    {
        DataProvider data = new DataProvider();   
        public ChiTietHoaDon_GUI()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChiTietHoaDon_GUI_Load(object sender, EventArgs e)
        {
            data.Open();
            SqlDataAdapter da = new SqlDataAdapter("print_HoaDonBanHang", data.conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = ThongKe_GUI.maDH;
            SqlCommand cmd = new SqlCommand("print_TongGia", data.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = ThongKe_GUI.maDH;
            DataTable ds = new DataTable();
            da.Fill(ds);

            dgvThongTinHoaDon.DataSource = ds;
            if(dgvThongTinHoaDon.Rows.Count>=0)
            {
                lblMaDonHang.Text = dgvThongTinHoaDon.Rows[0].Cells["MaDonHang"].Value.ToString();
                lblTenDonHang.Text = dgvThongTinHoaDon.Rows[0].Cells["TenDonHang"].Value.ToString();
                lblNhanVien.Text = dgvThongTinHoaDon.Rows[0].Cells["TenNhanVien"].Value.ToString();
                lblKhuyenMai.Text = dgvThongTinHoaDon.Rows[0].Cells["TenKhuyenMai"].Value.ToString();
                lblThoiGian.Text = dgvThongTinHoaDon.Rows[0].Cells["ThoiGianDat"].Value.ToString();
            }
            decimal tongGia = Convert.ToDecimal(cmd.ExecuteScalar());
            lblTongDonGia.Text = tongGia.ToString("#,##0.000 đồng") ;

        }
    }
}
