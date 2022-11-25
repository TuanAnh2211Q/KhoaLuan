
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
            this.ccbMaDatHang = new System.Windows.Forms.ComboBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvPhieuNhap = new System.Windows.Forms.DataGridView();
            this.btnThongTinChiTiet = new System.Windows.Forms.Button();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.btnHuyPhieuNhap = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.maNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ccbMaDatHang);
            this.groupBox1.Controls.Add(this.dtNgayNhap);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaNhap);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(18, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // ccbMaDatHang
            // 
            this.ccbMaDatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbMaDatHang.FormattingEnabled = true;
            this.ccbMaDatHang.Location = new System.Drawing.Point(106, 145);
            this.ccbMaDatHang.Name = "ccbMaDatHang";
            this.ccbMaDatHang.Size = new System.Drawing.Size(243, 27);
            this.ccbMaDatHang.TabIndex = 21;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(106, 96);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(243, 27);
            this.dtNgayNhap.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(106, 189);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(243, 96);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(106, 62);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(243, 27);
            this.txtMaNhap.TabIndex = 4;
            this.txtMaNhap.TextChanged += new System.EventHandler(this.txtMaNhap_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đặt hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhập:";
            // 
            // dgvPhieuNhap
            // 
            this.dgvPhieuNhap.AllowUserToAddRows = false;
            this.dgvPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maNhap,
            this.ngayNhap,
            this.maDatHang,
            this.ghiChu});
            this.dgvPhieuNhap.Location = new System.Drawing.Point(381, 32);
            this.dgvPhieuNhap.Name = "dgvPhieuNhap";
            this.dgvPhieuNhap.ReadOnly = true;
            this.dgvPhieuNhap.Size = new System.Drawing.Size(518, 271);
            this.dgvPhieuNhap.TabIndex = 1;
            this.dgvPhieuNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuNhap_CellClick);
            // 
            // btnThongTinChiTiet
            // 
            this.btnThongTinChiTiet.Location = new System.Drawing.Point(733, 309);
            this.btnThongTinChiTiet.Name = "btnThongTinChiTiet";
            this.btnThongTinChiTiet.Size = new System.Drawing.Size(165, 42);
            this.btnThongTinChiTiet.TabIndex = 2;
            this.btnThongTinChiTiet.Text = "Thông tin chi tiết ";
            this.btnThongTinChiTiet.UseVisualStyleBackColor = true;
            this.btnThongTinChiTiet.Click += new System.EventHandler(this.btnThongTinChiTiet_Click);
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(557, 309);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(170, 42);
            this.btnThemPhieuNhap.TabIndex = 3;
            this.btnThemPhieuNhap.Text = "Thêm phiếu nhập mới";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = true;
            this.btnThemPhieuNhap.Click += new System.EventHandler(this.btnThemPhieuNhap_Click);
            // 
            // btnHuyPhieuNhap
            // 
            this.btnHuyPhieuNhap.Location = new System.Drawing.Point(381, 309);
            this.btnHuyPhieuNhap.Name = "btnHuyPhieuNhap";
            this.btnHuyPhieuNhap.Size = new System.Drawing.Size(170, 42);
            this.btnHuyPhieuNhap.TabIndex = 4;
            this.btnHuyPhieuNhap.Text = "Hủy phiếu nhập";
            this.btnHuyPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // maNhap
            // 
            this.maNhap.DataPropertyName = "maNhap";
            this.maNhap.HeaderText = "Mã nhập";
            this.maNhap.Name = "maNhap";
            // 
            // ngayNhap
            // 
            this.ngayNhap.DataPropertyName = "ngayNhap";
            this.ngayNhap.HeaderText = "Ngày nhập";
            this.ngayNhap.Name = "ngayNhap";
            // 
            // maDatHang
            // 
            this.maDatHang.DataPropertyName = "maDatHang";
            this.maDatHang.HeaderText = "Mã đặt hàng";
            this.maDatHang.Name = "maDatHang";
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // PhieuNhapKho_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 363);
            this.Controls.Add(this.btnHuyPhieuNhap);
            this.Controls.Add(this.btnThemPhieuNhap);
            this.Controls.Add(this.btnThongTinChiTiet);
            this.Controls.Add(this.dgvPhieuNhap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuNhapKho_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuNhapKho_GUI";
            this.Load += new System.EventHandler(this.PhieuNhapKho_GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhap)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnThongTinChiTiet;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Button btnHuyPhieuNhap;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox ccbMaDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}