
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
            this.grThemPhieuNhap = new System.Windows.Forms.GroupBox();
            this.ccbMaDatHang = new System.Windows.Forms.ComboBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachHangNhap = new System.Windows.Forms.GroupBox();
            this.lblTongGia = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grThemPhieuNhap.SuspendLayout();
            this.grbDanhSachHangNhap.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // grThemPhieuNhap
            // 
            this.grThemPhieuNhap.Controls.Add(this.ccbMaDatHang);
            this.grThemPhieuNhap.Controls.Add(this.dtNgayNhap);
            this.grThemPhieuNhap.Controls.Add(this.rtxtGhiChu);
            this.grThemPhieuNhap.Controls.Add(this.txtMaNhap);
            this.grThemPhieuNhap.Controls.Add(this.label4);
            this.grThemPhieuNhap.Controls.Add(this.label3);
            this.grThemPhieuNhap.Controls.Add(this.label2);
            this.grThemPhieuNhap.Controls.Add(this.label1);
            this.grThemPhieuNhap.Location = new System.Drawing.Point(15, 25);
            this.grThemPhieuNhap.Margin = new System.Windows.Forms.Padding(6);
            this.grThemPhieuNhap.Name = "grThemPhieuNhap";
            this.grThemPhieuNhap.Padding = new System.Windows.Forms.Padding(6);
            this.grThemPhieuNhap.Size = new System.Drawing.Size(502, 334);
            this.grThemPhieuNhap.TabIndex = 1;
            this.grThemPhieuNhap.TabStop = false;
            this.grThemPhieuNhap.Text = "Thêm phiếu nhập";
            // 
            // ccbMaDatHang
            // 
            this.ccbMaDatHang.FormattingEnabled = true;
            this.ccbMaDatHang.Location = new System.Drawing.Point(131, 80);
            this.ccbMaDatHang.Name = "ccbMaDatHang";
            this.ccbMaDatHang.Size = new System.Drawing.Size(362, 27);
            this.ccbMaDatHang.TabIndex = 20;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(130, 113);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(362, 27);
            this.dtNgayNhap.TabIndex = 19;
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(130, 148);
            this.rtxtGhiChu.Margin = new System.Windows.Forms.Padding(4);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(362, 138);
            this.rtxtGhiChu.TabIndex = 8;
            this.rtxtGhiChu.Text = "";
            // 
            // txtMaNhap
            // 
            this.txtMaNhap.Location = new System.Drawing.Point(130, 45);
            this.txtMaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNhap.Name = "txtMaNhap";
            this.txtMaNhap.Size = new System.Drawing.Size(362, 27);
            this.txtMaNhap.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 83);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã đặt hàng:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 119);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày nhập:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã nhập:";
            // 
            // grbDanhSachHangNhap
            // 
            this.grbDanhSachHangNhap.Controls.Add(this.lblTongGia);
            this.grbDanhSachHangNhap.Controls.Add(this.label5);
            this.grbDanhSachHangNhap.Controls.Add(this.dataGridView1);
            this.grbDanhSachHangNhap.Location = new System.Drawing.Point(526, 25);
            this.grbDanhSachHangNhap.Name = "grbDanhSachHangNhap";
            this.grbDanhSachHangNhap.Size = new System.Drawing.Size(451, 334);
            this.grbDanhSachHangNhap.TabIndex = 2;
            this.grbDanhSachHangNhap.TabStop = false;
            this.grbDanhSachHangNhap.Text = "Danh sách hàng nhập";
            // 
            // lblTongGia
            // 
            this.lblTongGia.AutoSize = true;
            this.lblTongGia.Location = new System.Drawing.Point(79, 302);
            this.lblTongGia.Name = "lblTongGia";
            this.lblTongGia.Size = new System.Drawing.Size(41, 19);
            this.lblTongGia.TabIndex = 2;
            this.lblTongGia.Text = "........";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 19);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tổng giá:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(439, 250);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(753, 365);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(109, 36);
            this.btnXacNhan.TabIndex = 3;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(868, 365);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 36);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // ThemPhieuNhap_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 420);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.grbDanhSachHangNhap);
            this.Controls.Add(this.grThemPhieuNhap);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemPhieuNhap_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhieuNhap_GUI";
            this.grThemPhieuNhap.ResumeLayout(false);
            this.grThemPhieuNhap.PerformLayout();
            this.grbDanhSachHangNhap.ResumeLayout(false);
            this.grbDanhSachHangNhap.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThemPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.TextBox txtMaNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ccbMaDatHang;
        private System.Windows.Forms.GroupBox grbDanhSachHangNhap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTongGia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}