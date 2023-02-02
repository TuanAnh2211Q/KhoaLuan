
namespace QLCHTAN
{
    partial class ThongTinPhieuXuat_GUI
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
            this.dgvThongTinPhieuXuat = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.lblThongTinPhieuXuat = new System.Windows.Forms.Label();
            this.grbThongTinPhieuDat = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.lblSoLuongTon = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblMaHangXuat = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSoLuongXuat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMatHang = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuXuat)).BeginInit();
            this.grbThongTinPhieuDat.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinPhieuXuat
            // 
            this.dgvThongTinPhieuXuat.AllowUserToAddRows = false;
            this.dgvThongTinPhieuXuat.AllowUserToDeleteRows = false;
            this.dgvThongTinPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.soLuong,
            this.tongDonGia,
            this.ghiChu});
            this.dgvThongTinPhieuXuat.Location = new System.Drawing.Point(13, 299);
            this.dgvThongTinPhieuXuat.Name = "dgvThongTinPhieuXuat";
            this.dgvThongTinPhieuXuat.ReadOnly = true;
            this.dgvThongTinPhieuXuat.RowHeadersWidth = 51;
            this.dgvThongTinPhieuXuat.Size = new System.Drawing.Size(842, 555);
            this.dgvThongTinPhieuXuat.TabIndex = 6;
            this.dgvThongTinPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinPhieuXuat_CellClick);
            // 
            // maHang
            // 
            this.maHang.DataPropertyName = "maHang";
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.MinimumWidth = 6;
            this.maHang.Name = "maHang";
            this.maHang.ReadOnly = true;
            // 
            // tenHang
            // 
            this.tenHang.DataPropertyName = "tenHang";
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.Name = "tenHang";
            this.tenHang.ReadOnly = true;
            // 
            // soLuong
            // 
            this.soLuong.DataPropertyName = "soLuong";
            this.soLuong.HeaderText = "Số lượng hàng";
            this.soLuong.MinimumWidth = 6;
            this.soLuong.Name = "soLuong";
            this.soLuong.ReadOnly = true;
            // 
            // tongDonGia
            // 
            this.tongDonGia.DataPropertyName = "tongDonGia";
            this.tongDonGia.HeaderText = "Tổng đơn giá";
            this.tongDonGia.Name = "tongDonGia";
            this.tongDonGia.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkThoat.Location = new System.Drawing.Point(806, 857);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(49, 19);
            this.lblkThoat.TabIndex = 9;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // lblThongTinPhieuXuat
            // 
            this.lblThongTinPhieuXuat.AutoSize = true;
            this.lblThongTinPhieuXuat.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhieuXuat.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinPhieuXuat.Location = new System.Drawing.Point(257, 10);
            this.lblThongTinPhieuXuat.Name = "lblThongTinPhieuXuat";
            this.lblThongTinPhieuXuat.Size = new System.Drawing.Size(263, 29);
            this.lblThongTinPhieuXuat.TabIndex = 8;
            this.lblThongTinPhieuXuat.Text = "THÔNG TIN PHIẾU XUẤT";
            // 
            // grbThongTinPhieuDat
            // 
            this.grbThongTinPhieuDat.Controls.Add(this.label2);
            this.grbThongTinPhieuDat.Controls.Add(this.txtGhiChu);
            this.grbThongTinPhieuDat.Controls.Add(this.lblSoLuongTon);
            this.grbThongTinPhieuDat.Controls.Add(this.label1);
            this.grbThongTinPhieuDat.Controls.Add(this.btnXoa);
            this.grbThongTinPhieuDat.Controls.Add(this.lblMaHangXuat);
            this.grbThongTinPhieuDat.Controls.Add(this.btnSua);
            this.grbThongTinPhieuDat.Controls.Add(this.btnThem);
            this.grbThongTinPhieuDat.Controls.Add(this.label5);
            this.grbThongTinPhieuDat.Controls.Add(this.txtSoLuongXuat);
            this.grbThongTinPhieuDat.Controls.Add(this.label4);
            this.grbThongTinPhieuDat.Controls.Add(this.label3);
            this.grbThongTinPhieuDat.Controls.Add(this.cbbMatHang);
            this.grbThongTinPhieuDat.Location = new System.Drawing.Point(14, 67);
            this.grbThongTinPhieuDat.Name = "grbThongTinPhieuDat";
            this.grbThongTinPhieuDat.Size = new System.Drawing.Size(841, 223);
            this.grbThongTinPhieuDat.TabIndex = 10;
            this.grbThongTinPhieuDat.TabStop = false;
            this.grbThongTinPhieuDat.Text = "Thông tin phiếu xuất hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 34;
            this.label2.Text = "Ghi chú:";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(124, 120);
            this.txtGhiChu.MaxLength = 10;
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(690, 63);
            this.txtGhiChu.TabIndex = 33;
            // 
            // lblSoLuongTon
            // 
            this.lblSoLuongTon.AutoSize = true;
            this.lblSoLuongTon.Location = new System.Drawing.Point(121, 73);
            this.lblSoLuongTon.Name = "lblSoLuongTon";
            this.lblSoLuongTon.Size = new System.Drawing.Size(22, 15);
            this.lblSoLuongTon.TabIndex = 32;
            this.lblSoLuongTon.Text = ".....";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 15);
            this.label1.TabIndex = 31;
            this.label1.Text = "Số lượng tồn:";
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.Location = new System.Drawing.Point(633, 189);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(87, 27);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // lblMaHangXuat
            // 
            this.lblMaHangXuat.AutoSize = true;
            this.lblMaHangXuat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaHangXuat.ForeColor = System.Drawing.Color.Red;
            this.lblMaHangXuat.Location = new System.Drawing.Point(126, 29);
            this.lblMaHangXuat.Name = "lblMaHangXuat";
            this.lblMaHangXuat.Size = new System.Drawing.Size(55, 15);
            this.lblMaHangXuat.TabIndex = 30;
            this.lblMaHangXuat.Text = "................";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.Location = new System.Drawing.Point(728, 189);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(87, 27);
            this.btnSua.TabIndex = 11;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.Location = new System.Drawing.Point(539, 189);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(87, 27);
            this.btnThem.TabIndex = 10;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "Tên hàng xuất:";
            // 
            // txtSoLuongXuat
            // 
            this.txtSoLuongXuat.Location = new System.Drawing.Point(124, 91);
            this.txtSoLuongXuat.MaxLength = 10;
            this.txtSoLuongXuat.Name = "txtSoLuongXuat";
            this.txtSoLuongXuat.Size = new System.Drawing.Size(690, 23);
            this.txtSoLuongXuat.TabIndex = 28;
            this.txtSoLuongXuat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuongXuat_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Số lượng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 15);
            this.label3.TabIndex = 26;
            this.label3.Text = "Mã hàng xuất:";
            // 
            // cbbMatHang
            // 
            this.cbbMatHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMatHang.FormattingEnabled = true;
            this.cbbMatHang.Location = new System.Drawing.Point(125, 47);
            this.cbbMatHang.Name = "cbbMatHang";
            this.cbbMatHang.Size = new System.Drawing.Size(690, 23);
            this.cbbMatHang.TabIndex = 25;
            this.cbbMatHang.SelectedValueChanged += new System.EventHandler(this.cbbMatHang_SelectedValueChanged);
            // 
            // ThongTinPhieuXuat_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 883);
            this.Controls.Add(this.grbThongTinPhieuDat);
            this.Controls.Add(this.dgvThongTinPhieuXuat);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.lblThongTinPhieuXuat);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ThongTinPhieuXuat_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhieuXuat_GUI";
            this.Load += new System.EventHandler(this.ThongTinPhieuXuat_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuXuat)).EndInit();
            this.grbThongTinPhieuDat.ResumeLayout(false);
            this.grbThongTinPhieuDat.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThongTinPhieuXuat;
        private System.Windows.Forms.LinkLabel lblkThoat;
        private System.Windows.Forms.Label lblThongTinPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.GroupBox grbThongTinPhieuDat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblMaHangXuat;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSoLuongXuat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMatHang;
        private System.Windows.Forms.Label lblSoLuongTon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtGhiChu;
    }
}