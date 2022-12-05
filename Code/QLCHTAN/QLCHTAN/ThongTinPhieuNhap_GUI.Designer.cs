
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
            this.lblTongGiaNhap = new System.Windows.Forms.Label();
            this.dgvThongTinChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblThongTinPhieuNhap = new System.Windows.Forms.Label();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongGiaNhap
            // 
            this.lblTongGiaNhap.AutoSize = true;
            this.lblTongGiaNhap.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGiaNhap.Location = new System.Drawing.Point(12, 53);
            this.lblTongGiaNhap.Name = "lblTongGiaNhap";
            this.lblTongGiaNhap.Size = new System.Drawing.Size(82, 23);
            this.lblTongGiaNhap.TabIndex = 1;
            this.lblTongGiaNhap.Text = "Tổng giá:";
            // 
            // dgvThongTinChiTietPhieuNhap
            // 
            this.dgvThongTinChiTietPhieuNhap.AllowUserToAddRows = false;
            this.dgvThongTinChiTietPhieuNhap.AllowUserToDeleteRows = false;
            this.dgvThongTinChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinChiTietPhieuNhap.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinChiTietPhieuNhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.tenNCC,
            this.soLuong,
            this.tongDonGia});
            this.dgvThongTinChiTietPhieuNhap.Location = new System.Drawing.Point(12, 79);
            this.dgvThongTinChiTietPhieuNhap.Name = "dgvThongTinChiTietPhieuNhap";
            this.dgvThongTinChiTietPhieuNhap.ReadOnly = true;
            this.dgvThongTinChiTietPhieuNhap.RowHeadersWidth = 51;
            this.dgvThongTinChiTietPhieuNhap.Size = new System.Drawing.Size(1067, 692);
            this.dgvThongTinChiTietPhieuNhap.TabIndex = 0;
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
            // tenNCC
            // 
            this.tenNCC.DataPropertyName = "tenNCC";
            this.tenNCC.HeaderText = "Tên nhà cung cấp";
            this.tenNCC.Name = "tenNCC";
            this.tenNCC.ReadOnly = true;
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
            // lblThongTinPhieuNhap
            // 
            this.lblThongTinPhieuNhap.AutoSize = true;
            this.lblThongTinPhieuNhap.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhieuNhap.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinPhieuNhap.Location = new System.Drawing.Point(407, 21);
            this.lblThongTinPhieuNhap.Name = "lblThongTinPhieuNhap";
            this.lblThongTinPhieuNhap.Size = new System.Drawing.Size(318, 29);
            this.lblThongTinPhieuNhap.TabIndex = 4;
            this.lblThongTinPhieuNhap.Text = "THÔNG TIN PHIẾU NHẬP  MÃ:";
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(1003, 774);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(49, 19);
            this.lblkThoat.TabIndex = 5;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // ThongTinPhieuNhap_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1091, 797);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.lblThongTinPhieuNhap);
            this.Controls.Add(this.lblTongGiaNhap);
            this.Controls.Add(this.dgvThongTinChiTietPhieuNhap);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinPhieuNhap_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhieuNhap";
            this.Load += new System.EventHandler(this.ThongTinPhieuNhap_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvThongTinChiTietPhieuNhap;
        private System.Windows.Forms.Label lblTongGiaNhap;
        private System.Windows.Forms.Label lblThongTinPhieuNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}