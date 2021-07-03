namespace Market_Programı
{
    partial class Yedekle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yedekle));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox15 = new System.Windows.Forms.GroupBox();
            this.groupBox17 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnYedekEkle = new System.Windows.Forms.Button();
            this.txtRestoreYolu = new System.Windows.Forms.TextBox();
            this.label35 = new System.Windows.Forms.Label();
            this.groupBox16 = new System.Windows.Forms.GroupBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnYoluKaydet = new System.Windows.Forms.Button();
            this.txtBackupYolu = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.btnGeri = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox15.SuspendLayout();
            this.groupBox17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(167, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(536, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "DOKUNMATİK MARKET PROGRAMI YEDEKLEME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(254, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Yedeklemek İstedğiniz Yeri Seçin";
            // 
            // groupBox15
            // 
            this.groupBox15.Controls.Add(this.groupBox17);
            this.groupBox15.Controls.Add(this.groupBox16);
            this.groupBox15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox15.ForeColor = System.Drawing.Color.Black;
            this.groupBox15.Location = new System.Drawing.Point(92, 182);
            this.groupBox15.Name = "groupBox15";
            this.groupBox15.Size = new System.Drawing.Size(720, 473);
            this.groupBox15.TabIndex = 25;
            this.groupBox15.TabStop = false;
            this.groupBox15.Text = "Yedekleme İşlemleri";
            // 
            // groupBox17
            // 
            this.groupBox17.Controls.Add(this.pictureBox1);
            this.groupBox17.Controls.Add(this.btnRestore);
            this.groupBox17.Controls.Add(this.btnYedekEkle);
            this.groupBox17.Controls.Add(this.txtRestoreYolu);
            this.groupBox17.Controls.Add(this.label35);
            this.groupBox17.ForeColor = System.Drawing.Color.Black;
            this.groupBox17.Location = new System.Drawing.Point(15, 252);
            this.groupBox17.Name = "groupBox17";
            this.groupBox17.Size = new System.Drawing.Size(685, 206);
            this.groupBox17.TabIndex = 0;
            this.groupBox17.TabStop = false;
            this.groupBox17.Text = "Restore Database";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Market_Programı.Properties.Resources.database_icon;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(11, 80);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 108);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnRestore
            // 
            this.btnRestore.BackgroundImage = global::Market_Programı.Properties.Resources.Fasticon_Database_Data_undo;
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRestore.Enabled = false;
            this.btnRestore.ForeColor = System.Drawing.Color.Black;
            this.btnRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestore.Location = new System.Drawing.Point(518, 90);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(154, 40);
            this.btnRestore.TabIndex = 3;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // btnYedekEkle
            // 
            this.btnYedekEkle.ForeColor = System.Drawing.Color.Black;
            this.btnYedekEkle.Image = global::Market_Programı.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.btnYedekEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYedekEkle.Location = new System.Drawing.Point(518, 44);
            this.btnYedekEkle.Name = "btnYedekEkle";
            this.btnYedekEkle.Size = new System.Drawing.Size(154, 40);
            this.btnYedekEkle.TabIndex = 2;
            this.btnYedekEkle.Text = "Ekle";
            this.btnYedekEkle.UseVisualStyleBackColor = true;
            this.btnYedekEkle.Click += new System.EventHandler(this.btnYedekEkle_Click);
            // 
            // txtRestoreYolu
            // 
            this.txtRestoreYolu.Location = new System.Drawing.Point(204, 44);
            this.txtRestoreYolu.Name = "txtRestoreYolu";
            this.txtRestoreYolu.Size = new System.Drawing.Size(308, 31);
            this.txtRestoreYolu.TabIndex = 1;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(6, 52);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(192, 25);
            this.label35.TabIndex = 0;
            this.label35.Text = "Yedekten Kaydet";
            // 
            // groupBox16
            // 
            this.groupBox16.Controls.Add(this.pictureBox2);
            this.groupBox16.Controls.Add(this.btnBackup);
            this.groupBox16.Controls.Add(this.btnYoluKaydet);
            this.groupBox16.Controls.Add(this.txtBackupYolu);
            this.groupBox16.Controls.Add(this.label34);
            this.groupBox16.ForeColor = System.Drawing.Color.Black;
            this.groupBox16.Location = new System.Drawing.Point(15, 30);
            this.groupBox16.Name = "groupBox16";
            this.groupBox16.Size = new System.Drawing.Size(685, 206);
            this.groupBox16.TabIndex = 0;
            this.groupBox16.TabStop = false;
            this.groupBox16.Text = "Backup Database";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Market_Programı.Properties.Resources.Database_Active_icon1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(11, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(154, 120);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnBackup
            // 
            this.btnBackup.BackgroundImage = global::Market_Programı.Properties.Resources.Fasticon_Database_Data_backup;
            this.btnBackup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBackup.Enabled = false;
            this.btnBackup.ForeColor = System.Drawing.Color.Black;
            this.btnBackup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBackup.Location = new System.Drawing.Point(518, 89);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(154, 40);
            this.btnBackup.TabIndex = 3;
            this.btnBackup.Text = "Backup";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnYoluKaydet
            // 
            this.btnYoluKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnYoluKaydet.Image = global::Market_Programı.Properties.Resources.Awicons_Vista_Artistic_Add;
            this.btnYoluKaydet.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoluKaydet.Location = new System.Drawing.Point(518, 43);
            this.btnYoluKaydet.Name = "btnYoluKaydet";
            this.btnYoluKaydet.Size = new System.Drawing.Size(154, 40);
            this.btnYoluKaydet.TabIndex = 2;
            this.btnYoluKaydet.Text = "Ekle";
            this.btnYoluKaydet.UseVisualStyleBackColor = true;
            this.btnYoluKaydet.Click += new System.EventHandler(this.btnYoluKaydet_Click);
            // 
            // txtBackupYolu
            // 
            this.txtBackupYolu.Location = new System.Drawing.Point(171, 46);
            this.txtBackupYolu.Name = "txtBackupYolu";
            this.txtBackupYolu.Size = new System.Drawing.Size(341, 31);
            this.txtBackupYolu.TabIndex = 1;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(6, 46);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(159, 25);
            this.label34.TabIndex = 0;
            this.label34.Text = "Yedek Kaydet";
            // 
            // btnGeri
            // 
            this.btnGeri.BackgroundImage = global::Market_Programı.Properties.Resources.Back_icon;
            this.btnGeri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGeri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGeri.Location = new System.Drawing.Point(725, 12);
            this.btnGeri.Name = "btnGeri";
            this.btnGeri.Size = new System.Drawing.Size(87, 74);
            this.btnGeri.TabIndex = 23;
            this.btnGeri.Text = "Geri";
            this.btnGeri.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGeri.UseVisualStyleBackColor = true;
            this.btnGeri.Click += new System.EventHandler(this.btnGeri_Click);
            // 
            // Yedekle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(898, 684);
            this.Controls.Add(this.groupBox15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGeri);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Yedekle";
            this.Text = "Yedekle";
            this.groupBox15.ResumeLayout(false);
            this.groupBox17.ResumeLayout(false);
            this.groupBox17.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox16.ResumeLayout(false);
            this.groupBox16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGeri;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox15;
        private System.Windows.Forms.GroupBox groupBox17;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnYedekEkle;
        private System.Windows.Forms.TextBox txtRestoreYolu;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.GroupBox groupBox16;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnYoluKaydet;
        private System.Windows.Forms.TextBox txtBackupYolu;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}