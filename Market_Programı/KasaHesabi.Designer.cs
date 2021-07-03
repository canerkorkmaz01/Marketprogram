namespace Market_Programı
{
    partial class KasaHesabi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KasaHesabi));
            this.btnKasaRaporu = new System.Windows.Forms.Button();
            this.btnKasaCikar = new System.Windows.Forms.Button();
            this.btnKasaEkle = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKasaRaporu
            // 
            this.btnKasaRaporu.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaRaporu.Location = new System.Drawing.Point(161, 333);
            this.btnKasaRaporu.Name = "btnKasaRaporu";
            this.btnKasaRaporu.Size = new System.Drawing.Size(201, 93);
            this.btnKasaRaporu.TabIndex = 34;
            this.btnKasaRaporu.Text = "KASA RAPORU";
            this.btnKasaRaporu.UseVisualStyleBackColor = true;
            this.btnKasaRaporu.Click += new System.EventHandler(this.btnKasaRaporu_Click);
            // 
            // btnKasaCikar
            // 
            this.btnKasaCikar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaCikar.Location = new System.Drawing.Point(301, 214);
            this.btnKasaCikar.Name = "btnKasaCikar";
            this.btnKasaCikar.Size = new System.Drawing.Size(129, 102);
            this.btnKasaCikar.TabIndex = 33;
            this.btnKasaCikar.Text = "KASA ÇIKAR";
            this.btnKasaCikar.UseVisualStyleBackColor = true;
            this.btnKasaCikar.Click += new System.EventHandler(this.btnKasaCikar_Click);
            // 
            // btnKasaEkle
            // 
            this.btnKasaEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKasaEkle.Location = new System.Drawing.Point(77, 214);
            this.btnKasaEkle.Name = "btnKasaEkle";
            this.btnKasaEkle.Size = new System.Drawing.Size(129, 102);
            this.btnKasaEkle.TabIndex = 32;
            this.btnKasaEkle.Text = "KASA EKLE";
            this.btnKasaEkle.UseVisualStyleBackColor = true;
            this.btnKasaEkle.Click += new System.EventHandler(this.btnKasaEkle_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(155, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 34);
            this.label8.TabIndex = 31;
            this.label8.Text = "KASA HESABI";
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::Market_Programı.Properties.Resources.Back_icon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(207, 107);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(105, 85);
            this.btnGeri.TabIndex = 30;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // KasaHesabi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(130)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(873, 519);
            this.Controls.Add(this.btnKasaRaporu);
            this.Controls.Add(this.btnKasaCikar);
            this.Controls.Add(this.btnKasaEkle);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KasaHesabi";
            this.Text = "KASA HESABI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKasaRaporu;
        private System.Windows.Forms.Button btnKasaCikar;
        private System.Windows.Forms.Button btnKasaEkle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGeri;
    }
}