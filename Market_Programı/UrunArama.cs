using Entity;
using ORM;
using System;
using System.Windows.Forms;
using Table;

namespace Market_Programı
{
    public partial class UrunArama : Form
    {
        private Urunler urun;
        public UrunArama(Urunler u)
        {
            urun = u;
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            if (txtAra.Text != string.Empty)
            {
                if (this.Text == "ÜRÜN ADINA GÖRE ARAMA")
                {
                    urun.UrunAdi = txtAra.Text;
                    UrunListesi ul = (UrunListesi)Application.OpenForms["UrunListesi"];
                    ul.dataGridView1.DataSource = UrunlerORM.AdGoreUrunArama(urun);
                    Tables.DataGridViewUrunListe(ul.dataGridView1);
                }
                else if(this.Text == "BARKODA GÖRE ARAMA")
                {
                    urun.BarkodNo = txtAra.Text;
                    UrunListesi ul = (UrunListesi)Application.OpenForms["UrunListesi"];
                    ul.dataGridView1.DataSource = UrunlerORM.BarkodGoreUrunArama(urun);
                    Tables.DataGridViewUrunListe(ul.dataGridView1);
                }
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
