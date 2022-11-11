
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
            this.grbDanhSachHangXuat = new System.Windows.Forms.GroupBox();
            this.dgvThongTinHangXuat = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.grbThongTinphieuNhap = new System.Windows.Forms.GroupBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaXuat = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbDanhSachHangXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHangXuat)).BeginInit();
            this.grbThongTinphieuNhap.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDanhSachHangXuat
            // 
            this.grbDanhSachHangXuat.Controls.Add(this.dgvThongTinHangXuat);
            this.grbDanhSachHangXuat.Location = new System.Drawing.Point(13, 149);
            this.grbDanhSachHangXuat.Name = "grbDanhSachHangXuat";
            this.grbDanhSachHangXuat.Size = new System.Drawing.Size(622, 313);
            this.grbDanhSachHangXuat.TabIndex = 5;
            this.grbDanhSachHangXuat.TabStop = false;
            this.grbDanhSachHangXuat.Text = "Danh sách hàng nhập";
            // 
            // dgvThongTinHangXuat
            // 
            this.dgvThongTinHangXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinHangXuat.Location = new System.Drawing.Point(12, 26);
            this.dgvThongTinHangXuat.Name = "dgvThongTinHangXuat";
            this.dgvThongTinHangXuat.Size = new System.Drawing.Size(583, 247);
            this.dgvThongTinHangXuat.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(539, 468);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(96, 41);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(364, 468);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(169, 41);
            this.btnCapNhat.TabIndex = 6;
            this.btnCapNhat.Text = "Cập nhật phiếu xuất";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // grbThongTinphieuNhap
            // 
            this.grbThongTinphieuNhap.Controls.Add(this.rtxtGhiChu);
            this.grbThongTinphieuNhap.Controls.Add(this.txtMaXuat);
            this.grbThongTinphieuNhap.Controls.Add(this.label1);
            this.grbThongTinphieuNhap.Controls.Add(this.label3);
            this.grbThongTinphieuNhap.Location = new System.Drawing.Point(13, 13);
            this.grbThongTinphieuNhap.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTinphieuNhap.Name = "grbThongTinphieuNhap";
            this.grbThongTinphieuNhap.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTinphieuNhap.Size = new System.Drawing.Size(622, 129);
            this.grbThongTinphieuNhap.TabIndex = 4;
            this.grbThongTinphieuNhap.TabStop = false;
            this.grbThongTinphieuNhap.Text = "Thông tin phiếu nhập";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(119, 75);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(476, 47);
            this.rtxtGhiChu.TabIndex = 25;
            this.rtxtGhiChu.Text = "";
            // 
            // txtMaXuat
            // 
            this.txtMaXuat.Location = new System.Drawing.Point(119, 42);
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.Size = new System.Drawing.Size(476, 27);
            this.txtMaXuat.TabIndex = 24;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "Ghi chú:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ThongTinPhieuXuat_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 525);
            this.Controls.Add(this.grbThongTinphieuNhap);
            this.Controls.Add(this.grbDanhSachHangXuat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnCapNhat);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinPhieuXuat_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhieuXuat_GUI";
            this.grbDanhSachHangXuat.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinHangXuat)).EndInit();
            this.grbThongTinphieuNhap.ResumeLayout(false);
            this.grbThongTinphieuNhap.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbDanhSachHangXuat;
        private System.Windows.Forms.DataGridView dgvThongTinHangXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox grbThongTinphieuNhap;
        private System.Windows.Forms.TextBox txtMaXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
    }
}