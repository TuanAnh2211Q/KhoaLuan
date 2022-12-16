
namespace QLCHTAN
{
    partial class ThongTinDonHang_GUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinDonHang_GUI));
            this.dgvThongTinHoaDon = new System.Windows.Forms.DataGridView();
            this.maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSDT = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblKhachHang = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblTongDonGia = new System.Windows.Forms.Label();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.lblThanhToan = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblLoaiDon = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTenDonHang = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblMaDonHang = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblThoiGian = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblKhuyenMai = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvThongTinHoaDon
            // 
            this.dgvThongTinHoaDon.AllowUserToAddRows = false;
            this.dgvThongTinHoaDon.AllowUserToDeleteRows = false;
            this.dgvThongTinHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinHoaDon.BackgroundColor = System.Drawing.Color.PaleGreen;
            this.dgvThongTinHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maSanPham,
            this.tenSanPham,
            this.soLuong,
            this.donGia,
            this.thanhTien});
            this.dgvThongTinHoaDon.Location = new System.Drawing.Point(12, 226);
            this.dgvThongTinHoaDon.Name = "dgvThongTinHoaDon";
            this.dgvThongTinHoaDon.ReadOnly = true;
            this.dgvThongTinHoaDon.Size = new System.Drawing.Size(1010, 396);
            this.dgvThongTinHoaDon.TabIndex = 0;
            // 
            // maSanPham
            // 
            this.maSanPham.DataPropertyName = "maSanPham";
            this.maSanPham.HeaderText = "Mã sản phẩm";
            this.maSanPham.Name = "maSanPham";
            this.maSanPham.ReadOnly = true;
            this.maSanPham.Visible = false;
            // 
            // tenSanPham
            // 
            this.tenSanPham.DataPropertyName = "tenSanPham";
            this.tenSanPham.HeaderText = "Tên sản phẩm";
            this.tenSanPham.Name = "tenSanPham";
            this.tenSanPham.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            this.donGia.ReadOnly = true;
            // 
            // thanhTien
            // 
            this.thanhTien.DataPropertyName = "thanhTien";
            this.thanhTien.HeaderText = "Thành tiền";
            this.thanhTien.Name = "thanhTien";
            this.thanhTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.txtGhiChu);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.lblDiaChi);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSDT);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblKhachHang);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(353, 60);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 160);
            this.panel1.TabIndex = 1;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(64, 100);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(259, 53);
            this.txtGhiChu.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ghi chú:";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.ForeColor = System.Drawing.Color.Red;
            this.lblDiaChi.Location = new System.Drawing.Point(94, 68);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(96, 18);
            this.lblDiaChi.TabIndex = 5;
            this.lblDiaChi.Text = "......................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Địa chỉ:";
            // 
            // lblSDT
            // 
            this.lblSDT.AutoSize = true;
            this.lblSDT.ForeColor = System.Drawing.Color.Red;
            this.lblSDT.Location = new System.Drawing.Point(94, 40);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(96, 18);
            this.lblSDT.TabIndex = 3;
            this.lblSDT.Text = "......................";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "SĐT:";
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.AutoSize = true;
            this.lblKhachHang.ForeColor = System.Drawing.Color.Red;
            this.lblKhachHang.Location = new System.Drawing.Point(94, 10);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(96, 18);
            this.lblKhachHang.TabIndex = 1;
            this.lblKhachHang.Text = "......................";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 637);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 29);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tổng đơn giá:";
            // 
            // lblTongDonGia
            // 
            this.lblTongDonGia.AutoSize = true;
            this.lblTongDonGia.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongDonGia.ForeColor = System.Drawing.Color.Red;
            this.lblTongDonGia.Location = new System.Drawing.Point(236, 637);
            this.lblTongDonGia.Name = "lblTongDonGia";
            this.lblTongDonGia.Size = new System.Drawing.Size(127, 29);
            this.lblTongDonGia.TabIndex = 5;
            this.lblTongDonGia.Text = "...................";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXacNhan.Location = new System.Drawing.Point(856, 648);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(166, 34);
            this.btnXacNhan.TabIndex = 6;
            this.btnXacNhan.Text = "Xác nhận thanh toán";
            this.btnXacNhan.UseVisualStyleBackColor = false;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Honeydew;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label12);
            this.panel2.Controls.Add(this.lblNhanVien);
            this.panel2.Controls.Add(this.lblThanhToan);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblLoaiDon);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.lblTenDonHang);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.lblMaDonHang);
            this.panel2.Controls.Add(this.lbl);
            this.panel2.Location = new System.Drawing.Point(12, 60);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(335, 160);
            this.panel2.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 127);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(95, 18);
            this.label12.TabIndex = 10;
            this.label12.Text = "Nhân viên lập:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblNhanVien.Location = new System.Drawing.Point(104, 127);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(96, 18);
            this.lblNhanVien.TabIndex = 9;
            this.lblNhanVien.Text = "......................";
            // 
            // lblThanhToan
            // 
            this.lblThanhToan.AutoSize = true;
            this.lblThanhToan.ForeColor = System.Drawing.Color.Red;
            this.lblThanhToan.Location = new System.Drawing.Point(104, 100);
            this.lblThanhToan.Name = "lblThanhToan";
            this.lblThanhToan.Size = new System.Drawing.Size(96, 18);
            this.lblThanhToan.TabIndex = 7;
            this.lblThanhToan.Text = "......................";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "Thanh toán:";
            // 
            // lblLoaiDon
            // 
            this.lblLoaiDon.AutoSize = true;
            this.lblLoaiDon.ForeColor = System.Drawing.Color.Red;
            this.lblLoaiDon.Location = new System.Drawing.Point(104, 68);
            this.lblLoaiDon.Name = "lblLoaiDon";
            this.lblLoaiDon.Size = new System.Drawing.Size(96, 18);
            this.lblLoaiDon.TabIndex = 5;
            this.lblLoaiDon.Text = "......................";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 18);
            this.label8.TabIndex = 4;
            this.label8.Text = "Loại đơn:";
            // 
            // lblTenDonHang
            // 
            this.lblTenDonHang.AutoSize = true;
            this.lblTenDonHang.ForeColor = System.Drawing.Color.Red;
            this.lblTenDonHang.Location = new System.Drawing.Point(104, 40);
            this.lblTenDonHang.Name = "lblTenDonHang";
            this.lblTenDonHang.Size = new System.Drawing.Size(96, 18);
            this.lblTenDonHang.TabIndex = 3;
            this.lblTenDonHang.Text = "......................";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "Tên đơn hàng:";
            // 
            // lblMaDonHang
            // 
            this.lblMaDonHang.AutoSize = true;
            this.lblMaDonHang.ForeColor = System.Drawing.Color.Red;
            this.lblMaDonHang.Location = new System.Drawing.Point(104, 10);
            this.lblMaDonHang.Name = "lblMaDonHang";
            this.lblMaDonHang.Size = new System.Drawing.Size(96, 18);
            this.lblMaDonHang.TabIndex = 1;
            this.lblMaDonHang.Text = "......................";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(3, 10);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(60, 18);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Mã đơn:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Honeydew;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lblTrangThai);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.lblThoiGian);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.lblKhuyenMai);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(689, 60);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(333, 160);
            this.panel3.TabIndex = 8;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(94, 68);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(96, 18);
            this.lblTrangThai.TabIndex = 5;
            this.lblTrangThai.Text = "......................";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 68);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 18);
            this.label13.TabIndex = 4;
            this.label13.Text = "Trạng thái:";
            // 
            // lblThoiGian
            // 
            this.lblThoiGian.AutoSize = true;
            this.lblThoiGian.ForeColor = System.Drawing.Color.Red;
            this.lblThoiGian.Location = new System.Drawing.Point(94, 40);
            this.lblThoiGian.Name = "lblThoiGian";
            this.lblThoiGian.Size = new System.Drawing.Size(96, 18);
            this.lblThoiGian.TabIndex = 3;
            this.lblThoiGian.Text = "......................";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 40);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(90, 18);
            this.label15.TabIndex = 2;
            this.label15.Text = "Thời gian lập:";
            // 
            // lblKhuyenMai
            // 
            this.lblKhuyenMai.AutoSize = true;
            this.lblKhuyenMai.ForeColor = System.Drawing.Color.Red;
            this.lblKhuyenMai.Location = new System.Drawing.Point(147, 10);
            this.lblKhuyenMai.Name = "lblKhuyenMai";
            this.lblKhuyenMai.Size = new System.Drawing.Size(96, 18);
            this.lblKhuyenMai.TabIndex = 1;
            this.lblKhuyenMai.Text = "......................";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(138, 18);
            this.label17.TabIndex = 0;
            this.label17.Text = "Khuyến mãi áp dụng:";
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuayLai.Location = new System.Drawing.Point(771, 648);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(79, 34);
            this.btnQuayLai.TabIndex = 9;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = false;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkGreen;
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel4.Location = new System.Drawing.Point(12, 12);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1010, 42);
            this.panel4.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(347, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 36);
            this.label4.TabIndex = 3;
            this.label4.Text = "THÔNG TIN ĐƠN HÀNG";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(638, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(42, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 628);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(48, 48);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // ThongTinDonHang_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1034, 710);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.lblTongDonGia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvThongTinHoaDon);
            this.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinDonHang_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinHoaDon_GUI";
            this.Load += new System.EventHandler(this.ThongTinDonHang_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblTongDonGia;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblLoaiDon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTenDonHang;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMaDonHang;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblThoiGian;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblKhuyenMai;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewTextBoxColumn maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTien;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}