
namespace QLCHTAN
{
    partial class ThongTinPhieuDat_GUI
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
            this.lblThoat = new System.Windows.Forms.LinkLabel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaHangNhap = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMatHang = new System.Windows.Forms.ComboBox();
            this.txtMaDatHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachHangDat = new System.Windows.Forms.GroupBox();
            this.lblkLamMoi = new System.Windows.Forms.LinkLabel();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongTinChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinPhieuDat.SuspendLayout();
            this.grbDanhSachHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuDat)).BeginInit();
            this.SuspendLayout();
            // 
            // grbThongTinPhieuDat
            // 
            this.grbThongTinPhieuDat.Controls.Add(this.lblThoat);
            this.grbThongTinPhieuDat.Controls.Add(this.btnXoa);
            this.grbThongTinPhieuDat.Controls.Add(this.lblMaHangNhap);
            this.grbThongTinPhieuDat.Controls.Add(this.btnSua);
            this.grbThongTinPhieuDat.Controls.Add(this.btnThem);
            this.grbThongTinPhieuDat.Controls.Add(this.label5);
            this.grbThongTinPhieuDat.Controls.Add(this.txtSoLuong);
            this.grbThongTinPhieuDat.Controls.Add(this.label4);
            this.grbThongTinPhieuDat.Controls.Add(this.label3);
            this.grbThongTinPhieuDat.Controls.Add(this.cbbMatHang);
            this.grbThongTinPhieuDat.Controls.Add(this.txtMaDatHang);
            this.grbThongTinPhieuDat.Controls.Add(this.label1);
            this.grbThongTinPhieuDat.Location = new System.Drawing.Point(10, 10);
            this.grbThongTinPhieuDat.Name = "grbThongTinPhieuDat";
            this.grbThongTinPhieuDat.Size = new System.Drawing.Size(721, 193);
            this.grbThongTinPhieuDat.TabIndex = 4;
            this.grbThongTinPhieuDat.TabStop = false;
            this.grbThongTinPhieuDat.Text = "Thông tin phiếu đặt hàng";
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Location = new System.Drawing.Point(2, 172);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(39, 15);
            this.lblThoat.TabIndex = 9;
            this.lblThoat.TabStop = true;
            this.lblThoat.Text = "Thoát";
            this.lblThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblThoat_LinkClicked);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(543, 164);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblMaHangNhap
            // 
            this.lblMaHangNhap.AutoSize = true;
            this.lblMaHangNhap.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangNhap.ForeColor = System.Drawing.Color.Red;
            this.lblMaHangNhap.Location = new System.Drawing.Point(104, 55);
            this.lblMaHangNhap.Name = "lblMaHangNhap";
            this.lblMaHangNhap.Size = new System.Drawing.Size(55, 15);
            this.lblMaHangNhap.TabIndex = 30;
            this.lblMaHangNhap.Text = "................";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(624, 164);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(462, 164);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên hàng nhập:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(107, 126);
            this.txtSoLuong.MaxLength = 10;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(592, 23);
            this.txtSoLuong.TabIndex = 28;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã hàng nhập:";
            // 
            // cbbMatHang
            // 
            this.cbbMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMatHang.FormattingEnabled = true;
            this.cbbMatHang.Location = new System.Drawing.Point(107, 88);
            this.cbbMatHang.Name = "cbbMatHang";
            this.cbbMatHang.Size = new System.Drawing.Size(592, 23);
            this.cbbMatHang.TabIndex = 25;
            this.cbbMatHang.SelectedValueChanged += new System.EventHandler(this.cbbMatHang_SelectedValueChanged);
            // 
            // txtMaDatHang
            // 
            this.txtMaDatHang.Enabled = false;
            this.txtMaDatHang.Location = new System.Drawing.Point(107, 21);
            this.txtMaDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDatHang.Name = "txtMaDatHang";
            this.txtMaDatHang.Size = new System.Drawing.Size(592, 23);
            this.txtMaDatHang.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã đặt hàng:";
            // 
            // grbDanhSachHangDat
            // 
            this.grbDanhSachHangDat.Controls.Add(this.lblkLamMoi);
            this.grbDanhSachHangDat.Controls.Add(this.lblTongGia);
            this.grbDanhSachHangDat.Controls.Add(this.label2);
            this.grbDanhSachHangDat.Controls.Add(this.dgvThongTinChiTietPhieuDat);
            this.grbDanhSachHangDat.Location = new System.Drawing.Point(11, 208);
            this.grbDanhSachHangDat.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhSachHangDat.Name = "grbDanhSachHangDat";
            this.grbDanhSachHangDat.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhSachHangDat.Size = new System.Drawing.Size(720, 413);
            this.grbDanhSachHangDat.TabIndex = 5;
            this.grbDanhSachHangDat.TabStop = false;
            this.grbDanhSachHangDat.Text = "Danh sách hàng đặt";
            // 
            // lblkLamMoi
            // 
            this.lblkLamMoi.AutoSize = true;
            this.lblkLamMoi.Location = new System.Drawing.Point(643, 384);
            this.lblkLamMoi.Name = "lblkLamMoi";
            this.lblkLamMoi.Size = new System.Drawing.Size(55, 15);
            this.lblkLamMoi.TabIndex = 3;
            this.lblkLamMoi.TabStop = true;
            this.lblkLamMoi.Text = "Làm mới";
            this.lblkLamMoi.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkLamMoi_LinkClicked);
            // 
            // lblTongGia
            // 
            this.lblTongGia.AutoSize = true;
            this.lblTongGia.Location = new System.Drawing.Point(62, 384);
            this.lblTongGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(37, 15);
            this.lblTongGia.TabIndex = 2;
            this.lblTongGia.Text = "..........";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 384);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng giá:";
            // 
            // dgvThongTinChiTietPhieuDat
            // 
            this.dgvThongTinChiTietPhieuDat.AllowUserToAddRows = false;
            this.dgvThongTinChiTietPhieuDat.AllowUserToDeleteRows = false;
            this.dgvThongTinChiTietPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTietPhieuDat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinChiTietPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTietPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.soLuongDat,
            this.tenNCC,
            this.tongDonGia});
            this.dgvThongTinChiTietPhieuDat.Location = new System.Drawing.Point(4, 20);
            this.dgvThongTinChiTietPhieuDat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongTinChiTietPhieuDat.Name = "dgvThongTinChiTietPhieuDat";
            this.dgvThongTinChiTietPhieuDat.ReadOnly = true;
            this.dgvThongTinChiTietPhieuDat.RowHeadersWidth = 51;
            this.dgvThongTinChiTietPhieuDat.Size = new System.Drawing.Size(714, 362);
            this.dgvThongTinChiTietPhieuDat.TabIndex = 0;
            this.dgvThongTinChiTietPhieuDat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinChiTietPhieuDat_CellClick);
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "maHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            this.maHang.ReadOnly = true;
            this.maHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maHang.Visible = false;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenHang";
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.MinimumWidth = 6;
            this.tenHang.Name = "tenHang";
            this.tenHang.ReadOnly = true;
            this.tenHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // soLuongDat
            // 
            this.soLuongDat.DataPropertyName = "soLuongDat";
            this.soLuongDat.HeaderText = "Số lượng đặt";
            this.soLuongDat.MinimumWidth = 6;
            this.soLuongDat.Name = "soLuongDat";
            this.soLuongDat.ReadOnly = true;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.tenNCC.MinimumWidth = 6;
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            // 
            // tongDonGia
            // 
            this.tongDonGia.DataPropertyName = "tongDonGia";
            this.tongDonGia.HeaderText = "Tổng đơn giá";
            this.tongDonGia.MinimumWidth = 6;
            this.tongDonGia.Name = "tongDonGia";
            this.tongDonGia.ReadOnly = true;
            // 
            // ThongTinPhieuDat_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(745, 628);
            this.Controls.Add(this.grbThongTinPhieuDat);
            this.Controls.Add(this.grbDanhSachHangDat);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongTinPhieuDat_GUI";
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.LinkLabel lblThoat;
        private System.Windows.Forms.LinkLabel lblkLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
        private System.Windows.Forms.Label lblMaHangNhap;
        private System.Windows.Forms.Label label5;
    }
}