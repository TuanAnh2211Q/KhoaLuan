
namespace QLCHTAN
{
    partial class BackUp_Restore_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackUp_Restore_GUI));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNgatKetNoi = new System.Windows.Forms.Button();
            this.btnKetNoi = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grbBackUp = new System.Windows.Forms.GroupBox();
            this.cbbDatabase = new System.Windows.Forms.ComboBox();
            this.btnMoThuMucBackUp = new System.Windows.Forms.Button();
            this.btnBackUpDBS = new System.Windows.Forms.Button();
            this.grbRestore = new System.Windows.Forms.GroupBox();
            this.btnRestoreDataBase = new System.Windows.Forms.Button();
            this.btnChonThuMucRestore = new System.Windows.Forms.Button();
            this.txtNoiBackUp = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtRestoreDBS = new System.Windows.Forms.TextBox();
            this.cbbTenServer = new System.Windows.Forms.ComboBox();
            this.fbrBackUp = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox1.SuspendLayout();
            this.grbBackUp.SuspendLayout();
            this.grbRestore.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbTenServer);
            this.groupBox1.Controls.Add(this.btnNgatKetNoi);
            this.groupBox1.Controls.Add(this.btnKetNoi);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(593, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn tên server:";
            // 
            // btnNgatKetNoi
            // 
            this.btnNgatKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNgatKetNoi.Location = new System.Drawing.Point(492, 63);
            this.btnNgatKetNoi.Name = "btnNgatKetNoi";
            this.btnNgatKetNoi.Size = new System.Drawing.Size(89, 23);
            this.btnNgatKetNoi.TabIndex = 2;
            this.btnNgatKetNoi.Text = "Ngắt kết nối";
            this.btnNgatKetNoi.UseVisualStyleBackColor = true;
            this.btnNgatKetNoi.Click += new System.EventHandler(this.btnNgatKetNoi_Click);
            // 
            // btnKetNoi
            // 
            this.btnKetNoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKetNoi.Location = new System.Drawing.Point(411, 63);
            this.btnKetNoi.Name = "btnKetNoi";
            this.btnKetNoi.Size = new System.Drawing.Size(75, 23);
            this.btnKetNoi.TabIndex = 1;
            this.btnKetNoi.Text = "Kết nối";
            this.btnKetNoi.UseVisualStyleBackColor = true;
            this.btnKetNoi.Click += new System.EventHandler(this.btnKetNoi_Click);
            // 
            // grbBackUp
            // 
            this.grbBackUp.Controls.Add(this.txtNoiBackUp);
            this.grbBackUp.Controls.Add(this.btnMoThuMucBackUp);
            this.grbBackUp.Controls.Add(this.btnBackUpDBS);
            this.grbBackUp.Enabled = false;
            this.grbBackUp.Location = new System.Drawing.Point(12, 206);
            this.grbBackUp.Name = "grbBackUp";
            this.grbBackUp.Size = new System.Drawing.Size(593, 87);
            this.grbBackUp.TabIndex = 1;
            this.grbBackUp.TabStop = false;
            this.grbBackUp.Text = "Back up Database";
            // 
            // cbbDatabase
            // 
            this.cbbDatabase.Enabled = false;
            this.cbbDatabase.FormattingEnabled = true;
            this.cbbDatabase.Location = new System.Drawing.Point(7, 22);
            this.cbbDatabase.Name = "cbbDatabase";
            this.cbbDatabase.Size = new System.Drawing.Size(580, 23);
            this.cbbDatabase.TabIndex = 3;
            this.cbbDatabase.SelectedIndexChanged += new System.EventHandler(this.cbbDatabase_SelectedIndexChanged);
            // 
            // btnMoThuMucBackUp
            // 
            this.btnMoThuMucBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoThuMucBackUp.Location = new System.Drawing.Point(398, 58);
            this.btnMoThuMucBackUp.Name = "btnMoThuMucBackUp";
            this.btnMoThuMucBackUp.Size = new System.Drawing.Size(108, 23);
            this.btnMoThuMucBackUp.TabIndex = 2;
            this.btnMoThuMucBackUp.Text = "Chọn thư mục";
            this.btnMoThuMucBackUp.UseVisualStyleBackColor = true;
            this.btnMoThuMucBackUp.Click += new System.EventHandler(this.btnMoThuMucBackUp_Click);
            // 
            // btnBackUpDBS
            // 
            this.btnBackUpDBS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackUpDBS.Location = new System.Drawing.Point(512, 58);
            this.btnBackUpDBS.Name = "btnBackUpDBS";
            this.btnBackUpDBS.Size = new System.Drawing.Size(75, 23);
            this.btnBackUpDBS.TabIndex = 1;
            this.btnBackUpDBS.Text = "BackUp";
            this.btnBackUpDBS.UseVisualStyleBackColor = true;
            this.btnBackUpDBS.Click += new System.EventHandler(this.btnBackUpDBS_Click);
            // 
            // grbRestore
            // 
            this.grbRestore.Controls.Add(this.txtRestoreDBS);
            this.grbRestore.Controls.Add(this.btnRestoreDataBase);
            this.grbRestore.Controls.Add(this.btnChonThuMucRestore);
            this.grbRestore.Enabled = false;
            this.grbRestore.Location = new System.Drawing.Point(12, 299);
            this.grbRestore.Name = "grbRestore";
            this.grbRestore.Size = new System.Drawing.Size(593, 87);
            this.grbRestore.TabIndex = 2;
            this.grbRestore.TabStop = false;
            this.grbRestore.Text = "Restore Database:";
            // 
            // btnRestoreDataBase
            // 
            this.btnRestoreDataBase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRestoreDataBase.Location = new System.Drawing.Point(512, 58);
            this.btnRestoreDataBase.Name = "btnRestoreDataBase";
            this.btnRestoreDataBase.Size = new System.Drawing.Size(75, 23);
            this.btnRestoreDataBase.TabIndex = 2;
            this.btnRestoreDataBase.Text = "Phục hồi";
            this.btnRestoreDataBase.UseVisualStyleBackColor = true;
            this.btnRestoreDataBase.Click += new System.EventHandler(this.btnRestoreDataBase_Click);
            // 
            // btnChonThuMucRestore
            // 
            this.btnChonThuMucRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChonThuMucRestore.Location = new System.Drawing.Point(398, 58);
            this.btnChonThuMucRestore.Name = "btnChonThuMucRestore";
            this.btnChonThuMucRestore.Size = new System.Drawing.Size(108, 23);
            this.btnChonThuMucRestore.TabIndex = 1;
            this.btnChonThuMucRestore.Text = "Chọn thư mục";
            this.btnChonThuMucRestore.UseVisualStyleBackColor = true;
            this.btnChonThuMucRestore.Click += new System.EventHandler(this.btnChonThuMucRestore_Click);
            // 
            // txtNoiBackUp
            // 
            this.txtNoiBackUp.Location = new System.Drawing.Point(7, 29);
            this.txtNoiBackUp.Name = "txtNoiBackUp";
            this.txtNoiBackUp.Size = new System.Drawing.Size(581, 23);
            this.txtNoiBackUp.TabIndex = 3;
            this.txtNoiBackUp.TextChanged += new System.EventHandler(this.txtNoiBackUp_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cbbDatabase);
            this.groupBox4.Location = new System.Drawing.Point(12, 112);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(593, 88);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Chọn database:";
            // 
            // txtRestoreDBS
            // 
            this.txtRestoreDBS.Location = new System.Drawing.Point(6, 32);
            this.txtRestoreDBS.Name = "txtRestoreDBS";
            this.txtRestoreDBS.Size = new System.Drawing.Size(581, 23);
            this.txtRestoreDBS.TabIndex = 4;
            this.txtRestoreDBS.TextChanged += new System.EventHandler(this.txtRestoreDBS_TextChanged);
            // 
            // cbbTenServer
            // 
            this.cbbTenServer.FormattingEnabled = true;
            this.cbbTenServer.Location = new System.Drawing.Point(17, 36);
            this.cbbTenServer.Name = "cbbTenServer";
            this.cbbTenServer.Size = new System.Drawing.Size(564, 23);
            this.cbbTenServer.TabIndex = 3;
            // 
            // fbrBackUp
            // 
            this.fbrBackUp.SelectedPath = "C:\\Users\\tuana\\OneDrive\\Documents\\QLCHTAN_BACKUP";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "ofdRestore";
            // 
            // BackUp_Restore_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(618, 397);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.grbRestore);
            this.Controls.Add(this.grbBackUp);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BackUp_Restore_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BackUp_Restore";
            this.Load += new System.EventHandler(this.BackUp_Restore_GUI_Load);
            this.groupBox1.ResumeLayout(false);
            this.grbBackUp.ResumeLayout(false);
            this.grbBackUp.PerformLayout();
            this.grbRestore.ResumeLayout(false);
            this.grbRestore.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnNgatKetNoi;
        private System.Windows.Forms.Button btnKetNoi;
        private System.Windows.Forms.GroupBox grbBackUp;
        private System.Windows.Forms.ComboBox cbbDatabase;
        private System.Windows.Forms.Button btnMoThuMucBackUp;
        private System.Windows.Forms.Button btnBackUpDBS;
        private System.Windows.Forms.GroupBox grbRestore;
        private System.Windows.Forms.Button btnRestoreDataBase;
        private System.Windows.Forms.Button btnChonThuMucRestore;
        private System.Windows.Forms.TextBox txtNoiBackUp;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox txtRestoreDBS;
        private System.Windows.Forms.ComboBox cbbTenServer;
        private System.Windows.Forms.FolderBrowserDialog fbrBackUp;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}