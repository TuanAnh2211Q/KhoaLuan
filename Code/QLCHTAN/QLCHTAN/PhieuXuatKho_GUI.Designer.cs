
namespace QLCHTAN
{
    partial class PhieuXuatKho_GUI
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
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.lblkHuyPhieuXuat = new System.Windows.Forms.LinkLabel();
            this.lblkThongTinChiTiet = new System.Windows.Forms.LinkLabel();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaXuat = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.maXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayXuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblkDuyetPhieuXuat = new System.Windows.Forms.LinkLabel();
            this.lblTrangThai = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(369, 58);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(39, 15);
            this.lblkThoat.TabIndex = 11;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            // 
            // lblkHuyPhieuXuat
            // 
            this.lblkHuyPhieuXuat.AutoSize = true;
            this.lblkHuyPhieuXuat.Location = new System.Drawing.Point(226, 273);
            this.lblkHuyPhieuXuat.Name = "lblkHuyPhieuXuat";
            this.lblkHuyPhieuXuat.Size = new System.Drawing.Size(91, 15);
            this.lblkHuyPhieuXuat.TabIndex = 26;
            this.lblkHuyPhieuXuat.TabStop = true;
            this.lblkHuyPhieuXuat.Text = "Hủy phiếu xuất";
            this.lblkHuyPhieuXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkHuyPhieuXuat_LinkClicked);
            // 
            // lblkThongTinChiTiet
            // 
            this.lblkThongTinChiTiet.AutoSize = true;
            this.lblkThongTinChiTiet.Location = new System.Drawing.Point(6, 273);
            this.lblkThongTinChiTiet.Name = "lblkThongTinChiTiet";
            this.lblkThongTinChiTiet.Size = new System.Drawing.Size(105, 15);
            this.lblkThongTinChiTiet.TabIndex = 24;
            this.lblkThongTinChiTiet.TabStop = true;
            this.lblkThongTinChiTiet.Text = "Thông tin chi tiết ";
            this.lblkThongTinChiTiet.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThongTinChiTiet_LinkClicked);
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Enabled = false;
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(82, 157);
            this.dtNgayNhap.Margin = new System.Windows.Forms.Padding(2);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(235, 23);
            this.dtNgayNhap.TabIndex = 19;
            // 
            // txtMaXuat
            // 
            this.txtMaXuat.Enabled = false;
            this.txtMaXuat.Location = new System.Drawing.Point(82, 130);
            this.txtMaXuat.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.Size = new System.Drawing.Size(235, 23);
            this.txtMaXuat.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.dgvPhieuXuat);
            this.panel1.Location = new System.Drawing.Point(370, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 365);
            this.panel1.TabIndex = 9;
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.AllowUserToAddRows = false;
            this.dgvPhieuXuat.AllowUserToDeleteRows = false;
            this.dgvPhieuXuat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhieuXuat.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhieuXuat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maXuat,
            this.ngayXuat,
            this.trangThai});
            this.dgvPhieuXuat.Location = new System.Drawing.Point(2, 2);
            this.dgvPhieuXuat.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.ReadOnly = true;
            this.dgvPhieuXuat.Size = new System.Drawing.Size(750, 363);
            this.dgvPhieuXuat.TabIndex = 1;
            this.dgvPhieuXuat.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhieuXuat_CellClick);
            // 
            // maXuat
            // 
            this.maXuat.DataPropertyName = "maXuat";
            this.maXuat.HeaderText = "Mã xuất";
            this.maXuat.Name = "maXuat";
            this.maXuat.ReadOnly = true;
            // 
            // ngayXuat
            // 
            this.ngayXuat.DataPropertyName = "ngayXuat";
            this.ngayXuat.HeaderText = "Ngày xuất";
            this.ngayXuat.Name = "ngayXuat";
            this.ngayXuat.ReadOnly = true;
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            this.trangThai.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 132);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xuất:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(618, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(238, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "DANH SÁCH PHIẾU XUẤT";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lblkDuyetPhieuXuat);
            this.groupBox1.Controls.Add(this.lblTrangThai);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblkHuyPhieuXuat);
            this.groupBox1.Controls.Add(this.lblkThongTinChiTiet);
            this.groupBox1.Controls.Add(this.dtNgayNhap);
            this.groupBox1.Controls.Add(this.txtMaXuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 411);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // lblkDuyetPhieuXuat
            // 
            this.lblkDuyetPhieuXuat.AutoSize = true;
            this.lblkDuyetPhieuXuat.Location = new System.Drawing.Point(117, 273);
            this.lblkDuyetPhieuXuat.Name = "lblkDuyetPhieuXuat";
            this.lblkDuyetPhieuXuat.Size = new System.Drawing.Size(102, 15);
            this.lblkDuyetPhieuXuat.TabIndex = 29;
            this.lblkDuyetPhieuXuat.TabStop = true;
            this.lblkDuyetPhieuXuat.Text = "Duyệt phiếu xuất";
            this.lblkDuyetPhieuXuat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkDuyetPhieuXuat_LinkClicked);
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTrangThai.AutoSize = true;
            this.lblTrangThai.ForeColor = System.Drawing.Color.Red;
            this.lblTrangThai.Location = new System.Drawing.Point(76, 194);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(121, 15);
            this.lblTrangThai.TabIndex = 28;
            this.lblTrangThai.Text = "......................................";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Trạng thái:";
            // 
            // PhieuXuatKho_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1165, 470);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhieuXuatKho_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuXuatKho";
            this.Load += new System.EventHandler(this.PhieuXuatKho_GUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblkThoat;
        private System.Windows.Forms.LinkLabel lblkHuyPhieuXuat;
        private System.Windows.Forms.LinkLabel lblkThongTinChiTiet;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox txtMaXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTrangThai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn maXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuat;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.LinkLabel lblkDuyetPhieuXuat;
    }
}