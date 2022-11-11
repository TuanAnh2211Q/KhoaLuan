
namespace QLCHTAN
{
    partial class ThongTinKhuyenMai_GUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtMucGiam = new System.Windows.Forms.TextBox();
            this.txtTenKhuyenMai = new System.Windows.Forms.TextBox();
            this.btnDanhSachSanPhamApDung = new System.Windows.Forms.Button();
            this.dgvThongTinKhuyenMai = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.S = new System.Windows.Forms.ComboBox();
            this.maKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mucGiam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin khuyến mãi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã khuyến mãi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(44, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mức giảm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(44, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tên khuyến mãi:";
            // 
            // txtMaKhuyenMai
            // 
            this.txtMaKhuyenMai.Location = new System.Drawing.Point(167, 90);
            this.txtMaKhuyenMai.Name = "txtMaKhuyenMai";
            this.txtMaKhuyenMai.Size = new System.Drawing.Size(304, 27);
            this.txtMaKhuyenMai.TabIndex = 6;
            // 
            // txtMucGiam
            // 
            this.txtMucGiam.Location = new System.Drawing.Point(167, 197);
            this.txtMucGiam.Name = "txtMucGiam";
            this.txtMucGiam.Size = new System.Drawing.Size(304, 27);
            this.txtMucGiam.TabIndex = 8;
            // 
            // txtTenKhuyenMai
            // 
            this.txtTenKhuyenMai.Location = new System.Drawing.Point(169, 129);
            this.txtTenKhuyenMai.Name = "txtTenKhuyenMai";
            this.txtTenKhuyenMai.Size = new System.Drawing.Size(302, 27);
            this.txtTenKhuyenMai.TabIndex = 9;
            // 
            // btnDanhSachSanPhamApDung
            // 
            this.btnDanhSachSanPhamApDung.Location = new System.Drawing.Point(48, 237);
            this.btnDanhSachSanPhamApDung.Name = "btnDanhSachSanPhamApDung";
            this.btnDanhSachSanPhamApDung.Size = new System.Drawing.Size(423, 32);
            this.btnDanhSachSanPhamApDung.TabIndex = 11;
            this.btnDanhSachSanPhamApDung.Text = "Danh sách sản phẩm áp dụng";
            this.btnDanhSachSanPhamApDung.UseVisualStyleBackColor = true;
            this.btnDanhSachSanPhamApDung.Click += new System.EventHandler(this.btnDanhSachSanPhamApDung_Click);
            // 
            // dgvThongTinKhuyenMai
            // 
            this.dgvThongTinKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvThongTinKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvThongTinKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhuyenMai,
            this.tenKhuyenMai,
            this.tenLoaiKhuyenMai,
            this.mucGiam});
            this.dgvThongTinKhuyenMai.Location = new System.Drawing.Point(48, 287);
            this.dgvThongTinKhuyenMai.Name = "dgvThongTinKhuyenMai";
            this.dgvThongTinKhuyenMai.Size = new System.Drawing.Size(423, 197);
            this.dgvThongTinKhuyenMai.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(44, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Loại khuyến mãi:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(315, 498);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 21;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(234, 498);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 20;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(153, 498);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 19;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(396, 498);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 18;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // S
            // 
            this.S.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.S.FormattingEnabled = true;
            this.S.Location = new System.Drawing.Point(167, 164);
            this.S.Name = "S";
            this.S.Size = new System.Drawing.Size(304, 27);
            this.S.TabIndex = 22;
            // 
            // maKhuyenMai
            // 
            this.maKhuyenMai.HeaderText = "Mã khuyến mãi";
            this.maKhuyenMai.Name = "maKhuyenMai";
            // 
            // tenKhuyenMai
            // 
            this.tenKhuyenMai.HeaderText = "Tên khuyến mãi";
            this.tenKhuyenMai.Name = "tenKhuyenMai";
            // 
            // tenLoaiKhuyenMai
            // 
            this.tenLoaiKhuyenMai.HeaderText = "Loại khuyến mãi";
            this.tenLoaiKhuyenMai.Name = "tenLoaiKhuyenMai";
            // 
            // mucGiam
            // 
            this.mucGiam.HeaderText = "Mức giảm";
            this.mucGiam.Name = "mucGiam";
            // 
            // ThongTinKhuyenMai_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 552);
            this.Controls.Add(this.S);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvThongTinKhuyenMai);
            this.Controls.Add(this.btnDanhSachSanPhamApDung);
            this.Controls.Add(this.txtTenKhuyenMai);
            this.Controls.Add(this.txtMucGiam);
            this.Controls.Add(this.txtMaKhuyenMai);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinKhuyenMai_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinKhuyenMai_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhuyenMai)).EndInit();
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
        private System.Windows.Forms.ComboBox S;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn mucGiam;
    }
}