
namespace QLCHTAN
{
    partial class Oder_GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Oder_GUI));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnMenuDoAn = new System.Windows.Forms.ToolStripButton();
            this.tbtnThanhToan = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(90, 90);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnMenuDoAn,
            this.tbtnThanhToan});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.MaximumSize = new System.Drawing.Size(200, 480);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.ShowItemToolTips = false;
            this.toolStrip1.Size = new System.Drawing.Size(95, 473);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnMenuDoAn
            // 
            this.tbtnMenuDoAn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnMenuDoAn.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbtnMenuDoAn.Image = ((System.Drawing.Image)(resources.GetObject("tbtnMenuDoAn.Image")));
            this.tbtnMenuDoAn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnMenuDoAn.Name = "tbtnMenuDoAn";
            this.tbtnMenuDoAn.Size = new System.Drawing.Size(92, 94);
            this.tbtnMenuDoAn.Text = "Menu Đồ Ăn";
            this.tbtnMenuDoAn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tbtnMenuDoAn.Click += new System.EventHandler(this.tbtnMenuDoAn_Click);
            // 
            // tbtnThanhToan
            // 
            this.tbtnThanhToan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("tbtnThanhToan.Image")));
            this.tbtnThanhToan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnThanhToan.Name = "tbtnThanhToan";
            this.tbtnThanhToan.Size = new System.Drawing.Size(92, 94);
            this.tbtnThanhToan.Text = "Thanh Toán ";
            this.tbtnThanhToan.Click += new System.EventHandler(this.tbtnThanhToan_Click);
            // 
            // Oder_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(857, 473);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Candara", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Oder_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Oder_GUI";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripButton tbtnMenuDoAn;
        private System.Windows.Forms.ToolStripButton tbtnThanhToan;
        public System.Windows.Forms.ToolStrip toolStrip1;
    }
}