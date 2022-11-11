
namespace QLCHTAN
{
    partial class DanhSachSanPhamKhuyenMai_GUI
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
            this.label = new System.Windows.Forms.Label();
            this.txtNgayBatDau = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.txtNgayKetThuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTenSanPham = new System.Windows.Forms.TextBox();
            this.dgvSanPhamKhuyenMai = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.lblTenKhuyenMai = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MaSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayBatDau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayKetThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GhiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamKhuyenMai)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh sách sản phẩm áp dụng khuyến mãi";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(14, 24);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(80, 19);
            this.label.TabIndex = 9;
            this.label.Text = "Sản phẩm:";
            // 
            // txtNgayBatDau
            // 
            this.txtNgayBatDau.Location = new System.Drawing.Point(137, 57);
            this.txtNgayBatDau.Name = "txtNgayBatDau";
            this.txtNgayBatDau.Size = new System.Drawing.Size(896, 27);
            this.txtNgayBatDau.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 19);
            this.label8.TabIndex = 28;
            this.label8.Text = "Ngày bắt đầu:";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(137, 130);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(896, 77);
            this.rtxtGhiChu.TabIndex = 27;
            this.rtxtGhiChu.Text = "";
            // 
            // txtNgayKetThuc
            // 
            this.txtNgayKetThuc.Location = new System.Drawing.Point(137, 97);
            this.txtNgayKetThuc.Name = "txtNgayKetThuc";
            this.txtNgayKetThuc.Size = new System.Drawing.Size(896, 27);
            this.txtNgayKetThuc.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 19);
            this.label4.TabIndex = 25;
            this.label4.Text = "Ngày kết thúc:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 19);
            this.label5.TabIndex = 24;
            this.label5.Text = "Ghi chú:";
            // 
            // txtTenSanPham
            // 
            this.txtTenSanPham.Location = new System.Drawing.Point(137, 21);
            this.txtTenSanPham.Name = "txtTenSanPham";
            this.txtTenSanPham.Size = new System.Drawing.Size(896, 27);
            this.txtTenSanPham.TabIndex = 30;
            // 
            // dgvSanPhamKhuyenMai
            // 
            this.dgvSanPhamKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSanPhamKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSanPhamKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPhamKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSanPham,
            this.NgayBatDau,
            this.NgayKetThuc,
            this.GhiChu});
            this.dgvSanPhamKhuyenMai.Location = new System.Drawing.Point(12, 309);
            this.dgvSanPhamKhuyenMai.Name = "dgvSanPhamKhuyenMai";
            this.dgvSanPhamKhuyenMai.Size = new System.Drawing.Size(1047, 269);
            this.dgvSanPhamKhuyenMai.TabIndex = 31;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(906, 584);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(825, 584);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(744, 584);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(987, 584);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 32;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // lblTenKhuyenMai
            // 
            this.lblTenKhuyenMai.AutoSize = true;
            this.lblTenKhuyenMai.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenKhuyenMai.Location = new System.Drawing.Point(517, 24);
            this.lblTenKhuyenMai.Name = "lblTenKhuyenMai";
            this.lblTenKhuyenMai.Size = new System.Drawing.Size(50, 33);
            this.lblTenKhuyenMai.TabIndex = 36;
            this.lblTenKhuyenMai.Text = ".....";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rtxtGhiChu);
            this.panel1.Controls.Add(this.label);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtNgayKetThuc);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtNgayBatDau);
            this.panel1.Controls.Add(this.txtTenSanPham);
            this.panel1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1047, 223);
            this.panel1.TabIndex = 37;
            // 
            // MaSanPham
            // 
            this.MaSanPham.DataPropertyName = "maSanPham";
            this.MaSanPham.HeaderText = "Mã sản phẩm";
            this.MaSanPham.Name = "MaSanPham";
            // 
            // NgayBatDau
            // 
            this.NgayBatDau.DataPropertyName = "ngayBatDau";
            this.NgayBatDau.HeaderText = "Ngày bắt đầu";
            this.NgayBatDau.Name = "NgayBatDau";
            // 
            // NgayKetThuc
            // 
            this.NgayKetThuc.DataPropertyName = "ngayKetThuc";
            this.NgayKetThuc.HeaderText = "Ngày kết thúc";
            this.NgayKetThuc.Name = "NgayKetThuc";
            // 
            // GhiChu
            // 
            this.GhiChu.DataPropertyName = "ghiChu";
            this.GhiChu.HeaderText = "Ghi chú";
            this.GhiChu.Name = "GhiChu";
            // 
            // DanhSachSanPhamKhuyenMai_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 627);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTenKhuyenMai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvSanPhamKhuyenMai);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhSachSanPhamKhuyenMai_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DanhSachKhuyenMai_GUI";
            this.Load += new System.EventHandler(this.DanhSachKhuyenMai_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPhamKhuyenMai)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtNgayBatDau;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.TextBox txtNgayKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTenSanPham;
        private System.Windows.Forms.DataGridView dgvSanPhamKhuyenMai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Label lblTenKhuyenMai;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayBatDau;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayKetThuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn GhiChu;
    }
}