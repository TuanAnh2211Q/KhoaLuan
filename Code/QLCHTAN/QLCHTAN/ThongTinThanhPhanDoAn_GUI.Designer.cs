﻿
namespace QLCHTAN
{
    partial class ThongTinThanhPhanDoAn_GUI
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
            this.lblTenMonAn = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.txtDinhLuong = new System.Windows.Forms.TextBox();
            this.cbbTenThanhPhan = new System.Windows.Forms.ComboBox();
            this.dgvThanhPhanMon = new System.Windows.Forms.DataGridView();
            this.maThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenThanhPhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dinhLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPhanMon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(135, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin thành phần món ăn ";
            // 
            // lblTenMonAn
            // 
            this.lblTenMonAn.AutoSize = true;
            this.lblTenMonAn.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenMonAn.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblTenMonAn.Location = new System.Drawing.Point(379, 19);
            this.lblTenMonAn.Name = "lblTenMonAn";
            this.lblTenMonAn.Size = new System.Drawing.Size(59, 23);
            this.lblTenMonAn.TabIndex = 1;
            this.lblTenMonAn.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên thành phần:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Định lượng:";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Transparent;
            this.btnSua.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(172, 131);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(68, 31);
            this.btnSua.TabIndex = 39;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Transparent;
            this.btnXoa.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(100, 131);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(66, 31);
            this.btnXoa.TabIndex = 38;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Transparent;
            this.btnThem.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(22, 131);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(72, 31);
            this.btnThem.TabIndex = 37;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.Color.Transparent;
            this.btnLamMoi.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(246, 131);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 36;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // txtDinhLuong
            // 
            this.txtDinhLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDinhLuong.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDinhLuong.Location = new System.Drawing.Point(139, 88);
            this.txtDinhLuong.Name = "txtDinhLuong";
            this.txtDinhLuong.Size = new System.Drawing.Size(182, 23);
            this.txtDinhLuong.TabIndex = 41;
            // 
            // cbbTenThanhPhan
            // 
            this.cbbTenThanhPhan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenThanhPhan.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenThanhPhan.FormattingEnabled = true;
            this.cbbTenThanhPhan.Location = new System.Drawing.Point(139, 52);
            this.cbbTenThanhPhan.Name = "cbbTenThanhPhan";
            this.cbbTenThanhPhan.Size = new System.Drawing.Size(182, 23);
            this.cbbTenThanhPhan.TabIndex = 42;
            // 
            // dgvThanhPhanMon
            // 
            this.dgvThanhPhanMon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvThanhPhanMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThanhPhanMon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maThanhPhan,
            this.tenThanhPhan,
            this.dinhLuong,
            this.maDoAn});
            this.dgvThanhPhanMon.Location = new System.Drawing.Point(327, 52);
            this.dgvThanhPhanMon.Name = "dgvThanhPhanMon";
            this.dgvThanhPhanMon.Size = new System.Drawing.Size(290, 110);
            this.dgvThanhPhanMon.TabIndex = 43;
            this.dgvThanhPhanMon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvThanhPhanMon_CellClick);
            // 
            // maThanhPhan
            // 
            this.maThanhPhan.DataPropertyName = "maThanhPhan";
            this.maThanhPhan.HeaderText = "Mã thành phần";
            this.maThanhPhan.Name = "maThanhPhan";
            this.maThanhPhan.Visible = false;
            // 
            // tenThanhPhan
            // 
            this.tenThanhPhan.DataPropertyName = "tenThanhPhan";
            this.tenThanhPhan.HeaderText = "Tên thành phần";
            this.tenThanhPhan.Name = "tenThanhPhan";
            // 
            // dinhLuong
            // 
            this.dinhLuong.DataPropertyName = "dinhLuong";
            this.dinhLuong.HeaderText = "Định lượng";
            this.dinhLuong.Name = "dinhLuong";
            // 
            // maDoAn
            // 
            this.maDoAn.DataPropertyName = "maDoAn";
            this.maDoAn.HeaderText = "Mã đồ ăn";
            this.maDoAn.Name = "maDoAn";
            this.maDoAn.Visible = false;
            // 
            // ThongTinThanhPhanDoAn_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(629, 166);
            this.Controls.Add(this.dgvThanhPhanMon);
            this.Controls.Add(this.cbbTenThanhPhan);
            this.Controls.Add(this.txtDinhLuong);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTenMonAn);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ThongTinThanhPhanDoAn_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ThongTinThanhPhanDoAn_GUI";
            this.Load += new System.EventHandler(this.ThongTinThanhPhanDoAn_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvThanhPhanMon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenMonAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.TextBox txtDinhLuong;
        private System.Windows.Forms.ComboBox cbbTenThanhPhan;
        private System.Windows.Forms.DataGridView dgvThanhPhanMon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenThanhPhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn dinhLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maDoAn;
    }
}