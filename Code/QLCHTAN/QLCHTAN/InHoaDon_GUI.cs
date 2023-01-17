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
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace QLCHTAN
{
    public partial class InHoaDon_GUI : Form
    {
        DataProvider data = new DataProvider();
        public InHoaDon_GUI()
        {
            InitializeComponent();
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void InHoaDon_GUI_Load(object sender, EventArgs e)
        {
            data.Open();
            rptHoaDonMuaHang prtHDMH = new rptHoaDonMuaHang();
            SqlDataAdapter da = new SqlDataAdapter("print_HoaDonBanHang",data.conn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = ThongTinDonHang_GUI.madh;
            SqlCommand cmd = new SqlCommand("print_TongGia", data.conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@maDonHang", SqlDbType.VarChar).Value = ThongTinDonHang_GUI.madh;
            DataTable ds = new DataTable();
            da.Fill(ds);
            prtHDMH.SetDataSource(ds);

            if (cmd.ExecuteScalar()!=null)
            {
                decimal tong = Math.Round(Convert.ToDecimal(cmd.ExecuteScalar()),3);

                TextObject title = (TextObject)prtHDMH.ReportDefinition.Sections[4].ReportObjects["TongGia"];
                title.Text = tong.ToString() +"VNĐ";
                title.Color = Color.Red;

            }

            crvInHoaDon.ReportSource = prtHDMH;
        }
    }
}
