namespace Employee_UI
{
    partial class CalisanMenuForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.calisanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatilPaketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calisanVardiyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calisanToolStripMenuItem,
            this.musteriMenuToolStripMenuItem,
            this.tatilPaketleriToolStripMenuItem,
            this.odaTipleriToolStripMenuItem,
            this.rezervasyonToolStripMenuItem,
            this.calisanVardiyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calisanToolStripMenuItem
            // 
            this.calisanToolStripMenuItem.Name = "calisanToolStripMenuItem";
            this.calisanToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.calisanToolStripMenuItem.Text = "Calisan Menu";
            this.calisanToolStripMenuItem.Click += new System.EventHandler(this.calisanToolStripMenuItem_Click);
            // 
            // musteriMenuToolStripMenuItem
            // 
            this.musteriMenuToolStripMenuItem.Name = "musteriMenuToolStripMenuItem";
            this.musteriMenuToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.musteriMenuToolStripMenuItem.Text = "Musteri Menu";
            this.musteriMenuToolStripMenuItem.Click += new System.EventHandler(this.musteriMenuToolStripMenuItem_Click);
            // 
            // tatilPaketleriToolStripMenuItem
            // 
            this.tatilPaketleriToolStripMenuItem.Name = "tatilPaketleriToolStripMenuItem";
            this.tatilPaketleriToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.tatilPaketleriToolStripMenuItem.Text = "Tatil Paketleri";
            this.tatilPaketleriToolStripMenuItem.Click += new System.EventHandler(this.tatilPaketleriToolStripMenuItem_Click);
            // 
            // odaTipleriToolStripMenuItem
            // 
            this.odaTipleriToolStripMenuItem.Name = "odaTipleriToolStripMenuItem";
            this.odaTipleriToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.odaTipleriToolStripMenuItem.Text = "Oda Tipleri";
            this.odaTipleriToolStripMenuItem.Click += new System.EventHandler(this.odaTipleriToolStripMenuItem_Click);
            // 
            // rezervasyonToolStripMenuItem
            // 
            this.rezervasyonToolStripMenuItem.Name = "rezervasyonToolStripMenuItem";
            this.rezervasyonToolStripMenuItem.Size = new System.Drawing.Size(109, 24);
            this.rezervasyonToolStripMenuItem.Text = "Rezervasyon ";
            this.rezervasyonToolStripMenuItem.Click += new System.EventHandler(this.rezervasyonToolStripMenuItem_Click);
            // 
            // calisanVardiyaToolStripMenuItem
            // 
            this.calisanVardiyaToolStripMenuItem.Name = "calisanVardiyaToolStripMenuItem";
            this.calisanVardiyaToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.calisanVardiyaToolStripMenuItem.Text = "Calisan Vardiya";
            this.calisanVardiyaToolStripMenuItem.Click += new System.EventHandler(this.calisanVardiyaToolStripMenuItem_Click);
            // 
            // CalisanMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CalisanMenuForm";
            this.Text = "CalisanMenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calisanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatilPaketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calisanVardiyaToolStripMenuItem;
    }
}