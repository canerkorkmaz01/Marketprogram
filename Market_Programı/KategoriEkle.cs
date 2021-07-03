using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class KategoriEkle : Form
    {
        public KategoriEkle()
        {
            InitializeComponent();
        }

        private void KategoriEkle_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = KategoriORM.KategoriGetir();
            Tables.DataGridViewKategori(dataGridView1);
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Kategoriler k = new Kategoriler();
            k.KategoriAdi = txtKategoriAdi.Text;
            k.Kdv = txtKdv.Text;
            bool deger = KategoriORM.KategoriEkle(k);
            if (deger)
            {
                KategoriEkle_Load(null, null);
            }
            else MessageBox.Show("Kategori Kaydedilemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnYeni_Click(object sender, EventArgs e)
        {
            txtKategoriAdi.Text = string.Empty;
            txtKdv.Text = string.Empty;
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            if (txtKategoriAdi.Text != string.Empty && txtKdv.Text != string.Empty)
            {
                int id = (int)dataGridView1.CurrentRow.Cells[0].Value;
                Kategoriler k = new Kategoriler();
                k.KategoriId = id;
                k.KategoriAdi = txtKategoriAdi.Text;
                k.Kdv = txtKdv.Text;
                bool deger = KategoriORM.KategorGuncelle(k);
                if (deger)
                {
                    KategoriEkle_Load(null, null);
                }
                else MessageBox.Show("Kategori Güncelleştirilirken Hata Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
            else MessageBox.Show("Kategori Adı ve KDV Boş Geçilemez", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}
