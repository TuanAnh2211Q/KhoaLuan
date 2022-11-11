
namespace QLCHTAN
{
    partial class DanhMucMon_GUI
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
            this.dgvMonAn = new System.Windows.Forms.DataGridView();
            this.dgvDanhSachMon = new System.Windows.Forms.DataGridView();
            this.dgvNuoc = new System.Windows.Forms.DataGridView();
            this.dgvKhuyenMai = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMonAn
            // 
            this.dgvMonAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMonAn.Location = new System.Drawing.Point(4, -3);
            this.dgvMonAn.Name = "dgvMonAn";
            this.dgvMonAn.RowHeadersWidth = 51;
            this.dgvMonAn.RowTemplate.Height = 24;
            this.dgvMonAn.Size = new System.Drawing.Size(544, 411);
            this.dgvMonAn.TabIndex = 0;
            // 
            // dgvDanhSachMon
            // 
            this.dgvDanhSachMon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachMon.Location = new System.Drawing.Point(547, -3);
            this.dgvDanhSachMon.Name = "dgvDanhSachMon";
            this.dgvDanhSachMon.RowHeadersWidth = 51;
            this.dgvDanhSachMon.RowTemplate.Height = 24;
            this.dgvDanhSachMon.Size = new System.Drawing.Size(358, 411);
            this.dgvDanhSachMon.TabIndex = 1;
            // 
            // dgvNuoc
            // 
            this.dgvNuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNuoc.Location = new System.Drawing.Point(4, 407);
            this.dgvNuoc.Name = "dgvNuoc";
            this.dgvNuoc.RowHeadersWidth = 51;
            this.dgvNuoc.RowTemplate.Height = 24;
            this.dgvNuoc.Size = new System.Drawing.Size(544, 184);
            this.dgvNuoc.TabIndex = 2;
            // 
            // dgvKhuyenMai
            // 
            this.dgvKhuyenMai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhuyenMai.Location = new System.Drawing.Point(547, 407);
            this.dgvKhuyenMai.Name = "dgvKhuyenMai";
            this.dgvKhuyenMai.RowHeadersWidth = 51;
            this.dgvKhuyenMai.RowTemplate.Height = 24;
            this.dgvKhuyenMai.Size = new System.Drawing.Size(358, 184);
            this.dgvKhuyenMai.TabIndex = 3;
            // 
            // DanhMucMon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(907, 593);
            this.Controls.Add(this.dgvKhuyenMai);
            this.Controls.Add(this.dgvNuoc);
            this.Controls.Add(this.dgvDanhSachMon);
            this.Controls.Add(this.dgvMonAn);
            this.Font = new System.Drawing.Font("Candara Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DanhMucMon_GUI";
            this.Text = "MenuDoAn_GUI";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMonAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhuyenMai)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMonAn;
        private System.Windows.Forms.DataGridView dgvDanhSachMon;
        private System.Windows.Forms.DataGridView dgvNuoc;
        private System.Windows.Forms.DataGridView dgvKhuyenMai;
    }
}