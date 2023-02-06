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
    
        public ThongKe_GUI()
        {
            InitializeComponent();
        }



        private void lbkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }
        public static string LoaiThongKe;
        public static string maDH = "";

        //Biến cho thống kê ngày tháng năm
        public static DateTime TKNTN_TG;
        public static string loaiTGTK = "";

        //Biến cho thống kê doanh thu theo mốc thời gian
        public static DateTime TKMTG_TG1;
        public static DateTime TKMTG_TG2;

        //Biến cho thống kê theo quý
        public static string quyList ;
        public static int TK_TQ_nam;


        ThongKe_BUS thongKe_BUS = new ThongKe_BUS();

        private void btnThongKe_Click(object sender, EventArgs e)
        {
                TKNTN_TG = dtTKDT_ThoiGianThongKe.Value.Date;
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
        private void btnTKDT_MTG_Click(object sender, EventArgs e)
        {
            if (dtTKDT_TG1.Value > dtTKDT_TG2.Value)
            {
                MessageBox.Show("Mốc thời gian trước không được nhỏ hơn mốc thời gian sau");
            }
            else
            {
                TKMTG_TG1 = dtTKDT_TG1.Value.Date;
                TKMTG_TG2 = dtTKDT_TG2.Value.Date;
                DataTable thongKeDT_MTG = thongKe_BUS.thongKeDoanhThu_MTG_BUS(TKMTG_TG1.Date, TKMTG_TG2.Date);
                if (thongKeDT_MTG.Rows.Count > 0)
                {
                    picTKDT_MTG.Visible = false;
                    dgvTKDT_MTG.DataSource = thongKeDT_MTG;
                    foreach (DataRow r in thongKeDT_MTG.Rows)
                    {
                        lblDT_MTG.Text = r.Field<decimal>("tongDoanhThu").ToString("#,##0.000 VNĐ");
                        break;
                    }
                }
                else
                {
                    picTKDT_MTG.Visible = true;
                }
            }

        }
        private void btnTKDT_TQ_Click(object sender, EventArgs e)
        {
            foreach (CheckBox cb in grbTKTQ_Quy.Controls)
            {
                if(!cb.Checked)
                {
                    picTKDT_TQ.Visible = true;
                }    
            }    
            quyList = string.Empty;
            DataTable tkdttq = new DataTable();
            TK_TQ_nam = Convert.ToInt32(dtTKTQ_Nam.Value.Year);
            foreach (Control c in grbTKTQ_Quy.Controls)
            {
                CheckBox quyC = c as CheckBox;
                if (quyC != null && quyC.Checked)
                {
                    quyList += quyC.Text + ",";
                }
            }
            quyList = quyList.TrimEnd(',');

            DataSet thongKeDT_TQ = thongKe_BUS.thongKeDoanhThu_TQ_BUS(TK_TQ_nam, quyList);

            if (thongKeDT_TQ.Tables.Count > 0)
            {
                foreach (DataTable tb in thongKeDT_TQ.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tkdttq.Merge(tb);
                }
                if (tkdttq.Rows.Count > 0)
                {
                    dgvTKDT_TQ.DataSource = tkdttq;
                    picTKDT_TQ.Visible = false;
                    foreach (DataRow r in tkdttq.Rows)
                    {
                        decimal tongDT = tkdttq.AsEnumerable().Select(row => row.Field<decimal>("tongDoanhThu")).Distinct().Sum();
                        lblTongDT_TKDT_TQ.Text = tongDT.ToString("#,##0.000 VNĐ");
                    }
                }
                else
                {
                    picTKDT_TQ.Visible = true;
                }

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
                dtTKDT_ThoiGianThongKe.CustomFormat = "MM/yyyy";
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
                dtTKDT_ThoiGianThongKe.ShowUpDown = true;
            }
            else
            {
                dtTKDT_ThoiGianThongKe.ShowUpDown = false;
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

        private void dgvTKDT_MTG_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow r = this.dgvTKDT_MTG.Rows[e.RowIndex];
                maDH = r.Cells["maDonHang_MTG"].Value.ToString();
                ChiTietHoaDon_GUI chiTietHoaDon_GUI = new ChiTietHoaDon_GUI();
                chiTietHoaDon_GUI.Show();
            }
        }

        private void dtTKTQ_Nam_ValueChanged(object sender, EventArgs e)
        {
            dtTKTQ_Nam.MaxDate = DateTime.Today;
            dtTKTQ_Nam.MinDate =Convert.ToDateTime("22/11/2001");
        }

        
        private void dgvTKDT_TQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && ((DataGridView)sender).Columns[e.ColumnIndex] is DataGridViewButtonColumn)
            {
                DataGridViewRow r = this.dgvTKDT_TQ.Rows[e.RowIndex];
                maDH = r.Cells["maDonHang_TKDT_TQ"].Value.ToString();
                ChiTietHoaDon_GUI chiTietHoaDon_GUI = new ChiTietHoaDon_GUI();
                chiTietHoaDon_GUI.Show();
            }
        }

        private void lblXuatTKDT_NTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "TKNTN_TG";
            XuatThongKe_GUI xuatThongKe = new XuatThongKe_GUI();
            xuatThongKe.Show();
        }
        private void lblbXuatTKDT_MTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "DT_MTG";
            XuatThongKe_GUI xuatThongKe = new XuatThongKe_GUI();
            xuatThongKe.Show();
        }
        private void lbkXuatTKDT_TQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "DT_TQ";
            XuatThongKe_GUI xuatThongKe = new XuatThongKe_GUI();
            xuatThongKe.Show();
        }

        //------------------------------THỐNG KÊ MẶT HÀNG------------------------------------
        public void KhongCoDuLieu_TKHH()
        {
            pic_TKHH_KCDL.Visible = true;
            pic_TKHH_KCDL.BringToFront();
            p_KQ_TKHH_MTG.Visible = p_KQ_TKHH_NTN.Visible = p_KQ_TKHH_Q.Visible = false;
        }

        private void btnTKHH_NTN_Click(object sender, EventArgs e)
        {
            TKNTN_TG = dtTKHH_NTN.Value.Date;
            loaiTGTK = string.Empty;
            foreach (RadioButton r in p_TKHH_NTN.Controls)
            {
                if (r.Checked == true)
                {
                    if (r.Text == "Ngày")
                        loaiTGTK = "ngay";
                    else if (r.Text == "Tháng")
                        loaiTGTK = "thang";
                    else if (r.Text == "Năm")
                        loaiTGTK = "nam";
                }
            }
            DataTable tkhh_NTN = new DataTable();
            tkhh_NTN=thongKe_BUS.thongKeHangHoa_NTN_BUS(loaiTGTK, TKNTN_TG);
            if (tkhh_NTN.Rows.Count > 0)
            {
                p_KQ_TKHH_NTN.Visible = true;
                pic_TKHH_KCDL.Visible = false;
                dgvTKHH_NTN.DataSource = tkhh_NTN;
                foreach (DataRow r in tkhh_NTN.Rows)
                {
                    decimal sum = tkhh_NTN.AsEnumerable().Select(row => row.Field<decimal>("TongGia")).Distinct().Sum();
                    lblTKHH_NTN.Text = sum.ToString("#,##0.000 VNĐ");
                }
            }
            else
            {
                KhongCoDuLieu_TKHH();
            }
        }

        private void btnTKHH_MTG_Click(object sender, EventArgs e)
        {
            if (dtTKHH_MTG_TG1.Value > dt_TKHH_MTG_TG2.Value)
            {
                MessageBox.Show("Mốc thời gian trước không được nhỏ hơn mốc thời gian sau");
            }
            else
            {
                TKMTG_TG1 = dtTKHH_MTG_TG1.Value.Date;
                TKMTG_TG2 = dt_TKHH_MTG_TG2.Value.Date;
                DataTable tthh_MTG = thongKe_BUS.thongKeHangHoa_MTG_BUS(TKMTG_TG1,TKMTG_TG2);
                if (tthh_MTG.Rows.Count > 0)
                {
                    p_KQ_TKHH_MTG.Visible = true;
                    p_KQ_TKHH_MTG.BringToFront();
                    dgvTKHH_MTG.DataSource = tthh_MTG;
                    foreach (DataRow r in tthh_MTG.Rows)
                    {
                        decimal sum = tthh_MTG.AsEnumerable().Select(row => row.Field<decimal>("TongGia")).Distinct().Sum();
                        lblTKHH_MTG.Text =sum.ToString("#,##0.000 VNĐ");
                    }
                }
                else
                {
                    KhongCoDuLieu_TKHH();
                }
            }

        }

        private void btnTTHH_Q_Click(object sender, EventArgs e)
        {
            TK_TQ_nam = Convert.ToInt32(dtTKHH_Nam.Value.Year);
            quyList = string.Empty;
            
            DataTable tkhh_Q = new DataTable();
            
            foreach (Control c in grbTKHH_Q.Controls)
            {
                CheckBox quyC = c as CheckBox;
                if (quyC != null && quyC.Checked)
                {
                    quyList += quyC.Text + ",";
                }
            }
            quyList = quyList.TrimEnd(',');

            DataSet thongKeHH_Q = thongKe_BUS.thongKeHangHoa_TQ_BUS(TK_TQ_nam, quyList);

            if (thongKeHH_Q.Tables.Count > 0)
            {
                foreach (DataTable tb in thongKeHH_Q.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tkhh_Q.Merge(tb);
                }
                if (tkhh_Q.Rows.Count > 0)
                {
                    p_KQ_TKHH_Q.Visible = true;
                    p_KQ_TKHH_Q.BringToFront();
                    dgvTKHH_Q.DataSource = tkhh_Q;
                    foreach (DataRow r in tkhh_Q.Rows)
                    {
                        decimal sum = tkhh_Q.AsEnumerable().Select(row => row.Field<decimal>("TongGia")).Distinct().Sum();
                        lblTKHH_Q.Text = sum.ToString("#,##0.000 VNĐ");
                    }
                }
                else
                {
                    KhongCoDuLieu_TKHH();
                }

            }
        }


        private void rdbTKHH_NTN_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTKHH_NTN.Checked)
            {
                p_TKHH_NTN.Enabled = true;
                grbTKHH_NTN.Visible = true;
                grbTKHH_MTG.Visible = false;
                grbTKHH_Q.Visible = false;
            }    
            else
            {
                grbTKHH_NTN.Visible = false;
                grbTKHH_NTN.Enabled = false;
                p_TKHH_NTN.Enabled = false;
                p_KQ_TKHH_NTN.Visible = false;
                foreach (RadioButton r in p_TKHH_NTN.Controls)
                {
                    if (r.Checked == true)
                        r.Checked = false;
                }    
            }
        }

        private void rdbTKHH_MTG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_MTG.Checked)
            {
                grbTKHH_NTN.Visible = false;
                grbTKHH_MTG.Visible = true;
                grbTKHH_Q.Visible = false;
            }
            else
            {
                grbTKHH_MTG.Visible = false;
                p_KQ_TKHH_MTG.Visible = false;
            }
        }

        private void rdbTKHH_Q_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_Q.Checked)
            {
                grbTKHH_NTN.Visible = false;
                grbTKHH_MTG.Visible = false;
                grbTKHH_Q.Visible = true;
            }
            else
            {
                grbTKHH_Q.Visible = false;
                p_KQ_TKHH_Q.Visible = false;
            }
        }

        private void rdbTKHH_D_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTKHH_D.Checked)
            {
                grbTKHH_NTN.Enabled = true;
                dtTKHH_NTN.CustomFormat = "dd/MM/yyyy";
                dtTKHH_NTN.Format = DateTimePickerFormat.Custom;
            }    
        }

        private void rdbTKHH_M_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_M.Checked)
            {
                grbTKHH_NTN.Enabled = true;
                dtTKHH_NTN.CustomFormat = "MM/yyyy";
                dtTKHH_NTN.Format = DateTimePickerFormat.Custom;
            }
        }

        private void rdbTKHH_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_Y.Checked)
            {
                grbTKHH_NTN.Enabled = true;
                dtTKHH_NTN.CustomFormat = "yyyy";
                dtTKHH_NTN.Format = DateTimePickerFormat.Custom;
            }
        }
      
        private void dtTKHH_Nam_ValueChanged(object sender, EventArgs e)
        {
            dtTKHH_Nam.MaxDate= DateTime.Now;
            dtTKHH_Nam.MinDate = Convert.ToDateTime("22/11/2001");
        }

        private void lbkXuat_TKHH_Q_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "HH_Q";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }

        private void lbkXuat_TKHH_NTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "HH_NTN";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }

        private void lbkXuat_TKHH_MTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "HH_MTG";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }


        //------------------------------THỐNG KÊ SẢN PHẨM------------------------------------

    }
}
