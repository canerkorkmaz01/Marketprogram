namespace Market_Programı
{
    partial class Toptanciİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Toptanciİslemleri));
            this.label8 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnTumBorçlar = new System.Windows.Forms.Button();
            this.btnToptanciHesaplari = new System.Windows.Forms.Button();
            this.bntToptanciEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(133, 44);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(321, 34);
            this.label8.TabIndex = 28;
            this.label8.Text = "TOPTANCI İŞLEMLERİ";
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::Market_Programı.Properties.Resources.Back_icon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(239, 81);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(105, 85);
            this.btnGeri.TabIndex = 27;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnTumBorçlar
            // 
            this.btnTumBorçlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumBorçlar.Location = new System.Drawing.Point(181, 311);
            this.btnTumBorçlar.Name = "btnTumBorçlar";
            this.btnTumBorçlar.Size = new System.Drawing.Size(221, 106);
            this.btnTumBorçlar.TabIndex = 32;
            this.btnTumBorçlar.Text = "TÜM TOPTANCI BORÇLARI";
            this.btnTumBorçlar.UseVisualStyleBackColor = true;
            this.btnTumBorçlar.Click += new System.EventHandler(this.btnTumBorçlar_Click);
            // 
            // btnToptanciHesaplari
            // 
            this.btnToptanciHesaplari.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToptanciHesaplari.Location = new System.Drawing.Point(345, 185);
            this.btnToptanciHesaplari.Name = "btnToptanciHesaplari";
            this.btnToptanciHesaplari.Size = new System.Drawing.Size(161, 105);
            this.btnToptanciHesaplari.TabIndex = 31;
            this.btnToptanciHesaplari.Text = "TOPTANCI HESAPLARI";
            this.btnToptanciHesaplari.UseVisualStyleBackColor = true;
            this.btnToptanciHesaplari.Click += new System.EventHandler(this.btnToptanciHesaplari_Click);
            // 
            // bntToptanciEkle
            // 
            this.bntToptanciEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bntToptanciEkle.Location = new System.Drawing.Point(76, 185);
            this.bntToptanciEkle.Name = "bntToptanciEkle";
            this.bntToptanciEkle.Size = new System.Drawing.Size(161, 105);
            this.bntToptanciEkle.TabIndex = 30;
            this.bntToptanciEkle.Text = "TOPTANCI EKLE";
            this.bntToptanciEkle.UseVisualStyleBackColor = true;
            this.bntToptanciEkle.Click += new System.EventHandler(this.bntToptanciEkle_Click);
            // 
            // Toptanciİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(887, 536);
            this.Controls.Add(this.btnTumBorçlar);
            this.Controls.Add(this.btnToptanciHesaplari);
            this.Controls.Add(this.bntToptanciEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Toptanciİslemleri";
            this.Text = "TOPTANCI İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnTumBorçlar;
        private System.Windows.Forms.Button btnToptanciHesaplari;
        private System.Windows.Forms.Button bntToptanciEkle;
    }
}