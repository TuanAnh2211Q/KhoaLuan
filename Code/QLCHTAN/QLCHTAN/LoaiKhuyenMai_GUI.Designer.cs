
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaLoaiKhuyenMai = new System.Windows.Forms.TextBox();
            this.txtTenLoaiKhuyenMai = new System.Windows.Forms.TextBox();
            this.dgvLoaiKhuyenMai = new System.Windows.Forms.DataGridView();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.grbThongTInLoaiKhuyenMai = new System.Windows.Forms.GroupBox();
            this.MaLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiKhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhuyenMai)).BeginInit();
            this.grbThongTInLoaiKhuyenMai.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã loại khuyến mãi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên loại khuyến mãi:";
            // 
            // txtMaLoaiKhuyenMai
            // 
            this.txtMaLoaiKhuyenMai.Location = new System.Drawing.Point(172, 76);
            this.txtMaLoaiKhuyenMai.Name = "txtMaLoaiKhuyenMai";
            this.txtMaLoaiKhuyenMai.Size = new System.Drawing.Size(191, 27);
            this.txtMaLoaiKhuyenMai.TabIndex = 2;
            // 
            // txtTenLoaiKhuyenMai
            // 
            this.txtTenLoaiKhuyenMai.Location = new System.Drawing.Point(172, 120);
            this.txtTenLoaiKhuyenMai.Name = "txtTenLoaiKhuyenMai";
            this.txtTenLoaiKhuyenMai.Size = new System.Drawing.Size(191, 27);
            this.txtTenLoaiKhuyenMai.TabIndex = 3;
            // 
            // dgvLoaiKhuyenMai
            // 
            this.dgvLoaiKhuyenMai.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiKhuyenMai.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLoaiKhuyenMai.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiKhuyenMai,
            this.TenLoaiKhuyenMai});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLoaiKhuyenMai.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiKhuyenMai.Location = new System.Drawing.Point(387, 21);
            this.dgvLoaiKhuyenMai.Name = "dgvLoaiKhuyenMai";
            this.dgvLoaiKhuyenMai.Size = new System.Drawing.Size(346, 185);
            this.dgvLoaiKhuyenMai.TabIndex = 4;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(468, 218);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 17;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(549, 218);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(630, 218);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(387, 218);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 14;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            // 
            // grbThongTInLoaiKhuyenMai
            // 
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.txtTenLoaiKhuyenMai);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.label1);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.label2);
            this.grbThongTInLoaiKhuyenMai.Controls.Add(this.txtMaLoaiKhuyenMai);
            this.grbThongTInLoaiKhuyenMai.Location = new System.Drawing.Point(12, 12);
            this.grbThongTInLoaiKhuyenMai.Name = "grbThongTInLoaiKhuyenMai";
            this.grbThongTInLoaiKhuyenMai.Size = new System.Drawing.Size(369, 237);
            this.grbThongTInLoaiKhuyenMai.TabIndex = 19;
            this.grbThongTInLoaiKhuyenMai.TabStop = false;
            this.grbThongTInLoaiKhuyenMai.Text = "Thông tin loại khuyến mãi";
            // 
            // MaLoaiKhuyenMai
            // 
            this.MaLoaiKhuyenMai.DataPropertyName = "maLoaiKhuyenMai";
            this.MaLoaiKhuyenMai.HeaderText = "Mã loại khuyến mãi";
            this.MaLoaiKhuyenMai.Name = "MaLoaiKhuyenMai";
            // 
            // TenLoaiKhuyenMai
            // 
            this.TenLoaiKhuyenMai.DataPropertyName = "tenLoaiKhuyenMai";
            this.TenLoaiKhuyenMai.HeaderText = "Tên loại khuyến mãi";
            this.TenLoaiKhuyenMai.Name = "TenLoaiKhuyenMai";
            // 
            // LoaiKhuyenMai_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 272);
            this.Controls.Add(this.grbThongTInLoaiKhuyenMai);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvLoaiKhuyenMai);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoaiKhuyenMai_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoaiKhuyenMai";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiKhuyenMai)).EndInit();
            this.grbThongTInLoaiKhuyenMai.ResumeLayout(false);
            this.grbThongTInLoaiKhuyenMai.PerformLayout();
            this.ResumeLayout(false);

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
    }
}