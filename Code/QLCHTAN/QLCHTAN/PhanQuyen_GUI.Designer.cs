
namespace QLCHTAN
{
    partial class PhanQuyen_GUI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGhiChu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaQuyen = new System.Windows.Forms.TextBox();
            this.txtTenQuyen = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvPhanQuyen = new System.Windows.Forms.DataGridView();
            this.maQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.lblkThoat);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.dgvPhanQuyen);
            this.panel1.Location = new System.Drawing.Point(2, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(563, 165);
            this.panel1.TabIndex = 0;
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(519, 11);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(39, 15);
            this.lblkThoat.TabIndex = 34;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(327, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(165, 23);
            this.label4.TabIndex = 33;
            this.label4.Text = "THÔNG TIN QUYỀN";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.txtGhiChu);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtMaQuyen);
            this.groupBox1.Controls.Add(this.txtTenQuyen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(243, 158);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin quyền";
            // 
            // txtGhiChu
            // 
            this.txtGhiChu.Location = new System.Drawing.Point(82, 88);
            this.txtGhiChu.Margin = new System.Windows.Forms.Padding(2);
            this.txtGhiChu.Multiline = true;
            this.txtGhiChu.Name = "txtGhiChu";
            this.txtGhiChu.Size = new System.Drawing.Size(143, 66);
            this.txtGhiChu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên quyền:";
            // 
            // txtMaQuyen
            // 
            this.txtMaQuyen.Location = new System.Drawing.Point(82, 21);
            this.txtMaQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaQuyen.Name = "txtMaQuyen";
            this.txtMaQuyen.Size = new System.Drawing.Size(143, 23);
            this.txtMaQuyen.TabIndex = 2;
            // 
            // txtTenQuyen
            // 
            this.txtTenQuyen.Location = new System.Drawing.Point(82, 53);
            this.txtTenQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenQuyen.Name = "txtTenQuyen";
            this.txtTenQuyen.Size = new System.Drawing.Size(143, 23);
            this.txtTenQuyen.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 88);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ghi chú:";
            // 
            // dgvPhanQuyen
            // 
            this.dgvPhanQuyen.AllowUserToAddRows = false;
            this.dgvPhanQuyen.AllowUserToDeleteRows = false;
            this.dgvPhanQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhanQuyen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhanQuyen.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvPhanQuyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhanQuyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maQuyen,
            this.tenQuyen,
            this.ghiChu});
            this.dgvPhanQuyen.Location = new System.Drawing.Point(251, 28);
            this.dgvPhanQuyen.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPhanQuyen.Name = "dgvPhanQuyen";
            this.dgvPhanQuyen.ReadOnly = true;
            this.dgvPhanQuyen.Size = new System.Drawing.Size(307, 134);
            this.dgvPhanQuyen.TabIndex = 31;
            // 
            // maQuyen
            // 
            this.maQuyen.DataPropertyName = "maQuyen";
            this.maQuyen.HeaderText = "Mã quyền";
            this.maQuyen.Name = "maQuyen";
            this.maQuyen.ReadOnly = true;
            // 
            // tenQuyen
            // 
            this.tenQuyen.DataPropertyName = "tenQuyen";
            this.tenQuyen.HeaderText = "Tên quyền";
            this.tenQuyen.Name = "tenQuyen";
            this.tenQuyen.ReadOnly = true;
            // 
            // ghiChu
            // 
            this.ghiChu.DataPropertyName = "ghiChu";
            this.ghiChu.HeaderText = "Ghi chú";
            this.ghiChu.Name = "ghiChu";
            this.ghiChu.ReadOnly = true;
            this.ghiChu.Visible = false;
            // 
            // PhanQuyen_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(568, 173);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PhanQuyen_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PhanQuyen_GUI";
            this.Load += new System.EventHandler(this.PhanQuyen_GUI_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhanQuyen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.LinkLabel lblkThoat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtGhiChu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaQuyen;
        private System.Windows.Forms.TextBox txtTenQuyen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvPhanQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenQuyen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ghiChu;
    }
}