
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTongGiaNhap = new System.Windows.Forms.Label();
            this.dgvThongTinPhieuXuat = new System.Windows.Forms.DataGridView();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.lblThongTinPhieuXuat = new System.Windows.Forms.Label();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTongGiaNhap
            // 
            this.lblTongGiaNhap.AutoSize = true;
            this.lblTongGiaNhap.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongGiaNhap.Location = new System.Drawing.Point(7, 58);
            this.lblTongGiaNhap.Name = "lblTongGiaNhap";
            this.lblTongGiaNhap.Size = new System.Drawing.Size(82, 23);
            this.lblTongGiaNhap.TabIndex = 7;
            this.lblTongGiaNhap.Text = "Tổng giá:";
            // 
            // dgvThongTinPhieuXuat
            // 
            this.dgvThongTinPhieuXuat.AllowUserToAddRows = false;
            this.dgvThongTinPhieuXuat.AllowUserToDeleteRows = false;
            this.dgvThongTinPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinPhieuXuat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.soLuong,
            this.tongDonGia,
            this.ghiChu});
            this.dgvThongTinPhieuXuat.Location = new System.Drawing.Point(11, 84);
            this.dgvThongTinPhieuXuat.Name = "dgvThongTinPhieuXuat";
            this.dgvThongTinPhieuXuat.ReadOnly = true;
            this.dgvThongTinPhieuXuat.RowHeadersWidth = 51;
            this.dgvThongTinPhieuXuat.Size = new System.Drawing.Size(1067, 692);
            this.dgvThongTinPhieuXuat.TabIndex = 6;
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkThoat.Location = new System.Drawing.Point(1029, 779);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(49, 19);
            this.lblkThoat.TabIndex = 9;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            // 
            // lblThongTinPhieuXuat
            // 
            this.lblThongTinPhieuXuat.AutoSize = true;
            this.lblThongTinPhieuXuat.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThongTinPhieuXuat.ForeColor = System.Drawing.Color.Red;
            this.lblThongTinPhieuXuat.Location = new System.Drawing.Point(381, 26);
            this.lblThongTinPhieuXuat.Name = "lblThongTinPhieuXuat";
            this.lblThongTinPhieuXuat.Size = new System.Drawing.Size(263, 29);
            this.lblThongTinPhieuXuat.TabIndex = 8;
            this.lblThongTinPhieuXuat.Text = "THÔNG TIN PHIẾU XUẤT";
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
            // ThongTinPhieuXuat_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 819);
            this.Controls.Add(this.lblTongGiaNhap);
            this.Controls.Add(this.dgvThongTinPhieuXuat);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.lblThongTinPhieuXuat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ThongTinPhieuXuat_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinPhieuXuat_GUI";
            this.Load += new System.EventHandler(this.ThongTinPhieuXuat_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinPhieuXuat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTongGiaNhap;
        private System.Windows.Forms.DataGridView dgvThongTinPhieuXuat;
        private System.Windows.Forms.LinkLabel lblkThoat;
        private System.Windows.Forms.Label lblThongTinPhieuXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}