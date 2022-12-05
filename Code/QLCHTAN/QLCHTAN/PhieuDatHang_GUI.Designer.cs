
namespace QLCHTAN
{
    partial class PhieuDatHang_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuDatHang_GUI));
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaDat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemPhieuDat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyPhieuDat = new System.Windows.Forms.Button();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.maDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDuKienGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblkTaoPhieuNhap = new System.Windows.Forms.LinkLabel();
            this.lblkTaoPhieuTra = new System.Windows.Forms.LinkLabel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblkThongTinPhieuDat = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.ccbPhuongThucThanhToan = new System.Windows.Forms.ComboBox();
            this.dtNgayDuKienGiao = new System.Windows.Forms.DateTimePicker();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.btnHoanThanh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDat.Location = new System.Drawing.Point(120, 75);
            this.dtNgayDat.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(211, 23);
            this.dtNgayDat.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(82, 206);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(248, 360);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtMaDat
            // 
            this.txtMaDat.Location = new System.Drawing.Point(120, 48);
            this.txtMaDat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDat.Name = "txtMaDat";
            this.txtMaDat.Size = new System.Drawing.Size(211, 23);
            this.txtMaDat.TabIndex = 4;
            this.txtMaDat.TextChanged += new System.EventHandler(this.txtMaDat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 206);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 114);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày dự kiến giao:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày đặt hàng:";
            // 
            // btnThemPhieuDat
            // 
            this.btnThemPhieuDat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemPhieuDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnThemPhieuDat.Location = new System.Drawing.Point(103, 564);
            this.btnThemPhieuDat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuDat.Name = "btnThemPhieuDat";
            this.btnThemPhieuDat.Size = new System.Drawing.Size(135, 33);
            this.btnThemPhieuDat.TabIndex = 8;
            this.btnThemPhieuDat.Text = "Thêm phiếu đặt mới";
            this.btnThemPhieuDat.UseVisualStyleBackColor = true;
            this.btnThemPhieuDat.Click += new System.EventHandler(this.btnThemPhieuDat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đặt hàng:";
            // 
            // btnHuyPhieuDat
            // 
            this.btnHuyPhieuDat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuyPhieuDat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHuyPhieuDat.Location = new System.Drawing.Point(242, 563);
            this.btnHuyPhieuDat.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyPhieuDat.Name = "btnHuyPhieuDat";
            this.btnHuyPhieuDat.Size = new System.Drawing.Size(108, 33);
            this.btnHuyPhieuDat.TabIndex = 9;
            this.btnHuyPhieuDat.Text = "Hủy phiếu đặt";
            this.btnHuyPhieuDat.UseVisualStyleBackColor = true;
            this.btnHuyPhieuDat.Click += new System.EventHandler(this.btnHuyPhieuDat_Click);
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.AllowUserToAddRows = false;
            this.dgvPhieuDat.AllowUserToDeleteRows = false;
            this.dgvPhieuDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDatHang,
            this.ngayDatHang,
            this.ngayDuKienGiao,
            this.phuongThucThanhToan,
            this.ghiChu,
            this.trangThai});
            this.dgvPhieuDat.Location = new System.Drawing.Point(3, 38);
            this.dgvPhieuDat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.ReadOnly = true;
            this.dgvPhieuDat.Size = new System.Drawing.Size(673, 524);
            this.dgvPhieuDat.TabIndex = 6;
            this.dgvPhieuDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuDat_CellClick);
            // 
            // maDatHang
            // 
            this.maDatHang.DataPropertyName = "maDatHang";
            this.maDatHang.HeaderText = "Mã đặt hàng";
            this.maDatHang.Name = "maDatHang";
            this.maDatHang.ReadOnly = true;
            // 
            // ngayDatHang
            // 
            this.ngayDatHang.DataPropertyName = "ngayDatHang";
            this.ngayDatHang.HeaderText = "Ngày đặt hàng";
            this.ngayDatHang.Name = "ngayDatHang";
            this.ngayDatHang.ReadOnly = true;
            // 
            // ngayDuKienGiao
            // 
            this.ngayDuKienGiao.DataPropertyName = "ngayDuKienGiao";
            this.ngayDuKienGiao.HeaderText = "Ngày dự kiến giao";
            this.ngayDuKienGiao.Name = "ngayDuKienGiao";
            this.ngayDuKienGiao.ReadOnly = true;
            // 
            // phuongThucThanhToan
            // 
            this.phuongThucThanhToan.DataPropertyName = "phuongThucThanhToan";
            this.phuongThucThanhToan.HeaderText = "Phương thức thanh toán";
            this.phuongThucThanhToan.Name = "phuongThucThanhToan";
            this.phuongThucThanhToan.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblkTaoPhieuNhap);
            this.groupBox1.Controls.Add(this.lblkTaoPhieuTra);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblkThongTinPhieuDat);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ccbPhuongThucThanhToan);
            this.groupBox1.Controls.Add(this.dtNgayDuKienGiao);
            this.groupBox1.Controls.Add(this.dtNgayDat);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaDat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 607);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu đặt";
            // 
            // lblkTaoPhieuNhap
            // 
            this.lblkTaoPhieuNhap.AutoSize = true;
            this.lblkTaoPhieuNhap.Location = new System.Drawing.Point(221, 580);
            this.lblkTaoPhieuNhap.Name = "lblkTaoPhieuNhap";
            this.lblkTaoPhieuNhap.Size = new System.Drawing.Size(90, 15);
            this.lblkTaoPhieuNhap.TabIndex = 26;
            this.lblkTaoPhieuNhap.TabStop = true;
            this.lblkTaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.lblkTaoPhieuNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkTaoPhieuNhap_LinkClicked);
            // 
            // lblkTaoPhieuTra
            // 
            this.lblkTaoPhieuTra.AutoSize = true;
            this.lblkTaoPhieuTra.Location = new System.Drawing.Point(127, 580);
            this.lblkTaoPhieuTra.Name = "lblkTaoPhieuTra";
            this.lblkTaoPhieuTra.Size = new System.Drawing.Size(86, 15);
            this.lblkTaoPhieuTra.TabIndex = 25;
            this.lblkTaoPhieuTra.TabStop = true;
            this.lblkTaoPhieuTra.Text = "Xem phiếu trả";
            this.lblkTaoPhieuTra.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkTaoPhieuTra_LinkClicked);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTrangThai.Location = new System.Drawing.Point(95, 166);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(235, 15);
            this.lblTrangThai.TabIndex = 24;
            this.lblTrangThai.Text = "............................................................................";
            this.lblTrangThai.TextChanged += new System.EventHandler(this.lblTrangThai_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Trạng thái:";
            // 
            // lblkThongTinPhieuDat
            // 
            this.lblkThongTinPhieuDat.AutoSize = true;
            this.lblkThongTinPhieuDat.Location = new System.Drawing.Point(6, 581);
            this.lblkThongTinPhieuDat.Name = "lblkThongTinPhieuDat";
            this.lblkThongTinPhieuDat.Size = new System.Drawing.Size(115, 15);
            this.lblkThongTinPhieuDat.TabIndex = 12;
            this.lblkThongTinPhieuDat.TabStop = true;
            this.lblkThongTinPhieuDat.Text = "Thông tin phiếu đặt";
            this.lblkThongTinPhieuDat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThongTinPhieuDat_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phương thức thanh toán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ccbPhuongThucThanhToan
            // 
            this.ccbPhuongThucThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbPhuongThucThanhToan.FormattingEnabled = true;
            this.ccbPhuongThucThanhToan.Items.AddRange(new object[] {
            "Chuyển khoản",
            "Tiền mặt"});
            this.ccbPhuongThucThanhToan.Location = new System.Drawing.Point(172, 135);
            this.ccbPhuongThucThanhToan.Margin = new System.Windows.Forms.Padding(2);
            this.ccbPhuongThucThanhToan.Name = "ccbPhuongThucThanhToan";
            this.ccbPhuongThucThanhToan.Size = new System.Drawing.Size(159, 23);
            this.ccbPhuongThucThanhToan.TabIndex = 21;
            // 
            // dtNgayDuKienGiao
            // 
            this.dtNgayDuKienGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDuKienGiao.Location = new System.Drawing.Point(120, 109);
            this.dtNgayDuKienGiao.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayDuKienGiao.Name = "dtNgayDuKienGiao";
            this.dtNgayDuKienGiao.Size = new System.Drawing.Size(211, 23);
            this.dtNgayDuKienGiao.TabIndex = 20;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(631, 564);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(44, 33);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCapNhat.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCapNhat.Location = new System.Drawing.Point(354, 563);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(129, 34);
            this.btnCapNhat.TabIndex = 11;
            this.btnCapNhat.Text = "Cập nhật phiếu đặt";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(221, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 26);
            this.label6.TabIndex = 12;
            this.label6.Text = "DANH SÁCH PHIẾU ĐẶT";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblkThoat);
            this.panel1.Controls.Add(this.btnHoanThanh);
            this.panel1.Controls.Add(this.dgvPhieuDat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHuyPhieuDat);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThemPhieuDat);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.Location = new System.Drawing.Point(351, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 605);
            this.panel1.TabIndex = 13;
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(3, 20);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(39, 15);
            this.lblkThoat.TabIndex = 14;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // btnHoanThanh
            // 
            this.btnHoanThanh.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoanThanh.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnHoanThanh.Location = new System.Drawing.Point(487, 564);
            this.btnHoanThanh.Margin = new System.Windows.Forms.Padding(2);
            this.btnHoanThanh.Name = "btnHoanThanh";
            this.btnHoanThanh.Size = new System.Drawing.Size(139, 34);
            this.btnHoanThanh.TabIndex = 13;
            this.btnHoanThanh.Text = "Hoàn thảnh phiếu đặt";
            this.btnHoanThanh.UseVisualStyleBackColor = true;
            this.btnHoanThanh.Click += new System.EventHandler(this.btnHoanThanh_Click);
            // 
            // PhieuDatHang_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1045, 629);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuDatHang_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuDatHang_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhieuDatHang_GUI_FormClosing);
            this.Load += new System.EventHandler(this.PhieuDatHang_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaDat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnThemPhieuDat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyPhieuDat;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtNgayDuKienGiao;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox ccbPhuongThucThanhToan;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.LinkLabel lblkThongTinPhieuDat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDuKienGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.LinkLabel lblkTaoPhieuTra;
        private System.Windows.Forms.LinkLabel lblkTaoPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHoanThanh;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}