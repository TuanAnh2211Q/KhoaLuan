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
using BUS;
using DTO;
namespace QLCHTAN
{
    public partial class ThongKe_GUI : Form
    {
        public string loaiTGTK="";
        public static string maDH = "";
        ThongKe_BUS thongKe_BUS = new ThongKe_BUS();
        public ThongKe_GUI()
        {
            InitializeComponent();
        }



        private void lbkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

       
        private void btnThongKe_Click(object sender, EventArgs e)
        {
          
            
                DataTable thongKeNgay = thongKe_BUS.thongKeDoanhThu_BUS(loaiTGTK, dtTKDT_ThoiGianThongKe.Value.Date);
                if (thongKeNgay.Rows.Count > 0)
                {
                    picTKDT_NTN.Visible = false;
                    dgvTKDT_NTN.DataSource = thongKeNgay;
                    foreach (DataRow r in thongKeNgay.Rows)
                    {
                        lblDT_NTN.Text = r.Field<decimal>("tongDoanhThu").ToString("#,##0.000 VNĐ") ;
                        break;
                    }
                }
                else
                {
                    picTKDT_NTN.Visible = true;
                }

            
        }

        private void rdbNgay_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKDT_Ngay.Checked)
            {
                grbDT_ThoiGianThongKe.Enabled = true;
                loaiTGTK = "ngay";
                dtTKDT_ThoiGianThongKe.CustomFormat = "dd/MM/yyyy";
                dtTKDT_ThoiGianThongKe.Format = DateTimePickerFormat.Custom;
            }    
        }

        private void rdbThang_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKDT_Thang.Checked)
            {
                grbDT_ThoiGianThongKe.Enabled = true;
                loaiTGTK = "thang";
                dtTKDT_ThoiGianThongKe.CustomFormat = "MM";
                dtTKDT_ThoiGianThongKe.Format = DateTimePickerFormat.Custom;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKDT_Nam.Checked)
            {
                grbDT_ThoiGianThongKe.Enabled = true;
                loaiTGTK = "nam";
                dtTKDT_ThoiGianThongKe.CustomFormat = "yyyy";
                dtTKDT_ThoiGianThongKe.Format = DateTimePickerFormat.Custom;
            }
        }




        private void btnTKDT_MTG_Click(object sender, EventArgs e)
        {
            if (dtTKDT_TG1.Value > dtTKDT_TG2.Value)
            {
                MessageBox.Show("Mốc thời gian trước không được nhỏ hơn mốc thời gian sau");
            }
            else
            {
                DataTable thongKeDT_MTG = thongKe_BUS.thongKeDoanhThu_MTG_BUS(dtTKDT_TG1.Value.Date, dtTKDT_TG2.Value.Date);
                if (thongKeDT_MTG.Rows.Count > 0)
                {
                    picTKDT_MTG.Visible = false;
                    dgvTKDT_MTG.DataSource = thongKeDT_MTG;
                    foreach (DataRow r in thongKeDT_MTG.Rows)
                    {
                        lblDT_MTG.Text = r.Field<decimal>("tongDoanhThu").ToString("#,##0.000 VNĐ") ;
                        break;
                    }
                }
                else
                {
                    picTKDT_MTG.Visible = true;
                }
            }    
               
        }

        private void ThongKe_GUI_Load(object sender, EventArgs e)
        {
            if(!rdbTKDT_Thang.Checked && !rdbTKDT_Ngay.Checked &&!rdbTKDT_Nam.Checked)
            {
                grbDT_ThoiGianThongKe.Enabled = false;
            }    
            else
            {
                grbDT_ThoiGianThongKe.Enabled = true;
            }    
        }

        private void dgvTKDT_NTN_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow r = this.dgvTKDT_NTN.Rows[e.RowIndex];
                maDH = r.Cells["maDonHang"].Value.ToString();
                ChiTietHoaDon_GUI chiTietHoaDon_GUI = new ChiTietHoaDon_GUI();
                chiTietHoaDon_GUI.Show();
            }
        }
    }
}
