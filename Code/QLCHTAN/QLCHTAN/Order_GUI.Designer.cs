
namespace QLCHTAN
{
    partial class Order_GUI
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
            this.panel_Trai = new System.Windows.Forms.Panel();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnOder = new System.Windows.Forms.Button();
            this.panel_Than = new System.Windows.Forms.Panel();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnKhuyenMai = new System.Windows.Forms.Button();
            this.panel_Tren = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelThan = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dvgThongTinDonHang = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNuoc = new System.Windows.Forms.Button();
            this.panel_Trai.SuspendLayout();
            this.panel_Tren.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgThongTinDonHang)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_Trai
            // 
            this.panel_Trai.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Trai.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Trai.Controls.Add(this.btnNuoc);
            this.panel_Trai.Controls.Add(this.btnThoat);
            this.panel_Trai.Controls.Add(this.btnOder);
            this.panel_Trai.Controls.Add(this.panel_Than);
            this.panel_Trai.Controls.Add(this.btnThanhToan);
            this.panel_Trai.Controls.Add(this.btnKhuyenMai);
            this.panel_Trai.Location = new System.Drawing.Point(0, 1);
            this.panel_Trai.Name = "panel_Trai";
            this.panel_Trai.Size = new System.Drawing.Size(143, 666);
            this.panel_Trai.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThoat.Location = new System.Drawing.Point(-1, 590);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(145, 65);
            this.btnThoat.TabIndex = 8;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnOder
            // 
            this.btnOder.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnOder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOder.Location = new System.Drawing.Point(0, 82);
            this.btnOder.Name = "btnOder";
            this.btnOder.Size = new System.Drawing.Size(143, 65);
            this.btnOder.TabIndex = 7;
            this.btnOder.Text = "Bảng Oder";
            this.btnOder.UseVisualStyleBackColor = false;
            this.btnOder.Click += new System.EventHandler(this.btnOder_Click);
            // 
            // panel_Than
            // 
            this.panel_Than.Location = new System.Drawing.Point(141, 51);
            this.panel_Than.Name = "panel_Than";
            this.panel_Than.Size = new System.Drawing.Size(783, 493);
            this.panel_Than.TabIndex = 6;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnThanhToan.Location = new System.Drawing.Point(-3, 463);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(145, 65);
            this.btnThanhToan.TabIndex = 1;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnKhuyenMai
            // 
            this.btnKhuyenMai.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnKhuyenMai.Location = new System.Drawing.Point(-3, 328);
            this.btnKhuyenMai.Name = "btnKhuyenMai";
            this.btnKhuyenMai.Size = new System.Drawing.Size(143, 65);
            this.btnKhuyenMai.TabIndex = 0;
            this.btnKhuyenMai.Text = "Khuyến Mãi";
            this.btnKhuyenMai.UseVisualStyleBackColor = false;
            this.btnKhuyenMai.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // panel_Tren
            // 
            this.panel_Tren.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel_Tren.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel_Tren.Controls.Add(this.label1);
            this.panel_Tren.Location = new System.Drawing.Point(144, 1);
            this.panel_Tren.Name = "panel_Tren";
            this.panel_Tren.Size = new System.Drawing.Size(946, 72);
            this.panel_Tren.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(349, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bảng Oder Khách";
            // 
            // panelThan
            // 
            this.panelThan.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelThan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelThan.Location = new System.Drawing.Point(144, 74);
            this.panelThan.Name = "panelThan";
            this.panelThan.Size = new System.Drawing.Size(536, 593);
            this.panelThan.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dvgThongTinDonHang);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(678, 74);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 593);
            this.panel1.TabIndex = 8;
            // 
            // dvgThongTinDonHang
            // 
            this.dvgThongTinDonHang.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dvgThongTinDonHang.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dvgThongTinDonHang.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dvgThongTinDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgThongTinDonHang.Location = new System.Drawing.Point(3, 3);
            this.dvgThongTinDonHang.Name = "dvgThongTinDonHang";
            this.dvgThongTinDonHang.RowHeadersWidth = 51;
            this.dvgThongTinDonHang.RowTemplate.Height = 24;
            this.dvgThongTinDonHang.Size = new System.Drawing.Size(402, 480);
            this.dvgThongTinDonHang.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtThanhTien);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(18, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(361, 62);
            this.panel2.TabIndex = 3;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(104, 16);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(203, 36);
            this.txtThanhTien.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thành Tiền : ";
            // 
            // btnNuoc
            // 
            this.btnNuoc.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnNuoc.Location = new System.Drawing.Point(-2, 199);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(143, 65);
            this.btnNuoc.TabIndex = 9;
            this.btnNuoc.Text = "Nước";
            this.btnNuoc.UseVisualStyleBackColor = false;
            this.btnNuoc.Click += new System.EventHandler(this.btnNuoc_Click);
            // 
            // Order_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1092, 668);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelThan);
            this.Controls.Add(this.panel_Tren);
            this.Controls.Add(this.panel_Trai);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Order_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oder_GUI";
            this.panel_Trai.ResumeLayout(false);
            this.panel_Tren.ResumeLayout(false);
            this.panel_Tren.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgThongTinDonHang)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Trai;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnKhuyenMai;
        private System.Windows.Forms.Panel panel_Tren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_Than;
        private System.Windows.Forms.Button btnOder;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panelThan;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgThongTinDonHang;
        private System.Windows.Forms.Button btnNuoc;
    }
}