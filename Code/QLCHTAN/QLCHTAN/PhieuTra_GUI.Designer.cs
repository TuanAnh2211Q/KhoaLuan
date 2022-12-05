
namespace QLCHTAN
{
    partial class PhieuTra_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuTra_GUI));
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvPhieuTra = new System.Windows.Forms.DataGridView();
            this.maTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaDat = new System.Windows.Forms.ComboBox();
            this.lblkTaoPhieuNhap = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblkThongTinPhieuDat = new System.Windows.Forms.LinkLabel();
            this.dtNgayTra = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhieuTra = new System.Windows.Forms.Button();
            this.btnHuyPhieuTra = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbkThoat = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(262, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "DANH SÁCH PHIẾU TRẢ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(697, 492);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(44, 33);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvPhieuTra
            // 
            this.dgvPhieuTra.AllowUserToAddRows = false;
            this.dgvPhieuTra.AllowUserToDeleteRows = false;
            this.dgvPhieuTra.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuTra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTra,
            this.ngayTra,
            this.ghiChu,
            this.maDatHang,
            this.trangThai});
            this.dgvPhieuTra.Location = new System.Drawing.Point(2, 42);
            this.dgvPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuTra.Name = "dgvPhieuTra";
            this.dgvPhieuTra.ReadOnly = true;
            this.dgvPhieuTra.Size = new System.Drawing.Size(736, 445);
            this.dgvPhieuTra.TabIndex = 14;
            this.dgvPhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuTra_CellClick);
            // 
            // maTra
            // 
            this.maTra.DataPropertyName = "maTra";
            this.maTra.HeaderText = "Mã trả hàng";
            this.maTra.Name = "maTra";
            this.maTra.ReadOnly = true;
            // 
            // ngayTra
            // 
            this.ngayTra.DataPropertyName = "ngayTra";
            this.ngayTra.HeaderText = "Ngày đặt hàng";
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // maDatHang
            // 
            this.maDatHang.DataPropertyName = "maDatHang";
            this.maDatHang.HeaderText = "Mã đặt hàng";
            this.maDatHang.Name = "maDatHang";
            this.maDatHang.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(563, 491);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(129, 34);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập nhật phiếu trả";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.cbbMaDat);
            this.groupBox1.Controls.Add(this.lblkTaoPhieuNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblkThongTinPhieuDat);
            this.groupBox1.Controls.Add(this.dtNgayTra);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaTra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 528);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu trả";
            // 
            // cbbMaDat
            // 
            this.cbbMaDat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaDat.FormattingEnabled = true;
            this.cbbMaDat.Location = new System.Drawing.Point(84, 107);
            this.cbbMaDat.Name = "cbbMaDat";
            this.cbbMaDat.Size = new System.Drawing.Size(238, 23);
            this.cbbMaDat.TabIndex = 28;
            // 
            // lblkTaoPhieuNhap
            // 
            this.lblkTaoPhieuNhap.AutoSize = true;
            this.lblkTaoPhieuNhap.Location = new System.Drawing.Point(231, 503);
            this.lblkTaoPhieuNhap.Name = "lblkTaoPhieuNhap";
            this.lblkTaoPhieuNhap.Size = new System.Drawing.Size(90, 15);
            this.lblkTaoPhieuNhap.TabIndex = 27;
            this.lblkTaoPhieuNhap.TabStop = true;
            this.lblkTaoPhieuNhap.Text = "Tạo phiếu nhập";
            this.lblkTaoPhieuNhap.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkTaoPhieuNhap_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã đặt:";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTrangThai.Location = new System.Drawing.Point(81, 136);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(241, 15);
            this.lblTrangThai.TabIndex = 24;
            this.lblTrangThai.Text = "..............................................................................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Trạng thái:";
            // 
            // lblkThongTinPhieuDat
            // 
            this.lblkThongTinPhieuDat.AutoSize = true;
            this.lblkThongTinPhieuDat.Location = new System.Drawing.Point(6, 503);
            this.lblkThongTinPhieuDat.Name = "lblkThongTinPhieuDat";
            this.lblkThongTinPhieuDat.Size = new System.Drawing.Size(113, 15);
            this.lblkThongTinPhieuDat.TabIndex = 12;
            this.lblkThongTinPhieuDat.TabStop = true;
            this.lblkThongTinPhieuDat.Text = "Thông tin phiếu trả";
            this.lblkThongTinPhieuDat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThongTinPhieuDat_LinkClicked);
            // 
            // dtNgayTra
            // 
            this.dtNgayTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayTra.Location = new System.Drawing.Point(84, 76);
            this.dtNgayTra.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayTra.Name = "dtNgayTra";
            this.dtNgayTra.Size = new System.Drawing.Size(237, 23);
            this.dtNgayTra.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(84, 169);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(239, 318);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtMaTra
            // 
            this.txtMaTra.Location = new System.Drawing.Point(84, 49);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.Size = new System.Drawing.Size(237, 23);
            this.txtMaTra.TabIndex = 4;
            this.txtMaTra.TextChanged += new System.EventHandler(this.txtMaTra_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trả hàng:";
            // 
            // btnThemPhieuTra
            // 
            this.btnThemPhieuTra.Location = new System.Drawing.Point(314, 492);
            this.btnThemPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuTra.Name = "btnThemPhieuTra";
            this.btnThemPhieuTra.Size = new System.Drawing.Size(135, 33);
            this.btnThemPhieuTra.TabIndex = 15;
            this.btnThemPhieuTra.Text = "Thêm phiếu trả mới";
            this.btnThemPhieuTra.UseVisualStyleBackColor = true;
            this.btnThemPhieuTra.Click += new System.EventHandler(this.btnThemPhieuTra_Click);
            // 
            // btnHuyPhieuTra
            // 
            this.btnHuyPhieuTra.Location = new System.Drawing.Point(453, 492);
            this.btnHuyPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyPhieuTra.Name = "btnHuyPhieuTra";
            this.btnHuyPhieuTra.Size = new System.Drawing.Size(108, 33);
            this.btnHuyPhieuTra.TabIndex = 16;
            this.btnHuyPhieuTra.Text = "Hủy phiếu trả";
            this.btnHuyPhieuTra.UseVisualStyleBackColor = true;
            this.btnHuyPhieuTra.Click += new System.EventHandler(this.btnHuyPhieuTra_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lbkThoat);
            this.panel1.Controls.Add(this.dgvPhieuTra);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnHuyPhieuTra);
            this.panel1.Controls.Add(this.btnLamMoi);
            this.panel1.Controls.Add(this.btnThemPhieuTra);
            this.panel1.Controls.Add(this.btnCapNhat);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(346, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(744, 528);
            this.panel1.TabIndex = 20;
            // 
            // lbkThoat
            // 
            this.lbkThoat.AutoSize = true;
            this.lbkThoat.Location = new System.Drawing.Point(3, 25);
            this.lbkThoat.Name = "lbkThoat";
            this.lbkThoat.Size = new System.Drawing.Size(39, 15);
            this.lbkThoat.TabIndex = 20;
            this.lbkThoat.TabStop = true;
            this.lbkThoat.Text = "Thoát";
            this.lbkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkThoat_LinkClicked);
            // 
            // PhieuTra_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1102, 558);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuTra_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuTra_GUI";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PhieuTra_GUI_FormClosing);
            this.Load += new System.EventHandler(this.PhieuTra_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuTra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvPhieuTra;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblkThongTinPhieuDat;
        private System.Windows.Forms.DateTimePicker dtNgayTra;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhieuTra;
        private System.Windows.Forms.Button btnHuyPhieuTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblkTaoPhieuNhap;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.ComboBox cbbMaDat;
        private System.Windows.Forms.LinkLabel lbkThoat;
    }
}