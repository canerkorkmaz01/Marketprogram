namespace Market_Programı
{
    partial class Musteriİslemleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Musteriİslemleri));
            this.label8 = new System.Windows.Forms.Label();
            this.btnMusteriekle = new System.Windows.Forms.Button();
            this.btnMusteriHesaplari = new System.Windows.Forms.Button();
            this.btnTumBorçlar = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(137, 43);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(291, 32);
            this.label8.TabIndex = 26;
            this.label8.Text = "MÜŞTERİ İŞLEMLERİ";
            // 
            // btnMusteriekle
            // 
            this.btnMusteriekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriekle.Location = new System.Drawing.Point(66, 187);
            this.btnMusteriekle.Name = "btnMusteriekle";
            this.btnMusteriekle.Size = new System.Drawing.Size(187, 102);
            this.btnMusteriekle.TabIndex = 27;
            this.btnMusteriekle.Text = "MÜŞTERİ EKLE";
            this.btnMusteriekle.UseVisualStyleBackColor = true;
            this.btnMusteriekle.Click += new System.EventHandler(this.btnMusteriekle_Click);
            // 
            // btnMusteriHesaplari
            // 
            this.btnMusteriHesaplari.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMusteriHesaplari.Location = new System.Drawing.Point(336, 187);
            this.btnMusteriHesaplari.Name = "btnMusteriHesaplari";
            this.btnMusteriHesaplari.Size = new System.Drawing.Size(189, 102);
            this.btnMusteriHesaplari.TabIndex = 28;
            this.btnMusteriHesaplari.Text = "MÜŞTERİ HESAPLARI";
            this.btnMusteriHesaplari.UseVisualStyleBackColor = true;
            this.btnMusteriHesaplari.Click += new System.EventHandler(this.btnMusteriHesaplari_Click);
            // 
            // btnTumBorçlar
            // 
            this.btnTumBorçlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumBorçlar.Location = new System.Drawing.Point(195, 307);
            this.btnTumBorçlar.Name = "btnTumBorçlar";
            this.btnTumBorçlar.Size = new System.Drawing.Size(205, 106);
            this.btnTumBorçlar.TabIndex = 29;
            this.btnTumBorçlar.Text = "TÜM MÜŞTERİ BORÇLARI";
            this.btnTumBorçlar.UseVisualStyleBackColor = true;
            this.btnTumBorçlar.Click += new System.EventHandler(this.btnTumBorçlar_Click);
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::Market_Programı.Properties.Resources.Back_icon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(242, 80);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(105, 85);
            this.btnGeri.TabIndex = 25;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Musteriİslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(885, 541);
            this.Controls.Add(this.btnTumBorçlar);
            this.Controls.Add(this.btnMusteriHesaplari);
            this.Controls.Add(this.btnMusteriekle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Musteriİslemleri";
            this.Text = "MÜŞTERİ İŞLEMLERİ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnMusteriekle;
        private System.Windows.Forms.Button btnMusteriHesaplari;
        private System.Windows.Forms.Button btnTumBorçlar;
    }
}