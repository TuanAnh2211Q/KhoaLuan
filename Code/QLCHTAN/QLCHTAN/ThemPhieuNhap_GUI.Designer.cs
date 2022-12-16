
namespace QLCHTAN
{
    partial class ThemPhieuNhap_GUI
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
            this.tbThemPhieuNhap = new System.Windows.Forms.TabControl();
            this.tbpThemPhieuNhap = new System.Windows.Forms.TabPage();
            this.grThemPhieuNhap = new System.Windows.Forms.GroupBox();
            this.btnHuy = new System.Windows.Forms.Button();
            this.txtMaDat = new System.Windows.Forms.TextBox();
            this.btnTiepTuc = new System.Windows.Forms.Button();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbpThemChiTiet = new System.Windows.Forms.TabPage();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvThongTinChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbThemPhieuNhap.SuspendLayout();
            this.tbpThemPhieuNhap.SuspendLayout();
            this.grThemPhieuNhap.SuspendLayout();
            this.tbpThemChiTiet.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // tbThemPhieuNhap
            // 
            this.tbThemPhieuNhap.Controls.Add(this.tbpThemPhieuNhap);
            this.tbThemPhieuNhap.Controls.Add(this.tbpThemChiTiet);
            this.tbThemPhieuNhap.Location = new System.Drawing.Point(9, 9);
            this.tbThemPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tbThemPhieuNhap.Name = "tbThemPhieuNhap";
            this.tbThemPhieuNhap.SelectedIndex = 0;
            this.tbThemPhieuNhap.Size = new System.Drawing.Size(584, 515);
            this.tbThemPhieuNhap.TabIndex = 0;
            this.tbThemPhieuNhap.Click += new System.EventHandler(this.tbThemPhieuNhap_Click);
            // 
            // tbpThemPhieuNhap
            // 
            this.tbpThemPhieuNhap.Controls.Add(this.grThemPhieuNhap);
            this.tbpThemPhieuNhap.Location = new System.Drawing.Point(4, 24);
            this.tbpThemPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.tbpThemPhieuNhap.Name = "tbpThemPhieuNhap";
            this.tbpThemPhieuNhap.Padding = new System.Windows.Forms.Padding(2);
            this.tbpThemPhieuNhap.Size = new System.Drawing.Size(576, 487);
            this.tbpThemPhieuNhap.TabIndex = 0;
            this.tbpThemPhieuNhap.Text = "Thêm phiếu nhập";
            this.tbpThemPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // grThemPhieuNhap
            // 
            this.grThemPhieuNhap.Controls.Add(this.btnHuy);
            this.grThemPhieuNhap.Controls.Add(this.txtMaDat);
            this.grThemPhieuNhap.Controls.Add(this.btnTiepTuc);
            this.grThemPhieuNhap.Controls.Add(this.dtNgayNhap);
            this.grThemPhieuNhap.Controls.Add(this.rtxtGhiChu);
            this.grThemPhieuNhap.Controls.Add(this.txtMaNhap);
            this.grThemPhieuNhap.Controls.Add(this.label4);
            this.grThemPhieuNhap.Controls.Add(this.label3);
            this.grThemPhieuNhap.Controls.Add(this.label2);
            this.grThemPhieuNhap.Controls.Add(this.label1);
            this.grThemPhieuNhap.Location = new System.Drawing.Point(7, 7);
            this.grThemPhieuNhap.Margin = new System.Windows.Forms.Padding(5);
            this.grThemPhieuNhap.Name = "grThemPhieuNhap";
            this.grThemPhieuNhap.Padding = new System.Windows.Forms.Padding(5);
            this.grThemPhieuNhap.Size = new System.Drawing.Size(567, 475);
            this.grThemPhieuNhap.TabIndex = 2;
            this.grThemPhieuNhap.TabStop = false;
            this.grThemPhieuNhap.Text = "Thêm phiếu nhập";
            // 
            // btnHuy
            // 
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Location = new System.Drawing.Point(412, 441);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(58, 27);
            this.btnHuy.TabIndex = 21;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtMaDat
            // 
            this.txtMaDat.Enabled = false;
            this.txtMaDat.Location = new System.Drawing.Point(101, 63);
            this.txtMaDat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDat.Name = "txtMaDat";
            this.txtMaDat.Size = new System.Drawing.Size(460, 23);
            this.txtMaDat.TabIndex = 20;
            // 
            // btnTiepTuc
            // 
            this.btnTiepTuc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiepTuc.Location = new System.Drawing.Point(475, 440);
            this.btnTiepTuc.Margin = new System.Windows.Forms.Padding(2);
            this.btnTiepTuc.Name = "btnTiepTuc";
            this.btnTiepTuc.Size = new System.Drawing.Size(85, 28);
            this.btnTiepTuc.TabIndex = 3;
            this.btnTiepTuc.Text = "Tiếp tục";
            this.btnTiepTuc.UseVisualStyleBackColor = true;
            this.btnTiepTuc.Click += new System.EventHandler(this.btnTiepTuc_Click);
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(101, 35);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(460, 23);
            this.dtNgayNhap.TabIndex = 19;
            this.dtNgayNhap.Value = new System.DateTime(2022, 12, 7, 16, 2, 47, 0);
            this.dtNgayNhap.ValueChanged += new System.EventHandler(this.dtNgayNhap_ValueChanged);
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(101, 117);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(460, 320);
            this.rtxtGhiChu.TabIndex = 8;
            this.rtxtGhiChu.Text = "";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(101, 88);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(460, 23);
            this.txtMaNhap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đặt hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhập:";
            // 
            // tbpThemChiTiet
            // 
            this.tbpThemChiTiet.Controls.Add(this.btnQuayLai);
            this.tbpThemChiTiet.Controls.Add(this.btnXacNhan);
            this.tbpThemChiTiet.Controls.Add(this.label5);
            this.tbpThemChiTiet.Controls.Add(this.dgvThongTinChiTietPhieuNhap);
            this.tbpThemChiTiet.Location = new System.Drawing.Point(4, 24);
            this.tbpThemChiTiet.Margin = new System.Windows.Forms.Padding(2);
            this.tbpThemChiTiet.Name = "tbpThemChiTiet";
            this.tbpThemChiTiet.Padding = new System.Windows.Forms.Padding(2);
            this.tbpThemChiTiet.Size = new System.Drawing.Size(576, 487);
            this.tbpThemChiTiet.TabIndex = 1;
            this.tbpThemChiTiet.Text = "Thêm chi tiết phiếu nhập";
            this.tbpThemChiTiet.UseVisualStyleBackColor = true;
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuayLai.Location = new System.Drawing.Point(431, 456);
            this.btnQuayLai.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(58, 28);
            this.btnQuayLai.TabIndex = 3;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXacNhan.Location = new System.Drawing.Point(494, 456);
            this.btnXacNhan.Margin = new System.Windows.Forms.Padding(2);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(77, 28);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 10);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thông tin sản phẩm nhập";
            // 
            // dgvThongTinChiTietPhieuNhap
            // 
            this.dgvThongTinChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.maNCC,
            this.soLuong,
            this.tongDonGia});
            this.dgvThongTinChiTietPhieuNhap.Location = new System.Drawing.Point(2, 28);
            this.dgvThongTinChiTietPhieuNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongTinChiTietPhieuNhap.Name = "dgvThongTinChiTietPhieuNhap";
            this.dgvThongTinChiTietPhieuNhap.Size = new System.Drawing.Size(569, 424);
            this.dgvThongTinChiTietPhieuNhap.TabIndex = 0;
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "maHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            // 
            // maNCC
            // 
            this.maNCC.DataPropertyName = "maNCC";
            this.maNCC.HeaderText = "Mã nhà cung cấp";
            this.maNCC.Name = "maNCC";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuongNhap";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // tongDonGia
            // 
            this.tongDonGia.DataPropertyName = "tongDonGia";
            this.tongDonGia.HeaderText = "Tổng giá";
            this.tongDonGia.Name = "tongDonGia";
            // 
            // ThemPhieuNhap_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(605, 534);
            this.Controls.Add(this.tbThemPhieuNhap);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThemPhieuNhap_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhieuNhap_GUI";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ThemPhieuNhap_GUI_FormClosed);
            this.Load += new System.EventHandler(this.ThemPhieuNhap_GUI_Load);
            this.tbThemPhieuNhap.ResumeLayout(false);
            this.tbpThemPhieuNhap.ResumeLayout(false);
            this.grThemPhieuNhap.ResumeLayout(false);
            this.grThemPhieuNhap.PerformLayout();
            this.tbpThemChiTiet.ResumeLayout(false);
            this.tbpThemChiTiet.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbThemPhieuNhap;
        private System.Windows.Forms.TabPage tbpThemPhieuNhap;
        private System.Windows.Forms.GroupBox grThemPhieuNhap;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.TextBox txtMaDat;
        private System.Windows.Forms.Button btnTiepTuc;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tbpThemChiTiet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvThongTinChiTietPhieuNhap;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
    }
}