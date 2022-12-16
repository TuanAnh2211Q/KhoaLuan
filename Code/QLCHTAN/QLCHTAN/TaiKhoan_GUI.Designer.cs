
namespace QLCHTAN
{
    partial class TaiKhoan_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaiKhoan_GUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblNhanVien = new System.Windows.Forms.Label();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbQuyen = new System.Windows.Forms.ComboBox();
            this.btnDatLaiMatKhau = new System.Windows.Forms.Button();
            this.btnGanQuyen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dgvTaiKhoan = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenTaiKhoan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maQuyen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTaiKhoan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblkDanhSachQuyen = new System.Windows.Forms.LinkLabel();
            this.lblID = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTenTaiKhoan);
            this.groupBox1.Controls.Add(this.lblNhanVien);
            this.groupBox1.Controls.Add(this.txtMatKhau);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cbbQuyen);
            this.groupBox1.Controls.Add(this.btnDatLaiMatKhau);
            this.groupBox1.Controls.Add(this.btnGanQuyen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(275, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tài khoản";
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(97, 60);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(0, 19);
            this.lblTenTaiKhoan.TabIndex = 58;
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.AutoSize = true;
            this.lblNhanVien.ForeColor = System.Drawing.Color.Red;
            this.lblNhanVien.Location = new System.Drawing.Point(96, 30);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(0, 19);
            this.lblNhanVien.TabIndex = 57;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatKhau.Location = new System.Drawing.Point(100, 86);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.PasswordChar = '*';
            this.txtMatKhau.Size = new System.Drawing.Size(161, 23);
            this.txtMatKhau.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(7, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 15);
            this.label4.TabIndex = 55;
            this.label4.Text = "Mật khẩu:";
            // 
            // cbbQuyen
            // 
            this.cbbQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbQuyen.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbQuyen.FormattingEnabled = true;
            this.cbbQuyen.Location = new System.Drawing.Point(100, 115);
            this.cbbQuyen.Name = "cbbQuyen";
            this.cbbQuyen.Size = new System.Drawing.Size(161, 23);
            this.cbbQuyen.TabIndex = 53;
            // 
            // btnDatLaiMatKhau
            // 
            this.btnDatLaiMatKhau.BackColor = System.Drawing.Color.White;
            this.btnDatLaiMatKhau.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDatLaiMatKhau.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatLaiMatKhau.Location = new System.Drawing.Point(97, 144);
            this.btnDatLaiMatKhau.Name = "btnDatLaiMatKhau";
            this.btnDatLaiMatKhau.Size = new System.Drawing.Size(164, 26);
            this.btnDatLaiMatKhau.TabIndex = 51;
            this.btnDatLaiMatKhau.Text = "Đặt lại mật khẩu";
            this.btnDatLaiMatKhau.UseVisualStyleBackColor = false;
            this.btnDatLaiMatKhau.Click += new System.EventHandler(this.btnDatLaiMatKhau_Click);
            // 
            // btnGanQuyen
            // 
            this.btnGanQuyen.BackColor = System.Drawing.Color.White;
            this.btnGanQuyen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGanQuyen.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGanQuyen.Location = new System.Drawing.Point(11, 144);
            this.btnGanQuyen.Name = "btnGanQuyen";
            this.btnGanQuyen.Size = new System.Drawing.Size(80, 26);
            this.btnGanQuyen.TabIndex = 50;
            this.btnGanQuyen.Text = "Gán quyền";
            this.btnGanQuyen.UseVisualStyleBackColor = false;
            this.btnGanQuyen.Click += new System.EventHandler(this.btnGanQuyen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quyền:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên tài khoản:";
            // 
            // dgvTaiKhoan
            // 
            this.dgvTaiKhoan.AllowUserToAddRows = false;
            this.dgvTaiKhoan.AllowUserToDeleteRows = false;
            this.dgvTaiKhoan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTaiKhoan.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.tenTaiKhoan,
            this.matKhau,
            this.maNhanVien,
            this.tenNhanVien,
            this.maQuyen});
            this.dgvTaiKhoan.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dgvTaiKhoan.Location = new System.Drawing.Point(307, 57);
            this.dgvTaiKhoan.Name = "dgvTaiKhoan";
            this.dgvTaiKhoan.ReadOnly = true;
            this.dgvTaiKhoan.Size = new System.Drawing.Size(579, 142);
            this.dgvTaiKhoan.TabIndex = 1;
            this.dgvTaiKhoan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTaiKhoan_CellClick);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // tenTaiKhoan
            // 
            this.tenTaiKhoan.DataPropertyName = "tenTaiKhoan";
            this.tenTaiKhoan.HeaderText = "Tên tài khoản";
            this.tenTaiKhoan.Name = "tenTaiKhoan";
            this.tenTaiKhoan.ReadOnly = true;
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật Khẩu";
            this.matKhau.Name = "matKhau";
            this.matKhau.ReadOnly = true;
            this.matKhau.Visible = false;
            // 
            // maNhanVien
            // 
            this.maNhanVien.DataPropertyName = "maNhanVien";
            this.maNhanVien.HeaderText = "Mã nhân viên";
            this.maNhanVien.Name = "maNhanVien";
            this.maNhanVien.ReadOnly = true;
            this.maNhanVien.Visible = false;
            // 
            // tenNhanVien
            // 
            this.tenNhanVien.DataPropertyName = "tenNhanVien";
            this.tenNhanVien.HeaderText = "Tên nhân viên";
            this.tenNhanVien.Name = "tenNhanVien";
            this.tenNhanVien.ReadOnly = true;
            // 
            // maQuyen
            // 
            this.maQuyen.DataPropertyName = "maQuyen";
            this.maQuyen.HeaderText = "Quyền";
            this.maQuyen.Name = "maQuyen";
            this.maQuyen.ReadOnly = true;
            // 
            // lblTaiKhoan
            // 
            this.lblTaiKhoan.AutoSize = true;
            this.lblTaiKhoan.ForeColor = System.Drawing.Color.Red;
            this.lblTaiKhoan.Location = new System.Drawing.Point(516, 23);
            this.lblTaiKhoan.Name = "lblTaiKhoan";
            this.lblTaiKhoan.Size = new System.Drawing.Size(169, 19);
            this.lblTaiKhoan.TabIndex = 2;
            this.lblTaiKhoan.Text = "DANH SÁCH TÀI KHOẢN";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(691, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblkDanhSachQuyen
            // 
            this.lblkDanhSachQuyen.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblkDanhSachQuyen.AutoSize = true;
            this.lblkDanhSachQuyen.Font = new System.Drawing.Font("Candara", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblkDanhSachQuyen.Location = new System.Drawing.Point(804, 38);
            this.lblkDanhSachQuyen.Name = "lblkDanhSachQuyen";
            this.lblkDanhSachQuyen.Size = new System.Drawing.Size(82, 13);
            this.lblkDanhSachQuyen.TabIndex = 4;
            this.lblkDanhSachQuyen.TabStop = true;
            this.lblkDanhSachQuyen.Text = "Thông tin quyền";
            this.lblkDanhSachQuyen.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkDanhSachQuyen_LinkClicked);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(303, 186);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(0, 19);
            this.lblID.TabIndex = 5;
            this.lblID.Visible = false;
            // 
            // TaiKhoan_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(898, 206);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblkDanhSachQuyen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTaiKhoan);
            this.Controls.Add(this.dgvTaiKhoan);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TaiKhoan_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "TaiKhoan";
            this.Load += new System.EventHandler(this.TaiKhoan_GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTaiKhoan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dgvTaiKhoan;
        private System.Windows.Forms.ComboBox cbbQuyen;
        private System.Windows.Forms.Button btnDatLaiMatKhau;
        private System.Windows.Forms.Button btnGanQuyen;
        private System.Windows.Forms.Label lblTaiKhoan;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lblkDanhSachQuyen;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenNhanVien;
        private System.Windows.Forms.DataGridViewTextBoxColumn maQuyen;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblNhanVien;
        private System.Windows.Forms.Label lblID;
    }
}