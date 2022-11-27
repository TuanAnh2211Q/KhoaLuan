
namespace QLCHTAN
{
    partial class ThemPhieuXuat_GUI
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
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtMaXuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbDanhSachHangXuat = new System.Windows.Forms.GroupBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvDanhSachHangXuat = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.grThemPhieuNhap.SuspendLayout();
            this.grbDanhSachHangXuat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // grThemPhieuNhap
            // 
            this.grThemPhieuNhap.Controls.Add(this.dtNgayXuat);
            this.grThemPhieuNhap.Controls.Add(this.txtMaXuat);
            this.grThemPhieuNhap.Controls.Add(this.label2);
            this.grThemPhieuNhap.Controls.Add(this.label1);
            this.grThemPhieuNhap.Location = new System.Drawing.Point(15, 20);
            this.grThemPhieuNhap.Margin = new System.Windows.Forms.Padding(6);
            this.grThemPhieuNhap.Name = "grThemPhieuNhap";
            this.grThemPhieuNhap.Padding = new System.Windows.Forms.Padding(6);
            this.grThemPhieuNhap.Size = new System.Drawing.Size(502, 334);
            this.grThemPhieuNhap.TabIndex = 5;
            this.grThemPhieuNhap.TabStop = false;
            this.grThemPhieuNhap.Text = "Thêm phiếu nhập";
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayXuat.Location = new System.Drawing.Point(130, 79);
            this.dtNgayXuat.Margin = new System.Windows.Forms.Padding(4);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(362, 32);
            this.dtNgayXuat.TabIndex = 19;
            // 
            // txtMaXuat
            // 
            this.txtMaXuat.Location = new System.Drawing.Point(130, 45);
            this.txtMaXuat.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.Size = new System.Drawing.Size(362, 32);
            this.txtMaXuat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xuất:";
            // 
            // grbDanhSachHangXuat
            // 
            this.grbDanhSachHangXuat.Controls.Add(this.rtxtGhiChu);
            this.grbDanhSachHangXuat.Controls.Add(this.label3);
            this.grbDanhSachHangXuat.Controls.Add(this.dgvDanhSachHangXuat);
            this.grbDanhSachHangXuat.Location = new System.Drawing.Point(526, 20);
            this.grbDanhSachHangXuat.Name = "grbDanhSachHangXuat";
            this.grbDanhSachHangXuat.Size = new System.Drawing.Size(451, 334);
            this.grbDanhSachHangXuat.TabIndex = 6;
            this.grbDanhSachHangXuat.TabStop = false;
            this.grbDanhSachHangXuat.Text = "Danh sách hàng xuất";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(88, 292);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(357, 36);
            this.rtxtGhiChu.TabIndex = 2;
            this.rtxtGhiChu.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Ghi chú:";
            // 
            // dgvDanhSachHangXuat
            // 
            this.dgvDanhSachHangXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachHangXuat.Location = new System.Drawing.Point(6, 36);
            this.dgvDanhSachHangXuat.Name = "dgvDanhSachHangXuat";
            this.dgvDanhSachHangXuat.RowHeadersWidth = 51;
            this.dgvDanhSachHangXuat.Size = new System.Drawing.Size(439, 250);
            this.dgvDanhSachHangXuat.TabIndex = 0;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(868, 360);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(109, 36);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(753, 360);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(109, 36);
            this.btnXacNhan.TabIndex = 7;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            // 
            // ThemPhieuXuat_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(992, 410);
            this.Controls.Add(this.grThemPhieuNhap);
            this.Controls.Add(this.grbDanhSachHangXuat);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXacNhan);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThemPhieuXuat_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThemPhieuXuat_GUI";
            this.grThemPhieuNhap.ResumeLayout(false);
            this.grThemPhieuNhap.PerformLayout();
            this.grbDanhSachHangXuat.ResumeLayout(false);
            this.grbDanhSachHangXuat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachHangXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grThemPhieuNhap;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.TextBox txtMaXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbDanhSachHangXuat;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvDanhSachHangXuat;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnXacNhan;
    }
}