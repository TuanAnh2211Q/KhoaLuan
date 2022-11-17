
namespace QLCHTAN
{
    partial class ThongTinChiTietPhieuDat_GUI
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
            this.grbThongTinPhieuDat = new System.Windows.Forms.GroupBox();
            this.txtMaDatHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachHangDat = new System.Windows.Forms.GroupBox();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongTinChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grbThongTinPhieuDat.SuspendLayout();
            this.grbDanhSachHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinPhieuDat
            // 
            this.grbThongTinPhieuDat.Controls.Add(this.txtMaDatHang);
            this.grbThongTinPhieuDat.Controls.Add(this.label1);
            this.grbThongTinPhieuDat.Location = new System.Drawing.Point(13, 13);
            this.grbThongTinPhieuDat.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTinPhieuDat.Name = "grbThongTinPhieuDat";
            this.grbThongTinPhieuDat.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTinPhieuDat.Size = new System.Drawing.Size(622, 129);
            this.grbThongTinPhieuDat.TabIndex = 4;
            this.grbThongTinPhieuDat.TabStop = false;
            this.grbThongTinPhieuDat.Text = "Thông tin phiếu đặt hàng";
            // 
            // txtMaDatHang
            // 
            this.txtMaDatHang.Enabled = false;
            this.txtMaDatHang.Location = new System.Drawing.Point(119, 65);
            this.txtMaDatHang.Name = "txtMaDatHang";
            this.txtMaDatHang.Size = new System.Drawing.Size(476, 27);
            this.txtMaDatHang.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã đặt hàng:";
            // 
            // grbDanhSachHangDat
            // 
            this.grbDanhSachHangDat.Controls.Add(this.lblTongGia);
            this.grbDanhSachHangDat.Controls.Add(this.label2);
            this.grbDanhSachHangDat.Controls.Add(this.dgvThongTinChiTietPhieuDat);
            this.grbDanhSachHangDat.Location = new System.Drawing.Point(13, 149);
            this.grbDanhSachHangDat.Name = "grbDanhSachHangDat";
            this.grbDanhSachHangDat.Size = new System.Drawing.Size(622, 313);
            this.grbDanhSachHangDat.TabIndex = 5;
            this.grbDanhSachHangDat.TabStop = false;
            this.grbDanhSachHangDat.Text = "Danh sách hàng đặt";
            // 
            // lblTongGia
            // 
            this.lblTongGia.AutoSize = true;
            this.lblTongGia.Location = new System.Drawing.Point(75, 276);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(49, 19);
            this.lblTongGia.TabIndex = 2;
            this.lblTongGia.Text = "..........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng giá:";
            // 
            // dgvThongTinChiTietPhieuDat
            // 
            this.dgvThongTinChiTietPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTietPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenHang,
            this.soLuongDat,
            this.tenNCC,
            this.tongDonGia});
            this.dgvThongTinChiTietPhieuDat.Location = new System.Drawing.Point(12, 26);
            this.dgvThongTinChiTietPhieuDat.Name = "dgvThongTinChiTietPhieuDat";
            this.dgvThongTinChiTietPhieuDat.Size = new System.Drawing.Size(583, 247);
            this.dgvThongTinChiTietPhieuDat.TabIndex = 0;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenHang";
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.Name = "tenHang";
            // 
            // soLuongDat
            // 
            this.soLuongDat.DataPropertyName = "soLuongDat";
            this.soLuongDat.HeaderText = "Số lượng đặt";
            this.soLuongDat.Name = "soLuongDat";
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.tenNCC.Name = "tenNCC";
            // 
            // tongDonGia
            // 
            this.tongDonGia.DataPropertyName = "tongDonGia";
            this.tongDonGia.HeaderText = "Tổng đơn giá";
            this.tongDonGia.Name = "tongDonGia";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(539, 468);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(348, 468);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(185, 41);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật phiếu đặt hàng";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // ThongTinChiTietPhieuDat_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 529);
            this.Controls.Add(this.grbThongTinPhieuDat);
            this.Controls.Add(this.grbDanhSachHangDat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinChiTietPhieuDat_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinChiTietPhieuDat_GUI";
            this.Load += new System.EventHandler(this.ThongTinChiTietPhieuDat_GUI_Load);
            this.grbThongTinPhieuDat.ResumeLayout(false);
            this.grbThongTinPhieuDat.PerformLayout();
            this.grbDanhSachHangDat.ResumeLayout(false);
            this.grbDanhSachHangDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinPhieuDat;
        private System.Windows.Forms.TextBox txtMaDatHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDanhSachHangDat;
        private System.Windows.Forms.Label lblTongGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThongTinChiTietPhieuDat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
    }
}