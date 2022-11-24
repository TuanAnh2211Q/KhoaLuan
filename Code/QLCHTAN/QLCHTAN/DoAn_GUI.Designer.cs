
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoAn_GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMaDoAn = new System.Windows.Forms.TextBox();
            this.txtTenDoAn = new System.Windows.Forms.TextBox();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.dgvDoAn = new System.Windows.Forms.DataGridView();
            this.MaDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).BeginInit();
            this.grbThongTinDoAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã đồ ăn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên đồ ăn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Loại đồ ăn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ghi chú:";
            // 
            // txtMaDoAn
            // 
            this.txtMaDoAn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDoAn.Location = new System.Drawing.Point(90, 28);
            this.txtMaDoAn.Name = "txtMaDoAn";
            this.txtMaDoAn.Size = new System.Drawing.Size(180, 23);
            this.txtMaDoAn.TabIndex = 4;
            // 
            // txtTenDoAn
            // 
            this.txtTenDoAn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDoAn.Location = new System.Drawing.Point(90, 57);
            this.txtTenDoAn.Name = "txtTenDoAn";
            this.txtTenDoAn.Size = new System.Drawing.Size(180, 23);
            this.txtTenDoAn.TabIndex = 7;
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtGhiChu.Location = new System.Drawing.Point(90, 173);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(180, 48);
            this.rtxtGhiChu.TabIndex = 8;
            this.rtxtGhiChu.Text = "";
            // 
            // dgvDoAn
            // 
            this.dgvDoAn.AllowUserToAddRows = false;
            this.dgvDoAn.AllowUserToDeleteRows = false;
            this.dgvDoAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDoAn.BackgroundColor = System.Drawing.SystemColors.Info;
            this.dgvDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDoAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDoAn,
            this.Column1,
            this.LoaiDoAn,
            this.DonViBan,
            this.DonGia,
            this.GhiChu});
            this.dgvDoAn.GridColor = System.Drawing.SystemColors.Control;
            this.dgvDoAn.Location = new System.Drawing.Point(296, 61);
            this.dgvDoAn.Name = "dgvDoAn";
            this.dgvDoAn.ReadOnly = true;
            this.dgvDoAn.Size = new System.Drawing.Size(647, 269);
            this.dgvDoAn.TabIndex = 9;
            this.dgvDoAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDoAn_CellClick);
            // 
            // MaDoAn
            // 
            this.MaDoAn.DataPropertyName = "maDoAn";
            this.MaDoAn.HeaderText = "Mã đồ ăn";
            this.MaDoAn.Name = "MaDoAn";
            this.MaDoAn.ReadOnly = true;
            this.MaDoAn.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "tenDoAn";
            this.Column1.HeaderText = "Tên đồ ăn";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // LoaiDoAn
            // 
            this.LoaiDoAn.DataPropertyName = "tenLoaiDoAn";
            this.LoaiDoAn.HeaderText = "Loại đồ ăn";
            this.LoaiDoAn.Name = "LoaiDoAn";
            this.LoaiDoAn.ReadOnly = true;
            // 
            // DonViBan
            // 
            this.DonViBan.DataPropertyName = "donViBan";
            this.DonViBan.HeaderText = "Đơn vị bán";
            this.DonViBan.Name = "DonViBan";
            this.DonViBan.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "donGia";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "ghiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            this.GhiChu.ReadOnly = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(10, 264);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(62, 24);
            this.btnLamMoi.TabIndex = 10;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(219, 264);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(53, 24);
            this.btnThem.TabIndex = 11;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(153, 264);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(63, 24);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(78, 264);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(69, 24);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // ccbLoaiDoAn
            // 
            this.ccbLoaiDoAn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ccbLoaiDoAn.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ccbLoaiDoAn.FormattingEnabled = true;
            this.ccbLoaiDoAn.Location = new System.Drawing.Point(90, 86);
            this.ccbLoaiDoAn.Name = "ccbLoaiDoAn";
            this.ccbLoaiDoAn.Size = new System.Drawing.Size(180, 23);
            this.ccbLoaiDoAn.TabIndex = 15;
            // 
            // btnThanhPhanDoAn
            // 
            this.btnThanhPhanDoAn.Enabled = false;
            this.btnThanhPhanDoAn.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhPhanDoAn.Location = new System.Drawing.Point(90, 227);
            this.btnThanhPhanDoAn.Name = "btnThanhPhanDoAn";
            this.btnThanhPhanDoAn.Size = new System.Drawing.Size(182, 20);
            this.btnThanhPhanDoAn.TabIndex = 16;
            this.btnThanhPhanDoAn.Text = "Thông tin thành phần";
            this.btnThanhPhanDoAn.UseVisualStyleBackColor = true;
            this.btnThanhPhanDoAn.Click += new System.EventHandler(this.btnThanhPhanDoAn_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(90, 144);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(180, 23);
            this.txtDonGia.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Đơn giá:";
            // 
            // txtDonViBan
            // 
            this.txtDonViBan.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViBan.Location = new System.Drawing.Point(90, 115);
            this.txtDonViBan.Name = "txtDonViBan";
            this.txtDonViBan.Size = new System.Drawing.Size(180, 23);
            this.txtDonViBan.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Đơn vị bán:";
            // 
            // grbThongTinDoAn
            // 
            this.grbThongTinDoAn.Controls.Add(this.txtMaDoAn);
            this.grbThongTinDoAn.Controls.Add(this.btnThem);
            this.grbThongTinDoAn.Controls.Add(this.btnXoa);
            this.grbThongTinDoAn.Controls.Add(this.btnSua);
            this.grbThongTinDoAn.Controls.Add(this.txtDonViBan);
            this.grbThongTinDoAn.Controls.Add(this.label1);
            this.grbThongTinDoAn.Controls.Add(this.label7);
            this.grbThongTinDoAn.Controls.Add(this.btnLamMoi);
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
            this.grbThongTinDoAn.Location = new System.Drawing.Point(12, 24);
            this.grbThongTinDoAn.Name = "grbThongTinDoAn";
            this.grbThongTinDoAn.Size = new System.Drawing.Size(278, 306);
            this.grbThongTinDoAn.TabIndex = 21;
            this.grbThongTinDoAn.TabStop = false;
            this.grbThongTinDoAn.Text = "Thông tin món";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(500, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 23);
            this.label5.TabIndex = 22;
            this.label5.Text = "Danh sách món ăn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(660, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // DoAn_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 342);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbThongTinDoAn);
            this.Controls.Add(this.dgvDoAn);
            this.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "DoAn_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đồ ăn";
            this.Load += new System.EventHandler(this.DoAn_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDoAn)).EndInit();
            this.grbThongTinDoAn.ResumeLayout(false);
            this.grbThongTinDoAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}