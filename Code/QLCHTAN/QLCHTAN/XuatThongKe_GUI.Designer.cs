
namespace QLCHTAN
{
    partial class XuatThongKe_GUI
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
            this.crvXuatThongKe = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crvXuatThongKe
            // 
            this.crvXuatThongKe.ActiveViewIndex = -1;
            this.crvXuatThongKe.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvXuatThongKe.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvXuatThongKe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crvXuatThongKe.Location = new System.Drawing.Point(0, 0);
            this.crvXuatThongKe.Name = "crvXuatThongKe";
            this.crvXuatThongKe.Size = new System.Drawing.Size(1047, 792);
            this.crvXuatThongKe.TabIndex = 0;
            this.crvXuatThongKe.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // XuatThongKe_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 792);
            this.Controls.Add(this.crvXuatThongKe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "XuatThongKe_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xuất thống kê";
            this.Load += new System.EventHandler(this.XuatThongKe_GUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvXuatThongKe;
    }
}