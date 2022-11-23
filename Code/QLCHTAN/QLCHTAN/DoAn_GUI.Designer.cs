
namespace QLCHTAN
{
    partial class DoAn_GUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDoAn = new System.Windows.Forms.TextBox();
            this.txtTenDoAn = new System.Windows.Forms.TextBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.dgvDoAn = new System.Windows.Forms.DataGridView();
            this.MaDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.ccbLoaiDoAn = new System.Windows.Forms.ComboBox();
            this.btnThanhPhanDoAn = new System.Windows.Forms.Button();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDonViBan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.grbThongTinDoAn = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).BeginInit();
            this.grbThongTinDoAn.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đồ ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đồ ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại đồ ăn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú:";
            // 
            // txtMaDoAn
            // 
            this.txtMaDoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoAn.Location = new System.Drawing.Point(90, 37);
            this.txtMaDoAn.Name = "txtMaDoAn";
            this.txtMaDoAn.Size = new System.Drawing.Size(795, 24);
            this.txtMaDoAn.TabIndex = 4;
            // 
            // txtTenDoAn
            // 
            this.txtTenDoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoAn.Location = new System.Drawing.Point(90, 66);
            this.txtTenDoAn.Name = "txtTenDoAn";
            this.txtTenDoAn.Size = new System.Drawing.Size(795, 24);
            this.txtTenDoAn.TabIndex = 7;
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtGhiChu.Location = new System.Drawing.Point(90, 189);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(795, 84);
            this.rtxtGhiChu.TabIndex = 8;
            this.rtxtGhiChu.Text = "";
            // 
            // dgvDoAn
            // 
            this.dgvDoAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoAn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoAn,
            this.TenDoAn,
            this.LoaiDoAn,
            this.DonViBan,
            this.DonGia,
            this.GhiChu});
            this.dgvDoAn.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDoAn.Location = new System.Drawing.Point(12, 345);
            this.dgvDoAn.Name = "dgvDoAn";
            this.dgvDoAn.Size = new System.Drawing.Size(891, 265);
            this.dgvDoAn.TabIndex = 9;
            // 
            // MaDoAn
            // 
            this.MaDoAn.DataPropertyName = "maDoAn";
            this.MaDoAn.HeaderText = "Mã đồ ăn";
            this.MaDoAn.Name = "MaDoAn";
            // 
            // TenDoAn
            // 
            this.TenDoAn.DataPropertyName = "tenDoAn";
            this.TenDoAn.HeaderText = "Tên đồ ăn";
            this.TenDoAn.Name = "TenDoAn";
            // 
            // LoaiDoAn
            // 
            this.LoaiDoAn.DataPropertyName = "loaiDoAn";
            this.LoaiDoAn.HeaderText = "Loại đồ ăn";
            this.LoaiDoAn.Name = "LoaiDoAn";
            // 
            // DonViBan
            // 
            this.DonViBan.DataPropertyName = "donViBan";
            this.DonViBan.HeaderText = "Đơn vị bán";
            this.DonViBan.Name = "DonViBan";
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "donGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "ghiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(353, 616);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(133, 31);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(770, 616);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(133, 31);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(631, 616);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(133, 31);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(492, 616);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(133, 31);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // ccbLoaiDoAn
            // 
            this.ccbLoaiDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbLoaiDoAn.FormattingEnabled = true;
            this.ccbLoaiDoAn.Location = new System.Drawing.Point(90, 94);
            this.ccbLoaiDoAn.Name = "ccbLoaiDoAn";
            this.ccbLoaiDoAn.Size = new System.Drawing.Size(795, 27);
            this.ccbLoaiDoAn.TabIndex = 15;
            // 
            // btnThanhPhanDoAn
            // 
            this.btnThanhPhanDoAn.Location = new System.Drawing.Point(213, 279);
            this.btnThanhPhanDoAn.Name = "btnThanhPhanDoAn";
            this.btnThanhPhanDoAn.Size = new System.Drawing.Size(470, 36);
            this.btnThanhPhanDoAn.TabIndex = 16;
            this.btnThanhPhanDoAn.Text = "Thông tin thành phần";
            this.btnThanhPhanDoAn.UseVisualStyleBackColor = true;
            this.btnThanhPhanDoAn.Click += new System.EventHandler(this.btnThanhPhanDoAn_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(90, 157);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(795, 24);
            this.txtDonGia.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đơn giá:";
            // 
            // txtDonViBan
            // 
            this.txtDonViBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViBan.Location = new System.Drawing.Point(90, 127);
            this.txtDonViBan.Name = "txtDonViBan";
            this.txtDonViBan.Size = new System.Drawing.Size(795, 24);
            this.txtDonViBan.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(0, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 19);
            this.label7.TabIndex = 19;
            this.label7.Text = "Đơn vị bán:";
            // 
            // grbThongTinDoAn
            // 
            this.grbThongTinDoAn.Controls.Add(this.txtMaDoAn);
            this.grbThongTinDoAn.Controls.Add(this.txtDonViBan);
            this.grbThongTinDoAn.Controls.Add(this.label1);
            this.grbThongTinDoAn.Controls.Add(this.label7);
            this.grbThongTinDoAn.Controls.Add(this.label2);
            this.grbThongTinDoAn.Controls.Add(this.txtDonGia);
            this.grbThongTinDoAn.Controls.Add(this.label3);
            this.grbThongTinDoAn.Controls.Add(this.label6);
            this.grbThongTinDoAn.Controls.Add(this.label4);
            this.grbThongTinDoAn.Controls.Add(this.btnThanhPhanDoAn);
            this.grbThongTinDoAn.Controls.Add(this.txtTenDoAn);
            this.grbThongTinDoAn.Controls.Add(this.ccbLoaiDoAn);
            this.grbThongTinDoAn.Controls.Add(this.rtxtGhiChu);
            this.grbThongTinDoAn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinDoAn.Location = new System.Drawing.Point(12, 18);
            this.grbThongTinDoAn.Name = "grbThongTinDoAn";
            this.grbThongTinDoAn.Size = new System.Drawing.Size(891, 321);
            this.grbThongTinDoAn.TabIndex = 21;
            this.grbThongTinDoAn.TabStop = false;
            this.grbThongTinDoAn.Text = "Thông tin dồ ăn";
            // 
            // DoAn_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 675);
            this.Controls.Add(this.grbThongTinDoAn);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvDoAn);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DoAn_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ ăn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).EndInit();
            this.grbThongTinDoAn.ResumeLayout(false);
            this.grbThongTinDoAn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMaDoAn;
        private System.Windows.Forms.TextBox txtTenDoAn;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.DataGridView dgvDoAn;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.ComboBox ccbLoaiDoAn;
        private System.Windows.Forms.Button btnThanhPhanDoAn;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDonViBan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox grbThongTinDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}