using BUS;
using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLCHTAN
{
    public partial class XuatThongKe_GUI : Form
    {
        public XuatThongKe_GUI()
        {
            InitializeComponent();
        }
        ThongKe_BUS thongke = new ThongKe_BUS();
        private void XuatThongKe_GUI_Load(object sender, EventArgs e)
        {
            string loaiThongKe = ThongKe_GUI.LoaiThongKe;
            if (loaiThongKe == "TKNTN_TG")
            {
                rpt_TKDT_NTN rptXuatTKDT_NTN = new rpt_TKDT_NTN();
                DataTable tb = thongke.thongKeDoanhThu_BUS(ThongKe_GUI.loaiTGTK, ThongKe_GUI.TKNTN_TG);
                rptXuatTKDT_NTN.SetDataSource(tb);

                TextObject title = (TextObject)rptXuatTKDT_NTN.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                if (ThongKe_GUI.loaiTGTK == "ngay")
                {
                    title.Text = "Ngày: " + ThongKe_GUI.TKNTN_TG.ToShortDateString();
                }
                else if (ThongKe_GUI.loaiTGTK == "thang")
                {
                    title.Text = "Tháng: " + ThongKe_GUI.TKNTN_TG.Month + "/" + ThongKe_GUI.TKNTN_TG.Year;
                }
                else if (ThongKe_GUI.loaiTGTK == "nam")
                {
                    title.Text = "Năm: " + ThongKe_GUI.TKNTN_TG.Year;
                }
                title.Color = Color.Red;
                crvXuatThongKe.ReportSource = rptXuatTKDT_NTN;
            }
            else if (loaiThongKe == "DT_MTG")
            {
                rpt_TKDT_MTG rpt_XuatTKDT_MTG = new rpt_TKDT_MTG();
                DataTable tb = thongke.thongKeDoanhThu_MTG_BUS(ThongKe_GUI.TKMTG_TG1, ThongKe_GUI.TKMTG_TG2);
                rpt_XuatTKDT_MTG.SetDataSource(tb);
                TextObject title = (TextObject)rpt_XuatTKDT_MTG.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Từ ngày " + ThongKe_GUI.TKMTG_TG1.ToShortDateString() + " đến ngày " + ThongKe_GUI.TKMTG_TG2.ToShortDateString();
                title.Color = Color.Red;
                crvXuatThongKe.ReportSource = rpt_XuatTKDT_MTG;
            }
            else if (loaiThongKe == "DT_TQ")
            {
                rpt_TKDT_TQ rpt_XuatTKDT_TQ = new rpt_TKDT_TQ();
                DataTable tb = new DataTable();
                DataSet ts = thongke.thongKeDoanhThu_TQ_BUS(ThongKe_GUI.TK_TQ_nam, ThongKe_GUI.quyList);
                foreach (DataTable tb2 in ts.Tables)
                {
                    if (tb2.Rows.Count >= 0)
                        tb.Merge(tb2);
                }

                rpt_XuatTKDT_TQ.SetDataSource(tb);
                TextObject title = (TextObject)rpt_XuatTKDT_TQ.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Quý" + ThongKe_GUI.quyList;
                title.Color = Color.Red;

                TextObject tongDT = (TextObject)rpt_XuatTKDT_TQ.ReportDefinition.Sections[4].ReportObjects["txtTongDoanhThu"];
                foreach (DataRow r in tb.Rows)
                {
                    decimal tDT = tb.AsEnumerable().Select(row => row.Field<decimal>("tongDoanhThu")).Distinct().Sum();
                    tongDT.Text = tDT.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_XuatTKDT_TQ;
            }
            else if (loaiThongKe == "HH_NTN")
            {
                rpt_TKHH_NTN rpt_Xuat = new rpt_TKHH_NTN();
                DataTable ts = thongke.thongKeHangHoa_NTN_BUS(ThongKe_GUI.loaiTGTK, ThongKe_GUI.TKNTN_TG);
                rpt_Xuat.SetDataSource(ts);

                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                if (ThongKe_GUI.loaiTGTK == "ngay")
                {
                    title.Text = "Ngày: " + ThongKe_GUI.TKNTN_TG.ToShortDateString();
                }
                else if (ThongKe_GUI.loaiTGTK == "thang")
                {
                    title.Text = "Tháng: " + ThongKe_GUI.TKNTN_TG.Month + "/" + ThongKe_GUI.TKNTN_TG.Year;
                }
                else if (ThongKe_GUI.loaiTGTK == "nam")
                {
                    title.Text = "Năm: " + ThongKe_GUI.TKNTN_TG.Year;
                }
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in ts.Rows)
                {
                    decimal sum = ts.AsEnumerable().Select(row => row.Field<decimal>("TongGia")).Distinct().Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }
            else if (loaiThongKe == "HH_Q")
            {
                rpt_TKHH_Q rpt_Xuat = new rpt_TKHH_Q();
                DataSet ts = thongke.thongKeHangHoa_TQ_BUS(ThongKe_GUI.TK_TQ_nam, ThongKe_GUI.quyList);
                DataTable tknlsd_q = new DataTable();
                foreach (DataTable tb in ts.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tknlsd_q.Merge(tb);
                }

                rpt_Xuat.SetDataSource(tknlsd_q);


                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Quý " + ThongKe_GUI.quyList;
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in tknlsd_q.Rows)
                {
                    decimal sum = tknlsd_q.AsEnumerable().Select(row => row.Field<decimal>("TongGia")).Distinct().Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }

            else if (loaiThongKe == "HH_MTG")
            {
                rpt_TKHH_MTG rpt_Xuat = new rpt_TKHH_MTG();
                DataTable ts = thongke.thongKeHangHoa_MTG_BUS(ThongKe_GUI.TKMTG_TG1, ThongKe_GUI.TKMTG_TG2);
                rpt_Xuat.SetDataSource(ts);

                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Từ ngày " + ThongKe_GUI.TKMTG_TG1.ToShortDateString() + " đến ngày " + ThongKe_GUI.TKMTG_TG2.ToShortDateString();
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in ts.Rows)
                {
                    decimal sum = ts.AsEnumerable().Select(row => row.Field<decimal>("TongGia")).Distinct().Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }

            else if(loaiThongKe=="HH_TMH")
            {
                rpt_TKHH_TMH rpt_Xuat = new rpt_TKHH_TMH();
                DataTable ts = thongke.thongKeHangHoa_TMH_BUS(ThongKe_GUI.TKTMH);
                rpt_Xuat.SetDataSource(ts);

                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                if (ThongKe_GUI.TKTMH.Trim() == "all")
                    title.Text = "Tất cả các mặt hàng";
                else
                    title.Text = "Mã hàng thống kê: " + ThongKe_GUI.TKTMH;
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in ts.Rows)
                {
                    decimal sum = ts.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Distinct().Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }    
            else if(loaiThongKe=="SP_NTN")
            {
                rpt_TKSP_NTN rpt_Xuat = new rpt_TKSP_NTN();
                DataTable ts = thongke.thongKeSanPham_NTN_BUS(ThongKe_GUI.loaiTGTK, ThongKe_GUI.TKNTN_TG);
                rpt_Xuat.SetDataSource(ts);

                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                if (ThongKe_GUI.loaiTGTK == "ngay")
                {
                    title.Text = "Ngày: " + ThongKe_GUI.TKNTN_TG.ToShortDateString();
                }
                else if (ThongKe_GUI.loaiTGTK == "thang")
                {
                    title.Text = "Tháng: " + ThongKe_GUI.TKNTN_TG.Month + "/" + ThongKe_GUI.TKNTN_TG.Year;
                }
                else if (ThongKe_GUI.loaiTGTK == "nam")
                {
                    title.Text = "Năm: " + ThongKe_GUI.TKNTN_TG.Year;
                }
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in ts.Rows)
                {
                    decimal sum = ts.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }
            else if (loaiThongKe == "SP_TQ")
            {
                rpt_TKSP_TQ rpt_Xuat = new rpt_TKSP_TQ();
                DataSet ts = thongke.thongKeSanPham_TQ_BUS(ThongKe_GUI.TK_TQ_nam, ThongKe_GUI.quyList);
                DataTable tksp_q = new DataTable();
                foreach (DataTable tb in ts.Tables)
                {
                    if (tb.Rows.Count >= 0)
                        tksp_q.Merge(tb);
                }

                rpt_Xuat.SetDataSource(tksp_q);


                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Quý " + ThongKe_GUI.quyList;
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in tksp_q.Rows)
                {
                    decimal sum = tksp_q.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }

            else if (loaiThongKe == "SP_MTG")
            {
                rpt_TKSP_TQ rpt_Xuat = new rpt_TKSP_TQ();
                DataTable ts = thongke.thongKeSanPham_MTG_BUS(ThongKe_GUI.TKMTG_TG1, ThongKe_GUI.TKMTG_TG2);
                rpt_Xuat.SetDataSource(ts);

                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Từ ngày " + ThongKe_GUI.TKMTG_TG1.ToShortDateString() + " đến ngày " + ThongKe_GUI.TKMTG_TG2.ToShortDateString();
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in ts.Rows)
                {
                    decimal sum = ts.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }

            else if (loaiThongKe=="SP_TSP")
            {
                rpt_TKSP_TSP rpt_Xuat = new rpt_TKSP_TSP();
                DataTable ts = thongke.thongKeSanPham_TSP_BUS(ThongKe_GUI.TKTMH);
                rpt_Xuat.SetDataSource(ts);

                TextObject title = (TextObject)rpt_Xuat.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                if (ThongKe_GUI.TKTMH.Trim() == "all")
                    title.Text = "Tất cả các mặt hàng";
                else
                    title.Text = "Mã hàng thống kê: " + ThongKe_GUI.TKTMH;
                title.Color = Color.Red;

                TextObject tongGia = (TextObject)rpt_Xuat.ReportDefinition.Sections[4].ReportObjects["txtTongTien"];

                foreach (DataRow r in ts.Rows)
                {
                    decimal sum = ts.AsEnumerable().Select(row => row.Field<decimal>("tongGiaBan")).Distinct().Sum();
                    tongGia.Text = sum.ToString("#,##0.000 VNĐ");
                }
                crvXuatThongKe.ReportSource = rpt_Xuat;
            }    

        }
    }
}
