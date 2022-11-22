
namespace QLCHTAN
{
    partial class OrderDoAn_GUI
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
            this.flpDanhMucMonChinh = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flpDanhMucMonPhu = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flpDanhMucMonChinh
            // 
            this.flpDanhMucMonChinh.AutoScroll = true;
            this.flpDanhMucMonChinh.Location = new System.Drawing.Point(9, 47);
            this.flpDanhMucMonChinh.Name = "flpDanhMucMonChinh";
            this.flpDanhMucMonChinh.Size = new System.Drawing.Size(592, 332);
            this.flpDanhMucMonChinh.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 35);
            this.label1.TabIndex = 14;
            this.label1.Text = "Món Chính :";
            // 
            // flpDanhMucMonPhu
            // 
            this.flpDanhMucMonPhu.AutoScroll = true;
            this.flpDanhMucMonPhu.Location = new System.Drawing.Point(12, 444);
            this.flpDanhMucMonPhu.Name = "flpDanhMucMonPhu";
            this.flpDanhMucMonPhu.Size = new System.Drawing.Size(592, 193);
            this.flpDanhMucMonPhu.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Candara", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 391);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 35);
            this.label2.TabIndex = 16;
            this.label2.Text = "Món Phụ :";
            // 
            // OrderDoAn_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(613, 649);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.flpDanhMucMonPhu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flpDanhMucMonChinh);
            this.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "OrderDoAn_GUI";
            this.Text = "OrderDoAn_GUI";
            this.Load += new System.EventHandler(this.OrderDoAn_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flpDanhMucMonChinh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpDanhMucMonPhu;
        private System.Windows.Forms.Label label2;
    }
}