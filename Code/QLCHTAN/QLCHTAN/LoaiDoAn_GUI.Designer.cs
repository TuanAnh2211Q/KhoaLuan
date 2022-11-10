
namespace QLCHTAN
{
    partial class LoaiDoAn_GUI
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
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLoaiDoAn = new System.Windows.Forms.DataGridView();
            this.txtTenLoaiDoAn = new System.Windows.Forms.TextBox();
            this.txtMaLoaiDoAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maLoaiDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDoAn)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(154, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(268, 31);
            this.label5.TabIndex = 24;
            this.label5.Text = "DANH MỤC LOẠI ĐỒ ĂN";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(376, 290);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 31);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(295, 290);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 31);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(214, 290);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 31);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(457, 290);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(75, 31);
            this.btnLamMoi.TabIndex = 20;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = false;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // dgvLoaiDoAn
            // 
            this.dgvLoaiDoAn.AllowUserToAddRows = false;
            this.dgvLoaiDoAn.AllowUserToDeleteRows = false;
            this.dgvLoaiDoAn.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLoaiDoAn.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvLoaiDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDoAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDoAn,
            this.tenLoaiDoAn});
            this.dgvLoaiDoAn.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiDoAn.Location = new System.Drawing.Point(19, 115);
            this.dgvLoaiDoAn.Name = "dgvLoaiDoAn";
            this.dgvLoaiDoAn.ReadOnly = true;
            this.dgvLoaiDoAn.Size = new System.Drawing.Size(513, 169);
            this.dgvLoaiDoAn.TabIndex = 19;
            this.dgvLoaiDoAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDoAn_CellClick);
            // 
            // txtTenLoaiDoAn
            // 
            this.txtTenLoaiDoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiDoAn.Location = new System.Drawing.Point(123, 85);
            this.txtTenLoaiDoAn.Name = "txtTenLoaiDoAn";
            this.txtTenLoaiDoAn.Size = new System.Drawing.Size(409, 24);
            this.txtTenLoaiDoAn.TabIndex = 18;
            // 
            // txtMaLoaiDoAn
            // 
            this.txtMaLoaiDoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiDoAn.Location = new System.Drawing.Point(123, 56);
            this.txtMaLoaiDoAn.Name = "txtMaLoaiDoAn";
            this.txtMaLoaiDoAn.Size = new System.Drawing.Size(409, 24);
            this.txtMaLoaiDoAn.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên loại đồ ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã loại đồ ăn:";
            // 
            // maLoaiDoAn
            // 
            this.maLoaiDoAn.DataPropertyName = "maLoaiDoAn";
            this.maLoaiDoAn.HeaderText = "Mã loại đồ ăn";
            this.maLoaiDoAn.Name = "maLoaiDoAn";
            this.maLoaiDoAn.ReadOnly = true;
            // 
            // tenLoaiDoAn
            // 
            this.tenLoaiDoAn.DataPropertyName = "tenLoaiDoAn";
            this.tenLoaiDoAn.HeaderText = "Tên loại đồ ăn";
            this.tenLoaiDoAn.Name = "tenLoaiDoAn";
            this.tenLoaiDoAn.ReadOnly = true;
            // 
            // LoaiDoAn_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 329);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvLoaiDoAn);
            this.Controls.Add(this.txtTenLoaiDoAn);
            this.Controls.Add(this.txtMaLoaiDoAn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoaiDoAn_GUI";
            this.Text = "Loại đồ ăn";
            this.Load += new System.EventHandler(this.LoaiDoAn_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDoAn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.DataGridView dgvLoaiDoAn;
        private System.Windows.Forms.TextBox txtTenLoaiDoAn;
        private System.Windows.Forms.TextBox txtMaLoaiDoAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn maLoaiDoAn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenLoaiDoAn;
    }
}