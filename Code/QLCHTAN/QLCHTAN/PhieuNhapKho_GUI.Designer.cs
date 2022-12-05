
namespace QLCHTAN
{
    partial class PhieuNhapKho_GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblkHuyPhieuNhap = new System.Windows.Forms.LinkLabel();
            this.txtMaDatHang = new System.Windows.Forms.TextBox();
            this.lblkThongTinChiTiet = new System.Windows.Forms.LinkLabel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.maNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblkHuyPhieuNhap);
            this.groupBox1.Controls.Add(this.txtMaDatHang);
            this.groupBox1.Controls.Add(this.lblkThongTinChiTiet);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtNgayNhap);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(322, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // lblkHuyPhieuNhap
            // 
            this.lblkHuyPhieuNhap.AutoSize = true;
            this.lblkHuyPhieuNhap.Location = new System.Drawing.Point(193, 316);
            this.lblkHuyPhieuNhap.Name = "lblkHuyPhieuNhap";
            this.lblkHuyPhieuNhap.Size = new System.Drawing.Size(93, 15);
            this.lblkHuyPhieuNhap.TabIndex = 26;
            this.lblkHuyPhieuNhap.TabStop = true;
            this.lblkHuyPhieuNhap.Text = "Hủy phiếu nhập";
            this.lblkHuyPhieuNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkHuyPhieuNhap_LinkClicked);
            // 
            // txtMaDatHang
            // 
            this.txtMaDatHang.Location = new System.Drawing.Point(82, 100);
            this.txtMaDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDatHang.Name = "txtMaDatHang";
            this.txtMaDatHang.Size = new System.Drawing.Size(235, 23);
            this.txtMaDatHang.TabIndex = 25;
            // 
            // lblkThongTinChiTiet
            // 
            this.lblkThongTinChiTiet.AutoSize = true;
            this.lblkThongTinChiTiet.Location = new System.Drawing.Point(59, 316);
            this.lblkThongTinChiTiet.Name = "lblkThongTinChiTiet";
            this.lblkThongTinChiTiet.Size = new System.Drawing.Size(105, 15);
            this.lblkThongTinChiTiet.TabIndex = 24;
            this.lblkThongTinChiTiet.TabStop = true;
            this.lblkThongTinChiTiet.Text = "Thông tin chi tiết ";
            this.lblkThongTinChiTiet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThongTinChiTiet_LinkClicked);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(79, 140);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(241, 15);
            this.lblTrangThai.TabIndex = 23;
            this.lblTrangThai.Text = "..............................................................................";
            this.lblTrangThai.TextChanged += new System.EventHandler(this.lblTrangThai_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Trạng thái:";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(82, 73);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(235, 23);
            this.dtNgayNhap.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(82, 170);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(235, 77);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(82, 46);
            this.txtMaNhap.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(235, 23);
            this.txtMaNhap.TabIndex = 4;
            this.txtMaNhap.TextChanged += new System.EventHandler(this.txtMaNhap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đặt hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhập:";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuNhap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhap,
            this.ngayNhap,
            this.maDatHang,
            this.ghiChu,
            this.trangThai});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(2, 2);
            this.dgvPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(750, 363);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // maNhap
            // 
            this.maNhap.DataPropertyName = "maNhap";
            this.maNhap.HeaderText = "Mã nhập";
            this.maNhap.Name = "maNhap";
            this.maNhap.ReadOnly = true;
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "ngayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            this.ngayNhap.ReadOnly = true;
            // 
            // maDatHang
            // 
            this.maDatHang.DataPropertyName = "maDatHang";
            this.maDatHang.HeaderText = "Mã đặt hàng";
            this.maDatHang.Name = "maDatHang";
            this.maDatHang.ReadOnly = true;
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
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvPhieuNhap);
            this.panel1.Location = new System.Drawing.Point(344, 71);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 365);
            this.panel1.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(592, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "DANH SÁCH PHIẾU NHẬP";
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(343, 53);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(39, 15);
            this.lblkThoat.TabIndex = 7;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // PhieuNhapKho_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1106, 447);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuNhapKho_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuNhapKho_GUI";
            this.Load += new System.EventHandler(this.PhieuNhapKho_GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel lblkHuyPhieuNhap;
        private System.Windows.Forms.TextBox txtMaDatHang;
        private System.Windows.Forms.LinkLabel lblkThongTinChiTiet;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}