
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaDat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemPhieuDat = new System.Windows.Forms.Button();
            this.btnThongTinChiTiet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyPhieuDat = new System.Windows.Forms.Button();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.maDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayDuKienGiao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phuongThucThanhToan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ccbPhuongThucThanhToan = new System.Windows.Forms.ComboBox();
            this.dtNgayDuKienGiao = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Enabled = false;
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDat.Location = new System.Drawing.Point(114, 76);
            this.dtNgayDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(159, 23);
            this.dtNgayDat.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Enabled = false;
            this.txtGhiChu.Location = new System.Drawing.Point(82, 182);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(190, 77);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtMaDat
            // 
            this.txtMaDat.Enabled = false;
            this.txtMaDat.Location = new System.Drawing.Point(114, 49);
            this.txtMaDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtMaDat.Name = "txtMaDat";
            this.txtMaDat.Size = new System.Drawing.Size(159, 23);
            this.txtMaDat.TabIndex = 4;
            this.txtMaDat.TextChanged += new System.EventHandler(this.txtMaDat_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 185);
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
            this.label3.Size = new System.Drawing.Size(108, 15);
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
            this.btnThemPhieuDat.Location = new System.Drawing.Point(429, 240);
            this.btnThemPhieuDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThemPhieuDat.Name = "btnThemPhieuDat";
            this.btnThemPhieuDat.Size = new System.Drawing.Size(132, 33);
            this.btnThemPhieuDat.TabIndex = 8;
            this.btnThemPhieuDat.Text = "Thêm phiếu đặt mới";
            this.btnThemPhieuDat.UseVisualStyleBackColor = true;
            // 
            // btnThongTinChiTiet
            // 
            this.btnThongTinChiTiet.Location = new System.Drawing.Point(565, 240);
            this.btnThongTinChiTiet.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnThongTinChiTiet.Name = "btnThongTinChiTiet";
            this.btnThongTinChiTiet.Size = new System.Drawing.Size(128, 33);
            this.btnThongTinChiTiet.TabIndex = 7;
            this.btnThongTinChiTiet.Text = "Thông tin chi tiết ";
            this.btnThongTinChiTiet.UseVisualStyleBackColor = true;
            this.btnThongTinChiTiet.Click += new System.EventHandler(this.btnThongTinChiTiet_Click);
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
            this.btnHuyPhieuDat.Location = new System.Drawing.Point(292, 240);
            this.btnHuyPhieuDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnHuyPhieuDat.Name = "btnHuyPhieuDat";
            this.btnHuyPhieuDat.Size = new System.Drawing.Size(132, 33);
            this.btnHuyPhieuDat.TabIndex = 9;
            this.btnHuyPhieuDat.Text = "Hủy phiếu đặt";
            this.btnHuyPhieuDat.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.AllowUserToAddRows = false;
            this.dgvPhieuDat.AllowUserToDeleteRows = false;
            this.dgvPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maDatHang,
            this.ngayDatHang,
            this.ngayDuKienGiao,
            this.phuongThucThanhToan,
            this.ghiChu});
            this.dgvPhieuDat.Location = new System.Drawing.Point(292, 21);
            this.dgvPhieuDat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.ReadOnly = true;
            this.dgvPhieuDat.Size = new System.Drawing.Size(403, 214);
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
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(9, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 264);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu đặt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 138);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Phương thức thanh toán:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ccbPhuongThucThanhToan
            // 
            this.ccbPhuongThucThanhToan.Enabled = false;
            this.ccbPhuongThucThanhToan.FormattingEnabled = true;
            this.ccbPhuongThucThanhToan.Location = new System.Drawing.Point(152, 136);
            this.ccbPhuongThucThanhToan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ccbPhuongThucThanhToan.Name = "ccbPhuongThucThanhToan";
            this.ccbPhuongThucThanhToan.Size = new System.Drawing.Size(120, 23);
            this.ccbPhuongThucThanhToan.TabIndex = 21;
            // 
            // dtNgayDuKienGiao
            // 
            this.dtNgayDuKienGiao.Enabled = false;
            this.dtNgayDuKienGiao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDuKienGiao.Location = new System.Drawing.Point(114, 110);
            this.dtNgayDuKienGiao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtNgayDuKienGiao.Name = "dtNgayDuKienGiao";
            this.dtNgayDuKienGiao.Size = new System.Drawing.Size(159, 23);
            this.dtNgayDuKienGiao.TabIndex = 20;
            // 
            // PhieuDatHang_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(711, 289);
            this.Controls.Add(this.btnThemPhieuDat);
            this.Controls.Add(this.btnThongTinChiTiet);
            this.Controls.Add(this.btnHuyPhieuDat);
            this.Controls.Add(this.dgvPhieuDat);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PhieuDatHang_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuDatHang_GUI";
            this.Load += new System.EventHandler(this.PhieuDatHang_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnThongTinChiTiet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyPhieuDat;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ccbPhuongThucThanhToan;
        private System.Windows.Forms.DateTimePicker dtNgayDuKienGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayDuKienGiao;
        private System.Windows.Forms.DataGridViewTextBoxColumn phuongThucThanhToan;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}