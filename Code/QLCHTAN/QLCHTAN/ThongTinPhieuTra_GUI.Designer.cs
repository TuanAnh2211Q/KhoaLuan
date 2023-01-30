
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.lblkLamMoi = new System.Windows.Forms.LinkLabel();
            this.grbDanhSachHangDat = new System.Windows.Forms.GroupBox();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.dgvThongTinPhieuTra = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinPhieuDat = new System.Windows.Forms.GroupBox();
            this.lblSoLuongDat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaDatHang = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.grbDanhSachHangDat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuTra)).BeginInit();
            this.grbThongTinPhieuDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblThoat
            // 
            this.lblThoat.AutoSize = true;
            this.lblThoat.Location = new System.Drawing.Point(0, 222);
            this.lblThoat.Name = "lblThoat";
            this.lblThoat.Size = new System.Drawing.Size(39, 15);
            this.lblThoat.TabIndex = 9;
            this.lblThoat.TabStop = true;
            this.lblThoat.Text = "Thoát";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(543, 218);
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
            this.btnSua.Location = new System.Drawing.Point(624, 218);
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
            this.btnThem.Location = new System.Drawing.Point(462, 218);
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
            this.label5.Size = new System.Drawing.Size(79, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên hàng trả:";
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(105, 165);
            this.txtSoLuong.MaxLength = 8;
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(592, 23);
            this.txtSoLuong.TabIndex = 28;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lượng trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã hàng trả:";
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 322);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng giá:";
            // 
            // txtMaTra
            // 
            this.txtMaTra.Enabled = false;
            this.txtMaTra.Location = new System.Drawing.Point(107, 21);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.Size = new System.Drawing.Size(264, 23);
            this.txtMaTra.TabIndex = 24;
            // 
            // lblkLamMoi
            // 
            this.lblkLamMoi.AutoSize = true;
            this.lblkLamMoi.Location = new System.Drawing.Point(641, 322);
            this.lblkLamMoi.Name = "lblkLamMoi";
            this.lblkLamMoi.Size = new System.Drawing.Size(55, 15);
            this.lblkLamMoi.TabIndex = 3;
            this.lblkLamMoi.TabStop = true;
            this.lblkLamMoi.Text = "Làm mới";
            // 
            // grbDanhSachHangDat
            // 
            this.grbDanhSachHangDat.Controls.Add(this.lblkLamMoi);
            this.grbDanhSachHangDat.Controls.Add(this.lblTongGia);
            this.grbDanhSachHangDat.Controls.Add(this.label2);
            this.grbDanhSachHangDat.Controls.Add(this.dgvThongTinPhieuTra);
            this.grbDanhSachHangDat.Location = new System.Drawing.Point(13, 277);
            this.grbDanhSachHangDat.Margin = new System.Windows.Forms.Padding(2);
            this.grbDanhSachHangDat.Name = "grbDanhSachHangDat";
            this.grbDanhSachHangDat.Padding = new System.Windows.Forms.Padding(2);
            this.grbDanhSachHangDat.Size = new System.Drawing.Size(720, 346);
            this.grbDanhSachHangDat.TabIndex = 7;
            this.grbDanhSachHangDat.TabStop = false;
            this.grbDanhSachHangDat.Text = "Danh sách hàng đặt";
            // 
            // lblTongGia
            // 
            this.lblTongGia.AutoSize = true;
            this.lblTongGia.Location = new System.Drawing.Point(60, 322);
            this.lblTongGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(37, 15);
            this.lblTongGia.TabIndex = 2;
            this.lblTongGia.Text = "..........";
            // 
            // dgvThongTinPhieuTra
            // 
            this.dgvThongTinPhieuTra.AllowUserToAddRows = false;
            this.dgvThongTinPhieuTra.AllowUserToDeleteRows = false;
            this.dgvThongTinPhieuTra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinPhieuTra.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinPhieuTra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPhieuTra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.soLuong,
            this.tenNCC,
            this.tongDonGia});
            this.dgvThongTinPhieuTra.Location = new System.Drawing.Point(2, 20);
            this.dgvThongTinPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongTinPhieuTra.Name = "dgvThongTinPhieuTra";
            this.dgvThongTinPhieuTra.ReadOnly = true;
            this.dgvThongTinPhieuTra.RowHeadersWidth = 51;
            this.dgvThongTinPhieuTra.Size = new System.Drawing.Size(714, 300);
            this.dgvThongTinPhieuTra.TabIndex = 0;
            this.dgvThongTinPhieuTra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinPhieuTra_CellClick);
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
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng trả";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã trả hàng:";
            // 
            // grbThongTinPhieuDat
            // 
            this.grbThongTinPhieuDat.Controls.Add(this.lblSoLuongDat);
            this.grbThongTinPhieuDat.Controls.Add(this.label7);
            this.grbThongTinPhieuDat.Controls.Add(this.txtMaDatHang);
            this.grbThongTinPhieuDat.Controls.Add(this.label6);
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
            this.grbThongTinPhieuDat.Controls.Add(this.txtMaTra);
            this.grbThongTinPhieuDat.Controls.Add(this.label1);
            this.grbThongTinPhieuDat.Location = new System.Drawing.Point(12, 12);
            this.grbThongTinPhieuDat.Name = "grbThongTinPhieuDat";
            this.grbThongTinPhieuDat.Size = new System.Drawing.Size(721, 247);
            this.grbThongTinPhieuDat.TabIndex = 6;
            this.grbThongTinPhieuDat.TabStop = false;
            this.grbThongTinPhieuDat.Text = "Thông tin phiếu đặt hàng";
            // 
            // lblSoLuongDat
            // 
            this.lblSoLuongDat.AutoSize = true;
            this.lblSoLuongDat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuongDat.ForeColor = System.Drawing.Color.Red;
            this.lblSoLuongDat.Location = new System.Drawing.Point(104, 137);
            this.lblSoLuongDat.Name = "lblSoLuongDat";
            this.lblSoLuongDat.Size = new System.Drawing.Size(55, 15);
            this.lblSoLuongDat.TabIndex = 34;
            this.lblSoLuongDat.Text = "................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 15);
            this.label7.TabIndex = 33;
            this.label7.Text = "Số lượng đặt:";
            // 
            // txtMaDatHang
            // 
            this.txtMaDatHang.Enabled = false;
            this.txtMaDatHang.Location = new System.Drawing.Point(477, 24);
            this.txtMaDatHang.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaDatHang.Name = "txtMaDatHang";
            this.txtMaDatHang.Size = new System.Drawing.Size(222, 23);
            this.txtMaDatHang.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(395, 27);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 15);
            this.label6.TabIndex = 31;
            this.label6.Text = "Mã đặt hàng:";
            // 
            // ThongTinPhieuTra_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(739, 636);
            this.Controls.Add(this.grbDanhSachHangDat);
            this.Controls.Add(this.grbThongTinPhieuDat);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongTinPhieuTra_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin phiếu trả";
            this.Load += new System.EventHandler(this.ThongTinPhieuTra_GUI_Load);
            this.grbDanhSachHangDat.ResumeLayout(false);
            this.grbDanhSachHangDat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuTra)).EndInit();
            this.grbThongTinPhieuDat.ResumeLayout(false);
            this.grbThongTinPhieuDat.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblThoat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaHangNhap;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.LinkLabel lblkLamMoi;
        private System.Windows.Forms.GroupBox grbDanhSachHangDat;
        private System.Windows.Forms.Label lblTongGia;
        private System.Windows.Forms.DataGridView dgvThongTinPhieuTra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbThongTinPhieuDat;
        private System.Windows.Forms.TextBox txtMaDatHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSoLuongDat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
    }
}