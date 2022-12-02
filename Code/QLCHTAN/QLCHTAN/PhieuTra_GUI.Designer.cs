
namespace QLCHTAN
{
    partial class PhieuTra_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PhieuTra_GUI));
            this.label6 = new System.Windows.Forms.Label();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvPhieuDat = new System.Windows.Forms.DataGridView();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblkThongTinPhieuDat = new System.Windows.Forms.LinkLabel();
            this.dtNgayDat = new System.Windows.Forms.DateTimePicker();
            this.txtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtMaTra = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThemPhieuTra = new System.Windows.Forms.Button();
            this.btnHuyPhieuTra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cbbMaDat = new System.Windows.Forms.ComboBox();
            this.maTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDatHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(428, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(226, 26);
            this.label6.TabIndex = 19;
            this.label6.Text = "DANH SÁCH PHIẾU TRẢ";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Image = ((System.Drawing.Image)(resources.GetObject("btnLamMoi.Image")));
            this.btnLamMoi.Location = new System.Drawing.Point(707, 258);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(44, 33);
            this.btnLamMoi.TabIndex = 17;
            this.btnLamMoi.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuDat
            // 
            this.dgvPhieuDat.AllowUserToAddRows = false;
            this.dgvPhieuDat.AllowUserToDeleteRows = false;
            this.dgvPhieuDat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuDat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuDat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuDat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maTra,
            this.ngayTra,
            this.ghiChu,
            this.maDatHang,
            this.trangThai});
            this.dgvPhieuDat.Location = new System.Drawing.Point(324, 60);
            this.dgvPhieuDat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuDat.Name = "dgvPhieuDat";
            this.dgvPhieuDat.ReadOnly = true;
            this.dgvPhieuDat.Size = new System.Drawing.Size(427, 185);
            this.dgvPhieuDat.TabIndex = 14;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(573, 257);
            this.btnCapNhat.Margin = new System.Windows.Forms.Padding(2);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(129, 34);
            this.btnCapNhat.TabIndex = 18;
            this.btnCapNhat.Text = "Cập nhật phiếu trả";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbMaDat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblkThongTinPhieuDat);
            this.groupBox1.Controls.Add(this.dtNgayDat);
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.txtMaTra);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(307, 273);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu trả";
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTrangThai.Location = new System.Drawing.Point(81, 136);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(202, 15);
            this.lblTrangThai.TabIndex = 24;
            this.lblTrangThai.Text = ".................................................................";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 15);
            this.label7.TabIndex = 23;
            this.label7.Text = "Trạng thái:";
            // 
            // lblkThongTinPhieuDat
            // 
            this.lblkThongTinPhieuDat.AutoSize = true;
            this.lblkThongTinPhieuDat.Location = new System.Drawing.Point(111, 239);
            this.lblkThongTinPhieuDat.Name = "lblkThongTinPhieuDat";
            this.lblkThongTinPhieuDat.Size = new System.Drawing.Size(113, 15);
            this.lblkThongTinPhieuDat.TabIndex = 12;
            this.lblkThongTinPhieuDat.TabStop = true;
            this.lblkThongTinPhieuDat.Text = "Thông tin phiếu trả";
            // 
            // dtNgayDat
            // 
            this.dtNgayDat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayDat.Location = new System.Drawing.Point(114, 76);
            this.dtNgayDat.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayDat.Name = "dtNgayDat";
            this.dtNgayDat.Size = new System.Drawing.Size(169, 23);
            this.dtNgayDat.TabIndex = 19;
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(84, 169);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(201, 58);
            this.txtGhiChu.TabIndex = 8;
            this.txtGhiChu.Text = "";
            // 
            // txtMaTra
            // 
            this.txtMaTra.Location = new System.Drawing.Point(114, 49);
            this.txtMaTra.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaTra.Name = "txtMaTra";
            this.txtMaTra.Size = new System.Drawing.Size(169, 23);
            this.txtMaTra.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 169);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày trả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trả hàng:";
            // 
            // btnThemPhieuTra
            // 
            this.btnThemPhieuTra.Location = new System.Drawing.Point(324, 258);
            this.btnThemPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnThemPhieuTra.Name = "btnThemPhieuTra";
            this.btnThemPhieuTra.Size = new System.Drawing.Size(135, 33);
            this.btnThemPhieuTra.TabIndex = 15;
            this.btnThemPhieuTra.Text = "Thêm phiếu trả mới";
            this.btnThemPhieuTra.UseVisualStyleBackColor = true;
            // 
            // btnHuyPhieuTra
            // 
            this.btnHuyPhieuTra.Location = new System.Drawing.Point(463, 258);
            this.btnHuyPhieuTra.Margin = new System.Windows.Forms.Padding(2);
            this.btnHuyPhieuTra.Name = "btnHuyPhieuTra";
            this.btnHuyPhieuTra.Size = new System.Drawing.Size(108, 33);
            this.btnHuyPhieuTra.TabIndex = 16;
            this.btnHuyPhieuTra.Text = "Hủy phiếu trả";
            this.btnHuyPhieuTra.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Mã đặt:";
            // 
            // cbbMaDat
            // 
            this.cbbMaDat.FormattingEnabled = true;
            this.cbbMaDat.Location = new System.Drawing.Point(114, 107);
            this.cbbMaDat.Name = "cbbMaDat";
            this.cbbMaDat.Size = new System.Drawing.Size(169, 23);
            this.cbbMaDat.TabIndex = 26;
            // 
            // maTra
            // 
            this.maTra.DataPropertyName = "maTra";
            this.maTra.HeaderText = "Mã đặt hàng";
            this.maTra.Name = "maTra";
            this.maTra.ReadOnly = true;
            // 
            // ngayTra
            // 
            this.ngayTra.DataPropertyName = "ngayTra";
            this.ngayTra.HeaderText = "Ngày đặt hàng";
            this.ngayTra.Name = "ngayTra";
            this.ngayTra.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            // 
            // maDatHang
            // 
            this.maDatHang.HeaderText = "Mã đặt hàng";
            this.maDatHang.Name = "maDatHang";
            this.maDatHang.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng Thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // PhieuTra_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 302);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvPhieuDat);
            this.Controls.Add(this.btnCapNhat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThemPhieuTra);
            this.Controls.Add(this.btnHuyPhieuTra);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "PhieuTra_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuTra_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuDat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvPhieuDat;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.LinkLabel lblkThongTinPhieuDat;
        private System.Windows.Forms.DateTimePicker dtNgayDat;
        private System.Windows.Forms.RichTextBox txtGhiChu;
        private System.Windows.Forms.TextBox txtMaTra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnThemPhieuTra;
        private System.Windows.Forms.Button btnHuyPhieuTra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbbMaDat;
        private System.Windows.Forms.DataGridViewTextBoxColumn maTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDatHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
    }
}