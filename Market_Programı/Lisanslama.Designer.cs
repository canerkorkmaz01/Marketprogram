namespace Market_Programı
{
    partial class Lisanslama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lisanslama));
            this.Lisans = new System.Windows.Forms.Label();
            this.txtAnahtarKodu = new System.Windows.Forms.TextBox();
            this.txtSirketAdi = new System.Windows.Forms.TextBox();
            this.txtLisansKodu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAktivasyon = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKpat = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lisans
            // 
            this.Lisans.AutoSize = true;
            this.Lisans.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lisans.ForeColor = System.Drawing.Color.Red;
            this.Lisans.Location = new System.Drawing.Point(142, 9);
            this.Lisans.Name = "Lisans";
            this.Lisans.Size = new System.Drawing.Size(336, 29);
            this.Lisans.TabIndex = 0;
            this.Lisans.Text = "LİSANS ANAHTARI GİRİNİZ";
            // 
            // txtAnahtarKodu
            // 
            this.txtAnahtarKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAnahtarKodu.Location = new System.Drawing.Point(147, 19);
            this.txtAnahtarKodu.Multiline = true;
            this.txtAnahtarKodu.Name = "txtAnahtarKodu";
            this.txtAnahtarKodu.Size = new System.Drawing.Size(436, 29);
            this.txtAnahtarKodu.TabIndex = 1;
            // 
            // txtSirketAdi
            // 
            this.txtSirketAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSirketAdi.Location = new System.Drawing.Point(147, 54);
            this.txtSirketAdi.Multiline = true;
            this.txtSirketAdi.Name = "txtSirketAdi";
            this.txtSirketAdi.Size = new System.Drawing.Size(436, 29);
            this.txtSirketAdi.TabIndex = 2;
            // 
            // txtLisansKodu
            // 
            this.txtLisansKodu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtLisansKodu.Location = new System.Drawing.Point(147, 89);
            this.txtLisansKodu.Multiline = true;
            this.txtLisansKodu.Name = "txtLisansKodu";
            this.txtLisansKodu.Size = new System.Drawing.Size(436, 29);
            this.txtLisansKodu.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(19, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Lisans Kodu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(19, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Şirket Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(19, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Anahtar Kodu";
            // 
            // btnAktivasyon
            // 
            this.btnAktivasyon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAktivasyon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAktivasyon.Image = global::Market_Programı.Properties.Resources.Anahtar;
            this.btnAktivasyon.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAktivasyon.Location = new System.Drawing.Point(147, 124);
            this.btnAktivasyon.Name = "btnAktivasyon";
            this.btnAktivasyon.Size = new System.Drawing.Size(436, 35);
            this.btnAktivasyon.TabIndex = 12;
            this.btnAktivasyon.Text = "Aktivasyon";
            this.btnAktivasyon.UseVisualStyleBackColor = true;
            this.btnAktivasyon.Click += new System.EventHandler(this.btnAktivasyon_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAktivasyon);
            this.panel1.Controls.Add(this.txtAnahtarKodu);
            this.panel1.Controls.Add(this.txtSirketAdi);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLisansKodu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 51);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(593, 217);
            this.panel1.TabIndex = 13;
            // 
            // btnKpat
            // 
            this.btnKpat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKpat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKpat.Image = global::Market_Programı.Properties.Resources.Custom_Icon_Design_Pretty_Office_6_Logout;
            this.btnKpat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKpat.Location = new System.Drawing.Point(155, 216);
            this.btnKpat.Name = "btnKpat";
            this.btnKpat.Size = new System.Drawing.Size(436, 40);
            this.btnKpat.TabIndex = 38;
            this.btnKpat.Text = "Çıkış";
            this.btnKpat.UseVisualStyleBackColor = true;
            this.btnKpat.Click += new System.EventHandler(this.btnKpat_Click);
            // 
            // Lisanslama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(616, 270);
            this.Controls.Add(this.btnKpat);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lisans);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Lisanslama";
            this.Text = "LİSANSLAMA";
            this.Load += new System.EventHandler(this.Lisanslama_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lisans;
        private System.Windows.Forms.TextBox txtAnahtarKodu;
        private System.Windows.Forms.TextBox txtSirketAdi;
        private System.Windows.Forms.TextBox txtLisansKodu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAktivasyon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKpat;
    }
}