
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.dgvLoaiDoAn = new System.Windows.Forms.DataGridView();
            this.maLoaiDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenLoaiDoAn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTenLoaiDoAn = new System.Windows.Forms.TextBox();
            this.txtMaLoaiDoAn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDoAn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(136, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(231, 26);
            this.label5.TabIndex = 24;
            this.label5.Text = "DANH MỤC LOẠI ĐỒ ĂN";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSua.Location = new System.Drawing.Point(307, 293);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(77, 31);
            this.btnSua.TabIndex = 23;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnXoa.Location = new System.Drawing.Point(224, 293);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(77, 31);
            this.btnXoa.TabIndex = 22;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThem.Location = new System.Drawing.Point(141, 293);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(77, 31);
            this.btnThem.TabIndex = 21;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLamMoi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLamMoi.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLamMoi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLamMoi.Location = new System.Drawing.Point(390, 293);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(77, 31);
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
            this.dgvLoaiDoAn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLoaiDoAn.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLoaiDoAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiDoAn.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maLoaiDoAn,
            this.tenLoaiDoAn});
            this.dgvLoaiDoAn.GridColor = System.Drawing.SystemColors.Control;
            this.dgvLoaiDoAn.Location = new System.Drawing.Point(19, 118);
            this.dgvLoaiDoAn.Name = "dgvLoaiDoAn";
            this.dgvLoaiDoAn.ReadOnly = true;
            this.dgvLoaiDoAn.Size = new System.Drawing.Size(448, 169);
            this.dgvLoaiDoAn.TabIndex = 19;
            this.dgvLoaiDoAn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiDoAn_CellClick);
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
            // txtTenLoaiDoAn
            // 
            this.txtTenLoaiDoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLoaiDoAn.Location = new System.Drawing.Point(102, 40);
            this.txtTenLoaiDoAn.Name = "txtTenLoaiDoAn";
            this.txtTenLoaiDoAn.Size = new System.Drawing.Size(331, 24);
            this.txtTenLoaiDoAn.TabIndex = 18;
            // 
            // txtMaLoaiDoAn
            // 
            this.txtMaLoaiDoAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLoaiDoAn.Location = new System.Drawing.Point(102, 11);
            this.txtMaLoaiDoAn.Name = "txtMaLoaiDoAn";
            this.txtMaLoaiDoAn.Size = new System.Drawing.Size(331, 24);
            this.txtMaLoaiDoAn.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "Tên loại đồ ăn:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Mã loại đồ ăn:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTenLoaiDoAn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtMaLoaiDoAn);
            this.panel1.Location = new System.Drawing.Point(19, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 79);
            this.panel1.TabIndex = 25;
            // 
            // LoaiDoAn_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(475, 329);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnLamMoi);
            this.Controls.Add(this.dgvLoaiDoAn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LoaiDoAn_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3";
            this.Load += new System.EventHandler(this.LoaiDoAn_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiDoAn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
    }
}