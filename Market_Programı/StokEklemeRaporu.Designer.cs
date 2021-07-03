namespace Market_Programı
{
    partial class StokEklemeRaporu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StokEklemeRaporu));
            this.btnGeri = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSonBirYıl = new System.Windows.Forms.Button();
            this.btnSonOtuzGün = new System.Windows.Forms.Button();
            this.btnBirHafta = new System.Windows.Forms.Button();
            this.btnBugün = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.dtpİlkTarih = new System.Windows.Forms.DateTimePicker();
            this.btnRaprAl = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::Market_Programı.Properties.Resources.Back_icon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(530, 8);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(70, 71);
            this.btnGeri.TabIndex = 32;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(209, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(439, 37);
            this.label8.TabIndex = 31;
            this.label8.Text = "STOK EKLEME RAPORLARI";
            // 
            // btnSonBirYıl
            // 
            this.btnSonBirYıl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonBirYıl.ForeColor = System.Drawing.Color.Blue;
            this.btnSonBirYıl.Location = new System.Drawing.Point(557, 224);
            this.btnSonBirYıl.Name = "btnSonBirYıl";
            this.btnSonBirYıl.Size = new System.Drawing.Size(87, 41);
            this.btnSonBirYıl.TabIndex = 30;
            this.btnSonBirYıl.Text = "&SON 1 YIL";
            this.btnSonBirYıl.UseVisualStyleBackColor = true;
            this.btnSonBirYıl.Click += new System.EventHandler(this.btnSonBirYıl_Click);
            // 
            // btnSonOtuzGün
            // 
            this.btnSonOtuzGün.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSonOtuzGün.ForeColor = System.Drawing.Color.Blue;
            this.btnSonOtuzGün.Location = new System.Drawing.Point(441, 224);
            this.btnSonOtuzGün.Name = "btnSonOtuzGün";
            this.btnSonOtuzGün.Size = new System.Drawing.Size(110, 41);
            this.btnSonOtuzGün.TabIndex = 29;
            this.btnSonOtuzGün.Text = "&SON 30 GÜN";
            this.btnSonOtuzGün.UseVisualStyleBackColor = true;
            this.btnSonOtuzGün.Click += new System.EventHandler(this.btnSonOtuzGün_Click);
            // 
            // btnBirHafta
            // 
            this.btnBirHafta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBirHafta.ForeColor = System.Drawing.Color.Blue;
            this.btnBirHafta.Location = new System.Drawing.Point(304, 224);
            this.btnBirHafta.Name = "btnBirHafta";
            this.btnBirHafta.Size = new System.Drawing.Size(131, 41);
            this.btnBirHafta.TabIndex = 27;
            this.btnBirHafta.Text = "&SON BİR HAFTA";
            this.btnBirHafta.UseVisualStyleBackColor = true;
            this.btnBirHafta.Click += new System.EventHandler(this.btnBirHafta_Click);
            // 
            // btnBugün
            // 
            this.btnBugün.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBugün.ForeColor = System.Drawing.Color.Blue;
            this.btnBugün.Location = new System.Drawing.Point(216, 224);
            this.btnBugün.Name = "btnBugün";
            this.btnBugün.Size = new System.Drawing.Size(82, 41);
            this.btnBugün.TabIndex = 26;
            this.btnBugün.Text = "&BUGÜN";
            this.btnBugün.UseVisualStyleBackColor = true;
            this.btnBugün.Click += new System.EventHandler(this.btnBugün_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpSonTarih);
            this.groupBox1.Controls.Add(this.dtpİlkTarih);
            this.groupBox1.Controls.Add(this.btnRaprAl);
            this.groupBox1.Location = new System.Drawing.Point(216, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(428, 175);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "TARİHLER ARASI RAPOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(275, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Son Tarih";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "İlk Tarih";
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonTarih.Location = new System.Drawing.Point(278, 56);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(119, 20);
            this.dtpSonTarih.TabIndex = 2;
            // 
            // dtpİlkTarih
            // 
            this.dtpİlkTarih.Checked = false;
            this.dtpİlkTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpİlkTarih.Location = new System.Drawing.Point(18, 56);
            this.dtpİlkTarih.Name = "dtpİlkTarih";
            this.dtpİlkTarih.Size = new System.Drawing.Size(119, 20);
            this.dtpİlkTarih.TabIndex = 1;
            // 
            // btnRaprAl
            // 
            this.btnRaprAl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRaprAl.ForeColor = System.Drawing.Color.Blue;
            this.btnRaprAl.Location = new System.Drawing.Point(18, 109);
            this.btnRaprAl.Name = "btnRaprAl";
            this.btnRaprAl.Size = new System.Drawing.Size(379, 45);
            this.btnRaprAl.TabIndex = 0;
            this.btnRaprAl.Text = "&RAPOR";
            this.btnRaprAl.UseVisualStyleBackColor = true;
            this.btnRaprAl.Click += new System.EventHandler(this.btnRaprAl_Click);
            // 
            // StokEklemeRaporu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(195)))), ((int)(((byte)(254)))));
            this.ClientSize = new System.Drawing.Size(906, 515);
            this.Controls.Add(this.btnGeri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnSonBirYıl);
            this.Controls.Add(this.btnSonOtuzGün);
            this.Controls.Add(this.btnBirHafta);
            this.Controls.Add(this.btnBugün);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StokEklemeRaporu";
            this.Text = "STOK EKLEME RAPORLARI";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSonBirYıl;
        private System.Windows.Forms.Button btnSonOtuzGün;
        private System.Windows.Forms.Button btnBirHafta;
        private System.Windows.Forms.Button btnBugün;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.DateTimePicker dtpİlkTarih;
        private System.Windows.Forms.Button btnRaprAl;
    }
}