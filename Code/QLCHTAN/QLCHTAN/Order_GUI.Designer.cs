
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
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.rdbThe = new System.Windows.Forms.RadioButton();
            this.rdbTienMat = new System.Windows.Forms.RadioButton();
            this.dgvDonHang = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTenKhach = new System.Windows.Forms.TextBox();
            this.cbbSDT = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rdbMangVe = new System.Windows.Forms.RadioButton();
            this.rdbAnTaiCho = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gbPhuongThuc = new System.Windows.Forms.GroupBox();
            this.rdbGiaoHang = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelKhachHang = new System.Windows.Forms.Panel();
            this.rdbNu = new System.Windows.Forms.RadioButton();
            this.rdbNam = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.rtxtGhiChu = new System.Windows.Forms.RichTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.panelThanhToan = new System.Windows.Forms.Panel();
            this.cbbMaGiamGia = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PanelOrder = new System.Windows.Forms.Panel();
            this.panelThongTinOrder = new System.Windows.Forms.Panel();
            this.cbxSize = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnXoaMon = new System.Windows.Forms.Button();
            this.btnThemMon = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbTenMon = new System.Windows.Forms.ComboBox();
            this.cbbDanhMucMon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).BeginInit();
            this.gbPhuongThuc.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panelKhachHang.SuspendLayout();
            this.panelThanhToan.SuspendLayout();
            this.PanelOrder.SuspendLayout();
            this.panelThongTinOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTongTien
            // 
            this.txtTongTien.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Location = new System.Drawing.Point(22, 260);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(259, 32);
            this.txtTongTien.TabIndex = 16;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThanhToan.Location = new System.Drawing.Point(16, 521);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(256, 45);
            this.btnThanhToan.TabIndex = 14;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // rdbThe
            // 
            this.rdbThe.AutoSize = true;
            this.rdbThe.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbThe.Location = new System.Drawing.Point(169, 59);
            this.rdbThe.Name = "rdbThe";
            this.rdbThe.Size = new System.Drawing.Size(63, 28);
            this.rdbThe.TabIndex = 3;
            this.rdbThe.TabStop = true;
            this.rdbThe.Text = "Thẻ";
            this.rdbThe.UseVisualStyleBackColor = true;
            // 
            // rdbTienMat
            // 
            this.rdbTienMat.AutoSize = true;
            this.rdbTienMat.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTienMat.Location = new System.Drawing.Point(13, 59);
            this.rdbTienMat.Name = "rdbTienMat";
            this.rdbTienMat.Size = new System.Drawing.Size(106, 28);
            this.rdbTienMat.TabIndex = 2;
            this.rdbTienMat.TabStop = true;
            this.rdbTienMat.Text = "Tiền Mặt";
            this.rdbTienMat.UseVisualStyleBackColor = true;
            // 
            // dgvDonHang
            // 
            this.dgvDonHang.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvDonHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonHang.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvDonHang.Location = new System.Drawing.Point(3, 313);
            this.dgvDonHang.Name = "dgvDonHang";
            this.dgvDonHang.RowHeadersWidth = 51;
            this.dgvDonHang.RowTemplate.Height = 24;
            this.dgvDonHang.Size = new System.Drawing.Size(438, 441);
            this.dgvDonHang.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa Chỉ :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(12, 209);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 24);
            this.label10.TabIndex = 15;
            this.label10.Text = "Tổng Tiền :";
            // 
            // txtTenKhach
            // 
            this.txtTenKhach.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenKhach.Location = new System.Drawing.Point(42, 201);
            this.txtTenKhach.Name = "txtTenKhach";
            this.txtTenKhach.Size = new System.Drawing.Size(351, 32);
            this.txtTenKhach.TabIndex = 7;
            this.txtTenKhach.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTenKhach_KeyPress);
            // 
            // cbbSDT
            // 
            this.cbbSDT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbSDT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbSDT.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbSDT.FormattingEnabled = true;
            this.cbbSDT.Location = new System.Drawing.Point(42, 118);
            this.cbbSDT.Name = "cbbSDT";
            this.cbbSDT.Size = new System.Drawing.Size(351, 32);
            this.cbbSDT.TabIndex = 5;
            this.cbbSDT.SelectedValueChanged += new System.EventHandler(this.cbbSDT_SelectedValueChanged);
            this.cbbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbbSDT_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Số Điện Thoại :";
            // 
            // rdbMangVe
            // 
            this.rdbMangVe.AutoSize = true;
            this.rdbMangVe.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMangVe.Location = new System.Drawing.Point(156, 71);
            this.rdbMangVe.Name = "rdbMangVe";
            this.rdbMangVe.Size = new System.Drawing.Size(108, 28);
            this.rdbMangVe.TabIndex = 1;
            this.rdbMangVe.TabStop = true;
            this.rdbMangVe.Text = "Mang Về ";
            this.rdbMangVe.UseVisualStyleBackColor = true;
            this.rdbMangVe.CheckedChanged += new System.EventHandler(this.rdbMangVe_CheckedChanged);
            // 
            // rdbAnTaiCho
            // 
            this.rdbAnTaiCho.AutoSize = true;
            this.rdbAnTaiCho.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAnTaiCho.Location = new System.Drawing.Point(7, 73);
            this.rdbAnTaiCho.Name = "rdbAnTaiCho";
            this.rdbAnTaiCho.Size = new System.Drawing.Size(125, 28);
            this.rdbAnTaiCho.TabIndex = 0;
            this.rdbAnTaiCho.TabStop = true;
            this.rdbAnTaiCho.Text = "Ăn Tại Chổ ";
            this.rdbAnTaiCho.UseVisualStyleBackColor = true;
            this.rdbAnTaiCho.CheckedChanged += new System.EventHandler(this.rdbAnTaiCho_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tên Khách :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông Tin Khách Hàng !!";
            // 
            // gbPhuongThuc
            // 
            this.gbPhuongThuc.Controls.Add(this.rdbGiaoHang);
            this.gbPhuongThuc.Controls.Add(this.rdbMangVe);
            this.gbPhuongThuc.Controls.Add(this.rdbAnTaiCho);
            this.gbPhuongThuc.Location = new System.Drawing.Point(3, 478);
            this.gbPhuongThuc.Name = "gbPhuongThuc";
            this.gbPhuongThuc.Size = new System.Drawing.Size(402, 144);
            this.gbPhuongThuc.TabIndex = 2;
            this.gbPhuongThuc.TabStop = false;
            this.gbPhuongThuc.Text = "Loại Dịch Vụ :";
            // 
            // rdbGiaoHang
            // 
            this.rdbGiaoHang.AutoSize = true;
            this.rdbGiaoHang.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbGiaoHang.Location = new System.Drawing.Point(278, 71);
            this.rdbGiaoHang.Name = "rdbGiaoHang";
            this.rdbGiaoHang.Size = new System.Drawing.Size(118, 28);
            this.rdbGiaoHang.TabIndex = 2;
            this.rdbGiaoHang.TabStop = true;
            this.rdbGiaoHang.Text = "Giao Hàng";
            this.rdbGiaoHang.UseVisualStyleBackColor = true;
            this.rdbGiaoHang.CheckedChanged += new System.EventHandler(this.rdbGiaoHang_CheckedChanged);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(460, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(395, 736);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbThe);
            this.groupBox1.Controls.Add(this.rdbTienMat);
            this.groupBox1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(9, 349);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 133);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phương Thức Thanh Toán :";
            // 
            // panelKhachHang
            // 
            this.panelKhachHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelKhachHang.Controls.Add(this.rdbNu);
            this.panelKhachHang.Controls.Add(this.rdbNam);
            this.panelKhachHang.Controls.Add(this.label14);
            this.panelKhachHang.Controls.Add(this.txtEmail);
            this.panelKhachHang.Controls.Add(this.label13);
            this.panelKhachHang.Controls.Add(this.rtxtGhiChu);
            this.panelKhachHang.Controls.Add(this.label11);
            this.panelKhachHang.Controls.Add(this.txtDiaChi);
            this.panelKhachHang.Controls.Add(this.label4);
            this.panelKhachHang.Controls.Add(this.txtTenKhach);
            this.panelKhachHang.Controls.Add(this.label3);
            this.panelKhachHang.Controls.Add(this.cbbSDT);
            this.panelKhachHang.Controls.Add(this.label2);
            this.panelKhachHang.Controls.Add(this.label1);
            this.panelKhachHang.Controls.Add(this.gbPhuongThuc);
            this.panelKhachHang.Controls.Add(this.flowLayoutPanel1);
            this.panelKhachHang.Location = new System.Drawing.Point(2, 1);
            this.panelKhachHang.Name = "panelKhachHang";
            this.panelKhachHang.Size = new System.Drawing.Size(405, 769);
            this.panelKhachHang.TabIndex = 6;
            // 
            // rdbNu
            // 
            this.rdbNu.AutoSize = true;
            this.rdbNu.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNu.Location = new System.Drawing.Point(217, 279);
            this.rdbNu.Name = "rdbNu";
            this.rdbNu.Size = new System.Drawing.Size(58, 28);
            this.rdbNu.TabIndex = 17;
            this.rdbNu.TabStop = true;
            this.rdbNu.Text = "Nữ";
            this.rdbNu.UseVisualStyleBackColor = true;
            this.rdbNu.CheckedChanged += new System.EventHandler(this.rdbNu_CheckedChanged);
            // 
            // rdbNam
            // 
            this.rdbNam.AutoSize = true;
            this.rdbNam.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNam.Location = new System.Drawing.Point(83, 279);
            this.rdbNam.Name = "rdbNam";
            this.rdbNam.Size = new System.Drawing.Size(71, 28);
            this.rdbNam.TabIndex = 16;
            this.rdbNam.TabStop = true;
            this.rdbNam.Text = "Nam";
            this.rdbNam.UseVisualStyleBackColor = true;
            this.rdbNam.CheckedChanged += new System.EventHandler(this.rdbNam_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 247);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 21);
            this.label14.TabIndex = 15;
            this.label14.Text = "Giới Tính :";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(42, 421);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(354, 32);
            this.txtEmail.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Candara", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(6, 390);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(57, 21);
            this.label13.TabIndex = 13;
            this.label13.Text = "Email :";
            // 
            // rtxtGhiChu
            // 
            this.rtxtGhiChu.Location = new System.Drawing.Point(7, 678);
            this.rtxtGhiChu.Name = "rtxtGhiChu";
            this.rtxtGhiChu.Size = new System.Drawing.Size(383, 71);
            this.rtxtGhiChu.TabIndex = 12;
            this.rtxtGhiChu.Text = "";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 651);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 24);
            this.label11.TabIndex = 11;
            this.label11.Text = "Ghi Chú :";
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(42, 344);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(351, 32);
            this.txtDiaChi.TabIndex = 9;
            // 
            // panelThanhToan
            // 
            this.panelThanhToan.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelThanhToan.Controls.Add(this.txtTongTien);
            this.panelThanhToan.Controls.Add(this.label10);
            this.panelThanhToan.Controls.Add(this.btnThanhToan);
            this.panelThanhToan.Controls.Add(this.groupBox1);
            this.panelThanhToan.Controls.Add(this.cbbMaGiamGia);
            this.panelThanhToan.Controls.Add(this.label9);
            this.panelThanhToan.Controls.Add(this.label8);
            this.panelThanhToan.Location = new System.Drawing.Point(860, 2);
            this.panelThanhToan.Name = "panelThanhToan";
            this.panelThanhToan.Size = new System.Drawing.Size(290, 768);
            this.panelThanhToan.TabIndex = 8;
            // 
            // cbbMaGiamGia
            // 
            this.cbbMaGiamGia.CausesValidation = false;
            this.cbbMaGiamGia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbMaGiamGia.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaGiamGia.FormattingEnabled = true;
            this.cbbMaGiamGia.Location = new System.Drawing.Point(24, 134);
            this.cbbMaGiamGia.Name = "cbbMaGiamGia";
            this.cbbMaGiamGia.Size = new System.Drawing.Size(257, 32);
            this.cbbMaGiamGia.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 24);
            this.label9.TabIndex = 7;
            this.label9.Text = "Giảm Giá :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 29);
            this.label8.TabIndex = 4;
            this.label8.Text = "Thanh Toán !!";
            // 
            // PanelOrder
            // 
            this.PanelOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelOrder.Controls.Add(this.dgvDonHang);
            this.PanelOrder.Controls.Add(this.panelThongTinOrder);
            this.PanelOrder.Location = new System.Drawing.Point(413, 1);
            this.PanelOrder.Name = "PanelOrder";
            this.PanelOrder.Size = new System.Drawing.Size(444, 769);
            this.PanelOrder.TabIndex = 7;
            // 
            // panelThongTinOrder
            // 
            this.panelThongTinOrder.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelThongTinOrder.Controls.Add(this.cbxSize);
            this.panelThongTinOrder.Controls.Add(this.label12);
            this.panelThongTinOrder.Controls.Add(this.btnXoaMon);
            this.panelThongTinOrder.Controls.Add(this.btnThemMon);
            this.panelThongTinOrder.Controls.Add(this.label7);
            this.panelThongTinOrder.Controls.Add(this.nudSoLuong);
            this.panelThongTinOrder.Controls.Add(this.cbbTenMon);
            this.panelThongTinOrder.Controls.Add(this.cbbDanhMucMon);
            this.panelThongTinOrder.Controls.Add(this.label6);
            this.panelThongTinOrder.Controls.Add(this.label5);
            this.panelThongTinOrder.Location = new System.Drawing.Point(3, 4);
            this.panelThongTinOrder.Name = "panelThongTinOrder";
            this.panelThongTinOrder.Size = new System.Drawing.Size(435, 303);
            this.panelThongTinOrder.TabIndex = 0;
            // 
            // cbxSize
            // 
            this.cbxSize.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxSize.FormattingEnabled = true;
            this.cbxSize.Location = new System.Drawing.Point(154, 126);
            this.cbxSize.Name = "cbxSize";
            this.cbxSize.Size = new System.Drawing.Size(266, 32);
            this.cbxSize.TabIndex = 14;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(3, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(118, 24);
            this.label12.TabIndex = 13;
            this.label12.Text = "Kích Thước :";
            // 
            // btnXoaMon
            // 
            this.btnXoaMon.BackColor = System.Drawing.Color.PowderBlue;
            this.btnXoaMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnXoaMon.Location = new System.Drawing.Point(250, 244);
            this.btnXoaMon.Name = "btnXoaMon";
            this.btnXoaMon.Size = new System.Drawing.Size(153, 45);
            this.btnXoaMon.TabIndex = 12;
            this.btnXoaMon.Text = "Xóa Món";
            this.btnXoaMon.UseVisualStyleBackColor = false;
            // 
            // btnThemMon
            // 
            this.btnThemMon.BackColor = System.Drawing.Color.PowderBlue;
            this.btnThemMon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnThemMon.Location = new System.Drawing.Point(70, 244);
            this.btnThemMon.Name = "btnThemMon";
            this.btnThemMon.Size = new System.Drawing.Size(153, 45);
            this.btnThemMon.TabIndex = 11;
            this.btnThemMon.Text = "Thêm Món ";
            this.btnThemMon.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số Lượng :";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(154, 192);
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(266, 32);
            this.nudSoLuong.TabIndex = 9;
            this.nudSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbbTenMon
            // 
            this.cbbTenMon.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenMon.FormattingEnabled = true;
            this.cbbTenMon.Location = new System.Drawing.Point(154, 68);
            this.cbbTenMon.Name = "cbbTenMon";
            this.cbbTenMon.Size = new System.Drawing.Size(266, 32);
            this.cbbTenMon.TabIndex = 8;
            // 
            // cbbDanhMucMon
            // 
            this.cbbDanhMucMon.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDanhMucMon.FormattingEnabled = true;
            this.cbbDanhMucMon.Location = new System.Drawing.Point(154, 9);
            this.cbbDanhMucMon.Name = "cbbDanhMucMon";
            this.cbbDanhMucMon.Size = new System.Drawing.Size(262, 32);
            this.cbbDanhMucMon.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Tên Món :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "Danh Mục Món :";
            // 
            // Order_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1152, 767);
            this.Controls.Add(this.panelKhachHang);
            this.Controls.Add(this.panelThanhToan);
            this.Controls.Add(this.PanelOrder);
            this.Font = new System.Drawing.Font("Candara Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Order_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderChinh";
            this.Load += new System.EventHandler(this.Order_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonHang)).EndInit();
            this.gbPhuongThuc.ResumeLayout(false);
            this.gbPhuongThuc.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelKhachHang.ResumeLayout(false);
            this.panelKhachHang.PerformLayout();
            this.panelThanhToan.ResumeLayout(false);
            this.panelThanhToan.PerformLayout();
            this.PanelOrder.ResumeLayout(false);
            this.panelThongTinOrder.ResumeLayout(false);
            this.panelThongTinOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.RadioButton rdbThe;
        private System.Windows.Forms.RadioButton rdbTienMat;
        private System.Windows.Forms.DataGridView dgvDonHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTenKhach;
        private System.Windows.Forms.ComboBox cbbSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbMangVe;
        private System.Windows.Forms.RadioButton rdbAnTaiCho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPhuongThuc;
        private System.Windows.Forms.RadioButton rdbGiaoHang;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panelKhachHang;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Panel panelThanhToan;
        private System.Windows.Forms.ComboBox cbbMaGiamGia;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel PanelOrder;
        private System.Windows.Forms.Panel panelThongTinOrder;
        private System.Windows.Forms.Button btnXoaMon;
        private System.Windows.Forms.Button btnThemMon;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbbTenMon;
        private System.Windows.Forms.ComboBox cbbDanhMucMon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.RichTextBox rtxtGhiChu;
        private System.Windows.Forms.ComboBox cbxSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RadioButton rdbNu;
        private System.Windows.Forms.RadioButton rdbNam;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label13;
    }
}