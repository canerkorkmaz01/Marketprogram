using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class Kullaniciİslemleri : Form
    {
        public Kullaniciİslemleri()
        {
            InitializeComponent();
        }

        /// <summary>
        /// DatagridView deki Seçilen Bilgileri Textbox Aktarır
        /// </summary>
        private void Bilgiler()
        {
            txtKullaniciAdi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtSifre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txtAdi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtSoyadi.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtGorevi.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        /// <summary>
        /// Textbox İşlem Bittikten Sonra Temzileme İşlemi Yapar
        /// </summary>
        private void Clear()
        {
            foreach (Control txt in this.Controls)
            {
                if (txt is TextBox)
                {
                    txt.Text = string.Empty;
                }
            }
        }
        private void Kullaniciİslemleri_Load(object sender, EventArgs e)
        {
            Cozunurluk c = new Cozunurluk();
            c.Boyut(this);
            dataGridView1.DataSource = PersonellerORM.Personeller();
            Tables.DataGridViewPersoneller(dataGridView1);
            cboYetki.DataSource = PersonellerORM.KullaniciTipi();
            cboYetki.DisplayMember = "KullaniciTipi";
            cboYetki.ValueMember = "TipId";
        }

        /// <summary>
        /// Girirlen Bilgileri Varitabanına Kaydeder
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                PersonellerORM pORM = new PersonellerORM();
                Personeller p = new Personeller();
                p.TipID = (int)cboYetki.SelectedValue;
                p.Adi = txtAdi.Text;
                p.Soyadi = txtSoyadi.Text;
                p.Unvani = txtGorevi.Text;
                p.KAdi = txtKullaniciAdi.Text;
                p.Sifre = txtSifre.Text;
                bool deger = pORM.KullaniciEkle(p);
                if (deger)
                {
                    MessageBox.Show("Personel Kaydedildi", "Kaydet", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    dataGridView1.DataSource = PersonellerORM.Personeller();
                    Tables.DataGridViewPersoneller(dataGridView1);
                }
                else MessageBox.Show("Personel Kaydedilirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"HATA",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        /// <summary>
        /// Seçilen Bilgileri Güncellemek İçin Kullanılır
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                try
                {
                    PersonellerORM pORM = new PersonellerORM();
                    Personeller p = new Personeller();
                    p.PersonelId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                    p.TipID = (int)cboYetki.SelectedValue;
                    p.Adi = txtAdi.Text;
                    p.Soyadi = txtSoyadi.Text;
                    p.Unvani = txtGorevi.Text;
                    p.KAdi = txtKullaniciAdi.Text;
                    p.Sifre = txtSifre.Text;
                    bool deger = pORM.KullaniciDüzenle(p);
                    if (deger)
                    {
                        MessageBox.Show("Personel Güncellendi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Clear();
                        dataGridView1.DataSource = PersonellerORM.Personeller();
                        Tables.DataGridViewPersoneller(dataGridView1);
                    }
                    else MessageBox.Show("Personel Güncellenirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message, "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } 
            }
            else MessageBox.Show("Lütfen Personel Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        /// <summary>
        /// DatagridView Seçilen Bilgiyi Siler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count != 0)
            {
                PersonellerORM pORM = new PersonellerORM();
                Personeller p = new Personeller();
                p.PersonelId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                bool deger = pORM.KullaniciSil(p);
                if (deger)
                {
                    MessageBox.Show("Personel Silindi", "Güncelle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridView1.DataSource = PersonellerORM.Personeller();
                    Tables.DataGridViewPersoneller(dataGridView1);
                }
                else MessageBox.Show("Personel Silinirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Lütfen Personel Seçiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Stop);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Bilgiler();
        }
    }
}
