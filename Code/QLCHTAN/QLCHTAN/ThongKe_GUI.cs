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

        //Biến cho thống kê theo mặt hàng
        public static string TKTMH;

        ThongKe_BUS thongKe_BUS = new ThongKe_BUS();
        SanPham_BUS sanPham_BUS = new SanPham_BUS();
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

        private void btnTKHH_TMH_Click(object sender, EventArgs e)
        {
            TKTMH = String.Empty;
            if (rdbTKHH_TMH_TC.Checked)
            {
                TKTMH = "all";
            }   
            else if(rdbTKHH_TMH_MH.Checked)
            {
                TKTMH = cbbTKHH_TMH.SelectedValue.ToString().Trim();
            }    
            DataTable tkhh_TMH = new DataTable();
            tkhh_TMH = thongKe_BUS.thongKeHangHoa_TMH_BUS(TKTMH);
            if (tkhh_TMH.Rows.Count > 0)
            {
                p_TKHH_TMH.Visible = true;
                pic_TKHH_KCDL.Visible = false;
                dgvTKHH_TMH.DataSource = tkhh_TMH;
                foreach (DataRow r in tkhh_TMH.Rows)
                {
                    decimal sum = tkhh_TMH.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Distinct().Sum();
                    lblTKHH_TMH.Text = sum.ToString("#,##0.000 VNĐ");
                }
            }
            else
            {
                p_TKHH_TMH.Visible = false;
                KhongCoDuLieu_TKHH();
            }
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
            else
                KhongCoDuLieu_TKHH();
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

        private void rdbTKHH_TQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_TQ.Checked)
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


        private void rdbTKHH_TMH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_TMH.Checked)
            {
                grbTKHH_MTH.Enabled=true;
                grbTKHH_MTH.Visible = true;
                grbTKHH_MTH.BringToFront();
                MatHang_BUS mathang = new MatHang_BUS();
                cbbTKHH_TMH.DataSource = mathang.select_MatHang();
                cbbTKHH_TMH.DisplayMember = "tenHang";
                cbbTKHH_TMH.ValueMember = "maHang";

            }
            else
            {
                grbTKHH_MTH.Visible = false;
                grbTKHH_MTH.SendToBack();
                p_TKHH_TMH.Visible = false;
            }
        }

        private void rdbTKHH_TMH_MH_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKHH_TMH_MH.Checked)
            {
                cbbTKHH_TMH.Enabled = true;
            }
            else
            {
                cbbTKHH_TMH.Enabled = false;
            }
        }
        private void lblbXuat_TKHH_TMH_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "HH_TMH";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }

        //------------------------------THỐNG KÊ SẢN PHẨM------------------------------------
        public void KhongCoDuLieuThongKe_TKSP()
        {
            pic_KCDL_TKSP.Visible = true;
            pic_KCDL_TKSP.BringToFront();
        }
        private void rdbTKSP_NTN_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbTKSP_NTN.Checked)
            {
                p_TKSP_NTN_Chon.Enabled = true;
                grbTKSP_NTN.Visible = true;
                grbTKSP_NTN.BringToFront();
            }    
            else
            {
                foreach (RadioButton r in p_TKSP_NTN_Chon.Controls)
                {
                    r.Checked = false;
                }
                p_TKSP_NTN_Chon.Enabled = false;
                p_TKSP_NTN.Visible = false;
                grbTKSP_NTN.Visible = false;
                grbTKSP_NTN.SendToBack();
                 
            }
        }

        private void rdbTKSP_MTG_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_MTG.Checked)
            {
                grbTKSP_MTG.Visible = true;
                grbTKSP_NTN.BringToFront();
            }
            else
            {
                p_TKSP_MTG.Visible = false;
                p_TKSP_MTG.Enabled = false;
                grbTKSP_MTG.Visible = false;
                grbTKSP_MTG.SendToBack();
            }
        }

        private void rdbTKSP_TQ_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_TQ.Checked)
            {
                grbTKSP_TQ.Visible = true;
                grbTKSP_TQ.BringToFront();
            }
            else
            {
                p_TKSP_TQ.Visible = false;
                p_TKSP_TQ.Enabled = false;
                grbTKSP_TQ.Visible = false;
                grbTKSP_TQ.SendToBack();
            }
        }

        private void rdbTKSP_D_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_D.Checked)
            {
                grbTKSP_NTN.Enabled = true;
                dtTKSP_NTN.CustomFormat = "dd/MM/yyyy";
                dtTKSP_NTN.Format = DateTimePickerFormat.Custom;
            }
        }

        private void rdbTKSP_M_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_M.Checked)
            {
                grbTKSP_NTN.Enabled = true;
                dtTKSP_NTN.CustomFormat = "MM/yyyy";
                dtTKSP_NTN.Format = DateTimePickerFormat.Custom;
            }
           
        }
        private void rdbTKSP_TSP_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_TSP.Checked)
            {
                grbTKSP_TSP.Visible = true;
                grbTKSP_TSP.Enabled = true;
                grbTKSP_TSP.BringToFront();
                cbbTKSP_TSP.DataSource = sanPham_BUS.select_SanPham_DAO();
                cbbTKSP_TSP.DisplayMember = "tenSanPham";
                cbbTKSP_TSP.ValueMember = "maSanPham";
            }
            else
            {
                p_TKSP_TSP.Visible = false;
                p_TKSP_TSP.Enabled = false;
                grbTKSP_TSP.Visible = false;
                grbTKSP_TSP.SendToBack();
            }
        }


        private void rdbTKSP_Y_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_Y.Checked)
            {
                grbTKSP_NTN.Enabled = true;
                dtTKSP_NTN.CustomFormat = "yyyy";
                dtTKSP_NTN.Format = DateTimePickerFormat.Custom;
            }
           
        }

        private void rdbTKSP_Chon_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbTKSP_Chon.Checked)
                cbbTKSP_TSP.Enabled = true;
            else
                cbbTKSP_TSP.Enabled = false;

        }
        private void btnTKSP_NTN_Click(object sender, EventArgs e)
        {
            TKNTN_TG = dtTKSP_NTN.Value.Date;
            loaiTGTK = string.Empty;
            foreach (RadioButton r in p_TKSP_NTN_Chon.Controls)
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
            DataTable tksp_NTN = new DataTable();
            tksp_NTN = thongKe_BUS.thongKeSanPham_NTN_BUS(loaiTGTK, TKNTN_TG);
            if (tksp_NTN.Rows.Count > 0)
            {
                p_TKSP_NTN.Visible = true;
                p_TKSP_NTN.BringToFront();
                pic_KCDL_TKSP.Visible = false;
                dgvTKSP_NTN.DataSource = tksp_NTN;
                foreach (DataRow r in tksp_NTN.Rows)
                {
                    decimal sum = tksp_NTN.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                    lblTongGiaTKSP_NTN.Text = sum.ToString("#,##0.000 VNĐ");
                }
            }
            else
            {
                KhongCoDuLieuThongKe_TKSP();
            }
        }

        private void btnTKSP_MTG_Click(object sender, EventArgs e)
        {
            if (dtTKSP_MTG_TG1.Value > dtTKSP_MTG_TG2.Value)
            {
                MessageBox.Show("Mốc thời gian trước không được nhỏ hơn mốc thời gian sau");
            }
            else
            {
                TKMTG_TG1 = dtTKSP_MTG_TG1.Value.Date;
                TKMTG_TG2 = dtTKSP_MTG_TG2.Value.Date;
                DataTable tksp_MTG = thongKe_BUS.thongKeSanPham_MTG_BUS(TKMTG_TG1, TKMTG_TG2);
                if (tksp_MTG.Rows.Count > 0)
                {
                    p_TKSP_MTG.Visible = true;
                    p_TKSP_MTG.BringToFront();
                    dgvTKSP_MTG.DataSource = tksp_MTG;
                    foreach (DataRow r in tksp_MTG.Rows)
                    {
                        decimal sum = tksp_MTG.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                        lblTongGiaTKSP_MTG.Text = sum.ToString("#,##0.000 VNĐ");
                    }
                }
                else
                {
                    KhongCoDuLieuThongKe_TKSP();
                }
            }
        }

        private void btnTKSP_TQ_Click(object sender, EventArgs e)
        {
            TK_TQ_nam = Convert.ToInt32(dtTKSP_Nam.Value.Year);
            quyList = string.Empty;

            DataTable tksp_Q = new DataTable();

            foreach (Control c in grbTKSP_TQ.Controls)
            {
                CheckBox quyC = c as CheckBox;
                if (quyC != null && quyC.Checked)
                {
                    quyList += quyC.Text + ",";
                }
            }
            quyList = quyList.TrimEnd(',');

            DataSet thongKeSP_Q = thongKe_BUS.thongKeSanPham_TQ_BUS(TK_TQ_nam, quyList);

            if (thongKeSP_Q.Tables.Count > 0)
            {
                foreach (DataTable tb in thongKeSP_Q.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tksp_Q.Merge(tb);
                }
                if (tksp_Q.Rows.Count > 0)
                {
                    p_TKSP_TQ.Visible = true;
                    p_TKSP_TQ.BringToFront();
                    pic_KCDL_TKSP.Visible = false;
                    dgvTKSP_TQ.DataSource = tksp_Q;
                    foreach (DataRow r in tksp_Q.Rows)
                    {
                        decimal sum = tksp_Q.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                        lblTongGiaTKSP_TQ.Text = sum.ToString("#,##0.000 VNĐ");
                    }
                }
                else
                {
                    KhongCoDuLieuThongKe_TKSP();
                }

            }
            else
                KhongCoDuLieuThongKe_TKSP();
           
        }

     

        private void btnTKSP_TSP_Click(object sender, EventArgs e)
        {
            TKTMH = String.Empty;
            if (rdbTKSP_All.Checked)
            {
                TKTMH = "all";
            }
            else if (rdbTKSP_Chon.Checked)
            {
                TKTMH = cbbTKSP_TSP.SelectedValue.ToString().Trim();
            }
            DataTable tksp_TSP = new DataTable();
            tksp_TSP = thongKe_BUS.thongKeSanPham_TSP_BUS(TKTMH);
            if (tksp_TSP.Rows.Count > 0)
            {
                p_TKSP_TSP.Visible = true;
                pic_KCDL_TKSP.Visible = false;
                dgvTKSP_TSP.DataSource = tksp_TSP;
                foreach (DataRow r in tksp_TSP.Rows)
                {
                    decimal sum = tksp_TSP.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                    lblTongTienTKSP_TSP.Text = sum.ToString("#,##0.000 VNĐ");
                }
            }
            else
            {
                p_TKSP_TSP.Visible = false;
                KhongCoDuLieu_TKHH();
            }
        }
        private void lblkXuatTKSP_NTN_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "SP_NTN";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }

        private void lblkXuatTKSP_TQ_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "SP_TQ";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }

        private void lbkXuatTKSP_MTG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "SP_MTG";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }

        private void lblkTKSP_TSP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoaiThongKe = "SP_TSP";
            XuatThongKe_GUI xuatThongKe_GUI = new XuatThongKe_GUI();
            xuatThongKe_GUI.Show();
        }
    }
}
