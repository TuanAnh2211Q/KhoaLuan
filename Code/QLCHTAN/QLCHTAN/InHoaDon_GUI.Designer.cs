
namespace QLCHTAN
{
    partial class InHoaDon_GUI
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
            this.crvInHoaDon = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.lblkThoat = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // crvInHoaDon
            // 
            this.crvInHoaDon.ActiveViewIndex = -1;
            this.crvInHoaDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crvInHoaDon.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crvInHoaDon.Cursor = System.Windows.Forms.Cursors.Default;
            this.crvInHoaDon.DisplayStatusBar = false;
            this.crvInHoaDon.Location = new System.Drawing.Point(3, 28);
            this.crvInHoaDon.Name = "crvInHoaDon";
            this.crvInHoaDon.Size = new System.Drawing.Size(785, 410);
            this.crvInHoaDon.TabIndex = 0;
            this.crvInHoaDon.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // lblkThoat
            // 
            this.lblkThoat.AutoSize = true;
            this.lblkThoat.Location = new System.Drawing.Point(733, 12);
            this.lblkThoat.Name = "lblkThoat";
            this.lblkThoat.Size = new System.Drawing.Size(35, 13);
            this.lblkThoat.TabIndex = 1;
            this.lblkThoat.TabStop = true;
            this.lblkThoat.Text = "Thoát";
            this.lblkThoat.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblkThoat_LinkClicked);
            // 
            // InHoaDon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblkThoat);
            this.Controls.Add(this.crvInHoaDon);
            this.Name = "InHoaDon_GUI";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "In hóa đơn";
            this.Load += new System.EventHandler(this.InHoaDon_GUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crvInHoaDon;
        private System.Windows.Forms.LinkLabel lblkThoat;
    }
}