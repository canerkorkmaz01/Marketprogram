namespace Market_Programı
{
    partial class HizliSatisKaldir
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnHizliSatisKaldir = new System.Windows.Forms.Button();
            this.cboHizliSatislar = new System.Windows.Forms.ComboBox();
            this.lblKapat = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnHizliSatisKaldir);
            this.groupBox1.Controls.Add(this.cboHizliSatislar);
            this.groupBox1.Controls.Add(this.lblKapat);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(244, 133);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Seçin";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Hızlı Satışa Kayıtlı Ürün";
            // 
            // btnHizliSatisKaldir
            // 
            this.btnHizliSatisKaldir.Location = new System.Drawing.Point(7, 91);
            this.btnHizliSatisKaldir.Name = "btnHizliSatisKaldir";
            this.btnHizliSatisKaldir.Size = new System.Drawing.Size(219, 37);
            this.btnHizliSatisKaldir.TabIndex = 2;
            this.btnHizliSatisKaldir.Text = "ÜRÜNÜ HIZLI SATIŞTAN KALDIR";
            this.btnHizliSatisKaldir.UseVisualStyleBackColor = true;
            this.btnHizliSatisKaldir.Click += new System.EventHandler(this.btnHizliSatisKaldir_Click);
            // 
            // cboHizliSatislar
            // 
            this.cboHizliSatislar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHizliSatislar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboHizliSatislar.FormattingEnabled = true;
            this.cboHizliSatislar.Location = new System.Drawing.Point(10, 53);
            this.cboHizliSatislar.Name = "cboHizliSatislar";
            this.cboHizliSatislar.Size = new System.Drawing.Size(216, 32);
            this.cboHizliSatislar.TabIndex = 1;
            this.cboHizliSatislar.Click += new System.EventHandler(this.cboHizliSatislar_Click);
            // 
            // lblKapat
            // 
            this.lblKapat.Image = global::Market_Programı.Properties.Resources.Close_2_icon1;
            this.lblKapat.Location = new System.Drawing.Point(181, 4);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(45, 46);
            this.lblKapat.TabIndex = 0;
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // HizliSatisKaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 140);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HizliSatisKaldir";
            this.Text = "HizliSatisKaldir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnHizliSatisKaldir;
        private System.Windows.Forms.ComboBox cboHizliSatislar;
        private System.Windows.Forms.Label lblKapat;
    }
}