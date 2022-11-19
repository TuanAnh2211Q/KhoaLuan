
namespace QLCHTAN
{
    partial class ThanhToan_GUI
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
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panelThanhToan = new System.Windows.Forms.Panel();
            this.gboxHinhThuc = new System.Windows.Forms.GroupBox();
            this.rdbMangVe = new System.Windows.Forms.RadioButton();
            this.rdbGiaoHang = new System.Windows.Forms.RadioButton();
            this.rdbAnTaiCho = new System.Windows.Forms.RadioButton();
            this.gboxThanhToan = new System.Windows.Forms.GroupBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.rdbThe = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.panel_KhachHang = new System.Windows.Forms.Panel();
            this.cbbSDT = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panelThanhToan.SuspendLayout();
            this.gboxHinhThuc.SuspendLayout();
            this.gboxThanhToan.SuspendLayout();
            this.panel_KhachHang.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(484, 3);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(475, 594);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // panelThanhToan
            // 
            this.panelThanhToan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThanhToan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelThanhToan.Controls.Add(this.gboxHinhThuc);
            this.panelThanhToan.Controls.Add(this.gboxThanhToan);
            this.panelThanhToan.Location = new System.Drawing.Point(5, 317);
            this.panelThanhToan.Name = "panelThanhToan";
            this.panelThanhToan.Size = new System.Drawing.Size(481, 297);
            this.panelThanhToan.TabIndex = 2;
            // 
            // gboxHinhThuc
            // 
            this.gboxHinhThuc.Controls.Add(this.rdbMangVe);
            this.gboxHinhThuc.Controls.Add(this.rdbGiaoHang);
            this.gboxHinhThuc.Controls.Add(this.rdbAnTaiCho);
            this.gboxHinhThuc.Location = new System.Drawing.Point(13, 18);
            this.gboxHinhThuc.Name = "gboxHinhThuc";
            this.gboxHinhThuc.Size = new System.Drawing.Size(460, 122);
            this.gboxHinhThuc.TabIndex = 6;
            this.gboxHinhThuc.TabStop = false;
            this.gboxHinhThuc.Text = "Hình Thức :";
            // 
            // rdbMangVe
            // 
            this.rdbMangVe.AutoSize = true;
            this.rdbMangVe.Location = new System.Drawing.Point(164, 53);
            this.rdbMangVe.Name = "rdbMangVe";
            this.rdbMangVe.Size = new System.Drawing.Size(123, 33);
            this.rdbMangVe.TabIndex = 2;
            this.rdbMangVe.TabStop = true;
            this.rdbMangVe.Text = "Mang Về";
            this.rdbMangVe.UseVisualStyleBackColor = true;
            // 
            // rdbGiaoHang
            // 
            this.rdbGiaoHang.AutoSize = true;
            this.rdbGiaoHang.Location = new System.Drawing.Point(310, 53);
            this.rdbGiaoHang.Name = "rdbGiaoHang";
            this.rdbGiaoHang.Size = new System.Drawing.Size(139, 33);
            this.rdbGiaoHang.TabIndex = 1;
            this.rdbGiaoHang.TabStop = true;
            this.rdbGiaoHang.Text = "Giao Hàng";
            this.rdbGiaoHang.UseVisualStyleBackColor = true;
            // 
            // rdbAnTaiCho
            // 
            this.rdbAnTaiCho.AutoSize = true;
            this.rdbAnTaiCho.Location = new System.Drawing.Point(6, 53);
            this.rdbAnTaiCho.Name = "rdbAnTaiCho";
            this.rdbAnTaiCho.Size = new System.Drawing.Size(141, 33);
            this.rdbAnTaiCho.TabIndex = 0;
            this.rdbAnTaiCho.TabStop = true;
            this.rdbAnTaiCho.Text = "Ăn Tại Chổ";
            this.rdbAnTaiCho.UseVisualStyleBackColor = true;
            // 
            // gboxThanhToan
            // 
            this.gboxThanhToan.Controls.Add(this.btnThanhToan);
            this.gboxThanhToan.Controls.Add(this.rdbThe);
            this.gboxThanhToan.Controls.Add(this.rdbTienMat);
            this.gboxThanhToan.Location = new System.Drawing.Point(13, 146);
            this.gboxThanhToan.Name = "gboxThanhToan";
            this.gboxThanhToan.Size = new System.Drawing.Size(460, 121);
            this.gboxThanhToan.TabIndex = 5;
            this.gboxThanhToan.TabStop = false;
            this.gboxThanhToan.Text = "Hình Thức Thanh Toán :";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(129, 74);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(193, 37);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // rdbThe
            // 
            this.rdbThe.AutoSize = true;
            this.rdbThe.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThe.Location = new System.Drawing.Point(279, 35);
            this.rdbThe.Name = "rdbThe";
            this.rdbThe.Size = new System.Drawing.Size(72, 33);
            this.rdbThe.TabIndex = 3;
            this.rdbThe.TabStop = true;
            this.rdbThe.Text = "Thẻ";
            this.rdbThe.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTienMat.Location = new System.Drawing.Point(105, 35);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(106, 28);
            this.rdbTienMat.TabIndex = 2;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền Mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // panel_KhachHang
            // 
            this.panel_KhachHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_KhachHang.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel_KhachHang.Controls.Add(this.cbbSDT);
            this.panel_KhachHang.Controls.Add(this.txtNote);
            this.panel_KhachHang.Controls.Add(this.txtDiaChi);
            this.panel_KhachHang.Controls.Add(this.txtTenKH);
            this.panel_KhachHang.Controls.Add(this.label6);
            this.panel_KhachHang.Controls.Add(this.label5);
            this.panel_KhachHang.Controls.Add(this.label4);
            this.panel_KhachHang.Controls.Add(this.label3);
            this.panel_KhachHang.Controls.Add(this.label2);
            this.panel_KhachHang.Location = new System.Drawing.Point(5, 3);
            this.panel_KhachHang.Name = "panel_KhachHang";
            this.panel_KhachHang.Size = new System.Drawing.Size(481, 326);
            this.panel_KhachHang.TabIndex = 3;
            // 
            // cbbSDT
            // 
            this.cbbSDT.FormattingEnabled = true;
            this.cbbSDT.Location = new System.Drawing.Point(136, 74);
            this.cbbSDT.Name = "cbbSDT";
            this.cbbSDT.Size = new System.Drawing.Size(326, 36);
            this.cbbSDT.TabIndex = 9;
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNote.Location = new System.Drawing.Point(136, 276);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(328, 32);
            this.txtNote.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(136, 212);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(328, 32);
            this.txtDiaChi.TabIndex = 7;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKH.Location = new System.Drawing.Point(136, 148);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(328, 32);
            this.txtTenKH.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(117, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(287, 35);
            this.label6.TabIndex = 4;
            this.label6.Text = "Thông Tin Khách Hàng ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 3;
            this.label5.Text = "Ghi Chú :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(42, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 24);
            this.label4.TabIndex = 2;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(67, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "SDT :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên Khách  :";
            // 
            // ThanhToan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 609);
            this.Controls.Add(this.panel_KhachHang);
            this.Controls.Add(this.panelThanhToan);
            this.Controls.Add(this.dgvHoaDon);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThanhToan_GUI";
            this.Text = "ThanhToan_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panelThanhToan.ResumeLayout(false);
            this.gboxHinhThuc.ResumeLayout(false);
            this.gboxHinhThuc.PerformLayout();
            this.gboxThanhToan.ResumeLayout(false);
            this.gboxThanhToan.PerformLayout();
            this.panel_KhachHang.ResumeLayout(false);
            this.panel_KhachHang.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panelThanhToan;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.RadioButton rdbThe;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.Panel panel_KhachHang;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gboxThanhToan;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.GroupBox gboxHinhThuc;
        private System.Windows.Forms.RadioButton rdbMangVe;
        private System.Windows.Forms.RadioButton rdbGiaoHang;
        private System.Windows.Forms.RadioButton rdbAnTaiCho;
        private System.Windows.Forms.ComboBox cbbSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}