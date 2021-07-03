using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class UrunListesi : Form
    {

        public UrunListesi()
        {
            InitializeComponent();

        }

        private void kAPATToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms["UrunEkle"]== null)
            {
                UrunEkle ue = new UrunEkle
                {
                    MdiParent = this.MdiParent
                };
                ue.Show(); 
            }
        }

        /// <summary>
        /// Form Açılışında Ürünlerin Listelenmesini Sağlar
        /// </summary>
        public void UrunListele()
        {
            UrunlerORM uORM = new UrunlerORM();
            dataGridView1.DataSource = UrunlerORM.UrunListesi();
            Tables.DataGridViewUrunListe(dataGridView1);
        }

        private void UrunListesi_Load(object sender, EventArgs e)
        {
            UrunListele();
        }

        private void sİLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id =(int) dataGridView1.CurrentRow.Cells[0].Value;
            bool urunsil=UrunlerORM.UrunSil(id);
            if (urunsil)
            {
                MessageBox.Show("Ürün Silindi", "Ürün Silme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UrunListele();
            }
            else MessageBox.Show("Ürün Silinirken Sorun Oluştu", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dÜZENLEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount != 0)
            {
                Urunler u = new Urunler();
                u.UrunId = (int)dataGridView1.CurrentRow.Cells[0].Value;
                u.BarkodNo = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                u.UrunAdi = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                u.KalanStok =(int) dataGridView1.CurrentRow.Cells[5].Value;
                u.SatisFiyati = (decimal)dataGridView1.CurrentRow.Cells[6].Value;
                u.AlisFiyati = (decimal)dataGridView1.CurrentRow.Cells[7].Value;
                u.Birim = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                u.Stok = (int)dataGridView1.CurrentRow.Cells[9].Value;
                u.SKTarih =(DateTime) dataGridView1.CurrentRow.Cells[11].Value;

                if (Application.OpenForms["UrunDuzenle"] == null)
                {
                    UrunDuzenle ud = new UrunDuzenle(u)
                    {
                        MdiParent = this.MdiParent
                    };
                    ud.Show();
                }

            }
        
        }

        private void uRUNADINAGÖREARAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            UrunArama ua = new UrunArama(u);
            ua.Text = "ÜRÜN ADINA GÖRE ARAMA";
            ua.Show();
        }

        private void bARKODToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Urunler u = new Urunler();
            UrunArama ua = new UrunArama(u);
            ua.Text = "BARKODA GÖRE ARAMA";
            ua.Show();
        }
    }
}
