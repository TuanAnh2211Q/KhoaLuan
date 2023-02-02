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

        //Biến cho thống kê doanh thu ngày tháng năm
        public static DateTime DT_NTN;
        public static string loaiTGTK = "";

        //Biến cho thống kê doanh thu theo mốc thời gian
        public static DateTime TKDT_TG1;
        public static DateTime TKDT_TG2;

        ThongKe_BUS thongKe_BUS = new ThongKe_BUS();

        private void btnThongKe_Click(object sender, EventArgs e)
        {
                DT_NTN = dtTKDT_ThoiGianThongKe.Value.Date;
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




        private void btnTKDT_MTG_Click(object sender, EventArgs e)
        {
            if (dtTKDT_TG1.Value > dtTKDT_TG2.Value)
            {
                MessageBox.Show("Mốc thời gian trước không được nhỏ hơn mốc thời gian sau");
            }
            else
            {
                TKDT_TG1 = dtTKDT_TG1.Value.Date;
                TKDT_TG2 = dtTKDT_TG2.Value.Date;
                DataTable thongKeDT_MTG = thongKe_BUS.thongKeDoanhThu_MTG_BUS(TKDT_TG1.Date, TKDT_TG2.Date);
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

        private void btnTKDT_TQ_Click(object sender, EventArgs e)
        {
            DataTable tkdttq = new DataTable();
            int nam = Convert.ToInt32(dtTKTQ_Nam.Value.Year);
            string quyList=string.Empty;
            foreach(Control c in grbTKTQ_Quy.Controls)
            {
                CheckBox quyC = c as CheckBox;
                if(quyC !=null && quyC.Checked)
                {
                    quyList += quyC.Text + ",";
                }    
            }
            quyList = quyList.TrimEnd(',');

            DataSet thongKeDT_TQ = thongKe_BUS.thongKeDoanhThu_TQ_BUS(nam, quyList);

            if (thongKeDT_TQ.Tables.Count > 0)
            {
                foreach(DataTable tb in thongKeDT_TQ.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tkdttq.Merge(tb);
                }
                if (tkdttq.Rows.Count>0)
                {
                        dgvTKDT_TQ.DataSource = tkdttq;
                        picTKDT_TQ.Visible = false;
                    foreach (DataRow r in tkdttq.Rows)
                    {
                        lblTongDT_TKDT_TQ.Text = r.Field<decimal>("tongDoanhThu").ToString("#,##0.000 VNĐ");
                        break;
                    }
                }
                else
                {
                    picTKDT_TQ.Visible = true;
                }

            }
           
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
            LoaiThongKe = "DT_NTN";
            XuatThongKe_GUI xuatThongKe = new XuatThongKe_GUI();
            xuatThongKe.Show();
        }
        private void lblbXuatTKDT_MTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "DT_MTG";
            XuatThongKe_GUI xuatThongKe = new XuatThongKe_GUI();
            xuatThongKe.Show();
        }

        //------------------------------THỐNG KÊ NGUYÊN LIỆU------------------------------------
        public void KhongCoDuLieu_TKNL_SD()
        {
            pic_TKNL_SD_KCDL.Visible = true;
            pic_TKNL_SD_KCDL.BringToFront();
        }

        private void rdbTKNL_SD_NTN_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTKNL_SD_NTN.Checked)
            {
                p_TKNL_SD_NTN.Enabled = true;
                grbTKNL_SD_NTN.Visible = true;
                grbTKNL_SD_MTG.Visible = false;
                grbTKNL_SD_Q.Visible = false;
            }    
            else
            {
                grbTKNL_SD_NTN.Visible = false;
                grbTKNL_SD_NTN.Enabled = false;
                p_TKNL_SD_NTN.Enabled = false;
                p_KQ_TKNL_SD_NTN.Visible = false;
                foreach (RadioButton r in p_TKNL_SD_NTN.Controls)
                {
                    if (r.Checked == true)
                        r.Checked = false;
                }    
            }
        }

        private void rdbTKNL_SD_MTG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKNL_SD_MTG.Checked)
            {
                grbTKNL_SD_NTN.Visible = false;
                grbTKNL_SD_MTG.Visible = true;
                grbTKNL_SD_Q.Visible = false;
            }
            else
            {
                grbTKNL_SD_MTG.Visible = false;
                p_KQ_TKNL_SD_MTG.Visible = false;
            }
        }

        private void rdbTKNL_SD_Q_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKNL_SD_Q.Checked)
            {
                grbTKNL_SD_NTN.Visible = false;
                grbTKNL_SD_MTG.Visible = false;
                grbTKNL_SD_Q.Visible = true;
            }
            else
            {
                grbTKNL_SD_Q.Visible = false;
                p_KQ_TKNL_SD_Q.Visible = false;
            }
        }

        private void rdbTKNL_SD_D_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTKNL_SD_D.Checked)
            {
                grbTKNL_SD_NTN.Enabled = true;
                dtTKNL_SD_NTN.CustomFormat = "dd/MM/yyyy";
                dtTKNL_SD_NTN.Format = DateTimePickerFormat.Custom;
            }    
        }

        private void rdbTKNL_SD_M_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKNL_SD_M.Checked)
            {
                grbTKNL_SD_NTN.Enabled = true;
                dtTKNL_SD_NTN.CustomFormat = "MM/yyyy";
                dtTKNL_SD_NTN.Format = DateTimePickerFormat.Custom;
            }
        }

        private void rdbTKNL_SD_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKNL_SD_Y.Checked)
            {
                grbTKNL_SD_NTN.Enabled = true;
                dtTKNL_SD_NTN.CustomFormat = "yyyy";
                dtTKNL_SD_NTN.Format = DateTimePickerFormat.Custom;
            }
        }

        private void btnTTKNL_SD_NTN_Click(object sender, EventArgs e)
        {
            p_KQ_TKNL_SD_NTN.Visible = true;
            
            string loai = string.Empty;
            foreach (RadioButton r in p_TKNL_SD_NTN.Controls)
            {
                if (r.Checked == true)
                {
                    if (r.Text == "Ngày")
                        loai = "ngay";
                    else if (r.Text == "Tháng")
                        loai = "thang";
                    else if (r.Text == "Năm")
                        loai = "nam";
                }   
            }
            DataTable tknlsd_NTN = thongKe_BUS.thongKeNguyenLieuSuDung_NTN_BUS(loai, dtTKNL_SD_NTN.Value.Date);
            if (tknlsd_NTN.Rows.Count > 0)
            {
                pic_TKNL_SD_KCDL.Visible = false;
                dgvTKNL_SD_NTN.DataSource = tknlsd_NTN;
                foreach (DataRow r in tknlsd_NTN.Rows)
                {
                    lblTKNL_SD_NTN.Text = r.Field<decimal>("TongGia").ToString("#,##0.000 VNĐ");
                    break;
                }
            }
            else
            {
                KhongCoDuLieu_TKNL_SD();
            }
        }

        private void btnTTKNL_SD_MTG_Click(object sender, EventArgs e)
        {
            if (dtTKNL_SD_MTG_TG1.Value > dt_TKNL_SD_MTG_TG2.Value)
            {
                MessageBox.Show("Mốc thời gian trước không được nhỏ hơn mốc thời gian sau");
            }
            else
            {
                DataTable TKNLSD_MTG = thongKe_BUS.thongKeNguyenLieuSuDung_MTG_BUS(dtTKNL_SD_MTG_TG1.Value.Date, dt_TKNL_SD_MTG_TG2.Value.Date);
                if (TKNLSD_MTG.Rows.Count > 0)
                {
                    p_KQ_TKNL_SD_MTG.Visible = true;
                    p_KQ_TKNL_SD_MTG.BringToFront();
                    dgvTKNL_SD_MTG.DataSource = TKNLSD_MTG;
                    foreach (DataRow r in TKNLSD_MTG.Rows)
                    {
                        lblTKNL_SD_MTG.Text = r.Field<decimal>("TongGia").ToString("#,##0.000 VNĐ");
                        break;
                    }
                }
                else
                {
                    KhongCoDuLieu_TKNL_SD();
                }
            }

        }

        private void btnTTKNL_SD_Q_Click(object sender, EventArgs e)
        {
            DataTable tknlsd_q = new DataTable();
            int nam = Convert.ToInt32(dtTKNL_SD_Nam.Value.Year);
            string quyList = string.Empty;
            foreach (Control c in grbTKNL_SD_Q.Controls)
            {
                CheckBox quyC = c as CheckBox;
                if (quyC != null && quyC.Checked)
                {
                    quyList += quyC.Text + ",";
                }
            }
            quyList = quyList.TrimEnd(',');

            DataSet thongKeNLSD_Q = thongKe_BUS.thongKeNguyenLieuSuDung_Q_BUS(nam, quyList);

            if (thongKeNLSD_Q.Tables.Count > 0)
            {
                foreach (DataTable tb in thongKeNLSD_Q.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tknlsd_q.Merge(tb);
                }
                if (tknlsd_q.Rows.Count > 0)
                {
                    p_KQ_TKNL_SD_Q.Visible = true;
                    p_KQ_TKNL_SD_Q.BringToFront();
                    dgvTKNL_SD_Q.DataSource = tknlsd_q;
                    foreach (DataRow r in tknlsd_q.Rows)
                    {
                        lblTKNL_SD_Q.Text = r.Field<decimal>("TongGia").ToString("#,##0.000 VNĐ");
                        break;
                    }
                }
                else
                {
                    KhongCoDuLieu_TKNL_SD();
                }

            }
        }

        private void dtTKNL_SD_Nam_ValueChanged(object sender, EventArgs e)
        {
            dtTKNL_SD_Nam.MaxDate= DateTime.Now;
            dtTKNL_SD_Nam.MinDate = Convert.ToDateTime("22/11/2001");
        }

      
    }
}
