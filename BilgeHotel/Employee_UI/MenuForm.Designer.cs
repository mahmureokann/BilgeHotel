namespace Employee_UI
{
    partial class MenuForm
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
            this.calisanMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.musteriMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tatilPaketleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odaTipleriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervasyonlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çalışanVardiyalarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calisanMenuToolStripMenuItem,
            this.musteriMenuToolStripMenuItem,
            this.tatilPaketleriToolStripMenuItem,
            this.odaTipleriToolStripMenuItem,
            this.rezervasyonlarToolStripMenuItem,
            this.çalışanVardiyalarıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // calisanMenuToolStripMenuItem
            // 
            this.calisanMenuToolStripMenuItem.Name = "calisanMenuToolStripMenuItem";
            this.calisanMenuToolStripMenuItem.Size = new System.Drawing.Size(111, 24);
            this.calisanMenuToolStripMenuItem.Text = "Calisan Menu";
            this.calisanMenuToolStripMenuItem.Click += new System.EventHandler(this.calisanMenuToolStripMenuItem_Click);
            // 
            // musteriMenuToolStripMenuItem
            // 
            this.musteriMenuToolStripMenuItem.Name = "musteriMenuToolStripMenuItem";
            this.musteriMenuToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.musteriMenuToolStripMenuItem.Text = "Musteri Menu";
            // 
            // tatilPaketleriToolStripMenuItem
            // 
            this.tatilPaketleriToolStripMenuItem.Name = "tatilPaketleriToolStripMenuItem";
            this.tatilPaketleriToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.tatilPaketleriToolStripMenuItem.Text = "Tatil Paketleri";
            // 
            // odaTipleriToolStripMenuItem
            // 
            this.odaTipleriToolStripMenuItem.Name = "odaTipleriToolStripMenuItem";
            this.odaTipleriToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.odaTipleriToolStripMenuItem.Text = "Oda Tipleri";
            // 
            // rezervasyonlarToolStripMenuItem
            // 
            this.rezervasyonlarToolStripMenuItem.Name = "rezervasyonlarToolStripMenuItem";
            this.rezervasyonlarToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.rezervasyonlarToolStripMenuItem.Text = "Rezervasyonlar";
            // 
            // çalışanVardiyalarıToolStripMenuItem
            // 
            this.çalışanVardiyalarıToolStripMenuItem.Name = "çalışanVardiyalarıToolStripMenuItem";
            this.çalışanVardiyalarıToolStripMenuItem.Size = new System.Drawing.Size(144, 24);
            this.çalışanVardiyalarıToolStripMenuItem.Text = "Çalışan Vardiyaları";
            this.çalışanVardiyalarıToolStripMenuItem.Click += new System.EventHandler(this.çalışanVardiyalarıToolStripMenuItem_Click);
            // 
            // MenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuForm";
            this.Text = "MenuForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem calisanMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem musteriMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tatilPaketleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odaTipleriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervasyonlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çalışanVardiyalarıToolStripMenuItem;
    }
}