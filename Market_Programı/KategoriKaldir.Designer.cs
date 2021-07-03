namespace Market_Programı
{
    partial class KategoriKaldir
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
            this.lblKapat = new System.Windows.Forms.Label();
            this.cboKategoriler = new System.Windows.Forms.ComboBox();
            this.btnKategoriKaldir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnKategoriKaldir);
            this.groupBox1.Controls.Add(this.cboKategoriler);
            this.groupBox1.Controls.Add(this.lblKapat);
            this.groupBox1.Location = new System.Drawing.Point(5, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 138);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Seçin";
            // 
            // lblKapat
            // 
            this.lblKapat.Image = global::Market_Programı.Properties.Resources.Close_2_icon1;
            this.lblKapat.Location = new System.Drawing.Point(175, 16);
            this.lblKapat.Name = "lblKapat";
            this.lblKapat.Size = new System.Drawing.Size(49, 46);
            this.lblKapat.TabIndex = 0;
            this.lblKapat.Click += new System.EventHandler(this.lblKapat_Click);
            // 
            // cboKategoriler
            // 
            this.cboKategoriler.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cboKategoriler.FormattingEnabled = true;
            this.cboKategoriler.Location = new System.Drawing.Point(10, 44);
            this.cboKategoriler.Name = "cboKategoriler";
            this.cboKategoriler.Size = new System.Drawing.Size(159, 32);
            this.cboKategoriler.TabIndex = 1;
            this.cboKategoriler.Click += new System.EventHandler(this.cboKategoriler_Click);
            // 
            // btnKategoriKaldir
            // 
            this.btnKategoriKaldir.Location = new System.Drawing.Point(7, 91);
            this.btnKategoriKaldir.Name = "btnKategoriKaldir";
            this.btnKategoriKaldir.Size = new System.Drawing.Size(159, 37);
            this.btnKategoriKaldir.TabIndex = 2;
            this.btnKategoriKaldir.Text = "KATEGORİ KALDIR";
            this.btnKategoriKaldir.UseVisualStyleBackColor = true;
            this.btnKategoriKaldir.Click += new System.EventHandler(this.btnKategoriKaldir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(7, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Kategoriler";
            // 
            // KategoriKaldir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(242, 146);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "KategoriKaldir";
            this.ShowIcon = false;
            this.Text = "KategoriKaldir";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblKapat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnKategoriKaldir;
        private System.Windows.Forms.ComboBox cboKategoriler;
    }
}