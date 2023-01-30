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
using System.Globalization;
using System.IO;

namespace QLCHTAN
{
    public partial class DoAn_GUI : Form
    {
        DoAn_BUS doAn_BUS = new DoAn_BUS();
        public static string tenDoAn;
        public static string maDoAn;
        public byte[] Hinh;
        public DoAn_DTO doAn_DTO()
        {
            
                return new DoAn_DTO(txtMaDoAn.Text, txtTenDoAn.Text, ccbLoaiDoAn.SelectedValue.ToString(), txtDonViBan.Text, Convert.ToSingle(txtDonGia.Text), rtxtGhiChu.Text, Hinh);
           
        }
        public bool kt_DoAnTonTai()
        {
            for(int i=0;i<=dgvDoAn.Rows.Count-1;i++)
            {
                if (dgvDoAn.Rows[i].Cells["maDoAnColumn"].Value.ToString().Trim() == txtMaDoAn.Text.Trim())
                    return true;
            }
            return false;
        }
        public DoAn_GUI()
        {
            InitializeComponent();
        }

        private void btnThanhPhanDoAn_Click(object sender, EventArgs e)
        {
            if (txtTenDoAn.Text == ""&&txtMaDoAn.Text=="")
            {
                MessageBox.Show("Vui lòng không để trống tên đồ ăn và mã đồ ăn");
            }
            else
            {
                maDoAn = txtMaDoAn.Text;
                tenDoAn = txtTenDoAn.Text;
                ThongTinThanhPhanDoAn_GUI tp = new ThongTinThanhPhanDoAn_GUI();
                tp.Show();
            }

        }

        private void DoAn_GUI_Load(object sender, EventArgs e)
        {
            dgvDoAn.DataSource = doAn_BUS.show_list_DoAn_BUS();
            ccbLoaiDoAn.DataSource = doAn_BUS.show_list_LoaiDoAn_BUS();
            ccbLoaiDoAn.DisplayMember = "tenLoaiDoAn";
            ccbLoaiDoAn.ValueMember = "maLoaiDoAn";

        }
      
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDoAn.Text.Trim() != "" && txtTenDoAn.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
            {
                if(!kt_DoAnTonTai())
                {
                    DialogResult them = MessageBox.Show("Bạn muốn thêm đồ ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (them == DialogResult.Yes)
                    {
                        try
                        {

                            if (doAn_BUS.insert_DoAn_ThongTinDoAn_BUS(doAn_DTO()))
                            {

                                MessageBox.Show("Thêm đồ ăn thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Thêm đồ ăn thất bại vui lòng kiểm tra lại thông tin nhập");
                            }


                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            MessageBox.Show("Thêm đồ ăn thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Mã đồ ăn đã tồn tại, vui lòng nhập lại");
                }    

            }
               
            else
            { MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); }
        }

        private void dgvDoAn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow r = dgvDoAn.Rows[e.RowIndex];
                txtMaDoAn.Text = r.Cells["maDoAnColumn"].Value.ToString();
                txtTenDoAn.Text = r.Cells["tenDoAnColumn"].Value.ToString();
                ccbLoaiDoAn.Text = r.Cells["LoaiDoAn"].Value.ToString();
                txtDonViBan.Text = r.Cells["DonViBan"].Value.ToString();
                txtDonGia.Text = r.Cells["DonGia"].Value.ToString();
                rtxtGhiChu.Text = r.Cells["GhiChu"].Value.ToString();
                txtMaDoAn.Enabled = false;
                if (txtTenDoAn.Text == "")
                    btnThanhPhanDoAn.Enabled = false;
                else
                    btnThanhPhanDoAn.Enabled = true;
               if(r.Cells["HinhURL"].Value.ToString()!="")
                {
                    byte[] image=(byte[])r.Cells["HinhURL"].Value;
                    using (var ms = new MemoryStream(image))
                    {
                        picAnhDoAn.Image = Image.FromStream(ms);
                        picAnhDoAn.SizeMode = PictureBoxSizeMode.StretchImage;
                        picAnhDoAn.ClientSize = new Size(133, 169);
                    }
                }
                else
                {
                    picAnhDoAn.Image = null;
                }


            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            DoAn_GUI_Load(sender, e);
            txtMaDoAn.Text = txtTenDoAn.Text = txtDonGia.Text = txtDonViBan.Text = rtxtGhiChu.Text = "";
            ccbLoaiDoAn.SelectedIndex = 0;
            txtMaDoAn.Enabled = true;
            btnThanhPhanDoAn.Enabled = false;
            picAnhDoAn.Image = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
           if(kt_DoAnTonTai())
           {
                DialogResult delete = MessageBox.Show("Bạn có muốn xóa món ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
                if (delete == DialogResult.Yes)
                {
                    try
                    {
                        if (doAn_BUS.delete_DoAn_ThongTinDoAn_BUS(doAn_DTO()))
                        {
                            MessageBox.Show("Xóa đồ ăn thành công");
                            btnLamMoi_Click(sender, e);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Xóa đồ ăn ăn thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                    }
                }
           }
           else
                MessageBox.Show("Đồ ăn không tồn tại, vui lòng kiểm tra lại mã đồ ăn");

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDoAn.Text != "" && txtTenDoAn.Text != "" & txtDonGia.Text != "" && txtDonViBan.Text != "")
            {
                if (kt_DoAnTonTai())
                {
                    DialogResult sua = MessageBox.Show("Bạn muốn sửa thông tin đồ ăn này ?", "Thông báo", MessageBoxButtons.YesNo);
                    if (sua == DialogResult.Yes)
                    {
                        try
                        {

                            if (doAn_BUS.update_DoAn_ThongTinDoAn_BUS(doAn_DTO()))
                            {
                                MessageBox.Show("Sửa thông tin đồ ăn thành công");
                                btnLamMoi_Click(sender, e);
                            }
                            else
                            {
                                MessageBox.Show("Sửa thông tin đồ ăn thất bại vui lòng kiểm tra lại thông tin nhập");
                            }


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Sửa thông tin đồ ăn thất bại vui lòng kiểm tra lại thông tin đồ ăn");
                        }
                    }

                }
                else
                    MessageBox.Show("Đồ ăn không tồn tại, vui lòng kiểm tra lại mã đồ ăn");

            }
            else
            {
                MessageBox.Show("Vui lòng nhập dầy đủ thông tin"); 
            }
        }

        private void lblkThoat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.JPG;*.JPEG;*.PNG;*.GIF)|*.JPG;*.JPEG;*.PNG;*.GIF";
            openFileDialog.ShowDialog();

            if (openFileDialog.FileName != "")
            {
                picAnhDoAn.Image = Image.FromFile(openFileDialog.FileName);
                picAnhDoAn.SizeMode = PictureBoxSizeMode.StretchImage;
                picAnhDoAn.ClientSize = new Size(133, 169);
                using (var ms = new MemoryStream())
                {
                    picAnhDoAn.Image.Save(ms, picAnhDoAn.Image.RawFormat);
                    Hinh = ms.ToArray();
                }
            }
        }

        private void btnBoAnh_Click(object sender, EventArgs e)
        {
            picAnhDoAn.Image = null;
            picAnhDoAn.SizeMode = PictureBoxSizeMode.StretchImage;
            picAnhDoAn.ClientSize = new Size(133, 169);
            Hinh = null;
        }

      
    }
}
