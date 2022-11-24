
namespace QLCHTAN
{
    partial class NuocUong_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NuocUong_GUI));
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvNuocUong = new System.Windows.Forms.DataGridView();
            this.MaNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonViBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtMaNuoc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.grbThongTinNuocUong = new System.Windows.Forms.GroupBox();
            this.txtTenNuoc = new System.Windows.Forms.TextBox();
            this.txtDonViBan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocUong)).BeginInit();
            this.grbThongTinNuocUong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(141, 155);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(61, 27);
            this.btnSua.TabIndex = 41;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(76, 155);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(57, 26);
            this.btnXoa.TabIndex = 40;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(12, 155);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(59, 26);
            this.btnThem.TabIndex = 39;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(210, 155);
            this.btnLamMoi.Margin = new System.Windows.Forms.Padding(4);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(65, 27);
            this.btnLamMoi.TabIndex = 38;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvNuocUong
            // 
            this.dgvNuocUong.AllowUserToAddRows = false;
            this.dgvNuocUong.AllowUserToDeleteRows = false;
            this.dgvNuocUong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNuocUong.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvNuocUong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuocUong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNuoc,
            this.TenNuoc,
            this.DonViBan,
            this.DonGia});
            this.dgvNuocUong.GridColor = System.Drawing.SystemColors.Control;
            this.dgvNuocUong.Location = new System.Drawing.Point(314, 42);
            this.dgvNuocUong.Margin = new System.Windows.Forms.Padding(4);
            this.dgvNuocUong.Name = "dgvNuocUong";
            this.dgvNuocUong.ReadOnly = true;
            this.dgvNuocUong.Size = new System.Drawing.Size(405, 174);
            this.dgvNuocUong.TabIndex = 37;
            this.dgvNuocUong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNuocUong_CellClick);
            // 
            // MaNuoc
            // 
            this.MaNuoc.DataPropertyName = "maNuoc";
            this.MaNuoc.HeaderText = "Mã nước";
            this.MaNuoc.Name = "MaNuoc";
            this.MaNuoc.ReadOnly = true;
            // 
            // TenNuoc
            // 
            this.TenNuoc.DataPropertyName = "tenNuoc";
            this.TenNuoc.HeaderText = "Tên nước";
            this.TenNuoc.Name = "TenNuoc";
            this.TenNuoc.ReadOnly = true;
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
            this.DonGia.DataPropertyName = "giaBanNuoc";
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(76, 124);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(199, 23);
            this.txtDonGia.TabIndex = 34;
            // 
            // txtMaNuoc
            // 
            this.txtMaNuoc.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNuoc.Location = new System.Drawing.Point(76, 27);
            this.txtMaNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaNuoc.Name = "txtMaNuoc";
            this.txtMaNuoc.Size = new System.Drawing.Size(199, 23);
            this.txtMaNuoc.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 127);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Đơn giá:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 30;
            this.label2.Text = "Đơn vị bán:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 29;
            this.label1.Text = "Mã nước:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 63);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 15);
            this.label6.TabIndex = 43;
            this.label6.Text = "Tên nước:";
            // 
            // grbThongTinNuocUong
            // 
            this.grbThongTinNuocUong.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbThongTinNuocUong.Controls.Add(this.txtTenNuoc);
            this.grbThongTinNuocUong.Controls.Add(this.btnLamMoi);
            this.grbThongTinNuocUong.Controls.Add(this.btnSua);
            this.grbThongTinNuocUong.Controls.Add(this.label1);
            this.grbThongTinNuocUong.Controls.Add(this.btnXoa);
            this.grbThongTinNuocUong.Controls.Add(this.label6);
            this.grbThongTinNuocUong.Controls.Add(this.btnThem);
            this.grbThongTinNuocUong.Controls.Add(this.label3);
            this.grbThongTinNuocUong.Controls.Add(this.txtMaNuoc);
            this.grbThongTinNuocUong.Controls.Add(this.txtDonGia);
            this.grbThongTinNuocUong.Controls.Add(this.txtDonViBan);
            this.grbThongTinNuocUong.Controls.Add(this.label2);
            this.grbThongTinNuocUong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grbThongTinNuocUong.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbThongTinNuocUong.ForeColor = System.Drawing.Color.Black;
            this.grbThongTinNuocUong.Location = new System.Drawing.Point(13, 22);
            this.grbThongTinNuocUong.Margin = new System.Windows.Forms.Padding(4);
            this.grbThongTinNuocUong.Name = "grbThongTinNuocUong";
            this.grbThongTinNuocUong.Padding = new System.Windows.Forms.Padding(4);
            this.grbThongTinNuocUong.Size = new System.Drawing.Size(295, 194);
            this.grbThongTinNuocUong.TabIndex = 44;
            this.grbThongTinNuocUong.TabStop = false;
            this.grbThongTinNuocUong.Text = "Thông tin nước uống";
            // 
            // txtTenNuoc
            // 
            this.txtTenNuoc.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNuoc.Location = new System.Drawing.Point(76, 60);
            this.txtTenNuoc.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenNuoc.Name = "txtTenNuoc";
            this.txtTenNuoc.Size = new System.Drawing.Size(199, 23);
            this.txtTenNuoc.TabIndex = 44;
            // 
            // txtDonViBan
            // 
            this.txtDonViBan.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonViBan.Location = new System.Drawing.Point(76, 92);
            this.txtDonViBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonViBan.Name = "txtDonViBan";
            this.txtDonViBan.Size = new System.Drawing.Size(199, 23);
            this.txtDonViBan.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(397, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(208, 26);
            this.label5.TabIndex = 45;
            this.label5.Text = "Danh mục nước uống";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(601, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 26);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // NuocUong_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(725, 221);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.grbThongTinNuocUong);
            this.Controls.Add(this.dgvNuocUong);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NuocUong_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nước uống";
            this.Load += new System.EventHandler(this.NuocUong_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuocUong)).EndInit();
            this.grbThongTinNuocUong.ResumeLayout(false);
            this.grbThongTinNuocUong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvNuocUong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtMaNuoc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grbThongTinNuocUong;
        private System.Windows.Forms.TextBox txtTenNuoc;
        private System.Windows.Forms.TextBox txtDonViBan;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNuoc;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonViBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
    }
}