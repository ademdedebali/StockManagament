namespace StockManagament
{
    partial class Form1
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veritabanıAçToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.veritabanınıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toptancıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriSilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.müşteriGüncelleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.müşteriToolStripMenuItem,
            this.toptancıToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(794, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veritabanıAçToolStripMenuItem,
            this.veritabanınıToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.dosyaToolStripMenuItem.Text = "Veritabanı";
            // 
            // veritabanıAçToolStripMenuItem
            // 
            this.veritabanıAçToolStripMenuItem.Name = "veritabanıAçToolStripMenuItem";
            this.veritabanıAçToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.veritabanıAçToolStripMenuItem.Text = "Veritabanı Aç";
            // 
            // veritabanınıToolStripMenuItem
            // 
            this.veritabanınıToolStripMenuItem.Name = "veritabanınıToolStripMenuItem";
            this.veritabanınıToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.veritabanınıToolStripMenuItem.Text = "Veritabanını ";
            // 
            // müşteriToolStripMenuItem
            // 
            this.müşteriToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.müşteriEkleToolStripMenuItem,
            this.müşteriSilToolStripMenuItem,
            this.müşteriGüncelleToolStripMenuItem});
            this.müşteriToolStripMenuItem.Name = "müşteriToolStripMenuItem";
            this.müşteriToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.müşteriToolStripMenuItem.Text = "Müşteri";
            // 
            // toptancıToolStripMenuItem
            // 
            this.toptancıToolStripMenuItem.Name = "toptancıToolStripMenuItem";
            this.toptancıToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.toptancıToolStripMenuItem.Text = "Toptancı";
            // 
            // müşteriEkleToolStripMenuItem
            // 
            this.müşteriEkleToolStripMenuItem.Name = "müşteriEkleToolStripMenuItem";
            this.müşteriEkleToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.müşteriEkleToolStripMenuItem.Text = "Müşteri Ekle";
            this.müşteriEkleToolStripMenuItem.Click += new System.EventHandler(this.müşteriEkleToolStripMenuItem_Click);
            // 
            // müşteriSilToolStripMenuItem
            // 
            this.müşteriSilToolStripMenuItem.Name = "müşteriSilToolStripMenuItem";
            this.müşteriSilToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.müşteriSilToolStripMenuItem.Text = "Müşteri Sil";
            // 
            // müşteriGüncelleToolStripMenuItem
            // 
            this.müşteriGüncelleToolStripMenuItem.Name = "müşteriGüncelleToolStripMenuItem";
            this.müşteriGüncelleToolStripMenuItem.Size = new System.Drawing.Size(194, 26);
            this.müşteriGüncelleToolStripMenuItem.Text = "Müşteri Güncelle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 439);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritabanıAçToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem veritabanınıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriSilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem müşteriGüncelleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toptancıToolStripMenuItem;
    }
}

