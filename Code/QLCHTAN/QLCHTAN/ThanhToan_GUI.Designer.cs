
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
            this.dgvThongTinKhachHang = new System.Windows.Forms.DataGridView();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.rdbThe = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhachHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvThongTinKhachHang
            // 
            this.dgvThongTinKhachHang.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvThongTinKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvThongTinKhachHang.Location = new System.Drawing.Point(0, 1);
            this.dgvThongTinKhachHang.Name = "dgvThongTinKhachHang";
            this.dgvThongTinKhachHang.RowHeadersWidth = 51;
            this.dgvThongTinKhachHang.RowTemplate.Height = 24;
            this.dgvThongTinKhachHang.Size = new System.Drawing.Size(458, 571);
            this.dgvThongTinKhachHang.TabIndex = 0;
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Location = new System.Drawing.Point(455, 1);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(412, 344);
            this.dgvHoaDon.TabIndex = 1;
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThanhToan);
            this.panel1.Controls.Add(this.rdbThe);
            this.panel1.Controls.Add(this.rdbTienMat);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(455, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 230);
            this.panel1.TabIndex = 2;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Location = new System.Drawing.Point(110, 151);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(193, 37);
            this.btnThanhToan.TabIndex = 4;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = true;
            // 
            // rdbThe
            // 
            this.rdbThe.AutoSize = true;
            this.rdbThe.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThe.Location = new System.Drawing.Point(245, 87);
            this.rdbThe.Name = "rdbThe";
            this.rdbThe.Size = new System.Drawing.Size(58, 25);
            this.rdbThe.TabIndex = 3;
            this.rdbThe.TabStop = true;
            this.rdbThe.Text = "Thẻ";
            this.rdbThe.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTienMat.Location = new System.Drawing.Point(94, 87);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(95, 25);
            this.rdbTienMat.TabIndex = 2;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền Mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hình Thức :";
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 22);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(286, 29);
            this.comboBox1.TabIndex = 0;
            // 
            // ThanhToan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 578);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.dgvThongTinKhachHang);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ThanhToan_GUI";
            this.Text = "ThanhToan_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvThongTinKhachHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvThongTinKhachHang;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.RadioButton rdbThe;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}