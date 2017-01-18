namespace StockManagament
{
    partial class MusteriEkleForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxSoyadi = new System.Windows.Forms.TextBox();
            this.textBoxTelefon1 = new System.Windows.Forms.TextBox();
            this.textBoxTelefon2 = new System.Windows.Forms.TextBox();
            this.textBoxAdres = new System.Windows.Forms.TextBox();
            this.textBoxAciklama = new System.Windows.Forms.TextBox();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Soyadı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefon2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Açıklama";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(151, 22);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(368, 22);
            this.textBoxAdi.TabIndex = 6;
            // 
            // textBoxSoyadi
            // 
            this.textBoxSoyadi.Location = new System.Drawing.Point(151, 62);
            this.textBoxSoyadi.Name = "textBoxSoyadi";
            this.textBoxSoyadi.Size = new System.Drawing.Size(368, 22);
            this.textBoxSoyadi.TabIndex = 7;
            // 
            // textBoxTelefon1
            // 
            this.textBoxTelefon1.Location = new System.Drawing.Point(151, 99);
            this.textBoxTelefon1.Name = "textBoxTelefon1";
            this.textBoxTelefon1.Size = new System.Drawing.Size(368, 22);
            this.textBoxTelefon1.TabIndex = 8;
            // 
            // textBoxTelefon2
            // 
            this.textBoxTelefon2.Location = new System.Drawing.Point(151, 141);
            this.textBoxTelefon2.Name = "textBoxTelefon2";
            this.textBoxTelefon2.Size = new System.Drawing.Size(368, 22);
            this.textBoxTelefon2.TabIndex = 9;
            // 
            // textBoxAdres
            // 
            this.textBoxAdres.Location = new System.Drawing.Point(151, 180);
            this.textBoxAdres.Name = "textBoxAdres";
            this.textBoxAdres.Size = new System.Drawing.Size(368, 22);
            this.textBoxAdres.TabIndex = 10;
            // 
            // textBoxAciklama
            // 
            this.textBoxAciklama.Location = new System.Drawing.Point(151, 220);
            this.textBoxAciklama.Name = "textBoxAciklama";
            this.textBoxAciklama.Size = new System.Drawing.Size(368, 22);
            this.textBoxAciklama.TabIndex = 11;
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(151, 274);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(368, 75);
            this.buttonEkle.TabIndex = 12;
            this.buttonEkle.Text = "Ekle";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.button1_Click);
            // 
            // MusteriEkleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 385);
            this.Controls.Add(this.buttonEkle);
            this.Controls.Add(this.textBoxAciklama);
            this.Controls.Add(this.textBoxAdres);
            this.Controls.Add(this.textBoxTelefon2);
            this.Controls.Add(this.textBoxTelefon1);
            this.Controls.Add(this.textBoxSoyadi);
            this.Controls.Add(this.textBoxAdi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MusteriEkleForm";
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.TextBox textBoxSoyadi;
        private System.Windows.Forms.TextBox textBoxTelefon1;
        private System.Windows.Forms.TextBox textBoxTelefon2;
        private System.Windows.Forms.TextBox textBoxAdres;
        private System.Windows.Forms.TextBox textBoxAciklama;
        private System.Windows.Forms.Button buttonEkle;
    }
}