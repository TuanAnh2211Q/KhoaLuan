
namespace QLCHTAN
{
    partial class KhuyenMai_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KhuyenMai_GUI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtMucGiam = new System.Windows.Forms.TextBox();
            this.txtTenKhuyenMai = new System.Windows.Forms.TextBox();
            this.btnDanhSachSanPhamApDung = new System.Windows.Forms.Button();
            this.dgvThongTinKhuyenMai = new System.Windows.Forms.DataGridView();
            this.maKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.cbbLoaiKhuyenMai = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhuyenMai)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(514, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách khuyến mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khuyến mãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 118);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mức giảm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(2, 64);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khuyến mãi:";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(98, 31);
            this.txtMaKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(237, 23);
            this.txtMaKhuyenMai.TabIndex = 6;
            this.txtMaKhuyenMai.TextChanged += new System.EventHandler(this.txtMaKhuyenMai_TextChanged);
            // 
            // txtMucGiam
            // 
            this.txtMucGiam.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMucGiam.Location = new System.Drawing.Point(98, 116);
            this.txtMucGiam.Margin = new System.Windows.Forms.Padding(2);
            this.txtMucGiam.Name = "txtMucGiam";
            this.txtMucGiam.Size = new System.Drawing.Size(237, 23);
            this.txtMucGiam.TabIndex = 8;
            this.txtMucGiam.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMucGiam_KeyPress);
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(98, 62);
            this.txtTenKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(236, 23);
            this.txtTenKhuyenMai.TabIndex = 9;
            // 
            // btnDanhSachSanPhamApDung
            // 
            this.btnDanhSachSanPhamApDung.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDanhSachSanPhamApDung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDanhSachSanPhamApDung.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDanhSachSanPhamApDung.Location = new System.Drawing.Point(5, 135);
            this.btnDanhSachSanPhamApDung.Margin = new System.Windows.Forms.Padding(2);
            this.btnDanhSachSanPhamApDung.Name = "btnDanhSachSanPhamApDung";
            this.btnDanhSachSanPhamApDung.Size = new System.Drawing.Size(89, 51);
            this.btnDanhSachSanPhamApDung.TabIndex = 11;
            this.btnDanhSachSanPhamApDung.Text = "Danh sách sản phẩm áp dụng";
            this.btnDanhSachSanPhamApDung.UseVisualStyleBackColor = false;
            this.btnDanhSachSanPhamApDung.Click += new System.EventHandler(this.btnDanhSachSanPhamApDung_Click);
            // 
            // dgvThongTinKhuyenMai
            // 
            this.dgvThongTinKhuyenMai.AllowUserToAddRows = false;
            this.dgvThongTinKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvThongTinKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThongTinKhuyenMai.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvThongTinKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhuyenMai,
            this.tenKhuyenMai,
            this.maLoaiKhuyenMai,
            this.mucGiam});
            this.dgvThongTinKhuyenMai.Location = new System.Drawing.Point(368, 61);
            this.dgvThongTinKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.dgvThongTinKhuyenMai.Name = "dgvThongTinKhuyenMai";
            this.dgvThongTinKhuyenMai.ReadOnly = true;
            this.dgvThongTinKhuyenMai.Size = new System.Drawing.Size(590, 156);
            this.dgvThongTinKhuyenMai.TabIndex = 12;
            this.dgvThongTinKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThongTinKhuyenMai_CellClick);
            // 
            // maKhuyenMai
            // 
            this.maKhuyenMai.DataPropertyName = "maKhuyenMai";
            this.maKhuyenMai.HeaderText = "Mã khuyến mãi";
            this.maKhuyenMai.Name = "maKhuyenMai";
            this.maKhuyenMai.ReadOnly = true;
            // 
            // tenKhuyenMai
            // 
            this.tenKhuyenMai.DataPropertyName = "tenKhuyenMai";
            this.tenKhuyenMai.HeaderText = "Tên khuyến mãi";
            this.tenKhuyenMai.Name = "tenKhuyenMai";
            this.tenKhuyenMai.ReadOnly = true;
            // 
            // maLoaiKhuyenMai
            // 
            this.maLoaiKhuyenMai.DataPropertyName = "maLoaiKhuyenMai";
            this.maLoaiKhuyenMai.HeaderText = "Loại khuyến mãi";
            this.maLoaiKhuyenMai.Name = "maLoaiKhuyenMai";
            this.maLoaiKhuyenMai.ReadOnly = true;
            // 
            // mucGiam
            // 
            this.mucGiam.DataPropertyName = "mucGiam";
            this.mucGiam.HeaderText = "Mức giảm";
            this.mucGiam.Name = "mucGiam";
            this.mucGiam.ReadOnly = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(2, 92);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Loại khuyến mãi:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.White;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(208, 162);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(55, 24);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.White;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(162, 162);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(42, 24);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.White;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(98, 162);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(60, 24);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.White;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(267, 162);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(2);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(68, 24);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // cbbLoaiKhuyenMai
            // 
            this.cbbLoaiKhuyenMai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLoaiKhuyenMai.FormattingEnabled = true;
            this.cbbLoaiKhuyenMai.Location = new System.Drawing.Point(98, 89);
            this.cbbLoaiKhuyenMai.Margin = new System.Windows.Forms.Padding(2);
            this.cbbLoaiKhuyenMai.Name = "cbbLoaiKhuyenMai";
            this.cbbLoaiKhuyenMai.Size = new System.Drawing.Size(237, 23);
            this.cbbLoaiKhuyenMai.TabIndex = 22;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(781, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDanhSachSanPhamApDung);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.cbbLoaiKhuyenMai);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnLamMoi);
            this.groupBox1.Controls.Add(this.txtMaKhuyenMai);
            this.groupBox1.Controls.Add(this.txtMucGiam);
            this.groupBox1.Controls.Add(this.txtTenKhuyenMai);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 205);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khuyến mãi";
            // 
            // KhuyenMai_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(969, 228);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvThongTinKhuyenMai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "KhuyenMai_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinKhuyenMai_GUI";
            this.Load += new System.EventHandler(this.KhuyenMai_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhuyenMai)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaKhuyenMai;
        private System.Windows.Forms.TextBox txtMucGiam;
        private System.Windows.Forms.TextBox txtTenKhuyenMai;
        private System.Windows.Forms.Button btnDanhSachSanPhamApDung;
        private System.Windows.Forms.DataGridView dgvThongTinKhuyenMai;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.ComboBox cbbLoaiKhuyenMai;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucGiam;
    }
}