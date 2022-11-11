
namespace QLCHTAN
{
    partial class ThongTinMatHang_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbThongTinMatHang = new System.Windows.Forms.GroupBox();
            this.dtpHSD = new System.Windows.Forms.DateTimePicker();
            this.dtpNXS = new System.Windows.Forms.DateTimePicker();
            this.ccbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.txtTenHang = new System.Windows.Forms.TextBox();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.dgvMatHang = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.maHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NSX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbThongTinMatHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hàng hóa trong kho ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Đơn giá:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 294);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Hạn sử dụng:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày sản xuất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn vị:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Nhà cung cấp:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 69);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên hàng:";
            // 
            // grbThongTinMatHang
            // 
            this.grbThongTinMatHang.Controls.Add(this.dtpHSD);
            this.grbThongTinMatHang.Controls.Add(this.dtpNXS);
            this.grbThongTinMatHang.Controls.Add(this.ccbNhaCungCap);
            this.grbThongTinMatHang.Controls.Add(this.rtxtGhiChu);
            this.grbThongTinMatHang.Controls.Add(this.txtDonGia);
            this.grbThongTinMatHang.Controls.Add(this.txtDonVi);
            this.grbThongTinMatHang.Controls.Add(this.txtTenHang);
            this.grbThongTinMatHang.Controls.Add(this.txtMaHang);
            this.grbThongTinMatHang.Controls.Add(this.label2);
            this.grbThongTinMatHang.Controls.Add(this.label4);
            this.grbThongTinMatHang.Controls.Add(this.label5);
            this.grbThongTinMatHang.Controls.Add(this.label3);
            this.grbThongTinMatHang.Controls.Add(this.label6);
            this.grbThongTinMatHang.Controls.Add(this.label7);
            this.grbThongTinMatHang.Controls.Add(this.label8);
            this.grbThongTinMatHang.Controls.Add(this.label9);
            this.grbThongTinMatHang.Location = new System.Drawing.Point(12, 72);
            this.grbThongTinMatHang.Name = "grbThongTinMatHang";
            this.grbThongTinMatHang.Size = new System.Drawing.Size(336, 430);
            this.grbThongTinMatHang.TabIndex = 9;
            this.grbThongTinMatHang.TabStop = false;
            this.grbThongTinMatHang.Text = "Thông tin mặt hàng";
            // 
            // dtpHSD
            // 
            this.dtpHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpHSD.Location = new System.Drawing.Point(122, 208);
            this.dtpHSD.Name = "dtpHSD";
            this.dtpHSD.Size = new System.Drawing.Size(208, 27);
            this.dtpHSD.TabIndex = 19;
            // 
            // dtpNXS
            // 
            this.dtpNXS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNXS.Location = new System.Drawing.Point(122, 170);
            this.dtpNXS.Name = "dtpNXS";
            this.dtpNXS.Size = new System.Drawing.Size(208, 27);
            this.dtpNXS.TabIndex = 18;
            // 
            // ccbNhaCungCap
            // 
            this.ccbNhaCungCap.FormattingEnabled = true;
            this.ccbNhaCungCap.Location = new System.Drawing.Point(117, 104);
            this.ccbNhaCungCap.Name = "ccbNhaCungCap";
            this.ccbNhaCungCap.Size = new System.Drawing.Size(213, 27);
            this.ccbNhaCungCap.TabIndex = 17;
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(76, 291);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(254, 133);
            this.rtxtGhiChu.TabIndex = 16;
            this.rtxtGhiChu.Text = "";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(85, 247);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(245, 27);
            this.txtDonGia.TabIndex = 15;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Location = new System.Drawing.Point(85, 141);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(245, 27);
            this.txtDonVi.TabIndex = 12;
            // 
            // txtTenHang
            // 
            this.txtTenHang.Location = new System.Drawing.Point(85, 66);
            this.txtTenHang.Name = "txtTenHang";
            this.txtTenHang.Size = new System.Drawing.Size(245, 27);
            this.txtTenHang.TabIndex = 10;
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(85, 30);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.Size = new System.Drawing.Size(245, 27);
            this.txtMaHang.TabIndex = 9;
            // 
            // dgvMatHang
            // 
            this.dgvMatHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvMatHang.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvMatHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maHang,
            this.tenHang,
            this.tenNCC,
            this.donVi,
            this.NSX,
            this.HSD,
            this.donGia,
            this.ghiChu});
            this.dgvMatHang.Location = new System.Drawing.Point(354, 85);
            this.dgvMatHang.Name = "dgvMatHang";
            this.dgvMatHang.Size = new System.Drawing.Size(845, 367);
            this.dgvMatHang.TabIndex = 10;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(1043, 465);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 45;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(962, 465);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(881, 465);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(1124, 465);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 42;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // maHang
            // 
            this.maHang.HeaderText = "Mã hàng";
            this.maHang.Name = "maHang";
            // 
            // tenHang
            // 
            this.tenHang.HeaderText = "Tên hàng";
            this.tenHang.Name = "tenHang";
            // 
            // tenNCC
            // 
            this.tenNCC.HeaderText = "Nhà cung cấp";
            this.tenNCC.Name = "tenNCC";
            // 
            // donVi
            // 
            this.donVi.HeaderText = "Đơn vị";
            this.donVi.Name = "donVi";
            // 
            // NSX
            // 
            this.NSX.HeaderText = "NSX";
            this.NSX.Name = "NSX";
            // 
            // HSD
            // 
            this.HSD.HeaderText = "HSD";
            this.HSD.Name = "HSD";
            // 
            // donGia
            // 
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            // 
            // ghiChu
            // 
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            // 
            // ThongTinMatHang_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 529);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvMatHang);
            this.Controls.Add(this.grbThongTinMatHang);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinMatHang_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinMatHang_GUI";
            this.grbThongTinMatHang.ResumeLayout(false);
            this.grbThongTinMatHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatHang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grbThongTinMatHang;
        private System.Windows.Forms.DateTimePicker dtpHSD;
        private System.Windows.Forms.DateTimePicker dtpNXS;
        private System.Windows.Forms.ComboBox ccbNhaCungCap;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TextBox txtTenHang;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.DataGridView dgvMatHang;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridViewTextBoxColumn maHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn donVi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}