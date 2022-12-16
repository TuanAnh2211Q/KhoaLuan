
namespace QLCHTAN
{
    partial class LoaiKhuyenMai_GUI
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
            this.txtMaLoaiKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtTenLoaiKhuyenMai = new System.Windows.Forms.TextBox();
            this.dgvLoaiKhuyenMai = new System.Windows.Forms.DataGridView();
            this.MaLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grbThongTInLoaiKhuyenMai = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhuyenMai)).BeginInit();
            this.grbThongTInLoaiKhuyenMai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại khuyến mãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại khuyến mãi:";
            // 
            // txtMaLoaiKhuyenMai
            // 
            this.txtMaLoaiKhuyenMai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiKhuyenMai.Location = new System.Drawing.Point(144, 48);
            this.txtMaLoaiKhuyenMai.Name = "txtMaLoaiKhuyenMai";
            this.txtMaLoaiKhuyenMai.Size = new System.Drawing.Size(191, 23);
            this.txtMaLoaiKhuyenMai.TabIndex = 2;
            // 
            // txtTenLoaiKhuyenMai
            // 
            this.txtTenLoaiKhuyenMai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiKhuyenMai.Location = new System.Drawing.Point(144, 77);
            this.txtTenLoaiKhuyenMai.Name = "txtTenLoaiKhuyenMai";
            this.txtTenLoaiKhuyenMai.Size = new System.Drawing.Size(191, 23);
            this.txtTenLoaiKhuyenMai.TabIndex = 3;
            // 
            // dgvLoaiKhuyenMai
            // 
            this.dgvLoaiKhuyenMai.AllowUserToAddRows = false;
            this.dgvLoaiKhuyenMai.AllowUserToDeleteRows = false;
            this.dgvLoaiKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvLoaiKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiKhuyenMai.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvLoaiKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiKhuyenMai,
            this.TenLoaiKhuyenMai});
            this.dgvLoaiKhuyenMai.Location = new System.Drawing.Point(367, 56);
            this.dgvLoaiKhuyenMai.Name = "dgvLoaiKhuyenMai";
            this.dgvLoaiKhuyenMai.ReadOnly = true;
            this.dgvLoaiKhuyenMai.Size = new System.Drawing.Size(346, 134);
            this.dgvLoaiKhuyenMai.TabIndex = 4;
            this.dgvLoaiKhuyenMai.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiKhuyenMai_CellClick);
            // 
            // MaLoaiKhuyenMai
            // 
            this.MaLoaiKhuyenMai.DataPropertyName = "maLoaiKhuyenMai";
            this.MaLoaiKhuyenMai.HeaderText = "Mã loại khuyến mãi";
            this.MaLoaiKhuyenMai.Name = "MaLoaiKhuyenMai";
            this.MaLoaiKhuyenMai.ReadOnly = true;
            // 
            // TenLoaiKhuyenMai
            // 
            this.TenLoaiKhuyenMai.DataPropertyName = "tenLoaiKhuyenMai";
            this.TenLoaiKhuyenMai.HeaderText = "Tên loại khuyến mãi";
            this.TenLoaiKhuyenMai.Name = "TenLoaiKhuyenMai";
            this.TenLoaiKhuyenMai.ReadOnly = true;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Snow;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(187, 114);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Snow;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(106, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Snow;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(25, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Snow;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLamMoi.Font = new System.Drawing.Font("Candara", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(268, 114);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // grbThongTInLoaiKhuyenMai
            // 
            this.grbThongTInLoaiKhuyenMai.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.txtTenLoaiKhuyenMai);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.btnLamMoi);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.btnSua);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.label1);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.btnXoa);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.label2);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.btnThem);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.txtMaLoaiKhuyenMai);
            this.grbThongTInLoaiKhuyenMai.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTInLoaiKhuyenMai.Location = new System.Drawing.Point(12, 20);
            this.grbThongTInLoaiKhuyenMai.Name = "grbThongTInLoaiKhuyenMai";
            this.grbThongTInLoaiKhuyenMai.Size = new System.Drawing.Size(349, 170);
            this.grbThongTInLoaiKhuyenMai.TabIndex = 19;
            this.grbThongTInLoaiKhuyenMai.TabStop = false;
            this.grbThongTInLoaiKhuyenMai.Text = "Thông tin loại khuyến mãi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(430, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(237, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "DANH SÁCH LOẠI ĐỒ ĂN";
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkThoat.Location = new System.Drawing.Point(363, 34);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(39, 15);
            this.lblkThoat.TabIndex = 21;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // LoaiKhuyenMai_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(725, 203);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grbThongTInLoaiKhuyenMai);
            this.Controls.Add(this.dgvLoaiKhuyenMai);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiKhuyenMai_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaiKhuyenMai";
            this.Load += new System.EventHandler(this.LoaiKhuyenMai_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhuyenMai)).EndInit();
            this.grbThongTInLoaiKhuyenMai.ResumeLayout(false);
            this.grbThongTInLoaiKhuyenMai.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaLoaiKhuyenMai;
        private System.Windows.Forms.TextBox txtTenLoaiKhuyenMai;
        private System.Windows.Forms.DataGridView dgvLoaiKhuyenMai;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.GroupBox grbThongTInLoaiKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiKhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiKhuyenMai;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}