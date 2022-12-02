
namespace QLCHTAN
{
    partial class ThongTinPhieuTra_GUI
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
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblThoat = new System.Windows.Forms.LinkLabel();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.lblkLamMoi = new System.Windows.Forms.LinkLabel();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvThongTinChiTietPhieuDat = new System.Windows.Forms.DataGridView();
            this.lblMaHangTra = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMatHang = new System.Windows.Forms.ComboBox();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.grbThongTinPhieuDat = new System.Windows.Forms.GroupBox();
            this.grbDanhSachHangDat = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuDat)).BeginInit();
            this.grbThongTinPhieuDat.SuspendLayout();
            this.grbDanhSachHangDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(397, 440);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 27);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(302, 440);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 16;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Location = new System.Drawing.Point(10, 440);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(39, 15);
            this.lblThoat.TabIndex = 15;
            this.lblThoat.TabStop = true;
            this.lblThoat.Text = "Thoát";
            // 
            // tongDonGia
            // 
            this.tongDonGia.DataPropertyName = "tongDonGia";
            this.tongDonGia.HeaderText = "Tổng đơn giá";
            this.tongDonGia.MinimumWidth = 6;
            this.tongDonGia.Name = "tongDonGia";
            this.tongDonGia.ReadOnly = true;
            // 
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.tenNCC.MinimumWidth = 6;
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
            // 
            // soLuongDat
            // 
            this.soLuongDat.DataPropertyName = "soLuongDat";
            this.soLuongDat.HeaderText = "Số lượng đặt";
            this.soLuongDat.MinimumWidth = 6;
            this.soLuongDat.Name = "soLuongDat";
            this.soLuongDat.ReadOnly = true;
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
            // maHang
            // 
            this.maHang.DataPropertyName = "maHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            this.maHang.ReadOnly = true;
            this.maHang.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.maHang.Visible = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(491, 440);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 27);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // lblkLamMoi
            // 
            this.lblkLamMoi.AutoSize = true;
            this.lblkLamMoi.Location = new System.Drawing.Point(497, 232);
            this.lblkLamMoi.Name = "lblkLamMoi";
            this.lblkLamMoi.Size = new System.Drawing.Size(55, 15);
            this.lblkLamMoi.TabIndex = 3;
            this.lblkLamMoi.TabStop = true;
            this.lblkLamMoi.Text = "Làm mới";
            // 
            // lblTongGia
            // 
            this.lblTongGia.AutoSize = true;
            this.lblTongGia.Location = new System.Drawing.Point(70, 232);
            this.lblTongGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(37, 15);
            this.lblTongGia.TabIndex = 2;
            this.lblTongGia.Text = "..........";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã trả hàng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 232);
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
            this.dgvThongTinChiTietPhieuDat.Location = new System.Drawing.Point(13, 23);
            this.dgvThongTinChiTietPhieuDat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongTinChiTietPhieuDat.Name = "dgvThongTinChiTietPhieuDat";
            this.dgvThongTinChiTietPhieuDat.ReadOnly = true;
            this.dgvThongTinChiTietPhieuDat.RowHeadersWidth = 51;
            this.dgvThongTinChiTietPhieuDat.Size = new System.Drawing.Size(548, 207);
            this.dgvThongTinChiTietPhieuDat.TabIndex = 0;
            // 
            // lblMaHangTra
            // 
            this.lblMaHangTra.AutoSize = true;
            this.lblMaHangTra.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangTra.ForeColor = System.Drawing.Color.Red;
            this.lblMaHangTra.Location = new System.Drawing.Point(118, 75);
            this.lblMaHangTra.Name = "lblMaHangTra";
            this.lblMaHangTra.Size = new System.Drawing.Size(55, 15);
            this.lblMaHangTra.TabIndex = 30;
            this.lblMaHangTra.Text = "................";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên hàng trả:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(456, 110);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(88, 23);
            this.txtSoLuong.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(379, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã hàng trả:";
            // 
            // cbbMatHang
            // 
            this.cbbMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMatHang.FormattingEnabled = true;
            this.cbbMatHang.Location = new System.Drawing.Point(121, 110);
            this.cbbMatHang.Name = "cbbMatHang";
            this.cbbMatHang.Size = new System.Drawing.Size(241, 23);
            this.cbbMatHang.TabIndex = 25;
            // 
            // txtMaTra
            // 
            this.txtMaTra.Enabled = false;
            this.txtMaTra.Location = new System.Drawing.Point(112, 24);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.Size = new System.Drawing.Size(432, 23);
            this.txtMaTra.TabIndex = 24;
            // 
            // grbThongTinPhieuDat
            // 
            this.grbThongTinPhieuDat.Controls.Add(this.lblMaHangTra);
            this.grbThongTinPhieuDat.Controls.Add(this.label5);
            this.grbThongTinPhieuDat.Controls.Add(this.txtSoLuong);
            this.grbThongTinPhieuDat.Controls.Add(this.label4);
            this.grbThongTinPhieuDat.Controls.Add(this.label3);
            this.grbThongTinPhieuDat.Controls.Add(this.cbbMatHang);
            this.grbThongTinPhieuDat.Controls.Add(this.txtMaTra);
            this.grbThongTinPhieuDat.Controls.Add(this.label1);
            this.grbThongTinPhieuDat.Location = new System.Drawing.Point(14, 24);
            this.grbThongTinPhieuDat.Name = "grbThongTinPhieuDat";
            this.grbThongTinPhieuDat.Size = new System.Drawing.Size(565, 143);
            this.grbThongTinPhieuDat.TabIndex = 13;
            this.grbThongTinPhieuDat.TabStop = false;
            this.grbThongTinPhieuDat.Text = "Thông tin phiếu đặt hàng";
            // 
            // grbDanhSachHangDat
            // 
            this.grbDanhSachHangDat.Controls.Add(this.lblkLamMoi);
            this.grbDanhSachHangDat.Controls.Add(this.lblTongGia);
            this.grbDanhSachHangDat.Controls.Add(this.label2);
            this.grbDanhSachHangDat.Controls.Add(this.dgvThongTinChiTietPhieuDat);
            this.grbDanhSachHangDat.Location = new System.Drawing.Point(15, 173);
            this.grbDanhSachHangDat.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhSachHangDat.Name = "grbDanhSachHangDat";
            this.grbDanhSachHangDat.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhSachHangDat.Size = new System.Drawing.Size(565, 261);
            this.grbDanhSachHangDat.TabIndex = 14;
            this.grbDanhSachHangDat.TabStop = false;
            this.grbDanhSachHangDat.Text = "Danh sách hàng đặt";
            // 
            // ThongTinPhieuTra_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 480);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.lblThoat);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.grbThongTinPhieuDat);
            this.Controls.Add(this.grbDanhSachHangDat);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ThongTinPhieuTra_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhieuTra_GUI";
            this.Load += new System.EventHandler(this.ThongTinPhieuTra_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuDat)).EndInit();
            this.grbThongTinPhieuDat.ResumeLayout(false);
            this.grbThongTinPhieuDat.PerformLayout();
            this.grbDanhSachHangDat.ResumeLayout(false);
            this.grbDanhSachHangDat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.LinkLabel lblThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.LinkLabel lblkLamMoi;
        private System.Windows.Forms.Label lblTongGia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvThongTinChiTietPhieuDat;
        private System.Windows.Forms.Label lblMaHangTra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.GroupBox grbThongTinPhieuDat;
        private System.Windows.Forms.GroupBox grbDanhSachHangDat;
    }
}