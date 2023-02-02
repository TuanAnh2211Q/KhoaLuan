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
using CrystalDecisions.CrystalReports.Engine;

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
            if (loaiThongKe=="DT_NTN")
            {
                rpt_TKDT_NTN rptXuatTKDT_NTN = new rpt_TKDT_NTN();
                DataTable tb = thongke.thongKeDoanhThu_BUS(ThongKe_GUI.loaiTGTK, ThongKe_GUI.DT_NTN);
                rptXuatTKDT_NTN.SetDataSource(tb);

                TextObject title = (TextObject)rptXuatTKDT_NTN.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                if(ThongKe_GUI.loaiTGTK=="ngay")
                {
                    title.Text = "Ngày: " + ThongKe_GUI.DT_NTN;
                }
                else if (ThongKe_GUI.loaiTGTK == "thang")
                {
                    title.Text = "Tháng: " + ThongKe_GUI.DT_NTN.Month+"/"+ThongKe_GUI.DT_NTN.Year;
                }
                else if (ThongKe_GUI.loaiTGTK == "nam")
                {
                    title.Text = "Năm: " + ThongKe_GUI.DT_NTN.Year;
                }
                title.Color = Color.Red;
                crvXuatThongKe.ReportSource = rptXuatTKDT_NTN;
            }
            else if(loaiThongKe == "DT_MTG")
            {
                rpt_TKDT_MTG rpt_XuatTKDT_MTG = new rpt_TKDT_MTG();
                DataTable tb = thongke.thongKeDoanhThu_MTG_BUS(ThongKe_GUI.TKDT_TG1, ThongKe_GUI.TKDT_TG2);
                rpt_XuatTKDT_MTG.SetDataSource(tb);
                TextObject title = (TextObject)rpt_XuatTKDT_MTG.ReportDefinition.Sections[1].ReportObjects["txtThoiGianThongKe"];
                title.Text = "Từ ngày " + ThongKe_GUI.TKDT_TG1.ToShortDateString() + " đến ngày " + ThongKe_GUI.TKDT_TG2.ToShortDateString();
                title.Color = Color.Red;
                crvXuatThongKe.ReportSource = rpt_XuatTKDT_MTG;
            }
        }
    }
}
