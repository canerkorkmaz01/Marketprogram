namespace Market_Programı
{
    partial class Yardım
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yardım));
            this.lstBilgi = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.btnYazi = new System.Windows.Forms.Button();
            this.btnUzakYardim = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstBilgi
            // 
            this.lstBilgi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(199)))));
            this.lstBilgi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lstBilgi.FormattingEnabled = true;
            this.lstBilgi.ItemHeight = 24;
            this.lstBilgi.Items.AddRange(new object[] {
            "KATEGORİ EKLE",
            "KATEGORİ GÜNCELLE",
            "TOPTANCI EKLE",
            "TOPTANCI GÜNCELLE",
            "ÜRÜN EKLE",
            "ÜRÜN GÜNCELLE",
            "ÜRÜN SİL",
            "BARKODA GÖRE ARAMA",
            "ÜRÜN ADINA GÖRE ARAMA",
            "RAPOR ALMA",
            "MÜŞTERİ HESAPLARI",
            "TOPTANCI HESAPLARI",
            "EXCEL\'E AKATARMA",
            "KORSAN PROGRAM KULLANIMI",
            "YEDEKLEME",
            "LİSANS ALMA",
            "İLETİŞİM"});
            this.lstBilgi.Location = new System.Drawing.Point(12, 94);
            this.lstBilgi.Name = "lstBilgi";
            this.lstBilgi.Size = new System.Drawing.Size(342, 484);
            this.lstBilgi.TabIndex = 0;
            this.lstBilgi.SelectedIndexChanged += new System.EventHandler(this.lstBilgi_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(147, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(546, 29);
            this.label8.TabIndex = 38;
            this.label8.Text = "DOKUNMATİ MARKET PROGRAMI KULLANIMI";
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::Market_Programı.Properties.Resources.Back_icon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(699, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(70, 71);
            this.btnGeri.TabIndex = 37;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // btnYazi
            // 
            this.btnYazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYazi.Location = new System.Drawing.Point(360, 94);
            this.btnYazi.Name = "btnYazi";
            this.btnYazi.Size = new System.Drawing.Size(683, 484);
            this.btnYazi.TabIndex = 39;
            this.btnYazi.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnYazi.UseVisualStyleBackColor = true;
            // 
            // btnUzakYardim
            // 
            this.btnUzakYardim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUzakYardim.ForeColor = System.Drawing.Color.Blue;
            this.btnUzakYardim.Location = new System.Drawing.Point(12, 584);
            this.btnUzakYardim.Name = "btnUzakYardim";
            this.btnUzakYardim.Size = new System.Drawing.Size(1031, 40);
            this.btnUzakYardim.TabIndex = 40;
            this.btnUzakYardim.Text = "TEKNİK DESTEK UZAK MASAÜSTÜ YARDIM PROGRAMINI İNDİRMEK İÇİN";
            this.btnUzakYardim.UseVisualStyleBackColor = true;
            this.btnUzakYardim.Click += new System.EventHandler(this.btnUzakYardim_Click);
            // 
            // Yardım
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(1047, 688);
            this.Controls.Add(this.btnUzakYardim);
            this.Controls.Add(this.btnYazi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.lstBilgi);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yardım";
            this.Text = "YARDIM";
            this.Load += new System.EventHandler(this.Yardım_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstBilgi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Button btnYazi;
        private System.Windows.Forms.Button btnUzakYardim;
    }
}