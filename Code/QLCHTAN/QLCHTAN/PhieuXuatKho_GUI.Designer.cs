
namespace QLCHTAN
{
    partial class PhieuXuatKho_GUI
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.txtMaXuat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuyPhieuXuat = new System.Windows.Forms.Button();
            this.btnThemPhieuNhap = new System.Windows.Forms.Button();
            this.btnThongTinChiTiet = new System.Windows.Forms.Button();
            this.dgvPhieuXuat = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtNgayXuat);
            this.groupBox1.Controls.Add(this.txtMaXuat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(356, 333);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách phiếu nhập";
            // 
            // dtNgayXuat
            // 
            this.dtNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayXuat.Location = new System.Drawing.Point(106, 151);
            this.dtNgayXuat.Name = "dtNgayXuat";
            this.dtNgayXuat.Size = new System.Drawing.Size(243, 27);
            this.dtNgayXuat.TabIndex = 19;
            // 
            // txtMaXuat
            // 
            this.txtMaXuat.Location = new System.Drawing.Point(106, 117);
            this.txtMaXuat.Name = "txtMaXuat";
            this.txtMaXuat.Size = new System.Drawing.Size(243, 27);
            this.txtMaXuat.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày xuất:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã xuất:";
            // 
            // btnHuyPhieuXuat
            // 
            this.btnHuyPhieuXuat.Location = new System.Drawing.Point(377, 308);
            this.btnHuyPhieuXuat.Name = "btnHuyPhieuXuat";
            this.btnHuyPhieuXuat.Size = new System.Drawing.Size(170, 42);
            this.btnHuyPhieuXuat.TabIndex = 9;
            this.btnHuyPhieuXuat.Text = "Hủy phiếu xuất";
            this.btnHuyPhieuXuat.UseVisualStyleBackColor = true;
            // 
            // btnThemPhieuNhap
            // 
            this.btnThemPhieuNhap.Location = new System.Drawing.Point(553, 308);
            this.btnThemPhieuNhap.Name = "btnThemPhieuNhap";
            this.btnThemPhieuNhap.Size = new System.Drawing.Size(170, 42);
            this.btnThemPhieuNhap.TabIndex = 8;
            this.btnThemPhieuNhap.Text = "Thêm phiếu xuất mới";
            this.btnThemPhieuNhap.UseVisualStyleBackColor = true;
            // 
            // btnThongTinChiTiet
            // 
            this.btnThongTinChiTiet.Location = new System.Drawing.Point(729, 308);
            this.btnThongTinChiTiet.Name = "btnThongTinChiTiet";
            this.btnThongTinChiTiet.Size = new System.Drawing.Size(165, 42);
            this.btnThongTinChiTiet.TabIndex = 7;
            this.btnThongTinChiTiet.Text = "Thông tin chi tiết ";
            this.btnThongTinChiTiet.UseVisualStyleBackColor = true;
            // 
            // dgvPhieuXuat
            // 
            this.dgvPhieuXuat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuXuat.Location = new System.Drawing.Point(377, 31);
            this.dgvPhieuXuat.Name = "dgvPhieuXuat";
            this.dgvPhieuXuat.Size = new System.Drawing.Size(518, 271);
            this.dgvPhieuXuat.TabIndex = 6;
            // 
            // PhieuXuatKho_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 388);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnHuyPhieuXuat);
            this.Controls.Add(this.btnThemPhieuNhap);
            this.Controls.Add(this.btnThongTinChiTiet);
            this.Controls.Add(this.dgvPhieuXuat);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PhieuXuatKho_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhieuXuatKho";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuXuat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNgayXuat;
        private System.Windows.Forms.TextBox txtMaXuat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuyPhieuXuat;
        private System.Windows.Forms.Button btnThemPhieuNhap;
        private System.Windows.Forms.Button btnThongTinChiTiet;
        private System.Windows.Forms.DataGridView dgvPhieuXuat;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}