using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLCHTAN
{
    public partial class Order_GUI : Form
    {
        public Order_GUI()
        {
            InitializeComponent();

        }
        #region Method

        public Form currentFormChild;
        public void openChildForm(Form childForm)
        {
            if(currentFormChild!=null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelThan.Controls.Add(childForm);
            panelThan.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    
        #endregion


        #region Event
        private void btnMenu_Click(object sender, EventArgs e)
        {
            openChildForm(new DanhMucKhuyenMai_GUI());
            label1.Text = btnKhuyenMai.Text;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            openChildForm(new ThanhToan_GUI());
            label1.Text = btnThanhToan.Text;
        }

        private void btnOder_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderDoAn_GUI());
            label1.Text = "Bảng Oder Khách";
        }
        private void btnNuoc_Click(object sender, EventArgs e)
        {
            openChildForm(new OrderNuoc_GUI());
            label1.Text = btnNuoc.Text;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
           DialogResult result=  MessageBox.Show("Bạn có muốn thoát ?", "Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result== System.Windows.Forms.DialogResult.Yes)
            {
                //Main_GUI t = new Main_GUI();
                //t.Show();
            }
        }




        #endregion

       
    }
}
