
namespace QLCHTAN
{
    partial class ThongTinPhieuNhap_GUI
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
            this.grbThongTinphieuNhap = new System.Windows.Forms.GroupBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNhaCungCap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDanhSachHangNhap = new System.Windows.Forms.GroupBox();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongTinChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbThongTinphieuNhap.SuspendLayout();
            this.grbDanhSachHangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinphieuNhap
            // 
            this.grbThongTinphieuNhap.Controls.Add(this.txtMaNhap);
            this.grbThongTinphieuNhap.Controls.Add(this.label1);
            this.grbThongTinphieuNhap.Controls.Add(this.txtNhaCungCap);
            this.grbThongTinphieuNhap.Controls.Add(this.label3);
            this.grbThongTinphieuNhap.Location = new System.Drawing.Point(13, 28);
            this.grbThongTinphieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTinphieuNhap.Name = "grbThongTinphieuNhap";
            this.grbThongTinphieuNhap.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTinphieuNhap.Size = new System.Drawing.Size(622, 129);
            this.grbThongTinphieuNhap.TabIndex = 0;
            this.grbThongTinphieuNhap.TabStop = false;
            this.grbThongTinphieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Enabled = false;
            this.txtMaNhap.Location = new System.Drawing.Point(119, 42);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(476, 27);
            this.txtMaNhap.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã nhập:";
            // 
            // txtNhaCungCap
            // 
            this.txtNhaCungCap.Location = new System.Drawing.Point(119, 75);
            this.txtNhaCungCap.Name = "txtNhaCungCap";
            this.txtNhaCungCap.Size = new System.Drawing.Size(476, 27);
            this.txtNhaCungCap.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Nhà cung cấp:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDanhSachHangNhap
            // 
            this.grbDanhSachHangNhap.Controls.Add(this.lblTongGia);
            this.grbDanhSachHangNhap.Controls.Add(this.label2);
            this.grbDanhSachHangNhap.Controls.Add(this.dgvThongTinChiTietPhieuNhap);
            this.grbDanhSachHangNhap.Location = new System.Drawing.Point(13, 164);
            this.grbDanhSachHangNhap.Name = "grbDanhSachHangNhap";
            this.grbDanhSachHangNhap.Size = new System.Drawing.Size(622, 313);
            this.grbDanhSachHangNhap.TabIndex = 1;
            this.grbDanhSachHangNhap.TabStop = false;
            this.grbDanhSachHangNhap.Text = "Danh sách hàng nhập";
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
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng giá:";
            // 
            // dgvThongTinChiTietPhieuNhap
            // 
            this.dgvThongTinChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.soLuong});
            this.dgvThongTinChiTietPhieuNhap.Location = new System.Drawing.Point(12, 26);
            this.dgvThongTinChiTietPhieuNhap.Name = "dgvThongTinChiTietPhieuNhap";
            this.dgvThongTinChiTietPhieuNhap.Size = new System.Drawing.Size(583, 247);
            this.dgvThongTinChiTietPhieuNhap.TabIndex = 0;
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "maHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng";
            this.soLuong.Name = "soLuong";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(364, 483);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(169, 41);
            this.btnCapNhat.TabIndex = 2;
            this.btnCapNhat.Text = "Cập nhật phiếu nhập";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(539, 483);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 41);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // ThongTinPhieuNhap_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 530);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.grbDanhSachHangNhap);
            this.Controls.Add(this.grbThongTinphieuNhap);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinPhieuNhap_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhieuNhap";
            this.Load += new System.EventHandler(this.ThongTinPhieuNhap_GUI_Load);
            this.grbThongTinphieuNhap.ResumeLayout(false);
            this.grbThongTinphieuNhap.PerformLayout();
            this.grbDanhSachHangNhap.ResumeLayout(false);
            this.grbDanhSachHangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbThongTinphieuNhap;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNhaCungCap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox grbDanhSachHangNhap;
        private System.Windows.Forms.DataGridView dgvThongTinChiTietPhieuNhap;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTongGia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
    }
}